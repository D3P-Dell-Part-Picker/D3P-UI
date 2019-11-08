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
            this.SuspendLayout();
            // 
            // optionsLbl
            // 
            this.optionsLbl.AutoSize = true;
            this.optionsLbl.Font = new System.Drawing.Font("Open Sans Condensed", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.optionsLbl.Location = new System.Drawing.Point(12, 9);
            this.optionsLbl.Name = "optionsLbl";
            this.optionsLbl.Size = new System.Drawing.Size(116, 43);
            this.optionsLbl.TabIndex = 0;
            this.optionsLbl.Text = "Options";
            // 
            // radioLt
            // 
            this.radioLt.AutoSize = true;
            this.radioLt.Location = new System.Drawing.Point(20, 72);
            this.radioLt.Name = "radioLt";
            this.radioLt.Size = new System.Drawing.Size(127, 17);
            this.radioLt.TabIndex = 1;
            this.radioLt.TabStop = true;
            this.radioLt.Text = "Light Theme (Default)";
            this.radioLt.UseVisualStyleBackColor = true;
            this.radioLt.CheckedChanged += new System.EventHandler(this.radioLt_CheckedChanged);
            // 
            // radioDrk
            // 
            this.radioDrk.AutoSize = true;
            this.radioDrk.Location = new System.Drawing.Point(20, 117);
            this.radioDrk.Name = "radioDrk";
            this.radioDrk.Size = new System.Drawing.Size(84, 17);
            this.radioDrk.TabIndex = 2;
            this.radioDrk.TabStop = true;
            this.radioDrk.Text = "Dark Theme";
            this.radioDrk.UseVisualStyleBackColor = true;
            this.radioDrk.CheckedChanged += new System.EventHandler(this.radioDrk_CheckedChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(20, 258);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 47);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(20, 172);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(108, 50);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply Changes";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.radioDrk);
            this.Controls.Add(this.radioLt);
            this.Controls.Add(this.optionsLbl);
            this.Name = "OptionsMenu";
            this.Text = "OptionsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLbl;
        private System.Windows.Forms.RadioButton radioLt;
        private System.Windows.Forms.RadioButton radioDrk;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonApply;
    }
}