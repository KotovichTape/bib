using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace dk
{
    public class Class1
    {
        public static void ser<T>(T obj)
        {
            string put = "C:\\Users\\Даниил\\Music\\qwe.json";
            String put2 = JsonConvert.SerializeObject(obj);
            File.WriteAllText("C:\\Users\\Даниил\\Music\\qwe.json", put2);
        }
        public static T des<T>(string put)
        {
            string put2 = File.ReadAllText(put);
            T ft52 = JsonConvert.DeserializeObject<T>(put2);
            return ft52;
        }

    }
}
