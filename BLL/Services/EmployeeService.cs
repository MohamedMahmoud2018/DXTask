using AutoMapper;
using CORE.DAL;
using CORE.Data;
using CORE.DTO;
using Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Resources.Shared.Enums;

namespace BLL.Services
{
   public class EmployeeService : IEmployeeService
    {
        readonly IRepository repo;
        readonly IMapper mapper;
        public EmployeeService(IRepository _repo, IMapper _mapper)
        {
            repo = _repo;
            mapper = _mapper;
        }
        public ServiceResponse Add(EmployeeInput input)
        {
            repo.Insert(mapper.Map<Employee>(input));
           
            try
            {
                return new ServiceResponse
                {
                    IsError = false,
                    Message = "Added Successfuly",
                    Data = mapper.Map<List<EmployeeOutput>>(EmployeeData.EmployeeList),
                    Code = 200
                };
            }
            catch (Exception ex)
            {

                return new ServiceResponse
                {
                    IsError = true,
                    Message = ex.Message,
                    Code = 500
                };
            }
        }
        public ServiceResponse Update(EmployeeInput input)
        {
            repo.Update(mapper.Map<Employee>(input));

            try
            {
                return new ServiceResponse
                {
                    IsError = false,
                    Message = "Updated Successfuly",
                    Data = mapper.Map<List<EmployeeOutput>>(EmployeeData.EmployeeList),
                    Code = 200
                };
            }
            catch (Exception ex)
            {

                return new ServiceResponse
                {
                    IsError = true,
                    Message = ex.Message,
                    Code = 500
                };
            }
        }
        public ServiceResponse Delete(int Id)
        {
            try
            {
                repo.Delete(Id);
                return new ServiceResponse
                {
                    IsError = false,
                    Message = "Deleted Successfuly",
                    Code = 200,
                    Data =mapper.Map<List<EmployeeOutput>>( EmployeeData.EmployeeList)
                };
            }
            catch (Exception ex)
            {

                return new ServiceResponse
                {
                    IsError = true,
                    Message = ex.Message,
                    Code = 500
                };
            }
        }

        public ServiceResponse GetAll()
        {
            try
            {
               var allEmp=mapper.Map<List<EmployeeOutput>>( repo.Get());
                if (allEmp!=null)
                {
                    return new ServiceResponse
                    {
                        Code = 200,
                        Data=allEmp,
                        IsError=false,
                        Message="All data"
                    };
                }
                else
                      return new ServiceResponse
                    {
                        Code = 404,
                        Data = null,
                        IsError = true,
                        Message = "No Data"
                    };
            }
            catch (Exception ex)
            {

                return new ServiceResponse
                {
                    IsError = true,
                    Message = ex.Message,
                    Code = 500
                };
            }
           
        }

        public ServiceResponse GetOne(int Id)
        {
            try
            {
                //var instEmp = repo.GetById(Id);
                var Emp = mapper.Map<EmployeeOutput>(repo.GetById(Id));
                
                if (Emp != null)
                {
                    //Emp.Gender = ((GenderEnum)instEmp.Gender).ToString();
                    //Emp.MaritalStatus = ((MaritalStatusEnum)instEmp.MaritalStatus).ToString();
                    return new ServiceResponse
                    {
                        Code = 200,
                        Data = Emp,
                        IsError = false,
                        Message = " data"
                    };
                }
                else
                    return new ServiceResponse
                    {
                        Code = 404,
                        Data = null,
                        IsError = true,
                        Message = "No Data"
                    };
            }
            catch (Exception ex)
            {

                return new ServiceResponse
                {
                    IsError = true,
                    Message = ex.Message,
                    Code = 500
                };
            }
        }

        
        public ServiceResponse GetByName( string Name)
        {
            try
            {
                var allEmp = mapper.Map<List<EmployeeOutput>>(repo.Get(X=>X.FirstName.Contains(Name)));
                if (allEmp != null)
                {
                    return new ServiceResponse
                    {
                        Code = 200,
                        Data = allEmp,
                        IsError = false,
                        Message = "All data"
                    };
                }
                else
                    return new ServiceResponse
                    {
                        Code = 404,
                        Data = null,
                        IsError = true,
                        Message = "No Data"
                    };
            }
            catch (Exception ex)
            {

                return new ServiceResponse
                {
                    IsError = true,
                    Message = ex.Message,
                    Code = 500
                };
            }
        }

        public ServiceResponse GetByJobTitle(string JobTitle)
        {
            try
            {
                var allEmp = mapper.Map<List<EmployeeOutput>>(repo.Get(X => X.JobTitle.Contains( JobTitle)));
                if (allEmp != null)
                {
                    return new ServiceResponse
                    {
                        Code = 200,
                        Data = allEmp,
                        IsError = false,
                        Message = "All data"
                    };
                }
                else
                    return new ServiceResponse
                    {
                        Code = 404,
                        Data = null,
                        IsError = true,
                        Message = "No Data"
                    };
            }
            catch (Exception ex)
            {

                return new ServiceResponse
                {
                    IsError = true,
                    Message = ex.Message,
                    Code = 500
                };
            }
        }
    }
}
