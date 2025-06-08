using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using FluentAvalonia.UI.Controls;
using WebViewControl;

namespace SampleWebView.Avalonia {

    internal class MainWindow : Window {

        public MainWindow() {
            WebView.Settings.LogFile = "ceflog.txt";
            AvaloniaXamlLoader.Load(this);

            DataContext = new MainWindowViewModel(this.FindControl<WebView>("webview"));
        }

        private async void ShowDialog_OnClick(object sender, RoutedEventArgs e) {
            var dialog = new ContentDialog
            {
                Title = "My Dialog Title", 
                PrimaryButtonText = "Ok", 
                SecondaryButtonText = "Not OK", 
                CloseButtonText = "Close",
            };
            
            var result = await dialog.ShowAsync(this);
        }
    }
}