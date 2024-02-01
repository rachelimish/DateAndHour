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

namespace DateAndHour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int rachelim = 6;
            InitializeComponent();
            //DateTime currentDateTime = DateTime.Now;
            //DateLabel.Content = currentDateTime.ToString();
            string dateTimeFormat = "ddd MMM dd, yyyy    HH:mm:ss";
            string currentDateTime = DateTime.Now.ToString(dateTimeFormat);
            DateLabel.Content = currentDateTime;
            int x = 5;
        }
    }
}
