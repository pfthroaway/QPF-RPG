using QPF_RPG.Models;
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

namespace QPF_RPG.Views
{
    /// <summary>Interaction logic for Loginpage.xaml</summary>
    public partial class LoginPage : Page
    {
        public LoginPage() => InitializeComponent();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GameState.CalculateScale(Grid);
            TxtLogin.Focus();
        }

        private void BtnFuckQuincy_Click(object sender, RoutedEventArgs e)
        {
            GameState.Navigate(new WorldPage());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e) => GameState.Navigate(new WorldPage());
    }
}