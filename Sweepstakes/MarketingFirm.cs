using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstake(string name)
        {
            Sweepstakes sweepstakes = new Sweepstakes(name);
            _manager.InsertSweepstakes(sweepstakes); 
        }
    }
}
