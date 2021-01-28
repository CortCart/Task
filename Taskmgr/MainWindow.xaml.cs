using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using Microsoft.VisualBasic;

namespace Taskmgr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static  string name;
       
        public MainWindow()
        {
            InitializeComponent();


            {
                Process[] processes = Process.GetProcesses();
                for (int i = 0; i < 100000; i++)
                {
                    Task.Items.Add(" ");
                }


                for (int i = 0; i < processes.Count(); i++)
                {
                    Task.Items[i] = processes[i].ProcessName.ToString();
                }
            }
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (var proces in processes)
            {
                Task.Items.Add(proces);
            }
        }

        private void Task_MouseMove(object sender, MouseEventArgs e)
        {
           
          
        }

        private void GetInfo_Click(object sender, RoutedEventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (var proces in processes)
            {
                if (Task.SelectedItem.ToString() == proces.ProcessName.ToString())
                {

                    try
                    {
                        string info = string.Empty;
                        info += $"ID :{proces.Id.ToString()}";
                        info += $"\nStart time : {proces.StartTime.ToString()}";
                        MessageBox.Show(info);
                        break;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Access denied");
                    }
                    
                }
                    
            }           
           for (int i = 0; i < processes.Count(); i++)
            {
                Task.Items[i] = processes[i].ProcessName.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (var proces in processes)
            {
                if (Task.SelectedItem.ToString() == proces.ProcessName.ToString())
                {
                    try
                    {
                        proces.Kill();
                        break;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Not select task");
                    }
                   
                }

            }
            for (int i = 0; i < processes.Count(); i++)
            {
                Task.Items[i] = processes[i].ProcessName.ToString();
            }         
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Infow infow = new Infow();
            infow.ShowDialog();
            try
            {
                if (name==null)
                {
                   
                }
                else
                {
                    Process.Start(name);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Unvalid app");
            }
            Process[] processes = Process.GetProcesses();           
           for (int i = 0; i < processes.Count(); i++)
            {
                Task.Items[i] = processes[i].ProcessName.ToString();
            }

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Process[] processes = Process.GetProcesses();          
            for (int i = 0; i < processes.Count(); i++)
            {
                Task.Items[i] = processes[i].ProcessName.ToString();
            }
        }
    }
}
