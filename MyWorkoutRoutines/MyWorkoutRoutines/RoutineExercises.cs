//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWorkoutRoutines
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoutineExercises
    {
        public int RoutineExercisesID { get; set; }
        public Nullable<int> Repetitions { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<System.TimeSpan> BreakRoutine { get; set; }
        public int RoutineID { get; set; }
        public int ExerciseID { get; set; }
    
        public virtual Exercise Exercise { get; set; }
        public virtual Routine Routine { get; set; }
    }
}
