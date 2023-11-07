using Common;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public abstract class BaseSO
    {
        protected IDbRepository<IEntity> repository;
   
        public BaseSO()
        {
            repository = new GenericDbRepository();
        }

        public void Execute()
        {
            try
            {
                ExecuteOperation();
                repository.Commit();
                Console.WriteLine("Uspesno");

            }
            catch (Exception)
            {
                Console.WriteLine("Neuspesno");
                repository.RollBack();
                throw;
            }
            finally
            {
                repository.Close();
            }
        }
            protected abstract void ExecuteOperation(); 
    }
}
