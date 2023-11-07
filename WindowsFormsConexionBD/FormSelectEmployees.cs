using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsConexionBD
{
    public partial class FormSelectEmployees : Form
    {
        private SqlConnection connection;

        private enum eOpcion
        {
            nombre = 0,
            apellido = 1,
            ciudad = 2
        }
        public FormSelectEmployees(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarPor();
        }

        private void FiltrarPor()
        {
            if (cbFiltro.SelectedIndex != -1)
            {
                if (txtTexto.Text != "")
                {
                    lbEmployees.Items.Clear();

                    List<Employee> employees;
                    switch (cbFiltro.SelectedIndex)
                    {
                        case (int) eOpcion.nombre:
                            employees = SelectEmployeesBy(txtTexto.Text, "first_name", "@FirstName");
                            AddEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.apellido:
                            employees = SelectEmployeesBy(txtTexto.Text, "last_name", "@LastName");
                            AddEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.ciudad:
                            employees = SelectEmployeesByCity(txtTexto.Text);
                            AddEmployeesToListBox(employees);
                            break;
                    }
                }
                else
                    MessageBox.Show("Debes escribir un texto para poder realizar la consulta");
            }
            else
                MessageBox.Show("Selecciona un filtro para poder realizar la consulta");
        }

        private List<Employee> SelectEmployeesBy(string text, string columnName, string paramName)
        {
            try
            {
                List<Employee> employees = new List<Employee>();

                string query = "SELECT * FROM employees WHERE " + columnName + "=" + paramName;
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlParameter param = new SqlParameter
                {
                    ParameterName = paramName,
                    SqlDbType = SqlDbType.VarChar,
                    Value = text
                };
                cmd.Parameters.Add(param);

                SqlDataReader records = cmd.ExecuteReader();
                PutEmployeesInList(records, employees);
                return employees;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void PutEmployeesInList(SqlDataReader records, List<Employee> employees)
        {
            while (records.Read())
            {
                string firstName = records.IsDBNull(1) ? null : records["first_name"].ToString();
                string phoneNumber = records.IsDBNull(4) ? null : records["phone_number"].ToString();
                int? managerId = records.IsDBNull(8) ? null : (int?) records["manager_id"];
                int? departmentId = records.IsDBNull(9) ? null : (int?) records["department_id"];

                Employee employee = new Employee(
                    (int) records["employee_id"],
                    firstName,
                    records["last_name"].ToString(),
                    records["email"].ToString(),
                    phoneNumber,
                    (DateTime) records["hire_date"],
                    (int) records["job_id"],
                    (decimal) records["salary"],
                    managerId,
                    departmentId
                );
                employees.Add(employee);
            }
            records.Close();
        }

        private void AddEmployeesToListBox(List<Employee> employees)
        {
            if (employees != null)
            {
                if (employees.Count > 0)
                {
                    foreach (Employee employee in employees)
                        lbEmployees.Items.Add(employee.ToString());
                }
                else
                    MessageBox.Show("No se encontraron resultados");
            }
        }

        private List<Employee> SelectEmployeesByCity(string city)
        {
            try
            {
                List<Employee> employees = new List<Employee>();

                string query = "SELECT * FROM employees e "
                    + "INNER JOIN departments d ON e.department_id = d.department_id "
                    + "INNER JOIN locations l ON d.location_id = l.location_id "
                    + "WHERE l.city=@City";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlParameter param = new SqlParameter
                {
                    ParameterName = "@City",
                    SqlDbType = SqlDbType.VarChar,
                    Value = city
                };
                cmd.Parameters.Add(param);

                SqlDataReader records = cmd.ExecuteReader();
                PutEmployeesInList(records, employees);
                return employees;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
