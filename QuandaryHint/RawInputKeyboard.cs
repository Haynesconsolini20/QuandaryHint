using RawInput_dll;


namespace QuandaryHint
{
    class RawInputKeyboard
    {
        bool ctrl;
        bool shift;
        RawInputEventArg e;
        static char[] shiftNumberRow = ")!@#$%^&*(".ToCharArray();
        static char[] miscChars = "`-=[]\\;',./".ToCharArray();
        static int[] miscKeys = { 192, 189, 187, 219, 221, 220, 186, 222, 188, 190, 191 };
        static char[] shiftMiscChars = "~_+{}|:\"<>?".ToCharArray();
        public string processed;
        int vKey;
        bool make;
        public string source;

        public RawInputKeyboard()
        {
            ctrl = false;
            shift = false;
            processed = "void";
        }

        public void ProcessInput(RawInputEventArg raw)
        {
            e = raw;
            vKey = e.KeyPressEvent.VKey;
            source = e.KeyPressEvent.Source;

            if (e.KeyPressEvent.KeyPressState == "MAKE")
                make = true;
            else
                make = false;
            

            if (make)
            {
                if (vKey >= 65 && vKey <= 90)
                {
                    ProcessLetters();
                }
                else if (vKey >= 48 && vKey <= 57)
                {
                    ProcessNumbers();
                }
                else if (vKey > 100)
                {
                    ProcessCharacters();
                }
                if (vKey == 16 || vKey == 17)
                {
                    ProcessModifiers();
                }
                else
                {
                    ProcessSpecial();
                }
            }
            if (!make)
            {
                if (vKey == 16)
                    shift = false;
                if (vKey == 17)
                    ctrl = false;

                processed = "void";
            }


           
        }

        public bool OutputReady()
        {
            if (processed == "void")
                return false;
            else
                return true;
        }
        
        private void ProcessLetters()
        {
            char letter = (char)vKey;
            if (shift)
            {
                processed = letter.ToString();
            }
            else
            {
                processed = letter.ToString().ToLower();
            }

            if (ctrl)
            {
                processed = "CTRL" + processed;
            }
        }

        private void ProcessNumbers()
        {
            if (shift)
            {
                int index = vKey - 48;
                processed = shiftNumberRow[index].ToString();
            }
            else
            {
                char num = (char)vKey;
                processed = num.ToString();
            }

        }

        private void ProcessCharacters()
        {
            int index = 0;
            for (int i = 0; i < 11; i++)
            {
                if (vKey == miscKeys[i])
                {
                    index = i;
                }
            }

            if (shift)
            {
                processed = shiftMiscChars[index].ToString();
            }
            else
            {
                processed = miscChars[index].ToString();
            }

        }

        private void ProcessModifiers()
        {
            if (vKey == 16)
                shift = true;
            if (vKey == 17)
                ctrl = true;
        }

        private void ProcessSpecial()
        {
            if (vKey == 32)
                processed = "SPACE";
            if (vKey == 8)
                processed = "BACKSPACE";
            if (vKey == 13)
            {
                if (shift)
                    processed = "SHIFTenter";
                else
                    processed = "ENTER";
            }
                
        }

        
    }
}
