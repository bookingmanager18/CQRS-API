using GBSPlans.Application.Dto;
using GBSPlans.Application.UseCases.Commons.Bases;
using MediatR;

namespace GBSPlans.Application.UseCases.Customers.Queries.GetByIdCustomerQuery
{
    public class GetByIdCustomerQuery: IRequest<BaseResponse<CustomerDto>>
    {
        public string? CustomerId { get; set; }
    }
}
