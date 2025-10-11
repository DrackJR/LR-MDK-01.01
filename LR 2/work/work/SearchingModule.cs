namespace work
{
    public class SearchingModule
    {
        static public int FindIndexService(string userQuery, string[] services)
        {
            for (int index = 0; index < services.Length; ++index)
            {
                string valueService = services[index].ToLower();
                if (valueService == userQuery.ToLower())
                {
                    return index;
                }
            }

            return -1;
        }


    }
}
