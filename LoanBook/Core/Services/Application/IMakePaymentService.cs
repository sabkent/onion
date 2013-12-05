namespace Core.Services.Application
{
    public interface IMakePaymentService
    {
        void MakePayment(int loan, decimal amount);
    }
}