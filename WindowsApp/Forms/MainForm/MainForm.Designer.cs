using WindowsApp.Database;
namespace WindowsApp.Forms
{
    partial class MainForm
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
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label middlenameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label passport_serialLabel;
            System.Windows.Forms.Label passport_numberLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label address_lifeLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label jobnameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passport_serialLabel1;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label engine_TypeLabel;
            System.Windows.Forms.Label type_of_driveLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.driverLicense = new System.Windows.Forms.TabControl();
            this.driversPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.driversDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gibddDataSet = new WindowsApp.Database.gibddDataSet();
            this.driversBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.driversBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteData = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.Button();
            this.newData = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.jobnameTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.realAddress = new System.Windows.Forms.TextBox();
            this.regAddress = new System.Windows.Forms.TextBox();
            this.driverPhoto = new System.Windows.Forms.PictureBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.middlenameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.regCity = new System.Windows.Forms.TextBox();
            this.realCity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passport_numberTextBox = new System.Windows.Forms.TextBox();
            this.passport_serialTextBox1 = new System.Windows.Forms.TextBox();
            this.passport_serialTextBox = new System.Windows.Forms.TextBox();
            this.finesPage = new System.Windows.Forms.TabPage();
            this.CarFinePic = new System.Windows.Forms.PictureBox();
            this.FinesSummary = new System.Windows.Forms.DataGridView();
            this.getUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.doGET_button = new System.Windows.Forms.Button();
            this.responseLabel = new System.Windows.Forms.Label();
            this.partBox = new System.Windows.Forms.TextBox();
            this.modifedDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.response = new System.Windows.Forms.TextBox();
            this.licPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.bindingNavigatorDriverLicenses = new System.Windows.Forms.BindingNavigator(this.components);
            this.driverLicenseAddItem = new System.Windows.Forms.ToolStripButton();
            this.drivers_LicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.driverLicenseDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.driverLicenseFirstItem = new System.Windows.Forms.ToolStripButton();
            this.driverLicensePrevItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.driverLicenseNextItem = new System.Windows.Forms.ToolStripButton();
            this.driverLicenseLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.driverLicenseSaveItem = new System.Windows.Forms.ToolStripButton();
            this.drivers_LicsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLicenseSaveImageButton = new System.Windows.Forms.Button();
            this.driverLicenseButton = new System.Windows.Forms.Button();
            this.driverLicenseImage = new System.Windows.Forms.PictureBox();
            this.carPage = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.vehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverCarsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.driverCarsAddItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.driverCarsDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.driverCarsFirstItem = new System.Windows.Forms.ToolStripButton();
            this.driverCarsPrevItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.driverCarsNextItem = new System.Windows.Forms.ToolStripButton();
            this.driverCarsLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.driverCarsSaveItem = new System.Windows.Forms.ToolStripButton();
            this.SaveNewCarButton = new System.Windows.Forms.Button();
            this.type_of_driveTextBox = new System.Windows.Forms.TextBox();
            this.engine_TypeTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.driversTableAdapter = new WindowsApp.Database.gibddDataSetTableAdapters.driversTableAdapter();
            this.tableAdapterManager = new WindowsApp.Database.gibddDataSetTableAdapters.TableAdapterManager();
            this.licencesTableAdapter = new WindowsApp.Database.gibddDataSetTableAdapters.licencesTableAdapter();
            this.licencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drivers_LicsTableAdapter = new WindowsApp.Database.gibddDataSetTableAdapters.Drivers_LicsTableAdapter();
            this.vehiclesTableAdapter = new WindowsApp.Database.gibddDataSetTableAdapters.vehiclesTableAdapter();
            firstnameLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            middlenameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            passport_serialLabel = new System.Windows.Forms.Label();
            passport_numberLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            address_lifeLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            jobnameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passport_serialLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            vINLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            engine_TypeLabel = new System.Windows.Forms.Label();
            type_of_driveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.driverLicense.SuspendLayout();
            this.driversPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibddDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).BeginInit();
            this.driversBindingNavigator.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.finesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarFinePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinesSummary)).BeginInit();
            this.licPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDriverLicenses)).BeginInit();
            this.bindingNavigatorDriverLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivers_LicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drivers_LicsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverLicenseImage)).BeginInit();
            this.carPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverCarsBindingNavigator)).BeginInit();
            this.driverCarsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licencesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(84, 16);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(29, 13);
            firstnameLabel.TabIndex = 0;
            firstnameLabel.Text = "Имя";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(2, 22);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(36, 13);
            photoLabel.TabIndex = 3;
            photoLabel.Text = "Файл";
            // 
            // middlenameLabel
            // 
            middlenameLabel.AutoSize = true;
            middlenameLabel.Location = new System.Drawing.Point(84, 55);
            middlenameLabel.Name = "middlenameLabel";
            middlenameLabel.Size = new System.Drawing.Size(54, 13);
            middlenameLabel.TabIndex = 4;
            middlenameLabel.Text = "Отчество";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(84, 94);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(56, 13);
            lastnameLabel.TabIndex = 6;
            lastnameLabel.Text = "Фамилия";
            // 
            // passport_serialLabel
            // 
            passport_serialLabel.AutoSize = true;
            passport_serialLabel.Location = new System.Drawing.Point(7, 126);
            passport_serialLabel.Name = "passport_serialLabel";
            passport_serialLabel.Size = new System.Drawing.Size(77, 13);
            passport_serialLabel.TabIndex = 8;
            passport_serialLabel.Text = "passport serial:";
            // 
            // passport_numberLabel
            // 
            passport_numberLabel.AutoSize = true;
            passport_numberLabel.Location = new System.Drawing.Point(2, 51);
            passport_numberLabel.Name = "passport_numberLabel";
            passport_numberLabel.Size = new System.Drawing.Size(41, 13);
            passport_numberLabel.TabIndex = 11;
            passport_numberLabel.Text = "Номер";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(2, 144);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(45, 13);
            postcodeLabel.TabIndex = 13;
            postcodeLabel.Text = "Индекс";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(3, 164);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(105, 13);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Адрес регистрации";
            // 
            // address_lifeLabel
            // 
            address_lifeLabel.AutoSize = true;
            address_lifeLabel.BackColor = System.Drawing.Color.Transparent;
            address_lifeLabel.Location = new System.Drawing.Point(2, 203);
            address_lifeLabel.Name = "address_lifeLabel";
            address_lifeLabel.Size = new System.Drawing.Size(103, 13);
            address_lifeLabel.TabIndex = 17;
            address_lifeLabel.Text = "Адрес проживания";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(2, 22);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(58, 13);
            companyLabel.TabIndex = 19;
            companyLabel.Text = "Компания";
            // 
            // jobnameLabel
            // 
            jobnameLabel.AutoSize = true;
            jobnameLabel.Location = new System.Drawing.Point(2, 48);
            jobnameLabel.Name = "jobnameLabel";
            jobnameLabel.Size = new System.Drawing.Size(65, 13);
            jobnameLabel.TabIndex = 21;
            jobnameLabel.Text = "Должность";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(2, 242);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 23;
            phoneLabel.Text = "Телефон";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(3, 281);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(36, 13);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "E-Mail";
            // 
            // passport_serialLabel1
            // 
            passport_serialLabel1.AutoSize = true;
            passport_serialLabel1.Location = new System.Drawing.Point(3, 25);
            passport_serialLabel1.Name = "passport_serialLabel1";
            passport_serialLabel1.Size = new System.Drawing.Size(38, 13);
            passport_serialLabel1.TabIndex = 26;
            passport_serialLabel1.Text = "Серия";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(130, 713);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 35;
            idLabel.Text = "id:";
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(55, 6);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(28, 13);
            vINLabel.TabIndex = 0;
            vINLabel.Text = "VIN:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(2, 32);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(81, 13);
            manufacturerLabel.TabIndex = 2;
            manufacturerLabel.Text = "Изготовитель:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(34, 58);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(49, 13);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Модель:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(55, 84);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(28, 13);
            yearLabel.TabIndex = 6;
            yearLabel.Text = "Год:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(54, 114);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(29, 13);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "Вес:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(48, 136);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(35, 13);
            colorLabel.TabIndex = 10;
            colorLabel.Text = "Цвет:";
            // 
            // engine_TypeLabel
            // 
            engine_TypeLabel.AutoSize = true;
            engine_TypeLabel.Location = new System.Drawing.Point(13, 162);
            engine_TypeLabel.Name = "engine_TypeLabel";
            engine_TypeLabel.Size = new System.Drawing.Size(70, 13);
            engine_TypeLabel.TabIndex = 12;
            engine_TypeLabel.Text = "Тип движка:";
            // 
            // type_of_driveLabel
            // 
            type_of_driveLabel.AutoSize = true;
            type_of_driveLabel.Location = new System.Drawing.Point(9, 188);
            type_of_driveLabel.Name = "type_of_driveLabel";
            type_of_driveLabel.Size = new System.Drawing.Size(74, 13);
            type_of_driveLabel.TabIndex = 14;
            type_of_driveLabel.Text = "Тип привода:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.driverLicense);
            this.splitContainer1.Size = new System.Drawing.Size(1309, 856);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsApp.Properties.Resources.gibdd_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Госавтоинспекция\r\nМВД России";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driverLicense
            // 
            this.driverLicense.Controls.Add(this.driversPage);
            this.driverLicense.Controls.Add(this.finesPage);
            this.driverLicense.Controls.Add(this.licPage);
            this.driverLicense.Controls.Add(this.carPage);
            this.driverLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverLicense.Location = new System.Drawing.Point(0, 0);
            this.driverLicense.Multiline = true;
            this.driverLicense.Name = "driverLicense";
            this.driverLicense.RightToLeftLayout = true;
            this.driverLicense.SelectedIndex = 0;
            this.driverLicense.Size = new System.Drawing.Size(1309, 767);
            this.driverLicense.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.driverLicense.TabIndex = 0;
            // 
            // driversPage
            // 
            this.driversPage.Controls.Add(this.splitContainer2);
            this.driversPage.Location = new System.Drawing.Point(4, 22);
            this.driversPage.Name = "driversPage";
            this.driversPage.Padding = new System.Windows.Forms.Padding(3);
            this.driversPage.Size = new System.Drawing.Size(1301, 741);
            this.driversPage.TabIndex = 1;
            this.driversPage.Text = "Водители";
            this.driversPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.driversDataGridView);
            this.splitContainer2.Panel1.Controls.Add(this.driversBindingNavigator);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.splitContainer2.Panel2.Controls.Add(idLabel);
            this.splitContainer2.Panel2.Controls.Add(this.idTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.deleteData);
            this.splitContainer2.Panel2.Controls.Add(this.saveData);
            this.splitContainer2.Panel2.Controls.Add(this.newData);
            this.splitContainer2.Panel2.Controls.Add(this.next);
            this.splitContainer2.Panel2.Controls.Add(this.back);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(passport_serialLabel);
            this.splitContainer2.Panel2.Controls.Add(this.passport_serialTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(1295, 735);
            this.splitContainer2.SplitterDistance = 1025;
            this.splitContainer2.TabIndex = 0;
            // 
            // driversDataGridView
            // 
            this.driversDataGridView.AutoGenerateColumns = false;
            this.driversDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.driversDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.driversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.driversDataGridView.DataSource = this.driversBindingSource;
            this.driversDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driversDataGridView.Location = new System.Drawing.Point(0, 0);
            this.driversDataGridView.Name = "driversDataGridView";
            this.driversDataGridView.RowHeadersVisible = false;
            this.driversDataGridView.Size = new System.Drawing.Size(1025, 710);
            this.driversDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "middlename";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "passport_serial";
            this.dataGridViewTextBoxColumn5.HeaderText = "Серия паспорта";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "passport_number";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер паспорта";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "postcode";
            this.dataGridViewTextBoxColumn7.HeaderText = "Почтовый индекс";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn8.HeaderText = "Адрес прописки";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "address_life";
            this.dataGridViewTextBoxColumn9.HeaderText = "Фактический адрес";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "company";
            this.dataGridViewTextBoxColumn10.HeaderText = "Компания";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "jobname";
            this.dataGridViewTextBoxColumn11.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn12.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn13.HeaderText = "Почта";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "photo";
            this.dataGridViewTextBoxColumn14.HeaderText = "Фотография";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "drivers";
            this.driversBindingSource.DataSource = this.gibddDataSet;
            // 
            // gibddDataSet
            // 
            this.gibddDataSet.DataSetName = "gibddDataSet";
            this.gibddDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driversBindingNavigator
            // 
            this.driversBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driversBindingNavigator.BindingSource = this.driversBindingSource;
            this.driversBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driversBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.driversBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.driversBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.driversBindingNavigatorSaveItem});
            this.driversBindingNavigator.Location = new System.Drawing.Point(0, 710);
            this.driversBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driversBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driversBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driversBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driversBindingNavigator.Name = "driversBindingNavigator";
            this.driversBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driversBindingNavigator.Size = new System.Drawing.Size(1025, 25);
            this.driversBindingNavigator.TabIndex = 1;
            this.driversBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "для {0}";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // driversBindingNavigatorSaveItem
            // 
            this.driversBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driversBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driversBindingNavigatorSaveItem.Image")));
            this.driversBindingNavigatorSaveItem.Name = "driversBindingNavigatorSaveItem";
            this.driversBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.driversBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.driversBindingNavigatorSaveItem.Click += new System.EventHandler(this.DriversBindingNavigatorSaveItemClick);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(155, 710);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 36;
            // 
            // deleteData
            // 
            this.deleteData.Location = new System.Drawing.Point(10, 681);
            this.deleteData.Name = "deleteData";
            this.deleteData.Size = new System.Drawing.Size(245, 23);
            this.deleteData.TabIndex = 35;
            this.deleteData.Text = "Удалить";
            this.deleteData.UseVisualStyleBackColor = true;
            this.deleteData.Click += new System.EventHandler(this.DeleteDataClick);
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(142, 652);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(113, 23);
            this.saveData.TabIndex = 34;
            this.saveData.Text = "Сохранить";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.SaveDataClick);
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(10, 652);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(113, 23);
            this.newData.TabIndex = 33;
            this.newData.Text = "Новая запись";
            this.newData.UseVisualStyleBackColor = true;
            this.newData.Click += new System.EventHandler(this.NewDataClick);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(142, 623);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(113, 23);
            this.next.TabIndex = 32;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.NextClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(10, 623);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 23);
            this.back.TabIndex = 31;
            this.back.Text = "<<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.BackClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.photoTextBox);
            this.groupBox4.Controls.Add(photoLabel);
            this.groupBox4.Location = new System.Drawing.Point(10, 500);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 53);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фото";
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(66, 19);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(179, 20);
            this.photoTextBox.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.jobnameTextBox);
            this.groupBox3.Controls.Add(this.companyTextBox);
            this.groupBox3.Controls.Add(companyLabel);
            this.groupBox3.Controls.Add(jobnameLabel);
            this.groupBox3.Location = new System.Drawing.Point(10, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 73);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сведения о работе";
            // 
            // jobnameTextBox
            // 
            this.jobnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "jobname", true));
            this.jobnameTextBox.Location = new System.Drawing.Point(66, 45);
            this.jobnameTextBox.Name = "jobnameTextBox";
            this.jobnameTextBox.Size = new System.Drawing.Size(179, 20);
            this.jobnameTextBox.TabIndex = 22;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "company", true));
            this.companyTextBox.Location = new System.Drawing.Point(66, 19);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(179, 20);
            this.companyTextBox.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.realAddress);
            this.groupBox1.Controls.Add(this.regAddress);
            this.groupBox1.Controls.Add(this.driverPhoto);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.firstnameTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(firstnameLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.middlenameTextBox);
            this.groupBox1.Controls.Add(middlenameLabel);
            this.groupBox1.Controls.Add(this.lastnameTextBox);
            this.groupBox1.Controls.Add(lastnameLabel);
            this.groupBox1.Controls.Add(postcodeLabel);
            this.groupBox1.Controls.Add(this.postcodeTextBox);
            this.groupBox1.Controls.Add(address_lifeLabel);
            this.groupBox1.Controls.Add(this.regCity);
            this.groupBox1.Controls.Add(this.realCity);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 324);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основная информация";
            // 
            // realAddress
            // 
            this.realAddress.Location = new System.Drawing.Point(107, 219);
            this.realAddress.Name = "realAddress";
            this.realAddress.Size = new System.Drawing.Size(138, 20);
            this.realAddress.TabIndex = 28;
            // 
            // regAddress
            // 
            this.regAddress.Location = new System.Drawing.Point(107, 180);
            this.regAddress.Name = "regAddress";
            this.regAddress.Size = new System.Drawing.Size(138, 20);
            this.regAddress.TabIndex = 27;
            // 
            // driverPhoto
            // 
            this.driverPhoto.Image = global::WindowsApp.Properties.Resources.emptyPhoto;
            this.driverPhoto.Location = new System.Drawing.Point(6, 41);
            this.driverPhoto.Name = "driverPhoto";
            this.driverPhoto.Size = new System.Drawing.Size(75, 74);
            this.driverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.driverPhoto.TabIndex = 10;
            this.driverPhoto.TabStop = false;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(87, 32);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(158, 20);
            this.firstnameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(6, 297);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(239, 20);
            this.emailTextBox.TabIndex = 26;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(6, 258);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(239, 20);
            this.phoneTextBox.TabIndex = 24;
            // 
            // middlenameTextBox
            // 
            this.middlenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "middlename", true));
            this.middlenameTextBox.Location = new System.Drawing.Point(87, 71);
            this.middlenameTextBox.Name = "middlenameTextBox";
            this.middlenameTextBox.Size = new System.Drawing.Size(158, 20);
            this.middlenameTextBox.TabIndex = 5;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(87, 110);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(158, 20);
            this.lastnameTextBox.TabIndex = 7;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(53, 141);
            this.postcodeTextBox.MaxLength = 6;
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(192, 20);
            this.postcodeTextBox.TabIndex = 14;
            // 
            // regCity
            // 
            this.regCity.AutoCompleteCustomSource.AddRange(new string[] {
            "Cumск",
            "Красноярск",
            "Москва",
            "Санкт-Петербург",
            "Краснодар",
            "Владивосток",
            "Омск",
            "Сорск",
            "Железногорск",
            "Вологда",
            "Волгоград",
            "Минусинск",
            "Абакан",
            "Норильск",
            "Кемерово",
            "Тюмень",
            "Екатеринбург",
            "Пермь"});
            this.regCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.regCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.regCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "address", true));
            this.regCity.Location = new System.Drawing.Point(6, 180);
            this.regCity.Name = "regCity";
            this.regCity.Size = new System.Drawing.Size(95, 20);
            this.regCity.TabIndex = 16;
            // 
            // realCity
            // 
            this.realCity.AutoCompleteCustomSource.AddRange(new string[] {
            "Cumск",
            "Красноярск",
            "Москва",
            "Санкт-Петербург",
            "Краснодар",
            "Владивосток",
            "Омск",
            "Сорск",
            "Железногорск",
            "Вологда",
            "Волгоград",
            "Минусинск",
            "Абакан",
            "Норильск",
            "Кемерово",
            "Тюмень",
            "Екатеринбург",
            "Пермь"});
            this.realCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.realCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.realCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "address_life", true));
            this.realCity.Location = new System.Drawing.Point(5, 219);
            this.realCity.Name = "realCity";
            this.realCity.Size = new System.Drawing.Size(96, 20);
            this.realCity.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(passport_serialLabel1);
            this.groupBox2.Controls.Add(this.passport_numberTextBox);
            this.groupBox2.Controls.Add(this.passport_serialTextBox1);
            this.groupBox2.Controls.Add(passport_numberLabel);
            this.groupBox2.Location = new System.Drawing.Point(10, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 77);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Паспортные данные";
            // 
            // passport_numberTextBox
            // 
            this.passport_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "passport_number", true));
            this.passport_numberTextBox.Location = new System.Drawing.Point(66, 48);
            this.passport_numberTextBox.MaxLength = 6;
            this.passport_numberTextBox.Name = "passport_numberTextBox";
            this.passport_numberTextBox.Size = new System.Drawing.Size(179, 20);
            this.passport_numberTextBox.TabIndex = 12;
            // 
            // passport_serialTextBox1
            // 
            this.passport_serialTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "passport_serial", true));
            this.passport_serialTextBox1.Location = new System.Drawing.Point(66, 22);
            this.passport_serialTextBox1.MaxLength = 4;
            this.passport_serialTextBox1.Name = "passport_serialTextBox1";
            this.passport_serialTextBox1.Size = new System.Drawing.Size(179, 20);
            this.passport_serialTextBox1.TabIndex = 27;
            // 
            // passport_serialTextBox
            // 
            this.passport_serialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "passport_serial", true));
            this.passport_serialTextBox.Location = new System.Drawing.Point(90, 123);
            this.passport_serialTextBox.Name = "passport_serialTextBox";
            this.passport_serialTextBox.Size = new System.Drawing.Size(100, 20);
            this.passport_serialTextBox.TabIndex = 9;
            // 
            // finesPage
            // 
            this.finesPage.Controls.Add(this.CarFinePic);
            this.finesPage.Controls.Add(this.FinesSummary);
            this.finesPage.Controls.Add(this.getUrl);
            this.finesPage.Controls.Add(this.label6);
            this.finesPage.Controls.Add(this.doGET_button);
            this.finesPage.Controls.Add(this.responseLabel);
            this.finesPage.Controls.Add(this.partBox);
            this.finesPage.Controls.Add(this.modifedDate);
            this.finesPage.Controls.Add(this.label4);
            this.finesPage.Controls.Add(this.label3);
            this.finesPage.Controls.Add(this.label2);
            this.finesPage.Controls.Add(this.response);
            this.finesPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finesPage.Location = new System.Drawing.Point(4, 22);
            this.finesPage.Name = "finesPage";
            this.finesPage.Padding = new System.Windows.Forms.Padding(3);
            this.finesPage.Size = new System.Drawing.Size(1301, 741);
            this.finesPage.TabIndex = 2;
            this.finesPage.Text = "Штрафы";
            this.finesPage.UseVisualStyleBackColor = true;
            // 
            // CarFinePic
            // 
            this.CarFinePic.Location = new System.Drawing.Point(547, 306);
            this.CarFinePic.Name = "CarFinePic";
            this.CarFinePic.Size = new System.Drawing.Size(660, 274);
            this.CarFinePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarFinePic.TabIndex = 13;
            this.CarFinePic.TabStop = false;
            // 
            // FinesSummary
            // 
            this.FinesSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FinesSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FinesSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FinesSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FinesSummary.DefaultCellStyle = dataGridViewCellStyle5;
            this.FinesSummary.Location = new System.Drawing.Point(547, 143);
            this.FinesSummary.Name = "FinesSummary";
            this.FinesSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FinesSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.FinesSummary.RowHeadersVisible = false;
            this.FinesSummary.Size = new System.Drawing.Size(660, 156);
            this.FinesSummary.TabIndex = 11;
            this.FinesSummary.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FinesSummary_CellContentDoubleClick);
            // 
            // getUrl
            // 
            this.getUrl.Location = new System.Drawing.Point(72, 93);
            this.getUrl.Name = "getUrl";
            this.getUrl.Size = new System.Drawing.Size(191, 20);
            this.getUrl.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "url";
            // 
            // doGET_button
            // 
            this.doGET_button.Location = new System.Drawing.Point(288, 61);
            this.doGET_button.Name = "doGET_button";
            this.doGET_button.Size = new System.Drawing.Size(75, 23);
            this.doGET_button.TabIndex = 7;
            this.doGET_button.Text = "GET";
            this.doGET_button.UseVisualStyleBackColor = true;
            this.doGET_button.Click += new System.EventHandler(this.TryToGetClick);
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responseLabel.Location = new System.Drawing.Point(10, 116);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(96, 24);
            this.responseLabel.TabIndex = 6;
            this.responseLabel.Text = "Response";
            // 
            // partBox
            // 
            this.partBox.Location = new System.Drawing.Point(72, 42);
            this.partBox.Name = "partBox";
            this.partBox.Size = new System.Drawing.Size(191, 20);
            this.partBox.TabIndex = 5;
            // 
            // modifedDate
            // 
            this.modifedDate.Location = new System.Drawing.Point(72, 64);
            this.modifedDate.Name = "modifedDate";
            this.modifedDate.Size = new System.Drawing.Size(191, 20);
            this.modifedDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "modified";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "participant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "getFines";
            // 
            // response
            // 
            this.response.Location = new System.Drawing.Point(14, 143);
            this.response.Multiline = true;
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(527, 437);
            this.response.TabIndex = 0;
            // 
            // licPage
            // 
            this.licPage.Controls.Add(this.splitContainer3);
            this.licPage.Location = new System.Drawing.Point(4, 22);
            this.licPage.Name = "licPage";
            this.licPage.Padding = new System.Windows.Forms.Padding(3);
            this.licPage.Size = new System.Drawing.Size(1301, 741);
            this.licPage.TabIndex = 3;
            this.licPage.Text = "ВУ";
            this.licPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.bindingNavigatorDriverLicenses);
            this.splitContainer3.Panel1.Controls.Add(this.drivers_LicsDataGridView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.driverLicenseSaveImageButton);
            this.splitContainer3.Panel2.Controls.Add(this.driverLicenseButton);
            this.splitContainer3.Panel2.Controls.Add(this.driverLicenseImage);
            this.splitContainer3.Size = new System.Drawing.Size(1295, 735);
            this.splitContainer3.SplitterDistance = 1025;
            this.splitContainer3.TabIndex = 0;
            // 
            // bindingNavigatorDriverLicenses
            // 
            this.bindingNavigatorDriverLicenses.AddNewItem = this.driverLicenseAddItem;
            this.bindingNavigatorDriverLicenses.BindingSource = this.drivers_LicsBindingSource;
            this.bindingNavigatorDriverLicenses.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorDriverLicenses.DeleteItem = this.driverLicenseDeleteItem;
            this.bindingNavigatorDriverLicenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorDriverLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverLicenseFirstItem,
            this.driverLicensePrevItem,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.driverLicenseNextItem,
            this.driverLicenseLastItem,
            this.bindingNavigatorSeparator5,
            this.driverLicenseAddItem,
            this.driverLicenseDeleteItem,
            this.driverLicenseSaveItem});
            this.bindingNavigatorDriverLicenses.Location = new System.Drawing.Point(0, 710);
            this.bindingNavigatorDriverLicenses.MoveFirstItem = this.driverLicenseFirstItem;
            this.bindingNavigatorDriverLicenses.MoveLastItem = this.driverLicenseLastItem;
            this.bindingNavigatorDriverLicenses.MoveNextItem = this.driverLicenseNextItem;
            this.bindingNavigatorDriverLicenses.MovePreviousItem = this.driverLicensePrevItem;
            this.bindingNavigatorDriverLicenses.Name = "bindingNavigatorDriverLicenses";
            this.bindingNavigatorDriverLicenses.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorDriverLicenses.Size = new System.Drawing.Size(1025, 25);
            this.bindingNavigatorDriverLicenses.TabIndex = 1;
            this.bindingNavigatorDriverLicenses.Text = "bindingNavigator1";
            // 
            // driverLicenseAddItem
            // 
            this.driverLicenseAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverLicenseAddItem.Image = ((System.Drawing.Image)(resources.GetObject("driverLicenseAddItem.Image")));
            this.driverLicenseAddItem.Name = "driverLicenseAddItem";
            this.driverLicenseAddItem.RightToLeftAutoMirrorImage = true;
            this.driverLicenseAddItem.Size = new System.Drawing.Size(23, 22);
            this.driverLicenseAddItem.Text = "Добавить";
            // 
            // drivers_LicsBindingSource
            // 
            this.drivers_LicsBindingSource.DataMember = "Drivers-Lics";
            this.drivers_LicsBindingSource.DataSource = this.gibddDataSet;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // driverLicenseDeleteItem
            // 
            this.driverLicenseDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverLicenseDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("driverLicenseDeleteItem.Image")));
            this.driverLicenseDeleteItem.Name = "driverLicenseDeleteItem";
            this.driverLicenseDeleteItem.RightToLeftAutoMirrorImage = true;
            this.driverLicenseDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.driverLicenseDeleteItem.Text = "Удалить";
            // 
            // driverLicenseFirstItem
            // 
            this.driverLicenseFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverLicenseFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("driverLicenseFirstItem.Image")));
            this.driverLicenseFirstItem.Name = "driverLicenseFirstItem";
            this.driverLicenseFirstItem.RightToLeftAutoMirrorImage = true;
            this.driverLicenseFirstItem.Size = new System.Drawing.Size(23, 22);
            this.driverLicenseFirstItem.Text = "Переместить в начало";
            // 
            // driverLicensePrevItem
            // 
            this.driverLicensePrevItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverLicensePrevItem.Image = ((System.Drawing.Image)(resources.GetObject("driverLicensePrevItem.Image")));
            this.driverLicensePrevItem.Name = "driverLicensePrevItem";
            this.driverLicensePrevItem.RightToLeftAutoMirrorImage = true;
            this.driverLicensePrevItem.Size = new System.Drawing.Size(23, 22);
            this.driverLicensePrevItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // driverLicenseNextItem
            // 
            this.driverLicenseNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverLicenseNextItem.Image = ((System.Drawing.Image)(resources.GetObject("driverLicenseNextItem.Image")));
            this.driverLicenseNextItem.Name = "driverLicenseNextItem";
            this.driverLicenseNextItem.RightToLeftAutoMirrorImage = true;
            this.driverLicenseNextItem.Size = new System.Drawing.Size(23, 22);
            this.driverLicenseNextItem.Text = "Переместить вперед";
            // 
            // driverLicenseLastItem
            // 
            this.driverLicenseLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverLicenseLastItem.Image = ((System.Drawing.Image)(resources.GetObject("driverLicenseLastItem.Image")));
            this.driverLicenseLastItem.Name = "driverLicenseLastItem";
            this.driverLicenseLastItem.RightToLeftAutoMirrorImage = true;
            this.driverLicenseLastItem.Size = new System.Drawing.Size(23, 22);
            this.driverLicenseLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // driverLicenseSaveItem
            // 
            this.driverLicenseSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverLicenseSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driverLicenseSaveItem.Image")));
            this.driverLicenseSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.driverLicenseSaveItem.Name = "driverLicenseSaveItem";
            this.driverLicenseSaveItem.Size = new System.Drawing.Size(23, 22);
            this.driverLicenseSaveItem.Text = "&Сохранить";
            this.driverLicenseSaveItem.Click += new System.EventHandler(this.DriverLicenseSaveItem);
            // 
            // drivers_LicsDataGridView
            // 
            this.drivers_LicsDataGridView.AutoGenerateColumns = false;
            this.drivers_LicsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drivers_LicsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.drivers_LicsDataGridView.DataSource = this.drivers_LicsBindingSource;
            this.drivers_LicsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drivers_LicsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.drivers_LicsDataGridView.Name = "drivers_LicsDataGridView";
            this.drivers_LicsDataGridView.RowHeadersVisible = false;
            this.drivers_LicsDataGridView.Size = new System.Drawing.Size(1025, 735);
            this.drivers_LicsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn15.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn16.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ВУ Серия";
            this.dataGridViewTextBoxColumn17.HeaderText = "ВУ Серия";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ВУ Номер";
            this.dataGridViewTextBoxColumn18.HeaderText = "ВУ Номер";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Категории";
            this.dataGridViewTextBoxColumn19.HeaderText = "Категории";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Дата выдачи";
            this.dataGridViewTextBoxColumn20.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Дата окончания";
            this.dataGridViewTextBoxColumn21.HeaderText = "Дата окончания";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // driverLicenseSaveImageButton
            // 
            this.driverLicenseSaveImageButton.Enabled = false;
            this.driverLicenseSaveImageButton.Location = new System.Drawing.Point(136, 707);
            this.driverLicenseSaveImageButton.Name = "driverLicenseSaveImageButton";
            this.driverLicenseSaveImageButton.Size = new System.Drawing.Size(124, 23);
            this.driverLicenseSaveImageButton.TabIndex = 2;
            this.driverLicenseSaveImageButton.Text = "Сохранить";
            this.driverLicenseSaveImageButton.UseVisualStyleBackColor = true;
            this.driverLicenseSaveImageButton.Click += new System.EventHandler(this.DriverLicenseSaveImage);
            // 
            // driverLicenseButton
            // 
            this.driverLicenseButton.Location = new System.Drawing.Point(3, 707);
            this.driverLicenseButton.Name = "driverLicenseButton";
            this.driverLicenseButton.Size = new System.Drawing.Size(127, 23);
            this.driverLicenseButton.TabIndex = 1;
            this.driverLicenseButton.Text = "Отобразить ВУ";
            this.driverLicenseButton.UseVisualStyleBackColor = true;
            this.driverLicenseButton.Click += new System.EventHandler(this.DriverLicensePaintClick);
            // 
            // driverLicenseImage
            // 
            this.driverLicenseImage.Location = new System.Drawing.Point(2, 550);
            this.driverLicenseImage.Name = "driverLicenseImage";
            this.driverLicenseImage.Size = new System.Drawing.Size(264, 151);
            this.driverLicenseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.driverLicenseImage.TabIndex = 0;
            this.driverLicenseImage.TabStop = false;
            // 
            // carPage
            // 
            this.carPage.Controls.Add(this.splitContainer4);
            this.carPage.Location = new System.Drawing.Point(4, 22);
            this.carPage.Name = "carPage";
            this.carPage.Padding = new System.Windows.Forms.Padding(3);
            this.carPage.Size = new System.Drawing.Size(1301, 741);
            this.carPage.TabIndex = 4;
            this.carPage.Text = "Авто";
            this.carPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.vehiclesDataGridView);
            this.splitContainer4.Panel1.Controls.Add(this.driverCarsBindingNavigator);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.AutoScroll = true;
            this.splitContainer4.Panel2.Controls.Add(this.SaveNewCarButton);
            this.splitContainer4.Panel2.Controls.Add(type_of_driveLabel);
            this.splitContainer4.Panel2.Controls.Add(this.type_of_driveTextBox);
            this.splitContainer4.Panel2.Controls.Add(engine_TypeLabel);
            this.splitContainer4.Panel2.Controls.Add(this.engine_TypeTextBox);
            this.splitContainer4.Panel2.Controls.Add(colorLabel);
            this.splitContainer4.Panel2.Controls.Add(this.colorTextBox);
            this.splitContainer4.Panel2.Controls.Add(weightLabel);
            this.splitContainer4.Panel2.Controls.Add(this.weightTextBox);
            this.splitContainer4.Panel2.Controls.Add(yearLabel);
            this.splitContainer4.Panel2.Controls.Add(this.yearTextBox);
            this.splitContainer4.Panel2.Controls.Add(modelLabel);
            this.splitContainer4.Panel2.Controls.Add(this.modelTextBox);
            this.splitContainer4.Panel2.Controls.Add(manufacturerLabel);
            this.splitContainer4.Panel2.Controls.Add(this.manufacturerTextBox);
            this.splitContainer4.Panel2.Controls.Add(vINLabel);
            this.splitContainer4.Panel2.Controls.Add(this.vinTextBox);
            this.splitContainer4.Size = new System.Drawing.Size(1295, 735);
            this.splitContainer4.SplitterDistance = 1025;
            this.splitContainer4.TabIndex = 2;
            // 
            // vehiclesDataGridView
            // 
            this.vehiclesDataGridView.AutoGenerateColumns = false;
            this.vehiclesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.vehiclesDataGridView.DataSource = this.vehiclesBindingSource;
            this.vehiclesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehiclesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vehiclesDataGridView.Name = "vehiclesDataGridView";
            this.vehiclesDataGridView.RowHeadersVisible = false;
            this.vehiclesDataGridView.Size = new System.Drawing.Size(1025, 710);
            this.vehiclesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "VIN";
            this.dataGridViewTextBoxColumn23.HeaderText = "VIN";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn24.HeaderText = "Изготовитель";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn25.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn26.HeaderText = "Год";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn27.HeaderText = "Вес";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn28.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Engine_Type";
            this.dataGridViewTextBoxColumn29.HeaderText = "Тип движка";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "type_of_drive";
            this.dataGridViewTextBoxColumn30.HeaderText = "Тип привода";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "vehicles";
            this.vehiclesBindingSource.DataSource = this.gibddDataSet;
            // 
            // driverCarsBindingNavigator
            // 
            this.driverCarsBindingNavigator.AddNewItem = this.driverCarsAddItem;
            this.driverCarsBindingNavigator.BindingSource = this.vehiclesBindingSource;
            this.driverCarsBindingNavigator.CountItem = this.toolStripLabel1;
            this.driverCarsBindingNavigator.DeleteItem = this.driverCarsDeleteItem;
            this.driverCarsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.driverCarsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverCarsFirstItem,
            this.driverCarsPrevItem,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.driverCarsNextItem,
            this.driverCarsLastItem,
            this.toolStripSeparator3,
            this.driverCarsAddItem,
            this.driverCarsDeleteItem,
            this.driverCarsSaveItem});
            this.driverCarsBindingNavigator.Location = new System.Drawing.Point(0, 710);
            this.driverCarsBindingNavigator.MoveFirstItem = this.driverCarsFirstItem;
            this.driverCarsBindingNavigator.MoveLastItem = this.driverCarsLastItem;
            this.driverCarsBindingNavigator.MoveNextItem = this.driverCarsNextItem;
            this.driverCarsBindingNavigator.MovePreviousItem = this.driverCarsPrevItem;
            this.driverCarsBindingNavigator.Name = "driverCarsBindingNavigator";
            this.driverCarsBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.driverCarsBindingNavigator.Size = new System.Drawing.Size(1025, 25);
            this.driverCarsBindingNavigator.TabIndex = 1;
            this.driverCarsBindingNavigator.Text = "bindingNavigator1";
            // 
            // driverCarsAddItem
            // 
            this.driverCarsAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverCarsAddItem.Image = ((System.Drawing.Image)(resources.GetObject("driverCarsAddItem.Image")));
            this.driverCarsAddItem.Name = "driverCarsAddItem";
            this.driverCarsAddItem.RightToLeftAutoMirrorImage = true;
            this.driverCarsAddItem.Size = new System.Drawing.Size(23, 22);
            this.driverCarsAddItem.Text = "Добавить";
            this.driverCarsAddItem.Click += new System.EventHandler(this.CarAddNewClick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // driverCarsDeleteItem
            // 
            this.driverCarsDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverCarsDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("driverCarsDeleteItem.Image")));
            this.driverCarsDeleteItem.Name = "driverCarsDeleteItem";
            this.driverCarsDeleteItem.RightToLeftAutoMirrorImage = true;
            this.driverCarsDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.driverCarsDeleteItem.Text = "Удалить";
            // 
            // driverCarsFirstItem
            // 
            this.driverCarsFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverCarsFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("driverCarsFirstItem.Image")));
            this.driverCarsFirstItem.Name = "driverCarsFirstItem";
            this.driverCarsFirstItem.RightToLeftAutoMirrorImage = true;
            this.driverCarsFirstItem.Size = new System.Drawing.Size(23, 22);
            this.driverCarsFirstItem.Text = "Переместить в начало";
            // 
            // driverCarsPrevItem
            // 
            this.driverCarsPrevItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverCarsPrevItem.Image = ((System.Drawing.Image)(resources.GetObject("driverCarsPrevItem.Image")));
            this.driverCarsPrevItem.Name = "driverCarsPrevItem";
            this.driverCarsPrevItem.RightToLeftAutoMirrorImage = true;
            this.driverCarsPrevItem.Size = new System.Drawing.Size(23, 22);
            this.driverCarsPrevItem.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // driverCarsNextItem
            // 
            this.driverCarsNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverCarsNextItem.Image = ((System.Drawing.Image)(resources.GetObject("driverCarsNextItem.Image")));
            this.driverCarsNextItem.Name = "driverCarsNextItem";
            this.driverCarsNextItem.RightToLeftAutoMirrorImage = true;
            this.driverCarsNextItem.Size = new System.Drawing.Size(23, 22);
            this.driverCarsNextItem.Text = "Переместить вперед";
            // 
            // driverCarsLastItem
            // 
            this.driverCarsLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverCarsLastItem.Image = ((System.Drawing.Image)(resources.GetObject("driverCarsLastItem.Image")));
            this.driverCarsLastItem.Name = "driverCarsLastItem";
            this.driverCarsLastItem.RightToLeftAutoMirrorImage = true;
            this.driverCarsLastItem.Size = new System.Drawing.Size(23, 22);
            this.driverCarsLastItem.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // driverCarsSaveItem
            // 
            this.driverCarsSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverCarsSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driverCarsSaveItem.Image")));
            this.driverCarsSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.driverCarsSaveItem.Name = "driverCarsSaveItem";
            this.driverCarsSaveItem.Size = new System.Drawing.Size(23, 22);
            this.driverCarsSaveItem.Text = "&Сохранить";
            this.driverCarsSaveItem.Click += new System.EventHandler(this.DriverCarsSaveItem);
            // 
            // SaveNewCarButton
            // 
            this.SaveNewCarButton.Location = new System.Drawing.Point(8, 239);
            this.SaveNewCarButton.Name = "SaveNewCarButton";
            this.SaveNewCarButton.Size = new System.Drawing.Size(252, 23);
            this.SaveNewCarButton.TabIndex = 16;
            this.SaveNewCarButton.Text = "Сохранить";
            this.SaveNewCarButton.UseVisualStyleBackColor = true;
            this.SaveNewCarButton.Click += new System.EventHandler(this.SaveNewCarButtonClick);
            // 
            // type_of_driveTextBox
            // 
            this.type_of_driveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "type_of_drive", true));
            this.type_of_driveTextBox.Location = new System.Drawing.Point(89, 185);
            this.type_of_driveTextBox.Name = "type_of_driveTextBox";
            this.type_of_driveTextBox.Size = new System.Drawing.Size(171, 20);
            this.type_of_driveTextBox.TabIndex = 15;
            // 
            // engine_TypeTextBox
            // 
            this.engine_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Engine_Type", true));
            this.engine_TypeTextBox.Location = new System.Drawing.Point(89, 159);
            this.engine_TypeTextBox.Name = "engine_TypeTextBox";
            this.engine_TypeTextBox.Size = new System.Drawing.Size(171, 20);
            this.engine_TypeTextBox.TabIndex = 13;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(89, 133);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(171, 20);
            this.colorTextBox.TabIndex = 11;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(89, 107);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(171, 20);
            this.weightTextBox.TabIndex = 9;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(89, 81);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(171, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(89, 55);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(171, 20);
            this.modelTextBox.TabIndex = 5;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(89, 29);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(171, 20);
            this.manufacturerTextBox.TabIndex = 3;
            // 
            // vinTextBox
            // 
            this.vinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "VIN", true));
            this.vinTextBox.Location = new System.Drawing.Point(89, 3);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(172, 20);
            this.vinTextBox.TabIndex = 1;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.driversTableAdapter = this.driversTableAdapter;
            this.tableAdapterManager.finesTableAdapter = null;
            this.tableAdapterManager.licencesTableAdapter = this.licencesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsApp.Database.gibddDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // licencesTableAdapter
            // 
            this.licencesTableAdapter.ClearBeforeFill = true;
            // 
            // licencesBindingSource
            // 
            this.licencesBindingSource.DataMember = "licences";
            this.licencesBindingSource.DataSource = this.gibddDataSet;
            // 
            // drivers_LicsTableAdapter
            // 
            this.drivers_LicsTableAdapter.ClearBeforeFill = true;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1309, 856);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Госавтоинспекция МВД России";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.driverLicense.ResumeLayout(false);
            this.driversPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibddDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).EndInit();
            this.driversBindingNavigator.ResumeLayout(false);
            this.driversBindingNavigator.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.finesPage.ResumeLayout(false);
            this.finesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarFinePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinesSummary)).EndInit();
            this.licPage.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDriverLicenses)).EndInit();
            this.bindingNavigatorDriverLicenses.ResumeLayout(false);
            this.bindingNavigatorDriverLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivers_LicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drivers_LicsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverLicenseImage)).EndInit();
            this.carPage.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverCarsBindingNavigator)).EndInit();
            this.driverCarsBindingNavigator.ResumeLayout(false);
            this.driverCarsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licencesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl driverLicense;
        private System.Windows.Forms.TabPage driversPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private gibddDataSet gibddDataSet;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private Database.gibddDataSetTableAdapters.driversTableAdapter driversTableAdapter;
        private Database.gibddDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator driversBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton driversBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView driversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox passport_serialTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox middlenameTextBox;
        private System.Windows.Forms.PictureBox driverPhoto;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox jobnameTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox realCity;
        private System.Windows.Forms.TextBox regCity;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox passport_numberTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox passport_serialTextBox1;
        private System.Windows.Forms.Button deleteData;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.Button newData;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox realAddress;
        private System.Windows.Forms.TextBox regAddress;
        private System.Windows.Forms.TabPage finesPage;
        private System.Windows.Forms.TextBox partBox;
        private System.Windows.Forms.DateTimePicker modifedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox response;
        private System.Windows.Forms.Button doGET_button;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.TextBox getUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage licPage;
        private System.Windows.Forms.DataGridView FinesSummary;
        private System.Windows.Forms.PictureBox CarFinePic;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.BindingSource licencesBindingSource;
        private Database.gibddDataSetTableAdapters.licencesTableAdapter licencesTableAdapter;
        private System.Windows.Forms.BindingSource drivers_LicsBindingSource;
        private Database.gibddDataSetTableAdapters.Drivers_LicsTableAdapter drivers_LicsTableAdapter;
        private System.Windows.Forms.TabPage carPage;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDriverLicenses;
        private System.Windows.Forms.ToolStripButton driverLicenseAddItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton driverLicenseDeleteItem;
        private System.Windows.Forms.ToolStripButton driverLicenseFirstItem;
        private System.Windows.Forms.ToolStripButton driverLicensePrevItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton driverLicenseNextItem;
        private System.Windows.Forms.ToolStripButton driverLicenseLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridView drivers_LicsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.ToolStripButton driverLicenseSaveItem;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.BindingNavigator driverCarsBindingNavigator;
        private System.Windows.Forms.ToolStripButton driverCarsAddItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton driverCarsDeleteItem;
        private System.Windows.Forms.ToolStripButton driverCarsFirstItem;
        private System.Windows.Forms.ToolStripButton driverCarsPrevItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton driverCarsNextItem;
        private System.Windows.Forms.ToolStripButton driverCarsLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton driverCarsSaveItem;
        private System.Windows.Forms.PictureBox driverLicenseImage;
        private System.Windows.Forms.Button driverLicenseButton;
        private System.Windows.Forms.Button driverLicenseSaveImageButton;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private Database.gibddDataSetTableAdapters.vehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.DataGridView vehiclesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.TextBox type_of_driveTextBox;
        private System.Windows.Forms.TextBox engine_TypeTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.Button SaveNewCarButton;
    }
}