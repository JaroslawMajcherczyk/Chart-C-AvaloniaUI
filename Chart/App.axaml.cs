using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Chart.ViewModels;
using Chart.Views;

namespace Chart
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                MainWindow mainWindow = new MainWindow();
                MainWindowViewModel MVVM = new MainWindowViewModel(mainWindow);

                mainWindow.DataContext = MVVM;
                mainWindow.MVVM = MVVM;

                desktop.MainWindow = mainWindow;
                mainWindow.Show();
            }
         /*   else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
            {
                singleViewPlatform.MainView = new MainWindow
                {
                };
            }*/

            base.OnFrameworkInitializationCompleted();
        }
    }
}