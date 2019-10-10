using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Context
{
    public class WetherDBInitializator : CreateDatabaseIfNotExists<WetherDbContext>
    {
        protected override void Seed(WetherDbContext context)
        {
            base.Seed(context);
        }
    }    
}
