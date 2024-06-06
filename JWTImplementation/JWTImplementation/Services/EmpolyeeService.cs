using JWTImplementation.Context;
using JWTImplementation.Interfaces;
using JWTImplementation.Models;

namespace JWTImplementation.Services
{
    public class EmpolyeeService : IEmployeeService
    {
        private readonly JwtContext _jwtContext;

        public EmpolyeeService(JwtContext jwtContext)
        {
            _jwtContext = jwtContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            var emp = _jwtContext.Employees.Add(employee);
            _jwtContext.SaveChanges();
            return emp.Entity;
        }

        public bool DeleteEmployee(int id)
        {
            try 
            {
                var emp = _jwtContext.Employees.Where(x => x.Id == id);
                if (emp == null)
                {
                    throw new Exception("User not found please provide valid id");
                }
                else {
                    _jwtContext.Employees.Remove((Employee)emp);
                    _jwtContext.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<Employee> GetEmployeeDetails()
        {
            var emp = _jwtContext.Employees.ToList();
            return emp;
        }

        public Employee GetEmployeeDetails(int id)
        {
            var emp = _jwtContext.Employees.Where(x => x.Id == id);
            return (Employee)emp;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var update = _jwtContext.Employees.Update(employee);
            _jwtContext.SaveChanges();
            return update.Entity;
        }
    }
}
