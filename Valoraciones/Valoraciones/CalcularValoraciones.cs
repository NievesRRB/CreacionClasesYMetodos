using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class CalcularValoraciones
    {
        //Lo primero que hago al crearme mi clase es crearme el constructor poniendo ctor+tabulador(2 veces) y me crea 
        //automáticamente el constructor 
        //El constructor es el unico metodo que yo puedo declarar sin ponerle void y q no me devuelva ningun parametro
        //Sino fuera un metodo constructor si que tendria q ponerle la palabra void sino devolviera nada
        public CalcularValoraciones()
        {
            //Si yo no inicializo mi variable valoracionMin, siempre me va a dar q mi valoracion minima es un 0
            //Le indico q mi valoracionMin es el maximo
            valoracionMin = float.MaxValue;
        }

        //Ahora declaro mis 3 miembros, me devuelve un decimal ya q mis valoraciones son del tipo float 
        // y los hago publicos ya q desde mi clase LibroValoraciones accedere a dichos miembros
        public float valoracionMax;
        public float valoracionMin;
        public float promedioValoracion;
    }
}
