using MoizTravel.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class ImformationCustomer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public int Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyTel { get; set; }
        public Status Status { get; set; }

    }
}
