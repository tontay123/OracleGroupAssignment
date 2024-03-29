using OracleGroupAssignment.Models;

namespace OracleGroupAssignment.Repository
{
    public interface IInvoiceService
    {
        IEnumerable<Invoice> GetAll();
        Invoice GetById(int id);
        bool Create(Invoice invoice);
        bool Update(Invoice invoice);
        bool Delete(int id);
    }
}
