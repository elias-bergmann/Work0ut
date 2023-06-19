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
    public class MovementService
    {
        private const string ServerAdress = "http://10.0.2.2:7170";
        readonly HttpClient httpClient;
        public MovementService()
        {
            httpClient = new HttpClient();
        }

        List<Movement> movementList = new();

        public async Task<List<Movement>> GetMovementList()
        {
            if (movementList?.Count > 0)
            {
                return movementList;
            }

            string url = ServerAdress + "/" + Controllers.Movement_ControllerName + "/" + Methods.GetMovementList_MethodName; 

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                movementList = await response.Content.ReadFromJsonAsync<List<Movement>>();
            }

            return movementList;
        }

        public async Task CreateMovement(Movement movement)
        {

            string url = ServerAdress + "/" + Controllers.Movement_ControllerName + "/" + Methods.PostNewMovement_MethodName;
            HttpResponseMessage response = await httpClient.PostAsJsonAsync(url, movement);

            if (response.IsSuccessStatusCode)
            {

            }
        }

        public async Task UpdateMovement(string id, Movement movement)
        {

            string url = ServerAdress + "/" + Controllers.Movement_ControllerName + "/" + Methods.PostNewMovement_MethodName;
            HttpResponseMessage response = await httpClient.PutAsJsonAsync(url, (id,movement));

            if (response.IsSuccessStatusCode)
            {

            }
        }

        public async Task<Movement> GetMovementById()
        {
            Movement movement = null;

            string url = ServerAdress + "/" + Controllers.Movement_ControllerName + "/" + Methods.GetMovementById_MethodName;
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                movement = await response.Content.ReadFromJsonAsync<Movement>();
            }

            return movement;
        }


        public Movement GetMovementByName(string movementName)
        {
            return movementList.FirstOrDefault(x => x.Name == movementName);
        }


        public async Task DeleteExerice(string id)
        {
            string url = ServerAdress + "/" + Controllers.Movement_ControllerName + "/" + Methods.DeleteMovementById_MethodName + "/" + id;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {

            }
        }
    }
}
