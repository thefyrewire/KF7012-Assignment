namespace KF7012_Assignment
{
    using System;
    using System.Collections;
    using System.Data.Entity;
    using System.Linq;

    using System.Data.Entity.Core;
    using System.ComponentModel.DataAnnotations;

    public class Model : DbContext
    {
        // Your context has been configured to use a 'Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KF7012_Assignment.Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model' 
        // connection string in the application configuration file.
        public Model()
            : base("name=Model")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Engineer> Engineers { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ScheduledJob> ScheduledJobs { get; set; }
        public virtual DbSet<ClosedJob> ClosedJobs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}