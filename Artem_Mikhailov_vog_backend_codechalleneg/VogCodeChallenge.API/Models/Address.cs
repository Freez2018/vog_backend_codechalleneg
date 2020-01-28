using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Address
    {
        public string Id { get; set; }
        public string AddressLine_1 { get; set; }
        public AddressType Type { get; set; }
    }

    public enum AddressType
    {
        Mailing,
        Billing
    }

}
