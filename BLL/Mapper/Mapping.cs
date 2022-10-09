using AutoMapper;
using CORE.DAL;
using CORE.DTO;

namespace BLL
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Employee, EmployeeInput>().ReverseMap();
            CreateMap<Employee, EmployeeOutput>();

            

        }
    }
}
