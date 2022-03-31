using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models.ViewModel
{
    public class BowlingViewModel
    {
        public IEnumerable<Bowler> Bowlers { get; set; }
        public Team Teams { get; set; }
    }
}

