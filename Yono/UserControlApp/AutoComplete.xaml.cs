using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

namespace Yono.UserControlApp
{
    /// <summary>
    /// Interaction logic for AutoComplete.xaml
    /// </summary>
    /// 
    public class DataSuggesList
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
    }
    public partial class AutoComplete : UserControl
    {
        public ObservableCollection<DataSuggesList> dataSuggesList { get; set; }
        public ObservableCollection<DataSuggesList> filteredData { get; set; }

        public string SelectedColumn
        {
            get { return (string)GetValue(SelectedColumnProperty); }
            set { SetValue(SelectedColumnProperty, value); }
        }

        public static readonly DependencyProperty SelectedColumnProperty =
            DependencyProperty.Register("SelectedColumn", typeof(string), typeof(AutoComplete));
        public AutoComplete()
        {
            InitializeComponent();

            dataSuggesList = new ObservableCollection<DataSuggesList>
                {
                    new DataSuggesList { Column1 = "1", Column2 = "Item1", Column3 = "Description1" },
                    new DataSuggesList { Column1 = "2", Column2 = "Item2", Column3 = "Description2" },
                    new DataSuggesList { Column1 = "3", Column2 = "Item3", Column3 = "Description3" }
                };

            dataGrid.ItemsSource = dataSuggesList;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string query = textBox.Text.ToLower();
            if (string.IsNullOrEmpty(query))
            {
                popup.IsOpen = false;
                return;
            }
            var selectedProperty = typeof(DataSuggesList).GetProperty(SelectedColumn, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            if (selectedProperty != null)
            {
                var matches = dataSuggesList.Where(item =>
                {
                    var value = selectedProperty.GetValue(item)?.ToString();
                    return value != null && value.ToLower().Contains(query);
                }).ToList();

                if (matches.Any())
                {
                    filteredData = new ObservableCollection<DataSuggesList>(matches);
                    dataGrid.ItemsSource = filteredData;
                    popup.IsOpen = true;
                }
                else
                {
                    popup.IsOpen = false;
                }
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedItem is DataSuggesList selectedItem)
            {
                var selectedProperty = selectedItem.GetType().GetProperty(SelectedColumn);
                if (selectedProperty != null)
                {
                    textBox.Text = selectedProperty.GetValue(selectedItem)?.ToString();
                }
                popup.IsOpen = false;
            }
        }

    }
}
