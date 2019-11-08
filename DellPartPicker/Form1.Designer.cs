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
            this.IDsearch = new System.Windows.Forms.RadioButton();
            this.nameSearch = new System.Windows.Forms.RadioButton();
            this.locSearch = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDsearch
            // 
            this.IDsearch.AutoSize = true;
            this.IDsearch.Location = new System.Drawing.Point(223, 331);
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
            this.nameSearch.Location = new System.Drawing.Point(223, 354);
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
            this.locSearch.Location = new System.Drawing.Point(223, 377);
            this.locSearch.Name = "locSearch";
            this.locSearch.Size = new System.Drawing.Size(118, 17);
            this.locSearch.TabIndex = 2;
            this.locSearch.TabStop = true;
            this.locSearch.Text = "Search By Location";
            this.locSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DellPartPicker.Properties.Resources.Dell_logo_2016;
            this.pictureBox1.Location = new System.Drawing.Point(31, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(142, 377);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 243);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dell PartPicker";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(67, 358);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(76, 13);
            this.error.TabIndex = 7;
            this.error.Text = "Error, no input!";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(117, 328);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 8;
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Location = new System.Drawing.Point(67, 331);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(44, 13);
            this.Searchlbl.TabIndex = 9;
            this.Searchlbl.Text = "Search ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Searchlbl);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.locSearch);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.IDsearch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton IDsearch;
        private System.Windows.Forms.RadioButton nameSearch;
        private System.Windows.Forms.RadioButton locSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label Searchlbl;
    }
}

