using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsConexionBD;

namespace WindowsFormsJobs
{
    public partial class FormSelectJobs : Form
    {
        public FormSelectJobs(List<Job> jobs)
        {
            InitializeComponent();

            foreach (Job job in jobs)
                lbJobs.Items.Add(job.ToString());
        }
    }
}
