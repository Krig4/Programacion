using System;
using System.Collections.Generic;
using System.Text;

namespace Asignature
{
    class Student
    {
        Subject S1;
        Subject S2;
        Subject S3;
        string name;
        int tuition;

        public Student(Subject S1, Subject S2, Subject S3, string name, int tuition)
        {
            this.S1 = S1;
            this.S2 = S2;
            this.S3 = S3;
            this.name = name;
            this.tuition = tuition;
        }
        public Subject GetS1()
        {
            return S1;
        }
        public Subject GetS2()
        {
            return S2;
        }
        public Subject GetS3()
        {
            return S3;
        }
        public string GetName()
        {
            return name;
        }
        public int GetTuition()
        {
            return tuition;
        }
    }
}
