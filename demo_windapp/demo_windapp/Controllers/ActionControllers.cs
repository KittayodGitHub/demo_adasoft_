using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using demo_windapp.Models;
using System.Text.Json;
using System.Net.Http.Json;

namespace demo_windapp.Controllers
{
    internal class ActionControllers
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = new HttpResponseMessage();

        public ActionControllers()
        {
            client.BaseAddress = new Uri("http://localhost:5011");
        }

        public bool IsNumeric(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            return value.All(char.IsNumber);
        }

        public List<EmployeeModels> SearchAllData()
        {
            List<EmployeeModels> data = new List<EmployeeModels>();
            try
            {
                response = client.GetAsync("api/Employee").Result;
                string jsonStr = response.Content.ReadAsStringAsync().Result;

                data = JsonConvert.DeserializeObject<List<EmployeeModels>>(jsonStr);

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return data;
            }
        }

        public int InsertData(EmployeeModels data)
        {
            try
            {
                string jsonConvert = System.Text.Json.JsonSerializer.Serialize(data);

                response = client.PostAsJsonAsync("api/Employee", data).Result;
                string jsonStr = response.Content.ReadAsStringAsync().Result;
                return 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 400;
            }
        }

        public int Update(EmployeeModels data)
        {
            try
            {
                string jsonConvert = System.Text.Json.JsonSerializer.Serialize(data);

                response = client.PutAsJsonAsync("api/Employee", data).Result;
                string jsonStr = response.Content.ReadAsStringAsync().Result;
                return 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 400;
            }
        }

        public int Delete(EmployeeModels data)
        {
            try
            {
                string jsonConvert = System.Text.Json.JsonSerializer.Serialize(data);

                response = client.DeleteAsync("api/Employee/"+data.Id.ToString()).Result;
                string jsonStr = response.Content.ReadAsStringAsync().Result;
                return 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 400;
            }
        }

        //public int SearchById(int id)
        //{
        //    data = new List<EmployeeModels>();
        //    try
        //    {
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(id));
        //        response = client.GetAsync("api/Employee").Result;
        //        string jsonStr = response.Content.ReadAsStringAsync().Result;

        //        data = JsonConvert.DeserializeObject<List<EmployeeModels>>(jsonStr);

        //        return 200;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return 400;
        //    }
        //}

    }
}
