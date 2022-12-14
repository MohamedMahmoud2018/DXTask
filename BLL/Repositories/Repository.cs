using CORE;
using CORE.DAL;
using CORE.Data;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repository:IRepository
    {
        List<Employee> query = EmployeeData.EmployeeList;
        public Repository()
        {
        }

        public IEnumerable<Employee> Get(Func<Employee, bool> filter = null, Func<IEnumerable<Employee>, IOrderedQueryable<Employee>> orderBy = null)
        {


            IEnumerable<Employee> Result = query;

            if (filter != null)
                Result = query.Where(filter);

            if (orderBy != null)
                Result = orderBy(query);

            return Result;
        }



        public virtual IEnumerable<Employee> Query(Func<Employee, bool> filter = null, Func<IEnumerable<Employee>, IOrderedQueryable<Employee>> orderBy = null)
        {
            IEnumerable<Employee> Result=query;
            if (filter != null)
                Result = query.Where(filter);

            if (orderBy != null)
                Result = orderBy(query);

            return Result;
        }



        public virtual Employee GetById(int id)
        {
            var entity = query.FirstOrDefault(emp => emp.Id == id); ;
            
            return entity;
        }

        public virtual IEnumerable<Employee> GetAllById(int id)
        {
            var entity = query.Where(emp => emp.Id == id); ;

            return entity;
        }

        public virtual Employee GetFirstOrDefault(Func<Employee, bool> filter = null)
        {
            

            return query.FirstOrDefault(filter);
        }

        Employee IRepository.GetLastOrDefault(Func<Employee, bool> filter)
        {
            

            return query.LastOrDefault(filter);
        }

        public virtual void Insert(Employee entity)
        {
            query.Add(entity);
        }
        public virtual void Insert(ICollection<Employee> entities)
        {
            query.AddRange(entities);
        }

        public virtual void Update(Employee entity)
        {
           int index= query.IndexOf(query.FirstOrDefault(X => X.Id == entity.Id));
            query[index] = new Employee(entity);   
        }





        public virtual void Delete(int id)
        {
            
            query.Remove(query.FirstOrDefault(X=>X.Id==id));
        }
        public virtual void Delete(Employee entityToDelete)
        {
            query.Remove(query.FirstOrDefault(X => X.Id == entityToDelete.Id));
        }


        
    }
}
