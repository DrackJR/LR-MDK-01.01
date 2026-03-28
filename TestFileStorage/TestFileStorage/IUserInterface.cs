using System.Collections.Generic;
namespace TestFileStorage
{
    public interface IUserInterface
    {
        List<User> Load();
        bool CheckUser(string log);
        bool Registration(User u);
    }
}