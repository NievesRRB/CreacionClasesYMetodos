using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invoco al constructor para crear un objeto libro
            LibroValoraciones libro = new LibroValoraciones();

            //Asigno valoraciones a mi objeto libro, instanciando al metodo
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(5);

            //Construyo un objeto sobre la variable de tipo libro, creada inicialmente como un objeto de clase 
            libro = new LibroValoraciones();
            libro.AgregarValoracion(2);

            //Hay que tener cuidado cuando creamos una variable como un objeto de clase a cuando utilizo la variable para 
            //almacenar datos. 

            //Asigno valores de una variable a otra varible siempre y cuando sean del mismo tipo, ya q sino me da error
            //Con esta igualicion estoy compartiendo el mismo espacio de memoria, las mismas propiedades, los mismos métodos, ...
            LibroValoraciones libro2 = libro;

            //Lo q no podria hacer seria la siguiente conversion, ya q estoy asonsolonignando un entero a mi varible del tipo
            //LibroValoraciones
            //LibroValoraciones libro3 = 10;

            //Lo que si puedo hacer es llamar a mi metodo de AgregarValoracion 
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(3.7f);
            libro.AgregarValoracion(1.4f);
            libro.AgregarValoracion(9.5f);
            
            //Genero un total de todas mis valoraciones. Como datos necesito saber mi valoracion minima y mi valoracion
            //maxima y luego un promedio de mis valoraciones

            //Publico mis valoraciones. Recordamos que al ser un verbo suelen ser metodos, con lo q puedo indicar que 
            //publicar valoraciones puede ser una funcion de mi libro 
            //Creo mi variable del tipo de la clase CalcularValoraciones, donde almacenare mi objeto libro q llama al 
            //metodo de PublicarValoraciones
            CalcularValoraciones publicar = libro.PublicarValoraciones();

            //Escribo mi promedio de valoraciones llamando al miembro a traves de la variable publicar 
            //escribiendolo en consola 
            Console.WriteLine("La media de las valoraciones es: " + publicar.promedioValoracion);
            Console.WriteLine("La valoración máxima es: " + publicar.valoracionMax);
            Console.WriteLine("La valoración mínima es: " +publicar.valoracionMin);
            Console.ReadLine();

            //Ahora debo obtener mi valoracion minima y mi valoracion máxima que las obtendre de todas las valoraciones 
            //que yo tenga en mi lista y a partir de ellas sumar todas y dividirlas por el total de las valoraciones 
            //que tenga en mi lista. 
            //valoracionMinima
            //valoracionMaxima
            //promedioValoracion
        }
    }
}
