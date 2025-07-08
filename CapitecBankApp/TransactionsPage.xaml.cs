using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace CapitecBankApp;

public partial class TransactionsPage : ContentPage
{
    public ObservableCollection<Transaction> Transactions { get; set; } = new();

    public TransactionsPage()
    {
        InitializeComponent();
        LoadTransactions();
        BindingContext = this;
    }

    private void LoadTransactions()
    {
        Transactions = new ObservableCollection<Transaction>
        {
            new Transaction
            {
                Description = "Shoprite Checkers",
                DateTime = "Today, 14:30",
                Amount = "-R 487.50",
                AmountColor = Colors.Red,
                Icon = "🏪",
                CategoryColor = "#E8F5E8",
                Reference = "TXN001234567",
                Balance = "R 14,760.36"
            },
            new Transaction
            {
                Description = "Salary Payment",
                DateTime = "Yesterday, 06:00",
                Amount = "+R 12,500.00",
                AmountColor = Colors.Green,
                Icon = "💰",
                CategoryColor = "#E3F2FD",
                Reference = "SAL987654321",
                Balance = "R 15,247.86"
            },
            new Transaction
            {
                Description = "Eskom Payment",
                DateTime = "2 days ago, 10:15",
                Amount = "-R 850.00",
                AmountColor = Colors.Red,
                Icon = "⚡",
                CategoryColor = "#FFF3E0",
                Reference = "ESK456789123",
                Balance = "R 2,747.86"
            },
            new Transaction
            {
                Description = "MTN Airtime",
                DateTime = "3 days ago, 08:45",
                Amount = "-R 50.00",
                AmountColor = Colors.Red,
                Icon = "📱",
                CategoryColor = "#E3F2FD",
                Reference = "MTN789123456",
                Balance = "R 3,597.86"
            },
            new Transaction
            {
                Description = "Pick n Pay",
                DateTime = "4 days ago, 16:20",
                Amount = "-R 345.75",
                AmountColor = Colors.Red,
                Icon = "🛒",
                CategoryColor = "#E8F5E8",
                Reference = "PNP321654987",
                Balance = "R 3,647.86"
            },
            new Transaction
            {
                Description = "Uber Trip",
                DateTime = "5 days ago, 22:30",
                Amount = "-R 89.50",
                AmountColor = Colors.Red,
                Icon = "🚗",
                CategoryColor = "#F3E5F5",
                Reference = "UBR654321789",
                Balance = "R 3,993.61"
            },
            new Transaction
            {
                Description = "Netflix Subscription",
                DateTime = "6 days ago, 12:00",
                Amount = "-R 199.00",
                AmountColor = Colors.Red,
                Icon = "📺",
                CategoryColor = "#FFF3E0",
                Reference = "NTF147258369",
                Balance = "R 4,083.11"
            },
            new Transaction
            {
                Description = "Woolworths",
                DateTime = "1 week ago, 11:15",
                Amount = "-R 567.80",
                AmountColor = Colors.Red,
                Icon = "🏪",
                CategoryColor = "#E8F5E8",
                Reference = "WOL258369147",
                Balance = "R 4,282.11"
            },
            new Transaction
            {
                Description = "Gym Membership",
                DateTime = "1 week ago, 09:00",
                Amount = "-R 450.00",
                AmountColor = Colors.Red,
                Icon = "🏋️",
                CategoryColor = "#E8F5E8",
                Reference = "GYM369147258",
                Balance = "R 4,849.91"
            },
            new Transaction
            {
                Description = "Freelance Payment",
                DateTime = "2 weeks ago, 15:30",
                Amount = "+R 2,500.00",
                AmountColor = Colors.Green,
                Icon = "💻",
                CategoryColor = "#E3F2FD",
                Reference = "FRL741852963",
                Balance = "R 5,299.91"
            }
        };
    }
}

public class Transaction
{
    public string? Description { get; set; }
    public string? DateTime { get; set; }
    public string? Amount { get; set; }
    public Color? AmountColor { get; set; }
    public string? Icon { get; set; }
    public string? CategoryColor { get; set; }
    public string? Reference { get; set; }
    public string? Balance { get; set; }
}