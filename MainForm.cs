using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNewAccount frmNewAccount = new FrmNewAccount();
            DialogResult result = frmNewAccount.ShowDialog();
            if(result == DialogResult.OK)
            {
                Account account = frmNewAccount.Account;
                Model.Accounts.Add(account);              
            }
            this.Show();
        }

        private void SaveAccounts()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Databáze účtů (*.dbd) |*.dbd|Všechny soubory (*.*)|*.*",
                Title = "Uložení učtů",
            };

            var res = sfd.ShowDialog();
            if(res == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                string tempName = System.IO.Path.GetTempFileName();
                string fileContent = GenerateFileContent();

                try
                {
                    System.IO.File.WriteAllText(tempName, fileContent);
                    System.IO.File.Copy(tempName, fileName, true);
                    System.IO.File.Delete(tempName);
                    MessageBox.Show("Účty byly aktualizovány a uloženy!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Nepodařilo se aktualizovat a uložit účty!");
                }
            }
        }

        private void LoadAccounts()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Databáze účtů (*.dbd) |*.dbd|Všechny soubory (*.*)|*.*",
                Title = "Načtení učtů",
            };

            var res = ofd.ShowDialog();
            if(res == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                try
                {
                    string[] fileContent = System.IO.File.ReadAllLines(fileName);
                    LoadContentIntoTheModel(fileContent);
                    MessageBox.Show("Účty byly načteny!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Účty se nepodařilo načíst!");
                }
            }
        }

        private string GenerateFileContent()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var account in Model.Accounts)
            {
                sb.Append(account.ID)
                    .Append(";")
                    .Append(account.Pin)
                    .Append(";")
                    .Append(account.Zustatek)
                    .AppendLine();
            }

            return sb.ToString();
        }

        private void LoadContentIntoTheModel(string[] lines)
        {
            BindingList<Account> accounts = new BindingList<Account>();
            
            foreach(var line in lines)
            {
                string[] pts = line.Split(';');

                accounts.Add(new Account()
                {
                    ID = pts[0],
                    Pin = pts[1],
                    Zustatek = int.Parse(pts[2])
                });
            }
            Model.Accounts.Clear();
            foreach(var account in accounts)
            {
                Model.Accounts.Add(account);
            }
        }

        private void btnMainSave_Click(object sender, EventArgs e)
        {
            SaveAccounts();
        }

        private void btnMainLoad_Click(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Show();
        }
    }
}
