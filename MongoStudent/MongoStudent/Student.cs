using System;
using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoStudent//Extremely simple test class
{
	public class Student
	{	

		public ObjectId Id { get; set; }// Need an ObjectId to avoid NoIdGenerator error.
		public string name { get; set; }
		public string sNumber { get; set; }
		public string course{ get; set; }
	}
}
