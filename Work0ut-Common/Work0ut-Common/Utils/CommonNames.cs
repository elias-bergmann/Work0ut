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
        public const string Exercice_ControllerName = "Exercice";
        public const string Workout_ControllerName = "Workout";
    }

    public static class Methods
    {
        public const string GetExercicesList_MethodName = "GetExercicesList";
        public const string GetExerciceFromId_MethodName = "GetExerciceFromId";
        public const string PostNewExercice_MethodName = "PostNewExercice";
        public const string PutExistingExercice_MethodName = "PutExistingExercice";
        public const string DeleteExerciceFromId_MethodName = "DeleteExerciceFromId";


        public const string GetWorkoutsList_MethodName = "GetWorkoutsList";
    }
}
