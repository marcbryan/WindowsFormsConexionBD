using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private enum eTipoFiltro
        {
            equals = 0,
            startsWith = 1,
            endsWith = 2
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
            if (cbFiltro.SelectedIndex != -1 && cbTipo.SelectedIndex != -1)
            {
                if (txtTexto.Text != "")
                {
                    lbEmployees.Items.Clear();

                    List<Employee> employees;
                    switch (cbFiltro.SelectedIndex)
                    {
                        case (int) eOpcion.nombre:
                            employees = SelectEmployeesBy(txtTexto.Text, cbTipo.SelectedIndex, "first_name", "@FirstName");
                            AddEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.apellido:
                            employees = SelectEmployeesBy(txtTexto.Text, cbTipo.SelectedIndex, "last_name", "@LastName");
                            AddEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.ciudad:
                            employees = SelectEmployeesByCity(txtTexto.Text, cbTipo.SelectedIndex);
                            AddEmployeesToListBox(employees);
                            break;
                    }
                }
                else
                    MessageBox.Show("Debes escribir un texto para poder realizar la consulta");
            }
            else
                MessageBox.Show("Selecciona los filtros para poder realizar la consulta");
        }

        private List<Employee> SelectEmployeesBy(string text, int type, string columnName, string paramName)
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                string comparator = "";

                switch (type)
                {
                    case (int) eTipoFiltro.equals:
                        comparator = "=";
                        break;

                    case (int) eTipoFiltro.startsWith:
                        comparator = "LIKE";
                        text += "%";
                        break;
                    
                    case (int) eTipoFiltro.endsWith:
                        comparator = "LIKE";
                        text = "%" + text;
                        break;
                }
                
                string query = "SELECT * FROM employees WHERE " + columnName + " " + comparator + " " + paramName;
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

        private List<Employee> SelectEmployeesByCity(string city, int type)
        {
            try
            {
                List<Employee> employees = new List<Employee>();

                string comparator = "";
                switch (type)
                {
                    case (int) eTipoFiltro.equals:
                        comparator = "=";
                        break;

                    case (int) eTipoFiltro.startsWith:
                        comparator = "LIKE";
                        city += "%";
                        break;

                    case (int) eTipoFiltro.endsWith:
                        comparator = "LIKE";
                        city = "%" + city;
                        break;
                }

                string query = "SELECT * FROM employees e "
                    + "INNER JOIN departments d ON e.department_id = d.department_id "
                    + "INNER JOIN locations l ON d.location_id = l.location_id "
                    + "WHERE l.city " + comparator + " @City";
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

        private void btnBuscarConLinq_Click(object sender, EventArgs e)
        {
            FiltrarPorLinq();
        }

        private void FiltrarPorLinq()
        {
            if (cbFiltro.SelectedIndex != -1 && cbTipo.SelectedIndex != -1)
            {
                if (txtTexto.Text != "")
                {
                    lbEmployees.Items.Clear();

                    IQueryable<employees> employees;
                    switch (cbFiltro.SelectedIndex)
                    {
                        case (int) eOpcion.nombre:
                            employees = LinqSelectEmployeesBy(txtTexto.Text, (int) eOpcion.nombre, cbTipo.SelectedIndex);
                            AddLinqEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.apellido:
                            employees = LinqSelectEmployeesBy(txtTexto.Text, (int) eOpcion.apellido, cbTipo.SelectedIndex);
                            AddLinqEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.ciudad:
                            employees = LinqSelectEmployeesBy(txtTexto.Text, (int) eOpcion.ciudad, cbTipo.SelectedIndex);
                            AddLinqEmployeesToListBox(employees);
                            break;
                    }
                }
                else
                    MessageBox.Show("Debes escribir un texto para poder realizar la consulta");
            }
            else
                MessageBox.Show("Selecciona los filtros para poder realizar la consulta");
        }

        private IQueryable<employees> LinqSelectEmployeesBy(string text, int filterBy, int type)
        {
            IQueryable<employees> data = null;

            switch (filterBy)
            {
                case (int) eOpcion.nombre:
                    data = LinqFirstNameTypeFilter(type, text);
                    break;

                case (int) eOpcion.apellido:
                    data = LinqLastNameTypeFilter(type, text);
                    break;

                case (int) eOpcion.ciudad:
                    data = LinqCityTypeFilter(type, text);
                    break;
            }

            return data;
        }

        private IQueryable<employees> LinqFirstNameTypeFilter(int type, string text)
        {
            LinqToSQLDataContext dc = new LinqToSQLDataContext();
            IQueryable<employees> data = null;

            switch (type)
            {
                case (int) eTipoFiltro.equals:
                    data = from emp in dc.employees
                           where emp.first_name == text
                           select emp;
                    break;

                case (int) eTipoFiltro.startsWith:
                    data = from emp in dc.employees
                           where emp.first_name.StartsWith(text)
                           select emp;
                    break;

                case (int) eTipoFiltro.endsWith:
                    data = from emp in dc.employees
                           where emp.first_name.EndsWith(text)
                           select emp;
                    break;
            }

            return data;
        }

        private IQueryable<employees> LinqLastNameTypeFilter(int type, string text)
        {
            LinqToSQLDataContext dc = new LinqToSQLDataContext();
            IQueryable<employees> data = null;

            switch (type)
            {
                case (int) eTipoFiltro.equals:
                    data = from emp in dc.employees
                           where emp.last_name == text
                           select emp;
                    break;

                case (int) eTipoFiltro.startsWith:
                    data = from emp in dc.employees
                           where emp.last_name.StartsWith(text)
                           select emp;
                    break;

                case (int) eTipoFiltro.endsWith:
                    data = from emp in dc.employees
                           where emp.last_name.EndsWith(text)
                           select emp;
                    break;
            }

            return data;
        }

        private IQueryable<employees> LinqCityTypeFilter(int type, string text)
        {
            LinqToSQLDataContext dc = new LinqToSQLDataContext();
            IQueryable<employees> data = null;

            switch (type)
            {
                case (int) eTipoFiltro.equals:
                    data = from emp in dc.employees
                           join d in dc.departments
                               on emp.department_id equals d.department_id
                           join l in dc.locations
                               on d.location_id equals l.location_id
                           where l.city == text
                           select emp;
                    break;

                case (int) eTipoFiltro.startsWith:
                    data = from emp in dc.employees
                           join d in dc.departments
                               on emp.department_id equals d.department_id
                           join l in dc.locations
                               on d.location_id equals l.location_id
                           where l.city.StartsWith(text)
                           select emp;
                    break;

                case (int) eTipoFiltro.endsWith:
                    data = from emp in dc.employees
                           join d in dc.departments
                               on emp.department_id equals d.department_id
                           join l in dc.locations
                               on d.location_id equals l.location_id
                           where l.city.EndsWith(text)
                           select emp;
                    break;
            }

            return data;
        }

        private void AddLinqEmployeesToListBox(IQueryable<employees> employees)
        {
            if (employees != null)
            {
                if (employees.Count<employees>() > 0)
                {
                    foreach (employees emp in employees)
                        lbEmployees.Items.Add(emp);
                }
                else
                    MessageBox.Show("No se encontraron resultados");
            }
        }
    }

    public partial class employees
    {
        public override string ToString()
        {
            return "{ employee_id: " + employee_id + ", first_name: " + first_name + ", last_name: " + last_name
                    + ", email: " + email + ", phone_number: " + phone_number + ", hire_date: " + hire_date
                    + ", job_id: " + job_id + ", salary: " + salary + ", manager_id: " + manager_id
                    + ", department_id: " + department_id + " }";
        }
    }
}
