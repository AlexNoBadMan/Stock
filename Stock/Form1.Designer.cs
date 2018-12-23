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
            System.Windows.Forms.Label код_категории_товараLabel;
            System.Windows.Forms.Label наименование_категорииLabel;
            System.Windows.Forms.Label артикул_товараLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label еденица_измеренияLabel;
            System.Windows.Forms.Label код_категории_товараLabel1;
            System.Windows.Forms.Label номер_складаLabel;
            System.Windows.Forms.Label наименование_складаLabel;
            System.Windows.Forms.Label фИО_кладовщикаLabel;
            System.Windows.Forms.Label номер_накладнойLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label признак_типа_накладнойLabel;
            System.Windows.Forms.Label код_организацииLabel;
            System.Windows.Forms.Label код_складаLabel;
            System.Windows.Forms.Label номер_накладнойLabel1;
            System.Windows.Forms.Label артикул_товараLabel1;
            System.Windows.Forms.Label количество_товараLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label рНН_организацииLabel;
            System.Windows.Forms.Label наименованиеLabel1;
            System.Windows.Forms.Label код_банкаLabel;
            System.Windows.Forms.Label лицевой_счет_организацииLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label фИО_руководителяLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label код_банкаLabel1;
            System.Windows.Forms.Label наименованиеLabel2;
            System.Windows.Forms.Label код_налогаLabel;
            System.Windows.Forms.Label наименованиеLabel3;
            System.Windows.Forms.Label процент_начисления_от_стоимости_товараLabel;
            System.Windows.Forms.Label номер_накладнойLabel2;
            System.Windows.Forms.Label код_налогаLabel1;
            System.Windows.Forms.Label сумма_налогаLabel;
            System.Windows.Forms.Label артикул_товараLabel2;
            System.Windows.Forms.Label средняя_ценаLabel;
            System.Windows.Forms.Label количество_товара_на_начало_месяцаLabel;
            System.Windows.Forms.Label количество_приходLabel;
            System.Windows.Forms.Label количество_расходLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProductGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductAddButton = new System.Windows.Forms.Button();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.артикул_товараTextBox = new System.Windows.Forms.TextBox();
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new Stock.StockDataSet();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.еденица_измеренияTextBox = new System.Windows.Forms.TextBox();
            this.код_категории_товараTextBox1 = new System.Windows.Forms.TextBox();
            this.ProductCancelButton = new System.Windows.Forms.Button();
            this.ProductSaveButton = new System.Windows.Forms.Button();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryAddButton = new System.Windows.Forms.Button();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategoryDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.CategoryCancelButton = new System.Windows.Forms.Button();
            this.CategorySaveButton = new System.Windows.Forms.Button();
            this.код_категории_товараTextBox = new System.Windows.Forms.TextBox();
            this.наименование_категорииTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DivisionsAddButton = new System.Windows.Forms.Button();
            this.DivisionsPanel = new System.Windows.Forms.Panel();
            this.номер_складаTextBox = new System.Windows.Forms.TextBox();
            this.DivisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименование_складаTextBox = new System.Windows.Forms.TextBox();
            this.фИО_кладовщикаTextBox = new System.Windows.Forms.TextBox();
            this.DivisionsCancelButton = new System.Windows.Forms.Button();
            this.DivisionsSaveButton = new System.Windows.Forms.Button();
            this.DivisionsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.InvoiceAddButton = new System.Windows.Forms.Button();
            this.InvoicePanel = new System.Windows.Forms.Panel();
            this.номер_накладнойTextBox = new System.Windows.Forms.TextBox();
            this.InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.признак_типа_накладнойTextBox = new System.Windows.Forms.TextBox();
            this.код_организацииComboBox = new System.Windows.Forms.ComboBox();
            this.код_складаComboBox = new System.Windows.Forms.ComboBox();
            this.InvoiceCancelButton = new System.Windows.Forms.Button();
            this.InvoiceSaveButton = new System.Windows.Forms.Button();
            this.InvoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MoveProductAddButton = new System.Windows.Forms.Button();
            this.MoveProductPanel = new System.Windows.Forms.Panel();
            this.номер_накладнойComboBox = new System.Windows.Forms.ComboBox();
            this.MoveProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.артикул_товараComboBox = new System.Windows.Forms.ComboBox();
            this.количество_товараTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.MoveProductCancelButton = new System.Windows.Forms.Button();
            this.MoveProductButton = new System.Windows.Forms.Button();
            this.MoveProductDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.OrganizationAddButton = new System.Windows.Forms.Button();
            this.OrganizationPanel = new System.Windows.Forms.Panel();
            this.рНН_организацииTextBox = new System.Windows.Forms.TextBox();
            this.OrganizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиеTextBox1 = new System.Windows.Forms.TextBox();
            this.код_банкаComboBox = new System.Windows.Forms.ComboBox();
            this.лицевой_счет_организацииTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.фИО_руководителяTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.OrganizationCancelButton = new System.Windows.Forms.Button();
            this.OrganizationSaveButton = new System.Windows.Forms.Button();
            this.OrganizationDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.BankAddButton = new System.Windows.Forms.Button();
            this.BankDataGridView = new System.Windows.Forms.DataGridView();
            this.BankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankPanel = new System.Windows.Forms.Panel();
            this.код_банкаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox2 = new System.Windows.Forms.TextBox();
            this.BankCancelButton = new System.Windows.Forms.Button();
            this.BankSaveButton = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.TaxAddButton = new System.Windows.Forms.Button();
            this.TaxPanel = new System.Windows.Forms.Panel();
            this.код_налогаTextBox = new System.Windows.Forms.TextBox();
            this.TaxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиеTextBox3 = new System.Windows.Forms.TextBox();
            this.процент_начисления_от_стоимости_товараTextBox = new System.Windows.Forms.TextBox();
            this.TaxCancelButton = new System.Windows.Forms.Button();
            this.TaxSaveButton = new System.Windows.Forms.Button();
            this.TaxDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.TaxingAddButton = new System.Windows.Forms.Button();
            this.TaxingPanel = new System.Windows.Forms.Panel();
            this.номер_накладнойComboBox1 = new System.Windows.Forms.ComboBox();
            this.TaxingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_налогаComboBox = new System.Windows.Forms.ComboBox();
            this.сумма_налогаTextBox = new System.Windows.Forms.TextBox();
            this.TaxingCancelButton = new System.Windows.Forms.Button();
            this.TaxingSaveButton = new System.Windows.Forms.Button();
            this.TaxingDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.BalanceAddButton = new System.Windows.Forms.Button();
            this.BalancePanel = new System.Windows.Forms.Panel();
            this.артикул_товараComboBox1 = new System.Windows.Forms.ComboBox();
            this.BalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.средняя_ценаTextBox = new System.Windows.Forms.TextBox();
            this.количество_товара_на_начало_месяцаTextBox = new System.Windows.Forms.TextBox();
            this.количество_приходTextBox = new System.Windows.Forms.TextBox();
            this.количество_расходTextBox = new System.Windows.Forms.TextBox();
            this.BalanceCancelButton = new System.Windows.Forms.Button();
            this.BalanceSaveButton = new System.Windows.Forms.Button();
            this.BalanceDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryTableAdapter = new Stock.StockDataSetTableAdapters.Категории_товараTableAdapter();
            this.tableAdapterManager = new Stock.StockDataSetTableAdapters.TableAdapterManager();
            this.BankTableAdapter = new Stock.StockDataSetTableAdapters.БанкTableAdapter();
            this.MoveProductTableAdapter = new Stock.StockDataSetTableAdapters.Движение_товараTableAdapter();
            this.InvoiceTableAdapter = new Stock.StockDataSetTableAdapters.НакладныеTableAdapter();
            this.TaxTableAdapter = new Stock.StockDataSetTableAdapters.НалогиTableAdapter();
            this.OrganizationTableAdapter = new Stock.StockDataSetTableAdapters.ОрганизацияTableAdapter();
            this.BalanceTableAdapter = new Stock.StockDataSetTableAdapters.ОстаткиTableAdapter();
            this.DivisionsTableAdapter = new Stock.StockDataSetTableAdapters.ПодразделенияTableAdapter();
            this.TaxingTableAdapter = new Stock.StockDataSetTableAdapters.ТаксировкаTableAdapter();
            this.ProductTableAdapter = new Stock.StockDataSetTableAdapters.ТоварTableAdapter();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DivisionsChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DivisionsDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.номерНакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.признакТипаНакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceCahngeColoumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.InvoiceDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveProductChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.MoveProductDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.OrganizationDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BankDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.TaxDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxingChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.TaxingDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BalanceDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            код_категории_товараLabel = new System.Windows.Forms.Label();
            наименование_категорииLabel = new System.Windows.Forms.Label();
            артикул_товараLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            еденица_измеренияLabel = new System.Windows.Forms.Label();
            код_категории_товараLabel1 = new System.Windows.Forms.Label();
            номер_складаLabel = new System.Windows.Forms.Label();
            наименование_складаLabel = new System.Windows.Forms.Label();
            фИО_кладовщикаLabel = new System.Windows.Forms.Label();
            номер_накладнойLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            признак_типа_накладнойLabel = new System.Windows.Forms.Label();
            код_организацииLabel = new System.Windows.Forms.Label();
            код_складаLabel = new System.Windows.Forms.Label();
            номер_накладнойLabel1 = new System.Windows.Forms.Label();
            артикул_товараLabel1 = new System.Windows.Forms.Label();
            количество_товараLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            рНН_организацииLabel = new System.Windows.Forms.Label();
            наименованиеLabel1 = new System.Windows.Forms.Label();
            код_банкаLabel = new System.Windows.Forms.Label();
            лицевой_счет_организацииLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            фИО_руководителяLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            код_банкаLabel1 = new System.Windows.Forms.Label();
            наименованиеLabel2 = new System.Windows.Forms.Label();
            код_налогаLabel = new System.Windows.Forms.Label();
            наименованиеLabel3 = new System.Windows.Forms.Label();
            процент_начисления_от_стоимости_товараLabel = new System.Windows.Forms.Label();
            номер_накладнойLabel2 = new System.Windows.Forms.Label();
            код_налогаLabel1 = new System.Windows.Forms.Label();
            сумма_налогаLabel = new System.Windows.Forms.Label();
            артикул_товараLabel2 = new System.Windows.Forms.Label();
            средняя_ценаLabel = new System.Windows.Forms.Label();
            количество_товара_на_начало_месяцаLabel = new System.Windows.Forms.Label();
            количество_приходLabel = new System.Windows.Forms.Label();
            количество_расходLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ProductGroupBox.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.CategoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            this.CategoryPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.DivisionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.InvoicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.MoveProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProductDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.OrganizationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationDataGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankBindingSource)).BeginInit();
            this.BankPanel.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.TaxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxDataGridView)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.TaxingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxingDataGridView)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.BalancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDataGridView)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_категории_товараLabel
            // 
            код_категории_товараLabel.AutoSize = true;
            код_категории_товараLabel.Location = new System.Drawing.Point(235, 73);
            код_категории_товараLabel.Name = "код_категории_товараLabel";
            код_категории_товараLabel.Size = new System.Drawing.Size(204, 20);
            код_категории_товараLabel.TabIndex = 0;
            код_категории_товараLabel.Text = "Код категории товара:";
            // 
            // наименование_категорииLabel
            // 
            наименование_категорииLabel.AutoSize = true;
            наименование_категорииLabel.Location = new System.Drawing.Point(235, 105);
            наименование_категорииLabel.Name = "наименование_категорииLabel";
            наименование_категорииLabel.Size = new System.Drawing.Size(231, 20);
            наименование_категорииLabel.TabIndex = 2;
            наименование_категорииLabel.Text = "Наименование категории:";
            // 
            // артикул_товараLabel
            // 
            артикул_товараLabel.AutoSize = true;
            артикул_товараLabel.Location = new System.Drawing.Point(255, 122);
            артикул_товараLabel.Name = "артикул_товараLabel";
            артикул_товараLabel.Size = new System.Drawing.Size(148, 20);
            артикул_товараLabel.TabIndex = 17;
            артикул_товараLabel.Text = "Артикул товара:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(255, 154);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(139, 20);
            наименованиеLabel.TabIndex = 19;
            наименованиеLabel.Text = "Наименование:";
            // 
            // еденица_измеренияLabel
            // 
            еденица_измеренияLabel.AutoSize = true;
            еденица_измеренияLabel.Location = new System.Drawing.Point(255, 186);
            еденица_измеренияLabel.Name = "еденица_измеренияLabel";
            еденица_измеренияLabel.Size = new System.Drawing.Size(184, 20);
            еденица_измеренияLabel.TabIndex = 21;
            еденица_измеренияLabel.Text = "Еденица измерения:";
            // 
            // код_категории_товараLabel1
            // 
            код_категории_товараLabel1.AutoSize = true;
            код_категории_товараLabel1.Location = new System.Drawing.Point(255, 218);
            код_категории_товараLabel1.Name = "код_категории_товараLabel1";
            код_категории_товараLabel1.Size = new System.Drawing.Size(204, 20);
            код_категории_товараLabel1.TabIndex = 23;
            код_категории_товараLabel1.Text = "Код категории товара:";
            // 
            // номер_складаLabel
            // 
            номер_складаLabel.AutoSize = true;
            номер_складаLabel.Location = new System.Drawing.Point(236, 37);
            номер_складаLabel.Name = "номер_складаLabel";
            номер_складаLabel.Size = new System.Drawing.Size(134, 20);
            номер_складаLabel.TabIndex = 17;
            номер_складаLabel.Text = "Номер склада:";
            // 
            // наименование_складаLabel
            // 
            наименование_складаLabel.AutoSize = true;
            наименование_складаLabel.Location = new System.Drawing.Point(236, 69);
            наименование_складаLabel.Name = "наименование_складаLabel";
            наименование_складаLabel.Size = new System.Drawing.Size(204, 20);
            наименование_складаLabel.TabIndex = 19;
            наименование_складаLabel.Text = "Наименование склада:";
            // 
            // фИО_кладовщикаLabel
            // 
            фИО_кладовщикаLabel.AutoSize = true;
            фИО_кладовщикаLabel.Location = new System.Drawing.Point(236, 101);
            фИО_кладовщикаLabel.Name = "фИО_кладовщикаLabel";
            фИО_кладовщикаLabel.Size = new System.Drawing.Size(163, 20);
            фИО_кладовщикаLabel.TabIndex = 21;
            фИО_кладовщикаLabel.Text = "ФИО кладовщика:";
            // 
            // номер_накладнойLabel
            // 
            номер_накладнойLabel.AutoSize = true;
            номер_накладнойLabel.Location = new System.Drawing.Point(249, 11);
            номер_накладнойLabel.Name = "номер_накладнойLabel";
            номер_накладнойLabel.Size = new System.Drawing.Size(165, 20);
            номер_накладнойLabel.TabIndex = 17;
            номер_накладнойLabel.Text = "Номер накладной:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(249, 44);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(57, 20);
            датаLabel.TabIndex = 19;
            датаLabel.Text = "Дата:";
            // 
            // признак_типа_накладнойLabel
            // 
            признак_типа_накладнойLabel.AutoSize = true;
            признак_типа_накладнойLabel.Location = new System.Drawing.Point(249, 75);
            признак_типа_накладнойLabel.Name = "признак_типа_накладнойLabel";
            признак_типа_накладнойLabel.Size = new System.Drawing.Size(226, 20);
            признак_типа_накладнойLabel.TabIndex = 21;
            признак_типа_накладнойLabel.Text = "Признак типа накладной:";
            // 
            // код_организацииLabel
            // 
            код_организацииLabel.AutoSize = true;
            код_организацииLabel.Location = new System.Drawing.Point(249, 107);
            код_организацииLabel.Name = "код_организацииLabel";
            код_организацииLabel.Size = new System.Drawing.Size(159, 20);
            код_организацииLabel.TabIndex = 23;
            код_организацииLabel.Text = "Код организации:";
            // 
            // код_складаLabel
            // 
            код_складаLabel.AutoSize = true;
            код_складаLabel.Location = new System.Drawing.Point(249, 141);
            код_складаLabel.Name = "код_складаLabel";
            код_складаLabel.Size = new System.Drawing.Size(112, 20);
            код_складаLabel.TabIndex = 25;
            код_складаLabel.Text = "Код склада:";
            // 
            // номер_накладнойLabel1
            // 
            номер_накладнойLabel1.AutoSize = true;
            номер_накладнойLabel1.Location = new System.Drawing.Point(274, 30);
            номер_накладнойLabel1.Name = "номер_накладнойLabel1";
            номер_накладнойLabel1.Size = new System.Drawing.Size(165, 20);
            номер_накладнойLabel1.TabIndex = 19;
            номер_накладнойLabel1.Text = "Номер накладной:";
            // 
            // артикул_товараLabel1
            // 
            артикул_товараLabel1.AutoSize = true;
            артикул_товараLabel1.Location = new System.Drawing.Point(274, 64);
            артикул_товараLabel1.Name = "артикул_товараLabel1";
            артикул_товараLabel1.Size = new System.Drawing.Size(148, 20);
            артикул_товараLabel1.TabIndex = 21;
            артикул_товараLabel1.Text = "Артикул товара:";
            // 
            // количество_товараLabel
            // 
            количество_товараLabel.AutoSize = true;
            количество_товараLabel.Location = new System.Drawing.Point(274, 98);
            количество_товараLabel.Name = "количество_товараLabel";
            количество_товараLabel.Size = new System.Drawing.Size(179, 20);
            количество_товараLabel.TabIndex = 23;
            количество_товараLabel.Text = "Количество товара:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(274, 130);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(57, 20);
            ценаLabel.TabIndex = 25;
            ценаLabel.Text = "Цена:";
            // 
            // рНН_организацииLabel
            // 
            рНН_организацииLabel.AutoSize = true;
            рНН_организацииLabel.Location = new System.Drawing.Point(256, 5);
            рНН_организацииLabel.Name = "рНН_организацииLabel";
            рНН_организацииLabel.Size = new System.Drawing.Size(163, 20);
            рНН_организацииLabel.TabIndex = 17;
            рНН_организацииLabel.Text = "РНН организации:";
            // 
            // наименованиеLabel1
            // 
            наименованиеLabel1.AutoSize = true;
            наименованиеLabel1.Location = new System.Drawing.Point(256, 37);
            наименованиеLabel1.Name = "наименованиеLabel1";
            наименованиеLabel1.Size = new System.Drawing.Size(139, 20);
            наименованиеLabel1.TabIndex = 19;
            наименованиеLabel1.Text = "Наименование:";
            // 
            // код_банкаLabel
            // 
            код_банкаLabel.AutoSize = true;
            код_банкаLabel.Location = new System.Drawing.Point(256, 69);
            код_банкаLabel.Name = "код_банкаLabel";
            код_банкаLabel.Size = new System.Drawing.Size(101, 20);
            код_банкаLabel.TabIndex = 21;
            код_банкаLabel.Text = "Код банка:";
            // 
            // лицевой_счет_организацииLabel
            // 
            лицевой_счет_организацииLabel.AutoSize = true;
            лицевой_счет_организацииLabel.Location = new System.Drawing.Point(256, 103);
            лицевой_счет_организацииLabel.Name = "лицевой_счет_организацииLabel";
            лицевой_счет_организацииLabel.Size = new System.Drawing.Size(242, 20);
            лицевой_счет_организацииLabel.TabIndex = 23;
            лицевой_счет_организацииLabel.Text = "Лицевой счет организации:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(256, 135);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(67, 20);
            адресLabel.TabIndex = 25;
            адресLabel.Text = "Адрес:";
            // 
            // фИО_руководителяLabel
            // 
            фИО_руководителяLabel.AutoSize = true;
            фИО_руководителяLabel.Location = new System.Drawing.Point(256, 167);
            фИО_руководителяLabel.Name = "фИО_руководителяLabel";
            фИО_руководителяLabel.Size = new System.Drawing.Size(178, 20);
            фИО_руководителяLabel.TabIndex = 27;
            фИО_руководителяLabel.Text = "ФИО руководителя:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(256, 199);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(90, 20);
            телефонLabel.TabIndex = 29;
            телефонLabel.Text = "Телефон:";
            // 
            // код_банкаLabel1
            // 
            код_банкаLabel1.AutoSize = true;
            код_банкаLabel1.Location = new System.Drawing.Point(269, 79);
            код_банкаLabel1.Name = "код_банкаLabel1";
            код_банкаLabel1.Size = new System.Drawing.Size(101, 20);
            код_банкаLabel1.TabIndex = 17;
            код_банкаLabel1.Text = "Код банка:";
            // 
            // наименованиеLabel2
            // 
            наименованиеLabel2.AutoSize = true;
            наименованиеLabel2.Location = new System.Drawing.Point(269, 111);
            наименованиеLabel2.Name = "наименованиеLabel2";
            наименованиеLabel2.Size = new System.Drawing.Size(139, 20);
            наименованиеLabel2.TabIndex = 19;
            наименованиеLabel2.Text = "Наименование:";
            // 
            // код_налогаLabel
            // 
            код_налогаLabel.AutoSize = true;
            код_налогаLabel.Location = new System.Drawing.Point(265, 69);
            код_налогаLabel.Name = "код_налогаLabel";
            код_налогаLabel.Size = new System.Drawing.Size(110, 20);
            код_налогаLabel.TabIndex = 17;
            код_налогаLabel.Text = "Код налога:";
            // 
            // наименованиеLabel3
            // 
            наименованиеLabel3.AutoSize = true;
            наименованиеLabel3.Location = new System.Drawing.Point(265, 101);
            наименованиеLabel3.Name = "наименованиеLabel3";
            наименованиеLabel3.Size = new System.Drawing.Size(139, 20);
            наименованиеLabel3.TabIndex = 19;
            наименованиеLabel3.Text = "Наименование:";
            // 
            // процент_начисления_от_стоимости_товараLabel
            // 
            процент_начисления_от_стоимости_товараLabel.AutoSize = true;
            процент_начисления_от_стоимости_товараLabel.Location = new System.Drawing.Point(265, 133);
            процент_начисления_от_стоимости_товараLabel.Name = "процент_начисления_от_стоимости_товараLabel";
            процент_начисления_от_стоимости_товараLabel.Size = new System.Drawing.Size(87, 20);
            процент_начисления_от_стоимости_товараLabel.TabIndex = 21;
            процент_начисления_от_стоимости_товараLabel.Text = "Процент:";
            // 
            // номер_накладнойLabel2
            // 
            номер_накладнойLabel2.AutoSize = true;
            номер_накладнойLabel2.Location = new System.Drawing.Point(262, 67);
            номер_накладнойLabel2.Name = "номер_накладнойLabel2";
            номер_накладнойLabel2.Size = new System.Drawing.Size(165, 20);
            номер_накладнойLabel2.TabIndex = 19;
            номер_накладнойLabel2.Text = "Номер накладной:";
            // 
            // код_налогаLabel1
            // 
            код_налогаLabel1.AutoSize = true;
            код_налогаLabel1.Location = new System.Drawing.Point(262, 101);
            код_налогаLabel1.Name = "код_налогаLabel1";
            код_налогаLabel1.Size = new System.Drawing.Size(110, 20);
            код_налогаLabel1.TabIndex = 21;
            код_налогаLabel1.Text = "Код налога:";
            // 
            // сумма_налогаLabel
            // 
            сумма_налогаLabel.AutoSize = true;
            сумма_налогаLabel.Location = new System.Drawing.Point(262, 135);
            сумма_налогаLabel.Name = "сумма_налогаLabel";
            сумма_налогаLabel.Size = new System.Drawing.Size(131, 20);
            сумма_налогаLabel.TabIndex = 23;
            сумма_налогаLabel.Text = "Сумма налога:";
            // 
            // артикул_товараLabel2
            // 
            артикул_товараLabel2.AutoSize = true;
            артикул_товараLabel2.Location = new System.Drawing.Point(212, 22);
            артикул_товараLabel2.Name = "артикул_товараLabel2";
            артикул_товараLabel2.Size = new System.Drawing.Size(148, 20);
            артикул_товараLabel2.TabIndex = 19;
            артикул_товараLabel2.Text = "Артикул товара:";
            // 
            // средняя_ценаLabel
            // 
            средняя_ценаLabel.AutoSize = true;
            средняя_ценаLabel.Location = new System.Drawing.Point(212, 56);
            средняя_ценаLabel.Name = "средняя_ценаLabel";
            средняя_ценаLabel.Size = new System.Drawing.Size(133, 20);
            средняя_ценаLabel.TabIndex = 21;
            средняя_ценаLabel.Text = "Средняя цена:";
            // 
            // количество_товара_на_начало_месяцаLabel
            // 
            количество_товара_на_начало_месяцаLabel.AutoSize = true;
            количество_товара_на_начало_месяцаLabel.Location = new System.Drawing.Point(212, 88);
            количество_товара_на_начало_месяцаLabel.Name = "количество_товара_на_начало_месяцаLabel";
            количество_товара_на_начало_месяцаLabel.Size = new System.Drawing.Size(335, 20);
            количество_товара_на_начало_месяцаLabel.TabIndex = 23;
            количество_товара_на_начало_месяцаLabel.Text = "Количество товара на начало месяца:";
            // 
            // количество_приходLabel
            // 
            количество_приходLabel.AutoSize = true;
            количество_приходLabel.Location = new System.Drawing.Point(212, 120);
            количество_приходLabel.Name = "количество_приходLabel";
            количество_приходLabel.Size = new System.Drawing.Size(179, 20);
            количество_приходLabel.TabIndex = 25;
            количество_приходLabel.Text = "Количество приход:";
            // 
            // количество_расходLabel
            // 
            количество_расходLabel.AutoSize = true;
            количество_расходLabel.Location = new System.Drawing.Point(212, 152);
            количество_расходLabel.Name = "количество_расходLabel";
            количество_расходLabel.Size = new System.Drawing.Size(178, 20);
            количество_расходLabel.TabIndex = 27;
            количество_расходLabel.Text = "Количество расход:";
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
            // ProductGroupBox
            // 
            this.ProductGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductGroupBox.Controls.Add(this.ProductAddButton);
            this.ProductGroupBox.Controls.Add(this.ProductDataGridView);
            this.ProductGroupBox.Controls.Add(this.ProductPanel);
            this.ProductGroupBox.Location = new System.Drawing.Point(3, 266);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.Size = new System.Drawing.Size(986, 385);
            this.ProductGroupBox.TabIndex = 3;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Товар";
            // 
            // ProductAddButton
            // 
            this.ProductAddButton.BackColor = System.Drawing.Color.White;
            this.ProductAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.ProductAddButton.Location = new System.Drawing.Point(3, 349);
            this.ProductAddButton.Name = "ProductAddButton";
            this.ProductAddButton.Size = new System.Drawing.Size(980, 30);
            this.ProductAddButton.TabIndex = 9;
            this.ProductAddButton.UseVisualStyleBackColor = false;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(артикул_товараLabel);
            this.ProductPanel.Controls.Add(this.артикул_товараTextBox);
            this.ProductPanel.Controls.Add(наименованиеLabel);
            this.ProductPanel.Controls.Add(this.наименованиеTextBox);
            this.ProductPanel.Controls.Add(еденица_измеренияLabel);
            this.ProductPanel.Controls.Add(this.еденица_измеренияTextBox);
            this.ProductPanel.Controls.Add(код_категории_товараLabel1);
            this.ProductPanel.Controls.Add(this.код_категории_товараTextBox1);
            this.ProductPanel.Controls.Add(this.ProductCancelButton);
            this.ProductPanel.Controls.Add(this.ProductSaveButton);
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProductPanel.Location = new System.Drawing.Point(3, 16);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(980, 366);
            this.ProductPanel.TabIndex = 10;
            // 
            // артикул_товараTextBox
            // 
            this.артикул_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "Артикул товара", true));
            this.артикул_товараTextBox.Location = new System.Drawing.Point(472, 119);
            this.артикул_товараTextBox.Name = "артикул_товараTextBox";
            this.артикул_товараTextBox.Size = new System.Drawing.Size(287, 26);
            this.артикул_товараTextBox.TabIndex = 18;
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataMember = "FK_Товар_Категория товара";
            this.ProductBindingSource.DataSource = this.CategoryBindingSource;
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
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(472, 151);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(287, 26);
            this.наименованиеTextBox.TabIndex = 20;
            // 
            // еденица_измеренияTextBox
            // 
            this.еденица_измеренияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "Еденица измерения", true));
            this.еденица_измеренияTextBox.Location = new System.Drawing.Point(472, 183);
            this.еденица_измеренияTextBox.Name = "еденица_измеренияTextBox";
            this.еденица_измеренияTextBox.Size = new System.Drawing.Size(287, 26);
            this.еденица_измеренияTextBox.TabIndex = 22;
            // 
            // код_категории_товараTextBox1
            // 
            this.код_категории_товараTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "Код категории товара", true));
            this.код_категории_товараTextBox1.Location = new System.Drawing.Point(472, 215);
            this.код_категории_товараTextBox1.Name = "код_категории_товараTextBox1";
            this.код_категории_товараTextBox1.Size = new System.Drawing.Size(287, 26);
            this.код_категории_товараTextBox1.TabIndex = 24;
            // 
            // ProductCancelButton
            // 
            this.ProductCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.ProductCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProductCancelButton.Location = new System.Drawing.Point(518, 295);
            this.ProductCancelButton.Name = "ProductCancelButton";
            this.ProductCancelButton.Size = new System.Drawing.Size(165, 32);
            this.ProductCancelButton.TabIndex = 17;
            this.ProductCancelButton.Text = "Отмена";
            this.ProductCancelButton.UseVisualStyleBackColor = true;
            // 
            // ProductSaveButton
            // 
            this.ProductSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductSaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.ProductSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProductSaveButton.Location = new System.Drawing.Point(301, 295);
            this.ProductSaveButton.Name = "ProductSaveButton";
            this.ProductSaveButton.Size = new System.Drawing.Size(165, 32);
            this.ProductSaveButton.TabIndex = 16;
            this.ProductSaveButton.Text = "Сохранить";
            this.ProductSaveButton.UseVisualStyleBackColor = true;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AutoGenerateColumns = false;
            this.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.ProductChangeColumn,
            this.ProductDeleteColumn});
            this.ProductDataGridView.DataSource = this.ProductBindingSource;
            this.ProductDataGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.RowHeadersVisible = false;
            this.ProductDataGridView.Size = new System.Drawing.Size(980, 327);
            this.ProductDataGridView.TabIndex = 1;
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryGroupBox.Controls.Add(this.CategoryAddButton);
            this.CategoryGroupBox.Controls.Add(this.CategoryDataGridView);
            this.CategoryGroupBox.Controls.Add(this.CategoryPanel);
            this.CategoryGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(986, 261);
            this.CategoryGroupBox.TabIndex = 2;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Категории товара";
            // 
            // CategoryAddButton
            // 
            this.CategoryAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryAddButton.BackColor = System.Drawing.Color.White;
            this.CategoryAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.CategoryAddButton.Location = new System.Drawing.Point(3, 225);
            this.CategoryAddButton.Name = "CategoryAddButton";
            this.CategoryAddButton.Size = new System.Drawing.Size(980, 30);
            this.CategoryAddButton.TabIndex = 8;
            this.CategoryAddButton.UseVisualStyleBackColor = false;
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AllowUserToAddRows = false;
            this.CategoryDataGridView.AllowUserToDeleteRows = false;
            this.CategoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryDataGridView.AutoGenerateColumns = false;
            this.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.CategoryChangeColumn,
            this.CategoryDeleteColumn});
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
            // CategoryChangeColumn
            // 
            this.CategoryChangeColumn.FillWeight = 22F;
            this.CategoryChangeColumn.HeaderText = "Редактировать";
            this.CategoryChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.CategoryChangeColumn.Name = "CategoryChangeColumn";
            this.CategoryChangeColumn.ReadOnly = true;
            // 
            // CategoryDeleteColumn
            // 
            this.CategoryDeleteColumn.FillWeight = 22F;
            this.CategoryDeleteColumn.HeaderText = "Удалить";
            this.CategoryDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.CategoryDeleteColumn.Name = "CategoryDeleteColumn";
            this.CategoryDeleteColumn.ReadOnly = true;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Controls.Add(this.CategoryCancelButton);
            this.CategoryPanel.Controls.Add(this.CategorySaveButton);
            this.CategoryPanel.Controls.Add(код_категории_товараLabel);
            this.CategoryPanel.Controls.Add(this.код_категории_товараTextBox);
            this.CategoryPanel.Controls.Add(наименование_категорииLabel);
            this.CategoryPanel.Controls.Add(this.наименование_категорииTextBox);
            this.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CategoryPanel.Location = new System.Drawing.Point(3, 16);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(980, 242);
            this.CategoryPanel.TabIndex = 2;
            // 
            // CategoryCancelButton
            // 
            this.CategoryCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.CategoryCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CategoryCancelButton.Location = new System.Drawing.Point(518, 172);
            this.CategoryCancelButton.Name = "CategoryCancelButton";
            this.CategoryCancelButton.Size = new System.Drawing.Size(165, 32);
            this.CategoryCancelButton.TabIndex = 17;
            this.CategoryCancelButton.Text = "Отмена";
            this.CategoryCancelButton.UseVisualStyleBackColor = true;
            // 
            // CategorySaveButton
            // 
            this.CategorySaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategorySaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.CategorySaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CategorySaveButton.Location = new System.Drawing.Point(301, 172);
            this.CategorySaveButton.Name = "CategorySaveButton";
            this.CategorySaveButton.Size = new System.Drawing.Size(165, 32);
            this.CategorySaveButton.TabIndex = 16;
            this.CategorySaveButton.Text = "Сохранить";
            this.CategorySaveButton.UseVisualStyleBackColor = true;
            // 
            // код_категории_товараTextBox
            // 
            this.код_категории_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoryBindingSource, "Код категории товара", true));
            this.код_категории_товараTextBox.Location = new System.Drawing.Point(472, 70);
            this.код_категории_товараTextBox.Name = "код_категории_товараTextBox";
            this.код_категории_товараTextBox.Size = new System.Drawing.Size(287, 26);
            this.код_категории_товараTextBox.TabIndex = 1;
            // 
            // наименование_категорииTextBox
            // 
            this.наименование_категорииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoryBindingSource, "Наименование категории", true));
            this.наименование_категорииTextBox.Location = new System.Drawing.Point(472, 102);
            this.наименование_категорииTextBox.Name = "наименование_категорииTextBox";
            this.наименование_категорииTextBox.Size = new System.Drawing.Size(287, 26);
            this.наименование_категорииTextBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.DivisionsAddButton);
            this.tabPage2.Controls.Add(this.DivisionsPanel);
            this.tabPage2.Controls.Add(this.DivisionsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подразделения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DivisionsAddButton
            // 
            this.DivisionsAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionsAddButton.BackColor = System.Drawing.Color.White;
            this.DivisionsAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivisionsAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionsAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.DivisionsAddButton.Location = new System.Drawing.Point(3, 620);
            this.DivisionsAddButton.Name = "DivisionsAddButton";
            this.DivisionsAddButton.Size = new System.Drawing.Size(986, 30);
            this.DivisionsAddButton.TabIndex = 10;
            this.DivisionsAddButton.UseVisualStyleBackColor = false;
            // 
            // DivisionsPanel
            // 
            this.DivisionsPanel.Controls.Add(номер_складаLabel);
            this.DivisionsPanel.Controls.Add(this.номер_складаTextBox);
            this.DivisionsPanel.Controls.Add(наименование_складаLabel);
            this.DivisionsPanel.Controls.Add(this.наименование_складаTextBox);
            this.DivisionsPanel.Controls.Add(фИО_кладовщикаLabel);
            this.DivisionsPanel.Controls.Add(this.фИО_кладовщикаTextBox);
            this.DivisionsPanel.Controls.Add(this.DivisionsCancelButton);
            this.DivisionsPanel.Controls.Add(this.DivisionsSaveButton);
            this.DivisionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DivisionsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DivisionsPanel.Location = new System.Drawing.Point(3, 448);
            this.DivisionsPanel.Name = "DivisionsPanel";
            this.DivisionsPanel.Size = new System.Drawing.Size(986, 203);
            this.DivisionsPanel.TabIndex = 9;
            // 
            // номер_складаTextBox
            // 
            this.номер_складаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DivisionsBindingSource, "Номер склада", true));
            this.номер_складаTextBox.Location = new System.Drawing.Point(446, 34);
            this.номер_складаTextBox.Name = "номер_складаTextBox";
            this.номер_складаTextBox.Size = new System.Drawing.Size(310, 26);
            this.номер_складаTextBox.TabIndex = 18;
            // 
            // DivisionsBindingSource
            // 
            this.DivisionsBindingSource.DataMember = "Подразделения";
            this.DivisionsBindingSource.DataSource = this.stockDataSet;
            // 
            // наименование_складаTextBox
            // 
            this.наименование_складаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DivisionsBindingSource, "Наименование склада", true));
            this.наименование_складаTextBox.Location = new System.Drawing.Point(446, 66);
            this.наименование_складаTextBox.Name = "наименование_складаTextBox";
            this.наименование_складаTextBox.Size = new System.Drawing.Size(310, 26);
            this.наименование_складаTextBox.TabIndex = 20;
            // 
            // фИО_кладовщикаTextBox
            // 
            this.фИО_кладовщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DivisionsBindingSource, "ФИО кладовщика", true));
            this.фИО_кладовщикаTextBox.Location = new System.Drawing.Point(446, 98);
            this.фИО_кладовщикаTextBox.Name = "фИО_кладовщикаTextBox";
            this.фИО_кладовщикаTextBox.Size = new System.Drawing.Size(310, 26);
            this.фИО_кладовщикаTextBox.TabIndex = 22;
            // 
            // DivisionsCancelButton
            // 
            this.DivisionsCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivisionsCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.DivisionsCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DivisionsCancelButton.Location = new System.Drawing.Point(518, 147);
            this.DivisionsCancelButton.Name = "DivisionsCancelButton";
            this.DivisionsCancelButton.Size = new System.Drawing.Size(165, 32);
            this.DivisionsCancelButton.TabIndex = 17;
            this.DivisionsCancelButton.Text = "Отмена";
            this.DivisionsCancelButton.UseVisualStyleBackColor = true;
            // 
            // DivisionsSaveButton
            // 
            this.DivisionsSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivisionsSaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.DivisionsSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DivisionsSaveButton.Location = new System.Drawing.Point(301, 147);
            this.DivisionsSaveButton.Name = "DivisionsSaveButton";
            this.DivisionsSaveButton.Size = new System.Drawing.Size(165, 32);
            this.DivisionsSaveButton.TabIndex = 16;
            this.DivisionsSaveButton.Text = "Сохранить";
            this.DivisionsSaveButton.UseVisualStyleBackColor = true;
            // 
            // DivisionsDataGridView
            // 
            this.DivisionsDataGridView.AllowUserToAddRows = false;
            this.DivisionsDataGridView.AllowUserToDeleteRows = false;
            this.DivisionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionsDataGridView.AutoGenerateColumns = false;
            this.DivisionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DivisionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DivisionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.DivisionsChangeColumn,
            this.DivisionsDeleteColumn});
            this.DivisionsDataGridView.DataSource = this.DivisionsBindingSource;
            this.DivisionsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DivisionsDataGridView.Name = "DivisionsDataGridView";
            this.DivisionsDataGridView.ReadOnly = true;
            this.DivisionsDataGridView.RowHeadersVisible = false;
            this.DivisionsDataGridView.Size = new System.Drawing.Size(986, 611);
            this.DivisionsDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.InvoiceAddButton);
            this.tabPage4.Controls.Add(this.InvoicePanel);
            this.tabPage4.Controls.Add(this.InvoiceDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(992, 654);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Накладные";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // InvoiceAddButton
            // 
            this.InvoiceAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceAddButton.BackColor = System.Drawing.Color.White;
            this.InvoiceAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoiceAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.InvoiceAddButton.Location = new System.Drawing.Point(3, 620);
            this.InvoiceAddButton.Name = "InvoiceAddButton";
            this.InvoiceAddButton.Size = new System.Drawing.Size(986, 30);
            this.InvoiceAddButton.TabIndex = 12;
            this.InvoiceAddButton.UseVisualStyleBackColor = false;
            // 
            // InvoicePanel
            // 
            this.InvoicePanel.Controls.Add(номер_накладнойLabel);
            this.InvoicePanel.Controls.Add(this.номер_накладнойTextBox);
            this.InvoicePanel.Controls.Add(датаLabel);
            this.InvoicePanel.Controls.Add(this.датаDateTimePicker);
            this.InvoicePanel.Controls.Add(признак_типа_накладнойLabel);
            this.InvoicePanel.Controls.Add(this.признак_типа_накладнойTextBox);
            this.InvoicePanel.Controls.Add(код_организацииLabel);
            this.InvoicePanel.Controls.Add(this.код_организацииComboBox);
            this.InvoicePanel.Controls.Add(код_складаLabel);
            this.InvoicePanel.Controls.Add(this.код_складаComboBox);
            this.InvoicePanel.Controls.Add(this.InvoiceCancelButton);
            this.InvoicePanel.Controls.Add(this.InvoiceSaveButton);
            this.InvoicePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.InvoicePanel.Location = new System.Drawing.Point(3, 421);
            this.InvoicePanel.Name = "InvoicePanel";
            this.InvoicePanel.Size = new System.Drawing.Size(986, 230);
            this.InvoicePanel.TabIndex = 11;
            // 
            // номер_накладнойTextBox
            // 
            this.номер_накладнойTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InvoiceBindingSource, "Номер накладной", true));
            this.номер_накладнойTextBox.Location = new System.Drawing.Point(481, 8);
            this.номер_накладнойTextBox.Name = "номер_накладнойTextBox";
            this.номер_накладнойTextBox.Size = new System.Drawing.Size(273, 26);
            this.номер_накладнойTextBox.TabIndex = 18;
            // 
            // InvoiceBindingSource
            // 
            this.InvoiceBindingSource.DataMember = "Накладные";
            this.InvoiceBindingSource.DataSource = this.stockDataSet;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.InvoiceBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(481, 40);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(273, 26);
            this.датаDateTimePicker.TabIndex = 20;
            // 
            // признак_типа_накладнойTextBox
            // 
            this.признак_типа_накладнойTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InvoiceBindingSource, "Признак типа накладной", true));
            this.признак_типа_накладнойTextBox.Location = new System.Drawing.Point(481, 72);
            this.признак_типа_накладнойTextBox.Name = "признак_типа_накладнойTextBox";
            this.признак_типа_накладнойTextBox.Size = new System.Drawing.Size(273, 26);
            this.признак_типа_накладнойTextBox.TabIndex = 22;
            // 
            // код_организацииComboBox
            // 
            this.код_организацииComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InvoiceBindingSource, "Код организации", true));
            this.код_организацииComboBox.FormattingEnabled = true;
            this.код_организацииComboBox.Location = new System.Drawing.Point(481, 104);
            this.код_организацииComboBox.Name = "код_организацииComboBox";
            this.код_организацииComboBox.Size = new System.Drawing.Size(273, 28);
            this.код_организацииComboBox.TabIndex = 24;
            // 
            // код_складаComboBox
            // 
            this.код_складаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InvoiceBindingSource, "Код склада", true));
            this.код_складаComboBox.FormattingEnabled = true;
            this.код_складаComboBox.Location = new System.Drawing.Point(481, 138);
            this.код_складаComboBox.Name = "код_складаComboBox";
            this.код_складаComboBox.Size = new System.Drawing.Size(273, 28);
            this.код_складаComboBox.TabIndex = 26;
            // 
            // InvoiceCancelButton
            // 
            this.InvoiceCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.InvoiceCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InvoiceCancelButton.Location = new System.Drawing.Point(520, 185);
            this.InvoiceCancelButton.Name = "InvoiceCancelButton";
            this.InvoiceCancelButton.Size = new System.Drawing.Size(165, 32);
            this.InvoiceCancelButton.TabIndex = 17;
            this.InvoiceCancelButton.Text = "Отмена";
            this.InvoiceCancelButton.UseVisualStyleBackColor = true;
            // 
            // InvoiceSaveButton
            // 
            this.InvoiceSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceSaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.InvoiceSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InvoiceSaveButton.Location = new System.Drawing.Point(303, 185);
            this.InvoiceSaveButton.Name = "InvoiceSaveButton";
            this.InvoiceSaveButton.Size = new System.Drawing.Size(165, 32);
            this.InvoiceSaveButton.TabIndex = 16;
            this.InvoiceSaveButton.Text = "Сохранить";
            this.InvoiceSaveButton.UseVisualStyleBackColor = true;
            // 
            // InvoiceDataGridView
            // 
            this.InvoiceDataGridView.AllowUserToAddRows = false;
            this.InvoiceDataGridView.AllowUserToDeleteRows = false;
            this.InvoiceDataGridView.AutoGenerateColumns = false;
            this.InvoiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерНакладнойDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.признакТипаНакладнойDataGridViewTextBoxColumn,
            this.кодОрганизацииDataGridViewTextBoxColumn,
            this.кодСкладаDataGridViewTextBoxColumn,
            this.InvoiceCahngeColoumn,
            this.InvoiceDeleteColumn});
            this.InvoiceDataGridView.DataSource = this.InvoiceBindingSource;
            this.InvoiceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.InvoiceDataGridView.Name = "InvoiceDataGridView";
            this.InvoiceDataGridView.ReadOnly = true;
            this.InvoiceDataGridView.RowHeadersVisible = false;
            this.InvoiceDataGridView.Size = new System.Drawing.Size(986, 611);
            this.InvoiceDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.MoveProductAddButton);
            this.tabPage3.Controls.Add(this.MoveProductPanel);
            this.tabPage3.Controls.Add(this.MoveProductDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Движения товара";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MoveProductAddButton
            // 
            this.MoveProductAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveProductAddButton.BackColor = System.Drawing.Color.White;
            this.MoveProductAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveProductAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveProductAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.MoveProductAddButton.Location = new System.Drawing.Point(3, 620);
            this.MoveProductAddButton.Name = "MoveProductAddButton";
            this.MoveProductAddButton.Size = new System.Drawing.Size(986, 30);
            this.MoveProductAddButton.TabIndex = 12;
            this.MoveProductAddButton.UseVisualStyleBackColor = false;
            // 
            // MoveProductPanel
            // 
            this.MoveProductPanel.Controls.Add(номер_накладнойLabel1);
            this.MoveProductPanel.Controls.Add(this.номер_накладнойComboBox);
            this.MoveProductPanel.Controls.Add(артикул_товараLabel1);
            this.MoveProductPanel.Controls.Add(this.артикул_товараComboBox);
            this.MoveProductPanel.Controls.Add(количество_товараLabel);
            this.MoveProductPanel.Controls.Add(this.количество_товараTextBox);
            this.MoveProductPanel.Controls.Add(ценаLabel);
            this.MoveProductPanel.Controls.Add(this.ценаTextBox);
            this.MoveProductPanel.Controls.Add(this.MoveProductCancelButton);
            this.MoveProductPanel.Controls.Add(this.MoveProductButton);
            this.MoveProductPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MoveProductPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.MoveProductPanel.Location = new System.Drawing.Point(3, 414);
            this.MoveProductPanel.Name = "MoveProductPanel";
            this.MoveProductPanel.Size = new System.Drawing.Size(986, 237);
            this.MoveProductPanel.TabIndex = 11;
            // 
            // номер_накладнойComboBox
            // 
            this.номер_накладнойComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MoveProductBindingSource, "Номер накладной", true));
            this.номер_накладнойComboBox.FormattingEnabled = true;
            this.номер_накладнойComboBox.Location = new System.Drawing.Point(459, 27);
            this.номер_накладнойComboBox.Name = "номер_накладнойComboBox";
            this.номер_накладнойComboBox.Size = new System.Drawing.Size(269, 28);
            this.номер_накладнойComboBox.TabIndex = 20;
            // 
            // MoveProductBindingSource
            // 
            this.MoveProductBindingSource.DataMember = "Движение товара";
            this.MoveProductBindingSource.DataSource = this.stockDataSet;
            // 
            // артикул_товараComboBox
            // 
            this.артикул_товараComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MoveProductBindingSource, "Артикул товара", true));
            this.артикул_товараComboBox.FormattingEnabled = true;
            this.артикул_товараComboBox.Location = new System.Drawing.Point(459, 61);
            this.артикул_товараComboBox.Name = "артикул_товараComboBox";
            this.артикул_товараComboBox.Size = new System.Drawing.Size(269, 28);
            this.артикул_товараComboBox.TabIndex = 22;
            // 
            // количество_товараTextBox
            // 
            this.количество_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MoveProductBindingSource, "Количество товара", true));
            this.количество_товараTextBox.Location = new System.Drawing.Point(459, 95);
            this.количество_товараTextBox.Name = "количество_товараTextBox";
            this.количество_товараTextBox.Size = new System.Drawing.Size(269, 26);
            this.количество_товараTextBox.TabIndex = 24;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MoveProductBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(459, 127);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(269, 26);
            this.ценаTextBox.TabIndex = 26;
            // 
            // MoveProductCancelButton
            // 
            this.MoveProductCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveProductCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.MoveProductCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoveProductCancelButton.Location = new System.Drawing.Point(520, 185);
            this.MoveProductCancelButton.Name = "MoveProductCancelButton";
            this.MoveProductCancelButton.Size = new System.Drawing.Size(165, 32);
            this.MoveProductCancelButton.TabIndex = 17;
            this.MoveProductCancelButton.Text = "Отмена";
            this.MoveProductCancelButton.UseVisualStyleBackColor = true;
            // 
            // MoveProductButton
            // 
            this.MoveProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveProductButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.MoveProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoveProductButton.Location = new System.Drawing.Point(303, 185);
            this.MoveProductButton.Name = "MoveProductButton";
            this.MoveProductButton.Size = new System.Drawing.Size(165, 32);
            this.MoveProductButton.TabIndex = 16;
            this.MoveProductButton.Text = "Сохранить";
            this.MoveProductButton.UseVisualStyleBackColor = true;
            // 
            // MoveProductDataGridView
            // 
            this.MoveProductDataGridView.AllowUserToAddRows = false;
            this.MoveProductDataGridView.AllowUserToDeleteRows = false;
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
            this.dataGridViewTextBoxColumn14,
            this.MoveProductChangeColumn,
            this.MoveProductDeleteColumn});
            this.MoveProductDataGridView.DataSource = this.MoveProductBindingSource;
            this.MoveProductDataGridView.Location = new System.Drawing.Point(3, 3);
            this.MoveProductDataGridView.Name = "MoveProductDataGridView";
            this.MoveProductDataGridView.ReadOnly = true;
            this.MoveProductDataGridView.RowHeadersVisible = false;
            this.MoveProductDataGridView.Size = new System.Drawing.Size(986, 611);
            this.MoveProductDataGridView.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.OrganizationAddButton);
            this.tabPage5.Controls.Add(this.OrganizationPanel);
            this.tabPage5.Controls.Add(this.OrganizationDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(992, 654);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Организация";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // OrganizationAddButton
            // 
            this.OrganizationAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizationAddButton.BackColor = System.Drawing.Color.White;
            this.OrganizationAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrganizationAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrganizationAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.OrganizationAddButton.Location = new System.Drawing.Point(3, 620);
            this.OrganizationAddButton.Name = "OrganizationAddButton";
            this.OrganizationAddButton.Size = new System.Drawing.Size(986, 30);
            this.OrganizationAddButton.TabIndex = 14;
            this.OrganizationAddButton.UseVisualStyleBackColor = false;
            // 
            // OrganizationPanel
            // 
            this.OrganizationPanel.Controls.Add(рНН_организацииLabel);
            this.OrganizationPanel.Controls.Add(this.рНН_организацииTextBox);
            this.OrganizationPanel.Controls.Add(наименованиеLabel1);
            this.OrganizationPanel.Controls.Add(this.наименованиеTextBox1);
            this.OrganizationPanel.Controls.Add(код_банкаLabel);
            this.OrganizationPanel.Controls.Add(this.код_банкаComboBox);
            this.OrganizationPanel.Controls.Add(лицевой_счет_организацииLabel);
            this.OrganizationPanel.Controls.Add(this.лицевой_счет_организацииTextBox);
            this.OrganizationPanel.Controls.Add(адресLabel);
            this.OrganizationPanel.Controls.Add(this.адресTextBox);
            this.OrganizationPanel.Controls.Add(фИО_руководителяLabel);
            this.OrganizationPanel.Controls.Add(this.фИО_руководителяTextBox);
            this.OrganizationPanel.Controls.Add(телефонLabel);
            this.OrganizationPanel.Controls.Add(this.телефонTextBox);
            this.OrganizationPanel.Controls.Add(this.OrganizationCancelButton);
            this.OrganizationPanel.Controls.Add(this.OrganizationSaveButton);
            this.OrganizationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrganizationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OrganizationPanel.Location = new System.Drawing.Point(3, 381);
            this.OrganizationPanel.Name = "OrganizationPanel";
            this.OrganizationPanel.Size = new System.Drawing.Size(986, 270);
            this.OrganizationPanel.TabIndex = 13;
            // 
            // рНН_организацииTextBox
            // 
            this.рНН_организацииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrganizationBindingSource, "РНН организации", true));
            this.рНН_организацииTextBox.Location = new System.Drawing.Point(504, 2);
            this.рНН_организацииTextBox.Name = "рНН_организацииTextBox";
            this.рНН_организацииTextBox.Size = new System.Drawing.Size(233, 26);
            this.рНН_организацииTextBox.TabIndex = 18;
            // 
            // OrganizationBindingSource
            // 
            this.OrganizationBindingSource.DataMember = "Организация";
            this.OrganizationBindingSource.DataSource = this.stockDataSet;
            // 
            // наименованиеTextBox1
            // 
            this.наименованиеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrganizationBindingSource, "Наименование", true));
            this.наименованиеTextBox1.Location = new System.Drawing.Point(504, 34);
            this.наименованиеTextBox1.Name = "наименованиеTextBox1";
            this.наименованиеTextBox1.Size = new System.Drawing.Size(233, 26);
            this.наименованиеTextBox1.TabIndex = 20;
            // 
            // код_банкаComboBox
            // 
            this.код_банкаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrganizationBindingSource, "Код банка", true));
            this.код_банкаComboBox.FormattingEnabled = true;
            this.код_банкаComboBox.Location = new System.Drawing.Point(504, 66);
            this.код_банкаComboBox.Name = "код_банкаComboBox";
            this.код_банкаComboBox.Size = new System.Drawing.Size(233, 28);
            this.код_банкаComboBox.TabIndex = 22;
            // 
            // лицевой_счет_организацииTextBox
            // 
            this.лицевой_счет_организацииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrganizationBindingSource, "Лицевой счет организации", true));
            this.лицевой_счет_организацииTextBox.Location = new System.Drawing.Point(504, 100);
            this.лицевой_счет_организацииTextBox.Name = "лицевой_счет_организацииTextBox";
            this.лицевой_счет_организацииTextBox.Size = new System.Drawing.Size(233, 26);
            this.лицевой_счет_организацииTextBox.TabIndex = 24;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrganizationBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(504, 132);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(233, 26);
            this.адресTextBox.TabIndex = 26;
            // 
            // фИО_руководителяTextBox
            // 
            this.фИО_руководителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrganizationBindingSource, "ФИО руководителя", true));
            this.фИО_руководителяTextBox.Location = new System.Drawing.Point(504, 164);
            this.фИО_руководителяTextBox.Name = "фИО_руководителяTextBox";
            this.фИО_руководителяTextBox.Size = new System.Drawing.Size(233, 26);
            this.фИО_руководителяTextBox.TabIndex = 28;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrganizationBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(504, 196);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(233, 26);
            this.телефонTextBox.TabIndex = 30;
            // 
            // OrganizationCancelButton
            // 
            this.OrganizationCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrganizationCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.OrganizationCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OrganizationCancelButton.Location = new System.Drawing.Point(522, 235);
            this.OrganizationCancelButton.Name = "OrganizationCancelButton";
            this.OrganizationCancelButton.Size = new System.Drawing.Size(165, 32);
            this.OrganizationCancelButton.TabIndex = 17;
            this.OrganizationCancelButton.Text = "Отмена";
            this.OrganizationCancelButton.UseVisualStyleBackColor = true;
            // 
            // OrganizationSaveButton
            // 
            this.OrganizationSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrganizationSaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.OrganizationSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OrganizationSaveButton.Location = new System.Drawing.Point(305, 235);
            this.OrganizationSaveButton.Name = "OrganizationSaveButton";
            this.OrganizationSaveButton.Size = new System.Drawing.Size(165, 32);
            this.OrganizationSaveButton.TabIndex = 16;
            this.OrganizationSaveButton.Text = "Сохранить";
            this.OrganizationSaveButton.UseVisualStyleBackColor = true;
            // 
            // OrganizationDataGridView
            // 
            this.OrganizationDataGridView.AllowUserToAddRows = false;
            this.OrganizationDataGridView.AllowUserToDeleteRows = false;
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
            this.dataGridViewTextBoxColumn21,
            this.OrganizationChangeColumn,
            this.OrganizationDeleteColumn});
            this.OrganizationDataGridView.DataSource = this.OrganizationBindingSource;
            this.OrganizationDataGridView.Location = new System.Drawing.Point(3, 3);
            this.OrganizationDataGridView.Name = "OrganizationDataGridView";
            this.OrganizationDataGridView.ReadOnly = true;
            this.OrganizationDataGridView.RowHeadersVisible = false;
            this.OrganizationDataGridView.Size = new System.Drawing.Size(986, 611);
            this.OrganizationDataGridView.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.Controls.Add(this.BankAddButton);
            this.tabPage6.Controls.Add(this.BankDataGridView);
            this.tabPage6.Controls.Add(this.BankPanel);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(992, 654);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Банк";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // BankAddButton
            // 
            this.BankAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankAddButton.BackColor = System.Drawing.Color.White;
            this.BankAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BankAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BankAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.BankAddButton.Location = new System.Drawing.Point(3, 620);
            this.BankAddButton.Name = "BankAddButton";
            this.BankAddButton.Size = new System.Drawing.Size(986, 30);
            this.BankAddButton.TabIndex = 14;
            this.BankAddButton.UseVisualStyleBackColor = false;
            // 
            // BankDataGridView
            // 
            this.BankDataGridView.AllowUserToAddRows = false;
            this.BankDataGridView.AllowUserToDeleteRows = false;
            this.BankDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankDataGridView.AutoGenerateColumns = false;
            this.BankDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.BankChangeColumn,
            this.BankDeleteColumn});
            this.BankDataGridView.DataSource = this.BankBindingSource;
            this.BankDataGridView.Location = new System.Drawing.Point(3, 3);
            this.BankDataGridView.Name = "BankDataGridView";
            this.BankDataGridView.ReadOnly = true;
            this.BankDataGridView.RowHeadersVisible = false;
            this.BankDataGridView.Size = new System.Drawing.Size(986, 611);
            this.BankDataGridView.TabIndex = 0;
            // 
            // BankBindingSource
            // 
            this.BankBindingSource.DataMember = "Банк";
            this.BankBindingSource.DataSource = this.stockDataSet;
            // 
            // BankPanel
            // 
            this.BankPanel.Controls.Add(код_банкаLabel1);
            this.BankPanel.Controls.Add(this.код_банкаTextBox);
            this.BankPanel.Controls.Add(наименованиеLabel2);
            this.BankPanel.Controls.Add(this.наименованиеTextBox2);
            this.BankPanel.Controls.Add(this.BankCancelButton);
            this.BankPanel.Controls.Add(this.BankSaveButton);
            this.BankPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BankPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BankPanel.Location = new System.Drawing.Point(3, 414);
            this.BankPanel.Name = "BankPanel";
            this.BankPanel.Size = new System.Drawing.Size(986, 237);
            this.BankPanel.TabIndex = 13;
            // 
            // код_банкаTextBox
            // 
            this.код_банкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BankBindingSource, "Код банка", true));
            this.код_банкаTextBox.Location = new System.Drawing.Point(414, 76);
            this.код_банкаTextBox.Name = "код_банкаTextBox";
            this.код_банкаTextBox.Size = new System.Drawing.Size(299, 26);
            this.код_банкаTextBox.TabIndex = 18;
            // 
            // наименованиеTextBox2
            // 
            this.наименованиеTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BankBindingSource, "Наименование", true));
            this.наименованиеTextBox2.Location = new System.Drawing.Point(414, 108);
            this.наименованиеTextBox2.Name = "наименованиеTextBox2";
            this.наименованиеTextBox2.Size = new System.Drawing.Size(299, 26);
            this.наименованиеTextBox2.TabIndex = 20;
            // 
            // BankCancelButton
            // 
            this.BankCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BankCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.BankCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BankCancelButton.Location = new System.Drawing.Point(520, 185);
            this.BankCancelButton.Name = "BankCancelButton";
            this.BankCancelButton.Size = new System.Drawing.Size(165, 32);
            this.BankCancelButton.TabIndex = 17;
            this.BankCancelButton.Text = "Отмена";
            this.BankCancelButton.UseVisualStyleBackColor = true;
            // 
            // BankSaveButton
            // 
            this.BankSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BankSaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.BankSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BankSaveButton.Location = new System.Drawing.Point(303, 185);
            this.BankSaveButton.Name = "BankSaveButton";
            this.BankSaveButton.Size = new System.Drawing.Size(165, 32);
            this.BankSaveButton.TabIndex = 16;
            this.BankSaveButton.Text = "Сохранить";
            this.BankSaveButton.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.AutoScroll = true;
            this.tabPage7.Controls.Add(this.TaxAddButton);
            this.tabPage7.Controls.Add(this.TaxPanel);
            this.tabPage7.Controls.Add(this.TaxDataGridView);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(992, 654);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Налоги";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // TaxAddButton
            // 
            this.TaxAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxAddButton.BackColor = System.Drawing.Color.White;
            this.TaxAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaxAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaxAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.TaxAddButton.Location = new System.Drawing.Point(3, 620);
            this.TaxAddButton.Name = "TaxAddButton";
            this.TaxAddButton.Size = new System.Drawing.Size(986, 30);
            this.TaxAddButton.TabIndex = 16;
            this.TaxAddButton.UseVisualStyleBackColor = false;
            // 
            // TaxPanel
            // 
            this.TaxPanel.Controls.Add(код_налогаLabel);
            this.TaxPanel.Controls.Add(this.код_налогаTextBox);
            this.TaxPanel.Controls.Add(наименованиеLabel3);
            this.TaxPanel.Controls.Add(this.наименованиеTextBox3);
            this.TaxPanel.Controls.Add(процент_начисления_от_стоимости_товараLabel);
            this.TaxPanel.Controls.Add(this.процент_начисления_от_стоимости_товараTextBox);
            this.TaxPanel.Controls.Add(this.TaxCancelButton);
            this.TaxPanel.Controls.Add(this.TaxSaveButton);
            this.TaxPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TaxPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TaxPanel.Location = new System.Drawing.Point(3, 414);
            this.TaxPanel.Name = "TaxPanel";
            this.TaxPanel.Size = new System.Drawing.Size(986, 237);
            this.TaxPanel.TabIndex = 15;
            // 
            // код_налогаTextBox
            // 
            this.код_налогаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaxBindingSource, "Код налога", true));
            this.код_налогаTextBox.Location = new System.Drawing.Point(410, 69);
            this.код_налогаTextBox.Name = "код_налогаTextBox";
            this.код_налогаTextBox.Size = new System.Drawing.Size(302, 26);
            this.код_налогаTextBox.TabIndex = 18;
            // 
            // TaxBindingSource
            // 
            this.TaxBindingSource.DataMember = "Налоги";
            this.TaxBindingSource.DataSource = this.stockDataSet;
            // 
            // наименованиеTextBox3
            // 
            this.наименованиеTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaxBindingSource, "Наименование", true));
            this.наименованиеTextBox3.Location = new System.Drawing.Point(410, 101);
            this.наименованиеTextBox3.Name = "наименованиеTextBox3";
            this.наименованиеTextBox3.Size = new System.Drawing.Size(302, 26);
            this.наименованиеTextBox3.TabIndex = 20;
            // 
            // процент_начисления_от_стоимости_товараTextBox
            // 
            this.процент_начисления_от_стоимости_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaxBindingSource, "Процент начисления от стоимости товара", true));
            this.процент_начисления_от_стоимости_товараTextBox.Location = new System.Drawing.Point(410, 133);
            this.процент_начисления_от_стоимости_товараTextBox.Name = "процент_начисления_от_стоимости_товараTextBox";
            this.процент_начисления_от_стоимости_товараTextBox.Size = new System.Drawing.Size(302, 26);
            this.процент_начисления_от_стоимости_товараTextBox.TabIndex = 22;
            // 
            // TaxCancelButton
            // 
            this.TaxCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaxCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.TaxCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaxCancelButton.Location = new System.Drawing.Point(520, 185);
            this.TaxCancelButton.Name = "TaxCancelButton";
            this.TaxCancelButton.Size = new System.Drawing.Size(165, 32);
            this.TaxCancelButton.TabIndex = 17;
            this.TaxCancelButton.Text = "Отмена";
            this.TaxCancelButton.UseVisualStyleBackColor = true;
            // 
            // TaxSaveButton
            // 
            this.TaxSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaxSaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.TaxSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaxSaveButton.Location = new System.Drawing.Point(303, 185);
            this.TaxSaveButton.Name = "TaxSaveButton";
            this.TaxSaveButton.Size = new System.Drawing.Size(165, 32);
            this.TaxSaveButton.TabIndex = 16;
            this.TaxSaveButton.Text = "Сохранить";
            this.TaxSaveButton.UseVisualStyleBackColor = true;
            // 
            // TaxDataGridView
            // 
            this.TaxDataGridView.AllowUserToAddRows = false;
            this.TaxDataGridView.AllowUserToDeleteRows = false;
            this.TaxDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxDataGridView.AutoGenerateColumns = false;
            this.TaxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaxDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.TaxChangeColumn,
            this.TaxDeleteColumn});
            this.TaxDataGridView.DataSource = this.TaxBindingSource;
            this.TaxDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TaxDataGridView.Name = "TaxDataGridView";
            this.TaxDataGridView.ReadOnly = true;
            this.TaxDataGridView.RowHeadersVisible = false;
            this.TaxDataGridView.Size = new System.Drawing.Size(986, 611);
            this.TaxDataGridView.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.AutoScroll = true;
            this.tabPage8.Controls.Add(this.TaxingAddButton);
            this.tabPage8.Controls.Add(this.TaxingPanel);
            this.tabPage8.Controls.Add(this.TaxingDataGridView);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(992, 654);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Таксировка";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // TaxingAddButton
            // 
            this.TaxingAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxingAddButton.BackColor = System.Drawing.Color.White;
            this.TaxingAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaxingAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaxingAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.TaxingAddButton.Location = new System.Drawing.Point(3, 620);
            this.TaxingAddButton.Name = "TaxingAddButton";
            this.TaxingAddButton.Size = new System.Drawing.Size(986, 30);
            this.TaxingAddButton.TabIndex = 18;
            this.TaxingAddButton.UseVisualStyleBackColor = false;
            // 
            // TaxingPanel
            // 
            this.TaxingPanel.Controls.Add(номер_накладнойLabel2);
            this.TaxingPanel.Controls.Add(this.номер_накладнойComboBox1);
            this.TaxingPanel.Controls.Add(код_налогаLabel1);
            this.TaxingPanel.Controls.Add(this.код_налогаComboBox);
            this.TaxingPanel.Controls.Add(сумма_налогаLabel);
            this.TaxingPanel.Controls.Add(this.сумма_налогаTextBox);
            this.TaxingPanel.Controls.Add(this.TaxingCancelButton);
            this.TaxingPanel.Controls.Add(this.TaxingSaveButton);
            this.TaxingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TaxingPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TaxingPanel.Location = new System.Drawing.Point(3, 414);
            this.TaxingPanel.Name = "TaxingPanel";
            this.TaxingPanel.Size = new System.Drawing.Size(986, 237);
            this.TaxingPanel.TabIndex = 17;
            // 
            // номер_накладнойComboBox1
            // 
            this.номер_накладнойComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaxingBindingSource, "Номер накладной", true));
            this.номер_накладнойComboBox1.FormattingEnabled = true;
            this.номер_накладнойComboBox1.Location = new System.Drawing.Point(433, 64);
            this.номер_накладнойComboBox1.Name = "номер_накладнойComboBox1";
            this.номер_накладнойComboBox1.Size = new System.Drawing.Size(301, 28);
            this.номер_накладнойComboBox1.TabIndex = 20;
            // 
            // TaxingBindingSource
            // 
            this.TaxingBindingSource.DataMember = "Таксировка";
            this.TaxingBindingSource.DataSource = this.stockDataSet;
            // 
            // код_налогаComboBox
            // 
            this.код_налогаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaxingBindingSource, "Код налога", true));
            this.код_налогаComboBox.FormattingEnabled = true;
            this.код_налогаComboBox.Location = new System.Drawing.Point(433, 98);
            this.код_налогаComboBox.Name = "код_налогаComboBox";
            this.код_налогаComboBox.Size = new System.Drawing.Size(301, 28);
            this.код_налогаComboBox.TabIndex = 22;
            // 
            // сумма_налогаTextBox
            // 
            this.сумма_налогаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaxingBindingSource, "Сумма налога", true));
            this.сумма_налогаTextBox.Location = new System.Drawing.Point(433, 132);
            this.сумма_налогаTextBox.Name = "сумма_налогаTextBox";
            this.сумма_налогаTextBox.Size = new System.Drawing.Size(301, 26);
            this.сумма_налогаTextBox.TabIndex = 24;
            // 
            // TaxingCancelButton
            // 
            this.TaxingCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaxingCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.TaxingCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaxingCancelButton.Location = new System.Drawing.Point(520, 185);
            this.TaxingCancelButton.Name = "TaxingCancelButton";
            this.TaxingCancelButton.Size = new System.Drawing.Size(165, 32);
            this.TaxingCancelButton.TabIndex = 17;
            this.TaxingCancelButton.Text = "Отмена";
            this.TaxingCancelButton.UseVisualStyleBackColor = true;
            // 
            // TaxingSaveButton
            // 
            this.TaxingSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaxingSaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.TaxingSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaxingSaveButton.Location = new System.Drawing.Point(303, 185);
            this.TaxingSaveButton.Name = "TaxingSaveButton";
            this.TaxingSaveButton.Size = new System.Drawing.Size(165, 32);
            this.TaxingSaveButton.TabIndex = 16;
            this.TaxingSaveButton.Text = "Сохранить";
            this.TaxingSaveButton.UseVisualStyleBackColor = true;
            // 
            // TaxingDataGridView
            // 
            this.TaxingDataGridView.AllowUserToAddRows = false;
            this.TaxingDataGridView.AllowUserToDeleteRows = false;
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
            this.dataGridViewTextBoxColumn30,
            this.TaxingChangeColumn,
            this.TaxingDeleteColumn});
            this.TaxingDataGridView.DataSource = this.TaxingBindingSource;
            this.TaxingDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TaxingDataGridView.Name = "TaxingDataGridView";
            this.TaxingDataGridView.ReadOnly = true;
            this.TaxingDataGridView.RowHeadersVisible = false;
            this.TaxingDataGridView.Size = new System.Drawing.Size(986, 611);
            this.TaxingDataGridView.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.AutoScroll = true;
            this.tabPage9.Controls.Add(this.BalanceAddButton);
            this.tabPage9.Controls.Add(this.BalancePanel);
            this.tabPage9.Controls.Add(this.BalanceDataGridView);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(992, 654);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Остатки";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // BalanceAddButton
            // 
            this.BalanceAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceAddButton.BackColor = System.Drawing.Color.White;
            this.BalanceAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BalanceAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceAddButton.Image = global::Stock.Properties.Resources.add_icon;
            this.BalanceAddButton.Location = new System.Drawing.Point(3, 620);
            this.BalanceAddButton.Name = "BalanceAddButton";
            this.BalanceAddButton.Size = new System.Drawing.Size(986, 30);
            this.BalanceAddButton.TabIndex = 20;
            this.BalanceAddButton.UseVisualStyleBackColor = false;
            // 
            // BalancePanel
            // 
            this.BalancePanel.Controls.Add(артикул_товараLabel2);
            this.BalancePanel.Controls.Add(this.артикул_товараComboBox1);
            this.BalancePanel.Controls.Add(средняя_ценаLabel);
            this.BalancePanel.Controls.Add(this.средняя_ценаTextBox);
            this.BalancePanel.Controls.Add(количество_товара_на_начало_месяцаLabel);
            this.BalancePanel.Controls.Add(this.количество_товара_на_начало_месяцаTextBox);
            this.BalancePanel.Controls.Add(количество_приходLabel);
            this.BalancePanel.Controls.Add(this.количество_приходTextBox);
            this.BalancePanel.Controls.Add(количество_расходLabel);
            this.BalancePanel.Controls.Add(this.количество_расходTextBox);
            this.BalancePanel.Controls.Add(this.BalanceCancelButton);
            this.BalancePanel.Controls.Add(this.BalanceSaveButton);
            this.BalancePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BalancePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BalancePanel.Location = new System.Drawing.Point(3, 414);
            this.BalancePanel.Name = "BalancePanel";
            this.BalancePanel.Size = new System.Drawing.Size(986, 237);
            this.BalancePanel.TabIndex = 19;
            // 
            // артикул_товараComboBox1
            // 
            this.артикул_товараComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BalanceBindingSource, "Артикул товара", true));
            this.артикул_товараComboBox1.FormattingEnabled = true;
            this.артикул_товараComboBox1.Location = new System.Drawing.Point(553, 19);
            this.артикул_товараComboBox1.Name = "артикул_товараComboBox1";
            this.артикул_товараComboBox1.Size = new System.Drawing.Size(225, 28);
            this.артикул_товараComboBox1.TabIndex = 20;
            // 
            // BalanceBindingSource
            // 
            this.BalanceBindingSource.DataMember = "Остатки";
            this.BalanceBindingSource.DataSource = this.stockDataSet;
            // 
            // средняя_ценаTextBox
            // 
            this.средняя_ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BalanceBindingSource, "Средняя цена", true));
            this.средняя_ценаTextBox.Location = new System.Drawing.Point(553, 53);
            this.средняя_ценаTextBox.Name = "средняя_ценаTextBox";
            this.средняя_ценаTextBox.Size = new System.Drawing.Size(225, 26);
            this.средняя_ценаTextBox.TabIndex = 22;
            // 
            // количество_товара_на_начало_месяцаTextBox
            // 
            this.количество_товара_на_начало_месяцаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BalanceBindingSource, "Количество товара на начало месяца", true));
            this.количество_товара_на_начало_месяцаTextBox.Location = new System.Drawing.Point(553, 85);
            this.количество_товара_на_начало_месяцаTextBox.Name = "количество_товара_на_начало_месяцаTextBox";
            this.количество_товара_на_начало_месяцаTextBox.Size = new System.Drawing.Size(225, 26);
            this.количество_товара_на_начало_месяцаTextBox.TabIndex = 24;
            // 
            // количество_приходTextBox
            // 
            this.количество_приходTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BalanceBindingSource, "Количество приход", true));
            this.количество_приходTextBox.Location = new System.Drawing.Point(553, 117);
            this.количество_приходTextBox.Name = "количество_приходTextBox";
            this.количество_приходTextBox.Size = new System.Drawing.Size(225, 26);
            this.количество_приходTextBox.TabIndex = 26;
            // 
            // количество_расходTextBox
            // 
            this.количество_расходTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BalanceBindingSource, "Количество расход", true));
            this.количество_расходTextBox.Location = new System.Drawing.Point(553, 149);
            this.количество_расходTextBox.Name = "количество_расходTextBox";
            this.количество_расходTextBox.Size = new System.Drawing.Size(225, 26);
            this.количество_расходTextBox.TabIndex = 28;
            // 
            // BalanceCancelButton
            // 
            this.BalanceCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BalanceCancelButton.Image = global::Stock.Properties.Resources.delete_icon;
            this.BalanceCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BalanceCancelButton.Location = new System.Drawing.Point(520, 196);
            this.BalanceCancelButton.Name = "BalanceCancelButton";
            this.BalanceCancelButton.Size = new System.Drawing.Size(165, 32);
            this.BalanceCancelButton.TabIndex = 17;
            this.BalanceCancelButton.Text = "Отмена";
            this.BalanceCancelButton.UseVisualStyleBackColor = true;
            // 
            // BalanceSaveButton
            // 
            this.BalanceSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BalanceSaveButton.Image = global::Stock.Properties.Resources.Save_icon;
            this.BalanceSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BalanceSaveButton.Location = new System.Drawing.Point(303, 196);
            this.BalanceSaveButton.Name = "BalanceSaveButton";
            this.BalanceSaveButton.Size = new System.Drawing.Size(165, 32);
            this.BalanceSaveButton.TabIndex = 16;
            this.BalanceSaveButton.Text = "Сохранить";
            this.BalanceSaveButton.UseVisualStyleBackColor = true;
            // 
            // BalanceDataGridView
            // 
            this.BalanceDataGridView.AllowUserToAddRows = false;
            this.BalanceDataGridView.AllowUserToDeleteRows = false;
            this.BalanceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceDataGridView.AutoGenerateColumns = false;
            this.BalanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BalanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BalanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.BalanceChangeColumn,
            this.BalanceDeleteColumn});
            this.BalanceDataGridView.DataSource = this.BalanceBindingSource;
            this.BalanceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.BalanceDataGridView.Name = "BalanceDataGridView";
            this.BalanceDataGridView.ReadOnly = true;
            this.BalanceDataGridView.RowHeadersVisible = false;
            this.BalanceDataGridView.Size = new System.Drawing.Size(986, 611);
            this.BalanceDataGridView.TabIndex = 0;
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
            // BankTableAdapter
            // 
            this.BankTableAdapter.ClearBeforeFill = true;
            // 
            // MoveProductTableAdapter
            // 
            this.MoveProductTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceTableAdapter
            // 
            this.InvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // TaxTableAdapter
            // 
            this.TaxTableAdapter.ClearBeforeFill = true;
            // 
            // OrganizationTableAdapter
            // 
            this.OrganizationTableAdapter.ClearBeforeFill = true;
            // 
            // BalanceTableAdapter
            // 
            this.BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // DivisionsTableAdapter
            // 
            this.DivisionsTableAdapter.ClearBeforeFill = true;
            // 
            // TaxingTableAdapter
            // 
            this.TaxingTableAdapter.ClearBeforeFill = true;
            // 
            // ProductTableAdapter
            // 
            this.ProductTableAdapter.ClearBeforeFill = true;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1584, 24);
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
            // ProductChangeColumn
            // 
            this.ProductChangeColumn.FillWeight = 20F;
            this.ProductChangeColumn.HeaderText = "Редактировать";
            this.ProductChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.ProductChangeColumn.Name = "ProductChangeColumn";
            this.ProductChangeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductChangeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductDeleteColumn
            // 
            this.ProductDeleteColumn.FillWeight = 20F;
            this.ProductDeleteColumn.HeaderText = "Удалить";
            this.ProductDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.ProductDeleteColumn.Name = "ProductDeleteColumn";
            this.ProductDeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDeleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ФИО кладовщика";
            this.dataGridViewTextBoxColumn9.HeaderText = "ФИО кладовщика";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // DivisionsChangeColumn
            // 
            this.DivisionsChangeColumn.FillWeight = 20F;
            this.DivisionsChangeColumn.HeaderText = "Редактировать";
            this.DivisionsChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.DivisionsChangeColumn.Name = "DivisionsChangeColumn";
            this.DivisionsChangeColumn.ReadOnly = true;
            // 
            // DivisionsDeleteColumn
            // 
            this.DivisionsDeleteColumn.FillWeight = 20F;
            this.DivisionsDeleteColumn.HeaderText = "Удалить";
            this.DivisionsDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.DivisionsDeleteColumn.Name = "DivisionsDeleteColumn";
            this.DivisionsDeleteColumn.ReadOnly = true;
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
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // признакТипаНакладнойDataGridViewTextBoxColumn
            // 
            this.признакТипаНакладнойDataGridViewTextBoxColumn.DataPropertyName = "Признак типа накладной";
            this.признакТипаНакладнойDataGridViewTextBoxColumn.HeaderText = "Признак типа накладной";
            this.признакТипаНакладнойDataGridViewTextBoxColumn.Name = "признакТипаНакладнойDataGridViewTextBoxColumn";
            this.признакТипаНакладнойDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодОрганизацииDataGridViewTextBoxColumn
            // 
            this.кодОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "Код организации";
            this.кодОрганизацииDataGridViewTextBoxColumn.HeaderText = "Код организации";
            this.кодОрганизацииDataGridViewTextBoxColumn.Name = "кодОрганизацииDataGridViewTextBoxColumn";
            this.кодОрганизацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодСкладаDataGridViewTextBoxColumn
            // 
            this.кодСкладаDataGridViewTextBoxColumn.DataPropertyName = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.HeaderText = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.Name = "кодСкладаDataGridViewTextBoxColumn";
            this.кодСкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InvoiceCahngeColoumn
            // 
            this.InvoiceCahngeColoumn.FillWeight = 20F;
            this.InvoiceCahngeColoumn.HeaderText = "Редактировать";
            this.InvoiceCahngeColoumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.InvoiceCahngeColoumn.Name = "InvoiceCahngeColoumn";
            this.InvoiceCahngeColoumn.ReadOnly = true;
            // 
            // InvoiceDeleteColumn
            // 
            this.InvoiceDeleteColumn.FillWeight = 20F;
            this.InvoiceDeleteColumn.HeaderText = "Удалить";
            this.InvoiceDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.InvoiceDeleteColumn.Name = "InvoiceDeleteColumn";
            this.InvoiceDeleteColumn.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Артикул товара";
            this.dataGridViewTextBoxColumn12.HeaderText = "Артикул товара";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Количество товара";
            this.dataGridViewTextBoxColumn13.HeaderText = "Количество товара";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn14.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // MoveProductChangeColumn
            // 
            this.MoveProductChangeColumn.FillWeight = 20F;
            this.MoveProductChangeColumn.HeaderText = "Редактировать";
            this.MoveProductChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.MoveProductChangeColumn.Name = "MoveProductChangeColumn";
            this.MoveProductChangeColumn.ReadOnly = true;
            // 
            // MoveProductDeleteColumn
            // 
            this.MoveProductDeleteColumn.FillWeight = 20F;
            this.MoveProductDeleteColumn.HeaderText = "Удалить";
            this.MoveProductDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.MoveProductDeleteColumn.Name = "MoveProductDeleteColumn";
            this.MoveProductDeleteColumn.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Код банка";
            this.dataGridViewTextBoxColumn17.HeaderText = "Код банка";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Лицевой счет организации";
            this.dataGridViewTextBoxColumn18.HeaderText = "Лицевой счет организации";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn19.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ФИО руководителя";
            this.dataGridViewTextBoxColumn20.HeaderText = "ФИО руководителя";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn21.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // OrganizationChangeColumn
            // 
            this.OrganizationChangeColumn.FillWeight = 20F;
            this.OrganizationChangeColumn.HeaderText = "Редактировать";
            this.OrganizationChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.OrganizationChangeColumn.Name = "OrganizationChangeColumn";
            this.OrganizationChangeColumn.ReadOnly = true;
            // 
            // OrganizationDeleteColumn
            // 
            this.OrganizationDeleteColumn.FillWeight = 20F;
            this.OrganizationDeleteColumn.HeaderText = "Удалить";
            this.OrganizationDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.OrganizationDeleteColumn.Name = "OrganizationDeleteColumn";
            this.OrganizationDeleteColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Код банка";
            this.dataGridViewTextBoxColumn22.HeaderText = "Код банка";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn23.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // BankChangeColumn
            // 
            this.BankChangeColumn.FillWeight = 20F;
            this.BankChangeColumn.HeaderText = "Редактировать";
            this.BankChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.BankChangeColumn.Name = "BankChangeColumn";
            this.BankChangeColumn.ReadOnly = true;
            // 
            // BankDeleteColumn
            // 
            this.BankDeleteColumn.FillWeight = 20F;
            this.BankDeleteColumn.HeaderText = "Удалить";
            this.BankDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.BankDeleteColumn.Name = "BankDeleteColumn";
            this.BankDeleteColumn.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Процент начисления от стоимости товара";
            this.dataGridViewTextBoxColumn26.HeaderText = "Процент начисления от стоимости товара";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // TaxChangeColumn
            // 
            this.TaxChangeColumn.FillWeight = 20F;
            this.TaxChangeColumn.HeaderText = "Редактировать";
            this.TaxChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.TaxChangeColumn.Name = "TaxChangeColumn";
            this.TaxChangeColumn.ReadOnly = true;
            this.TaxChangeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TaxChangeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TaxDeleteColumn
            // 
            this.TaxDeleteColumn.FillWeight = 20F;
            this.TaxDeleteColumn.HeaderText = "Удалить";
            this.TaxDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.TaxDeleteColumn.Name = "TaxDeleteColumn";
            this.TaxDeleteColumn.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Код налога";
            this.dataGridViewTextBoxColumn29.HeaderText = "Код налога";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Сумма налога";
            this.dataGridViewTextBoxColumn30.HeaderText = "Сумма налога";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // TaxingChangeColumn
            // 
            this.TaxingChangeColumn.FillWeight = 20F;
            this.TaxingChangeColumn.HeaderText = "Редактировать";
            this.TaxingChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.TaxingChangeColumn.Name = "TaxingChangeColumn";
            this.TaxingChangeColumn.ReadOnly = true;
            // 
            // TaxingDeleteColumn
            // 
            this.TaxingDeleteColumn.FillWeight = 20F;
            this.TaxingDeleteColumn.HeaderText = "Удалить";
            this.TaxingDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.TaxingDeleteColumn.Name = "TaxingDeleteColumn";
            this.TaxingDeleteColumn.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Средняя цена";
            this.dataGridViewTextBoxColumn33.HeaderText = "Средняя цена";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Количество товара на начало месяца";
            this.dataGridViewTextBoxColumn34.HeaderText = "Количество товара на начало месяца";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Количество приход";
            this.dataGridViewTextBoxColumn35.HeaderText = "Количество приход";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Количество расход";
            this.dataGridViewTextBoxColumn36.HeaderText = "Количество расход";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // BalanceChangeColumn
            // 
            this.BalanceChangeColumn.FillWeight = 20F;
            this.BalanceChangeColumn.HeaderText = "Редактировать";
            this.BalanceChangeColumn.Image = global::Stock.Properties.Resources.edit_icon;
            this.BalanceChangeColumn.Name = "BalanceChangeColumn";
            this.BalanceChangeColumn.ReadOnly = true;
            // 
            // BalanceDeleteColumn
            // 
            this.BalanceDeleteColumn.FillWeight = 20F;
            this.BalanceDeleteColumn.HeaderText = "Удалить";
            this.BalanceDeleteColumn.Image = global::Stock.Properties.Resources.delete_icon;
            this.BalanceDeleteColumn.Name = "BalanceDeleteColumn";
            this.BalanceDeleteColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ProductGroupBox.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.CategoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            this.CategoryPanel.ResumeLayout(false);
            this.CategoryPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.DivisionsPanel.ResumeLayout(false);
            this.DivisionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionsDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.InvoicePanel.ResumeLayout(false);
            this.InvoicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.MoveProductPanel.ResumeLayout(false);
            this.MoveProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProductDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.OrganizationPanel.ResumeLayout(false);
            this.OrganizationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationDataGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BankDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankBindingSource)).EndInit();
            this.BankPanel.ResumeLayout(false);
            this.BankPanel.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.TaxPanel.ResumeLayout(false);
            this.TaxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxDataGridView)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.TaxingPanel.ResumeLayout(false);
            this.TaxingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxingDataGridView)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.BalancePanel.ResumeLayout(false);
            this.BalancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDataGridView)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
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
        private StockDataSetTableAdapters.ТоварTableAdapter ProductTableAdapter;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private StockDataSetTableAdapters.ПодразделенияTableAdapter DivisionsTableAdapter;
        private System.Windows.Forms.BindingSource DivisionsBindingSource;
        private System.Windows.Forms.DataGridView DivisionsDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private StockDataSetTableAdapters.Движение_товараTableAdapter MoveProductTableAdapter;
        private System.Windows.Forms.BindingSource MoveProductBindingSource;
        private System.Windows.Forms.DataGridView MoveProductDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private StockDataSetTableAdapters.НакладныеTableAdapter InvoiceTableAdapter;
        private System.Windows.Forms.BindingSource InvoiceBindingSource;
        private System.Windows.Forms.DataGridView InvoiceDataGridView;
        private System.Windows.Forms.TabPage tabPage5;
        private StockDataSetTableAdapters.ОрганизацияTableAdapter OrganizationTableAdapter;
        private System.Windows.Forms.BindingSource OrganizationBindingSource;
        private System.Windows.Forms.DataGridView OrganizationDataGridView;
        private System.Windows.Forms.TabPage tabPage6;
        private StockDataSetTableAdapters.БанкTableAdapter BankTableAdapter;
        private System.Windows.Forms.BindingSource BankBindingSource;
        private System.Windows.Forms.DataGridView BankDataGridView;
        private System.Windows.Forms.TabPage tabPage7;
        private StockDataSetTableAdapters.НалогиTableAdapter TaxTableAdapter;
        private System.Windows.Forms.BindingSource TaxBindingSource;
        private System.Windows.Forms.DataGridView TaxDataGridView;
        private System.Windows.Forms.TabPage tabPage8;
        private StockDataSetTableAdapters.ТаксировкаTableAdapter TaxingTableAdapter;
        private System.Windows.Forms.BindingSource TaxingBindingSource;
        private System.Windows.Forms.DataGridView TaxingDataGridView;
        private System.Windows.Forms.TabPage tabPage9;
        private StockDataSetTableAdapters.ОстаткиTableAdapter BalanceTableAdapter;
        private System.Windows.Forms.BindingSource BalanceBindingSource;
        private System.Windows.Forms.DataGridView BalanceDataGridView;
        private System.Windows.Forms.Button CategoryAddButton;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.TextBox артикул_товараTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox еденица_измеренияTextBox;
        private System.Windows.Forms.TextBox код_категории_товараTextBox1;
        private System.Windows.Forms.Button ProductCancelButton;
        private System.Windows.Forms.Button ProductSaveButton;
        private System.Windows.Forms.Button ProductAddButton;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.Button CategoryCancelButton;
        private System.Windows.Forms.Button CategorySaveButton;
        private System.Windows.Forms.TextBox код_категории_товараTextBox;
        private System.Windows.Forms.TextBox наименование_категорииTextBox;
        private System.Windows.Forms.Button DivisionsAddButton;
        private System.Windows.Forms.Panel DivisionsPanel;
        private System.Windows.Forms.TextBox номер_складаTextBox;
        private System.Windows.Forms.TextBox наименование_складаTextBox;
        private System.Windows.Forms.TextBox фИО_кладовщикаTextBox;
        private System.Windows.Forms.Button DivisionsCancelButton;
        private System.Windows.Forms.Button DivisionsSaveButton;
        private System.Windows.Forms.Button InvoiceAddButton;
        private System.Windows.Forms.Panel InvoicePanel;
        private System.Windows.Forms.Button InvoiceCancelButton;
        private System.Windows.Forms.Button InvoiceSaveButton;
        private System.Windows.Forms.TextBox номер_накладнойTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox признак_типа_накладнойTextBox;
        private System.Windows.Forms.ComboBox код_организацииComboBox;
        private System.Windows.Forms.ComboBox код_складаComboBox;
        private System.Windows.Forms.Button MoveProductAddButton;
        private System.Windows.Forms.Panel MoveProductPanel;
        private System.Windows.Forms.Button MoveProductCancelButton;
        private System.Windows.Forms.Button MoveProductButton;
        private System.Windows.Forms.ComboBox номер_накладнойComboBox;
        private System.Windows.Forms.ComboBox артикул_товараComboBox;
        private System.Windows.Forms.TextBox количество_товараTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.Button OrganizationAddButton;
        private System.Windows.Forms.Panel OrganizationPanel;
        private System.Windows.Forms.TextBox рНН_организацииTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox1;
        private System.Windows.Forms.ComboBox код_банкаComboBox;
        private System.Windows.Forms.TextBox лицевой_счет_организацииTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox фИО_руководителяTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.Button OrganizationCancelButton;
        private System.Windows.Forms.Button OrganizationSaveButton;
        private System.Windows.Forms.Button BankAddButton;
        private System.Windows.Forms.Panel BankPanel;
        private System.Windows.Forms.TextBox код_банкаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox2;
        private System.Windows.Forms.Button BankCancelButton;
        private System.Windows.Forms.Button BankSaveButton;
        private System.Windows.Forms.Button TaxAddButton;
        private System.Windows.Forms.Panel TaxPanel;
        private System.Windows.Forms.TextBox код_налогаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox3;
        private System.Windows.Forms.TextBox процент_начисления_от_стоимости_товараTextBox;
        private System.Windows.Forms.Button TaxCancelButton;
        private System.Windows.Forms.Button TaxSaveButton;
        private System.Windows.Forms.Button TaxingAddButton;
        private System.Windows.Forms.Panel TaxingPanel;
        private System.Windows.Forms.ComboBox номер_накладнойComboBox1;
        private System.Windows.Forms.ComboBox код_налогаComboBox;
        private System.Windows.Forms.TextBox сумма_налогаTextBox;
        private System.Windows.Forms.Button TaxingCancelButton;
        private System.Windows.Forms.Button TaxingSaveButton;
        private System.Windows.Forms.Button BalanceAddButton;
        private System.Windows.Forms.Panel BalancePanel;
        private System.Windows.Forms.ComboBox артикул_товараComboBox1;
        private System.Windows.Forms.TextBox средняя_ценаTextBox;
        private System.Windows.Forms.TextBox количество_товара_на_начало_месяцаTextBox;
        private System.Windows.Forms.TextBox количество_приходTextBox;
        private System.Windows.Forms.TextBox количество_расходTextBox;
        private System.Windows.Forms.Button BalanceCancelButton;
        private System.Windows.Forms.Button BalanceSaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn CategoryChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn CategoryDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn ProductChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn ProductDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewImageColumn DivisionsChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn DivisionsDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерНакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn признакТипаНакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОрганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn InvoiceCahngeColoumn;
        private System.Windows.Forms.DataGridViewImageColumn InvoiceDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewImageColumn MoveProductChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn MoveProductDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewImageColumn OrganizationChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn OrganizationDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewImageColumn BankChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn BankDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewImageColumn TaxChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn TaxDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewImageColumn TaxingChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn TaxingDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewImageColumn BalanceChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn BalanceDeleteColumn;
    }
}

