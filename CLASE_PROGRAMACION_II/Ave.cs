﻿

namespace CLASE_PROGRAMACION_II
{
    public class Ave
    {
        public string? Nombre {  get; set; }
        public string? Especie { get; set; }
        public string? Color { get; set; }
        public double Tamano { get; set; }

        public string? Habitat {  get; set; }


        public void Imprimir() 
        {
            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"Especia:{Especie}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Tamano:{Tamano} cm");
            Console.WriteLine($"Habitat:{Habitat}");
        }

    }
}
