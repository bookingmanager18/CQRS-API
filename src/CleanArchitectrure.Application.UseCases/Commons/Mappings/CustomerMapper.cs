using AutoMapper;
using GBSPlans.Application.Dto;
using GBSPlans.Application.UseCases.Customers.Commands.CreateCustomerCommand;
using GBSPlans.Application.UseCases.Customers.Commands.UpdateCustomerCommand;
using GBSPlans.Domain.Entities;

namespace GBSPlans.Application.UseCases.Commons.Mappings
{
    public class CustomerMapper: Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
        }
    }
}
