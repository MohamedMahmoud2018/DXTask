using CORE.DTO;
using Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
   public interface IEmployeeService
    {
        ServiceResponse Add(EmployeeInput input);
        ServiceResponse Update(EmployeeInput input);
        ServiceResponse Delete(int Id);
        ServiceResponse GetOne(int Id);
        ServiceResponse GetByJobTitle(string JobTitle);
        ServiceResponse GetAll();
        ServiceResponse GetByName(string Name);
    }
}
