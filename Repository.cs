using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace _100_Thieves.Models
{
    public class Repository
    {
        private static List<CustomerCheckout> responses = new List<CustomerCheckout>();
        public static IEnumerable<CustomerCheckout> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(CustomerCheckout response)
        {
            responses.Add(response);
        }
    }
}
