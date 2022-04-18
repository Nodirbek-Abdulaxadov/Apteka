using Apteka.Data;
using Apteka.Data.Models;
using Apteka.Service.Interfaces;

namespace Apteka.Service.Repository
{
    public class DrugRepository : IDrugInterface
    {
        private readonly AppDbContext _dbContext;

        public DrugRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Drug> Add(Drug drug)
        {
            _dbContext.Drugs.Add(drug);
            _dbContext.SaveChanges();
            return Task.FromResult(drug);
        }

        public Task Delete(Guid id)
        {
            var drug = _dbContext.Drugs.FirstOrDefault(d => d.Id == id);
            _dbContext.Drugs.Remove(drug);
            return Task.CompletedTask;
        }

        public Task<List<Drug>> GetAll() =>
            Task.FromResult(_dbContext.Drugs.ToList());

        public Task<Drug> GetById(Guid id) =>
            Task.FromResult(_dbContext.Drugs.FirstOrDefault(d => d.Id == id));

        public Task<Drug> Update(Drug drug)
        {
            _dbContext.Drugs.Update(drug);
            _dbContext.SaveChanges();
            return Task.FromResult(drug);
        }
    }
}
