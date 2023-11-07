using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Job
    {
        private int jobId;
        private string jobTitle;
        private decimal? minSalary;
        private decimal? maxSalary;

        public int JobId { get { return jobId; } set {  jobId = value; } }
        public string JobTitle { get {  return jobTitle; } set { jobTitle = value; } }
        public decimal? MinSalary { get {  return minSalary; } set {  minSalary = value; } }
        public decimal? MaxSalary { get { return maxSalary; } set {  maxSalary = value; } }

        public Job(int jobId, string jobTitle, decimal? minSalary, decimal? maxSalary) 
        {
            this.jobId = jobId;
            this.jobTitle = jobTitle;
            this.minSalary = minSalary;
            this.maxSalary = maxSalary;
        }

        public override string ToString()
        {
            string min = (minSalary == null) ? "null" : minSalary.ToString();
            string max = (maxSalary == null) ? "null" : maxSalary.ToString();

            return "{ job_id: " + jobId + ", job_title: " + jobTitle + ", min_salary: " + min + ", max_salary: " + max + " }";
        }
    }
}
