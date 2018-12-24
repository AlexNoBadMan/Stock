using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    class Export
    {
        public void ExportInExcelWithoutImage(DataGridView dataGridView)
        {
            WaitForm waitForm = new WaitForm();
            waitForm.Show();
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dataGridView.ColumnCount -2; i++)
                {
                    ExcelApp.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;

                    for (int j = 0; j < dataGridView.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = (dataGridView[i, j].Value).ToString();
                    }
                }
                ExcelApp.Columns.AutoFit();
                ExcelApp.Visible = true;

                waitForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка экспорта: " + ex.Message);
                waitForm.Close();
            }
        }

        public void ExportInExcel(DataGridView dataGridView)
        {
            WaitForm waitForm = new WaitForm();
            waitForm.Show();
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    ExcelApp.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;

                    for (int j = 0; j < dataGridView.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = (dataGridView[i, j].Value).ToString();
                    }
                }
                ExcelApp.Columns.AutoFit();
                ExcelApp.Visible = true;

                waitForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка экспорта: " + ex.Message);
                waitForm.Close();
            }
        }
    }
}
