using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainForm
{
    public partial class MainForm : Form
    {

        #region Define

        #endregion

        #region Field


        private InputStudent m_InputStudent;
        private OutStudent m_outStudent;
        private Main m_MainClass;
        int k = 0;
        #endregion

        #region Constructor
        public MainForm()
        {
            MainClass = new Main();
            InitializeComponent();
            InputStudent = new InputStudent(MainClass);
            OutStudent = new OutStudent(MainClass);
        }

        #endregion

        #region Property
        public Main MainClass
        {
            get { return this.m_MainClass; }
            set { this.m_MainClass = value; }
        }
        public InputStudent InputStudent
        {
            get { return this.m_InputStudent; }
            set { this.m_InputStudent = value; }
        }
        public OutStudent OutStudent
        {
            get { return this.m_outStudent; }
            set { this.m_outStudent = value; }
        }

        #endregion

        #region EventHandler
        private void button_InPutStudent_Click(object sender, EventArgs e)
        {
            InputStudent = new InputStudent(MainClass);
            InputStudent.Show();


        }

        private void button_Outstudent_Click(object sender, EventArgs e)
        {
            OutStudent = new OutStudent(MainClass);
            OutStudent.Show();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            MainClass = new Main();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("stu.txt"))
            {
                for (int i = 0; i < MainClass.RowCount; i++)
                {
                    for (int j = 0; j < Enum.GetValues(typeof(Main.TotalStudent)).Length; j++)
                    {
                        tw.Write($"{MainClass.TotalDataSave[k]}");
                        k++;
                        tw.Write("\t");
                    }

                    tw.WriteLine();
                }
            }

        }
    }         
}
