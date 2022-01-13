
namespace Bankomat
{
    partial class FrmBankomat
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
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnPinChange = new System.Windows.Forms.Button();
            this.btnLeaveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(81, 97);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(185, 48);
            this.btnBalance.TabIndex = 0;
            this.btnBalance.Text = "Dotaz na zůstatek";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(81, 162);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(185, 48);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Vklad";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(81, 228);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(185, 48);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Výběr";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnPinChange
            // 
            this.btnPinChange.Location = new System.Drawing.Point(81, 294);
            this.btnPinChange.Name = "btnPinChange";
            this.btnPinChange.Size = new System.Drawing.Size(185, 48);
            this.btnPinChange.TabIndex = 3;
            this.btnPinChange.Text = "Změna PIN";
            this.btnPinChange.UseVisualStyleBackColor = true;
            this.btnPinChange.Click += new System.EventHandler(this.btnPinChange_Click);
            // 
            // btnLeaveB
            // 
            this.btnLeaveB.Location = new System.Drawing.Point(81, 362);
            this.btnLeaveB.Name = "btnLeaveB";
            this.btnLeaveB.Size = new System.Drawing.Size(185, 48);
            this.btnLeaveB.TabIndex = 4;
            this.btnLeaveB.Text = "Konec";
            this.btnLeaveB.UseVisualStyleBackColor = true;
            this.btnLeaveB.Click += new System.EventHandler(this.btnLeaveB_Click);
            // 
            // FrmBankomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 496);
            this.Controls.Add(this.btnLeaveB);
            this.Controls.Add(this.btnPinChange);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnBalance);
            this.Name = "FrmBankomat";
            this.Text = "Bankomat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnPinChange;
        private System.Windows.Forms.Button btnLeaveB;
    }
}