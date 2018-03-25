using System;


namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public interface IMoneyTransferParams
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        decimal Amount { get; set; }
    }
}
