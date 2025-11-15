using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = InputModule.InputPlayersInTeam();
            string userQuery = InputModule.UserQuery();
            Team? userTeam = SearchModule.SearchTeamByUserQuery(userQuery, teams);
            if (userTeam == null)
            {
                Console.WriteLine("Такой команды нет :(");
            }


        }
    }
}
