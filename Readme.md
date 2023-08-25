## Ejercicio 2 

- ¿Cuál de estas relaciones considera que se realiza por composición y cuál por agregación? 

Relacion Cliente-Pedido : Composición
Relacion Pedido-Cadete : Agregación
Relacion Cadete-Cadeteria : Agregación

- ¿Qué métodos considera que debería tener la clase Cadetería y la clase Cadete?

Metodos Clase Cadete :
cantidadPedidos()
jornalACobrar()
verDatosCadete()
agregarPedido()
eliminarPedido()

Metodos Clase Cadeteria :
cantidadCadetes()
cantidadPedidos()
totalRecaudado()

- Teniendo en cuenta los principios de abstracción y ocultamiento, que atributos,
propiedades y métodos deberían ser públicos y cuáles privados.


- Atributo 
  Cliente : Publico

  Propiedades
  Nombre : publico
  Direccion : publico
  Telefono : publico
  DatosReferenciaDireccion : publico?

- Atributo
  Pedido : 

  Propiedades
  Nro :
  Obs :
  Cliente :
  Estado :

  Metodos
  VerDireccionCliente() :
  VerDatosCliente() : 

- Atributo
  Cadete :

 Propiedades
  Id :
  Nombre :
  Direccion :
  Telefono :
  ListadoPedidos :

  Metodos
  JornalACobrar() : 

- Atributo
  Cadeteria : 

  Propiedades
  Nombre :
  Telefono :
  ListadoCadetes :
