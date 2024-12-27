using System.Collections.Generic;

namespace AspNetMvcAssignment.Models
{
    public class CustomerViewModel
    {
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public List<CustomerOrder> Orders { get; set; } = new List<CustomerOrder>();
    }
}
