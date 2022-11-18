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
    /// Logika interakcji dla klasy PaymentHistoryWindow.xaml
    /// </summary>
    public partial class PaymentHistoryWindow : Window
    {
        public PaymentHistoryWindow(BindingList<string> listOfTransaction)
        {
            InitializeComponent();
            this.ListOfPayments.ItemsSource = listOfTransaction;
           

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
