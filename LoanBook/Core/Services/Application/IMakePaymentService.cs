using Core.Commands;
namespace Core.Services.Application
{
    public interface IMakePaymentService
    {
        MakePaymentResult MakePayment(MakePaymentCommand makePaymentCommand);
    }
}