using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppDb.DbOperation
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmployeeModel model)
        {
            using (var context = new EmployeeDbEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code,
                    Address = new Address()
                    {
                        Details = model.address.Details,
                        Country = model.address.Country,
                        State = model.address.State,
                    }
                };

                //if(emp.Address != null) 
                //{
                //    emp.Address = new Address()
                //    {
                //        Details = model.Address.Detail,
                //    };
                //}
                context.Employees.Add(emp);
                context.SaveChanges();

                return emp.id;
            }
        }

        public List<EmployeeModel> GetAllEmployees() { 
            using(var context = new EmployeeDbEntities())
            {
                var result = context.Employees.Select(x => new EmployeeModel()
                {
                    id = x.id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Code = x.Code,
                    address = new AddressModel()
                    {
                        id = x.Address.id,
                        Details = x.Address.Details,
                        Country = x.Address.Country,
                        State = x.Address.State
                    }
                }).ToList();

                return result;
            }
        }

        public EmployeeModel GetEmployees(int id)
        {
            using (var context = new EmployeeDbEntities())
            {
                var result = context.Employees
                    .Where(x => x.id == id)
                    .Select(x => new EmployeeModel()
                {
                    id = x.id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Code = x.Code,
                    address = new AddressModel()
                    {
                        id = x.Address.id,
                        Details = x.Address.Details,
                        Country = x.Address.Country,
                        State = x.Address.State
                    }
                }).FirstOrDefault();

                return result;
            }
        }

        public bool UpdateEmployee(int id, EmployeeModel model)
        {
            using (var context = new EmployeeDbEntities())
            {
                var employee = context.Employees.FirstOrDefault(x => x.id == id);
                if (employee!=null)
                { 
                    employee.FirstName = model.FirstName;
                    employee.LastName = model.LastName;
                    employee.Email = model.Email;
                }

                return true;
            }
        }

    }
}
