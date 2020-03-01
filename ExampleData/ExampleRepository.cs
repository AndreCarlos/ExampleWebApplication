using DevIO.Business.Models;
using DevIO.Data.Context;
using DevIO.Data.Repository;

namespace ExampleData
{
    public class ExampleRepository<TEntity> : Repository<Fornecedor>
    {
        //protected readonly MeuDbContext Db;
        //protected readonly DbSet<TEntity> DbSet;

        public ExampleRepository(MeuDbContext context) : base(context)
        {
            
        }

        public void Adicionar(TEntity entity)
        {
            //DbSet.Add(entity);
            //SaveChanges();
        }
    }
}
