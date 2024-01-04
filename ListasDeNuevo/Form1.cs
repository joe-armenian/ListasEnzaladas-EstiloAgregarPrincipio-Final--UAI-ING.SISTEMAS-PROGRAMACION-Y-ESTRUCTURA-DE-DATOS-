using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDeNuevo
{
    public partial class Form1 : Form
    {

        ListaEnlazada _lista = new ListaEnlazada();

        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarItemAlista(Nodo unNodo)
        {
            if (unNodo!=null)
            {
                lstListaEnlazada.Items.Add(unNodo.Nombre);
                AgregarItemAlista(unNodo.Siguiente);

            }
        }

        public void MostrarLista() //mantiene la lista.
        {
            lstListaEnlazada.Items.Clear();

            if (_lista.Inicio != null) 
            {

               AgregarItemAlista(_lista.Inicio);
             }

        }    
         private void cmdAgregarPrincipio_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length > 0)
            {
                Nodo unNuevoNodo= new Nodo();   
                unNuevoNodo.Nombre=txtNombreNodo.Text;
                _lista.AgregarAlPrincipio(unNuevoNodo);
                MostrarLista();


            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre!");
            }
        }

   

        private void cmdAgregarFinal_Click(object sender, EventArgs e)
        {
       
            {
                if (txtNombreNodo.Text.Length > 0)
                {
                    Nodo unNuevoNodo = new Nodo();
                    unNuevoNodo.Nombre = txtNombreNodo.Text;
                    _lista.AgregarAlFinal(unNuevoNodo);
                    MostrarLista();

                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre!");
                }

            }
        }
    
    
    
    }
}
