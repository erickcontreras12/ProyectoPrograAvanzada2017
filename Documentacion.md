Documentación Proyecto SisLey
-----------------------------
-----------------------------

Introducción
------------

El sistema SysLey consiste en un programa capaz de realizar para acciones relacionadas con el control de leyes y reglamentos del país de Goathemala. Con el objetivo de brindar una mejor organización a los diputados en cuanto a las leyes del país y así lograr que  los votos en el hemiciclo parlamentario sean más eficientes. Para ello se cuenta con un sistema que guarda leyes y reglamentos así como usuarios y lo ubica en un grupo de usuarios, tambien es capaz de realizar préstamos de leyes(lotes ley+reglamentos) o reglamentos a  determinados usuarios de ciertos grupos de usuarios, esto con el fin de que los usuarios tengan acceso a las leyes y reglamentos, en caso de que la ley que desean no este disponible estarán en una lista de espera para recibir su ley cuando esta este disponible. Por lo tanto SysLey es una manera más eficiente de controlar las leyes y poder concerlas mejor para relalizar un voto adecuado en el hemicilo parlamentario.

Organización de Clases
----------------------

+ Grupo Usuarios: guarda a todos los usuarios que pertenecen a un mismo grupo.
+ Usuarios: guarda a los usuarios con sus propiedades.
+ Reglamentos: guarda los reglamentos de determinado ley.
+ Ley: almacena de todos los reglamentos de la ley.
+ Leyes: Almacena todas las leyes y sus copias.
+ Pila: Almacena las copias de las leyes y los reglamentos.
+ Prestamos: Almacena todas las propiedades contenidas en un prestamo.
+ Cola: es la lista de espera de los préstamos que no se dieron por falta de disponibilidad de la ley o reglamento.

Forms para implementar las clases
---------------------------------
# Form Inicial
El programa al compilar empieza en un pestaña que solo nos permite trasladarnos a las demás pestañas para poder ver los informes, realizar prestamos o devoluciones y entrar a la manipulación de datos.
![](https://image.ibb.co/jkQjWG/Form1.png)

## Datos
![](https://image.ibb.co/dcHnkb/Datos.png)

### Usuarios
![](https://image.ibb.co/nQcWBG/Usuarios.png)
#### Grupo Usuario
![](https://image.ibb.co/mfSWBG/SGrupo_Usuarios.png)
##### Crear
![](https://image.ibb.co/cB3hJw/CGrupo_Usuario.png)
##### Eliminar
![](https://image.ibb.co/nBRrBG/Eliminar_Grupo.png)


#### Usuario Individual
![](https://image.ibb.co/iHwPWG/SUsuarios.png)
##### Crear
![](https://image.ibb.co/mUvwdw/CUsuario.png)
##### Eliminar
![](https://image.ibb.co/nh7bdw/EUsuario.png)
##### Modificar
![](https://image.ibb.co/eqytQb/MUsuario.png)

### Leyes
![](https://image.ibb.co/gLeNJw/SLeyes.png)
#### Crear
![](https://image.ibb.co/jxqwdw/CLey.png)
#### Eliminar
![](https://image.ibb.co/jqytQb/ELey.png)
#### Modificar
![](https://image.ibb.co/fq4NJw/MLey.png)

### Reglamentos
![](https://image.ibb.co/bSD4WG/SReglamentos.png)
#### Crear
![](https://image.ibb.co/n7iSkb/CReglamento.png)
#### Eliminar
![](https://image.ibb.co/np3Gdw/EReglamento.png)
#### Modificar
![](https://image.ibb.co/nnWf5b/MReglamento.png)

## Prestamo/Devolución
![](https://image.ibb.co/cv0jWG/PrestDev.png)
### Prestamo indivual
![](https://image.ibb.co/gT405b/IPrestamo.png)
### Prestamo por lote
![](https://image.ibb.co/cOhnkb/LPrestamo.png)
### Devolución
![](https://image.ibb.co/bMtSkb/Devolucion.png)


## Informes
![](https://image.ibb.co/hqSbdw/Informe.png)










