using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiWiiWinGUI
{
    internal class NeonSoundhandler
    {
        public static void PlayerBeepSound()
        {
            System.IO.Stream str = Properties.Resources.BEEP;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
         
            snd.Play();
        }
    }
}
