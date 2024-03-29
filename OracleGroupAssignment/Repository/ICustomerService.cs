using OracleGroupAssignment.Models;

namespace OracleGroupAssignment.Repository
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        bool Create(Customer customer);
        bool Update(Customer customer);
        bool Delete(int CustomerId);
    }
}
