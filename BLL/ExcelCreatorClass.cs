using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace FATCA.BLL
{
    public class ExcelCreatorClass
    {
        /// <summary>
        /// Example of function for this Class 
        /// ExcelCreatorFxn(dgDept, "D:\\testofExcel.xlsx");
        /// </summary>
        /// <param name="dataGridName"></param>
        /// <param name="ExcelFileName"></param>


        public void ExcelCreatorFxn(DataGridView dataGridName, string ExcelFileName)
        {
            try
            {
                // creating Excel Application
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.
                // store its reference to worksheet
              
                
                //  uncomment this part for xp 
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"]; // for framework less than 3.5 
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;


                // uncomment this part for .net 4 +
                //worksheet = workbook.Sheets["Sheet1"];
                //worksheet = workbook.ActiveSheet;

                // changing the name of active sheet
                worksheet.Name = "Fatca data download";
                // storing header part in Excel
                for (int i = 1; i < dataGridName.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridName.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet
                for (int i = 0; i < dataGridName.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridName.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridName.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application
                workbook.SaveAs(ExcelFileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application
                app.Quit();
                MessageBox.Show("Document created Succesfully, Please Check My documents on C Drive");
            }
            catch { MessageBox.Show("Excel Document Creation process Aborted."); }
        }
    }
}
