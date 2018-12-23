using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Методы
        enum ResultClick
        {
            None,
            Change,
            Delete,
            Other
        }

        private ResultClick ResultCellContenClick(DataGridViewCellEventArgs e, DataGridView dataGridView, string message)
        {
            if (e.ColumnIndex == dataGridView.ColumnCount - 1)
            {
                var deleteDiaolg = MessageBox.Show(message, "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    return ResultClick.Delete;
                }
                return ResultClick.None;
            }
            if (e.ColumnIndex == dataGridView.ColumnCount - 2)
            {
                return ResultClick.Change;
            }
            return ResultClick.Other;
        }

        private void ChangeCursor(DataGridViewCellEventArgs e, DataGridView dataGridView)
        {
            dataGridView.Cursor = e.ColumnIndex > dataGridView.ColumnCount - 3 ? Cursors.Hand : Cursors.Default;
        }

        /*private void RegistrySaveChanges()
        {
            Validate();
            RegistryBindingSource.EndEdit();
            RegistryTableAdapter.Update(polyDataSet);
            RegistryViewTableAdapter.Fill(polyDataSet.СписокРегистратуры);
        }

        private void CardSaveChanges()
        {
            Validate();
            CardBindingSource.EndEdit();
            CardTableAdapter.Update(polyDataSet);
            CardViewTableAdapter.Fill(polyDataSet.СхемаЛечения);
        }

        private void DoctorSaveChanges()
        {
            Validate();
            DoctorBindingSource.EndEdit();
            DoctorTableAdapter.Update(polyDataSet);
        }

        private void DiagnosesSaveChanges()
        {
            Validate();
            DiagnosesBindingSource.EndEdit();
            DiagnosesTableAdapter.Update(polyDataSet);
        }

        private void SpecialtySaveChanges()
        {
            Validate();
            SpecialtyBindingSource.EndEdit();
            SpecialtyTableAdapter.Update(polyDataSet);
        }

        private void SaveChanges(BindingSource bindingSource)
        {
            Validate();
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(polyDataSet);
        }*/

        public void ChangeDisplayElements(DataGridView dataGrid, Button button, Panel panel, bool show)
        {
            if (show)
            {
                dataGrid.Visible = true;
                button.Visible = true;
                panel.Visible = false;
            }
            else
            {
                dataGrid.Visible = false;
                button.Visible = false;
                panel.Visible = true;
            }
        }

        public void EnableDisplayElements(bool enable)
        {
            if (enable)
            {
                ControlBox = true;
                ((Control)tabPage2).Enabled = true;
                ((Control)tabPage3).Enabled = true;
                ((Control)tabPage4).Enabled = true;
            }
            else
            {
                ControlBox = false;
                ((Control)tabPage2).Enabled = false;
                ((Control)tabPage3).Enabled = false;
                ((Control)tabPage4).Enabled = false;
            }
        }

        private void EnableDisplayElements(DataGridView dataGridView, Button button, Panel panel, bool show)
        {
            if (show)
            {
                dataGridView.Enabled = true;
                dataGridView.Height = 608;
                button.Visible = true;
                panel.Visible = false;
            }
            else
            {
                dataGridView.Enabled = false;
                dataGridView.Height = 460;
                button.Visible = false;
                panel.Visible = true;
            }
        }

        /*private void ExportInExcel(DataGridView dataGridView)
        {
            try
            {
                WaitForm waitForm = new WaitForm();
                waitForm.Show();

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dataGridView.ColumnCount - 2; i++)
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
            }
        }*/
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Остатки". При необходимости она может быть перемещена или удалена.
            this.BalanceTableAdapter.Fill(this.stockDataSet.Остатки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Таксировка". При необходимости она может быть перемещена или удалена.
            this.TaxingTableAdapter.Fill(this.stockDataSet.Таксировка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Налоги". При необходимости она может быть перемещена или удалена.
            this.TaxTableAdapter.Fill(this.stockDataSet.Налоги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Банк". При необходимости она может быть перемещена или удалена.
            this.BankTableAdapter.Fill(this.stockDataSet.Банк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Организация". При необходимости она может быть перемещена или удалена.
            this.OrganizationTableAdapter.Fill(this.stockDataSet.Организация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Накладные". При необходимости она может быть перемещена или удалена.
            this.InvoiceTableAdapter.Fill(this.stockDataSet.Накладные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Движение_товара". При необходимости она может быть перемещена или удалена.
            this.MoveProductTableAdapter.Fill(this.stockDataSet.Движение_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Подразделения". При необходимости она может быть перемещена или удалена.
            this.DivisionsTableAdapter.Fill(this.stockDataSet.Подразделения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.ProductTableAdapter.Fill(this.stockDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Категории_товара". При необходимости она может быть перемещена или удалена.
            this.CategoryTableAdapter.Fill(this.stockDataSet.Категории_товара);
        }
    }
}
