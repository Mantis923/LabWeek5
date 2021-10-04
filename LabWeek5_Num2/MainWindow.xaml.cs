/// HomeWork 5(Graded Assignment)    
/// File Name: Lab5Week5
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
/// 
///This is a GUI that takes in my speed and gives a warning. 
///A Canvas element that changes color, green (legal speed), 
///yellow (speeding no penalty), red (speeding with penalty).



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

namespace LabWeek5_Num2
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

        private void SpeedWarningButton_Click(object sender, RoutedEventArgs e)
        {
            int speed ;
           
            
           // Console.Write(" Enter your speed on school zone which legal limit is 25mph: ");

            speed = Convert.ToInt32(Console.ReadLine());
            speed = int.Parse(SpeedTextBox.Text);

            if (speed == 25)
            {
                
                Console.Write("Speeding with penalty");
                TempCanvas.Background = Brushes.Yellow;
            }
            else if
               (speed >= 26 )
            {
                
                Console.Write("Speeding with penalty");
                TempCanvas.Background = Brushes.Red;
            }
           else  
            {
               
                Console.Write("Speeding no penalty");
                TempCanvas.Background = Brushes.Green;
            }
        }
    }
}
