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
// interview question and practice c#
1)what is typecasting.
    thpe casting is process to converting one data type value to other data type value.
    example convert string to int etc.
2) what is boxing and unboxing.
    it is procees of converting Valuetype datatype to reference type data type. 
    not- all data type except string is colled valuetype datatype. string is refrence ype data type.
    
    so--> converting any data type to string is colled boxing. unboxing string to any data type.
    boxing example.
    int i = 10;
string s = i.Tostring();
   unboxing example
   string name ="suraj";
name=int.parse();
dataype.parse();
exaple. int.parse();, byte.parse(); ,double.parse();
    
    
