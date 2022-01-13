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
    public partial class FrmLogin : Form
    {
        public int selectedIndex;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            RefreshAccountList();
        }

        public void RefreshAccountList()
        {
            lstLogin.Items.Clear();
            foreach(Account account in Model.Accounts)
            {
                if (account != null)
                {
                    lstLogin.Items.Add(account);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                if (lstLogin.SelectedIndex >= 0)
                {
                    if (txtEnterPin.Text == Model.Accounts[lstLogin.SelectedIndex].Pin)
                    {
                        this.Hide();
                        MessageBox.Show("Přihlášení proběhlo úspěšně");
                        selectedIndex = lstLogin.SelectedIndex;
                        FrmBankomat frmBankomat = new FrmBankomat(selectedIndex);
                        frmBankomat.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("ŠPATNÝ PIN!","Špatný pin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            
        }
    }
}
