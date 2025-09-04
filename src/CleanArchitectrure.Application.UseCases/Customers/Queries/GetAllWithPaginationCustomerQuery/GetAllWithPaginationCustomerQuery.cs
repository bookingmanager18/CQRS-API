using GBSPlans.Application.Dto;
using GBSPlans.Application.UseCases.Commons.Bases;
using MediatR;

namespace GBSPlans.Application.UseCases.Customers.Queries.GetAllWithPaginationCustomerQuery
{
    public class GetAllWithPaginationCustomerQuery: IRequest<BaseResponsePagination<IEnumerable<CustomerDto>>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
