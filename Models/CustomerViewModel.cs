using System.Collections.Generic;

namespace AspNetMvcAssignment.Models
{
    public class CustomerViewModel
    {
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public List<CustomerOrder> Orders { get; set; } = new List<CustomerOrder>();
    }
}
