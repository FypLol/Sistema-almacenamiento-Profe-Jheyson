using System;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    //  Clase Nodo
    public class Nodo
    {
        public string NombreDestinatario;
        public string Telefono;
        public string Tamaño;
        public string DNI;
        public Nodo Siguiente;
    }

    //  Clase Cola Registro y Entrega
    public class ColaPaquetes
    {
        private Nodo inicio;
        private Nodo fin;

        // Encolar
        public void Encolar(string nombre, string telefono, string tamaño, string dni)
        {
            Nodo nuevo = new Nodo();
            nuevo.NombreDestinatario = nombre;
            nuevo.Telefono = telefono;
            nuevo.Tamaño = tamaño;
            nuevo.DNI = dni;

            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.Siguiente = nuevo;
                fin = nuevo;
            }
        }

        // Desencolar
        public Nodo Desencolar()
        {
            if (inicio == null)
                return null;

            Nodo temp = inicio;
            inicio = inicio.Siguiente;
            return temp;
        }

        // Mostrar contenido para DataGridView
        public void MostrarEnGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            Nodo actual = inicio;
            while (actual != null)
            {
                dgv.Rows.Add(actual.NombreDestinatario, actual.Telefono, actual.Tamaño, actual.DNI);
                actual = actual.Siguiente;
            }
        }

        public bool EstaVacia()
        {
            return inicio == null;
        }
    }

    //  Clase Pila (Historial de entregas)
    public class PilaHistorial
    {
        private Nodo tope;

        public void Apilar(Nodo paquete)
        {
            paquete.Siguiente = tope;
            tope = paquete;
        }

        public Nodo Desapilar()
        {
            if (tope == null)
                return null;

            Nodo temp = tope;
            tope = tope.Siguiente;
            return temp;
        }

        public void MostrarEnGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            Nodo actual = tope;
            while (actual != null)
            {
                dgv.Rows.Add(actual.NombreDestinatario, actual.Telefono, actual.Tamaño, actual.DNI);
                actual = actual.Siguiente;
            }
        }

        public bool EstaVacia()
        {
            return tope == null;
        }
    }
}
