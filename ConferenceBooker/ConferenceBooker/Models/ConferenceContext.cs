namespace ConferenceBooker.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class ConferenceContext : DbContext
	{
		// Your context has been configured to use a 'Model1' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'ConferenceBooker.Models.Model1' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'Model1' 
		// connection string in the application configuration file.
		public ConferenceContext()
			: base("Conference")
		{
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		 public virtual DbSet<Presentation> PresentationEntries { get; set; }
		 public virtual DbSet<Speaker> SpeakerEntries { get; set; }

		 public virtual DbSet<Attendant> AttendantEntries { get; set; }

		 public virtual DbSet<Publication> PublicationEntries { get; set; }

	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}