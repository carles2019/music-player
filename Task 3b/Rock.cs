using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3b
{
    public class Rock : Song
    {
        public string rockSound { get; set; }
        public Rock(string newTitle, string newAuthor)
            : base(newTitle, newAuthor)
        {
            this.rockSound = "let rockkk bum bummbummm";
        }

        public override string Play()
        {
            return this.title + " * " + this.author + "\n*rock rhythm* " + this.rockSound;
        }


    }

    public class AlternativeRock : Rock
    {
        public string alternativeRockSound { get; set; }
        public AlternativeRock(string newTitle, string newAuthor)
            : base(newTitle, newAuthor)

        {
            this.alternativeRockSound = "brummm yooo";
        }
        public override string Play()
        {
            return base.Play() + "\n*alternative rock rhythm:* " + this.alternativeRockSound;
        }

    }

    public class HeavyMetalRock : Rock
    {
        public string heavyMetalRockSound { get; set; }
        public HeavyMetalRock(string newTitle, string newAuthor)
            : base(newTitle, newAuthor)
        {
            this.heavyMetalRockSound = "BOOOOOOM!!!!";
        }

        public override string Play()
        {
            return base.Play() + "\n*Heavy metal ryhmthm* " + this.heavyMetalRockSound;
        }

    }

    public class IndieAlternativeRock : AlternativeRock
    {
        public string indieAlternativeRockSound { get; private set; }
        public IndieAlternativeRock(string newTitle, string newAuthor)
            : base(newTitle, newAuthor)
        {
            this.indieAlternativeRockSound = "lalala AAAAAA abababa";
        }

        public override string Play()
        {
            return base.Play() + "\n*Indie alternative rock ryhthm* " + this.indieAlternativeRockSound;
        }
    }

    public class DoomMetalRock: HeavyMetalRock
    {
        public string doomMetalRockSound { get; set; }
        public DoomMetalRock(string newTitle, string newAuthor)
            :base(newTitle, newAuthor)
        {
            this.doomMetalRockSound = "bang bang bang BUM";
        }

        public override string Play()
        {
            return base.Play()+"\n*Doom metal rhythm* "+this.doomMetalRockSound;
        }
    }
}
