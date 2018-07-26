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
using System.Reflection;

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

        private List<Image> GetImages()
        {
            //Cant use GetFields, must use RUNTIME
            var fields = GetType().GetRuntimeFields();

            var list = new List<FieldInfo>(fields);
            var images = new List<Image>();

            foreach (var l in list)
            {
                if (l.Name.Contains("Image_"))
                {
                    images.Add((Image)l.GetValue(this));
                }
            }

            foreach (var i in images)
            {
                Console.WriteLine(i.Name);
            }

            return images;
        }

        private void SaveMenuItem(object sender, RoutedEventArgs e)
        {
        }

        private void ExitMenuItem(object sender, RoutedEventArgs e)
        {
            GameState.MainWindow.Close();
        }

        private void WorldLoaded(object sender, RoutedEventArgs e)
        {
            var images = GetImages();
            GameState.CalculateScale(ImageGrid);

            foreach (var i in images)
            {
                i.Stretch = Stretch.UniformToFill;
                i.Source = new BitmapImage(new Uri(@"pack://application:,,,/Images/Dude.png"));
                //17,9
                i.Width = ImageGrid.ActualWidth / 17;
                i.Height = ImageGrid.ActualHeight / 9;
            }
        }
    }
}