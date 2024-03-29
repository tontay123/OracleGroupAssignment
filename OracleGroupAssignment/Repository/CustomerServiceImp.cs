using OracleGroupAssignment.Data;
using OracleGroupAssignment.Models;
using Dapper;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace OracleGroupAssignment.Repository
{
    public class CustomerServiceImp : ICustomerService
    {
        private readonly DapperDbContext _dbContext;

        public CustomerServiceImp(DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Create(Customer customer)
        {
            var sql = "INSERT INTO Customer (IsHidden, IsDefault, CustomerName, CompanyName, Phone, Email, Address) VALUES (@IsHidden, @IsDefault, @CustomerName, @CompanyName, @Phone, @Email, @Address)";
            var rowEffect = _dbContext.Connection.Execute(sql, new
            {
               IsHidden = customer.IsHidden,
               IsDefault = customer.IsDefault,
               CustomerName = customer.CustomerName,
               CompanyName = customer.CompanyName,
               Phone = customer.Phone,
               Email = customer.Email,
               Address = customer.Address,

            });
            return rowEffect > 0;
        }

        public bool Delete(int customerid)
        {
            var sql = "DELETE FROM Customer WHERE CustomerId=@customerid ";
            var rowEffect = (_dbContext.Connection.Execute(sql, new { CustomerId = @customerid }));
            return rowEffect > 0;
        }

        public IEnumerable<Customer> GetAll()
        {
            var sql = "SELECT * FROM Customer";
            var Customer = _dbContext.Connection.Query<Customer>(sql);
            return Customer;
        }

        public Customer GetById(int id)
        {
            var sql = "SELECT * FROM Customer WHERE CustomerId=@customerid ";
            var Customer = _dbContext.Connection.QueryFirstOrDefault<Customer>(sql, new { @Customerid = id });
            return Customer!;
        }

        public bool Update(Customer customer)
        {
            var sql = "UPDATE Customer SET IsHidden = @IsHidden, IsDefault = @IsDefault, CustomerName = @CustomerName, CompanyName = @CompanyName, Phone = @Phone, Email = @Email, Address = @Address WHERE CustomerId=@customerid";

            var rowEffect = _dbContext.Connection.Execute(sql, customer);

            return rowEffect > 0;
        }
    }
}
