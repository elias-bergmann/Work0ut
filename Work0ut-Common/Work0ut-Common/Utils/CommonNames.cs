using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Work0ut.Utils
{

    public static class Controllers
    {
        public const string Movement_ControllerName = "Movement";
        public const string Workout_ControllerName = "Workout";
    }

    public static class Methods
    {
        public const string GetMovementList_MethodName = "GetMovementList";
        public const string GetMovementById_MethodName = "GetMovementById";
        public const string PostNewMovement_MethodName = "PostNewMovement";
        public const string PutExistingMovement_MethodName = "PutExistingMovement";
        public const string DeleteMovementById_MethodName = "DeleteMovementById";


        public const string GetWorkoutsList_MethodName = "GetWorkoutsList";
        public const string GetWorkoutById_MethodName = "GetWorkoutById";
        public const string PostNewWorkout_MethodName = "PostNewWorkout";
        public const string PutExistingWorkout_MethodName = "PutExistingWorkout";
        public const string DeleteWorkoutById_MethodName = "DeleteWorkoutById";
    }
}
