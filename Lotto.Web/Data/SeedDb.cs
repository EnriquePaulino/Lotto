namespace Lotto.Web.Data
{
    using Lotto.Web.Data.Entities;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Lotto_Bancas.Any())
            {
                this.AddBanca("Paulino");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddBanca(string name)
        {
            this.context.Lotto_Bancas.Add(new Banca
            {
                Name = name,
                Propietario = 1,
                Localidad = 1,
                IsAvailabe = true
            });
        }
    }
}
