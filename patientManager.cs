﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_1
{
    public partial class patientManager : Form
    {
        public patientManager()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            patient newPatient = new patient();
            newPatient.patientName = txtPatientName.Text;

            PatientDAL.CreatePATient(newPatient);

            dataGridView1.DataSource = PatientDAL.GetAllpatients();
        }

        private void patientManager_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PatientDAL.GetAllpatients();
        }
    }
}
