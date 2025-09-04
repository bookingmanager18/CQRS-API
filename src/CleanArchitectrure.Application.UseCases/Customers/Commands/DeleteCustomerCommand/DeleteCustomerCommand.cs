using GBSPlans.Application.UseCases.Commons.Bases;
using MediatR;

namespace GBSPlans.Application.UseCases.Customers.Commands.DeleteCustomerCommand
{
    public class DeleteCustomerCommand: IRequest<BaseResponse<bool>>
    {
        public string CustomerId { get; set; }
    }
}
