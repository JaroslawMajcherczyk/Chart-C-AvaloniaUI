using Avalonia;
using Avalonia.Controls.Primitives;
using System.Security.AccessControl;

namespace Chart;

public class LargeLabelControl : TemplatedControl
{

    //Large text controler
    public static readonly StyledProperty<string> LargeTextProperty =
        AvaloniaProperty.Register<LargeLabelControl, string>(
            nameof(LargeText),"LARGE TEXT");

   
    public string LargeText
    {
        get => GetValue(LargeTextProperty);
        set => SetValue(LargeTextProperty, value);
    }


    //Small text controler
    public static readonly StyledProperty<string> SmallTextProperty =
        AvaloniaProperty.Register<LargeLabelControl, string>(nameof(SmallText), "small text");

    
    public string SmallText
    {
        get => GetValue(SmallTextProperty);
        set => SetValue(SmallTextProperty, value);
    }




}