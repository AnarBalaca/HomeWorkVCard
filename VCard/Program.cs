using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json;
using VCard.Models;
public class Program
{
 
    public static void Main()
    {

        using (var vCard = new HttpClient())
        {
            var endpoint = new Uri("https://randomuser.me/api?results=");
            

            var result = vCard.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;

            //var jsonseria = JsonSerializer.Deserialize<VCards>(json);




            //foreach (PropertyInfo property in jsonseria.GetType().GetProperties())
            //{
            //    Console.WriteLine(property.GetValue(jsonseria , null));
            //}


            List<VCards> vCards = JsonConvert.DeserializeObject<List<VCards>>(json);

            Console.WriteLine(vCards.ToString());


        }

    }
}