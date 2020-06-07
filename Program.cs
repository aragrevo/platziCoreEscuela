using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();

            Printer.WriteTitle("BIENVENIDOS");
            WriteLine(engine.Escuela);
            ImprimirCursos(engine.Escuela);

            var listaObjetos = engine.GetObjetosEscuela(
                out int conteoEvaluaciones,
                out int conteoCursos,
                out int conteoAsignaturas,
                out int conteoAlumnos
            );

            var listaLugar = from obj in listaObjetos
                             where obj is ILugar
                             select (ILugar)obj;

            var dicti = engine.GetDiccionarioObjetos();
            engine.ImprimirDiccionario(dicti, true);
        }



        private static void ImprimirCursos(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }
    }
}
