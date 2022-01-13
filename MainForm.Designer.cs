
namespace Bankomat
{
    partial class frmMain
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainSave = new System.Windows.Forms.Button();
            this.btnMainLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(63, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(255, 54);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Přihlášení";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.Location = new System.Drawing.Point(63, 228);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(255, 54);
            this.btnNewAcc.TabIndex = 1;
            this.btnNewAcc.Text = "Vytvořit účet";
            this.btnNewAcc.UseVisualStyleBackColor = true;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(63, 447);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(255, 54);
            this.btnLeave.TabIndex = 2;
            this.btnLeave.Text = "Odejít";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Úvodní menu";
            // 
            // btnMainSave
            // 
            this.btnMainSave.Location = new System.Drawing.Point(63, 302);
            this.btnMainSave.Name = "btnMainSave";
            this.btnMainSave.Size = new System.Drawing.Size(255, 54);
            this.btnMainSave.TabIndex = 4;
            this.btnMainSave.Text = "Uložit účty";
            this.btnMainSave.UseVisualStyleBackColor = true;
            this.btnMainSave.Click += new System.EventHandler(this.btnMainSave_Click);
            // 
            // btnMainLoad
            // 
            this.btnMainLoad.Location = new System.Drawing.Point(63, 372);
            this.btnMainLoad.Name = "btnMainLoad";
            this.btnMainLoad.Size = new System.Drawing.Size(255, 54);
            this.btnMainLoad.TabIndex = 5;
            this.btnMainLoad.Text = "Načíst účty";
            this.btnMainLoad.UseVisualStyleBackColor = true;
            this.btnMainLoad.Click += new System.EventHandler(this.btnMainLoad_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 526);
            this.Controls.Add(this.btnMainLoad);
            this.Controls.Add(this.btnMainSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnNewAcc);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmMain";
            this.Text = "Bankomat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnNewAcc;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainSave;
        private System.Windows.Forms.Button btnMainLoad;
    }
}

