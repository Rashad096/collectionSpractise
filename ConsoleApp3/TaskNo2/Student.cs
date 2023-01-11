using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNo2
{
    internal class Student
    {
        private static int _count;

        public Student()
        {
            _count++;
            No = _count;
        }
        public int No;
        public string FullName;
        Dictionary<string, int> _exams = new Dictionary<string, int>();

        public List<string> ExamSubjects
        {

            get
            {
                List<string> list = new List<string>();
                foreach (var item in _exams)
                    list.Add(item.Key);
                return list;
            }

        }



        public void AddExam(string ExamName, int ExamPoint)
        {

            if (!_exams.ContainsKey(ExamName))
                _exams.Add(ExamName, ExamPoint);

        }

        public int? GetExamresult(string ExamName)
        {
            if (_exams.ContainsKey(ExamName))
            {
                return _exams[ExamName];
            }
            return null;
        }

        public int GetAvarage()
        {
            int sum = 0;
            int result = 0;
            if (_exams.Count > 0)
            {
                foreach (var item in _exams)
                {
                    sum += item.Value;
                    result = sum / _exams.Count;
                }
            }
            return result;

        }
    }
}
