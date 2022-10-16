using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Work0ut.Model;

namespace Work0ut.Service
{
    public class DatabaseConnectionService
    {
        private readonly IMongoCollection<Exercice> _exercicesCollection;

        public DatabaseConnectionService(IOptions<Work0utDatabaseSettings> wor0utDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                wor0utDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                wor0utDatabaseSettings.Value.DatabaseName);

            _exercicesCollection = mongoDatabase.GetCollection<Exercice>(wor0utDatabaseSettings.Value.ExercicesCollectionName);

        }

        public async Task<List<Exercice>> GetAsync() =>
    await _exercicesCollection.Find(_ => true).ToListAsync();

        public async Task<Exercice?> GetAsync(string id) =>
            await _exercicesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Exercice newExercice) =>
            await _exercicesCollection.InsertOneAsync(newExercice);

        public async Task UpdateAsync(string id, Exercice updatedExercice) =>
            await _exercicesCollection.ReplaceOneAsync(x => x.Id == id, updatedExercice);

        public async Task RemoveAsync(string id) =>
            await _exercicesCollection.DeleteOneAsync(x => x.Id == id);
    }
}
