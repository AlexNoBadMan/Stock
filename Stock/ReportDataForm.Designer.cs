namespace Stock
{
    partial class ReportDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_категории_товараLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label5;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListProductsChooseButton = new System.Windows.Forms.Button();
            this.ListProductsComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new Stock.StockDataSet();
            this.tableAdapterManager = new Stock.StockDataSetTableAdapters.TableAdapterManager();
            this.CategoryTableAdapter = new Stock.StockDataSetTableAdapters.Категории_товараTableAdapter();
            this.ListProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ListProductsPanel = new System.Windows.Forms.Panel();
            this.ListProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.кодКатегорииТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ListProductsTableAdapter = new Stock.StockDataSetTableAdapters.Пречень_товаровTableAdapter();
            this.WealthGroupBox = new System.Windows.Forms.GroupBox();
            this.WealthDataGridView = new System.Windows.Forms.DataGridView();
            this.номерСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКладовщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоВещейНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материальныхЦенностейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WealthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WealthTableAdapter = new Stock.StockDataSetTableAdapters.Материальные_ценностиTableAdapter();
            this.ShippedGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShippedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ShippedChooseButton = new System.Windows.Forms.Button();
            this.ShippedComboBox = new System.Windows.Forms.ComboBox();
            this.DivisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShippedDataGridView = new System.Windows.Forms.DataGridView();
            this.кодСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКатегорииТовараDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулТовараDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShippedTableAdapter = new Stock.StockDataSetTableAdapters.Отгруженные_товарыTableAdapter();
            this.DivisionsTableAdapter = new Stock.StockDataSetTableAdapters.ПодразделенияTableAdapter();
            this.TOOGroupBox = new System.Windows.Forms.GroupBox();
            this.TOODataGridView = new System.Windows.Forms.DataGridView();
            this.рННОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОРуководителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TOOTableAdapter = new Stock.StockDataSetTableAdapters.ТОО_поставившая_товарTableAdapter();
            this.ListOrganizationsGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListOrganizationsButton = new System.Windows.Forms.Button();
            this.ListOrganizationsComboBox = new System.Windows.Forms.ComboBox();
            this.ListOrganizationsDataGridView = new System.Windows.Forms.DataGridView();
            this.рННОрганизацииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКатегорииТовараDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулТовараDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименвоаниеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListOrganizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListOrganizationsTableAdapter = new Stock.StockDataSetTableAdapters.Организации_поставившие_товарTableAdapter();
            this.TrafficReportGroupBox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TrafficReportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TrafficReportButton = new System.Windows.Forms.Button();
            this.TrafficReportComboBox = new System.Windows.Forms.ComboBox();
            this.TrafficReportDataGridView = new System.Windows.Forms.DataGridView();
            this.датаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСкладаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСкладаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.признакТипаНакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrafficReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrafficReportTableAdapter = new Stock.StockDataSetTableAdapters.Отчет_по_движению_товаровTableAdapter();
            this.BalanceReportGroupBox = new System.Windows.Forms.GroupBox();
            this.BalanceReportDataGridView = new System.Windows.Forms.DataGridView();
            this.BalanceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BalanceReportTableAdapter = new Stock.StockDataSetTableAdapters.Отчет_остатки_товаровTableAdapter();
            this.кодКатегорииТовараDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулТовараDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остатокНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.средняяЦенаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaybillReportGroupBox = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WaybillReportButton = new System.Windows.Forms.Button();
            this.WaybillReportComboBox = new System.Windows.Forms.ComboBox();
            this.WaybillReportDataGridView = new System.Windows.Forms.DataGridView();
            this.WaybillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WaybillTableAdapter = new Stock.StockDataSetTableAdapters.НакладныеTableAdapter();
            this.WaybillReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WaybillReportTableAdapter = new Stock.StockDataSetTableAdapters.Отчет_накладныеTableAdapter();
            this.датаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерНакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.признакТипаНакладнойDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОРуководителяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСкладаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКладовщикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_категории_товараLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            this.ListProductsGroupBox.SuspendLayout();
            this.ListProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductsBindingSource)).BeginInit();
            this.WealthGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WealthDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WealthBindingSource)).BeginInit();
            this.ShippedGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippedBindingSource)).BeginInit();
            this.TOOGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TOODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOOBindingSource)).BeginInit();
            this.ListOrganizationsGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrganizationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrganizationsBindingSource)).BeginInit();
            this.TrafficReportGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficReportBindingSource)).BeginInit();
            this.BalanceReportGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceReportBindingSource)).BeginInit();
            this.WaybillReportGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaybillReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaybillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaybillReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_категории_товараLabel
            // 
            код_категории_товараLabel.AutoSize = true;
            код_категории_товараLabel.Location = new System.Drawing.Point(32, 43);
            код_категории_товараLabel.Name = "код_категории_товараLabel";
            код_категории_товараLabel.Size = new System.Drawing.Size(204, 20);
            код_категории_товараLabel.TabIndex = 0;
            код_категории_товараLabel.Text = "Код категории товара:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(100, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Склад:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(100, 58);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(57, 20);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(103, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Товар:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(100, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Дата:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(100, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Склад:";
            // 
            // ListProductsChooseButton
            // 
            this.ListProductsChooseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListProductsChooseButton.Location = new System.Drawing.Point(190, 85);
            this.ListProductsChooseButton.Name = "ListProductsChooseButton";
            this.ListProductsChooseButton.Size = new System.Drawing.Size(165, 32);
            this.ListProductsChooseButton.TabIndex = 2;
            this.ListProductsChooseButton.Text = "Выбрать";
            this.ListProductsChooseButton.UseVisualStyleBackColor = true;
            this.ListProductsChooseButton.Click += new System.EventHandler(this.ListProductsChooseButton_Click);
            // 
            // ListProductsComboBox
            // 
            this.ListProductsComboBox.DataSource = this.CategoryBindingSource;
            this.ListProductsComboBox.DisplayMember = "Наименование категории";
            this.ListProductsComboBox.FormattingEnabled = true;
            this.ListProductsComboBox.Location = new System.Drawing.Point(242, 40);
            this.ListProductsComboBox.Name = "ListProductsComboBox";
            this.ListProductsComboBox.Size = new System.Drawing.Size(258, 28);
            this.ListProductsComboBox.TabIndex = 1;
            this.ListProductsComboBox.ValueMember = "Код категории товара";
            // 
            // CategoryBindingSource
            // 
            this.CategoryBindingSource.DataMember = "Категории товара";
            this.CategoryBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Stock.StockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БанкTableAdapter = null;
            this.tableAdapterManager.Движение_товараTableAdapter = null;
            this.tableAdapterManager.Категории_товараTableAdapter = this.CategoryTableAdapter;
            this.tableAdapterManager.НакладныеTableAdapter = null;
            this.tableAdapterManager.НалогиTableAdapter = null;
            this.tableAdapterManager.ОрганизацияTableAdapter = null;
            this.tableAdapterManager.ОстаткиTableAdapter = null;
            this.tableAdapterManager.ПодразделенияTableAdapter = null;
            this.tableAdapterManager.ТаксировкаTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // CategoryTableAdapter
            // 
            this.CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // ListProductsGroupBox
            // 
            this.ListProductsGroupBox.Controls.Add(this.ListProductsPanel);
            this.ListProductsGroupBox.Controls.Add(this.ListProductsDataGridView);
            this.ListProductsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ListProductsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ListProductsGroupBox.Name = "ListProductsGroupBox";
            this.ListProductsGroupBox.Size = new System.Drawing.Size(984, 647);
            this.ListProductsGroupBox.TabIndex = 3;
            this.ListProductsGroupBox.TabStop = false;
            this.ListProductsGroupBox.Text = "Перечень товаров «i-ой» категории, имеющихся на складе, стоимость которых колебле" +
    "тся в интервале от 4000 до 5000 тенге";
            this.ListProductsGroupBox.Visible = false;
            // 
            // ListProductsPanel
            // 
            this.ListProductsPanel.Controls.Add(this.ListProductsChooseButton);
            this.ListProductsPanel.Controls.Add(код_категории_товараLabel);
            this.ListProductsPanel.Controls.Add(this.ListProductsComboBox);
            this.ListProductsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ListProductsPanel.Location = new System.Drawing.Point(207, 25);
            this.ListProductsPanel.Name = "ListProductsPanel";
            this.ListProductsPanel.Size = new System.Drawing.Size(538, 131);
            this.ListProductsPanel.TabIndex = 0;
            // 
            // ListProductsDataGridView
            // 
            this.ListProductsDataGridView.AllowUserToAddRows = false;
            this.ListProductsDataGridView.AllowUserToDeleteRows = false;
            this.ListProductsDataGridView.AutoGenerateColumns = false;
            this.ListProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКатегорииТовараDataGridViewTextBoxColumn,
            this.артикулТовараDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.ListProductsDataGridView.DataSource = this.ListProductsBindingSource;
            this.ListProductsDataGridView.EnableHeadersVisualStyles = false;
            this.ListProductsDataGridView.Location = new System.Drawing.Point(4, 162);
            this.ListProductsDataGridView.Name = "ListProductsDataGridView";
            this.ListProductsDataGridView.ReadOnly = true;
            this.ListProductsDataGridView.RowHeadersVisible = false;
            this.ListProductsDataGridView.Size = new System.Drawing.Size(974, 479);
            this.ListProductsDataGridView.TabIndex = 0;
            // 
            // кодКатегорииТовараDataGridViewTextBoxColumn
            // 
            this.кодКатегорииТовараDataGridViewTextBoxColumn.DataPropertyName = "Код категории товара";
            this.кодКатегорииТовараDataGridViewTextBoxColumn.HeaderText = "Код категории товара";
            this.кодКатегорииТовараDataGridViewTextBoxColumn.Name = "кодКатегорииТовараDataGridViewTextBoxColumn";
            this.кодКатегорииТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // артикулТовараDataGridViewTextBoxColumn
            // 
            this.артикулТовараDataGridViewTextBoxColumn.DataPropertyName = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn.HeaderText = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn.Name = "артикулТовараDataGridViewTextBoxColumn";
            this.артикулТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.Name = "количествоНаСкладеDataGridViewTextBoxColumn";
            this.количествоНаСкладеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListProductsBindingSource
            // 
            this.ListProductsBindingSource.DataMember = "Пречень товаров";
            this.ListProductsBindingSource.DataSource = this.stockDataSet;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CloseButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseButton.Location = new System.Drawing.Point(796, 665);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(200, 32);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ExportButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportButton.Location = new System.Drawing.Point(590, 665);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(200, 32);
            this.ExportButton.TabIndex = 18;
            this.ExportButton.Text = "Экспортировать";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ListProductsTableAdapter
            // 
            this.ListProductsTableAdapter.ClearBeforeFill = true;
            // 
            // WealthGroupBox
            // 
            this.WealthGroupBox.Controls.Add(this.WealthDataGridView);
            this.WealthGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.WealthGroupBox.Location = new System.Drawing.Point(12, 12);
            this.WealthGroupBox.Name = "WealthGroupBox";
            this.WealthGroupBox.Size = new System.Drawing.Size(984, 647);
            this.WealthGroupBox.TabIndex = 4;
            this.WealthGroupBox.TabStop = false;
            this.WealthGroupBox.Text = "Стоимость материальных ценностей, хранящихся на каждом из складов";
            this.WealthGroupBox.Visible = false;
            // 
            // WealthDataGridView
            // 
            this.WealthDataGridView.AllowUserToAddRows = false;
            this.WealthDataGridView.AllowUserToDeleteRows = false;
            this.WealthDataGridView.AutoGenerateColumns = false;
            this.WealthDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.WealthDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WealthDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WealthDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерСкладаDataGridViewTextBoxColumn,
            this.наименованиеСкладаDataGridViewTextBoxColumn,
            this.фИОКладовщикаDataGridViewTextBoxColumn,
            this.количествоВещейНаСкладеDataGridViewTextBoxColumn,
            this.материальныхЦенностейDataGridViewTextBoxColumn});
            this.WealthDataGridView.DataSource = this.WealthBindingSource;
            this.WealthDataGridView.EnableHeadersVisualStyles = false;
            this.WealthDataGridView.Location = new System.Drawing.Point(4, 25);
            this.WealthDataGridView.Name = "WealthDataGridView";
            this.WealthDataGridView.ReadOnly = true;
            this.WealthDataGridView.RowHeadersVisible = false;
            this.WealthDataGridView.Size = new System.Drawing.Size(974, 616);
            this.WealthDataGridView.TabIndex = 0;
            // 
            // номерСкладаDataGridViewTextBoxColumn
            // 
            this.номерСкладаDataGridViewTextBoxColumn.DataPropertyName = "Номер склада";
            this.номерСкладаDataGridViewTextBoxColumn.HeaderText = "Номер склада";
            this.номерСкладаDataGridViewTextBoxColumn.Name = "номерСкладаDataGridViewTextBoxColumn";
            this.номерСкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеСкладаDataGridViewTextBoxColumn
            // 
            this.наименованиеСкладаDataGridViewTextBoxColumn.DataPropertyName = "Наименование склада";
            this.наименованиеСкладаDataGridViewTextBoxColumn.HeaderText = "Наименование склада";
            this.наименованиеСкладаDataGridViewTextBoxColumn.Name = "наименованиеСкладаDataGridViewTextBoxColumn";
            this.наименованиеСкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОКладовщикаDataGridViewTextBoxColumn
            // 
            this.фИОКладовщикаDataGridViewTextBoxColumn.DataPropertyName = "ФИО кладовщика";
            this.фИОКладовщикаDataGridViewTextBoxColumn.HeaderText = "ФИО кладовщика";
            this.фИОКладовщикаDataGridViewTextBoxColumn.Name = "фИОКладовщикаDataGridViewTextBoxColumn";
            this.фИОКладовщикаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоВещейНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоВещейНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество вещей на складе";
            this.количествоВещейНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество вещей на складе";
            this.количествоВещейНаСкладеDataGridViewTextBoxColumn.Name = "количествоВещейНаСкладеDataGridViewTextBoxColumn";
            this.количествоВещейНаСкладеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // материальныхЦенностейDataGridViewTextBoxColumn
            // 
            this.материальныхЦенностейDataGridViewTextBoxColumn.DataPropertyName = "Материальных ценностей";
            this.материальныхЦенностейDataGridViewTextBoxColumn.HeaderText = "Материальных ценностей";
            this.материальныхЦенностейDataGridViewTextBoxColumn.Name = "материальныхЦенностейDataGridViewTextBoxColumn";
            this.материальныхЦенностейDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WealthBindingSource
            // 
            this.WealthBindingSource.DataMember = "Материальные ценности";
            this.WealthBindingSource.DataSource = this.stockDataSet;
            // 
            // WealthTableAdapter
            // 
            this.WealthTableAdapter.ClearBeforeFill = true;
            // 
            // ShippedGroupBox
            // 
            this.ShippedGroupBox.Controls.Add(this.panel1);
            this.ShippedGroupBox.Controls.Add(this.ShippedDataGridView);
            this.ShippedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ShippedGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ShippedGroupBox.Name = "ShippedGroupBox";
            this.ShippedGroupBox.Size = new System.Drawing.Size(984, 647);
            this.ShippedGroupBox.TabIndex = 20;
            this.ShippedGroupBox.TabStop = false;
            this.ShippedGroupBox.Text = "Список товаров, отгруженных с «i-го» склада на «j-ю» дата";
            this.ShippedGroupBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(датаLabel);
            this.panel1.Controls.Add(this.ShippedDateTimePicker);
            this.panel1.Controls.Add(this.ShippedChooseButton);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.ShippedComboBox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.panel1.Location = new System.Drawing.Point(207, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 137);
            this.panel1.TabIndex = 0;
            // 
            // ShippedDateTimePicker
            // 
            this.ShippedDateTimePicker.Location = new System.Drawing.Point(173, 53);
            this.ShippedDateTimePicker.Name = "ShippedDateTimePicker";
            this.ShippedDateTimePicker.Size = new System.Drawing.Size(258, 26);
            this.ShippedDateTimePicker.TabIndex = 4;
            this.ShippedDateTimePicker.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // ShippedChooseButton
            // 
            this.ShippedChooseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShippedChooseButton.Location = new System.Drawing.Point(190, 96);
            this.ShippedChooseButton.Name = "ShippedChooseButton";
            this.ShippedChooseButton.Size = new System.Drawing.Size(165, 32);
            this.ShippedChooseButton.TabIndex = 2;
            this.ShippedChooseButton.Text = "Выбрать";
            this.ShippedChooseButton.UseVisualStyleBackColor = true;
            this.ShippedChooseButton.Click += new System.EventHandler(this.ShippedChooseButton_Click);
            // 
            // ShippedComboBox
            // 
            this.ShippedComboBox.DataSource = this.DivisionsBindingSource;
            this.ShippedComboBox.DisplayMember = "Номер склада";
            this.ShippedComboBox.FormattingEnabled = true;
            this.ShippedComboBox.Location = new System.Drawing.Point(173, 16);
            this.ShippedComboBox.Name = "ShippedComboBox";
            this.ShippedComboBox.Size = new System.Drawing.Size(258, 28);
            this.ShippedComboBox.TabIndex = 1;
            this.ShippedComboBox.ValueMember = "Номер склада";
            // 
            // DivisionsBindingSource
            // 
            this.DivisionsBindingSource.DataMember = "Подразделения";
            this.DivisionsBindingSource.DataSource = this.stockDataSet;
            // 
            // ShippedDataGridView
            // 
            this.ShippedDataGridView.AllowUserToAddRows = false;
            this.ShippedDataGridView.AllowUserToDeleteRows = false;
            this.ShippedDataGridView.AutoGenerateColumns = false;
            this.ShippedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ShippedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ShippedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShippedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСкладаDataGridViewTextBoxColumn,
            this.кодКатегорииТовараDataGridViewTextBoxColumn1,
            this.артикулТовараDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.количествоТовараDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.ShippedDataGridView.DataSource = this.ShippedBindingSource;
            this.ShippedDataGridView.EnableHeadersVisualStyles = false;
            this.ShippedDataGridView.Location = new System.Drawing.Point(4, 162);
            this.ShippedDataGridView.Name = "ShippedDataGridView";
            this.ShippedDataGridView.ReadOnly = true;
            this.ShippedDataGridView.RowHeadersVisible = false;
            this.ShippedDataGridView.Size = new System.Drawing.Size(974, 479);
            this.ShippedDataGridView.TabIndex = 0;
            // 
            // кодСкладаDataGridViewTextBoxColumn
            // 
            this.кодСкладаDataGridViewTextBoxColumn.DataPropertyName = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.HeaderText = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.Name = "кодСкладаDataGridViewTextBoxColumn";
            this.кодСкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодКатегорииТовараDataGridViewTextBoxColumn1
            // 
            this.кодКатегорииТовараDataGridViewTextBoxColumn1.DataPropertyName = "Код категории товара";
            this.кодКатегорииТовараDataGridViewTextBoxColumn1.HeaderText = "Код категории товара";
            this.кодКатегорииТовараDataGridViewTextBoxColumn1.Name = "кодКатегорииТовараDataGridViewTextBoxColumn1";
            this.кодКатегорииТовараDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // артикулТовараDataGridViewTextBoxColumn1
            // 
            this.артикулТовараDataGridViewTextBoxColumn1.DataPropertyName = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn1.HeaderText = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn1.Name = "артикулТовараDataGridViewTextBoxColumn1";
            this.артикулТовараDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            this.наименованиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // количествоТовараDataGridViewTextBoxColumn
            // 
            this.количествоТовараDataGridViewTextBoxColumn.DataPropertyName = "Количество товара";
            this.количествоТовараDataGridViewTextBoxColumn.HeaderText = "Количество товара";
            this.количествоТовараDataGridViewTextBoxColumn.Name = "количествоТовараDataGridViewTextBoxColumn";
            this.количествоТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ShippedBindingSource
            // 
            this.ShippedBindingSource.DataMember = "Отгруженные товары";
            this.ShippedBindingSource.DataSource = this.stockDataSet;
            // 
            // ShippedTableAdapter
            // 
            this.ShippedTableAdapter.ClearBeforeFill = true;
            // 
            // DivisionsTableAdapter
            // 
            this.DivisionsTableAdapter.ClearBeforeFill = true;
            // 
            // TOOGroupBox
            // 
            this.TOOGroupBox.Controls.Add(this.TOODataGridView);
            this.TOOGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TOOGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TOOGroupBox.Name = "TOOGroupBox";
            this.TOOGroupBox.Size = new System.Drawing.Size(984, 647);
            this.TOOGroupBox.TabIndex = 21;
            this.TOOGroupBox.TabStop = false;
            this.TOOGroupBox.Text = "Список организаций поставивших товары в текущем году в названии которых есть слов" +
    "о «ТОО»";
            this.TOOGroupBox.Visible = false;
            // 
            // TOODataGridView
            // 
            this.TOODataGridView.AllowUserToAddRows = false;
            this.TOODataGridView.AllowUserToDeleteRows = false;
            this.TOODataGridView.AutoGenerateColumns = false;
            this.TOODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TOODataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TOODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TOODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.рННОрганизацииDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn2,
            this.адресDataGridViewTextBoxColumn,
            this.фИОРуководителяDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.TOODataGridView.DataSource = this.TOOBindingSource;
            this.TOODataGridView.EnableHeadersVisualStyles = false;
            this.TOODataGridView.Location = new System.Drawing.Point(4, 25);
            this.TOODataGridView.Name = "TOODataGridView";
            this.TOODataGridView.ReadOnly = true;
            this.TOODataGridView.RowHeadersVisible = false;
            this.TOODataGridView.Size = new System.Drawing.Size(974, 616);
            this.TOODataGridView.TabIndex = 0;
            // 
            // рННОрганизацииDataGridViewTextBoxColumn
            // 
            this.рННОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "РНН организации";
            this.рННОрганизацииDataGridViewTextBoxColumn.HeaderText = "РНН организации";
            this.рННОрганизацииDataGridViewTextBoxColumn.Name = "рННОрганизацииDataGridViewTextBoxColumn";
            this.рННОрганизацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn2
            // 
            this.наименованиеDataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn2.Name = "наименованиеDataGridViewTextBoxColumn2";
            this.наименованиеDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОРуководителяDataGridViewTextBoxColumn
            // 
            this.фИОРуководителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО руководителя";
            this.фИОРуководителяDataGridViewTextBoxColumn.HeaderText = "ФИО руководителя";
            this.фИОРуководителяDataGridViewTextBoxColumn.Name = "фИОРуководителяDataGridViewTextBoxColumn";
            this.фИОРуководителяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TOOBindingSource
            // 
            this.TOOBindingSource.DataMember = "ТОО поставившая товар";
            this.TOOBindingSource.DataSource = this.stockDataSet;
            // 
            // TOOTableAdapter
            // 
            this.TOOTableAdapter.ClearBeforeFill = true;
            // 
            // ListOrganizationsGroupBox
            // 
            this.ListOrganizationsGroupBox.Controls.Add(this.panel2);
            this.ListOrganizationsGroupBox.Controls.Add(this.ListOrganizationsDataGridView);
            this.ListOrganizationsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ListOrganizationsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ListOrganizationsGroupBox.Name = "ListOrganizationsGroupBox";
            this.ListOrganizationsGroupBox.Size = new System.Drawing.Size(984, 647);
            this.ListOrganizationsGroupBox.TabIndex = 22;
            this.ListOrganizationsGroupBox.TabStop = false;
            this.ListOrganizationsGroupBox.Text = "Перечень организаций, поставляющих «I-ый» товар";
            this.ListOrganizationsGroupBox.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListOrganizationsButton);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.ListOrganizationsComboBox);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.panel2.Location = new System.Drawing.Point(207, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 131);
            this.panel2.TabIndex = 0;
            // 
            // ListOrganizationsButton
            // 
            this.ListOrganizationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListOrganizationsButton.Location = new System.Drawing.Point(190, 85);
            this.ListOrganizationsButton.Name = "ListOrganizationsButton";
            this.ListOrganizationsButton.Size = new System.Drawing.Size(165, 32);
            this.ListOrganizationsButton.TabIndex = 2;
            this.ListOrganizationsButton.Text = "Выбрать";
            this.ListOrganizationsButton.UseVisualStyleBackColor = true;
            this.ListOrganizationsButton.Click += new System.EventHandler(this.ListOrganizationsButton_Click);
            // 
            // ListOrganizationsComboBox
            // 
            this.ListOrganizationsComboBox.DataSource = this.ListProductsBindingSource;
            this.ListOrganizationsComboBox.DisplayMember = "Артикул товара";
            this.ListOrganizationsComboBox.FormattingEnabled = true;
            this.ListOrganizationsComboBox.Location = new System.Drawing.Point(173, 40);
            this.ListOrganizationsComboBox.Name = "ListOrganizationsComboBox";
            this.ListOrganizationsComboBox.Size = new System.Drawing.Size(258, 28);
            this.ListOrganizationsComboBox.TabIndex = 1;
            this.ListOrganizationsComboBox.ValueMember = "Артикул товара";
            // 
            // ListOrganizationsDataGridView
            // 
            this.ListOrganizationsDataGridView.AllowUserToAddRows = false;
            this.ListOrganizationsDataGridView.AllowUserToDeleteRows = false;
            this.ListOrganizationsDataGridView.AutoGenerateColumns = false;
            this.ListOrganizationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListOrganizationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListOrganizationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOrganizationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.рННОрганизацииDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn3,
            this.кодКатегорииТовараDataGridViewTextBoxColumn2,
            this.артикулТовараDataGridViewTextBoxColumn2,
            this.наименвоаниеТовараDataGridViewTextBoxColumn});
            this.ListOrganizationsDataGridView.DataSource = this.ListOrganizationsBindingSource;
            this.ListOrganizationsDataGridView.EnableHeadersVisualStyles = false;
            this.ListOrganizationsDataGridView.Location = new System.Drawing.Point(4, 162);
            this.ListOrganizationsDataGridView.Name = "ListOrganizationsDataGridView";
            this.ListOrganizationsDataGridView.ReadOnly = true;
            this.ListOrganizationsDataGridView.RowHeadersVisible = false;
            this.ListOrganizationsDataGridView.Size = new System.Drawing.Size(974, 479);
            this.ListOrganizationsDataGridView.TabIndex = 0;
            // 
            // рННОрганизацииDataGridViewTextBoxColumn1
            // 
            this.рННОрганизацииDataGridViewTextBoxColumn1.DataPropertyName = "РНН организации";
            this.рННОрганизацииDataGridViewTextBoxColumn1.HeaderText = "РНН организации";
            this.рННОрганизацииDataGridViewTextBoxColumn1.Name = "рННОрганизацииDataGridViewTextBoxColumn1";
            this.рННОрганизацииDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn3
            // 
            this.наименованиеDataGridViewTextBoxColumn3.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn3.Name = "наименованиеDataGridViewTextBoxColumn3";
            this.наименованиеDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // кодКатегорииТовараDataGridViewTextBoxColumn2
            // 
            this.кодКатегорииТовараDataGridViewTextBoxColumn2.DataPropertyName = "Код категории товара";
            this.кодКатегорииТовараDataGridViewTextBoxColumn2.HeaderText = "Код категории товара";
            this.кодКатегорииТовараDataGridViewTextBoxColumn2.Name = "кодКатегорииТовараDataGridViewTextBoxColumn2";
            this.кодКатегорииТовараDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // артикулТовараDataGridViewTextBoxColumn2
            // 
            this.артикулТовараDataGridViewTextBoxColumn2.DataPropertyName = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn2.HeaderText = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn2.Name = "артикулТовараDataGridViewTextBoxColumn2";
            this.артикулТовараDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // наименвоаниеТовараDataGridViewTextBoxColumn
            // 
            this.наименвоаниеТовараDataGridViewTextBoxColumn.DataPropertyName = "Наименвоание товара";
            this.наименвоаниеТовараDataGridViewTextBoxColumn.HeaderText = "Наименвоание товара";
            this.наименвоаниеТовараDataGridViewTextBoxColumn.Name = "наименвоаниеТовараDataGridViewTextBoxColumn";
            this.наименвоаниеТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListOrganizationsBindingSource
            // 
            this.ListOrganizationsBindingSource.DataMember = "Организации поставившие товар";
            this.ListOrganizationsBindingSource.DataSource = this.stockDataSet;
            // 
            // ListOrganizationsTableAdapter
            // 
            this.ListOrganizationsTableAdapter.ClearBeforeFill = true;
            // 
            // TrafficReportGroupBox
            // 
            this.TrafficReportGroupBox.Controls.Add(this.panel3);
            this.TrafficReportGroupBox.Controls.Add(this.TrafficReportDataGridView);
            this.TrafficReportGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TrafficReportGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TrafficReportGroupBox.Name = "TrafficReportGroupBox";
            this.TrafficReportGroupBox.Size = new System.Drawing.Size(984, 647);
            this.TrafficReportGroupBox.TabIndex = 23;
            this.TrafficReportGroupBox.TabStop = false;
            this.TrafficReportGroupBox.Text = "Отчет по движению товаров на «I-ом» складе за «j-е» число (подсчитав и стоимость " +
    "товара)";
            this.TrafficReportGroupBox.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(this.TrafficReportDateTimePicker);
            this.panel3.Controls.Add(this.TrafficReportButton);
            this.panel3.Controls.Add(label4);
            this.panel3.Controls.Add(this.TrafficReportComboBox);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.panel3.Location = new System.Drawing.Point(207, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 137);
            this.panel3.TabIndex = 0;
            // 
            // TrafficReportDateTimePicker
            // 
            this.TrafficReportDateTimePicker.Location = new System.Drawing.Point(173, 53);
            this.TrafficReportDateTimePicker.Name = "TrafficReportDateTimePicker";
            this.TrafficReportDateTimePicker.Size = new System.Drawing.Size(258, 26);
            this.TrafficReportDateTimePicker.TabIndex = 4;
            this.TrafficReportDateTimePicker.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // TrafficReportButton
            // 
            this.TrafficReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrafficReportButton.Location = new System.Drawing.Point(190, 96);
            this.TrafficReportButton.Name = "TrafficReportButton";
            this.TrafficReportButton.Size = new System.Drawing.Size(165, 32);
            this.TrafficReportButton.TabIndex = 2;
            this.TrafficReportButton.Text = "Выбрать";
            this.TrafficReportButton.UseVisualStyleBackColor = true;
            this.TrafficReportButton.Click += new System.EventHandler(this.TrafficReportButton_Click);
            // 
            // TrafficReportComboBox
            // 
            this.TrafficReportComboBox.DataSource = this.DivisionsBindingSource;
            this.TrafficReportComboBox.DisplayMember = "Номер склада";
            this.TrafficReportComboBox.FormattingEnabled = true;
            this.TrafficReportComboBox.Location = new System.Drawing.Point(173, 16);
            this.TrafficReportComboBox.Name = "TrafficReportComboBox";
            this.TrafficReportComboBox.Size = new System.Drawing.Size(258, 28);
            this.TrafficReportComboBox.TabIndex = 1;
            this.TrafficReportComboBox.ValueMember = "Номер склада";
            // 
            // TrafficReportDataGridView
            // 
            this.TrafficReportDataGridView.AllowUserToAddRows = false;
            this.TrafficReportDataGridView.AllowUserToDeleteRows = false;
            this.TrafficReportDataGridView.AutoGenerateColumns = false;
            this.TrafficReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TrafficReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TrafficReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrafficReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn1,
            this.кодСкладаDataGridViewTextBoxColumn1,
            this.наименованиеСкладаDataGridViewTextBoxColumn1,
            this.признакТипаНакладнойDataGridViewTextBoxColumn,
            this.стоимостьТовараDataGridViewTextBoxColumn});
            this.TrafficReportDataGridView.DataSource = this.TrafficReportBindingSource;
            this.TrafficReportDataGridView.EnableHeadersVisualStyles = false;
            this.TrafficReportDataGridView.Location = new System.Drawing.Point(4, 162);
            this.TrafficReportDataGridView.Name = "TrafficReportDataGridView";
            this.TrafficReportDataGridView.ReadOnly = true;
            this.TrafficReportDataGridView.RowHeadersVisible = false;
            this.TrafficReportDataGridView.Size = new System.Drawing.Size(974, 479);
            this.TrafficReportDataGridView.TabIndex = 0;
            // 
            // датаDataGridViewTextBoxColumn1
            // 
            this.датаDataGridViewTextBoxColumn1.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn1.Name = "датаDataGridViewTextBoxColumn1";
            this.датаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кодСкладаDataGridViewTextBoxColumn1
            // 
            this.кодСкладаDataGridViewTextBoxColumn1.DataPropertyName = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn1.HeaderText = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn1.Name = "кодСкладаDataGridViewTextBoxColumn1";
            this.кодСкладаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // наименованиеСкладаDataGridViewTextBoxColumn1
            // 
            this.наименованиеСкладаDataGridViewTextBoxColumn1.DataPropertyName = "Наименование склада";
            this.наименованиеСкладаDataGridViewTextBoxColumn1.HeaderText = "Наименование склада";
            this.наименованиеСкладаDataGridViewTextBoxColumn1.Name = "наименованиеСкладаDataGridViewTextBoxColumn1";
            this.наименованиеСкладаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // признакТипаНакладнойDataGridViewTextBoxColumn
            // 
            this.признакТипаНакладнойDataGridViewTextBoxColumn.DataPropertyName = "Признак типа накладной";
            this.признакТипаНакладнойDataGridViewTextBoxColumn.HeaderText = "Признак типа накладной";
            this.признакТипаНакладнойDataGridViewTextBoxColumn.Name = "признакТипаНакладнойDataGridViewTextBoxColumn";
            this.признакТипаНакладнойDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьТовараDataGridViewTextBoxColumn
            // 
            this.стоимостьТовараDataGridViewTextBoxColumn.DataPropertyName = "Стоимость товара";
            this.стоимостьТовараDataGridViewTextBoxColumn.HeaderText = "Стоимость товара";
            this.стоимостьТовараDataGridViewTextBoxColumn.Name = "стоимостьТовараDataGridViewTextBoxColumn";
            this.стоимостьТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TrafficReportBindingSource
            // 
            this.TrafficReportBindingSource.DataMember = "Отчет по движению товаров";
            this.TrafficReportBindingSource.DataSource = this.stockDataSet;
            // 
            // TrafficReportTableAdapter
            // 
            this.TrafficReportTableAdapter.ClearBeforeFill = true;
            // 
            // BalanceReportGroupBox
            // 
            this.BalanceReportGroupBox.Controls.Add(this.BalanceReportDataGridView);
            this.BalanceReportGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BalanceReportGroupBox.Location = new System.Drawing.Point(12, 12);
            this.BalanceReportGroupBox.Name = "BalanceReportGroupBox";
            this.BalanceReportGroupBox.Size = new System.Drawing.Size(984, 647);
            this.BalanceReportGroupBox.TabIndex = 24;
            this.BalanceReportGroupBox.TabStop = false;
            this.BalanceReportGroupBox.Text = "Отчет остатки товаров на конец месяца и их стоимость по средней цене";
            this.BalanceReportGroupBox.Visible = false;
            // 
            // BalanceReportDataGridView
            // 
            this.BalanceReportDataGridView.AllowUserToAddRows = false;
            this.BalanceReportDataGridView.AllowUserToDeleteRows = false;
            this.BalanceReportDataGridView.AutoGenerateColumns = false;
            this.BalanceReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BalanceReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.BalanceReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BalanceReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКатегорииТовараDataGridViewTextBoxColumn3,
            this.артикулТовараDataGridViewTextBoxColumn3,
            this.наименованиеDataGridViewTextBoxColumn4,
            this.остатокНаСкладеDataGridViewTextBoxColumn,
            this.средняяЦенаDataGridViewTextBoxColumn});
            this.BalanceReportDataGridView.DataSource = this.BalanceReportBindingSource;
            this.BalanceReportDataGridView.EnableHeadersVisualStyles = false;
            this.BalanceReportDataGridView.Location = new System.Drawing.Point(4, 25);
            this.BalanceReportDataGridView.Name = "BalanceReportDataGridView";
            this.BalanceReportDataGridView.ReadOnly = true;
            this.BalanceReportDataGridView.RowHeadersVisible = false;
            this.BalanceReportDataGridView.Size = new System.Drawing.Size(974, 616);
            this.BalanceReportDataGridView.TabIndex = 0;
            // 
            // BalanceReportBindingSource
            // 
            this.BalanceReportBindingSource.DataMember = "Отчет остатки товаров";
            this.BalanceReportBindingSource.DataSource = this.stockDataSet;
            // 
            // BalanceReportTableAdapter
            // 
            this.BalanceReportTableAdapter.ClearBeforeFill = true;
            // 
            // кодКатегорииТовараDataGridViewTextBoxColumn3
            // 
            this.кодКатегорииТовараDataGridViewTextBoxColumn3.DataPropertyName = "Код категории товара";
            this.кодКатегорииТовараDataGridViewTextBoxColumn3.HeaderText = "Код категории товара";
            this.кодКатегорииТовараDataGridViewTextBoxColumn3.Name = "кодКатегорииТовараDataGridViewTextBoxColumn3";
            this.кодКатегорииТовараDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // артикулТовараDataGridViewTextBoxColumn3
            // 
            this.артикулТовараDataGridViewTextBoxColumn3.DataPropertyName = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn3.HeaderText = "Артикул товара";
            this.артикулТовараDataGridViewTextBoxColumn3.Name = "артикулТовараDataGridViewTextBoxColumn3";
            this.артикулТовараDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn4
            // 
            this.наименованиеDataGridViewTextBoxColumn4.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn4.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn4.Name = "наименованиеDataGridViewTextBoxColumn4";
            this.наименованиеDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // остатокНаСкладеDataGridViewTextBoxColumn
            // 
            this.остатокНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Остаток на складе";
            this.остатокНаСкладеDataGridViewTextBoxColumn.HeaderText = "Остаток на складе";
            this.остатокНаСкладеDataGridViewTextBoxColumn.Name = "остатокНаСкладеDataGridViewTextBoxColumn";
            this.остатокНаСкладеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // средняяЦенаDataGridViewTextBoxColumn
            // 
            this.средняяЦенаDataGridViewTextBoxColumn.DataPropertyName = "Средняя цена";
            this.средняяЦенаDataGridViewTextBoxColumn.HeaderText = "Средняя цена";
            this.средняяЦенаDataGridViewTextBoxColumn.Name = "средняяЦенаDataGridViewTextBoxColumn";
            this.средняяЦенаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WaybillReportGroupBox
            // 
            this.WaybillReportGroupBox.Controls.Add(this.panel4);
            this.WaybillReportGroupBox.Controls.Add(this.WaybillReportDataGridView);
            this.WaybillReportGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.WaybillReportGroupBox.Location = new System.Drawing.Point(12, 12);
            this.WaybillReportGroupBox.Name = "WaybillReportGroupBox";
            this.WaybillReportGroupBox.Size = new System.Drawing.Size(984, 647);
            this.WaybillReportGroupBox.TabIndex = 25;
            this.WaybillReportGroupBox.TabStop = false;
            this.WaybillReportGroupBox.Text = "«I-я» накладная";
            this.WaybillReportGroupBox.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.WaybillReportButton);
            this.panel4.Controls.Add(label5);
            this.panel4.Controls.Add(this.WaybillReportComboBox);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.panel4.Location = new System.Drawing.Point(207, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 131);
            this.panel4.TabIndex = 0;
            // 
            // WaybillReportButton
            // 
            this.WaybillReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WaybillReportButton.Location = new System.Drawing.Point(190, 85);
            this.WaybillReportButton.Name = "WaybillReportButton";
            this.WaybillReportButton.Size = new System.Drawing.Size(165, 32);
            this.WaybillReportButton.TabIndex = 2;
            this.WaybillReportButton.Text = "Выбрать";
            this.WaybillReportButton.UseVisualStyleBackColor = true;
            this.WaybillReportButton.Click += new System.EventHandler(this.WaybillReportButton_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(86, 43);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 20);
            label5.TabIndex = 0;
            label5.Text = "Накладная:";
            // 
            // WaybillReportComboBox
            // 
            this.WaybillReportComboBox.DataSource = this.WaybillBindingSource;
            this.WaybillReportComboBox.DisplayMember = "Номер накладной";
            this.WaybillReportComboBox.FormattingEnabled = true;
            this.WaybillReportComboBox.Location = new System.Drawing.Point(200, 40);
            this.WaybillReportComboBox.Name = "WaybillReportComboBox";
            this.WaybillReportComboBox.Size = new System.Drawing.Size(258, 28);
            this.WaybillReportComboBox.TabIndex = 1;
            this.WaybillReportComboBox.ValueMember = "Номер накладной";
            // 
            // WaybillReportDataGridView
            // 
            this.WaybillReportDataGridView.AllowUserToAddRows = false;
            this.WaybillReportDataGridView.AllowUserToDeleteRows = false;
            this.WaybillReportDataGridView.AutoGenerateColumns = false;
            this.WaybillReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.WaybillReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.WaybillReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaybillReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn2,
            this.номерНакладнойDataGridViewTextBoxColumn,
            this.признакТипаНакладнойDataGridViewTextBoxColumn1,
            this.наименованиеОрганизацииDataGridViewTextBoxColumn,
            this.фИОРуководителяDataGridViewTextBoxColumn1,
            this.телефонDataGridViewTextBoxColumn1,
            this.наименованиеСкладаDataGridViewTextBoxColumn2,
            this.фИОКладовщикаDataGridViewTextBoxColumn1});
            this.WaybillReportDataGridView.DataSource = this.WaybillReportBindingSource;
            this.WaybillReportDataGridView.EnableHeadersVisualStyles = false;
            this.WaybillReportDataGridView.Location = new System.Drawing.Point(4, 162);
            this.WaybillReportDataGridView.Name = "WaybillReportDataGridView";
            this.WaybillReportDataGridView.ReadOnly = true;
            this.WaybillReportDataGridView.RowHeadersVisible = false;
            this.WaybillReportDataGridView.Size = new System.Drawing.Size(974, 479);
            this.WaybillReportDataGridView.TabIndex = 0;
            // 
            // WaybillBindingSource
            // 
            this.WaybillBindingSource.DataMember = "Накладные";
            this.WaybillBindingSource.DataSource = this.stockDataSet;
            // 
            // WaybillTableAdapter
            // 
            this.WaybillTableAdapter.ClearBeforeFill = true;
            // 
            // WaybillReportBindingSource
            // 
            this.WaybillReportBindingSource.DataMember = "Отчет накладные";
            this.WaybillReportBindingSource.DataSource = this.stockDataSet;
            // 
            // WaybillReportTableAdapter
            // 
            this.WaybillReportTableAdapter.ClearBeforeFill = true;
            // 
            // датаDataGridViewTextBoxColumn2
            // 
            this.датаDataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn2.Name = "датаDataGridViewTextBoxColumn2";
            this.датаDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // номерНакладнойDataGridViewTextBoxColumn
            // 
            this.номерНакладнойDataGridViewTextBoxColumn.DataPropertyName = "Номер накладной";
            this.номерНакладнойDataGridViewTextBoxColumn.HeaderText = "Номер накладной";
            this.номерНакладнойDataGridViewTextBoxColumn.Name = "номерНакладнойDataGridViewTextBoxColumn";
            this.номерНакладнойDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // признакТипаНакладнойDataGridViewTextBoxColumn1
            // 
            this.признакТипаНакладнойDataGridViewTextBoxColumn1.DataPropertyName = "Признак типа накладной";
            this.признакТипаНакладнойDataGridViewTextBoxColumn1.HeaderText = "Признак типа накладной";
            this.признакТипаНакладнойDataGridViewTextBoxColumn1.Name = "признакТипаНакладнойDataGridViewTextBoxColumn1";
            this.признакТипаНакладнойDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // наименованиеОрганизацииDataGridViewTextBoxColumn
            // 
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "Наименование организации";
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.HeaderText = "Наименование организации";
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.Name = "наименованиеОрганизацииDataGridViewTextBoxColumn";
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОРуководителяDataGridViewTextBoxColumn1
            // 
            this.фИОРуководителяDataGridViewTextBoxColumn1.DataPropertyName = "ФИО руководителя";
            this.фИОРуководителяDataGridViewTextBoxColumn1.HeaderText = "ФИО руководителя";
            this.фИОРуководителяDataGridViewTextBoxColumn1.Name = "фИОРуководителяDataGridViewTextBoxColumn1";
            this.фИОРуководителяDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn1
            // 
            this.телефонDataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.Name = "телефонDataGridViewTextBoxColumn1";
            this.телефонDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // наименованиеСкладаDataGridViewTextBoxColumn2
            // 
            this.наименованиеСкладаDataGridViewTextBoxColumn2.DataPropertyName = "Наименование склада";
            this.наименованиеСкладаDataGridViewTextBoxColumn2.HeaderText = "Наименование склада";
            this.наименованиеСкладаDataGridViewTextBoxColumn2.Name = "наименованиеСкладаDataGridViewTextBoxColumn2";
            this.наименованиеСкладаDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // фИОКладовщикаDataGridViewTextBoxColumn1
            // 
            this.фИОКладовщикаDataGridViewTextBoxColumn1.DataPropertyName = "ФИО кладовщика";
            this.фИОКладовщикаDataGridViewTextBoxColumn1.HeaderText = "ФИО кладовщика";
            this.фИОКладовщикаDataGridViewTextBoxColumn1.Name = "фИОКладовщикаDataGridViewTextBoxColumn1";
            this.фИОКладовщикаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ReportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 709);
            this.Controls.Add(this.WaybillReportGroupBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ListOrganizationsGroupBox);
            this.Controls.Add(this.ListProductsGroupBox);
            this.Controls.Add(this.BalanceReportGroupBox);
            this.Controls.Add(this.TOOGroupBox);
            this.Controls.Add(this.WealthGroupBox);
            this.Controls.Add(this.TrafficReportGroupBox);
            this.Controls.Add(this.ShippedGroupBox);
            this.Name = "ReportDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportDataForm";
            this.Load += new System.EventHandler(this.ReportDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.ListProductsGroupBox.ResumeLayout(false);
            this.ListProductsPanel.ResumeLayout(false);
            this.ListProductsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductsBindingSource)).EndInit();
            this.WealthGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WealthDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WealthBindingSource)).EndInit();
            this.ShippedGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippedBindingSource)).EndInit();
            this.TOOGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TOODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOOBindingSource)).EndInit();
            this.ListOrganizationsGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrganizationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrganizationsBindingSource)).EndInit();
            this.TrafficReportGroupBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficReportBindingSource)).EndInit();
            this.BalanceReportGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BalanceReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceReportBindingSource)).EndInit();
            this.WaybillReportGroupBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaybillReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaybillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaybillReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StockDataSet stockDataSet;
        private StockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ListProductsComboBox;
        private StockDataSetTableAdapters.Категории_товараTableAdapter CategoryTableAdapter;
        private System.Windows.Forms.BindingSource CategoryBindingSource;
        private System.Windows.Forms.Button ListProductsChooseButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.BindingSource ListProductsBindingSource;
        private StockDataSetTableAdapters.Пречень_товаровTableAdapter ListProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        internal System.Windows.Forms.GroupBox ListProductsGroupBox;
        private System.Windows.Forms.DataGridView ListProductsDataGridView;
        private System.Windows.Forms.Panel ListProductsPanel;
        internal System.Windows.Forms.GroupBox WealthGroupBox;
        private System.Windows.Forms.DataGridView WealthDataGridView;
        private System.Windows.Forms.BindingSource WealthBindingSource;
        private StockDataSetTableAdapters.Материальные_ценностиTableAdapter WealthTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКладовщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВещейНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материальныхЦенностейDataGridViewTextBoxColumn;
        internal System.Windows.Forms.GroupBox ShippedGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShippedChooseButton;
        private System.Windows.Forms.ComboBox ShippedComboBox;
        private System.Windows.Forms.DataGridView ShippedDataGridView;
        private System.Windows.Forms.BindingSource ShippedBindingSource;
        private StockDataSetTableAdapters.Отгруженные_товарыTableAdapter ShippedTableAdapter;
        private System.Windows.Forms.DateTimePicker ShippedDateTimePicker;
        private System.Windows.Forms.BindingSource DivisionsBindingSource;
        private StockDataSetTableAdapters.ПодразделенияTableAdapter DivisionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииТовараDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулТовараDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        internal System.Windows.Forms.GroupBox TOOGroupBox;
        private System.Windows.Forms.DataGridView TOODataGridView;
        private System.Windows.Forms.BindingSource TOOBindingSource;
        private StockDataSetTableAdapters.ТОО_поставившая_товарTableAdapter TOOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn рННОрганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОРуководителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        internal System.Windows.Forms.GroupBox ListOrganizationsGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ListOrganizationsButton;
        private System.Windows.Forms.ComboBox ListOrganizationsComboBox;
        private System.Windows.Forms.DataGridView ListOrganizationsDataGridView;
        private System.Windows.Forms.BindingSource ListOrganizationsBindingSource;
        private StockDataSetTableAdapters.Организации_поставившие_товарTableAdapter ListOrganizationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn рННОрганизацииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииТовараDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулТовараDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименвоаниеТовараDataGridViewTextBoxColumn;
        internal System.Windows.Forms.GroupBox TrafficReportGroupBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker TrafficReportDateTimePicker;
        private System.Windows.Forms.Button TrafficReportButton;
        private System.Windows.Forms.ComboBox TrafficReportComboBox;
        private System.Windows.Forms.DataGridView TrafficReportDataGridView;
        private System.Windows.Forms.BindingSource TrafficReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСкладаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСкладаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn признакТипаНакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьТовараDataGridViewTextBoxColumn;
        private StockDataSetTableAdapters.Отчет_по_движению_товаровTableAdapter TrafficReportTableAdapter;
        internal System.Windows.Forms.GroupBox BalanceReportGroupBox;
        private System.Windows.Forms.DataGridView BalanceReportDataGridView;
        private System.Windows.Forms.BindingSource BalanceReportBindingSource;
        private StockDataSetTableAdapters.Отчет_остатки_товаровTableAdapter BalanceReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииТовараDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулТовараDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn остатокНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn средняяЦенаDataGridViewTextBoxColumn;
        internal System.Windows.Forms.GroupBox WaybillReportGroupBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button WaybillReportButton;
        private System.Windows.Forms.ComboBox WaybillReportComboBox;
        private System.Windows.Forms.DataGridView WaybillReportDataGridView;
        private System.Windows.Forms.BindingSource WaybillBindingSource;
        private StockDataSetTableAdapters.НакладныеTableAdapter WaybillTableAdapter;
        private System.Windows.Forms.BindingSource WaybillReportBindingSource;
        private StockDataSetTableAdapters.Отчет_накладныеTableAdapter WaybillReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерНакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn признакТипаНакладнойDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОрганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОРуководителяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСкладаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКладовщикаDataGridViewTextBoxColumn1;
    }
}