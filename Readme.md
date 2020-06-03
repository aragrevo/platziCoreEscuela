# Notas

## Clean Code
+ Métodos empiezan en Mayúsculas
+ /// para comentar lo que hace un método especifico.

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