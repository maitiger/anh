using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class User
    {
        private string name1;
        private string email1;
        private string phone1;

        public string name { get => name1; set => name1 = value; }
        public string email { get => email1; set => email1 = value; }
        public string phone { get => phone1; set => phone1 = value; }
    }
}
