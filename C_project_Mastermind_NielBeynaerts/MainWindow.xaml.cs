using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C_project_Mastermind_NielBeynaerts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SolidColorBrush[] colors = { Brushes.Red, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.White, Brushes.Orange };
            string[] colorsName = { "Red", "Yellow", "Green", "Blue", "White", "Orange" };
            int[] randomColors = new int[4];

            Random rnd = new Random();
            for (int i = 0; i < randomColors.Length; i++)
            {
                randomColors[i] = rnd.Next(1,6);
            }
            this.Title = $"{colorsName[randomColors[0]].ToString()}, {colorsName[randomColors[1]].ToString()}, {colorsName[randomColors[2]].ToString()}, {colorsName[randomColors[3]].ToString()}";
        }




        private void color1Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void color2Button_Click(object sender, RoutedEventArgs e)
        {
            radioButtonsGroupBox.Visibility = Visibility.Visible;


        }

        private void color3Button_Click(object sender, RoutedEventArgs e)
        {
            radioButtonsGroupBox.Visibility = Visibility.Visible;

        }

        private void color4Button_Click(object sender, RoutedEventArgs e)
        {
            radioButtonsGroupBox.Visibility = Visibility.Visible;

        }
    }
}