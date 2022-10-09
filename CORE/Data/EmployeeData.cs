using CORE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Resources.Shared.Enums;

namespace CORE.Data
{
   public class EmployeeData
    {
        public static List<Employee> EmployeeList =
            new List<Employee>()
            {
               new Employee{
                    Id=1,
                    FirstName="Mohamed",
                    LastName="Mahmoud",
                    DisplayName="MohamedMahmoud",
                    Address="Cairo",
                    PhoneNumber="01229833229",
                    Email="Mohamedfci2018@gmail.com",
                    DateOfBirth=new DateTime(1996/09/01),
                    JoningDate=new DateTime(2020/09/01),
                    Salary=10000f,
                    Gender=GenderEnum.Male,
                    MaritalStatus=MaritalStatusEnum.Single,
                    JobTitle=".net developer",
                    Manager="Mohamed"
                },
               new Employee{
                    Id=2,
                    FirstName="Ali",
                    LastName="Ahmed",
                    DisplayName="AliAhmed",
                    Address="Cairo",
                    PhoneNumber="01229833229",
                    Email="Mohamedfci2018@gmail.com",
                    DateOfBirth=new DateTime(1996/09/01),
                    JoningDate=new DateTime(2020/09/01),
                    Salary=10000f,
                    Gender=GenderEnum.Male,
                    MaritalStatus=MaritalStatusEnum.Single,
                    JobTitle=".net developer",
                    Manager="Mohamed"
                }
            };
    }
}
