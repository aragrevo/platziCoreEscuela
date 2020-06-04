# Notas

##
+ ¿Cuál es el comando de consola para compilar una solución de .net core? => dotnet run
+ Respecto a las colecciones y los arreglos: => 
+ En el flujo del programa no es conveniente establecer validaciones para objetos nulos: => True
+ Ud es el arquitecto de software de una pequeña compañía de software => Arreglo
+ Se requiere guardar información de clientes en la aplicación Perfect Banking, => Variable contador

## Clean Code
+ Métodos empiezan en Mayúsculas
+ /// para comentar lo que hace un método especifico.
+ `'` se usa para tipo char

## Atajos
+ `ctor` => Constructor
+ `prop` => Propiedades Get & Set
+ `ctrl + .` => Definiciones

## Apuntes
`Predicate` => Callback? `delegate` => retorna bool, recibe un Tipo Genérico
`static class` => No permite crear instancias, la clase en sí funciona como un Objeto.

## Código
Agregar datos Lista
```cs
escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TiposJornada.Tarde });
escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TiposJornada.Tarde });
```

Agregar coleccion a Lista
```cs
var otrColeccion = new List<Curso>(){
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso() {Nombre = "501", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "501", Jornada = TiposJornada.Tarde}
            };
escuela.Cursos.AddRange(otrColeccion);

```
Agregar/Remover Objeto de Lista
```cs
Curso tmp = new Curso{Nombre = "101-Vacacional", Jornada = TipoJornada.Noche};
escuela.Cursos.Add(tmp);
escuela.Cursos.Remove(tmp);
```

Predicado
```cs
Predicate<Curso> miAlgoritmo = Predicado;
escuela.Cursos.RemoveAll(miAlgoritmo);
private static bool Predicado(Curso curobj)
{
    return curobj.Nombre == "301";
}
```

Delegado
```cs
escuela.Cursos.RemoveAll(delegate (Curso cur)
{
    return cur.Nombre == "301";
});
```

Lambda
```cs
escuela.Cursos.RemoveAll((cur) => cur.Nombre == "501");
```