using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    internal class Classroom
    {
        public List<Person> PersonList = new List<Person>();
        public List<int> YearList = new List<int>();
        public List<double> GradeList = new List<double>();
        public List<string> NameList = new List<string>();

        public void AddPerson(Person persons)
        {
            PersonList.Add(persons);
            YearList.Add(persons.birthyear);

        }
        public string ShowPerson()
        {
            string results = "";
            foreach (var persons in PersonList)
            {
                results += persons.name + "\r\n";
            }
            return results;
        }
        public int ShowAllAge()
        {

            return YearList.Sum();
        }

        public void SetGrade()
        {
            foreach (var person in PersonList)
            {
                GradeList.Add(person.grade);
                NameList.Add(person.name);
            }
        }
        public double ShowMaxGrade()
        {
            return GradeList.Max();
        }
        public double ShowMinGrade()
        {
            return GradeList.Min();
        }
        public string ShowNameMaxGrade()
        {
            return NameList[GradeList.IndexOf(GradeList.Max())];
        }
        public string ShowNameMinGrade()
        {
            return NameList[GradeList.IndexOf(GradeList.Min())];
        }
        public string ShowAvgnGrade()
        {
            return GradeList.Average().ToString();
        }
    }
}
