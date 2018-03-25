using System;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class AccountTransferParams : TransferParamsBase
    {
        protected AccountTransferParams(string firstName, string lastName, decimal amount) : base(firstName, lastName, amount)
        {
        }

        protected AccountTransferParams(string firstName, string lastName, string phoneNumber, decimal amount) : base(firstName, lastName, phoneNumber, amount)
        {
        }

        protected AccountTransferParams(string firstName, string lastName, string email, string phoneNumber, decimal amount) : base(firstName, lastName, email, phoneNumber, amount)
        {
        }
    }
}
