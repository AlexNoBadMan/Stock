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

        /*private ResultClick ResultCellContenClick(DataGridViewCellEventArgs e, DataGridView dataGridView)
        {
            if (e.ColumnIndex == dataGridView.ColumnCount - 1)
            {
                var deleteDiaolg = MessageBox.Show("Вы действительно хотите удалить данные из таблицы", "Внимание!", MessageBoxButtons.YesNo);
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
        }*/

        private void SaveChanges(BindingSource bindingSource)
        {
            Validate();
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(stockDataSet);
        }

        private void CellClickHide(DataGridViewCellEventArgs e, DataGridView dataGridView, BindingSource bindingSource, Button button, Panel panel)
        {
            if (e.ColumnIndex == dataGridView.ColumnCount - 1)
            {
                var deleteDiaolg = MessageBox.Show("Вы действительно хотите удалить данные из таблицы", "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    dataGridView.Rows.RemoveAt(e.RowIndex);
                    SaveChanges(bindingSource);
                }
                return;
            }

            if (e.ColumnIndex == dataGridView.ColumnCount - 2)
            {
                HideDataGrid(dataGridView, button, panel);
            }
            return;
        }

        private void CellClickResize(DataGridViewCellEventArgs e, DataGridView dataGridView, BindingSource bindingSource, Button button, Panel panel)
        {
            if (e.ColumnIndex == dataGridView.ColumnCount - 1)
            {
                var deleteDiaolg = MessageBox.Show("Вы действительно хотите удалить данные из таблицы", "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    dataGridView.Rows.RemoveAt(e.RowIndex);
                    SaveChanges(bindingSource);
                }
                return;
            }

            if (e.ColumnIndex == dataGridView.ColumnCount - 2)
            {
                ReduceDataGrid(dataGridView, button, panel);
            }
            return;
        }

        private void ChangeCursor(DataGridViewCellEventArgs e, DataGridView dataGridView)
        {
            dataGridView.Cursor = e.ColumnIndex > dataGridView.ColumnCount - 3 ? Cursors.Hand : Cursors.Default;
        }

        private void HideDataGrid(DataGridView dataGrid, Button button, Panel panel)
        {
            dataGrid.Visible = false;
            button.Visible = false;
            panel.Visible = true;
        }

        private void ShowDataGrid(DataGridView dataGrid, Button button, Panel panel)
        {
            dataGrid.Visible = true;
            button.Visible = true;
            panel.Visible = false;
        }

        private void ReduceDataGrid(DataGridView dataGridView, Button button, Panel panel)
        {
            dataGridView.Enabled = false;
            dataGridView.Height = 372;
            button.Visible = false;
            panel.Visible = true;
        }

        private void EnlargeDataGrid(DataGridView dataGridView, Button button, Panel panel)
        {
            dataGridView.Enabled = true;
            dataGridView.Height = 608;
            button.Visible = true;
            panel.Visible = false;
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

        #region Работа с таблицей "Категории товара"
        private void CategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < CategoryDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickHide(e, CategoryDataGridView, CategoryBindingSource, CategoryAddButton, CategoryPanel);
        }

        private void CategoryDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, CategoryDataGridView);
        }

        private void CategoryAddButton_Click(object sender, EventArgs e)
        {
            CategoryBindingSource.AddNew();
            HideDataGrid(CategoryDataGridView, CategoryAddButton, CategoryPanel);
        }

        private void CategorySaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(CategoryBindingSource);
            ShowDataGrid(CategoryDataGridView, CategoryAddButton, CategoryPanel);
        }

        private void CategoryCancelButton_Click(object sender, EventArgs e)
        {
            CategoryBindingSource.CancelEdit();
            ShowDataGrid(CategoryDataGridView, CategoryAddButton, CategoryPanel);
        }
        #endregion

        #region Работа с таблицей "Товар"
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < ProductDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickHide(e, ProductDataGridView, ProductBindingSource, ProductAddButton, ProductPanel);
        }

        private void ProductDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, ProductDataGridView);
        }

        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            ProductBindingSource.AddNew();
            HideDataGrid(ProductDataGridView, ProductAddButton, ProductPanel);
        }

        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(ProductBindingSource);
            ShowDataGrid(ProductDataGridView, ProductAddButton, ProductPanel);
        }

        private void ProductCancelButton_Click(object sender, EventArgs e)
        {
            ProductBindingSource.CancelEdit();
            ShowDataGrid(ProductDataGridView, ProductAddButton, ProductPanel);
        }
        #endregion

        #region Работа с таблице "Подразделения"
        private void DivisionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < DivisionsDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickResize(e, DivisionsDataGridView, DivisionsBindingSource, DivisionsAddButton, DivisionsPanel);
        }

        private void DivisionsDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, DivisionsDataGridView);
        }

        private void DivisionsAddButton_Click(object sender, EventArgs e)
        {
            DivisionsBindingSource.AddNew();
            ReduceDataGrid(DivisionsDataGridView, DivisionsAddButton, DivisionsPanel);
        }

        private void DivisionsSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(DivisionsBindingSource);
            EnlargeDataGrid(DivisionsDataGridView, DivisionsAddButton, DivisionsPanel);
        }

        private void DivisionsCancelButton_Click(object sender, EventArgs e)
        {
            DivisionsBindingSource.CancelEdit();
            EnlargeDataGrid(DivisionsDataGridView, DivisionsAddButton, DivisionsPanel);
        }
        #endregion

        #region Работа с таблицей "Накладные"
        private void InvoiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < InvoiceDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickResize(e, InvoiceDataGridView, InvoiceBindingSource, InvoiceAddButton, InvoicePanel);
        }

        private void InvoiceDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, InvoiceDataGridView);
        }

        private void InvoiceAddButton_Click(object sender, EventArgs e)
        {
            InvoiceBindingSource.AddNew();
            ReduceDataGrid(InvoiceDataGridView, InvoiceAddButton, InvoicePanel);
        }

        private void InvoiceSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(InvoiceBindingSource);
            EnlargeDataGrid(InvoiceDataGridView, InvoiceAddButton, InvoicePanel);
        }

        private void InvoiceCancelButton_Click(object sender, EventArgs e)
        {
            InvoiceBindingSource.CancelEdit();
            EnlargeDataGrid(InvoiceDataGridView, InvoiceAddButton, InvoicePanel);
        }
        #endregion

        #region Работа с таблицей "Движения товара"
        private void MoveProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < MoveProductDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickResize(e, MoveProductDataGridView, MoveProductBindingSource, MoveProductAddButton, MoveProductPanel);
        }

        private void MoveProductDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, MoveProductDataGridView);
        }

        private void MoveProductAddButton_Click(object sender, EventArgs e)
        {
            MoveProductBindingSource.AddNew();
            ReduceDataGrid(MoveProductDataGridView, MoveProductAddButton, MoveProductPanel);
        }

        private void MoveProductSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(MoveProductBindingSource);
            EnlargeDataGrid(MoveProductDataGridView, MoveProductAddButton, MoveProductPanel);
        }

        private void MoveProductCancelButton_Click(object sender, EventArgs e)
        {
            MoveProductBindingSource.CancelEdit();
            EnlargeDataGrid(MoveProductDataGridView, MoveProductAddButton, MoveProductPanel);
        }

        #endregion

        #region Работа с таблицей "Организация"
        private void OrganizationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < OrganizationDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickResize(e, OrganizationDataGridView, OrganizationBindingSource, OrganizationAddButton, OrganizationPanel);
        }

        private void OrganizationDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, OrganizationDataGridView);
        }

        private void OrganizationAddButton_Click(object sender, EventArgs e)
        {
            OrganizationBindingSource.AddNew();
            ReduceDataGrid(OrganizationDataGridView, OrganizationAddButton, OrganizationPanel);
        }

        private void OrganizationSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(OrganizationBindingSource);
            EnlargeDataGrid(OrganizationDataGridView, OrganizationAddButton, OrganizationPanel);
        }

        private void OrganizationCancelButton_Click(object sender, EventArgs e)
        {
            OrganizationBindingSource.CancelEdit();
            EnlargeDataGrid(OrganizationDataGridView, OrganizationAddButton, OrganizationPanel);
        }
        #endregion

        #region Работа с таблицей "Банк"
        private void BankDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < BankDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickResize(e, BankDataGridView, BankBindingSource, BankAddButton, BankPanel);
        }

        private void BankDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, BankDataGridView);
        }

        private void BankAddButton_Click(object sender, EventArgs e)
        {
            BankBindingSource.AddNew();
            ReduceDataGrid(BankDataGridView, BankAddButton, BankPanel);
        }

        private void BankSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(BankBindingSource);
            EnlargeDataGrid(BankDataGridView, BankAddButton, BankPanel);
        }

        private void BankCancelButton_Click(object sender, EventArgs e)
        {
            BankBindingSource.CancelEdit();
            EnlargeDataGrid(BankDataGridView, BankAddButton, BankPanel);
        }
        #endregion

        #region Работа с таблицей "Налоги"
        private void TaxDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < TaxDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickResize(e, TaxDataGridView, TaxBindingSource, TaxAddButton, TaxPanel);
        }

        private void TaxDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, TaxDataGridView);
        }

        private void TaxAddButton_Click(object sender, EventArgs e)
        {
            TaxBindingSource.AddNew();
            ReduceDataGrid(TaxDataGridView, TaxAddButton, TaxPanel);
        }

        private void TaxSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(TaxBindingSource);
            EnlargeDataGrid(TaxDataGridView, TaxAddButton, TaxPanel);
        }

        private void TaxCancelButton_Click(object sender, EventArgs e)
        {
            TaxBindingSource.CancelEdit();
            EnlargeDataGrid(TaxDataGridView, TaxAddButton, TaxPanel);
        }
        #endregion

        #region Работа с таблицей "Таксировка"
        private void TaxingDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < TaxingDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickResize(e, TaxingDataGridView, TaxingBindingSource, TaxingAddButton, TaxingPanel);
        }

        private void TaxingDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, TaxingDataGridView);
        }

        private void TaxingAddButton_Click(object sender, EventArgs e)
        {
            TaxingBindingSource.AddNew();
            ReduceDataGrid(TaxingDataGridView, TaxingAddButton, TaxingPanel);
        }

        private void TaxingSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(TaxingBindingSource);
            EnlargeDataGrid(TaxingDataGridView, TaxingAddButton, TaxingPanel);
        }

        private void TaxingCancelButton_Click(object sender, EventArgs e)
        {
            TaxingBindingSource.CancelEdit();
            EnlargeDataGrid(TaxingDataGridView, TaxingAddButton, TaxingPanel);
        }
        #endregion

        #region Работа с таблицей "Остаток"
        private void BalanceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < BalanceDataGridView.ColumnCount - 2)
            {
                return;
            }

            CellClickResize(e, BalanceDataGridView, BalanceBindingSource, BalanceAddButton, BalancePanel);
        }

        private void BalanceDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, BalanceDataGridView);
        }

        private void BalanceAddButton_Click(object sender, EventArgs e)
        {
            BalanceBindingSource.AddNew();
            ReduceDataGrid(BalanceDataGridView, BalanceAddButton, BalancePanel);
        }

        private void BalanceSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(BalanceBindingSource);
            EnlargeDataGrid(BalanceDataGridView, BalanceAddButton, BalancePanel);
        }

        private void BalanceCancelButton_Click(object sender, EventArgs e)
        {
            BalanceBindingSource.CancelEdit();
            EnlargeDataGrid(BalanceDataGridView, BalanceAddButton, BalancePanel);
        }
        #endregion
    }
}
