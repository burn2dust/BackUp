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
using Animation;

namespace WindowAppTest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateAndShowMainWindow();
        }

        private void CreateAndShowMainWindow()
        {
            // TextBox hello = new TextBox();
            // hello.Text = "Hello.";
            // Canvas canvas = new Canvas();
            // canvas.Children.Add(hello);
            // this.Title = "Hello";
            // this.Show();

            // Create the application's main window
            Window mainWindow = MainWin;

            // Create a canvas sized to fill the window
            Canvas myCanvas = new Canvas();
            myCanvas.Background = Brushes.LightSteelBlue;

            // Add a "Hello World!" text element to the Canvas
            TextBlock txt1 = new TextBlock();
            txt1.FontSize = 14;
            txt1.Text = "Hello World!";
            Canvas.SetTop(txt1, 100);
            Canvas.SetLeft(txt1, 10);
            myCanvas.Children.Add(txt1);

            // Add a second text element to show how absolute positioning works in a Canvas
            TextBlock txt2 = new TextBlock();
            txt2.FontSize = 22;
            txt2.Text = "Isn't absolute positioning handy?";
            Canvas.SetTop(txt2, 200);
            Canvas.SetLeft(txt2, 75);
            myCanvas.Children.Add(txt2);
            mainWindow.Content = myCanvas;
            mainWindow.Title = "Canvas Sample";
            mainWindow.Show();
        }
    }
}
