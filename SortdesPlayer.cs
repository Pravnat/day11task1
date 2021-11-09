using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IplApp
{
    class SortdesPlayer: IComparer<Players>
    {
        public int Compare(Players x, Players y)
        {
            return x.BattingStyle.CompareTo(y.BattingStyle);
        }
    }
}
