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
            if (cbTipoNombre.SelectedIndex != -1 || cbTipoApellido.SelectedIndex != -1 || cbTipoCiudad.SelectedIndex != -1)
            {
                if (txtTextoNombre.Text != "" || txtTextoApellido.Text != "" || txtTextoCiudad.Text != "")
                {
                    lbEmployees.Items.Clear();

                    Dictionary<string, object[]> map = ObtenerDatosCamposParaFiltrar();

                    List<Employee> employees = SelectEmployeesBy(map);
                    AddEmployeesToListBox(employees);
                    /*switch (cbFiltro.SelectedIndex)
                    {
                        case (int) eOpcion.nombre:
                            employees = SelectEmployeesBy(txtTextoNombre.Text, cbTipoNombre.SelectedIndex, "first_name", "@FirstName");
                            AddEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.apellido:
                            employees = SelectEmployeesBy(txtTextoNombre.Text, cbTipoNombre.SelectedIndex, "last_name", "@LastName");
                            AddEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.ciudad:
                            employees = SelectEmployeesByCity(txtTextoNombre.Text, cbTipoNombre.SelectedIndex);
                            AddEmployeesToListBox(employees);
                            break;
                    }*/
                }
                else
                    MessageBox.Show("Debes escribir un texto para poder realizar la consulta");
            }
            else
                MessageBox.Show("Selecciona los filtros para poder realizar la consulta");
        }

        private Dictionary<string, object[]> ObtenerDatosCamposParaFiltrar()
        {
            Dictionary<string, object[]> map = new Dictionary<string, object[]>();
            
            if (cbTipoNombre.SelectedIndex != -1 || cbTipoApellido.SelectedIndex != -1 || cbTipoCiudad.SelectedIndex != -1)
            {
                if (cbTipoCiudad.SelectedIndex != -1)
                {
                    Object[] datosCiudad = { cbTipoCiudad.SelectedIndex, txtTextoCiudad.Text, "city", "@City" };
                    map["ciudad"] = datosCiudad;
                }

                if (cbTipoNombre.SelectedIndex != -1)
                {
                    Object[] datosNombre = { cbTipoNombre.SelectedIndex, txtTextoNombre.Text, "first_name", "@FirstName" };
                    map["nombre"] = datosNombre;
                }
                
                if (cbTipoApellido.SelectedIndex != -1)
                {
                    Object[] datosApellido = { cbTipoApellido.SelectedIndex, txtTextoApellido.Text, "last_name", "@LastName" };
                    map["apellido"] = datosApellido;
                }  
            }

            return map;
        }

        private List<Employee> SelectEmployeesBy(Dictionary<string, object[]> map)
        {
            try
            {                
                string query = "SELECT * FROM employees ";
                SqlCommand cmd = new SqlCommand(query, connection);

                int contador = 0;
                bool isWhereAdded = false;

                foreach (var columna in map)
                {
                    int type = (int) columna.Value[0];
                    string text = (string) columna.Value[1];
                    string columnName = (string) columna.Value[2];
                    string paramName = (string) columna.Value[3];

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

                    if (columna.Key == "ciudad")
                    {
                        string strCityQuery = "e INNER JOIN departments d ON e.department_id = d.department_id "
                                            + "INNER JOIN locations l ON d.location_id = l.location_id "
                                            + "WHERE l.city " + comparator + " @City";
                        query += strCityQuery;
                        isWhereAdded = true;
                    }
                    else
                    {
                        if (!isWhereAdded)
                        {
                            query += " WHERE ";
                            isWhereAdded = true;
                        }

                        if (contador > 0)
                            query += " AND ";

                        query += columnName + " " + comparator + " " + paramName;
                    }      
                    
                    SqlParameter param = new SqlParameter
                    {
                        ParameterName = paramName,
                        SqlDbType = SqlDbType.VarChar,
                        Value = text
                    };
                    cmd.Parameters.Add(param);

                    contador++;
                }

                cmd.CommandText = query;
                SqlDataReader records = cmd.ExecuteReader();

                List<Employee> employees = GetEmployeesFromRecords(records);
                return employees;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private List<Employee> GetEmployeesFromRecords(SqlDataReader records)
        {
            List<Employee> employees = new List<Employee>();

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

            return employees;
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

        //TODO: Eliminar
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
                //PutEmployeesInList(records, employees);
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

        // TODO: Cambiar
        private void FiltrarPorLinq()
        {
            if (cbTipoNombre.SelectedIndex != -1 || cbTipoApellido.SelectedIndex != -1 || cbTipoCiudad.SelectedIndex != -1)
            {
                if (txtTextoNombre.Text != "" || txtTextoApellido.Text != "" || txtTextoCiudad.Text != "")
                {
                    lbEmployees.Items.Clear();

                    LinqToSQLDataContext dc = new LinqToSQLDataContext();
                    IQueryable<employees> data = from emp in dc.employees
                                                 select emp;

                    Dictionary<string, object[]> map = ObtenerDatosCamposParaFiltrar();

                    foreach (var field in map)
                    {
                        int type = (int) field.Value[0];
                        string text = (string) field.Value[1];
                        string columnName = (string) field.Value[2];
                        string paramName = (string) field.Value[3];
                        
                        switch (field.Key)
                        {
                            case "ciudad":
                                data = LinqCityTypeFilter(type, text);
                                break;

                            case "nombre":
                                data = LinqWhereFirstName(data, type, text);
                                break;

                            case "apellido":
                                data = LinqWhereLastName(data, type, text);
                                break;
                        }
                    }
                    AddLinqEmployeesToListBox(data);

                    /*switch (cbFiltro.SelectedIndex)
                    {
                        case (int) eOpcion.nombre:
                            employees = LinqSelectEmployeesBy(txtTextoNombre.Text, (int) eOpcion.nombre, cbTipoNombre.SelectedIndex);
                            AddLinqEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.apellido:
                            employees = LinqSelectEmployeesBy(txtTextoNombre.Text, (int) eOpcion.apellido, cbTipoNombre.SelectedIndex);
                            AddLinqEmployeesToListBox(employees);
                            break;

                        case (int) eOpcion.ciudad:
                            employees = LinqSelectEmployeesBy(txtTextoNombre.Text, (int) eOpcion.ciudad, cbTipoNombre.SelectedIndex);
                            AddLinqEmployeesToListBox(employees);
                            break;
                    }*/
                }
                else
                    MessageBox.Show("Debes escribir un texto para poder realizar la consulta");
            }
            else
                MessageBox.Show("Selecciona los filtros para poder realizar la consulta");
        }

        private IQueryable<employees> LinqWhereFirstName(IQueryable<employees> data, int type, string text)
        {
            switch (type)
            {
                case (int) eTipoFiltro.equals:
                    data = data.Where(e => e.first_name.Equals(text));
                    break;

                case (int) eTipoFiltro.startsWith:
                    data = data.Where(e => e.first_name.StartsWith(text));
                    break;

                case (int) eTipoFiltro.endsWith:
                    data = data.Where(e => e.first_name.EndsWith(text));
                    break;
            }
            return data;
        }

        private IQueryable<employees> LinqWhereLastName(IQueryable<employees> data, int type, string text)
        {
            switch (type)
            {
                case (int) eTipoFiltro.equals:
                    data = data.Where(e => e.last_name.Equals(text));
                    break;

                case (int) eTipoFiltro.startsWith:
                    data = data.Where(e => e.last_name.StartsWith(text));
                    break;

                case (int) eTipoFiltro.endsWith:
                    data = data.Where(e => e.last_name.EndsWith(text));
                    break;
            }
            return data;
        }

        /*private void LinqWhereCity(IQueryable<employees> data, int type, string text)
        {
            switch (type)
            {
                case (int)eTipoFiltro.equals:
                    data = data.Where(e => e.last_name.Equals(text));
                    break;

                case (int)eTipoFiltro.startsWith:
                    data = data.Where(e => e.last_name.StartsWith(text));
                    break;

                case (int)eTipoFiltro.endsWith:
                    data = data.Where(e => e.last_name.EndsWith(text));
                    break;
            }
        }*/

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

        private void btnBorrarNombre_Click(object sender, EventArgs e)
        {
            cbTipoNombre.SelectedIndex = -1;
            txtTextoNombre.Text = "";
        }

        private void btnBorrarApellido_Click(object sender, EventArgs e)
        {
            cbTipoApellido.SelectedIndex = -1;
            txtTextoApellido.Text = "";
        }

        private void btnBorrarCiudad_Click(object sender, EventArgs e)
        {
            cbTipoCiudad.SelectedIndex = -1;
            txtTextoCiudad.Text = "";
        }
    }

    public partial class employees
    {
        public override string ToString()
        {
            string firstName = (first_name == null) ? "null" : first_name;
            string phoneNumber = (phone_number == null) ? "null" : phone_number;
            string managerId = (manager_id == null) ? "null" : manager_id.ToString();
            string departmentId = (department_id == null) ? "null" : department_id.ToString();

            return "{ employee_id: " + employee_id + ", first_name: " + firstName + ", last_name: " + last_name
                    + ", email: " + email + ", phone_number: " + phoneNumber + ", hire_date: " + hire_date
                    + ", job_id: " + job_id + ", salary: " + salary + ", manager_id: " + managerId
                    + ", department_id: " + departmentId + " }";
        }
    }
}
