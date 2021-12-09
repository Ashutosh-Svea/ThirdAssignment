using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Swan : Bird
    {

        private double soundPitch;

        public double SoundPitch
        {
            get { return soundPitch; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid sound pitch entered.");
                else
                    soundPitch = value;
            }
        }

        public Swan(string name, double weight, int age, double wingSpan, double soundPitch) : base(name, weight, age, wingSpan)
        {
            SoundPitch = soundPitch;
        }

        public override string Stats()
        {
            return $"Swan Name: {Name} => Age: {Age}, Wingspan : {WingSpan}, Weight: {Weight}, Sound Pitch: {SoundPitch}";
        }
    }
}
