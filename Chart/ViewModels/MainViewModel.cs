using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chart.ViewModels;

public partial class MainViewModel : ObservableObject

    // Zmiana stringa z jednej na druga
{
    [ObservableProperty]

    private string boldTitle = "Avalonia";

    [ObservableProperty]

    private string regularTitle = "Laudnes Metter";
    public MainViewModel()
    {
        Task.Run(async () =>
        {
           
            await Task.Delay(2000);
            BoldTitle = "Hellow SIema 2";


        });
    }
}
