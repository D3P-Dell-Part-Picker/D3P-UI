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
            this.IDsearch = new System.Windows.Forms.RadioButton();
            this.nameSearch = new System.Windows.Forms.RadioButton();
            this.locSearch = new System.Windows.Forms.RadioButton();
            this.d3pLogo1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.d3pTitle1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.pictureSettings1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listTextBox = new System.Windows.Forms.TextBox();
            this.listSearchBttn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.singleItemTab = new System.Windows.Forms.TabPage();
            this.listTab = new System.Windows.Forms.TabPage();
            this.enterHere = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dumpLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.d3pTitle2 = new System.Windows.Forms.Label();
            this.d3pLogo2 = new System.Windows.Forms.PictureBox();
            this.collectiveTab = new System.Windows.Forms.TabPage();
            this.bttnRemove = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.collectiveLbl = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.d3pTitle3 = new System.Windows.Forms.Label();
            this.d3pLogo3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSettings1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.singleItemTab.SuspendLayout();
            this.listTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo2)).BeginInit();
            this.collectiveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo3)).BeginInit();
            this.SuspendLayout();
            // 
            // IDsearch
            // 
            this.IDsearch.AutoSize = true;
            this.IDsearch.Location = new System.Drawing.Point(152, 403);
            this.IDsearch.Name = "IDsearch";
            this.IDsearch.Size = new System.Drawing.Size(86, 17);
            this.IDsearch.TabIndex = 0;
            this.IDsearch.TabStop = true;
            this.IDsearch.Text = "Search By Id";
            this.IDsearch.UseVisualStyleBackColor = true;
            // 
            // nameSearch
            // 
            this.nameSearch.AutoSize = true;
            this.nameSearch.Location = new System.Drawing.Point(152, 426);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(105, 17);
            this.nameSearch.TabIndex = 1;
            this.nameSearch.TabStop = true;
            this.nameSearch.Text = "Search By Name";
            this.nameSearch.UseVisualStyleBackColor = true;
            // 
            // locSearch
            // 
            this.locSearch.AutoSize = true;
            this.locSearch.Location = new System.Drawing.Point(152, 449);
            this.locSearch.Name = "locSearch";
            this.locSearch.Size = new System.Drawing.Size(118, 17);
            this.locSearch.TabIndex = 2;
            this.locSearch.TabStop = true;
            this.locSearch.Text = "Search By Location";
            this.locSearch.UseVisualStyleBackColor = true;
            // 
            // d3pLogo1
            // 
            this.d3pLogo1.Image = global::DellPartPicker.Properties.Resources.Dell_logo_2016;
            this.d3pLogo1.Location = new System.Drawing.Point(6, 59);
            this.d3pLogo1.Name = "d3pLogo1";
            this.d3pLogo1.Size = new System.Drawing.Size(177, 133);
            this.d3pLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d3pLogo1.TabIndex = 3;
            this.d3pLogo1.TabStop = false;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(36, 420);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 44);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 346);
            this.dataGridView1.TabIndex = 5;
            // 
            // d3pTitle1
            // 
            this.d3pTitle1.AutoSize = true;
            this.d3pTitle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.d3pTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3pTitle1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.d3pTitle1.Location = new System.Drawing.Point(6, 19);
            this.d3pTitle1.Name = "d3pTitle1";
            this.d3pTitle1.Size = new System.Drawing.Size(295, 37);
            this.d3pTitle1.TabIndex = 6;
            this.d3pTitle1.Text = "Dell Part Picker UI";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Maroon;
            this.error.Location = new System.Drawing.Point(33, 403);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(76, 13);
            this.error.TabIndex = 7;
            this.error.Text = "Error, no input!";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Location = new System.Drawing.Point(124, 377);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(114, 20);
            this.searchBox.TabIndex = 8;
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Location = new System.Drawing.Point(55, 377);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(44, 13);
            this.Searchlbl.TabIndex = 9;
            this.Searchlbl.Text = "Search ";
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(285, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(455, 407);
            this.dataGridView2.TabIndex = 11;
            // 
            // listTextBox
            // 
            this.listTextBox.Location = new System.Drawing.Point(13, 250);
            this.listTextBox.Multiline = true;
            this.listTextBox.Name = "listTextBox";
            this.listTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.listTextBox.Size = new System.Drawing.Size(266, 197);
            this.listTextBox.TabIndex = 12;
            // 
            // listSearchBttn
            // 
            this.listSearchBttn.Location = new System.Drawing.Point(13, 453);
            this.listSearchBttn.Name = "listSearchBttn";
            this.listSearchBttn.Size = new System.Drawing.Size(101, 33);
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
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 533);
            this.tabControl1.TabIndex = 14;
            // 
            // singleItemTab
            // 
            this.singleItemTab.Controls.Add(this.dataGridView1);
            this.singleItemTab.Controls.Add(this.pictureSettings1);
            this.singleItemTab.Controls.Add(this.d3pTitle1);
            this.singleItemTab.Controls.Add(this.d3pLogo1);
            this.singleItemTab.Controls.Add(this.search);
            this.singleItemTab.Controls.Add(this.searchBox);
            this.singleItemTab.Controls.Add(this.Searchlbl);
            this.singleItemTab.Controls.Add(this.IDsearch);
            this.singleItemTab.Controls.Add(this.nameSearch);
            this.singleItemTab.Controls.Add(this.error);
            this.singleItemTab.Controls.Add(this.locSearch);
            this.singleItemTab.Location = new System.Drawing.Point(4, 22);
            this.singleItemTab.Name = "singleItemTab";
            this.singleItemTab.Padding = new System.Windows.Forms.Padding(3);
            this.singleItemTab.Size = new System.Drawing.Size(942, 507);
            this.singleItemTab.TabIndex = 0;
            this.singleItemTab.Text = "Add Single Item";
            this.singleItemTab.UseVisualStyleBackColor = true;
            // 
            // listTab
            // 
            this.listTab.Controls.Add(this.label1);
            this.listTab.Controls.Add(this.enterHere);
            this.listTab.Controls.Add(this.pictureBox1);
            this.listTab.Controls.Add(this.button2);
            this.listTab.Controls.Add(this.dumpLbl);
            this.listTab.Controls.Add(this.pictureBox3);
            this.listTab.Controls.Add(this.d3pTitle2);
            this.listTab.Controls.Add(this.d3pLogo2);
            this.listTab.Controls.Add(this.dataGridView2);
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
            this.enterHere.Location = new System.Drawing.Point(87, 212);
            this.enterHere.Name = "enterHere";
            this.enterHere.Size = new System.Drawing.Size(113, 13);
            this.enterHere.TabIndex = 21;
            this.enterHere.Text = "Enter Part Number List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(863, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dumpLbl
            // 
            this.dumpLbl.AutoSize = true;
            this.dumpLbl.Location = new System.Drawing.Point(494, 20);
            this.dumpLbl.Name = "dumpLbl";
            this.dumpLbl.Size = new System.Drawing.Size(42, 13);
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
            this.d3pTitle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.d3pTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3pTitle2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.d3pTitle2.Location = new System.Drawing.Point(5, 2);
            this.d3pTitle2.Name = "d3pTitle2";
            this.d3pTitle2.Size = new System.Drawing.Size(295, 37);
            this.d3pTitle2.TabIndex = 15;
            this.d3pTitle2.Text = "Dell Part Picker UI";
            // 
            // d3pLogo2
            // 
            this.d3pLogo2.Image = global::DellPartPicker.Properties.Resources.Dell_logo_2016;
            this.d3pLogo2.Location = new System.Drawing.Point(13, 42);
            this.d3pLogo2.Name = "d3pLogo2";
            this.d3pLogo2.Size = new System.Drawing.Size(224, 143);
            this.d3pLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d3pLogo2.TabIndex = 14;
            this.d3pLogo2.TabStop = false;
            // 
            // collectiveTab
            // 
            this.collectiveTab.Controls.Add(this.bttnRemove);
            this.collectiveTab.Controls.Add(this.bttnClear);
            this.collectiveTab.Controls.Add(this.pictureBox2);
            this.collectiveTab.Controls.Add(this.collectiveLbl);
            this.collectiveTab.Controls.Add(this.dataGridView4);
            this.collectiveTab.Controls.Add(this.pictureBox4);
            this.collectiveTab.Controls.Add(this.d3pTitle3);
            this.collectiveTab.Controls.Add(this.d3pLogo3);
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
            this.bttnRemove.Location = new System.Drawing.Point(454, 472);
            this.bttnRemove.Name = "bttnRemove";
            this.bttnRemove.Size = new System.Drawing.Size(112, 23);
            this.bttnRemove.TabIndex = 21;
            this.bttnRemove.Text = "Remove Selected";
            this.bttnRemove.UseVisualStyleBackColor = true;
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(730, 472);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 20;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(863, 6);
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
            this.collectiveLbl.Location = new System.Drawing.Point(563, 26);
            this.collectiveLbl.Name = "collectiveLbl";
            this.collectiveLbl.Size = new System.Drawing.Size(99, 13);
            this.collectiveLbl.TabIndex = 18;
            this.collectiveLbl.Text = "Collective Parts List";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(390, 51);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(454, 407);
            this.dataGridView4.TabIndex = 17;
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
            this.d3pTitle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.d3pTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3pTitle3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.d3pTitle3.Location = new System.Drawing.Point(5, 2);
            this.d3pTitle3.Name = "d3pTitle3";
            this.d3pTitle3.Size = new System.Drawing.Size(295, 37);
            this.d3pTitle3.TabIndex = 15;
            this.d3pTitle3.Text = "Dell Part Picker UI";
            // 
            // d3pLogo3
            // 
            this.d3pLogo3.Image = global::DellPartPicker.Properties.Resources.Dell_logo_2016;
            this.d3pLogo3.Location = new System.Drawing.Point(12, 51);
            this.d3pLogo3.Name = "d3pLogo3";
            this.d3pLogo3.Size = new System.Drawing.Size(224, 143);
            this.d3pLogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d3pLogo3.TabIndex = 14;
            this.d3pLogo3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "put each part number on a seperate line";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSettings1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3pLogo3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox d3pLogo1;
        public System.Windows.Forms.Button search;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.PictureBox pictureSettings1;
        public System.Windows.Forms.RadioButton IDsearch;
        public System.Windows.Forms.RadioButton nameSearch;
        public System.Windows.Forms.RadioButton locSearch;
        public System.Windows.Forms.Label error;
        public System.Windows.Forms.Label Searchlbl;
        public System.Windows.Forms.Label d3pTitle1;
        public System.Windows.Forms.TextBox searchBox;
        public System.Windows.Forms.DataGridView dataGridView2;
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
        public System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label d3pTitle3;
        public System.Windows.Forms.PictureBox d3pLogo3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button bttnRemove;
        public System.Windows.Forms.Button bttnClear;
        public System.Windows.Forms.Label enterHere;
        private System.Windows.Forms.Label label1;
    }
}

