using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Account
    {

      private string _username { get; set; }
       public string username { get => _username;  }

       private string _passwword { get; set; }
       public  string passwword { get => _passwword; }

        private int _no { get; set; }
        public int No { get => _no; }
       

      public Account(string username, string password)
        {
            
        }

    }
}
