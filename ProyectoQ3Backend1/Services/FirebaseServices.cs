using Google.Cloud.Firestore;

namespace ProyectoQ3Backend.Services;

public class FirebaseService
{
    private readonly FirestoreDb _firestoreDb;

    public FirebaseService()
    {
        var credentialPath = Path.Combine(
            AppContext.BaseDirectory, "Config", "firebase-crendentials.json");

        _firestoreDb = FirestoreDb.Create("proyecto-clase-2026");
    }

    public CollectionReference GetCollection(string collectionName)
    {
        return _firestoreDb.Collection(collectionName);
    }
}