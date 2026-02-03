using System.Collections.Generic;
using System.IO;

namespace TestFileStorage
{
    public class FileUserStorage : IUserInterface
    {
        public bool Authorize(string log, string pass)
        {
            List<User> identification = Load();

            User user = new User(log, pass);

            return Contains(identification, user);
        }

        public List<User> Load()
        {
            List<User> allUsers = new List<User>();
            string path = @"D:\repo\TestFileStorage\info.txt";
            StreamReader SR = new StreamReader(path);

            string line;

            while ((line = SR.ReadLine()) != null)
            {
                 string[] lines = line.Split('-');
                allUsers.Add(new User(lines[0], lines[1]));
            }

            return allUsers;
        }
        private bool Contains(List<User> users, User user)
        {
            foreach (User u in users)
            {
                if (user.Login == u.Login && u.Password == user.Password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
