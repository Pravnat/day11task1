using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IplApp
{
    class SortbyTeamName: IComparer<Players>
    {
        public int Compare(Players x, Players y)
        {
            return x.TeamName.CompareTo(y.TeamName);
        }
    }
}
