using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Forms;

namespace _1010alfa
{
    class Sound
    {
        public void play(String name)
        {            
            MediaPlayer player = new MediaPlayer();
            
            player.Open(new Uri(Application.StartupPath + "\\Sound\\" +  name, UriKind.Absolute));
            player.Play();
                        
        }
    }
}
