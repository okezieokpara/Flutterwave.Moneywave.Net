namespace Flutterwave.Moneywave.Net.Requests
{
    public interface IMoneywaveResponse<T> where T : IMoneywaveResponseData
    {
        string Status { get; set; }
        string Message { get; set; }
        T Data { get; set; }
    }
}
