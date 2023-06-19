namespace Work0ut.Model
{
    public class Set
    {
        public Movement Movement { get; set; }
        public int NumberOfReps { get; set; }
        public double Weight { get; set; }
        TimeSpan? RestTime { get; set; }
    }
}