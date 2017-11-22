using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace QuandaryHint
{
    class Excel
    {
        string path;
        public _Application excel = new _Excel.Application();

        public  Workbook wb;
        public  Worksheet ws;

        public int FirstEmptyRow;
        public int gameColumn;

        public Excel(string path, int sheet, int column)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
            gameColumn = column;
            FindFirstEmptyRow(column);
            excel.Visible = false;
        }

        ~Excel()
        {
            SaveAndQuit();
        }
        public string ReadCell(int row, int col)
        {
            if (ws.Cells[row, col].Value2 != null)
                return ws.Cells[row, col].Value2;
            else
                return "";
        }

        private void FindFirstEmptyRow(int column)
        {
            int row = 1;
            
            //Find the beginning of the listings
            while (ws.Cells[row, column].Value2 != "Date")
            {
                row++;
            }

            //keeep going until you find a blank row
            while (ws.Cells[row, column].Value2 != null)
                row++;

            FirstEmptyRow = row; 
        }

        public void WriteCell(int row, int col, string data)
        {
            ws.Cells[row, col] = data;
            Console.WriteLine("Wrote " + data + "\n");
           
           
        }

        public void AppendToDocument(int teamSize, string teamName, string escapeTime, bool escaped)
        {

            DateTime thisDay = DateTime.Today;
            WriteCell(FirstEmptyRow, gameColumn, thisDay.ToString("d"));
            
            WriteCell(FirstEmptyRow, gameColumn + 1, teamSize.ToString());
            WriteCell(FirstEmptyRow, gameColumn + 2, teamName);
            WriteCell(FirstEmptyRow, gameColumn + 3, escapeTime);

            string txt = (escaped) ? "Yes" : "No";
            WriteCell(FirstEmptyRow, gameColumn + 4, txt);

            FirstEmptyRow++;
        }

        public void SaveAndQuit()
        {
            wb.Save();
            excel.Workbooks.Close();
            excel.Quit();
            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(wb);
        }
    }
}
