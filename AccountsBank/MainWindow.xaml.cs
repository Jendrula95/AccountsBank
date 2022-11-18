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
       
        public MainWindow()
        {
            InitializeComponent();
            m_users = new BankUsers();
            m_users.AddUser("Adam", " Malysz", 1);
            m_users.AddUser("Adam", " Malysz2", 2);
            m_users.AddUser("Adam", " Malysz3", 3);

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

    public class BankUsers
    {
        public BindingList<BankUser> users;

        public BankUsers()
        {
            users = new BindingList<BankUser>();
        }

        public bool AddUser(string Name, string Surname, long ID, string currency = "PLN")
        {
            BankUser user = new BankUser(Name, Surname, ID, currency);

            users.Add(user);

            return true;

        }

        public bool RemoveUser(string Name, String Surname)
        {
            bool retVal = false;
            foreach (var user in users)
            {
                if (user.Imie == Name && user.Nazwisko == Surname)
                {
                    users.Remove(user);
                    retVal = true;
                }

            }
            return retVal;

        }

    }

    public class BankUser
    {
        public string Imie { get; }
        public string Nazwisko { get; }
        public long ID { get; }
        public override string ToString()
        {
            return Imie.ToString() +" " + Nazwisko.ToString();
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
