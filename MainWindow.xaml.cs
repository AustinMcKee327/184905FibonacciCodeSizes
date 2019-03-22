/* Austin Mckee
 * March 22nd, 2019
 * This code is supposed to output rectangles with size proportions to its number based upon the Fibonacci Code
 * I need to figure out how to change it to single numbers so I can place each one in a rectangle
 */
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

namespace _184905FibonacciSequenceDrawing
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

        private void btnFib_Click(object sender, RoutedEventArgs e)
        {
            int s1 = 0;
            int s2 = 1;
            int numberOfItems = 10;
            string fib = "";
            if (numberOfItems >= 1)
            {
                fib = s1.ToString();
            }
            if (numberOfItems >= 2)
            {
                fib += ", " + s2.ToString();
            }
            for (int i = 2; i < numberOfItems; i++)
            {
                int next = s1 + s2;
                fib += ", " + next.ToString();
                s1 = s2;
                s2 = next;
            }
            TextBlock textBlock = new TextBlock();

            textBlock.Text = fib;

            textBlock.Foreground = Brushes.Black;
            textBlock.Background = Brushes.Green;

            Canvas.SetLeft(textBlock, 125);

            Canvas.SetTop(textBlock, 100);

            canvas.Children.Add(textBlock);


        }
    }
}