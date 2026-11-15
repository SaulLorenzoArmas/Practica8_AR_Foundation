
# Practica8_AR_Foundation

En esta práctica se ha desarrollado un minijuego de Realidad Aumentada (AR) utilizando el motor Unity y el framework AR Foundation. En concreto, el proyecto se ha configurado y compilado para dispositivos Apple, haciendo uso de **ARKit** .

El primer paso del desarrollo consistió en adaptar el proyecto base. El tutorial y el código original (Codelab) estaban diseñados principalmente para ser usado en el entorno de trabajo de Google (Android/ARCore). Por lo que, para poder probarlo en los dispositivos disponibles, con el sistema IOS, hubo que reconfigurar el proyecto, instalando los paquetes correspondientes de ARKit y prepararando el entorno de compilación en macOS (Xcode).

Partiendo de ese juego base, donde el coche solo recogía paquetes, se desarrollo el juego final. La mecánica principal de este último consiste en que, al recoger un paquete, el jugador suma 1 punto, pero al chocar o al ser atacado por una araña, se resta 1 punto. 

Para implementar la araña, se siguió exactamente la misma idea y estructura que la del paquete. Se duplicó su funcionalidad base (Prefabs y Spawners) y lo que se cambió fue, el objeto 3D, ajustando su collider y asignándole una etiqueta (arana) nueva para diferenciarla del regalo.

Por último, la lógica de los impactos se centro en el script `CarBehaviour` del vehículo. En este, se programó el evento de colisión (`OnTriggerEnter`). Al detectar un choque, el coche comprueba la etiqueta del objeto ("Paquete" o "Arana"), se comunica con la cámara principal (que representa al personaje) para actualizar los puntos en pantalla, y destruye el objeto con el que ha chocado (apagando su colisión para evitar bugs de puntuación múltiple).

<img src="imagenes/video_coche_gif.gif" width="80%" alt="Descripción del GIF">
