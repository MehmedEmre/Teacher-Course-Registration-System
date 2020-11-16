using FirstEntityFrameworkCore.DAC.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.DAC.EntityFrameworkCore.Repository
{
    public class RepositoryBase
    {

        protected static DataBaseContext db;
        private static object _locksync = new object();

        public RepositoryBase()
        {
            CreateContext();
        }

        private static void CreateContext()
        {

            if(db == null)
            {
                lock (_locksync)
                {
                    db = new DataBaseContext();
                }
                
            }

  

        }


    }
}
