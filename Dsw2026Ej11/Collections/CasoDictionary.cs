using Dsw2026Ej11.Domain;
using System.Collections.Generic;

namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    private Dictionary<int, Alumno> _alumnosDiccionario = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        _alumnosDiccionario.Add(alumno.Id, alumno);
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        if (_alumnosDiccionario.ContainsKey(legajo))
        {
            return _alumnosDiccionario[legajo];
        }
        return null;
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return _alumnosDiccionario;
    }

    public bool EliminarAlumno(int legajo)
    {
        return _alumnosDiccionario.Remove(legajo);
    }
} 
