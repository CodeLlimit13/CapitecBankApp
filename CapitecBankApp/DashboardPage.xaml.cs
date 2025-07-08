using Microsoft.Maui.Controls;

namespace CapitecBankApp;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
    }

    private async void OnTransactionsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TransactionsPage());
    }
}