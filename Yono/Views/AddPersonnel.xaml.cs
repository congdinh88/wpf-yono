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
using System.Windows.Shapes;

namespace Yono.Views
{
    /// <summary>
    /// Interaction logic for AddPersonnel.xaml
    /// </summary>
    public partial class AddPersonnel : Window
    {
        public AddPersonnel()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                foreach (Window window in Application.Current.Windows)
                {
                    if (window != this)
                    {
                        window.Close();
                    }
                }
            }

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            Expander expandedExpander = sender as Expander;
            foreach (Expander expander in leftBar.Children)
            {
                if (expander != expandedExpander && expander.IsExpanded)
                {
                    expander.IsExpanded = false;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (MainContent.Content is Personnel personnel)
            {
                AddPersonnel addPersonnel = new AddPersonnel();
                addPersonnel.Show();
            }

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView listView = sender as ListView;
            ListViewItem selectedItem = listView.SelectedItem as ListViewItem;
            string str = selectedItem.Content.ToString();
            switch (str)
            {
                case "Nhân sự":
                    AddPersonnel addPersonnel = new AddPersonnel();
                    MainContent.Navigate(new Personnel());
                    break;
            }
        }

    }
}
