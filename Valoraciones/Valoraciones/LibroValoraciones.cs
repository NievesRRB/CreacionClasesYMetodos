using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibroValoraciones
    {
        //Creo mi listado de valoraciones, donde se van a almacenar las valoraciones
        List<float> valoraciones = new List<float>();

        //Declaro mi constructor. Todas las clases tienen un constructor.
        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }

        //A este metodo lo llamo al inicializar mi programa, con lo q vo ya tener un objeto de esta clase inicializado
        //sino no podre trabajar con el
        //Lo declaro public para poder acceder desde otras clases y void=vacio, q no me va a devolver nada, pero en este
        //caso, necesito devolver un valor y cuando se devuelve valores necesito devolverlos del mismo tipo del q 
        //declaro mi funcion. Para devolver un valor necesito saber el tipo del metodo q voy a declarar
        //Como voy a hacer los calculos y voy a estar trabajando con la clase CalcularValoraciones, voy a devolver 
        //un objeto de ese tipo, es decir el tipo del metodo con el q voy a trabajar
        //Tendre que devolver un valor del tipo CalcularValoraciones, para lo q prevamente debere de crearme una variable 
        //del tipo de mi clase CalcularValoraciones
        public CalcularValoraciones PublicarValoraciones ()
        {
            //Rapidamente podria devolverle mi constructor sin necesidad de declarar variable
            //return new CalcularValoraciones(); ;

            //Otra manera que podria hacer seria declararme un objeto/una variable llamando a mi constructor y devolver esa
            //variable
            //Defino mi clase, indicando de q tipo va a ser mi objeto "calculo" y llamo al constructor del mismo tipo 
            //de la clase, almacenando mi espacio en memoria y creando mi objeto
            CalcularValoraciones calculo = new CalcularValoraciones();

            //En pseudocódigo para yo calcular mi promedio seria 
            //calculo.promedioValoracion = sumaValoraciones / List<Milistadevaloraciones> valoraciones.Count;
            //Declaro mi variable sumaValoraciones
            float sumaValoraciones = 0;

            //Ahora recorro mi lista de valoraciones mediante un bucle y las voy almacenando en mi variable 
            //Para cada valoracion en mi lista de valoraciones la voy almacenando en mi sumaValoraciones
            foreach (float valoracion in valoraciones)
            {
                //Trabajo con el objeto que cree mas arriba "calculo", donde llamando a mi clase Math y haciendo uso 
                //del método Max, le paso 2 argumentos entre los q quiero q me calcule mi valoracion máxima
                //Al inicio mi valoracionMax estara a null, pero en el momento en q empiece a recorrer, me ira comparando
                //valoraciones
                calculo.valoracionMax = Math.Max(valoracion, calculo.valoracionMax);
                calculo.valoracionMin = Math.Min(valoracion, calculo.valoracionMin);
                sumaValoraciones += valoracion;
            }

            //Calculo mi promedio de valoraciones, llamando a mi miembro promedioValoracion
            calculo.promedioValoracion = sumaValoraciones / valoraciones.Count;

            //Por ultimo retorno mi objeto del tipo CalcularValoraciones
            return calculo;
        }
        
        //Declaramos metodos de mi clase
        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

        
    }
}
