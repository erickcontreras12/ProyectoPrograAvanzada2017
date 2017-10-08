Documentación Proyecto SisLey
-----------------------------
-----------------------------

Introducción
------------

El sistema SysLey consiste en un programa capaz de realizar para acciones relacionadas con el control de leyes y reglamentos del país de Goathemala. Con el objetivo de brindar una mejor organización a los diputados en cuanto a las leyes del país y así lograr que  los votos en el hemiciclo parlamentario sean más eficientes. Para ello se cuenta con un sistema que guarda leyes y reglamentos así como usuarios y lo ubica en un grupo de usuarios, tambien es capaz de realizar préstamos de leyes(lotes ley+reglamentos) o reglamentos a  determinados usuarios de ciertos grupos de usuarios, esto con el fin de que los usuarios tengan acceso a las leyes y reglamentos, en caso de que la ley que desean no este disponible estarán en una lista de espera para recibir su ley cuando esta este disponible. Por lo tanto SysLey es una manera más eficiente de controlar las leyes y poder concerlas mejor para relalizar un voto adecuado en el hemicilo parlamentario.

Organización de Clases
----------------------

1.Grupo Usuarios: guarda a todos los usuarios que pertenecen a un mismo grupo.
2.Usuarios: guarda a los usuarios con sus propiedades.
3.Reglamentos: guarda los reglamentos de determinado ley.
4.Ley: almacena de todos los reglamentos de la ley.
5.Leyes: Almacena todas las leyes y sus copias.
6.Pila: Almacena las copias de las leyes y los reglamentos.
7.Prestamos por lote: Guarda a los usuarios que pidieron un lote de prestamos.
8.Prestamos: Guarda a los usuarios que pidieron un reglamento.
9.Cola: es la lista de espera de los préstamos que no se dieron por falta de disponibilidad de la ley o reglamento.

