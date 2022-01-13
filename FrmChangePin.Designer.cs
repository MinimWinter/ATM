
namespace Bankomat
{
    partial class FrmChangePin
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
            this.lblCurPin = new System.Windows.Forms.Label();
            this.lblNewPin = new System.Windows.Forms.Label();
            this.lblNewPinCheck = new System.Windows.Forms.Label();
            this.txtCurPin = new System.Windows.Forms.TextBox();
            this.txtNewPin = new System.Windows.Forms.TextBox();
            this.txtCheckPin = new System.Windows.Forms.TextBox();
            this.btnNPCancel = new System.Windows.Forms.Button();
            this.btnNPOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurPin
            // 
            this.lblCurPin.AutoSize = true;
            this.lblCurPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurPin.Location = new System.Drawing.Point(12, 41);
            this.lblCurPin.Name = "lblCurPin";
            this.lblCurPin.Size = new System.Drawing.Size(114, 18);
            this.lblCurPin.TabIndex = 0;
            this.lblCurPin.Text = "Současný PIN";
            // 
            // lblNewPin
            // 
            this.lblNewPin.AutoSize = true;
            this.lblNewPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewPin.Location = new System.Drawing.Point(12, 78);
            this.lblNewPin.Name = "lblNewPin";
            this.lblNewPin.Size = new System.Drawing.Size(78, 18);
            this.lblNewPin.TabIndex = 1;
            this.lblNewPin.Text = "Nový PIN";
            // 
            // lblNewPinCheck
            // 
            this.lblNewPinCheck.AutoSize = true;
            this.lblNewPinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewPinCheck.Location = new System.Drawing.Point(12, 113);
            this.lblNewPinCheck.Name = "lblNewPinCheck";
            this.lblNewPinCheck.Size = new System.Drawing.Size(111, 18);
            this.lblNewPinCheck.TabIndex = 2;
            this.lblNewPinCheck.Text = "Potvrzení PIN";
            // 
            // txtCurPin
            // 
            this.txtCurPin.Location = new System.Drawing.Point(175, 37);
            this.txtCurPin.Name = "txtCurPin";
            this.txtCurPin.Size = new System.Drawing.Size(226, 22);
            this.txtCurPin.TabIndex = 3;
            // 
            // txtNewPin
            // 
            this.txtNewPin.Location = new System.Drawing.Point(175, 74);
            this.txtNewPin.Name = "txtNewPin";
            this.txtNewPin.Size = new System.Drawing.Size(226, 22);
            this.txtNewPin.TabIndex = 4;
            // 
            // txtCheckPin
            // 
            this.txtCheckPin.Location = new System.Drawing.Point(175, 109);
            this.txtCheckPin.Name = "txtCheckPin";
            this.txtCheckPin.Size = new System.Drawing.Size(226, 22);
            this.txtCheckPin.TabIndex = 5;
            // 
            // btnNPCancel
            // 
            this.btnNPCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNPCancel.Location = new System.Drawing.Point(15, 157);
            this.btnNPCancel.Name = "btnNPCancel";
            this.btnNPCancel.Size = new System.Drawing.Size(88, 35);
            this.btnNPCancel.TabIndex = 7;
            this.btnNPCancel.Text = "Zrušit";
            this.btnNPCancel.UseVisualStyleBackColor = true;
            // 
            // btnNPOK
            // 
            this.btnNPOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNPOK.Location = new System.Drawing.Point(313, 157);
            this.btnNPOK.Name = "btnNPOK";
            this.btnNPOK.Size = new System.Drawing.Size(88, 35);
            this.btnNPOK.TabIndex = 6;
            this.btnNPOK.Text = "Potvrdit";
            this.btnNPOK.UseVisualStyleBackColor = true;
            // 
            // FrmChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 214);
            this.Controls.Add(this.btnNPCancel);
            this.Controls.Add(this.btnNPOK);
            this.Controls.Add(this.txtCheckPin);
            this.Controls.Add(this.txtNewPin);
            this.Controls.Add(this.txtCurPin);
            this.Controls.Add(this.lblNewPinCheck);
            this.Controls.Add(this.lblNewPin);
            this.Controls.Add(this.lblCurPin);
            this.Name = "FrmChangePin";
            this.Text = "Změna PIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurPin;
        private System.Windows.Forms.Label lblNewPin;
        private System.Windows.Forms.Label lblNewPinCheck;
        private System.Windows.Forms.TextBox txtCurPin;
        private System.Windows.Forms.TextBox txtNewPin;
        private System.Windows.Forms.TextBox txtCheckPin;
        private System.Windows.Forms.Button btnNPCancel;
        private System.Windows.Forms.Button btnNPOK;
    }
}