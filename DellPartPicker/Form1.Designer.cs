namespace DellPartPicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.d3pLogo1 = new System.Windows.Forms.PictureBox();
            this.searchID = new System.Windows.Forms.Button();
            this.addSingletable = new System.Windows.Forms.DataGridView();
            this.d3pTitle1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.pictureSettings1 = new System.Windows.Forms.PictureBox();
            this.addListTable = new System.Windows.Forms.DataGridView();
            this.listTextBox = new System.Windows.Forms.TextBox();
            this.listSearchBttn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.singleItemTab = new System.Windows.Forms.TabPage();
            this.addSelectedBttn = new System.Windows.Forms.Button();
            this.listTab = new System.Windows.Forms.TabPage();
            this.enterHere = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addAll = new System.Windows.Forms.Button();
            this.dumpLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.d3pTitle2 = new System.Windows.Forms.Label();
            this.d3pLogo2 = new System.Windows.Forms.PictureBox();
            this.collectiveTab = new System.Windows.Forms.TabPage();
            this.bttnRemove = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.collectiveLbl = new System.Windows.Forms.Label();
            this.collectiveTable = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.d3pTitle3 = new System.Windows.Forms.Label();
            this.d3pLogo3 = new System.Windows.Forms.PictureBox();
            this.Map = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.searchName = new System.Windows.Forms.Button();
            this.searchLocation = new System.Windows.Forms.Button();
            this.resultsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSingletable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSettings1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addListTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.singleItemTab.SuspendLayout();
            this.listTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo2)).BeginInit();
            this.collectiveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectiveTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo3)).BeginInit();
            this.SuspendLayout();
            // 
            // d3pLogo1
            // 
            this.d3pLogo1.Image = global::DellPartPicker.Properties.Resources.Dell_logo_2016;
            this.d3pLogo1.Location = new System.Drawing.Point(3, 48);
            this.d3pLogo1.Name = "d3pLogo1";
            this.d3pLogo1.Size = new System.Drawing.Size(117, 112);
            this.d3pLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d3pLogo1.TabIndex = 3;
            this.d3pLogo1.TabStop = false;
            this.d3pLogo1.Click += new System.EventHandler(this.d3pLogo1_Click);
            // 
            // searchID
            // 
            this.searchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchID.Location = new System.Drawing.Point(10, 230);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(53, 44);
            this.searchID.TabIndex = 4;
            this.searchID.Text = "ID";
            this.searchID.UseVisualStyleBackColor = true;
            this.searchID.Click += new System.EventHandler(this.search_Click);
            // 
            // addSingletable
            // 
            this.addSingletable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addSingletable.Location = new System.Drawing.Point(434, 138);
            this.addSingletable.Name = "addSingletable";
            this.addSingletable.Size = new System.Drawing.Size(496, 357);
            this.addSingletable.TabIndex = 5;
            // 
            // d3pTitle1
            // 
            this.d3pTitle1.AutoSize = true;
            this.d3pTitle1.BackColor = System.Drawing.Color.Transparent;
            this.d3pTitle1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3pTitle1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.d3pTitle1.Location = new System.Drawing.Point(3, 0);
            this.d3pTitle1.Name = "d3pTitle1";
            this.d3pTitle1.Size = new System.Drawing.Size(298, 45);
            this.d3pTitle1.TabIndex = 6;
            this.d3pTitle1.Text = "Dell Part Picker UI";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Maroon;
            this.error.Location = new System.Drawing.Point(12, 199);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(115, 20);
            this.error.TabIndex = 7;
            this.error.Text = "Error: No input!";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(10, 197);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(393, 26);
            this.searchBox.TabIndex = 8;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(6, 174);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(64, 21);
            this.Searchlbl.TabIndex = 9;
            this.Searchlbl.Text = "Search: ";
            // 
            // pictureSettings1
            // 
            this.pictureSettings1.Image = ((System.Drawing.Image)(resources.GetObject("pictureSettings1.Image")));
            this.pictureSettings1.Location = new System.Drawing.Point(875, 0);
            this.pictureSettings1.Name = "pictureSettings1";
            this.pictureSettings1.Size = new System.Drawing.Size(63, 56);
            this.pictureSettings1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSettings1.TabIndex = 10;
            this.pictureSettings1.TabStop = false;
            this.pictureSettings1.Click += new System.EventHandler(this.pictureSettings_Click);
            // 
            // addListTable
            // 
            this.addListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addListTable.Location = new System.Drawing.Point(434, 138);
            this.addListTable.Name = "addListTable";
            this.addListTable.Size = new System.Drawing.Size(496, 357);
            this.addListTable.TabIndex = 11;
            // 
            // listTextBox
            // 
            this.listTextBox.Location = new System.Drawing.Point(13, 184);
            this.listTextBox.Multiline = true;
            this.listTextBox.Name = "listTextBox";
            this.listTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.listTextBox.Size = new System.Drawing.Size(402, 229);
            this.listTextBox.TabIndex = 12;
            // 
            // listSearchBttn
            // 
            this.listSearchBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listSearchBttn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSearchBttn.Location = new System.Drawing.Point(13, 419);
            this.listSearchBttn.Name = "listSearchBttn";
            this.listSearchBttn.Size = new System.Drawing.Size(201, 76);
            this.listSearchBttn.TabIndex = 13;
            this.listSearchBttn.Text = "Search";
            this.listSearchBttn.UseVisualStyleBackColor = true;
            this.listSearchBttn.Click += new System.EventHandler(this.listSearchBttn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.singleItemTab);
            this.tabControl1.Controls.Add(this.listTab);
            this.tabControl1.Controls.Add(this.collectiveTab);
            this.tabControl1.Controls.Add(this.Map);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 533);
            this.tabControl1.TabIndex = 14;
            // 
            // singleItemTab
            // 
            this.singleItemTab.Controls.Add(this.searchLocation);
            this.singleItemTab.Controls.Add(this.searchName);
            this.singleItemTab.Controls.Add(this.error);
            this.singleItemTab.Controls.Add(this.label1);
            this.singleItemTab.Controls.Add(this.addSelectedBttn);
            this.singleItemTab.Controls.Add(this.addSingletable);
            this.singleItemTab.Controls.Add(this.pictureSettings1);
            this.singleItemTab.Controls.Add(this.d3pTitle1);
            this.singleItemTab.Controls.Add(this.d3pLogo1);
            this.singleItemTab.Controls.Add(this.searchID);
            this.singleItemTab.Controls.Add(this.Searchlbl);
            this.singleItemTab.Controls.Add(this.searchBox);
            this.singleItemTab.Location = new System.Drawing.Point(4, 22);
            this.singleItemTab.Name = "singleItemTab";
            this.singleItemTab.Padding = new System.Windows.Forms.Padding(3);
            this.singleItemTab.Size = new System.Drawing.Size(942, 507);
            this.singleItemTab.TabIndex = 0;
            this.singleItemTab.Text = "Add Single Item";
            this.singleItemTab.UseVisualStyleBackColor = true;
            // 
            // addSelectedBttn
            // 
            this.addSelectedBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedBttn.Location = new System.Drawing.Point(206, 229);
            this.addSelectedBttn.Name = "addSelectedBttn";
            this.addSelectedBttn.Size = new System.Drawing.Size(197, 45);
            this.addSelectedBttn.TabIndex = 11;
            this.addSelectedBttn.Text = "Add Selected";
            this.addSelectedBttn.UseVisualStyleBackColor = false;
            this.addSelectedBttn.Click += new System.EventHandler(this.addSelectedBttn_Click);
            // 
            // listTab
            // 
            this.listTab.Controls.Add(this.enterHere);
            this.listTab.Controls.Add(this.pictureBox1);
            this.listTab.Controls.Add(this.addAll);
            this.listTab.Controls.Add(this.dumpLbl);
            this.listTab.Controls.Add(this.pictureBox3);
            this.listTab.Controls.Add(this.d3pTitle2);
            this.listTab.Controls.Add(this.d3pLogo2);
            this.listTab.Controls.Add(this.addListTable);
            this.listTab.Controls.Add(this.listSearchBttn);
            this.listTab.Controls.Add(this.listTextBox);
            this.listTab.Location = new System.Drawing.Point(4, 22);
            this.listTab.Name = "listTab";
            this.listTab.Padding = new System.Windows.Forms.Padding(3);
            this.listTab.Size = new System.Drawing.Size(942, 507);
            this.listTab.TabIndex = 1;
            this.listTab.Text = "List Dump";
            this.listTab.UseVisualStyleBackColor = true;
            // 
            // enterHere
            // 
            this.enterHere.AutoSize = true;
            this.enterHere.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterHere.Location = new System.Drawing.Point(10, 164);
            this.enterHere.Name = "enterHere";
            this.enterHere.Size = new System.Drawing.Size(403, 17);
            this.enterHere.TabIndex = 21;
            this.enterHere.Text = "Enter part number below.  Put each part number on a separate line.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(875, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addAll
            // 
            this.addAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAll.Location = new System.Drawing.Point(220, 419);
            this.addAll.Name = "addAll";
            this.addAll.Size = new System.Drawing.Size(195, 76);
            this.addAll.TabIndex = 19;
            this.addAll.Text = "Add All";
            this.addAll.UseVisualStyleBackColor = true;
            this.addAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // dumpLbl
            // 
            this.dumpLbl.AutoSize = true;
            this.dumpLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dumpLbl.Location = new System.Drawing.Point(430, 114);
            this.dumpLbl.Name = "dumpLbl";
            this.dumpLbl.Size = new System.Drawing.Size(60, 21);
            this.dumpLbl.TabIndex = 18;
            this.dumpLbl.Text = "Results";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1194, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // d3pTitle2
            // 
            this.d3pTitle2.AutoSize = true;
            this.d3pTitle2.BackColor = System.Drawing.Color.Transparent;
            this.d3pTitle2.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3pTitle2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.d3pTitle2.Location = new System.Drawing.Point(3, 0);
            this.d3pTitle2.Name = "d3pTitle2";
            this.d3pTitle2.Size = new System.Drawing.Size(298, 45);
            this.d3pTitle2.TabIndex = 15;
            this.d3pTitle2.Text = "Dell Part Picker UI";
            // 
            // d3pLogo2
            // 
            this.d3pLogo2.Image = global::DellPartPicker.Properties.Resources.Dell_logo_2016;
            this.d3pLogo2.Location = new System.Drawing.Point(3, 48);
            this.d3pLogo2.Name = "d3pLogo2";
            this.d3pLogo2.Size = new System.Drawing.Size(117, 112);
            this.d3pLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d3pLogo2.TabIndex = 14;
            this.d3pLogo2.TabStop = false;
            // 
            // collectiveTab
            // 
            this.collectiveTab.Controls.Add(this.resultsLbl);
            this.collectiveTab.Controls.Add(this.bttnRemove);
            this.collectiveTab.Controls.Add(this.bttnClear);
            this.collectiveTab.Controls.Add(this.pictureBox2);
            this.collectiveTab.Controls.Add(this.collectiveLbl);
            this.collectiveTab.Controls.Add(this.collectiveTable);
            this.collectiveTab.Controls.Add(this.pictureBox4);
            this.collectiveTab.Controls.Add(this.d3pTitle3);
            this.collectiveTab.Controls.Add(this.d3pLogo3);
            this.collectiveTab.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectiveTab.Location = new System.Drawing.Point(4, 22);
            this.collectiveTab.Name = "collectiveTab";
            this.collectiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.collectiveTab.Size = new System.Drawing.Size(942, 507);
            this.collectiveTab.TabIndex = 2;
            this.collectiveTab.Text = "Collective";
            this.collectiveTab.UseVisualStyleBackColor = true;
            // 
            // bttnRemove
            // 
            this.bttnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRemove.Location = new System.Drawing.Point(6, 256);
            this.bttnRemove.Name = "bttnRemove";
            this.bttnRemove.Size = new System.Drawing.Size(391, 62);
            this.bttnRemove.TabIndex = 21;
            this.bttnRemove.Text = "Remove Selected";
            this.bttnRemove.UseVisualStyleBackColor = true;
            this.bttnRemove.Click += new System.EventHandler(this.bttnRemove_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClear.Location = new System.Drawing.Point(6, 191);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(391, 59);
            this.bttnClear.TabIndex = 20;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(875, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // collectiveLbl
            // 
            this.collectiveLbl.AutoSize = true;
            this.collectiveLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectiveLbl.Location = new System.Drawing.Point(6, 163);
            this.collectiveLbl.Name = "collectiveLbl";
            this.collectiveLbl.Size = new System.Drawing.Size(183, 25);
            this.collectiveLbl.TabIndex = 18;
            this.collectiveLbl.Text = "Collective Parts List";
            // 
            // collectiveTable
            // 
            this.collectiveTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collectiveTable.Location = new System.Drawing.Point(434, 138);
            this.collectiveTable.Name = "collectiveTable";
            this.collectiveTable.Size = new System.Drawing.Size(496, 357);
            this.collectiveTable.TabIndex = 17;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1194, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // d3pTitle3
            // 
            this.d3pTitle3.AutoSize = true;
            this.d3pTitle3.BackColor = System.Drawing.Color.Transparent;
            this.d3pTitle3.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3pTitle3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.d3pTitle3.Location = new System.Drawing.Point(3, 0);
            this.d3pTitle3.Name = "d3pTitle3";
            this.d3pTitle3.Size = new System.Drawing.Size(298, 45);
            this.d3pTitle3.TabIndex = 15;
            this.d3pTitle3.Text = "Dell Part Picker UI";
            // 
            // d3pLogo3
            // 
            this.d3pLogo3.Image = global::DellPartPicker.Properties.Resources.Dell_logo_2016;
            this.d3pLogo3.Location = new System.Drawing.Point(3, 48);
            this.d3pLogo3.Name = "d3pLogo3";
            this.d3pLogo3.Size = new System.Drawing.Size(117, 112);
            this.d3pLogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d3pLogo3.TabIndex = 14;
            this.d3pLogo3.TabStop = false;
            // 
            // Map
            // 
            this.Map.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Map.Location = new System.Drawing.Point(4, 22);
            this.Map.Name = "Map";
            this.Map.Padding = new System.Windows.Forms.Padding(3);
            this.Map.Size = new System.Drawing.Size(942, 507);
            this.Map.TabIndex = 3;
            this.Map.Text = "Map";
            this.Map.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Results";
            // 
            // searchName
            // 
            this.searchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchName.Location = new System.Drawing.Point(69, 230);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(55, 44);
            this.searchName.TabIndex = 20;
            this.searchName.Text = "Name";
            this.searchName.UseVisualStyleBackColor = true;
            this.searchName.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchLocation
            // 
            this.searchLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchLocation.Location = new System.Drawing.Point(130, 230);
            this.searchLocation.Name = "searchLocation";
            this.searchLocation.Size = new System.Drawing.Size(70, 44);
            this.searchLocation.TabIndex = 21;
            this.searchLocation.Text = "Location";
            this.searchLocation.UseVisualStyleBackColor = true;
            this.searchLocation.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // resultsLbl
            // 
            this.resultsLbl.AutoSize = true;
            this.resultsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLbl.Location = new System.Drawing.Point(430, 114);
            this.resultsLbl.Name = "resultsLbl";
            this.resultsLbl.Size = new System.Drawing.Size(60, 21);
            this.resultsLbl.TabIndex = 22;
            this.resultsLbl.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(942, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSingletable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSettings1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addListTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.singleItemTab.ResumeLayout(false);
            this.singleItemTab.PerformLayout();
            this.listTab.ResumeLayout(false);
            this.listTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo2)).EndInit();
            this.collectiveTab.ResumeLayout(false);
            this.collectiveTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectiveTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox d3pLogo1;
        public System.Windows.Forms.Button searchID;
        public System.Windows.Forms.DataGridView addSingletable;
        public System.Windows.Forms.PictureBox pictureSettings1;
        public System.Windows.Forms.Label error;
        public System.Windows.Forms.Label Searchlbl;
        public System.Windows.Forms.Label d3pTitle1;
        public System.Windows.Forms.TextBox searchBox;
        public System.Windows.Forms.DataGridView addListTable;
        public System.Windows.Forms.TextBox listTextBox;
        public System.Windows.Forms.Button listSearchBttn;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage singleItemTab;
        public System.Windows.Forms.TabPage listTab;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label d3pTitle2;
        public System.Windows.Forms.PictureBox d3pLogo2;
        public System.Windows.Forms.Label dumpLbl;
        public System.Windows.Forms.TabPage collectiveTab;
        public System.Windows.Forms.Label collectiveLbl;
        public System.Windows.Forms.DataGridView collectiveTable;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label d3pTitle3;
        public System.Windows.Forms.PictureBox d3pLogo3;
        public System.Windows.Forms.Button addAll;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button bttnRemove;
        public System.Windows.Forms.Button bttnClear;
        public System.Windows.Forms.Label enterHere;
        public System.Windows.Forms.Button addSelectedBttn;
        private System.Windows.Forms.TabPage Map;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button searchLocation;
        public System.Windows.Forms.Button searchName;
        public System.Windows.Forms.Label resultsLbl;
    }
}

