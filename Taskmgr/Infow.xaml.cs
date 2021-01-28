using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Taskmgr
{
    /// <summary>
    /// Interaction logic for Infow.xaml
    /// </summary>
    public partial class Infow : Window
    {
       
        public  Infow()
        {
            InitializeComponent();

           
          
        }

        private void Id_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Id_Loaded(object sender, RoutedEventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (var proc in processes)
            {
                if (proc.ProcessName.ToString() == Name)
                {
                    Id.Text = $"Id:{proc.Id.ToString()}";
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.name = Id.Text;
            this.Close();
        }
    }
}
