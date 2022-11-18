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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private BankUser m_user;
        public Window1(string ElementName, string ElementSurname)
        {
            InitializeComponent();
            this.Title = ElementName + " " + ElementSurname;
        }

        public Window1(BankUser user)
        {
            m_user = user;
            InitializeComponent();
            this.Title = m_user.Imie + " " + m_user.Nazwisko;

            this.ListAccounts.ItemsSource = m_user.accountsList;
            Binding binding1 = new Binding();

            binding1.Source = m_user.accountsList;
            this.ListAccounts.SetBinding(ListBox.ItemsSourceProperty, binding1);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddAccount_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void WithDrawMoney_Click(object sender, RoutedEventArgs e)
        {
           
               WithDrawWindow withDrawWindow = new WithDrawWindow((Account)this.ListAccounts.SelectedItem);
            withDrawWindow.ShowDialog();
            m_user.accountsList.ResetBindings();

        }

        private void AddAccount_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void WithDrawMoney_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void DepositMoney_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow depositWindow = new DepositWindow((Account)this.ListAccounts.SelectedItem);
            depositWindow.ShowDialog();
            m_user.accountsList.ResetBindings();
        }

        private void ShowHistoryTransaction_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Account)this.ListAccounts.SelectedItem;
            PaymentHistoryWindow ph = new PaymentHistoryWindow(selectedItem.accountHistory);
            ph.Show();
        }

        private void Grid_GotFocus(object sender, RoutedEventArgs e)
        {
        }
    }
   

    
}
