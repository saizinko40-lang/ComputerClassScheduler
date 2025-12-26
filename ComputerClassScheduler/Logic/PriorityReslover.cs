using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerClassScheduler.Logic
{
    public class PriorityResolver
    {
        public Request Resolve(Request a, Request b)
        {
            if (a.GroupPriority >= b.GroupPriority)
                return a;

            return b;
        }
    }
}
