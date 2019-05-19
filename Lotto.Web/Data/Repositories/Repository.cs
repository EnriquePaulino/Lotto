namespace Lotto.Web.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Banca> GetBancas()
        {
            return this.context.Lotto_Bancas.OrderBy(p => p.Name);
        }

        public Banca GetBanca(int id)
        {
            return this.context.Lotto_Bancas.Find(id);
        }

        public void AddBanca(Banca banca)
        {
            this.context.Lotto_Bancas.Add(banca);
        }

        public void UpdateBanca(Banca banca)
        {
            this.context.Update(banca);
        }

        public void RemoveBanca(Banca banca)
        {
            this.context.Lotto_Bancas.Remove(banca);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool BancaExists(int id)
        {
            return this.context.Lotto_Bancas.Any(p => p.Id == id);
        }
    }
}
