
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label photoLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.driversPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.driversBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gibddDataSet = new WindowsApp.gibddDataSet();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.driversTableAdapter = new WindowsApp.gibddDataSetTableAdapters.driversTableAdapter();
            this.tableAdapterManager = new WindowsApp.gibddDataSetTableAdapters.TableAdapterManager();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            firstnameLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.driversPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).BeginInit();
            this.driversBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibddDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(2, 11);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(52, 13);
            firstnameLabel.TabIndex = 0;
            firstnameLabel.Text = "firstname:";
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.driversPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 361);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // driversPage
            // 
            this.driversPage.Controls.Add(this.splitContainer2);
            this.driversPage.Location = new System.Drawing.Point(4, 22);
            this.driversPage.Name = "driversPage";
            this.driversPage.Padding = new System.Windows.Forms.Padding(3);
            this.driversPage.Size = new System.Drawing.Size(792, 335);
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
            this.splitContainer2.Panel1.Controls.Add(this.driversBindingNavigator);
            this.splitContainer2.Panel1.Controls.Add(this.driversDataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.splitContainer2.Panel2.Controls.Add(photoLabel);
            this.splitContainer2.Panel2.Controls.Add(this.photoTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Panel2.Controls.Add(firstnameLabel);
            this.splitContainer2.Panel2.Controls.Add(this.firstnameTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(786, 329);
            this.splitContainer2.SplitterDistance = 614;
            this.splitContainer2.TabIndex = 0;
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
            this.driversBindingNavigator.Location = new System.Drawing.Point(0, 304);
            this.driversBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driversBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driversBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driversBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driversBindingNavigator.Name = "driversBindingNavigator";
            this.driversBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driversBindingNavigator.Size = new System.Drawing.Size(614, 25);
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
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.driversBindingNavigatorSaveItem.Click += new System.EventHandler(this.driversBindingNavigatorSaveItem_Click);
            // 
            // driversDataGridView
            // 
            this.driversDataGridView.AutoGenerateColumns = false;
            this.driversDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.driversDataGridView.Size = new System.Drawing.Size(614, 329);
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(33, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(60, 8);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 1;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.driversTableAdapter = this.driversTableAdapter;
            this.tableAdapterManager.regionCodesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsApp.gibddDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(17, 156);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(37, 13);
            photoLabel.TabIndex = 3;
            photoLabel.Text = "photo:";
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(60, 153);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(100, 20);
            this.photoTextBox.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001-happy-18.png");
            this.imageList1.Images.SetKeyName(1, "002-cool-5.png");
            this.imageList1.Images.SetKeyName(2, "003-happy-17.png");
            this.imageList1.Images.SetKeyName(3, "004-surprised-9.png");
            this.imageList1.Images.SetKeyName(4, "005-shocked-4.png");
            this.imageList1.Images.SetKeyName(5, "006-shocked-3.png");
            this.imageList1.Images.SetKeyName(6, "007-nervous-2.png");
            this.imageList1.Images.SetKeyName(7, "008-nervous-1.png");
            this.imageList1.Images.SetKeyName(8, "009-angry-6.png");
            this.imageList1.Images.SetKeyName(9, "010-drool.png");
            this.imageList1.Images.SetKeyName(10, "011-tired-2.png");
            this.imageList1.Images.SetKeyName(11, "012-tongue-7.png");
            this.imageList1.Images.SetKeyName(12, "013-tongue-6.png");
            this.imageList1.Images.SetKeyName(13, "014-tongue-5.png");
            this.imageList1.Images.SetKeyName(14, "015-smile-1.png");
            this.imageList1.Images.SetKeyName(15, "016-sleeping-1.png");
            this.imageList1.Images.SetKeyName(16, "017-nervous.png");
            this.imageList1.Images.SetKeyName(17, "018-surprised-8.png");
            this.imageList1.Images.SetKeyName(18, "019-tongue-4.png");
            this.imageList1.Images.SetKeyName(19, "020-happy-16.png");
            this.imageList1.Images.SetKeyName(20, "021-wink-1.png");
            this.imageList1.Images.SetKeyName(21, "022-laughing-2.png");
            this.imageList1.Images.SetKeyName(22, "023-laughing-1.png");
            this.imageList1.Images.SetKeyName(23, "024-sweat-1.png");
            this.imageList1.Images.SetKeyName(24, "025-happy-15.png");
            this.imageList1.Images.SetKeyName(25, "026-happy-14.png");
            this.imageList1.Images.SetKeyName(26, "027-laughing.png");
            this.imageList1.Images.SetKeyName(27, "028-happy-13.png");
            this.imageList1.Images.SetKeyName(28, "029-happy-12.png");
            this.imageList1.Images.SetKeyName(29, "030-crying-8.png");
            this.imageList1.Images.SetKeyName(30, "031-crying-7.png");
            this.imageList1.Images.SetKeyName(31, "032-bored.png");
            this.imageList1.Images.SetKeyName(32, "033-cool-4.png");
            this.imageList1.Images.SetKeyName(33, "034-angry-5.png");
            this.imageList1.Images.SetKeyName(34, "035-sad-14.png");
            this.imageList1.Images.SetKeyName(35, "036-angry-4.png");
            this.imageList1.Images.SetKeyName(36, "037-happy-11.png");
            this.imageList1.Images.SetKeyName(37, "038-angry-3.png");
            this.imageList1.Images.SetKeyName(38, "039-cyclops-1.png");
            this.imageList1.Images.SetKeyName(39, "040-surprised-7.png");
            this.imageList1.Images.SetKeyName(40, "041-thinking-2.png");
            this.imageList1.Images.SetKeyName(41, "042-book.png");
            this.imageList1.Images.SetKeyName(42, "043-baby-boy.png");
            this.imageList1.Images.SetKeyName(43, "044-dead-1.png");
            this.imageList1.Images.SetKeyName(44, "045-star.png");
            this.imageList1.Images.SetKeyName(45, "046-dubious.png");
            this.imageList1.Images.SetKeyName(46, "047-phone-call.png");
            this.imageList1.Images.SetKeyName(47, "048-moon.png");
            this.imageList1.Images.SetKeyName(48, "049-robot.png");
            this.imageList1.Images.SetKeyName(49, "050-flower.png");
            this.imageList1.Images.SetKeyName(50, "051-happy-10.png");
            this.imageList1.Images.SetKeyName(51, "052-happy-9.png");
            this.imageList1.Images.SetKeyName(52, "053-tired-1.png");
            this.imageList1.Images.SetKeyName(53, "054-ugly-3.png");
            this.imageList1.Images.SetKeyName(54, "055-tongue-3.png");
            this.imageList1.Images.SetKeyName(55, "056-vampire.png");
            this.imageList1.Images.SetKeyName(56, "057-music-1.png");
            this.imageList1.Images.SetKeyName(57, "058-popcorn.png");
            this.imageList1.Images.SetKeyName(58, "059-nurse.png");
            this.imageList1.Images.SetKeyName(59, "060-sad-13.png");
            this.imageList1.Images.SetKeyName(60, "061-graduated-1.png");
            this.imageList1.Images.SetKeyName(61, "062-happy-8.png");
            this.imageList1.Images.SetKeyName(62, "063-hungry.png");
            this.imageList1.Images.SetKeyName(63, "064-police.png");
            this.imageList1.Images.SetKeyName(64, "065-crying-6.png");
            this.imageList1.Images.SetKeyName(65, "066-happy-7.png");
            this.imageList1.Images.SetKeyName(66, "067-sun.png");
            this.imageList1.Images.SetKeyName(67, "068-father-2.png");
            this.imageList1.Images.SetKeyName(68, "069-happy-6.png");
            this.imageList1.Images.SetKeyName(69, "070-late.png");
            this.imageList1.Images.SetKeyName(70, "071-heart.png");
            this.imageList1.Images.SetKeyName(71, "072-sick-3.png");
            this.imageList1.Images.SetKeyName(72, "073-sad-12.png");
            this.imageList1.Images.SetKeyName(73, "074-in-love-10.png");
            this.imageList1.Images.SetKeyName(74, "075-shocked-2.png");
            this.imageList1.Images.SetKeyName(75, "076-happy-5.png");
            this.imageList1.Images.SetKeyName(76, "077-shocked-1.png");
            this.imageList1.Images.SetKeyName(77, "078-cool-3.png");
            this.imageList1.Images.SetKeyName(78, "079-crying-5.png");
            this.imageList1.Images.SetKeyName(79, "080-zombie.png");
            this.imageList1.Images.SetKeyName(80, "081-pain.png");
            this.imageList1.Images.SetKeyName(81, "082-cyclops.png");
            this.imageList1.Images.SetKeyName(82, "083-sweat.png");
            this.imageList1.Images.SetKeyName(83, "084-thief.png");
            this.imageList1.Images.SetKeyName(84, "085-sad-11.png");
            this.imageList1.Images.SetKeyName(85, "086-kiss-4.png");
            this.imageList1.Images.SetKeyName(86, "087-father-1.png");
            this.imageList1.Images.SetKeyName(87, "088-father.png");
            this.imageList1.Images.SetKeyName(88, "089-angel-1.png");
            this.imageList1.Images.SetKeyName(89, "090-happy-4.png");
            this.imageList1.Images.SetKeyName(90, "091-sad-10.png");
            this.imageList1.Images.SetKeyName(91, "092-outrage-1.png");
            this.imageList1.Images.SetKeyName(92, "093-ugly-2.png");
            this.imageList1.Images.SetKeyName(93, "094-ugly-1.png");
            this.imageList1.Images.SetKeyName(94, "095-scared.png");
            this.imageList1.Images.SetKeyName(95, "096-tongue-2.png");
            this.imageList1.Images.SetKeyName(96, "097-sad-9.png");
            this.imageList1.Images.SetKeyName(97, "098-nerd-9.png");
            this.imageList1.Images.SetKeyName(98, "099-greed-2.png");
            this.imageList1.Images.SetKeyName(99, "100-whistle.png");
            this.imageList1.Images.SetKeyName(100, "101-nerd-8.png");
            this.imageList1.Images.SetKeyName(101, "102-muted-4.png");
            this.imageList1.Images.SetKeyName(102, "103-in-love-9.png");
            this.imageList1.Images.SetKeyName(103, "104-in-love-8.png");
            this.imageList1.Images.SetKeyName(104, "105-kiss-3.png");
            this.imageList1.Images.SetKeyName(105, "106-in-love-7.png");
            this.imageList1.Images.SetKeyName(106, "107-ugly.png");
            this.imageList1.Images.SetKeyName(107, "108-nerd-7.png");
            this.imageList1.Images.SetKeyName(108, "109-nerd-6.png");
            this.imageList1.Images.SetKeyName(109, "110-crying-4.png");
            this.imageList1.Images.SetKeyName(110, "111-muted-3.png");
            this.imageList1.Images.SetKeyName(111, "112-nerd-5.png");
            this.imageList1.Images.SetKeyName(112, "113-kiss-2.png");
            this.imageList1.Images.SetKeyName(113, "114-greed-1.png");
            this.imageList1.Images.SetKeyName(114, "115-pirate-1.png");
            this.imageList1.Images.SetKeyName(115, "116-music.png");
            this.imageList1.Images.SetKeyName(116, "117-confused-2.png");
            this.imageList1.Images.SetKeyName(117, "118-nerd-4.png");
            this.imageList1.Images.SetKeyName(118, "119-greed.png");
            this.imageList1.Images.SetKeyName(119, "120-nerd-3.png");
            this.imageList1.Images.SetKeyName(120, "121-crying-3.png");
            this.imageList1.Images.SetKeyName(121, "122-cheering.png");
            this.imageList1.Images.SetKeyName(122, "123-surprised-6.png");
            this.imageList1.Images.SetKeyName(123, "124-muted-2.png");
            this.imageList1.Images.SetKeyName(124, "125-sick-2.png");
            this.imageList1.Images.SetKeyName(125, "126-graduated.png");
            this.imageList1.Images.SetKeyName(126, "127-angry-2.png");
            this.imageList1.Images.SetKeyName(127, "128-in-love-6.png");
            this.imageList1.Images.SetKeyName(128, "129-cool-2.png");
            this.imageList1.Images.SetKeyName(129, "130-confused-1.png");
            this.imageList1.Images.SetKeyName(130, "131-sad-8.png");
            this.imageList1.Images.SetKeyName(131, "132-nerd-2.png");
            this.imageList1.Images.SetKeyName(132, "133-birthday-boy.png");
            this.imageList1.Images.SetKeyName(133, "134-surprised-5.png");
            this.imageList1.Images.SetKeyName(134, "135-selfie.png");
            this.imageList1.Images.SetKeyName(135, "136-tongue-1.png");
            this.imageList1.Images.SetKeyName(136, "137-smart-1.png");
            this.imageList1.Images.SetKeyName(137, "138-smart.png");
            this.imageList1.Images.SetKeyName(138, "139-surprised-4.png");
            this.imageList1.Images.SetKeyName(139, "140-3d-glasses.png");
            this.imageList1.Images.SetKeyName(140, "141-in-love-5.png");
            this.imageList1.Images.SetKeyName(141, "142-sleeping.png");
            this.imageList1.Images.SetKeyName(142, "143-pirate.png");
            this.imageList1.Images.SetKeyName(143, "144-santa-claus.png");
            this.imageList1.Images.SetKeyName(144, "145-wink.png");
            this.imageList1.Images.SetKeyName(145, "146-in-love-4.png");
            this.imageList1.Images.SetKeyName(146, "147-tired.png");
            this.imageList1.Images.SetKeyName(147, "148-bang.png");
            this.imageList1.Images.SetKeyName(148, "149-baby.png");
            this.imageList1.Images.SetKeyName(149, "150-tongue.png");
            this.imageList1.Images.SetKeyName(150, "151-sick-1.png");
            this.imageList1.Images.SetKeyName(151, "152-outrage.png");
            this.imageList1.Images.SetKeyName(152, "153-injury.png");
            this.imageList1.Images.SetKeyName(153, "154-dead.png");
            this.imageList1.Images.SetKeyName(154, "155-rich-1.png");
            this.imageList1.Images.SetKeyName(155, "156-sick.png");
            this.imageList1.Images.SetKeyName(156, "157-angel.png");
            this.imageList1.Images.SetKeyName(157, "158-nerd-1.png");
            this.imageList1.Images.SetKeyName(158, "159-crying-2.png");
            this.imageList1.Images.SetKeyName(159, "160-crying-1.png");
            this.imageList1.Images.SetKeyName(160, "161-muted-1.png");
            this.imageList1.Images.SetKeyName(161, "162-surprised-3.png");
            this.imageList1.Images.SetKeyName(162, "163-crying.png");
            this.imageList1.Images.SetKeyName(163, "164-sad-7.png");
            this.imageList1.Images.SetKeyName(164, "165-cool-1.png");
            this.imageList1.Images.SetKeyName(165, "166-happy-3.png");
            this.imageList1.Images.SetKeyName(166, "167-thinking-1.png");
            this.imageList1.Images.SetKeyName(167, "168-muted.png");
            this.imageList1.Images.SetKeyName(168, "169-confused.png");
            this.imageList1.Images.SetKeyName(169, "170-happy-2.png");
            this.imageList1.Images.SetKeyName(170, "171-thinking.png");
            this.imageList1.Images.SetKeyName(171, "172-nerd.png");
            this.imageList1.Images.SetKeyName(172, "173-in-love-3.png");
            this.imageList1.Images.SetKeyName(173, "174-hypnotized.png");
            this.imageList1.Images.SetKeyName(174, "175-cool.png");
            this.imageList1.Images.SetKeyName(175, "176-shocked.png");
            this.imageList1.Images.SetKeyName(176, "177-easter.png");
            this.imageList1.Images.SetKeyName(177, "178-surprised-2.png");
            this.imageList1.Images.SetKeyName(178, "179-surprised-1.png");
            this.imageList1.Images.SetKeyName(179, "180-surprised.png");
            this.imageList1.Images.SetKeyName(180, "181-furious.png");
            this.imageList1.Images.SetKeyName(181, "182-sad-6.png");
            this.imageList1.Images.SetKeyName(182, "183-sad-5.png");
            this.imageList1.Images.SetKeyName(183, "184-sad-4.png");
            this.imageList1.Images.SetKeyName(184, "185-sad-3.png");
            this.imageList1.Images.SetKeyName(185, "186-angry-1.png");
            this.imageList1.Images.SetKeyName(186, "187-rich.png");
            this.imageList1.Images.SetKeyName(187, "188-sad-2.png");
            this.imageList1.Images.SetKeyName(188, "189-happy-1.png");
            this.imageList1.Images.SetKeyName(189, "190-sad-1.png");
            this.imageList1.Images.SetKeyName(190, "191-sad.png");
            this.imageList1.Images.SetKeyName(191, "192-smile.png");
            this.imageList1.Images.SetKeyName(192, "193-in-love-2.png");
            this.imageList1.Images.SetKeyName(193, "194-happy.png");
            this.imageList1.Images.SetKeyName(194, "195-kiss-1.png");
            this.imageList1.Images.SetKeyName(195, "196-in-love-1.png");
            this.imageList1.Images.SetKeyName(196, "197-in-love.png");
            this.imageList1.Images.SetKeyName(197, "198-kiss.png");
            this.imageList1.Images.SetKeyName(198, "199-angry.png");
            this.imageList1.Images.SetKeyName(199, "200-sleepy.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Госавтоинспекция МВД России";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.driversPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).EndInit();
            this.driversBindingNavigator.ResumeLayout(false);
            this.driversBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibddDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage driversPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private gibddDataSet gibddDataSet;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private gibddDataSetTableAdapters.driversTableAdapter driversTableAdapter;
        private gibddDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.ImageList imageList1;
    }
}