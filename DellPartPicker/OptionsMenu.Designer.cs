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
            this.headerBar = new System.Windows.Forms.PictureBox();
            this.headerBar2 = new System.Windows.Forms.PictureBox();
            this.piIP = new System.Windows.Forms.TextBox();
            this.remoteserverIP = new System.Windows.Forms.TextBox();
            this.localserverIP = new System.Windows.Forms.TextBox();
            this.labelPiIP = new System.Windows.Forms.Label();
            this.labelRSIP = new System.Windows.Forms.Label();
            this.labelLSIP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // piIP
            // 
            this.piIP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piIP.Location = new System.Drawing.Point(526, 126);
            this.piIP.Name = "piIP";
            this.piIP.Size = new System.Drawing.Size(262, 22);
            this.piIP.TabIndex = 8;
            // 
            // remoteserverIP
            // 
            this.remoteserverIP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remoteserverIP.Location = new System.Drawing.Point(526, 194);
            this.remoteserverIP.Name = "remoteserverIP";
            this.remoteserverIP.Size = new System.Drawing.Size(262, 22);
            this.remoteserverIP.TabIndex = 9;
            // 
            // localserverIP
            // 
            this.localserverIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.localserverIP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localserverIP.Location = new System.Drawing.Point(526, 263);
            this.localserverIP.Name = "localserverIP";
            this.localserverIP.Size = new System.Drawing.Size(262, 22);
            this.localserverIP.TabIndex = 10;
            // 
            // labelPiIP
            // 
            this.labelPiIP.AutoSize = true;
            this.labelPiIP.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPiIP.Location = new System.Drawing.Point(522, 103);
            this.labelPiIP.Name = "labelPiIP";
            this.labelPiIP.Size = new System.Drawing.Size(39, 20);
            this.labelPiIP.TabIndex = 11;
            this.labelPiIP.Text = "Pi IP";
            // 
            // labelRSIP
            // 
            this.labelRSIP.AutoSize = true;
            this.labelRSIP.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRSIP.Location = new System.Drawing.Point(522, 171);
            this.labelRSIP.Name = "labelRSIP";
            this.labelRSIP.Size = new System.Drawing.Size(127, 20);
            this.labelRSIP.TabIndex = 12;
            this.labelRSIP.Text = "Remote Server IP";
            // 
            // labelLSIP
            // 
            this.labelLSIP.AutoSize = true;
            this.labelLSIP.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLSIP.Location = new System.Drawing.Point(522, 240);
            this.labelLSIP.Name = "labelLSIP";
            this.labelLSIP.Size = new System.Drawing.Size(110, 20);
            this.labelLSIP.TabIndex = 13;
            this.labelLSIP.Text = "Local Server IP";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(526, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelLSIP);
            this.Controls.Add(this.labelRSIP);
            this.Controls.Add(this.labelPiIP);
            this.Controls.Add(this.localserverIP);
            this.Controls.Add(this.remoteserverIP);
            this.Controls.Add(this.piIP);
            this.Controls.Add(this.headerBar2);
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
        private System.Windows.Forms.PictureBox headerBar;
        private System.Windows.Forms.PictureBox headerBar2;
        private System.Windows.Forms.TextBox piIP;
        private System.Windows.Forms.TextBox remoteserverIP;
        private System.Windows.Forms.TextBox localserverIP;
        private System.Windows.Forms.Label labelPiIP;
        private System.Windows.Forms.Label labelRSIP;
        private System.Windows.Forms.Label labelLSIP;
        private System.Windows.Forms.Button button1;
    }
}