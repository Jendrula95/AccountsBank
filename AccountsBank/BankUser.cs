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
    public class BankUser
    {
        public string Imie { get; }
        public string Nazwisko { get; }
        public long ID { get; }
        public override string ToString()
        {
            return Imie.ToString() + " " + Nazwisko.ToString();
        }

        public BankUser(string Name, string Surname, long ID, string currency)
        {
            Imie = Name;
            Nazwisko = Surname;
            accountsList = new BindingList<Account>();


            string nrKonta = Account.GenerateAccountNr();
            Account defaultAccount = new Account(nrKonta, currency);
            accountsList.Add(defaultAccount);


        }

        public BindingList<Account> accountsList;
    }
}
