using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Work0ut.Model;

namespace Work0ut.Service
{
    public class ExerciceService
    {
        readonly HttpClient httpClient;
        public ExerciceService()
        {
            httpClient = new HttpClient();
        }

        List<Exercice> exerciceList = new();
        public async Task<List<Exercice>> GetExercices()
        {
            if (exerciceList?.Count > 0)
            {
                return exerciceList;
            }

            string url = "https://raw.githubusercontent.com/elias-bergmann/Resources/main/Json/exercice-list.json?raw=true";
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                exerciceList = await response.Content.ReadFromJsonAsync<List<Exercice>>();
            }

            return exerciceList;
        }
    }
}
