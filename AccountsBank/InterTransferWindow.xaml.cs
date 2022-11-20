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
using System.Windows.Shapes;
using System.ComponentModel;

namespace AccountsBank
{
    /// <summary>
    /// Logika interakcji dla klasy InterTransferWindow.xaml
    /// </summary>
    public partial class InterTransferWindow : Window
    {
     
        public InterTransferWindow(BindingList<Account> accounts)
        {
            InitializeComponent();
            this.FromListAccount.ItemsSource = accounts;
            this.ToListAccount.ItemsSource = accounts;
        }

        private void FromListAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ToListAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TransferButton_Click(object sender, RoutedEventArgs e)
        {
            //czy to samo konto : [t] - błąd
            if ((Account)(FromListAccount.SelectedItem) ==(Account)(ToListAccount.SelectedItem))
            {
                MessageBox.Show("Wybrano to samo konto");
                return;
            }
            var accountFrom = (Account)FromListAccount.SelectedItem;
            var accountTo = (Account)ToListAccount.SelectedItem;
            var transferValue = double.Parse(TransferValue.Text);
            if (accountFrom.getAccoutValue() < transferValue )
            {
                MessageBox.Show("Nie wystarczająca ilość środków na koncie");
                return;
            }
            if (accountFrom.getAccountCurrency() != accountTo.getAccountCurrency())
            {
                if (MessageBox.Show("Wykryto rózne waluty \n Czy chcesz przewalutować?",
                   "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    // Close the window
                    transferValue = transferValue * MainWindow.CurrencyMultipler(accountFrom.getAccountCurrency(), accountTo.getAccountCurrency());
                }
                else
                {
                    return;
                }
            }

            // Do not close the window  
            accountFrom.WithDraw(transferValue);
            accountTo.AddCash(transferValue);
  
            this.Close();
            

        }

        private void TransferValue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
