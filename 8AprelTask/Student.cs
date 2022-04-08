using System;
using System.Collections.Generic;
using System.Text;

namespace _8AprelTask
{
    internal class Student
    {
        private static int _no;
        public Student()
        {
            _no++;
            this.No = _no;
        }
        public int No { get; }
        public string FullName { get; set; }
        public Dictionary<string, int> _exams = new Dictionary<string, int>();
        public void AddExam(string examName,int point)
        {
            if (!_exams.ContainsKey(examName))
            {
                _exams.Add(examName, point);
            }
        }
        public int GetExamResult(string examName)
        {
            if (_exams.ContainsKey(examName))
            {
                return _exams[examName];
            }
            else
            {
                return -1;
            }
        }
        public int GetExamAvg()
        {
            if (_exams.Count == 0)
            {
                return -1;
            }
            int avgSum = 0;
            foreach (var item in _exams)
            {
                avgSum += item.Value;
            }
            return (avgSum)/_exams.Count;
        }
    }
}
