using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models.Entity;

namespace WinFormsApp1.Repository
{
    public class JobRepository
    {
        public List<Job> GetListJob()
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var listJob = db.Jobs.ToList();
                return listJob;
            }
        }

        public Job GetJobById(int id)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var job = from j in db.Jobs
                          where j.Id == id
                          select j;
                return job.FirstOrDefault();
            }
        }

        public Job GetJobByName(string name)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var job = from j in db.Jobs
                          where j.Name == name
                          select j;
                return job.FirstOrDefault();
            }
        }
    }
}
