using System;
using System.Collections.Generic;

namespace work
{
    public class InputModule
    {
        static public List<Team> InputPlayersInTeam()
        {
            List<Team> teams = new List<Team>();



            teams.Add(new Team {Name = "Гриззли",players = new List<Player> { new Player { Name = "Владислав", Goals = 4 },
                                                                              new Player { Name = "Никита", Goals = 2 },
                                                                              new Player { Name = "Артём", Goals = 1 },
                                                                              new Player { Name = "Александр", Goals = 5 }} , Scores = 22});


            teams.Add(new Team {Name = "Орлы", players = new List<Player> { new Player { Name = "Всеволод", Goals = 2 },
                                                                            new Player { Name = "Фёдор", Goals = 3 },
                                                                            new Player { Name = "Тимофей", Goals = 4 },
                                                                            new Player { Name = "Алексей", Goals = 5 }} , Scores = 17});

            teams.Add(new Team{ Name = "Обманщики", players = new List<Player> { new Player { Name = "Михаил", Goals = 6 },
                                                                                 new Player { Name = "Олег", Goals = 1 },
                                                                                 new Player { Name = "Матвей", Goals = 4 },
                                                                                 new Player { Name = "Семён", Goals = 3 }}, Scores = 18});

            teams.Add(new Team { Name = "Матрикс", players = new List<Player> { new Player { Name = "Григорий", Goals = 3 },
                                                                                new Player { Name = "Иван", Goals = 2 },
                                                                                new Player { Name = "Роман", Goals = 5 },
                                                                                new Player { Name = "Дмитрий", Goals = 1 }},Scores = 20});



            teams.Add(new Team
            { Name = "Дикари", players = new List<Player> { new Player { Name = "Даниил", Goals = 5 },
                                                            new Player { Name = "Илья", Goals = 4 },
                                                            new Player { Name = "Степан", Goals = 2 },
                                                            new Player { Name = "Лука", Goals = 1 }}, Scores = 15});

            teams.Add(new Team
            { Name = "Вестерны", players = new List<Player> { new Player { Name = "Тимур", Goals = 4 },
                                                              new Player { Name = "Лев", Goals = 1 },
                                                              new Player { Name = "Константин", Goals = 2 },
                                                              new Player { Name = "Антон", Goals = 31 } }, Scores = 11});


            return teams;
        }

        static public string UserQuery()
        {
            Console.WriteLine("Какую команду хотите посмотреть (Гриззли, Орлы, Обманщики, Матрикс, Дикари, Вестерны): ");
            return Console.ReadLine();
        }
    }
}
