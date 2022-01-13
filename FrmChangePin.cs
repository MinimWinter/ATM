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
    public partial class FrmChangePin : Form
    {
        public FrmChangePin()
        {
            InitializeComponent();
        }

        public string getCurrentPin()
        {
            return txtCurPin.Text;
        }

        public string getNewPin()
        {
            return txtNewPin.Text;
        }

        public string getNewPinCheck()
        {
            return txtCheckPin.Text;
        }
    }
}
