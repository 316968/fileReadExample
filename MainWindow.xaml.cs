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

namespace fileReadExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string tempSplit;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "";
            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader("birthdayList.txt");
                while (!reader.EndOfStream)
                {
                    lblOutput.Content += reader.ReadLine() + Environment.NewLine;
                }
                reader.Close();
                
            }
            catch (Exception ex)
            {
                lblOutput.Content = ex.Message;
            }
            
        }

        private void readFile2_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "";
            tempSplit = "";
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("bl2.txt");
                while (!sr.EndOfStream)
                {
                    string fullName = sr.ReadLine();
                    string [] names = fullName.Split(new char[] { ',' });
                    tempSplit += names[0] + Environment.NewLine;
                    //lblOutput.Content += sr.ReadLine() + Environment.NewLine;
                }
                lblOutput.Content = tempSplit;
                sr.Close();
            }
            catch (Exception exc)
            {
                lblOutput.Content = exc.Message;
            }
        }
    }
}
