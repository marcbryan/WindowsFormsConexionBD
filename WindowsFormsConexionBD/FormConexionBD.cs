using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsJobs;

namespace WindowsFormsConexionBD
{
    public partial class FormConexionBD : Form
    {
        private SqlConnection connection;
        
        public FormConexionBD()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            bool connected = ConectarBD();
            if (connected)
            {
                lblConectado.Text = "Conectado";
                lblConectado.ForeColor = Color.Green;

                btnInsertarJob.Enabled = true;
                btnCerrar.Enabled = true;
                btnInsertCustomJob.Enabled = true;
                btnVerJobs.Enabled = true;
                btnShowEmployees.Enabled = true;
                lblCerrarConexion.Text = "";
            }
            else
            {
                lblConectado.Text = "ERROR";
                lblConectado.ForeColor = Color.Red;
            }
        }

        private bool ConectarBD()
        {
            try
            {
                connection = new SqlConnection(
                    @"Data source = 79.143.90.12,54321;" +
                    "Initial Catalog = MarcBoakyeEmployees; Persist Security Info = true;" +
                    "User Id = sa; Password = 123456789");

                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (CerrarConexion())
            {
                lblCerrarConexion.Text = "Conexión cerrada";
                lblCerrarConexion.ForeColor = Color.Green;
                
                lblConectado.Text = "";
                btnCerrar.Enabled = false;
            }
            else
            {
                lblCerrarConexion.Text = "ERROR";
                lblCerrarConexion.ForeColor = Color.Red;
            }
        }

        private bool CerrarConexion()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        private void btnInsertarJob_Click(object sender, EventArgs e)
        {
            bool inserted = InsertJob();
            if (inserted)
            {
                lblInsertado.Text = "Insertado correctamente!";
                lblInsertado.ForeColor = Color.Green;
            }
            else
            {
                lblInsertado.Text = "ERROR";
                lblInsertado.ForeColor = Color.Red;
            }
        }

        private bool InsertJob()
        {
            try
            {
                string query = $"INSERT INTO JOBS (job_title, min_salary, max_salary) VALUES ('Marketing 2', 1000, 3000)";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void btnInsertCustomJob_Click(object sender, EventArgs e)
        {
            decimal? minSalary;
            if (nmrMinSalary.Text == "")
                minSalary = null;
            else
                minSalary = nmrMinSalary.Value;

            decimal? maxSalary;
            if (nmrMaxSalary.Text == "")
                maxSalary = null;
            else
                maxSalary = nmrMaxSalary.Value;
            
            Job job = new Job(
                -1,
                txtJobTitle.Text,
                minSalary,
                maxSalary
            );
            
            bool inserted = InsertCustomJob(job);
            if (inserted)
            {
                lblInsertedCustomJob.Text = "Insertado correctamente! ID: " + job.JobId;
                lblInsertedCustomJob.ForeColor = Color.Green;
            }
            else
            {
                lblInsertedCustomJob.Text = "ERROR";
                lblInsertedCustomJob.ForeColor = Color.Red;
            }
        }

        private bool InsertCustomJob(Job job)
        {
            try
            {
                string minSalary = (job.MinSalary == null) ? "null" : job.MinSalary.ToString();
                string maxSalary = (job.MaxSalary == null) ? "null" : job.MaxSalary.ToString();
                
                string query = "INSERT INTO JOBS (job_title, min_salary, max_salary) " +
                               "VALUES (@JobTitle, @MinSalary, @MaxSalary);" +
                               "SELECT CAST(SCOPE_IDENTITY() AS INT);";
                SqlCommand command = new SqlCommand(query, connection);

                SqlParameter paramJobTitle = new SqlParameter
                {
                    ParameterName = "@JobTitle",
                    SqlDbType = SqlDbType.VarChar,
                    Value = job.JobTitle
                };
                command.Parameters.Add(paramJobTitle);

                SqlParameter paramMinSalary = new SqlParameter
                {
                    ParameterName = "@MinSalary",
                    SqlDbType = SqlDbType.Decimal,
                    Value = job.MinSalary
                };

                if (job.MinSalary == null)
                    paramMinSalary.Value = DBNull.Value;
                
                command.Parameters.Add(paramMinSalary);

                SqlParameter paramMaxSalary = new SqlParameter
                {
                    ParameterName = "@MaxSalary",
                    SqlDbType = SqlDbType.Decimal,
                    Value = job.MaxSalary
                };

                if (job.MaxSalary == null)
                    paramMaxSalary.Value = DBNull.Value;

                command.Parameters.Add(paramMaxSalary);

                object id = command.ExecuteScalar();
                job.JobId = (int) id;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void btnVerJobs_Click(object sender, EventArgs e)
        {
            List<Job> jobs = GetAllJobs();
            if (jobs != null)
            {
                FormSelectJobs formSelectJobs = new FormSelectJobs(jobs);
                formSelectJobs.ShowDialog();
            }
            else
                MessageBox.Show("Error al recuperar los datos!");
        }

        private List<Job> GetAllJobs()
        {
            try
            {
                List<Job> jobs = new List<Job>();

                string query = "SELECT * FROM JOBS";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader records = command.ExecuteReader();
            
                while (records.Read())
                {
                    int jobId = (int) records["job_id"];
                    string jobName = records["job_title"].ToString();
                    decimal? minSalary = records.IsDBNull(2) ? null : (decimal?) records["min_salary"];
                    decimal? maxSalary = records.IsDBNull(3) ? null : (decimal?) records["max_salary"];

                    Job job = new Job(jobId, jobName, minSalary, maxSalary);
                    jobs.Add(job);
                }
                records.Close();

                return jobs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void SetNullValueNumericUpDown (NumericUpDown nmr)
        {
            nmr.Text = "";
        }

        private void btnBorrarMinSalary_Click(object sender, EventArgs e)
        {
            SetNullValueNumericUpDown(nmrMinSalary);
        }

        private void btnBorrarMaxSalary_Click(object sender, EventArgs e)
        {
            SetNullValueNumericUpDown(nmrMaxSalary);
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            CrearFormMostrarEmpleados();
        }

        private void CrearFormMostrarEmpleados()
        {
            FormSelectEmployees formSelectEmployees = new FormSelectEmployees(connection);
            formSelectEmployees.ShowDialog();
        }
    }
}
