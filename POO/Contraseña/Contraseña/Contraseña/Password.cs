using System;
using System.Collections.Generic;
using System.Text;

namespace Contraseña
{
    class Password
    {
        int length;
        string password;
        public Password()
        {
            length = 8;
            GeneratePassword();
        }
        public Password(int length)
        {
            this.length = length;
        }
        public string GetPassword()
        {
            return password;
        }
        public int GetLength()
        {
            return length;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public void GeneratePassword()
        {
            //Generar contraseña con la longitud correspondiente
            Random rand = new Random();
            password = "";
            for (int counter = 1; counter <= length; counter = counter + 1)
            {
                int number = rand.Next(42, 123);
                char c = Convert.ToChar(number);
                password = password + c;
            }          
            
        }
        public bool IsStrong()
        {
            //Es fuerte +2 mayúsculas, +1 minúscula, +2 números
            int mayus = 0;
            int minus = 0;
            int numbers = 0;
            int special = 0;
            for (int position = 0; position < length; position = position + 1)
            {
                if (password[position] <= '0' && password[position] <= '9')
                {
                    numbers = numbers + 1;
                }
                else
                {
                    if (password[position] <= 'a' && password[position] <= 'z')
                    {
                        minus = minus + 1;
                    }
                    else
                    {
                        if (password[position] <= 'A' && password[position] <= 'Z')
                        {
                            mayus = mayus + 1;
                        }
                        else
                        {
                            special = special + 1;
                        }
                    }
                }
            }
            bool result = (mayus > 2) && (minus > 1) && (numbers > 2);
            return result;
            
        }
    }
}
