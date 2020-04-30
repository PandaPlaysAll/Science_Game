using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PracticeTest
{
    public class ResourceController
    {
        private SoundPlayer _player;
        public ResourceController() {
            _player = new SoundPlayer();
            _player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Music.wav";
        }

        public void PlayMusic()
        {
            _player.Play();
        }
        
        public void StopMusic()
        {
            _player.Stop();
        }
    }
}
