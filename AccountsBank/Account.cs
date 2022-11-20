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
    public class Account
    {

        const string withDrawString = "Pobrano z konta nr: ";
        const string incomeString = "Wplacono na konto nr: ";
        const string afterSaldoString = "Saldo po operacji";

        private string cashCurrency;
        private double cashValue;

        public BindingList<string> accountHistory { get; }

        public double getAccoutValue()
        {
            return cashValue;
        }
        public string getAccountCurrency()
        {
            return cashCurrency;
        }

        public const string BankID = "44";

        string NumerKonta;

        public static string GenerateAccountNr()
        {
            string AccountNr = BankID;

            Random rnd = new Random();
            for (int j = 0; j < 24; j++)
            {
                AccountNr += rnd.Next(9);
            }
            return AccountNr;
        }

        public Account(string nrKonta, string defaultCurrency = "PLN")
        {
            NumerKonta = nrKonta;
            cashCurrency = defaultCurrency;
            cashValue = 0;
            accountHistory = new BindingList<string>();
        }

        public override string ToString()
        {
            string RetValue = "";
            RetValue += "Numer Konta: " + NumerKonta + "\n";
            RetValue +=  "Waluta: " + cashCurrency + "\n" + "Saldo: " + cashValue;

            return RetValue;

        }

        public void AddCash(double aValToAdd)
        {
            cashValue += aValToAdd;
            accountHistory.Insert(0, DateTime.Now + ": " + incomeString + this.NumerKonta +" : "  + aValToAdd +" " +cashCurrency  + "." + afterSaldoString + ": " + cashValue  + cashCurrency);
           
        }

        public bool WithDraw(double aValToGet)
        {
            bool retVal = true;

            if ( cashValue > aValToGet)
            {
                cashValue -= aValToGet;
                //accountHistory.Insert(0, DateTime.Now + ": " + withDrawString + " : " + aValToGet + cashCurrency + ". " + afterSaldoString + ": " + cashValue + cashCurrency + ".");
                accountHistory.Insert(0, DateTime.Now + ": " + withDrawString + this.NumerKonta + " : " + aValToGet + cashCurrency + ". " + afterSaldoString + ": " + cashValue + cashCurrency + ".");
            }
            else
            {
                retVal = false;
            }

            return retVal;
        }

        public string GetAccountSaldo()
        {
            return cashCurrency + cashValue;
        }

        public BindingList<string> GetAccountHistory()
        {
            return accountHistory;
        }
      
    }
}
