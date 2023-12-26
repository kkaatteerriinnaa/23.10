using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace _23._10
{
    public partial class MainWindow : Window
    {
        private string currentOperation;
        private double currentNumber;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            currentNumber = double.Parse(button.Content.ToString());
            display.Text += button.Content.ToString();
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            currentOperation = button.Content.ToString();
            display.Text += " " + currentOperation + " ";
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            var result = new DataTable().Compute(display.Text, null);
            display.Text = result.ToString();
        }

        private void AllClearButton_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            currentNumber = 0;
            currentOperation = null;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }

        
    }
}
