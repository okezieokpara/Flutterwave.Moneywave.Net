using Flutterwave.Moneywave.Net.Requests;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    internal interface IMoneyTransfer<in T> where T : IMoneyTransferParams
    {
        Task<MoneywaveResponse<MoneyTransferResponseData>> Transfer(T moneyTransferParams);
    }
}
