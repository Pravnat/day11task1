using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IplApp
{
    class PlayerBO
    {
        public Players[] SearchBYTeamName(Players[] playerList)
        {
            
            SortbyTeamName ascSotbyTeam = new SortbyTeamName();
            Array.Sort(playerList, ascSotbyTeam);
            
            return playerList;
        }
        public Players[] SearchBYBattingStyle(Players[] playerList)
        {
            Players[] results = null;
            SortDesPlayer obj_sort = new SortDesPlayer();
            Array.Sort(playerList, obj_sort);
            Array.Reverse(playerList);
            results = playerList;
            return results;
        }
    }
}
