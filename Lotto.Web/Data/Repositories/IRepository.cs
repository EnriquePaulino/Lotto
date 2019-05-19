namespace Lotto.Web.Data.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IRepository
    {
        void AddBanca(Banca banca);

        bool BancaExists(int id);

        Banca GetBanca(int id);

        IEnumerable<Banca> GetBancas();

        void RemoveBanca(Banca banca);

        Task<bool> SaveAllAsync();

        void UpdateBanca(Banca banca);
    }
}