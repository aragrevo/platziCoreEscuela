# Notas

## Clean Code
+ Métodos empiezan en Mayúsculas
+ /// para comentar lo que hace un método especifico.
+ `'` se usa para tipo char
+ `4.5f` crear float se agrega `f` al final.

## Atajos
+ `ctor` => Constructor
+ `prop` => Propiedades Get & Set
+ `ctrl + .` => Definiciones

## Apuntes
`Predicate` => Callback? `delegate` => retorna bool, recibe un Tipo Genérico  
`static class` => No permite crear instancias, la clase en sí funciona como un Objeto.  
``abstract`` => para que dicha clase solamente pueda ser heredada, pero nunca instanciada  
``sealed`` => 'Sellada' permite generar instancias de la clase, pero no permite heredarla.  
> **Polimorfismo**  
En polimorfismo un objeto hijo que hereda de una clase padre puede ser tratado como un objeto padre, pero al ser convertido en objeto padre ya no se podrá acceder a los atributos del objeto hijo. Por otro lado, un objeto padre no puede tratarse como un objeto hijo a menos que el objeto padre estuviera guardando un objeto hijo

``is`` para verificar si un objeto es de un tipo en específico.  
``as`` para tratar un objeto como un tipo específico, en caso de no poder convertir el objeto entonces va a asignar un valor null.

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