using Microsoft.AspNetCore.Mvc;
using demo_api.Models;
using System.Text.Json;

namespace demo_api.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<EmployeeModels> ReadDataJson()
        {
            List<EmployeeModels> data = new List<EmployeeModels>();

            using (StreamReader r = new StreamReader("data.json"))
            {
                string json = r.ReadToEnd();
                data = JsonSerializer.Deserialize<List<EmployeeModels>>(json);
            }
            return data;
        }

        //public List<EmployeeModels> ReadDataJson()
        //{
        //    List<EmployeeModels> data = new List<EmployeeModels>();

        //    using (StreamReader r = new StreamReader("data.json"))
        //    {
        //        string json = r.ReadToEnd();
        //        data = JsonSerializer.Deserialize<List<EmployeeModels>>(json);
        //    }

        //    return data.ToList();
        //}

        public void WriteJsonToFile(List<EmployeeModels> data)
        {
            string jsonConvert = JsonSerializer.Serialize(data);
            System.IO.File.WriteAllText(@"C:\Users\kittayod.pet\Desktop\WFH\demo_api\demo_api\data.json", jsonConvert);
        }
    }
}
