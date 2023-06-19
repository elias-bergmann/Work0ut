using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Work0ut.Model;

namespace Work0ut.Service
{
    public class DatabaseConnectionService
    {
        private readonly IMongoCollection<Movement> _movementCollection;
        private readonly IMongoCollection<Workout> _workoutsCollection;

        public DatabaseConnectionService(IOptions<Work0utDatabaseSettings> wor0utDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                wor0utDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                wor0utDatabaseSettings.Value.DatabaseName);

            _movementCollection = mongoDatabase.GetCollection<Movement>(wor0utDatabaseSettings.Value.MovementCollectionName);
            _workoutsCollection = mongoDatabase.GetCollection<Workout>(wor0utDatabaseSettings.Value.WorkoutsCollectionName);
        }

        #region Movements

        public async Task<List<Movement>> GetAllMovementAsync() =>
            await _movementCollection.Find(_ => true).ToListAsync();

        public async Task<Movement?> GetMovementAsync(string id) =>
            await _movementCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateMovementAsync(Movement newMovement) =>
            await _movementCollection.InsertOneAsync(newMovement);

        public async Task UpdateMovementAsync(string id, Movement updatedMovement) =>
            await _movementCollection.ReplaceOneAsync(x => x.Id == id, updatedMovement);

        public async Task RemoveMovementAsync(string id) =>
            await _movementCollection.DeleteOneAsync(x => x.Id == id);

        #endregion

        #region Workout

        public async Task<List<Workout>> GetAllWorkoutAsync() =>
            await _workoutsCollection.Find(_ => true).ToListAsync();

        public async Task<Workout?> GetWorkoutAsync(string id) =>
            await _workoutsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateWorkoutAsync(Workout newWorkout) =>
            await _workoutsCollection.InsertOneAsync(newWorkout);

        public async Task UpdateWorkoutAsync(string id, Workout updatedWorkout) =>
            await _workoutsCollection.ReplaceOneAsync(x => x.Id == id, updatedWorkout);

        public async Task RemoveWorkoutAsync(string id) =>
            await _workoutsCollection.DeleteOneAsync(x => x.Id == id);

#       endregion

    }
}
