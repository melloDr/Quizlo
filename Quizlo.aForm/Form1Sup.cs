using Quizlo.Data.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Collections.Generic;

namespace Quizlo.aForm
{
    public class Form1Sup
    {
        public static List<DataModel> GetData()
        {
            var result = new List<DataModel>();
            try
            {
                Excel.Application excelApp = new Excel.Application();
                string filePath = @"D:\Workspace\WinForm\Quizlo\Quizlo_v01\BookExam_v01.xlsx";
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                int rowCount = excelWorksheet.UsedRange.Rows.Count;
                int colCount = excelWorksheet.UsedRange.Columns.Count;

                for (int row = 2; row <= rowCount; row++)
                {
                    var dataModel = new DataModel();
                    dataModel.Id = new Guid();
                    dataModel.Word = (excelWorksheet.Cells[row, 1] as Excel.Range).Value.ToString();
                    dataModel.Mean = (excelWorksheet.Cells[row, 2] as Excel.Range).Value.ToString();
                    result.Add(dataModel);
                }
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        public static List<DataModel> RandomData(List<DataModel> listData)
        {
            var result = new List<DataModel>();
            try
            {
                if (listData.Count >= 4)
                {
                    Random random = new Random();
                    result = listData.OrderBy(x => random.Next()).Take(4).ToList();
                }else
                    MessageBox.Show("Từ không đủ để bắt đầu (Ít nhất là 4)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return result;
        }

        //public static bool checkAnswer(List<DataModel);
    }
}
