
namespace Bankomat
{
    partial class FrmDepositWithdraw
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
            this.btnDepOK = new System.Windows.Forms.Button();
            this.btnDepCancel = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadejte částku (max. 100 tisíc)";
            // 
            // btnDepOK
            // 
            this.btnDepOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDepOK.Location = new System.Drawing.Point(225, 130);
            this.btnDepOK.Name = "btnDepOK";
            this.btnDepOK.Size = new System.Drawing.Size(88, 35);
            this.btnDepOK.TabIndex = 2;
            this.btnDepOK.Text = "Potvrdit";
            this.btnDepOK.UseVisualStyleBackColor = true;
            // 
            // btnDepCancel
            // 
            this.btnDepCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDepCancel.Location = new System.Drawing.Point(16, 130);
            this.btnDepCancel.Name = "btnDepCancel";
            this.btnDepCancel.Size = new System.Drawing.Size(88, 35);
            this.btnDepCancel.TabIndex = 3;
            this.btnDepCancel.Text = "Zrušit";
            this.btnDepCancel.UseVisualStyleBackColor = true;
            // 
            // nudValue
            // 
            this.nudValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudValue.Location = new System.Drawing.Point(16, 86);
            this.nudValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(297, 22);
            this.nudValue.TabIndex = 4;
            this.nudValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // FrmDepositWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 189);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.btnDepCancel);
            this.Controls.Add(this.btnDepOK);
            this.Controls.Add(this.label1);
            this.Name = "FrmDepositWithdraw";
            this.Text = "Vklad / Výběr";
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepOK;
        private System.Windows.Forms.Button btnDepCancel;
        private System.Windows.Forms.NumericUpDown nudValue;
    }
}