using System;
using System.Collections;
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

namespace To_Do_List
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

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            var items = lvEntry.SelectedItems;
            
            var result = MessageBox.Show($"Have you finished this task?", "Task Completion", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
                {
                    var itemsList = new ArrayList(items);
                    foreach (var item in itemsList)
                    lvEntry.Items.Remove(item);
                }


        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            lvEntry.Items.Add(entryTxt.Text);
            entryTxt.Clear();
        }

        private void entryTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lvEntry.Items.Add(entryTxt.Text);
                entryTxt.Text = "";
            }
        }
    }
}
