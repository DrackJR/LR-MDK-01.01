using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public class MemoryUsersModel : IUsersModel
    {
        private List<User> allUsers_ = new List<User>();

        public MemoryUsersModel()
        {
            allUsers_.Add(new User("Маркот", "111", "Владислав"));
            allUsers_.Add(new User("Горб", "123", "Никита"));
            allUsers_.Add(new User("Марму", "321", "Артём"));
            allUsers_.Add(new User("Ксеро", "231", "Александр"));
        }

        public bool AddUsers(User u)
        {
            foreach (User user in allUsers_)
            {
                if (user.Login == u.Login)
                {
                    return false;
                }
            }
            allUsers_.Add(u);
            return true;
        }
        

        public List<User> Load()
        {
            return allUsers_;
        }

        public bool Register(User user)
        {
            int countListUser = allUsers_.Count;
            allUsers_.Add(user);
            if(allUsers_.Count > countListUser)
            {
                return true;
            }
            return false;
        }
        public void RemoveUsers(List<User> users)
        {
            foreach(User u in users)
            {
                int targetIndex = allUsers_.FindIndex(local => local.Login == u.Login);
                if (targetIndex >= 0)
                {
                    allUsers_.RemoveAt(targetIndex);
                }
            }
        }
    }
}
