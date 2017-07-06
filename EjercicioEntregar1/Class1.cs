using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar1
{
    public class ClassDatos
    {
        public String texto
        {
            set;
            get;
        }
        public int entero1
        {
            set;
            get;
        }
        public int entero2
        {
            set;
            get;
        }
    }
    public class ClassMetodos
    {
        public String MetodoConcatenar(ClassDatos objeto)
        {
            return objeto.texto + objeto.entero1 + " y "+ objeto.entero2;
        }
    }
}
