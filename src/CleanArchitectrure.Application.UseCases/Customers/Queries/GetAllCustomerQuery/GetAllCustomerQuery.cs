using GBSPlans.Application.Dto;
using GBSPlans.Application.UseCases.Commons.Bases;
using MediatR;

namespace GBSPlans.Application.UseCases.Customers.Queries.GetAllCustomerQuery
{
    public class GetAllCustomerQuery: IRequest<BaseResponse<IEnumerable<CustomerDto>>>
    {
    }
}
