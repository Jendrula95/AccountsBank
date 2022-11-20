using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
namespace AccountsBank
{
    public class BankUsers
    {
        public BindingList<BankUser> users;

        public BankUsers()
        {
            users = new BindingList<BankUser>();
        }

        public bool AddUser(string Name, string Surname, long ID, string currency = "PLN")
        {
            BankUser user = new BankUser(Name, Surname, ID, currency);

            users.Add(user);

            return true;

        }

        public bool RemoveUser(string Name, String Surname)
        {
            bool retVal = false;
            foreach (var user in users)
            {
                if (user.Imie == Name && user.Nazwisko == Surname)
                {
                    users.Remove(user);
                    retVal = true;
                }

            }
            return retVal;

        }

    }

}
