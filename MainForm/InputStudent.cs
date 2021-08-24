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
    public partial class InputStudent : Form
    {

        #region Define

        #endregion

        #region Field
        private Main m_MainClass;
        #endregion

        #region Constructor

        public InputStudent(Main main)
        {
            MainClass = main;
            InitializeComponent();
            #region Default       
            foreach (Main.Student item in Enum.GetValues(typeof(Main.Student)))
            {
                dataGridView1.Columns.Add(item.ToString(), item.ToString());
            }
            foreach (Main.Subjects item in Enum.GetValues(typeof(Main.Subjects)))
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
        private void button_save_Click(object sender, EventArgs e)
        {
            #region InformationSave
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {               
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    #region NullReferenceException
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    }
                    #endregion

                    #region StudentInformationSave
                    if (j < Enum.GetValues(typeof(Main.Student)).Length)
                    {
                        this.MainClass.StudentDataSave.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }                   
                    #endregion

                    #region SubjectInformationSave
                    if (j >= Enum.GetValues(typeof(Main.Student)).Length)
                    {
                        this.MainClass.SubjectDataSave.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }                   
                    #endregion
                }
                this.MainClass.StudentCount++;
                this.MainClass.SubjectCount++;
            }
            for (int i = 0; i < MainClass.StudentCount; i++)
            {
                for (int j = 0; j < Enum.GetValues(typeof(Main.Student)).Length; j++)
                {
                    if(j!=0)
                    {
                        if (j == i)
                        {
                            j++;
                        }
                    }
                    if (j >= 0)
                    {
                        int k = Main.Student.Id.GetHashCode() + (j * Enum.GetValues(typeof(Main.Student)).Length);                       
                        if (dataGridView1.Rows[i].Cells["Id"].Value.ToString() == MainClass.StudentDataSave[k]  )
                        {
                            MessageBox.Show("학번이 중복됩니다");
                            return;
                        }
                    }                    
                }                    
                
               
            }
            
            #endregion

            #region SumDataSave
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {             
                for (int j = Enum.GetValues(typeof(Main.Student)).Length; j < dataGridView1.ColumnCount; j++)
                {
                    MainClass.SumData.Add(0);
                    MainClass.ScoreDataSave.Add(double.Parse(dataGridView1[j, i].Value.ToString()));
                }
                for (int j = 0; j < Enum.GetValues(typeof(Main.Student)).Length; j++)
                {
                    MainClass.SumData[MainClass.Count1] += MainClass.ScoreDataSave[MainClass.Count];
                    MainClass.Count++;
                }
                MainClass.Count1++;    
            }
            #endregion

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add();
            MainClass.RowCount++;
        }
        #endregion

    }
}
