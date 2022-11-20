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
   
    public class BankAccounts
    {
        public BindingList<Account> accounts;
        public BankAccounts()
        {
            accounts = new BindingList<Account>();
        }  
        public bool AddAccount(string NrKonta, string defaultCurrency = "PLN")
        {
            Account account = new Account(NrKonta, defaultCurrency);
            accounts.Add(account);  
            return true;

        }
    }
}
