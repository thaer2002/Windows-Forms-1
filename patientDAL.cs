using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Windows_Forms_1.DataAccess
{
    public static class patientDAL
    {
        private static string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;"
            +" Data source=D:\\VisualProgramming_Grouo2_Projects\\Databases\\clinic.accdb";

       public static OleDbConnection connection = new OleDbConnection(connectionString);

        public static DataTable GetAllPatients()
        {
            string commandString = "select * from patients";

            OleDbconnand command = new OleDbconnand(commandString, connection);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable patientsTable = new DataTable();

            da.Fill(patientsTable);
          
            return null;
        }
        public static Patient GetPatient(int id)
        {
            return null;
        }
        public static void createPatient(Patient patient)
        {
            string commandString = String.Format("Insert into patient(patientName) values ('{0}')",
                patient.PatientName);

            OleDbCommand command = new OleDbCommand(commandString, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void UpdatePatient(Patient patient)
        {
            string commandString = String.Format("Update patients set PatientName = '{0}'",
                patient.PatientName);

            OleDbCommand command = new OleDbCommand(commandString, connection);

            connection.Close();

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void DeletePatient(int id)
        {
            string commandString = String.Format("Delete from patients where patientId = {0}",
                id);

            OleDbCommand command = new OleDbCommand(commandString, connection);

            connection.Close();

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        }
    
}
