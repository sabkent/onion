using Core.Commands;
namespace Core.Services.Application
{
    public interface IMakePaymentService
    {
        void MakePayment(MakePaymentCommand makePaymentCommand);
    }
}