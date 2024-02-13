using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Chart.ViewModels;

namespace Chart.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        
        DataContext = new MainViewModel();

    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        
        
    }

}