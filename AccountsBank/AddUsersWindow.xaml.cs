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
    /// Logika interakcji dla klasy AddUsersWindow.xaml
    /// </summary>
    /// 
  
    public partial class AddUsersWindow : Window
    {
        BankUsers m_users;
        public AddUsersWindow(BankUsers users)
        {

            InitializeComponent();
           m_users = users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long userID = 0;
            if (m_users.users.Count() !=0)
             userID =  m_users.users.Last().ID + 1;
            m_users.AddUser(NameUser.Text,SurnameUser.Text,userID);
            this.Close();
        }
    }
}
