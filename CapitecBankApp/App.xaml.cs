using Microsoft.Maui.Controls;

namespace CapitecBankApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage())
        {
            BarBackgroundColor = Color.FromArgb("#0066CC"),
            BarTextColor = Colors.White
        };
    }
}