using System;
using System.Collections.Generic;
using System.Text;

namespace Asignature
{
    class Subject
    {
        //2 Atributos 1 int(Identificador) y otro float(calif), constructor parametro int y  un set para calificación
        int identificator;
        float calification;

        public Subject(int _identificator)
        {
            identificator = _identificator;
            calification = 0;
        }
        public int GetIdent()
        {
            return identificator;
        }
        public float GetCalif()
        {
            return calification;
        }
        public void SetCalif(float _califitacion)
        {
            calification = _califitacion;
        }
    }
}
