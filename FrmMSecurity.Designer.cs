
namespace GeneratePasssword
{
    partial class FrmMSecurity
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPasswordGenrator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSecurity";
            // 
            // btnPasswordGenrator
            // 
            this.btnPasswordGenrator.BackColor = System.Drawing.Color.White;
            this.btnPasswordGenrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordGenrator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPasswordGenrator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordGenrator.Location = new System.Drawing.Point(39, 162);
            this.btnPasswordGenrator.Name = "btnPasswordGenrator";
            this.btnPasswordGenrator.Size = new System.Drawing.Size(176, 30);
            this.btnPasswordGenrator.TabIndex = 1;
            this.btnPasswordGenrator.Text = "Password Genrator";
            this.btnPasswordGenrator.UseVisualStyleBackColor = false;
            this.btnPasswordGenrator.Click += new System.EventHandler(this.btnPasswordGenrator_Click);
            this.btnPasswordGenrator.MouseEnter += new System.EventHandler(this.btnPasswordGenrator_MouseEnter);
            this.btnPasswordGenrator.MouseLeave += new System.EventHandler(this.btnPasswordGenrator_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // FrmMSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GeneratePasssword.Properties.Resources._1775810918905;
            this.ClientSize = new System.Drawing.Size(246, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPasswordGenrator);
            this.Controls.Add(this.label1);
            this.Name = "FrmMSecurity";
            this.Text = "FrmMSecurity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPasswordGenrator;
        private System.Windows.Forms.Button button1;
    }
}