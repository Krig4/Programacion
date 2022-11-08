using System;
using System.Collections.Generic;
using System.Text;

namespace Persona
{
    class Person
    {
        string name;
        int age;
        string dni;
        char sex;
        float heigth;
        float weigth;

        public Person()
        {
            this.dni = GenerateDNI();
            name = "";
            age = 0;
            sex = 'H';
            heigth = 0;
            weigth = 0;
        }
        public Person(string name, int age, char sex)
        {
            this.dni = GenerateDNI();
            this.name = name;
            this.age = age;
            this.sex = sex;
            heigth = 0;
            weigth = 0;
        }
        public Person(string name, int age, char sex, float heigth, float weigth)
        {
            this.name = name;
            this.age = age;
            this.dni = GenerateDNI();
            this.sex = sex;
            this.heigth = heigth;
            this.weigth = weigth;
        }
        public int CalculateIMC()
        {
            float imc = (weigth) / (heigth * heigth);
            if (imc < 20)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        public bool IsAdult()
        {
            return age >= 18;
        }
        public bool IsGender(char gender)
        {
            return gender == sex;
        }
        public string toString()
        {
            return name + ", " + sex + " de " + age + " años de edad, y con NIF: " + dni + " pesa " + weigth + " y mide " + heigth;
        }
        public string GetName() 
        {
            return name;
        }
        public void SetName(string name) 
        {
            this.name = name;
        }
        public int GetAge() 
        {
            return age;
        }
        public void SetAge(int age) 
        {
            this.age = age;
        }                
        public char GetSex() 
        {
            return sex;
        }

        public void SetSex(char sex) 
        {
            this.sex = sex;
        }

        public float GetHeigth() 
        {
            return heigth;
        }
        public void SetHeigth(float heigth) 
        {
            this.heigth = heigth;
        }
        public float GetWeigth()
        {
            return weigth;
        }
        public void SetWeigth(float weigth) 
        {
            this.weigth = weigth;
        }

        public string GenerateDNI()
        {
            Random rand = new Random();
            int numberDNI = rand.Next(0, 100000000);
            char leter = 'A';
            switch (numberDNI % 23)
            {
                case 0: leter = 'T'; break;
                case 1: leter = 'R'; break;
                case 2: leter = 'W'; break;
                case 3: leter = 'A'; break;
                case 4: leter = 'G'; break;
                case 5: leter = 'M'; break;
                case 6: leter = 'Y'; break;
                case 7: leter = '-'; break;
                case 8: leter = 'T'; break;
                case 9: leter = 'T'; break;
                case 10: leter = 'T'; break;
                case 11: leter = 'T'; break;
                case 12: leter = 'T'; break;
                case 13: leter = 'T'; break;
                case 14: leter = 'T'; break;
                case 15: leter = 'T'; break;
                case 16: leter = 'T'; break;
                case 17: leter = 'T'; break;
                case 18: leter = 'T'; break;
                case 19: leter = 'T'; break;
                case 20: leter = 'T'; break;
                case 21: leter = 'T'; break;
                case 22: leter = 'T'; break;
            }
            return numberDNI.ToString() + leter.ToString();
        }

    }
}
