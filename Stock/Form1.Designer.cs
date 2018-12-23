namespace Stock
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stockDataSet = new Stock.StockDataSet();
            this.CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryTableAdapter = new Stock.StockDataSetTableAdapters.Категории_товараTableAdapter();
            this.tableAdapterManager = new Stock.StockDataSetTableAdapters.TableAdapterManager();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductTableAdapter = new Stock.StockDataSetTableAdapters.ТоварTableAdapter();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductGroupBox = new System.Windows.Forms.GroupBox();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DivisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DivisionsTableAdapter = new Stock.StockDataSetTableAdapters.ПодразделенияTableAdapter();
            this.DivisionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MoveProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MoveProductTableAdapter = new Stock.StockDataSetTableAdapters.Движение_товараTableAdapter();
            this.MoveProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceTableAdapter = new Stock.StockDataSetTableAdapters.НакладныеTableAdapter();
            this.InvoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.номерНакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.признакТипаНакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.OrganizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrganizationTableAdapter = new Stock.StockDataSetTableAdapters.ОрганизацияTableAdapter();
            this.OrganizationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.BankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankTableAdapter = new Stock.StockDataSetTableAdapters.БанкTableAdapter();
            this.BankDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.TaxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxTableAdapter = new Stock.StockDataSetTableAdapters.НалогиTableAdapter();
            this.TaxDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.TaxingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxingTableAdapter = new Stock.StockDataSetTableAdapters.ТаксировкаTableAdapter();
            this.TaxingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.BalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BalanceTableAdapter = new Stock.StockDataSetTableAdapters.ОстаткиTableAdapter();
            this.остаткиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.CategoryGroupBox.SuspendLayout();
            this.ProductGroupBox.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProductDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationDataGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataGridView)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxDataGridView)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxingDataGridView)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.остаткиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 18);
            this.tabControl1.Location = new System.Drawing.Point(4, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 680);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.ProductGroupBox);
            this.tabPage1.Controls.Add(this.CategoryGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DivisionsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подразделения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CategoryBindingSource
            // 
            this.CategoryBindingSource.DataMember = "Категории товара";
            this.CategoryBindingSource.DataSource = this.stockDataSet;
            // 
            // CategoryTableAdapter
            // 
            this.CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Stock.StockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БанкTableAdapter = this.BankTableAdapter;
            this.tableAdapterManager.Движение_товараTableAdapter = this.MoveProductTableAdapter;
            this.tableAdapterManager.Категории_товараTableAdapter = this.CategoryTableAdapter;
            this.tableAdapterManager.НакладныеTableAdapter = this.InvoiceTableAdapter;
            this.tableAdapterManager.НалогиTableAdapter = this.TaxTableAdapter;
            this.tableAdapterManager.ОрганизацияTableAdapter = this.OrganizationTableAdapter;
            this.tableAdapterManager.ОстаткиTableAdapter = this.BalanceTableAdapter;
            this.tableAdapterManager.ПодразделенияTableAdapter = this.DivisionsTableAdapter;
            this.tableAdapterManager.ТаксировкаTableAdapter = this.TaxingTableAdapter;
            this.tableAdapterManager.ТоварTableAdapter = this.ProductTableAdapter;
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AllowUserToAddRows = false;
            this.CategoryDataGridView.AllowUserToDeleteRows = false;
            this.CategoryDataGridView.AutoGenerateColumns = false;
            this.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.CategoryDataGridView.DataSource = this.CategoryBindingSource;
            this.CategoryDataGridView.Location = new System.Drawing.Point(3, 16);
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.ReadOnly = true;
            this.CategoryDataGridView.RowHeadersVisible = false;
            this.CategoryDataGridView.Size = new System.Drawing.Size(980, 204);
            this.CategoryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код категории товара";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код категории товара";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование категории";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование категории";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataMember = "FK_Товар_Категория товара";
            this.ProductBindingSource.DataSource = this.CategoryBindingSource;
            // 
            // ProductTableAdapter
            // 
            this.ProductTableAdapter.ClearBeforeFill = true;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AutoGenerateColumns = false;
            this.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ProductDataGridView.DataSource = this.ProductBindingSource;
            this.ProductDataGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.RowHeadersVisible = false;
            this.ProductDataGridView.Size = new System.Drawing.Size(980, 257);
            this.ProductDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Артикул товара";
            this.dataGridViewTextBoxColumn3.HeaderText = "Артикул товара";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Еденица измерения";
            this.dataGridViewTextBoxColumn5.HeaderText = "Еденица измерения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код категории товара";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код категории товара";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Controls.Add(this.CategoryDataGridView);
            this.CategoryGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(986, 261);
            this.CategoryGroupBox.TabIndex = 2;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Категории товара";
            // 
            // ProductGroupBox
            // 
            this.ProductGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductGroupBox.Controls.Add(this.ProductDataGridView);
            this.ProductGroupBox.Location = new System.Drawing.Point(3, 266);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.Size = new System.Drawing.Size(986, 385);
            this.ProductGroupBox.TabIndex = 3;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Товар";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1008, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // DivisionsBindingSource
            // 
            this.DivisionsBindingSource.DataMember = "Подразделения";
            this.DivisionsBindingSource.DataSource = this.stockDataSet;
            // 
            // DivisionsTableAdapter
            // 
            this.DivisionsTableAdapter.ClearBeforeFill = true;
            // 
            // DivisionsDataGridView
            // 
            this.DivisionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionsDataGridView.AutoGenerateColumns = false;
            this.DivisionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DivisionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DivisionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.DivisionsDataGridView.DataSource = this.DivisionsBindingSource;
            this.DivisionsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DivisionsDataGridView.Name = "DivisionsDataGridView";
            this.DivisionsDataGridView.RowHeadersVisible = false;
            this.DivisionsDataGridView.Size = new System.Drawing.Size(986, 603);
            this.DivisionsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Номер склада";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер склада";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Наименование склада";
            this.dataGridViewTextBoxColumn8.HeaderText = "Наименование склада";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ФИО кладовщика";
            this.dataGridViewTextBoxColumn9.HeaderText = "ФИО кладовщика";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MoveProductDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Движения товара";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MoveProductBindingSource
            // 
            this.MoveProductBindingSource.DataMember = "Движение товара";
            this.MoveProductBindingSource.DataSource = this.stockDataSet;
            // 
            // MoveProductTableAdapter
            // 
            this.MoveProductTableAdapter.ClearBeforeFill = true;
            // 
            // MoveProductDataGridView
            // 
            this.MoveProductDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveProductDataGridView.AutoGenerateColumns = false;
            this.MoveProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoveProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoveProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.MoveProductDataGridView.DataSource = this.MoveProductBindingSource;
            this.MoveProductDataGridView.Location = new System.Drawing.Point(3, 3);
            this.MoveProductDataGridView.Name = "MoveProductDataGridView";
            this.MoveProductDataGridView.RowHeadersVisible = false;
            this.MoveProductDataGridView.Size = new System.Drawing.Size(986, 557);
            this.MoveProductDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn10.HeaderText = "id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Номер накладной";
            this.dataGridViewTextBoxColumn11.HeaderText = "Номер накладной";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Артикул товара";
            this.dataGridViewTextBoxColumn12.HeaderText = "Артикул товара";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Количество товара";
            this.dataGridViewTextBoxColumn13.HeaderText = "Количество товара";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn14.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.InvoiceDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(992, 654);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Накладные";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // InvoiceBindingSource
            // 
            this.InvoiceBindingSource.DataMember = "Накладные";
            this.InvoiceBindingSource.DataSource = this.stockDataSet;
            // 
            // InvoiceTableAdapter
            // 
            this.InvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceDataGridView
            // 
            this.InvoiceDataGridView.AutoGenerateColumns = false;
            this.InvoiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерНакладнойDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.признакТипаНакладнойDataGridViewTextBoxColumn,
            this.кодОрганизацииDataGridViewTextBoxColumn,
            this.кодСкладаDataGridViewTextBoxColumn});
            this.InvoiceDataGridView.DataSource = this.InvoiceBindingSource;
            this.InvoiceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.InvoiceDataGridView.Name = "InvoiceDataGridView";
            this.InvoiceDataGridView.RowHeadersVisible = false;
            this.InvoiceDataGridView.Size = new System.Drawing.Size(986, 601);
            this.InvoiceDataGridView.TabIndex = 0;
            // 
            // номерНакладнойDataGridViewTextBoxColumn
            // 
            this.номерНакладнойDataGridViewTextBoxColumn.DataPropertyName = "Номер накладной";
            this.номерНакладнойDataGridViewTextBoxColumn.HeaderText = "Номер накладной";
            this.номерНакладнойDataGridViewTextBoxColumn.Name = "номерНакладнойDataGridViewTextBoxColumn";
            this.номерНакладнойDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // признакТипаНакладнойDataGridViewTextBoxColumn
            // 
            this.признакТипаНакладнойDataGridViewTextBoxColumn.DataPropertyName = "Признак типа накладной";
            this.признакТипаНакладнойDataGridViewTextBoxColumn.HeaderText = "Признак типа накладной";
            this.признакТипаНакладнойDataGridViewTextBoxColumn.Name = "признакТипаНакладнойDataGridViewTextBoxColumn";
            // 
            // кодОрганизацииDataGridViewTextBoxColumn
            // 
            this.кодОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "Код организации";
            this.кодОрганизацииDataGridViewTextBoxColumn.HeaderText = "Код организации";
            this.кодОрганизацииDataGridViewTextBoxColumn.Name = "кодОрганизацииDataGridViewTextBoxColumn";
            // 
            // кодСкладаDataGridViewTextBoxColumn
            // 
            this.кодСкладаDataGridViewTextBoxColumn.DataPropertyName = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.HeaderText = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.Name = "кодСкладаDataGridViewTextBoxColumn";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.OrganizationDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(992, 654);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Организация";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // OrganizationBindingSource
            // 
            this.OrganizationBindingSource.DataMember = "Организация";
            this.OrganizationBindingSource.DataSource = this.stockDataSet;
            // 
            // OrganizationTableAdapter
            // 
            this.OrganizationTableAdapter.ClearBeforeFill = true;
            // 
            // OrganizationDataGridView
            // 
            this.OrganizationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizationDataGridView.AutoGenerateColumns = false;
            this.OrganizationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrganizationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrganizationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.OrganizationDataGridView.DataSource = this.OrganizationBindingSource;
            this.OrganizationDataGridView.Location = new System.Drawing.Point(3, 3);
            this.OrganizationDataGridView.Name = "OrganizationDataGridView";
            this.OrganizationDataGridView.RowHeadersVisible = false;
            this.OrganizationDataGridView.Size = new System.Drawing.Size(986, 220);
            this.OrganizationDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "РНН организации";
            this.dataGridViewTextBoxColumn15.HeaderText = "РНН организации";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn16.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Код банка";
            this.dataGridViewTextBoxColumn17.HeaderText = "Код банка";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Лицевой счет организации";
            this.dataGridViewTextBoxColumn18.HeaderText = "Лицевой счет организации";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn19.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ФИО руководителя";
            this.dataGridViewTextBoxColumn20.HeaderText = "ФИО руководителя";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn21.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.BankDataGridView);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(992, 654);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Банк";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // BankBindingSource
            // 
            this.BankBindingSource.DataMember = "Банк";
            this.BankBindingSource.DataSource = this.stockDataSet;
            // 
            // BankTableAdapter
            // 
            this.BankTableAdapter.ClearBeforeFill = true;
            // 
            // BankDataGridView
            // 
            this.BankDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankDataGridView.AutoGenerateColumns = false;
            this.BankDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.BankDataGridView.DataSource = this.BankBindingSource;
            this.BankDataGridView.Location = new System.Drawing.Point(3, 3);
            this.BankDataGridView.Name = "BankDataGridView";
            this.BankDataGridView.RowHeadersVisible = false;
            this.BankDataGridView.Size = new System.Drawing.Size(986, 220);
            this.BankDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Код банка";
            this.dataGridViewTextBoxColumn22.HeaderText = "Код банка";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn23.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.TaxDataGridView);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(992, 654);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Налоги";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // TaxBindingSource
            // 
            this.TaxBindingSource.DataMember = "Налоги";
            this.TaxBindingSource.DataSource = this.stockDataSet;
            // 
            // TaxTableAdapter
            // 
            this.TaxTableAdapter.ClearBeforeFill = true;
            // 
            // TaxDataGridView
            // 
            this.TaxDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxDataGridView.AutoGenerateColumns = false;
            this.TaxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaxDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.TaxDataGridView.DataSource = this.TaxBindingSource;
            this.TaxDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TaxDataGridView.Name = "TaxDataGridView";
            this.TaxDataGridView.RowHeadersVisible = false;
            this.TaxDataGridView.Size = new System.Drawing.Size(986, 440);
            this.TaxDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Код налога";
            this.dataGridViewTextBoxColumn24.HeaderText = "Код налога";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn25.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Процент начисления от стоимости товара";
            this.dataGridViewTextBoxColumn26.HeaderText = "Процент начисления от стоимости товара";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.TaxingDataGridView);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(992, 654);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Таксировка";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // TaxingBindingSource
            // 
            this.TaxingBindingSource.DataMember = "Таксировка";
            this.TaxingBindingSource.DataSource = this.stockDataSet;
            // 
            // TaxingTableAdapter
            // 
            this.TaxingTableAdapter.ClearBeforeFill = true;
            // 
            // TaxingDataGridView
            // 
            this.TaxingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxingDataGridView.AutoGenerateColumns = false;
            this.TaxingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaxingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaxingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.TaxingDataGridView.DataSource = this.TaxingBindingSource;
            this.TaxingDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TaxingDataGridView.Name = "TaxingDataGridView";
            this.TaxingDataGridView.RowHeadersVisible = false;
            this.TaxingDataGridView.Size = new System.Drawing.Size(986, 220);
            this.TaxingDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn27.HeaderText = "id";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Номер накладной";
            this.dataGridViewTextBoxColumn28.HeaderText = "Номер накладной";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Код налога";
            this.dataGridViewTextBoxColumn29.HeaderText = "Код налога";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Сумма налога";
            this.dataGridViewTextBoxColumn30.HeaderText = "Сумма налога";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.остаткиDataGridView);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(992, 654);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Остатки";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // BalanceBindingSource
            // 
            this.BalanceBindingSource.DataMember = "Остатки";
            this.BalanceBindingSource.DataSource = this.stockDataSet;
            // 
            // BalanceTableAdapter
            // 
            this.BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // остаткиDataGridView
            // 
            this.остаткиDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.остаткиDataGridView.AutoGenerateColumns = false;
            this.остаткиDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.остаткиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.остаткиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36});
            this.остаткиDataGridView.DataSource = this.BalanceBindingSource;
            this.остаткиDataGridView.Location = new System.Drawing.Point(3, 3);
            this.остаткиDataGridView.Name = "остаткиDataGridView";
            this.остаткиDataGridView.RowHeadersVisible = false;
            this.остаткиDataGridView.Size = new System.Drawing.Size(986, 568);
            this.остаткиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn31.HeaderText = "id";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Артикул товара";
            this.dataGridViewTextBoxColumn32.HeaderText = "Артикул товара";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Средняя цена";
            this.dataGridViewTextBoxColumn33.HeaderText = "Средняя цена";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Количество товара на начало месяца";
            this.dataGridViewTextBoxColumn34.HeaderText = "Количество товара на начало месяца";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Количество приход";
            this.dataGridViewTextBoxColumn35.HeaderText = "Количество приход";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Количество расход";
            this.dataGridViewTextBoxColumn36.HeaderText = "Количество расход";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainMenuStrip);
            this.MainMenuStrip = this.MainMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.CategoryGroupBox.ResumeLayout(false);
            this.ProductGroupBox.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoveProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProductDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationDataGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataGridView)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxDataGridView)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaxingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxingDataGridView)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.остаткиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource CategoryBindingSource;
        private StockDataSetTableAdapters.Категории_товараTableAdapter CategoryTableAdapter;
        private StockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private StockDataSetTableAdapters.ТоварTableAdapter ProductTableAdapter;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private StockDataSetTableAdapters.ПодразделенияTableAdapter DivisionsTableAdapter;
        private System.Windows.Forms.BindingSource DivisionsBindingSource;
        private System.Windows.Forms.DataGridView DivisionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TabPage tabPage3;
        private StockDataSetTableAdapters.Движение_товараTableAdapter MoveProductTableAdapter;
        private System.Windows.Forms.BindingSource MoveProductBindingSource;
        private System.Windows.Forms.DataGridView MoveProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TabPage tabPage4;
        private StockDataSetTableAdapters.НакладныеTableAdapter InvoiceTableAdapter;
        private System.Windows.Forms.BindingSource InvoiceBindingSource;
        private System.Windows.Forms.DataGridView InvoiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерНакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn признакТипаНакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОрганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage5;
        private StockDataSetTableAdapters.ОрганизацияTableAdapter OrganizationTableAdapter;
        private System.Windows.Forms.BindingSource OrganizationBindingSource;
        private System.Windows.Forms.DataGridView OrganizationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.TabPage tabPage6;
        private StockDataSetTableAdapters.БанкTableAdapter BankTableAdapter;
        private System.Windows.Forms.BindingSource BankBindingSource;
        private System.Windows.Forms.DataGridView BankDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.TabPage tabPage7;
        private StockDataSetTableAdapters.НалогиTableAdapter TaxTableAdapter;
        private System.Windows.Forms.BindingSource TaxBindingSource;
        private System.Windows.Forms.DataGridView TaxDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.TabPage tabPage8;
        private StockDataSetTableAdapters.ТаксировкаTableAdapter TaxingTableAdapter;
        private System.Windows.Forms.BindingSource TaxingBindingSource;
        private System.Windows.Forms.DataGridView TaxingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.TabPage tabPage9;
        private StockDataSetTableAdapters.ОстаткиTableAdapter BalanceTableAdapter;
        private System.Windows.Forms.BindingSource BalanceBindingSource;
        private System.Windows.Forms.DataGridView остаткиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
    }
}

