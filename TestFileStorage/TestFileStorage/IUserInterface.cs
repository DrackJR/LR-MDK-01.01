using System.Collections.Generic;
namespace TestFileStorage
{
    public interface IUserInterface
    {
        List<User> Load();
        bool Authorize(string log, string pass);
    }
}
