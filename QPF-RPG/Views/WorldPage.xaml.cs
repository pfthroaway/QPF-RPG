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
using QPF_RPG.Models;

namespace QPF_RPG.Views
{
    /// <summary>
    /// Interaction logic for World.xaml
    /// </summary>
    public partial class WorldPage : Page
    {
        public WorldPage()
        {
            InitializeComponent();
        }

        private void SaveMenuItem(object sender, RoutedEventArgs e)
        {

        }

        private void ExitMenuItem(object sender, RoutedEventArgs e)
        {
            GameState.MainWindow.Close();
        }
    }
}
