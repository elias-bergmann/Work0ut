using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Work0ut.Model;

namespace Work0ut.Service
{
    public class WorkoutService
    {
        readonly HttpClient httpClient;
        public WorkoutService()
        {
            httpClient = new HttpClient();
        }


        public async Task<Model.Workout> GetWorkout()
        {
            Model.Workout workout = null;
            string url = "https://raw.githubusercontent.com/elias-bergmann/Resources/main/Json/workout.json?raw=true";
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                workout = await response.Content.ReadFromJsonAsync<Model.Workout>();
            }

            return workout;
        }
    }
}
