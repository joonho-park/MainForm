using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Main
    {
        #region Define
        public enum TotalStudent
        {
            Name,
            Id,
            Adress,

            Korea,
            English,
            Math,

            Sum,
            Average

        }
        public enum Student
        {
            Name,
            Id,
            Adress
        }
        public enum Subjects
        {
            Korea,
            English,
            Math
        }
        public enum Score
        {
            Sum,
            Average
        }

        #endregion

        #region Field
        private List<string> m_StudentDataSave;
        private List<string> m_SubjectDataSave;
        private List<double> m_ScoreDataSave;
        private List<string> m_TotalDataSave;
        private int m_RowCount;
        private List<double> m_SumData;
        private int m_Count;
        private int m_Count1;
        private int m_StudentCount;
        private int m_SubjectCount;
        // private InputStudent m_InputStudemt;
        #endregion


        #region Constructor
        public Main()
        {
            StudentDataSave = new List<string>();
            SubjectDataSave = new List<string>();
            ScoreDataSave = new List<double>();
            TotalDataSave = new List<string>();
            SumData = new List<double>();
            StudentCount = 0;
            SubjectCount = 0;
            Count = 0;
            Count1 = 0;
            RowCount = 0;           
        }
        #endregion
        #region Property        
        public List<double> SumData
        {
            get { return this.m_SumData; }
            set { this.m_SumData = value; }
        }
        public int RowCount
        {
            get { return this.m_RowCount; }
            set { this.m_RowCount = value; }
        }
        public int Count
        {
            get { return this.m_Count; }
            set { this.m_Count = value; }
        }
        public int StudentCount
        {
            get { return this.m_StudentCount; }
            set { this.m_StudentCount = value; }
        }
        public int SubjectCount
        {
            get { return this.m_SubjectCount; }
            set { this.m_SubjectCount = value; }
        }
        public int Count1
        {
            get { return this.m_Count1; }
            set { this.m_Count1 = value; }
        }
        public List<string> StudentDataSave
        {
            get { return this.m_StudentDataSave; }
            set { this.m_StudentDataSave = value; }
        }
        public List<string> SubjectDataSave
        {
            get { return this.m_SubjectDataSave; }
            set { this.m_SubjectDataSave = value; }
        }
        public List<double> ScoreDataSave
        {
            get { return this.m_ScoreDataSave; }
            set { this.m_ScoreDataSave = value; }
        }
        public List<string> TotalDataSave
        {
            get { return this.m_TotalDataSave; }
            set { this.m_TotalDataSave = value; }
        }
        #endregion
    }
}
