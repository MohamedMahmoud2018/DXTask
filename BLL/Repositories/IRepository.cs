using CORE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BLL
{
    public interface IRepository
    {
        /// <summary>
        /// Get all entities from db
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        IEnumerable<Employee> Get(Func<Employee, bool> filter = null, Func<IEnumerable<Employee>, IOrderedQueryable<Employee>> orderBy = null);

        /// <summary>
        /// Get query for entity
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IEnumerable<Employee> Query(Func<Employee, bool> filter = null, Func<IEnumerable<Employee>, IOrderedQueryable<Employee>> orderBy = null);

        
       

        /// <summary>
        /// Get single entity by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee GetById(int id);
        /// <summary>
        /// Get all entities by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<Employee> GetAllById(int id);

        /// <summary>
        /// Get first or default entity by filter
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Employee GetFirstOrDefault(Func<Employee, bool> filter = null);


        /// <summary>
        /// Get Last or default entity by filter
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Employee GetLastOrDefault(Func<Employee, bool> filter = null);

        /// <summary>
        /// Insert entity to db
        /// </summary>
        /// <param name="entity"></param>
        void Insert(Employee entity);
        /// <summary>
        /// Insert entities to db
        /// </summary>
        /// <param name="entities"></param>
        void Insert(ICollection<Employee> entities);

        /// <summary>
        /// Update entity in db
        /// </summary>
        /// <param name="entity"></param>
        void Update(Employee entity);

        

        /// <summary>
        /// Delete entity from db by primary key
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Delete entity from db
        /// </summary>
        /// <param name="entityToDelete"></param>
        void Delete(Employee entityToDelete);

        

        
    }
}
