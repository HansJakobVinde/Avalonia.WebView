using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace SampleWebView.Views;
public partial class MainView : UserControl
{
    private List<(double x, double y)> dataPoints = new List<(double x, double y)>();
    private PlotlyGraph plotlyGraph = new PlotlyGraph();
    public WebSocketHandler? webSocketHandler;
    private string htmlFilePath = "/Users/hansjakobvinde/Revolve/test_webview/Avalonia.WebView/Source/Sample/SampleWebView/SampleWebView/Views/html/plotlygraph.html";
    public MainView()
    {
        InitializeComponent();

        StartWebSocketConnection();
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

    private async void StartWebSocketConnection()
    {
        string url = "ws://localhost:8080/ws/datastream";
        webSocketHandler = new WebSocketHandler(url);
        webSocketHandler.OnDataReceived += OnDataReceived;

        // Start the WebSocket connection
        await webSocketHandler.Start();
    }

    private void OnDataReceived(DataMessage dataMessage)
    {
        // Console.WriteLine("Received DataMessage:");
        // foreach (var key in dataMessage.Data.Keys)
        // {
        //     Console.WriteLine($"Key: {key}, Value: {dataMessage.Data[key]}");
        // }

        if (dataMessage.Data.TryGetValue("vcu/114.InsEstimates1.pitch", out var altitude))
        {
            double alt = 0;
            if (altitude is JsonElement jsonElement && jsonElement.TryGetDouble(out double value))
            {
                alt = value;
            }
            else
            {
                Console.WriteLine("Invalid altitude value.");
                return;
            }

            var timestamp = DateTimeOffset.FromUnixTimeMilliseconds(dataMessage.Timestamp)
                .UtcDateTime.ToOADate();
                
            dataPoints.Add((timestamp, alt));

            // Console.WriteLine($"Added DataPoint: {timestamp}, {alt}");

            Avalonia.Threading.Dispatcher.UIThread.InvokeAsync(UpdateGraph);
        }
    }

    private void UpdateGraph()
    {
        // Console.WriteLine($"Number of DataPoints: {dataPoints.Count}");

        plotlyGraph.UpdateGraph(dataPoints);
        
        string updatedHtml = plotlyGraph.GetHtml();
        File.WriteAllText(htmlFilePath, updatedHtml);

        PART_WebView2.Reload();
    }

}