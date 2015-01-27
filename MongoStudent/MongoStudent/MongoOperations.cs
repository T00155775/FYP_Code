using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoStudent;
using System.Diagnostics;


public class MongoOperations
{

	public static void Main(String[] args)
	{

		MongoClient client = new MongoClient (); // create client.
		MongoServer server = client.GetServer ();// accesses server.
		MongoDatabase db = server.GetDatabase ("TestStudentLocally"); // get database - previously created/but will create if needed.


		MongoCollection <Student> studentCollection = db.GetCollection<Student> ("TestStudentLocallyCollection");// simple database of names - type Student

		Console.Write ("Enter a name:");
		string sName = Console.ReadLine ();

		Console.Write ("Enter a student number:");
		string sNumber = Console.ReadLine ();

		Console.Write ("Enter a course:");
		string course = Console.ReadLine ();

		Student student = new Student {
			Id = ObjectId.GenerateNewId(),
			name = sName,
			sNumber = sNumber,
			course = course

		};

		Stopwatch timer = new Stopwatch ();// Measure time taken to save

		timer.Start ();

		studentCollection.Save (student);

		timer.Stop();
		Console.WriteLine("Time taken to save: " +timer.ElapsedMilliseconds+" ms");

		// search collection
		timer.Start ();

		studentCollection.FindAll();

		timer.Stop();
		Console.WriteLine("\nTime taken to find: " +timer.ElapsedMilliseconds+" ms");

		//Test same operations for:
		//Redis
		//Cassandra
		//Neo4J




	}

}

