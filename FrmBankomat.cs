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
    public partial class FrmBankomat : Form
    {
        public int index;
        public FrmBankomat(int selIndex)
        {
            InitializeComponent();
            index = selIndex;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Váš zůstatek je " + Model.Accounts[index].Zustatek, "Zůstatek");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            FrmDepositWithdraw frmDeposit = new FrmDepositWithdraw();
            DialogResult result = frmDeposit.ShowDialog();
            if(result == DialogResult.OK)
            {
                Model.Accounts[index].Zustatek += frmDeposit.Value();
                MessageBox.Show("Vklad proveden - Zůstatek aktualizován", "Vklad proveden",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            FrmDepositWithdraw frmDeposit = new FrmDepositWithdraw();
            DialogResult result = frmDeposit.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (frmDeposit.Value() > Model.Accounts[index].Zustatek)
                {
                    MessageBox.Show("Nedostatek financí na účtě!", "Chyba!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Model.Accounts[index].Zustatek -= frmDeposit.Value();
                    MessageBox.Show("Odeberte své peníze - Zůstatek aktualizován", "Výběr proveden",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                }
        }

        private void btnPinChange_Click(object sender, EventArgs e)
        {
            FrmChangePin frmChangePin = new FrmChangePin();
            DialogResult result = frmChangePin.ShowDialog();
            if(result == DialogResult.OK)
            {
                if(frmChangePin.getCurrentPin() == Model.Accounts[index].Pin)
                {
                    if (frmChangePin.getNewPin() == frmChangePin.getNewPinCheck())
                    {
                        Model.Accounts[index].Pin = frmChangePin.getNewPin();
                        MessageBox.Show("PIN byl úspěšně změněn!", "PIN změněn!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }else MessageBox.Show("Potvrzení PIN se neshoduje s novým PIN!", "Chyba!",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }else MessageBox.Show("Současný PIN je nesprávný!", "Chyba!",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnLeaveB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
