using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace _100_Thieves.Models
{

    public class CustomerCheckout
    {
   
            [Required(ErrorMessage = "Please enter your name")]
            public string Name  { get; set; }

            [Required(ErrorMessage = "Please enter a Credit Card number")]
            public string CreditCard { get; set; }
            
            [Required(ErrorMessage = "Please select an expiration date")]
            public string ExpirationDate { get; set; }
               
            [Required(ErrorMessage = " Enter a CVC number")]
            public string CVC { get; set; }
            [Required(ErrorMessage = "Enter a State")]
            public string State { get; set; }
            [Required(ErrorMessage = "Enter a City")]
            public string City { get; set; }
            [Required(ErrorMessage = "Enter a ZipCode")]
            public string ZipCode { get; set; }

            [Required(ErrorMessage = "Enter your Address")]
            public string Address { get; set; }

            [Required(ErrorMessage = "Select a delivery type")]
            public bool? DeliveryType { get; set; }
  
    }
}