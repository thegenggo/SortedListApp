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

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;

        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(int.Parse(keyTxt.Text), valueTxt.Text);

            ICollection collection = sortedList.Keys;
            string result = "";

            foreach(int key in collection)
            {
                result = result + sortedList[key] + "\n";
            }

            MessageBox.Show(result);
        }
    }
}
