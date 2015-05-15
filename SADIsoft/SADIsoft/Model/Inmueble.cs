using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SADI.Model
{
    public class Inmueble
    {
        public int PropietarioId { set; get; }
        public Direccion Direccion { get; set; }
        public bool Tipo { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public int Depositos { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Niveles { get; set; }
        public bool TipoInmueble {get; set;}
        public bool Sotano { get; set; }
        public bool Piscina { get; set; }
        public bool Marquesina { get; set; }
        public int Capacidad { get; set; }
        public string Comentarios { get; set; }
        public string Foto1 { get; set; }
        public string Foto2 { get; set; }
        public string Foto3 { get; set; }
        public string Foto4 { get; set; }
        public int Habitaciones { get; set; }
        public int Banos { get; set; }

        public Inmueble(int propietarioId, Direccion direccion, bool tipo, decimal precioAlquiler, int depositos, decimal precioVenta, int niveles, bool tipoInmueble, bool sotano, bool piscina, bool marquesina, int capacidad, string comentarios, string foto1, string foto2, string foto3, string foto4, int habitaciones, int banos)
        {
            PropietarioId = propietarioId;
            Direccion = direccion;
            Tipo = tipo;
            PrecioAlquiler = precioAlquiler;
            Depositos = depositos;
            PrecioVenta = precioVenta;
            Niveles = niveles;
            TipoInmueble = tipoInmueble;
            Sotano = sotano;
            Piscina = piscina;
            Marquesina = marquesina;
            Capacidad = capacidad;
            Comentarios = comentarios;
            Foto1 = foto1;
            Foto2 = foto2;
            Foto3 = foto3;
            Foto4 = foto4;
            Habitaciones = habitaciones;
            Banos = banos;
        }
    }
}
