using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Chart.ViewModels;
using Avalonia.Threading;
using Avalonia.Layout;
using System;
using Avalonia.Input;

namespace Chart.Views;

public partial class MainView : UserControl
{

    #region Privat Members

    private Control mChannelConfigPopup;
    private Control mChannelConfigButton;
    private Control mMainGrid;

    #endregion
    public MainView()
    {
        InitializeComponent();
        
        DataContext = new MainViewModel();

        mChannelConfigPopup = this.FindControl<Control>("ChannelConfigurationPopup") ?? throw new Exception("Cannot finde Channel configuratio Popup by name");
        mChannelConfigButton = this.FindControl<Control>("ChannelConfigurationButton") ?? throw new Exception("Cannot finde Channel configuratio button by name");
        mMainGrid = this.FindControl<Control>("MainGrid") ?? throw new Exception("Cannot finde main grid by name");


    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        
        
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);


        // Get relative position of button, in relation to main grid 
        var position = mChannelConfigButton.TranslatePoint(new Point(), mMainGrid) ??
            throw new Exception("Cannot get TranslatePoint form configuration button");


        // Set margin of popup si it appears bottom left of  button 
        Dispatcher.UIThread.InvokeAsync(() =>
        { 
            mChannelConfigPopup.Margin = new Thickness(
            position.X,0,0,mMainGrid.Bounds.Height - position.Y - mChannelConfigButton.Bounds.Height
            );
        }, DispatcherPriority.Background);
    }

        private void InputElement_OnPointerPressed(object sender, PointerPressedEventArgs e) => ((MainViewModel)DataContext).ChannelConfigurationButtonPressedCommand.Execute(null);

}