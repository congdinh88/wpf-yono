using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Yono.Models;

namespace Yono.Pages
{
    /// <summary>
    /// Interaction logic for Personnel.xaml
    /// </summary>
    public partial class Personnel : Page
    {
        ObservableCollection<PersonnelModel> people = new ObservableCollection<PersonnelModel>
        {
            new PersonnelModel { Id = "HP01234", Name = "John Doe",DateOfBirth= new DateTime(1988,01,12),JobPosition="BGĐ", Workshop = "VP", Tell="012345",Add="Hải Phòng", TellOfDear="12304", Date1=new DateTime(2020, 05, 12) },
            new PersonnelModel { Id = "HP01235", Name = "Nguyễn Văn Anh",DateOfBirth=new DateTime(1985,05,12),JobPosition="KTV", Workshop = "Bảo trì cơ", Tell="012345",Add="Hải Phòng", TellOfDear="12304", Date1=new DateTime(2009, 01, 12) },
            new PersonnelModel { Id = "HP11234", Name = "Sammy Doe",DateOfBirth=new DateTime(1982,02,12),JobPosition="CN", Workshop = "Đường ống", Tell="012345",Add="Hải Phòng", TellOfDear="12304", Date1=new DateTime(2014,03,12)},
            new PersonnelModel { Id = "HP11244", Name = "Doe",DateOfBirth=new DateTime(1981,02,12),JobPosition="CN", Workshop = "Bảo trì cơ", Tell="012345",Add="Hải Phòng", TellOfDear="12304", Date1=new DateTime(2010,03,12)}
        };
        public Personnel()
        {
            InitializeComponent();
            this.DataContext = this;
            PersonnelGrid.ItemsSource = people;
        }
    }
}
