
using System.Text;
using System.Text.Json;

namespace apiangas
{
    public class ResponseTest
    {
        public Dictionary<string, string> arg { get; set; }
        public string data { get; set; }

        public Dictionary<string, string> header { get; set; }

    
    }
    public class Pokemon
    {
        public int baseExperience { get; set; }
        public class Forms
        {
            string name { get; set; }
            string url { get; set; }
        }
        public class Abilities
        {
            public class Ability
            {
                public string name { get; set; }
                public string url { get; set; }

            }



            public Ability ability { get; set; }
            public bool is_hidden { get; set; }
            public int slot { get; set; }
        }
        public Abilities[] abilities { get; set; }
        public Forms[] forms { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent("{}", Encoding.UTF8);
            try
            {
                
                var response = client.PostAsync("https://httpbin.org/post?key=value", content).GetAwaiter().GetResult();             
                string content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                //var response = client.GetAsync("https://pokeapi.co/api/v2/pokemon/charmander").GetAwaiter().GetResult();
                //string content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                //Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}