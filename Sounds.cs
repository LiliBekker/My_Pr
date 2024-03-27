using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoicedAndDeafConsonants
{
    class Sounds
    {
        public string sound { get; private set; }
        public string scoring { get; private set; }
        public bool sonority { get; private set; }

        public Sounds(string sound, string scoring, bool sonority)
        {
            sound = this.sound;
            scoring = this.scoring;
            sonority = this.sonority;
        }

        public override string ToString()
        {
            return sound;
        }
    }
}
