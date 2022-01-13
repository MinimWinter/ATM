using System;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class FrmNewAccount : Form
    {
        public FrmNewAccount()
        {
            InitializeComponent();
        }

        private Account account = new Account();

        public Account Account
        {
            get
            {
                if (txtPin.Text == txtPinControl.Text)
                {

                    for (int i = 0; i < Model.Accounts.Count; i++)
                    {
                        if (txtID.Text == Model.Accounts[i].ID)
                        {
                            MessageBox.Show("Zadané ID již existuje!", "Chyba!",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Account acc = new Account()
                            {
                                ID = "ERROR",
                                Pin = "ERROR",
                                Zustatek = -1
                            };
                            return acc;
                        }
                    }
                    account.ID = txtID.Text;
                    account.Pin = txtPin.Text;
                    account.Zustatek = 0;
                    return account;
                } else { MessageBox.Show("Hesla se neshodují! Účet nebyl vytvořen", "Chyba!",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Account acc = new Account()
                    {
                        ID = "ERROR",
                        Pin = "ERROR",
                        Zustatek = -1
                    };
                    return acc;
                      }
            }

            set
            {
                this.account = value;
                txtID.Text = value.ID;
                txtPin.Text = value.Pin;            
            }
        }

       

        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnCreateAcc.Enabled = true;
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {

        }
    }
}
