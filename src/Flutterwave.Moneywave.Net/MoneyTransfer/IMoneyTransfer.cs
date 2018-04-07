using Flutterwave.Moneywave.Net.Requests;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    internal interface IMoneyTransfer<in T1, T2> where T1 : IMoneyTransferParams where T2 : IMoneywaveResponseData
    {
        Task<MoneywaveResponse<T2>> TransferAsync(T1 moneyTransferParams);
    }
}
