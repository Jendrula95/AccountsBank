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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// en
    public partial class MainWindow : Window
    {
        BankUsers m_users;

        private static Dictionary<string, double> m_currencyMultiplers = new Dictionary<string, double>();

       public static double CurrencyMultipler(string from, string to)
        {
            double retVal = 0;

            if(m_currencyMultiplers.ContainsKey(from+to))
                retVal = m_currencyMultiplers[from+to];
            return retVal;
        }
       
        public MainWindow()
        {
            InitializeComponent();
            m_users = new BankUsers();
            m_users.AddUser("Adam", " Malysz", 1);

            m_currencyMultiplers.Add("PLNEUR", 0.2);
            m_currencyMultiplers.Add("EURPLN", 5);
            m_currencyMultiplers.Add("PLNUSD", 0.17);
            m_currencyMultiplers.Add("USDPLN", 4.73);
            m_currencyMultiplers.Add("PLNGBP", 5);
            m_currencyMultiplers.Add("GBPPLN", 0.2);



            ClientsList.ItemsSource = m_users.users;
         
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var user = (BankUser)ClientsList.SelectedItem;
            Window1 okno = new Window1(user);

            okno.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddUsersWindow addUsers = new AddUsersWindow(m_users);

            addUsers.ShowDialog();
            m_users.users.ResetBindings();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BankUser userToRemove = (BankUser)ClientsList.SelectedItem;

            m_users.users.Remove(userToRemove);

            m_users.users.ResetBindings();
        }
    }

   
   
    
}
