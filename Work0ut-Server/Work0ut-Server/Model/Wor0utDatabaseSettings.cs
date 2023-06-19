namespace Work0ut.Model
{
    public class Work0utDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string MovementCollectionName { get; set; } = null!;

        public string WorkoutsCollectionName { get; set; } = null!;
    }
}
