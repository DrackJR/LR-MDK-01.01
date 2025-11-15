using System.Collections.Generic;


namespace work
{
    public class SearchModule
    {

        static public Team? SearchTeamByUserQuery(string userQuery, List<Team> teams)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Name.ToLower() == userQuery.ToLower())
                {
                    return teams[i];
                }
            }
            return null;
        }
    }
}
