
namespace Bankomat
{
    partial class FrmNewAccount
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtPinControl = new System.Windows.Forms.TextBox();
            this.lblPinControl = new System.Windows.Forms.Label();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnCancelCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.Location = new System.Drawing.Point(41, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPin.Location = new System.Drawing.Point(41, 115);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(47, 25);
            this.lblPin.TabIndex = 1;
            this.lblPin.Text = "PIN";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(229, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(269, 22);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(229, 118);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(269, 22);
            this.txtPin.TabIndex = 3;
            this.txtPin.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtPinControl
            // 
            this.txtPinControl.Location = new System.Drawing.Point(229, 172);
            this.txtPinControl.Name = "txtPinControl";
            this.txtPinControl.Size = new System.Drawing.Size(269, 22);
            this.txtPinControl.TabIndex = 5;
            this.txtPinControl.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblPinControl
            // 
            this.lblPinControl.AutoSize = true;
            this.lblPinControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPinControl.Location = new System.Drawing.Point(41, 168);
            this.lblPinControl.Name = "lblPinControl";
            this.lblPinControl.Size = new System.Drawing.Size(111, 25);
            this.lblPinControl.TabIndex = 4;
            this.lblPinControl.Text = "PIN znovu";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateAcc.Enabled = false;
            this.btnCreateAcc.Location = new System.Drawing.Point(372, 233);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(126, 51);
            this.btnCreateAcc.TabIndex = 6;
            this.btnCreateAcc.Text = "Vytvořit";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnCancelCreate
            // 
            this.btnCancelCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCreate.Location = new System.Drawing.Point(46, 233);
            this.btnCancelCreate.Name = "btnCancelCreate";
            this.btnCancelCreate.Size = new System.Drawing.Size(126, 51);
            this.btnCancelCreate.TabIndex = 7;
            this.btnCancelCreate.Text = "Odejít";
            this.btnCancelCreate.UseVisualStyleBackColor = true;
            // 
            // FrmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 312);
            this.Controls.Add(this.btnCancelCreate);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.txtPinControl);
            this.Controls.Add(this.lblPinControl);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblID);
            this.Name = "FrmNewAccount";
            this.Text = "Vytvořit účet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtPinControl;
        private System.Windows.Forms.Label lblPinControl;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnCancelCreate;
    }
}