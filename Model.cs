using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Bankomat
{
    public static class Model
    {
        public static BindingList<Account> Accounts { get; set; } = new BindingList<Account>();
    }
}
