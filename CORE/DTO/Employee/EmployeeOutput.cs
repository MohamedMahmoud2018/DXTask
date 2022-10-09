using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Resources.Shared.Enums;

namespace CORE.DTO
{
   public class EmployeeOutput
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoningDate { get; set; }
        public float Salary { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string JobTitle { get; set; }

        public string Manager { get; set; }
    }
}
