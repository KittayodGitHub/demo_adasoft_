using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using demo_api.Models;
using System.Text.Json;

namespace demo_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EmployeeController : ControllerBase
    {
        ActionController action = new ActionController();

        [HttpGet]
        public IEnumerable<EmployeeModels> Get()
        {
            return action.ReadDataJson();
        }

        [HttpGet("{id}")]
        public EmployeeModels Get(int id)
        {
            List<EmployeeModels> data = action.ReadDataJson().ToList();

            int idx = data.FindIndex(n => n.Id == id);

            return data[idx];
        }

        [HttpPost]
        public void Post([FromBody] EmployeeModels value)
        {
            List<EmployeeModels> data = action.ReadDataJson().ToList();
            data.Add(new EmployeeModels
            {
                Id = data.Count + 1,
                Name = value.Name,
                Age = value.Age,
                Gender = value.Gender
            });
            action.WriteJsonToFile(data);
        }

        [HttpPut]
        public void Put([FromBody] EmployeeModels value)
        {
            List<EmployeeModels> data = action.ReadDataJson().ToList();

            int idx = data.FindIndex(a => a.Id == value.Id);

            data[idx].Name = value.Name;
            data[idx].Age = value.Age;
            data[idx].Gender = value.Gender;

            action.WriteJsonToFile(data);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            List<EmployeeModels> data = action.ReadDataJson().ToList();

            int idx = data.FindIndex(a => a.Id == id);
            data.RemoveAt(idx);

            action.WriteJsonToFile(data);
        }
    }
}
