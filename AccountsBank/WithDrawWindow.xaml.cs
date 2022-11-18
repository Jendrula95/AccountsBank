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
    /// Logika interakcji dla klasy WithDrawWindow.xaml
    /// </summary>
    public partial class WithDrawWindow : Window
    {
        Account m_selectedAccount;
        public WithDrawWindow(Account selectedAccount)
        {
            InitializeComponent();
            m_selectedAccount = selectedAccount;
        }

       

        private void WithDrawsCash_Click(object sender, RoutedEventArgs e)
        {
            m_selectedAccount.WithDraw(double.Parse(WithDrawValue.Text));

            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
