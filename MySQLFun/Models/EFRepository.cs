using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public class EFRepository : IRepository
    {
        private BowlersDbContext context { get; set; }
        public EFRepository (BowlersDbContext temp)
        {
            context = temp;
        }
        public IQueryable<Bowler> Bowlers => context.Bowlers;

    }
}
