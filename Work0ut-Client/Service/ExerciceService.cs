using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Work0ut.Model;
using Work0ut.Utils;

namespace Work0ut.Service
{
    public class ExerciceService
    {
        readonly string serverAdress;
        readonly HttpClient httpClient;
        public ExerciceService()
        {
            httpClient = new HttpClient();
            serverAdress = "http://10.0.2.2:7170";
        }

        List<Exercice> exerciceList = new();

        public async Task<List<Exercice>> FetchExercices()
        {
            if (exerciceList?.Count > 0)
            {
                return exerciceList;
            }

            string url = serverAdress + "/" + Controllers.Exercice_ControllerName + "/" + Methods.GetExercicesList_MethodName; 

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                exerciceList = await response.Content.ReadFromJsonAsync<List<Exercice>>();
            }

            return exerciceList;
        }

        public Exercice GetExercieByName(string exerciceName)
        {
            return exerciceList.FirstOrDefault(x => x.Name == exerciceName);
        }
    }
}
