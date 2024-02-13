using Avalonia.Controls;
using Chart.Views;
using ReactiveUI;

namespace Chart.ViewModels;


public class MainWindowViewModel : ReactiveObject
{
public Window _mainWindow;
public MainWindowViewModel(Window mainWindow)

{
    _mainWindow = mainWindow;
}

}