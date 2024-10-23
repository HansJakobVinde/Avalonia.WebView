using Avalonia.Controls;

namespace SampleWebView.Views;
public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        //PART_Button.Click += PART_Button_Click;
        PART_WebView1.WebViewNewWindowRequested += PART_WebView1_WebViewNewWindowRequested;
        PART_WebView2.WebViewNewWindowRequested += PART_WebView2_WebViewNewWindowRequested;
        PART_WebView3.WebViewNewWindowRequested += PART_WebView3_WebViewNewWindowRequested;
    }

    private void PART_WebView1_WebViewNewWindowRequested(object? sender, WebViewCore.Events.WebViewNewWindowEventArgs e)
    {
        e.UrlLoadingStrategy = WebViewCore.Enums.UrlRequestStrategy.OpenInWebView;
    }
    private void PART_WebView2_WebViewNewWindowRequested(object? sender, WebViewCore.Events.WebViewNewWindowEventArgs e)
    {
        e.UrlLoadingStrategy = WebViewCore.Enums.UrlRequestStrategy.OpenInWebView;
    }
    private void PART_WebView3_WebViewNewWindowRequested(object? sender, WebViewCore.Events.WebViewNewWindowEventArgs e)
    {
        e.UrlLoadingStrategy = WebViewCore.Enums.UrlRequestStrategy.OpenInWebView;
    }

    private void PART_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Window window = new()
        {
            Height = 600,
            Width = 600,
        };
        window.Show();
    }
}