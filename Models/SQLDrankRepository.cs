using System.Collections.Generic;

namespace DrankAPI.Models{
    public class SQLDrankRepository : IDrankRepository
    {
        private readonly AppDBContext context;
        public SQLDrankRepository(AppDBContext context)
        {
        this.context = context;
        }

        public Drank Add(Drank drank)
        {
            context.Dranken.Add(drank);
            context.SaveChanges();
            return drank;
        }

        public IEnumerable<Drank> GetAllDrank()
        {
            return context.Dranken;

        }
        public Drank GetDrank(int Id)
        {
            return context.Dranken.Find(Id);
        }

        public Drank Remove(Drank model)
        {
            throw new System.NotImplementedException();
        }

        public Drank Update(Drank drankChanges)
        {
            var drank = context.Dranken.Attach(drankChanges);
            drank.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return drankChanges;
        }
    }

 
}