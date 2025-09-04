using AutoMapper;
using GBSPlans.Application.Dto;
using GBSPlans.Application.Interface.Persistence;
using GBSPlans.Application.UseCases.Commons.Bases;
using MediatR;

namespace GBSPlans.Application.UseCases.Customers.Queries.GetByIdCustomerQuery
{
    public class GetByIdCustomerHandler : IRequestHandler<GetByIdCustomerQuery, BaseResponse<CustomerDto>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdCustomerHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<BaseResponse<CustomerDto>> Handle(GetByIdCustomerQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<CustomerDto>();
            try
            {
                var customer = await _unitOfWork.Customers.GetAsync(request.CustomerId);
                if(customer is not null)
                {
                    response.Data = _mapper.Map<CustomerDto>(customer);
                    response.succcess = true;
                    response.Message = "Query succeed!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
