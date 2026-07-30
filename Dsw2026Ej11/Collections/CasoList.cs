using Dsw2026Ej11.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Dsw2026Ej11.Collections;

public class CasoList
{
    
    private List<Alumno> _alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

   
    public List<Alumno> RetornarLista()
    {
        return _alumnos;
    }

   
    public Alumno BuscarAlumnoPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }

   
    public bool EliminarAlumno(Alumno alumno)
    {
        return _alumnos.Remove(alumno);
    }
    public void EliminarAlumnoEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _alumnos.Count)
        {
            _alumnos.RemoveAt(posicion);
        }
    }
}
