using HR_DB_with_ef_core.Data;
using HR_DB_with_ef_core.Models;
using HR_DB_with_ef_core.Repository;
using static System.Console;

namespace HR_DB_with_ef_core
{
    public class UnitOfWorkExamples
    {
        public static void AddData()
        {
            using (var unitOfWork = new UnitOfWork(new HRContext()) )
            {
                //Create Instance of that class
                Employee employee = new Employee
                {
                    FirstName = "Eaud",
                    LastName = "Carel",
                    Email = "eaduJDR@yahoo.com",
                    PhoneNumber = "8956898989",
                    HireDate = new DateOnly(2020, 12, 22),
                    Salary = "25000",
                    JobId = 2,
                    DepartmentId = 4,
                    ManagerId = 1
                };

                //Use unitOfWork to add
                unitOfWork.Employee.Add(employee);
                //Don't forget save the changes.
                unitOfWork.Complete();
            }
        }

        public static void UpdateData()
        {
            using (var unitOfWork = new UnitOfWork(new HRContext()) )
            {
                //Find that record using filter method (predicate funciton)
                Employee employee = unitOfWork.Employee.GetFirstOrDefault(e => e.EmployeeId == 2);
                
                //access that object property and assign new updated value and call save that changes.
                employee.Salary = "25000";

                unitOfWork.Complete();
            }
        }

        public static void AddEmployeeWithJobAndDepartment()
        {
            using (var unitOfWork = new UnitOfWork(new HRContext()))
            {
                Employee employee = new Employee
                {
                    FirstName = "Carmin",
                    LastName = "Sid",
                    Email = "sid253@jml.com",
                    PhoneNumber = "8956235689",
                    HireDate = new DateOnly(2022, 08, 02),
                    Salary = "18000",
                    Job = new Job
                    {
                        JobTitle = "HR recruiter",
                        MinSalary = "10000",
                        MaxSalary = "25000"
                    },
                    ManagerId = 1,
                    Department = new Department
                    {
                        DepartmentName = "Business Development",
                        LocationId = 2
                    }
                };
                unitOfWork.Employee.Add(employee);
                unitOfWork.Complete();
            }
        }
        
        public static void EmployeeListByYear(int year)
        {
            using (var unitOfWork = new UnitOfWork(new HRContext()))
            {
                //Aleardy implemetnd in Employee Repositary
                var employeeis = unitOfWork.Employee.EmployeeListJoinYear(year);

                WriteLine($"Employe join on year {year}:");
                foreach (var item in employeeis)
                {
                    WriteLine($"Name: {item.FirstName} {item.LastName}, Joinyear: {item.HireDate.Year}");
                }
            }
        }

        public static void Top10HighestSalryEmployees()
        {
            using (var unitOfWork = new UnitOfWork(new HRContext()))
            {
                //Aleardy implemetnd in Employee Repositary
                var employeeis = unitOfWork.Employee.Top10HighestSalryEmployees();
                WriteLine("Top 10 Highest Salry Employe's List:");
                foreach (var item in employeeis)
                {
                    WriteLine($"Name: {item.FirstName} {item.LastName}, Salary: {item.Salary}");
                }
            }
        }

    }
}