using System;
using FacadePattern.HomeTheater;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var amp = new Amplifier();
            var tuner = new Tuner();
            var dvd = new DvdPlayer();
            var cd = new CdPlayer();
            var projector = new Projector();
            var screen = new Screen();
            var lights = new TheaterLights();
            var popper = new PopcornPopper();

            var homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, lights, screen, popper);

            homeTheater.WatchMovie("Raider of the Lost Ark");
            homeTheater.EndMovie();
        }
    }
}
