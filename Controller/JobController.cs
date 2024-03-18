using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Controller
{
    public class JobController
    {
        private JobRepository _jobModel;
        private frmEmployees _fEmployees;
        public JobController(frmEmployees fRevenue)
        {
            _jobModel = new JobRepository();
            _fEmployees = fRevenue;
        }

        public void LoadListJob()
        {
            List<Job> list = _jobModel.GetListJob();
            _fEmployees.LoadJob(list);
        }

        public Job getJobById(int id)
        {
            Job job = _jobModel.GetJobById(id);
            return job;
        }
        public Job getJobByName(string name)
        {
            Job job = _jobModel.GetJobByName(name);
            return job;
        }
    }
}
