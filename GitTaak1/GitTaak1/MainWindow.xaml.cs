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

namespace GitTaak1
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

        private void pxlPNG_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Black);
        }

        private void pxlPNG_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Red);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Green);
        }

        private void Image_MouseLeave_2(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Image_MouseLeave_3(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Textbox1.Text = "Rood: #FF0000";
            Textbox2.Text = "Rood is de kleur van warmte";
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Textbox1.Text = "Geel: #FFFF00";
            Textbox2.Text = "Geel is de kleur van levenslust";
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Textbox1.Text = "Groen: #008000";
            Textbox2.Text = "Groen is de kleur van genezing";
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Textbox1.Text = "Blauw: #0000FF";
            Textbox2.Text = "Blauw is de kleur van intelligentie";
        }
    }
}