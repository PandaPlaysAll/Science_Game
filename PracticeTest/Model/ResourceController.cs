using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PracticeTest
{
    public static class ResourceController
    {
        private static SoundPlayer _player;
        
        static ResourceController() {
            _player = new SoundPlayer();
            _player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Music.wav";
            Extensible.IsPlaying = false;
        }

        public static void PlayMusic()
        {
            _player.Play();
            Extensible.IsPlaying = true;
        }

        public static void StopMusic()
        {
            _player.Stop();
            Extensible.IsPlaying = false;
        }

      
    }
}
