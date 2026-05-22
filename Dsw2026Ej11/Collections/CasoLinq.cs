using Dsw2026Ej11.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Dsw2026Ej11.Collections;

public class CasoLinq
{

    private List<Libro> libros = Libro.CrearLista();

    public Libro GetPrimero()
    {
        return libros.First();
    }

    public Libro GetUltimo()
    {
        return libros.Last();
    }


    public decimal GetTotalPrecios()
    {
        return libros.Sum(l => l.Precio);
    }
    public decimal GetPromedioPrecios()
    {
        return libros.Average(l => l.Precio);
    }

    public List<Libro> GetListById()
    {
        return libros.Where(l => l.Id > 15).ToList();
    }

        public List<string> GetLibros()
    {
        return libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();
    }    
    public Libro GetMayorPrecio()
    {
        decimal maxPrecio = libros.Max(l => l.Precio);
        return libros.First(l => l.Precio == maxPrecio);
    }
    public Libro GetMenorPrecio()
    {
        decimal minPrecio = libros.Min(l => l.Precio);
        return libros.First(l => l.Precio == minPrecio);
    }

    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = libros.Average(l => l.Precio);
        return libros.Where(l => l.Precio > promedio).ToList();
    }

    public List<Libro> GetLibrosOrdenados()
    {
        return libros.OrderByDescending(l => l.Titulo).ToList();
    }
}
