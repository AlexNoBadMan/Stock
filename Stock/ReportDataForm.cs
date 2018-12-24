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
    public partial class ReportDataForm : Form
    {
        public ReportDataForm()
        {
            InitializeComponent();
        }
        public byte ReportId { get; set; }
        /*public StateReport resultReport;

        public enum StateReport
        {
            Close,
            GoReport
        }*/

        private void ReportDataForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Отчет_накладные". При необходимости она может быть перемещена или удалена.
            this.WaybillReportTableAdapter.Fill(this.stockDataSet.Отчет_накладные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Накладные". При необходимости она может быть перемещена или удалена.
            this.WaybillTableAdapter.Fill(this.stockDataSet.Накладные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.Отчет_остатки_товаров". При необходимости она может быть перемещена или удалена.
            this.BalanceReportTableAdapter.Fill(this.stockDataSet.Отчет_остатки_товаров);
            TrafficReportTableAdapter.Fill(stockDataSet.Отчет_по_движению_товаров);
            ListOrganizationsTableAdapter.Fill(stockDataSet.Организации_поставившие_товар);
            TOOTableAdapter.Fill(stockDataSet.ТОО_поставившая_товар);
            DivisionsTableAdapter.Fill(stockDataSet.Подразделения);
            ShippedTableAdapter.Fill(stockDataSet.Отгруженные_товары);
            WealthTableAdapter.Fill(stockDataSet.Материальные_ценности);
            ListProductsTableAdapter.Fill(stockDataSet.Пречень_товаров);
            CategoryTableAdapter.Fill(stockDataSet.Категории_товара);
        }

        private void ListProductsChooseButton_Click(object sender, EventArgs e)
        {
            ListProductsBindingSource.Filter = $"[Код категории товара] = {ListProductsComboBox.SelectedValue}";
        }

        private void ShippedChooseButton_Click(object sender, EventArgs e)
        {
            ShippedBindingSource.Filter = $"[Код склада] = {ShippedComboBox.SelectedValue} AND Дата = '{ShippedDateTimePicker.Value:yyyy-MM-dd}'";
        }

        private void ListOrganizationsButton_Click(object sender, EventArgs e)
        {
            ListOrganizationsBindingSource.Filter = $"[Артикул товара] = {ListOrganizationsComboBox.SelectedValue}";
        }

        private void TrafficReportButton_Click(object sender, EventArgs e)
        {
            TrafficReportBindingSource.Filter = $"[Код склада] = {TrafficReportComboBox.SelectedValue} AND Дата = '{TrafficReportDateTimePicker.Value:yyyy-MM-dd}'";
        }

        private void WaybillReportButton_Click(object sender, EventArgs e)
        {
            WaybillReportBindingSource.Filter = $"[Номер накладной] = {WaybillReportComboBox.SelectedValue}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            //var controls = (this.Controls.GetType() == typeof(DataGridView));
            var export = new Export();
            switch (ReportId)
            {
                case 0: export.ExportInExcel(ListProductsDataGridView); break;
                case 1: export.ExportInExcel(WealthDataGridView); break;
                case 2: export.ExportInExcel(ShippedDataGridView); break;
                case 3: export.ExportInExcel(TOODataGridView); break;
                case 4: export.ExportInExcel(ListOrganizationsDataGridView); break;
                case 5: export.ExportInExcel(TrafficReportDataGridView); break;
                case 6: export.ExportInExcel(BalanceReportDataGridView); break;
                case 7: export.ExportInExcel(WaybillReportDataGridView); break;

            default: MessageBox.Show("Ошибка выбора отчета.", "Ошибка!"); break;
            }
             
                
            
        }
    }
}
