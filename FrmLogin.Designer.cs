
namespace Bankomat
{
    partial class FrmLogin
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
            this.lstLogin = new System.Windows.Forms.ListBox();
            this.lblEnterPin = new System.Windows.Forms.Label();
            this.txtEnterPin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLogin
            // 
            this.lstLogin.FormattingEnabled = true;
            this.lstLogin.ItemHeight = 16;
            this.lstLogin.Location = new System.Drawing.Point(29, 29);
            this.lstLogin.Name = "lstLogin";
            this.lstLogin.Size = new System.Drawing.Size(274, 132);
            this.lstLogin.TabIndex = 0;
            // 
            // lblEnterPin
            // 
            this.lblEnterPin.AutoSize = true;
            this.lblEnterPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnterPin.Location = new System.Drawing.Point(26, 202);
            this.lblEnterPin.Name = "lblEnterPin";
            this.lblEnterPin.Size = new System.Drawing.Size(79, 17);
            this.lblEnterPin.TabIndex = 2;
            this.lblEnterPin.Text = "Zadej PIN";
            // 
            // txtEnterPin
            // 
            this.txtEnterPin.Location = new System.Drawing.Point(138, 202);
            this.txtEnterPin.Name = "txtEnterPin";
            this.txtEnterPin.Size = new System.Drawing.Size(165, 22);
            this.txtEnterPin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Location = new System.Drawing.Point(228, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Přihlásit";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoginCancel.Location = new System.Drawing.Point(29, 263);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(75, 34);
            this.btnLoginCancel.TabIndex = 5;
            this.btnLoginCancel.Text = "Zrušit";
            this.btnLoginCancel.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 320);
            this.Controls.Add(this.btnLoginCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtEnterPin);
            this.Controls.Add(this.lblEnterPin);
            this.Controls.Add(this.lstLogin);
            this.Name = "FrmLogin";
            this.Text = "Přihlášení";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLogin;
        private System.Windows.Forms.Label lblEnterPin;
        private System.Windows.Forms.TextBox txtEnterPin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginCancel;
    }
}