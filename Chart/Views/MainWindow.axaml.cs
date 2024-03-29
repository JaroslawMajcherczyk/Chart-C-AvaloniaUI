using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Chart.ViewModels;

namespace Chart.Views;


public partial class MainWindow : Window
{
    public MainWindow()
    {

        InitializeComponent();

    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private MainWindowViewModel mvvm;
    public MainWindowViewModel MVVM
    {
        get => mvvm;
        set => mvvm = value;

    }
}