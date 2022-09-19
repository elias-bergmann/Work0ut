using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Workout.Model;

namespace Workout.Service
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

            var url = "https://github.com/elias-bergmann/Workout/blob/master/ExerciceList.json";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                exerciceList = await response.Content.ReadFromJsonAsync<List<Exercice>>();
            }

            return exerciceList;
        }
    }
}
