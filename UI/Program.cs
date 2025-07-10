using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

                //Crear el Originator
                Personaje personajeGanador = new Personaje(7, "Ganador");
                Personaje personajeObjetivo = new Personaje(8, "Objetivo");

                //Crear el Caretaker y pasarle el Originator
                Caretaker caretakerGanador = new Caretaker(personajeGanador);
                Caretaker caretakerObjetivo = new Caretaker(personajeObjetivo);

                //Establecer el Caretaker en la Persona
                personajeGanador.EstablecerCaretaker(caretakerGanador);
                personajeObjetivo.EstablecerCaretaker(caretakerObjetivo);

                //Estado inicial antes de iniciar la lucha cuerpo a cuerpo
                personajeGanador.MostrarEstado();
                personajeObjetivo.MostrarEstado();


                //Personaje objetivo le quita salud al ganador
                personajeObjetivo.DarGolpe(personajeGanador, TipoGolpe.Fuerte);
                personajeGanador.MostrarEstado();

                // Recibir golpes
                personajeGanador.DarGolpe(personajeObjetivo, TipoGolpe.Debil); // Golpe débil
                personajeObjetivo.MostrarEstado();
                personajeGanador.DarGolpe(personajeObjetivo, TipoGolpe.Intermedio); // Golpe intermedio
                personajeObjetivo.MostrarEstado();
                personajeGanador.DarGolpe(personajeObjetivo, TipoGolpe.Fuerte); // Golpe fuerte
                personajeObjetivo.MostrarEstado();

                // Recibir más golpes para activar la recuperación
                personajeGanador.DarGolpe(personajeObjetivo, TipoGolpe.Debil);
                personajeObjetivo.MostrarEstado();
                personajeGanador.DarGolpe(personajeObjetivo, TipoGolpe.Debil);  //Esto debería activar la recuperación
                personajeGanador.MostrarEstado(); // Debería mostrar la salud recuperada del personaje ganador
            }
        
    }
}
