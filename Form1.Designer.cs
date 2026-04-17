
namespace GeneratePasssword
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chkCapitalLetters = new System.Windows.Forms.CheckBox();
            this.chkSmallLetters = new System.Windows.Forms.CheckBox();
            this.chkNumbrs = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkMax = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 30);
            this.textBox1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGenerate.Location = new System.Drawing.Point(339, 50);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 30);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            this.btnGenerate.MouseEnter += new System.EventHandler(this.btnGenerate_MouseEnter);
            this.btnGenerate.MouseLeave += new System.EventHandler(this.btnGenerate_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Location = new System.Drawing.Point(344, -1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Gray;
            this.trackBar1.Location = new System.Drawing.Point(4, -1);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(334, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // chkCapitalLetters
            // 
            this.chkCapitalLetters.AutoSize = true;
            this.chkCapitalLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCapitalLetters.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCapitalLetters.ForeColor = System.Drawing.Color.White;
            this.chkCapitalLetters.Location = new System.Drawing.Point(49, 106);
            this.chkCapitalLetters.Name = "chkCapitalLetters";
            this.chkCapitalLetters.Size = new System.Drawing.Size(149, 23);
            this.chkCapitalLetters.TabIndex = 5;
            this.chkCapitalLetters.Text = "Capital Letters";
            this.chkCapitalLetters.UseVisualStyleBackColor = true;
            // 
            // chkSmallLetters
            // 
            this.chkSmallLetters.AutoSize = true;
            this.chkSmallLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSmallLetters.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSmallLetters.ForeColor = System.Drawing.Color.White;
            this.chkSmallLetters.Location = new System.Drawing.Point(234, 106);
            this.chkSmallLetters.Name = "chkSmallLetters";
            this.chkSmallLetters.Size = new System.Drawing.Size(136, 23);
            this.chkSmallLetters.TabIndex = 6;
            this.chkSmallLetters.Text = "Small Letters";
            this.chkSmallLetters.UseVisualStyleBackColor = true;
            // 
            // chkNumbrs
            // 
            this.chkNumbrs.AutoSize = true;
            this.chkNumbrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNumbrs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumbrs.ForeColor = System.Drawing.Color.White;
            this.chkNumbrs.Location = new System.Drawing.Point(49, 150);
            this.chkNumbrs.Name = "chkNumbrs";
            this.chkNumbrs.Size = new System.Drawing.Size(100, 23);
            this.chkNumbrs.TabIndex = 7;
            this.chkNumbrs.Text = "Numbers";
            this.chkNumbrs.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSymbols.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSymbols.ForeColor = System.Drawing.Color.White;
            this.chkSymbols.Location = new System.Drawing.Point(234, 150);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(95, 23);
            this.chkSymbols.TabIndex = 8;
            this.chkSymbols.Text = "Symbols";
            this.chkSymbols.UseVisualStyleBackColor = true;
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMax.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMax.ForeColor = System.Drawing.Color.White;
            this.chkMax.Location = new System.Drawing.Point(165, 188);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(62, 23);
            this.chkMax.TabIndex = 9;
            this.chkMax.Text = "Max";
            this.chkMax.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GeneratePasssword.Properties.Resources._1775810918905;
            this.ClientSize = new System.Drawing.Size(436, 223);
            this.Controls.Add(this.chkMax);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.chkNumbrs);
            this.Controls.Add(this.chkSmallLetters);
            this.Controls.Add(this.chkCapitalLetters);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox chkCapitalLetters;
        private System.Windows.Forms.CheckBox chkSmallLetters;
        private System.Windows.Forms.CheckBox chkNumbrs;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.CheckBox chkMax;
    }
}

