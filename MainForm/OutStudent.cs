using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class OutStudent : Form
    {
        #region Define

        #endregion

        #region Field
        private Main m_MainClass;
        string[] data = new string[30];
        #endregion

        #region Constructor
        public OutStudent(Main main)
        {
            MainClass = main;
            InitializeComponent();
            #region Default
            foreach (Main.TotalStudent item in Enum.GetValues(typeof(Main.TotalStudent)))
            {
                dataGridView1.Columns.Add(item.ToString(), item.ToString());
            }
            dataGridView1.Rows.Add();
            #endregion
        }
        #endregion

        #region Property
        public Main MainClass
        {
            get { return this.m_MainClass; }
            set { this.m_MainClass = value; }
        }





        #endregion

        #region EventHandler
        private void OutStudent_Load(object sender, EventArgs e)
        {
            
            int k = 0;
            int p = 0;
            dataGridView1.RowCount = MainClass.RowCount;
            #region OutStudentInformation
            for (int i = 0; i < MainClass.RowCount; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Main.Student)).Length; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = MainClass.StudentDataSave[k];
                    k++;
                }               
                for (int j = Enum.GetNames(typeof(Main.Subjects)).Length; j < Enum.GetNames(typeof(Main.Student)).Length + Enum.GetNames(typeof(Main.Subjects)).Length; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = MainClass.SubjectDataSave[p];
                    p++;
                } 
                dataGridView1.Rows[i].Cells["Sum"].Value = MainClass.SumData[i];
                dataGridView1.Rows[i].Cells["Average"].Value = MainClass.SumData[i] / Enum.GetNames(typeof(Main.Subjects)).Length;
            }
            k = 0;
            p = 0;
            #endregion
            #region TotalSave
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    MainClass.TotalDataSave.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
            #endregion
        }
        #endregion

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int k = dataGridView1.Rows.IndexOf(row); 
            
            for (int i = 0; i  < Enum.GetValues(typeof(Main.TotalStudent)).Length; i++)
            {
                data[i] = row.Cells[i].Value.ToString();
                if (data[i] != MainClass.TotalDataSave[i + ((k - 1) * Enum.GetValues(typeof(Main.TotalStudent)).Length)])
                {
                    MainClass.TotalDataSave[i + ((k - 1) * Enum.GetValues(typeof(Main.TotalStudent)).Length)] = data[i];
                }
            }          
        }
    }
}
