using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcService.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;
        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomeModel> GetCustomerInfo(CustomerLockupModel request, ServerCallContext context)
        {
            CustomeModel customeModel = new CustomeModel();

            if (request.UserId == 1)
            {
                customeModel.FirstName = "Nik";
                customeModel.LastName = "Jon";
                customeModel.Age = 35;
            }
            if (request.UserId == 2)
            {
                customeModel.FirstName = "Jack";
                customeModel.LastName = "Marc";
                customeModel.Age = 34;
            }

            return Task.FromResult(customeModel);
        }
  
   }
}
