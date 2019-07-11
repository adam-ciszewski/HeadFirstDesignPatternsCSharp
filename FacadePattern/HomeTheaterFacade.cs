using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.HomeTheater;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;
        private Projector _projector;
        private TheaterLights _theaterLights;
        private Screen _screen;
        private PopcornPopper _popcornPopper;

        public HomeTheaterFacade(
            Amplifier amplifier,
            Tuner tuner,
            DvdPlayer dvdPlayer,
            CdPlayer cdPlayer,
            Projector projector, 
            TheaterLights theaterLights,
            Screen screen, 
            PopcornPopper popcornPopper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _theaterLights = theaterLights;
            _screen = screen;
            _popcornPopper = popcornPopper;
        }

        public void WatchMovie(String movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popcornPopper.On();
            _popcornPopper.Pop();
            _theaterLights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd(string);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.PlayMovie(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down.");
            _popcornPopper.Off();
            _theaterLights.Off();
            _screen.Up();
            _projector.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }
    }
}
