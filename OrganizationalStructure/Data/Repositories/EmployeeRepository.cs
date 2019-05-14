using OrganizationalStructure.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Data.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployeesOfDepartment(int departmentId)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"SELECT ID, FirstName, LastName, Title, Phone, Email, DepartmentID 
                                        FROM Employees WHERE DepartmentID = @departmentId";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@departmentId", SqlDbType.Int).Value = departmentId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.ID = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                            employee.Phone = reader.GetString(4);
                            employee.Email = reader.GetString(5);
                            employee.DepartmentID = reader.GetInt32(6);
                            employees.Add(employee);
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                }
                return employees;
            }
        }

        public List<Employee> GetEmployeesOfCompany(string companyCode)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"SELECT E.ID, FirstName, LastName, Title, Phone, Email, DepartmentID 
                                        FROM Employees AS E
                                        JOIN Sections AS S ON E.DepartmentID = S.ID 
                                        WHERE S.Code LIKE '' + @CompanyCode + '%'";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@companyCode", SqlDbType.NVarChar).Value = companyCode;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.ID = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                            employee.Phone = reader.GetString(4);
                            employee.Email = reader.GetString(5);
                            employee.DepartmentID = reader.GetInt32(6);
                            employees.Add(employee);
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                }
                return employees;
            }
        }
    }
}
