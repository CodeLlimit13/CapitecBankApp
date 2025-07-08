
using Microsoft.Maui.Controls;

namespace CapitecBankApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Simple validation
        if (string.IsNullOrWhiteSpace(UsernameEntry.Text) ||
            string.IsNullOrWhiteSpace(PasswordEntry.Text))
        {
            await DisplayAlert("Error", "Please enter both username and password", "OK");
            return;
        }

        // Navigate to Dashboard
        await Navigation.PushAsync(new DashboardPage());
    }
}