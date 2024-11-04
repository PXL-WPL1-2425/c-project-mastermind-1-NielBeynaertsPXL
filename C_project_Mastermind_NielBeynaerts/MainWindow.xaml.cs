using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace C_project_Mastermind_NielBeynaerts
{
    public partial class MainWindow : Window
    {
        private Button selectedButton; // Track the currently selected button

        public MainWindow()
        {
            InitializeComponent();

            SolidColorBrush[] colors = { Brushes.Red, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.White, Brushes.Orange };
            string[] colorsName = { "Red", "Yellow", "Green", "Blue", "White", "Orange" };
            int[] randomColors = new int[4];

            Random rnd = new Random();
            for (int i = 0; i < randomColors.Length; i++)
            {
                randomColors[i] = rnd.Next(0, colors.Length); // Adjusted to use 0-based index
            }
            this.Title = $"{colorsName[randomColors[0]]}, {colorsName[randomColors[1]]}, {colorsName[randomColors[2]]}, {colorsName[randomColors[3]]}";
        }



        private void color1Button_Click(object sender, RoutedEventArgs e)
        {
            selectedButton = color1Button; // Set selected button to color1Button
            radioButtonsGroupBox.Visibility = Visibility.Visible;
            uncheckRadioButtons();
        }

        private void color2Button_Click(object sender, RoutedEventArgs e)
        {
            selectedButton = color2Button; // Set selected button to color2Button
            radioButtonsGroupBox.Visibility = Visibility.Visible;
            uncheckRadioButtons();
        }

        private void color3Button_Click(object sender, RoutedEventArgs e)
        {
            selectedButton = color3Button; // Set selected button to color3Button
            radioButtonsGroupBox.Visibility = Visibility.Visible;
            uncheckRadioButtons();
        }

        private void color4Button_Click(object sender, RoutedEventArgs e)
        {
            selectedButton = color4Button; // Set selected button to color4Button
            radioButtonsGroupBox.Visibility = Visibility.Visible;
            uncheckRadioButtons();
        }

        private void uncheckRadioButtons()
        {
            redRadioButton.IsChecked = false;
            greenRadioButton.IsChecked = false;
            whiteRadioButton.IsChecked = false;
            orangeRadioButton.IsChecked = false;
            blueRadioButton.IsChecked = false;
            yellowRadioButton.IsChecked = false;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (selectedButton != null && sender is RadioButton radioButton)
            {
                radioButtonsGroupBox.Visibility = Visibility.Visible;

                // Set color based on selected radio button for the selected button only
                switch (radioButton.Content.ToString())
                {
                    case "Rood":
                        selectedButton.Background = Brushes.Red;
                        break;
                    case "Groen":
                        selectedButton.Background = Brushes.Green;
                        break;
                    case "Blauw":
                        selectedButton.Background = Brushes.Blue;
                        break;
                    case "Geel":
                        selectedButton.Background = Brushes.Yellow;
                        break;
                    case "Wit":
                        selectedButton.Background = Brushes.White;
                        break;
                    case "Oranje":
                        selectedButton.Background = Brushes.Orange;
                        break;
                    default:
                        selectedButton.Background = Brushes.Transparent;
                        break;
                }
            }
        }

    }
}
