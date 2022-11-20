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

namespace AccountsBank
{
    /// <summary>
    /// Logika interakcji dla klasy DepositWindow.xaml
    /// </summary>
    public partial class DepositWindow : Window
    {
        Account m_selectedAccount;
        public DepositWindow(Account selectedAccount)
        {
            InitializeComponent();
            m_selectedAccount = selectedAccount;
        }

        private void DepositCash_Click(object sender, RoutedEventArgs e)
        {
            m_selectedAccount.AddCash(double.Parse(DepoValue.Text));

            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void DepositCash_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

           
        }
    }
}
    
