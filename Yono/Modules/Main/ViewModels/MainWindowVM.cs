using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Yono.Modules.Main.ViewModels
{
    public class MainWindowVM:ObservableObject
    {

        [RelayCommand]
        void Expander_Expanded()
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

    }
}
