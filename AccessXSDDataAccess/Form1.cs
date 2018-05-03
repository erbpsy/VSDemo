using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace AccessXSDDataAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            patientsTableAdapter1.Fill(maindataset.Patients);
            DataRow[] Rows=   maindataset.Patients.Select("IsUploaded=True");
            foreach (var item in Rows)
            {
                MessageBox.Show("PatientId =  " + Convert.ToString(item["PatientId"]) + 
                    " PatientName =  " + Convert.ToString(item["PatientName"])+ 
                    " LocationCode =  " + Convert.ToString(item["LocationCode"])+ 
                    " Email =  " + Convert.ToString(item["Email"])+
                    " StudyDateTime =  " + Convert.ToString(item["StudyDateTime"])+
                    " ImageNumber =  " + Convert.ToString(item["ImageNumber"])+
                    " IsUploaded =  " + Convert.ToString(item["IsUploaded"]));
            }
        }
    }
}
