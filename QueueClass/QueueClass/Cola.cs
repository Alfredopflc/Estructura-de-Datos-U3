using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    public class Cola
    {
        private ArrayList pcola;
        public Cola()
        {
            pcola = new ArrayList();
        }

        public void EnQueue(object item)
        { 
            //Añade objeto de entrada al ArrayList
            //El objeto puede ser cualquier tipo de dato
            pcola.Add(item);
        }

        public void DeQueue()
        {
            //Elimina la posicion 0 del ArrayList
            pcola.RemoveAt(0);
        }

        public object Peek()
        {
            //Visualiza el elemento 0
            //pero en la mente de Jesus es el 1 :v
            return pcola[0];
        }

        public void ClearQueue()
        {
            //Limpia la Cola
            pcola.Clear();
        }

        public int Count ()
        {
            //Regresa la cantidad de elementos de la cola 
            return pcola.Count;
        }

    }
}