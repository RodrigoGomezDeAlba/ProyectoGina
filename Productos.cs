using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGina
{
    public class Productos
    {

        public Productos(int id, string imagen, string descripcion, double precio, int existencia)
        {
            this.Id = id;
            this.Imagen = imagen;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Existencia = existencia;
        }

        private int id;
        private string imagen;
        private string descripcion;
        private double precio;
        private int existencia;

        public int Id { get => id; set => id = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencia { get => existencia; set => existencia = value; }
    }
}
