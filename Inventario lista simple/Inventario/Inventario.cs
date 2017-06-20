using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        Producto inicio, temp;

        public Inventario()
        {
            inicio = temp = null;
        }
        
        public void Agregar(Producto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                //temp.siguiente = nuevo;
                Agregar(inicio, nuevo);
            }
            //temp = nuevo;
        }

        private void Agregar(Producto ultimo,Producto nuevo)
        {
            if (ultimo.siguiente == null)
            {
                ultimo.siguiente = nuevo;
            }
            else
            {
                Agregar(ultimo.siguiente,nuevo);
            }
        }

        public void Eliminar(int codigo)
        {
            if (inicio != null)
            {
                Producto actual, padre;
                padre = BuscarPadre(codigo);
                if (padre == temp)
                {
                    return;
                }
                if (padre == null)
                {
                    actual = inicio;
                    inicio = inicio.siguiente;
                    padre = inicio;
                }
                else
                {
                    actual = padre.siguiente;
                    padre.siguiente = actual.siguiente;
                }
                actual = null;
                if (padre == null || padre.siguiente == null)
                {
                    temp = padre;
                }
            }
        }

        private Producto BuscarPadre(int codigo)
        {
            Producto padre, actual;
            actual = inicio;
            padre = null;
            while (actual != null)
            {
                if (actual.regresaCodigo() == codigo)
                {
                    break;
                } 
                padre = actual;
                actual = actual.siguiente;
            }
            return padre;
        }

        public Producto Buscar(int codigo)
        {
            Producto actual = inicio;
            while (actual != null)
            {
                if (actual.regresaCodigo() == codigo)
                {
                    return actual;
                }
                actual = actual.siguiente;
            }
            return null;
        }

        public string Reporte()
        {
            string salida = "";
            if (inicio != null)
            {
                Producto actual = inicio;
                while (actual != null)
                {
                    salida += actual.ToString() +Environment.NewLine;
                    actual = actual.siguiente;
                }
            }
            return salida;
        }

        public void Insertar(Producto nuevo, int pos)
        {
            int posActual = 2;

            if (pos != 2)
            {
                while (inicio != null)
                {
                    if (posActual == pos)
                    {
                        if(inicio == null)
                        {
                            inicio.siguiente = nuevo;
                        }
                        else
                        {
                            nuevo.siguiente = inicio.siguiente;
                            inicio.siguiente = nuevo;
                        }                                               
                        break;
                    }
                    posActual++;
                    inicio = inicio.siguiente;
                }
            }
            else
            {
                inicio = nuevo;
            }
            
        }
    }
}


//Clase autoreferenciada
/*
 * Persona
 *  nombre : string
 *  edad : int
 *  padre: Persona
 *  Persona alguien, abuelo, capataz, JDS;
 *  alguien = new Persona("Hugo",10);
 *  JDS = new persona("Filemon",28);
 *  alguien.Padre = JDS;
 *  JDS.padre = new Persona("Nepomuceno",55);
 *  alguien.Padre.Padre.nombre;
 *  capataz = new Persona("Pefilo",83);
 *  abuelo = capataz;
 *  JDS.Padre.Padre = abuelo;
 *  abuelo = padre = new Persona("Romulo",100);
 *  JDS.padrex4 = new Persona("Astavacio",120);
 *  Persona otro = new Padre("Ponchio",79);
 *  JDS.padre = otro;
 *  
 *  Producto
 *      ------------------
 *      ------------------
 *      ------------------
 *      ------------------
 *      Siguiente:Producto;
 *  
 *  Inventario
 *     Inicio:Producto;
 *     Inventario()
 *      Inicio = null;
 *     Agregar(Producto nuevo)
 *      if(inicio == null)
 *      {
 *          inicio = nuevo;
 *      }
 *      else
 *      {
 *          Producto temp = inicio;
 *          While(temp.siguiente != null)
 *          {
 *              temp = temp.siguiente;
 *          }
 *          temp.siguiente = nuevo;
 *      }
 *      
 *      public string reporte()
 *      {
 *          string datos = " ";
 *          Producto t = inicio;
 *          while(t != null)
 *          {
 *              datos t = t.toString();
 *              t = t.siguiente;
 *          }
 *          return datos;
 *      }
 *      
 */

