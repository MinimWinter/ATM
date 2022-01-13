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
    public partial class FrmDepositWithdraw : Form
    {
        public FrmDepositWithdraw()
        {
            InitializeComponent();
        }

        public int Value()
        {
            int value = (int)nudValue.Value;
            return value;
        }
    }
}
