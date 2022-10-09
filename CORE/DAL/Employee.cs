using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Resources.Shared.Enums;

namespace CORE.DAL
{
  public  class Employee
    {
        public Employee()
        {

        }
        public Employee(Employee emp)
        {
            this.Id = emp.Id;
            this.FirstName = emp.FirstName;

            this.LastName = emp.LastName;
            this.DisplayName = emp.DisplayName;
            this.Address = emp.Address;
            this.PhoneNumber = emp.PhoneNumber;
            this.Email = emp.Email;
            this.DateOfBirth = emp.DateOfBirth;
            this.JoningDate = emp.JoningDate;
            this.Salary = emp.Salary;
            this.Gender = emp.Gender;
            this.MaritalStatus = emp.MaritalStatus;
            this.JobTitle = emp.JobTitle;
            this.Manager = emp.Manager;
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName Is Required"),
            StringLength(40,ErrorMessage ="FirstName shouln't exceed 40 letters")]
        public string FirstName { get; set; }
        [Required, StringLength(40)]
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone number is required "),
            StringLength(11, ErrorMessage = "Phone number must be 11 digits")]
        [RegularExpression(@"^[\/+]([0-9]{11})$",
            ErrorMessage = "Phone number must be digits only")]
        public string PhoneNumber { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoningDate { get; set; }
        public float Salary { get; set; }
        public GenderEnum Gender { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }
        public string JobTitle { get; set; }

        public string Manager { get; set; }
    }
}
