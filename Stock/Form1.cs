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

        private void товарBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stockDataSet);

        }

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

        private void категории_товараBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.CategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stockDataSet);

        }
    }
}
