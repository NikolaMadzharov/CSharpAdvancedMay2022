using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            this.renovators = new List<Renovator>();
        }

        
        public string Name { get; set; }

        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public int Count => renovators.Count;

       public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name)||string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            if (Count+1>NeededRenovators)
            {
                return "return Renovators are no more needed.";
            }
            if (renovator.Rate>350)
            {
                return "Invalid renovator's rate.";
            }
            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }
       public bool RemoveRenovator(string name)
        {
            Renovator renovator= renovators.Where(x=>x.Name.Equals(name)).FirstOrDefault();
            
            return renovators.Remove(renovator);

        }
       public int RemoveRenovatorBySpecialty(string type)
        {

            return renovators.RemoveAll(x => x.Type==type);
        }
       public Renovator HireRenovator(string name)
        {

            Renovator renovator = renovators.Where(x => x.Name==name).FirstOrDefault();
            if (renovator == null)
            {
                return null;
            }
            renovator.Hired = true;
            return renovator;
        }
       public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> renovator =renovators.Where(d=>d.Days>=days).ToList();
           
            return renovator;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Renovators available for Project {this.Project}:{Environment.NewLine}{string.Join(Environment.NewLine, this.renovators.Where(r => r.Hired == false))}");
            return sb.ToString();
        }
    }
}
