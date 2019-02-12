using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TeaApp.Model;



namespace TeaApp.Api
{
    public class CarApi
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<CarModel>> action)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://api.myjson.com/bins/jly7p");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<CarModel>>(await response.Content.ReadAsStringAsync());
                action(list);
            }

        }
    }
}
