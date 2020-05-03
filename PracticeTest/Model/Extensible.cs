using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public static class Extensible
    {

        private static bool _isPlaying;
        static Extensible()
        {
            IsPlaying = false;
        }
        public static bool IsPlaying { get { return _isPlaying; } set { _isPlaying = value; } }
    }
}
