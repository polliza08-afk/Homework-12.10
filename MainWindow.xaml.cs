using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExampleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Digital_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var textBlock = (TextBlock)button.Content;
            string value = textBlock.Text;   //Отримуємо текст натиснутої кнопки

            //Якщо в TextBox зараз "0", замінюємо його на натиснуту цифру,
            //інакше дописуємо в кінець
            if (ResultTextBox.Text == "0")
            {
                ResultTextBox.Text = value;
            }
            else
            {
                ResultTextBox.Text += value;
            }
        }
    }
}