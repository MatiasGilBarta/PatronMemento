# Patrón Memento en C#

## 📌 Descripción
Este proyecto implementa el patrón de diseño **Memento**, que permite guardar y restaurar el estado anterior de un objeto sin violar el principio de encapsulamiento.

Este patrón es útil cuando se necesita implementar funcionalidades como deshacer (undo), checkpoints o historial de cambios.

En este caso tiene una condicion que al encadenar 5 golpes ininterrumpidos, se restaura el estado salud al estado previo.

El ejemplo fue desarrollado como parte de una práctica personal sobre patrones de diseño en C#.

## 🛠️ Tecnologías utilizadas
- C#
- .NET (Consola)
- Visual Studio

## ▶️ Cómo ejecutar
1. Cloná este repositorio o descargalo como ZIP.
2. Abrí el proyecto en Visual Studio.
3. Ejecutá el archivo `Program.cs`.
4. Observá la salida de la consola.

## 📤 Ejemplo de salida esperada
```plaintext
Ganador, 100, 7
Objetivo, 100, 8
Nombre: Ganador, Velocidad: 7, Salud: 100
Nombre: Objetivo, Velocidad: 8, Salud: 100
Nombre: Ganador, Velocidad: 7, Salud: 80
Nombre: Objetivo, Velocidad: 8, Salud: 95
Nombre: Objetivo, Velocidad: 8, Salud: 85
Nombre: Objetivo, Velocidad: 8, Salud: 65
Nombre: Objetivo, Velocidad: 8, Salud: 60
Salud recuperada a: 100
Nombre: Ganador, Velocidad: 7, Salud: 100
