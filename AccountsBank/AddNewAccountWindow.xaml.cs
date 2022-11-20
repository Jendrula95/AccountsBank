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
    /// Logika interakcji dla klasy AddNewAccountWindow.xaml
    /// </summary>
    /// 
   
    public partial class AddNewAccountWindow : Window
    {
        BindingList<Account> m_accountList;
        public AddNewAccountWindow(BindingList<Account> accountList)
        {
         
            InitializeComponent();
            m_accountList = accountList;
        }

        private void chooseCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddNewAccount_Click(object sender, RoutedEventArgs e)
        {
            Account newAccount = new Account(Account.GenerateAccountNr(),this.chooseCurrency.Text);
            m_accountList.Add(newAccount);
            m_accountList.ResetBindings();
            this.Close();
         
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
