using Dapper;
using OracleGroupAssignment.Data;
using OracleGroupAssignment.Models;

namespace OracleGroupAssignment.Repository
{
    public class InvoiceServiceImp : IInvoiceService
    {
        private readonly DapperDbContext _dbContext;

        public InvoiceServiceImp(DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Create(Invoice invoice)
        {
            var sql = "INSERT INTO Invoice (IsHidden, CustomerId, OderDate, VAT, Memo, IsPaid ) VALUES (@IsHidden, @CustomerId, @OderDate, @VAT, @IsPaid )";
            var rowEffect = _dbContext.Connection.Execute(sql, new
            {
               IsHidden = invoice.IsHidden,
               CustomerId = invoice.CustomerId,
               OderDate = invoice.OderDate,
               VAT = invoice.VAT,
               Memo = invoice.Memo,
               IsPaid = invoice.IsPaid

            });
            return rowEffect > 0;
        }

        public bool Delete(int id)
        {
            var sql = "DELETE FROM Invoice WHERE Id=@id ";
            var rowEffect = (_dbContext.Connection.Execute(sql, new { @id = id }));
            return rowEffect > 0;
        }

        public IEnumerable<Invoice> GetAll()
        {
            var sql = "SELECT * FROM Books";
            var invoice = _dbContext.Connection.Query<Invoice>(sql);
            return invoice;
        }

        public Invoice GetById(int id)
        {
            var sql = "SELECT * FROM Invoice WHERE Id=@id ";
            var invoice = _dbContext.Connection.QueryFirstOrDefault<Invoice>(sql, new { @id = id });
            return invoice!;
        }

        public bool Update(Invoice invoice)
        {
            var sql = "UPDATE Invoice SET IsHidden = @IsHidden, CustomerId = @CustomerId, OderDate = @OderDate, VAT = @VAT, Memo = @Memo, IsPaid = @IsPaid WHERE Id = @Id";

            var rowEffect = _dbContext.Connection.Execute(sql, invoice);

            return rowEffect > 0;
        }
    }
}
