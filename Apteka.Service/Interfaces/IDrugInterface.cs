using Apteka.Data.Models;
namespace Apteka.Service.Interfaces
{
    public interface IDrugInterface
    {
        Task<List<Drug>> GetAll();
        Task<Drug> GetById(Guid id);
        Task<Drug> Add(Drug drug);
        Task<Drug> Update(Drug drug);
        Task Delete(Guid id);
    }
}
