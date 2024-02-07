using Microsoft.UI.Xaml;

namespace onereach_windows_sdk;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnLaunchApp(object sender, RoutedEventArgs e)
    {
        // this is a dummy url, that doesn't refer to any app, use the correct url instead
        string appUrl = "https://apps.onereach.ai/vWT5IwGnRdqadZc6JzetZg";

        OneReach.SDK.Apps.LaunchApp(appUrl);
    }
}
