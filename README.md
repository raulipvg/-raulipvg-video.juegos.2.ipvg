# Trabajo 2 - Juego de persecución
## Descripción del Juego
Proyecto para la asignatura Taller de Videojuegos del Instituto Profesional Virginio Gómez. Consiste en generar un excenario con enemigos que perseguirán al protagonista. Él tendrá un tiempo definido de 30 segundos para llegar a una meta. Se evalúa el uso de herramientas UI, cambios de escena, compartir elementos entre escenas, uso de música y sonidos.
<br>La primera pantalla del juego pide el nombre del usuario y muestra un botón de continuar. La segunda pantalla es la pricipal y muestra las opciones de Iniciar partida, Configuración, Salir. En Iniciar Partida se cambia a la escena del juego.
- El protagonista pierde cuando se le acaba el tiempo y cuando es impactado 3 veces por algún enemigo. Luego, el juego cambia a la pantalla principal.
- El protagonista gana cuando llega a la meta. El juego muestra una pantalla de felicitaciones, muestra el nombre del usuario, los enemigos derrotados y el timepo utilizado.
- Los enemigos se mueven gracias a la IA de persecución.
---
La pantalla de Configuración permite modificar el volumen del sonido (disparos, sonido al acercarse a un botón, sonidos de game-over), y el volumen de la música (música de fondo). También, permite cambiar el nombre del usuario y la dificultad del juego.
- La dificultad del juego es la velocidad de movimiento de los enemigos, y está dada por la _velocidad inicial*(Mathf.Pow(10, dificultad+1=)_, donde dificultad tiene valores entre 0 y 2 (Fácil-Medio-Difícil), y la velocidad inicial es 70, es decir, 70 por una potencia de 10 entre 1 y 3.
- Cualquier modificación tendrá efecto inmediatamente en caso del sonido y música, con el botón volver se guardan los cambios de dificultad y nombre.

## Botones
- Flecha arriba/abajo: Mover el personaje adelante o atrás.
- Flechas izq/der: Girar el personaje a la izquierda o derecha.
- Barra espaciadora: disparar

## NOTA
- El menú se encuentra en "Escenario 0" y el juego en "Escenario 1".
- Para el escenario se utilizó el creado en el proyecto 1 [video.juegos.1.ipvg](https://github.com/raulipvg/video.juegos.1.ipvg/) escalado y con algunas modificaciones.
<br>Version Editor 2020.3.37f1
