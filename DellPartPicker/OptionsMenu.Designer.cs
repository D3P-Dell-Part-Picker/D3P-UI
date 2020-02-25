namespace DellPartPicker
{
    partial class OptionsMenu
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
            this.optionsLbl = new System.Windows.Forms.Label();
            this.radioLt = new System.Windows.Forms.RadioButton();
            this.radioDrk = new System.Windows.Forms.RadioButton();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.headerBar = new System.Windows.Forms.PictureBox();
            this.headerBar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsLbl
            // 
            this.optionsLbl.AutoSize = true;
            this.optionsLbl.BackColor = System.Drawing.Color.Transparent;
            this.optionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.optionsLbl.Location = new System.Drawing.Point(12, 9);
            this.optionsLbl.Name = "optionsLbl";
            this.optionsLbl.Size = new System.Drawing.Size(135, 37);
            this.optionsLbl.TabIndex = 0;
            this.optionsLbl.Text = "Options";
            // 
            // radioLt
            // 
            this.radioLt.AutoSize = true;
            this.radioLt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLt.Location = new System.Drawing.Point(12, 92);
            this.radioLt.Name = "radioLt";
            this.radioLt.Size = new System.Drawing.Size(202, 24);
            this.radioLt.TabIndex = 1;
            this.radioLt.TabStop = true;
            this.radioLt.Text = "Light Theme (Default)";
            this.radioLt.UseVisualStyleBackColor = true;
            this.radioLt.CheckedChanged += new System.EventHandler(this.radioLt_CheckedChanged);
            // 
            // radioDrk
            // 
            this.radioDrk.AutoSize = true;
            this.radioDrk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDrk.Location = new System.Drawing.Point(12, 137);
            this.radioDrk.Name = "radioDrk";
            this.radioDrk.Size = new System.Drawing.Size(124, 24);
            this.radioDrk.TabIndex = 2;
            this.radioDrk.TabStop = true;
            this.radioDrk.Text = "Dark Theme";
            this.radioDrk.UseVisualStyleBackColor = true;
            this.radioDrk.CheckedChanged += new System.EventHandler(this.radioDrk_CheckedChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Location = new System.Drawing.Point(12, 370);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(202, 68);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonApply.BackColor = System.Drawing.Color.White;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(12, 296);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(202, 68);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply Changes";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdvanced.BackColor = System.Drawing.Color.White;
            this.buttonAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvanced.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdvanced.Location = new System.Drawing.Point(639, 404);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(149, 34);
            this.buttonAdvanced.TabIndex = 5;
            this.buttonAdvanced.Text = "Advanced";
            this.buttonAdvanced.UseVisualStyleBackColor = false;
            // 
            // headerBar
            // 
            this.headerBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerBar.BackColor = System.Drawing.Color.Silver;
            this.headerBar.Location = new System.Drawing.Point(-1, -11);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new System.Drawing.Size(812, 82);
            this.headerBar.TabIndex = 6;
            this.headerBar.TabStop = false;
            // 
            // headerBar2
            // 
            this.headerBar2.Location = new System.Drawing.Point(-1, 70);
            this.headerBar2.Name = "headerBar2";
            this.headerBar2.Size = new System.Drawing.Size(803, 2);
            this.headerBar2.TabIndex = 7;
            this.headerBar2.TabStop = false;
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerBar2);
            this.Controls.Add(this.buttonAdvanced);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.radioDrk);
            this.Controls.Add(this.radioLt);
            this.Controls.Add(this.optionsLbl);
            this.Controls.Add(this.headerBar);
            this.Name = "OptionsMenu";
            this.Text = "OptionsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.headerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLbl;
        private System.Windows.Forms.RadioButton radioLt;
        private System.Windows.Forms.RadioButton radioDrk;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonAdvanced;
        private System.Windows.Forms.PictureBox headerBar;
        private System.Windows.Forms.PictureBox headerBar2;
    }
}