using System;
using System.Collections.Generic;
using System.Text;

namespace Asignature
{
    class Teacher
    {
        string nif;
        string name;
        string specialty;



        public Teacher(string nif, string name, string specialty)
        {
            this.nif = nif;
            this.name = name;
            this.specialty = specialty;
        }
        public void PutMark(Student qualified)
        {
            Random r1 = new Random();
            int random1 = r1.Next(0, 11);
            int random2 = r1.Next(0, 11);
            int random3 = r1.Next(0, 11);
            Subject S1 = qualified.GetS1();
            S1.SetCalif(random1);
            Subject S2 = qualified.GetS2();
            S2.SetCalif(random2);
            Subject S3 = qualified.GetS3();
            S3.SetCalif(random3);

        }
        public double AverageScore(Student student)
        {
            Subject S1 = student.GetS1();
            Subject S2 = student.GetS2();
            Subject S3 = student.GetS3();
            double cal1 = S1.GetCalif();
            double cal2 = S2.GetCalif();
            double cal3 = S3.GetCalif();
            return (cal1 + cal2 + cal3) / 3;
        }
    }
    
}
