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
    }
}
