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
    public class WorkoutService
    {
        readonly HttpClient httpClient;
        private const string ServerAdress = "http://10.0.2.2:7170";
        public WorkoutService()
        {
            httpClient = new HttpClient();
        }



        public async Task<IEnumerable<Workout>> GetWorkoutList()
        {
            IEnumerable<Workout> workoutList = null;

            string url = ServerAdress + "/" + Controllers.Workout_ControllerName + "/" + Methods.GetWorkoutsList_MethodName;
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                workoutList = await response.Content.ReadFromJsonAsync<IEnumerable<Workout>>();
            }

            return workoutList;
        }

        public async Task<Workout> GetWorkoutById()
        {
            Workout workout = null;

            string url = ServerAdress + "/" + Controllers.Workout_ControllerName + "/" + Methods.GetWorkoutById_MethodName;
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                workout = await response.Content.ReadFromJsonAsync<Workout>();
            }

            return workout;
        }


        public async Task CreateWorkout(Workout workout)
        {
            string url = ServerAdress + "/" + Controllers.Workout_ControllerName + "/" + Methods.GetWorkoutById_MethodName;
            HttpResponseMessage response = await httpClient.PostAsJsonAsync(url,workout);

            if (response.IsSuccessStatusCode)
            {

            }
        }

        public async Task UpdateWorkout(string id, Workout workout)
        {
            string url = ServerAdress + "/" + Controllers.Workout_ControllerName + "/" + Methods.GetWorkoutById_MethodName;
            HttpResponseMessage response = await httpClient.PutAsJsonAsync(url, (id, workout));

            if (response.IsSuccessStatusCode) 
            {

            }
        }


        public async Task DeleteWorkout(string id)
        {
            string url = ServerAdress + "/" + Controllers.Workout_ControllerName + "/" + Methods.DeleteWorkoutById_MethodName + "/" + id;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {

            }
        }
    }
}
