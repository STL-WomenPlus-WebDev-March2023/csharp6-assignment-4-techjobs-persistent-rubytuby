using System;
namespace TechJobs6Persistent.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Job>? Jobs { get; set; }

        
        public Employer(string name, string location)
        {
            Name = name;
            Location = location;
            Jobs = new List<Job>();
        }

        public Employer()
        {
        }
    }
}
