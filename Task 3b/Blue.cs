using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3b
{
    public class Blue: Song
    {
        public string blueSound { get; set; }
        public Blue(string newTitle, string newAuthor)
            :base(newTitle,newAuthor)
        {
            this.blueSound = "lo lollololol";
        }

        public override string Play()
        {
            return this.title + " * " + this.author + "\n*blue rhythm* " + this.blueSound;
        }

        
    }
    public class JazzBlue: Blue
    {
        public string jazzBlueSound { get; set; }
        public JazzBlue(string newTitle, string newAuthor)
            :base(newTitle,newAuthor)
        {
            this.jazzBlueSound = "yolololololo0";

        }
        public override string Play()
        {
            return base.Play()+"\n*blue jazz rhythm* "+this.jazzBlueSound;
        }

    }

    public class BlueRock: Blue
    {
        public string blueRockSound { get; set; }
        public BlueRock(string newTitle, string newAuthor)
            :base(newTitle, newAuthor)
        {
            this.blueRockSound = "BOOOOOM LOLOLOLOL";
        }

        public override string Play()
        {
            return base.Play()+"\n*Blue rock rhythm* "+this.blueSound;
        }
    }

    public class AccoustisBlue: Blue
    {
        public string accousticBlueSound { get; set; }
        public AccoustisBlue(string newTitle, string newAuthor)
            :base(newTitle,newAuthor)
        {
            this.accousticBlueSound = "tun tun tun lalala";
        }
        public override string Play()
        {
            return base.Play()+"\n*Accoustic blue ryhthm* "+this.accousticBlueSound;
        }
    }

    
}
