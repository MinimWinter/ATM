using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Account
    {
        public string ID { get; set; }

        public string Pin { get; set; }

        public int Zustatek { get; set; }

        public string DisplayTitle { get => $"{ID}"; }

        public override string ToString()
        {
            return $"ID: {ID}";
        }
    }
}
