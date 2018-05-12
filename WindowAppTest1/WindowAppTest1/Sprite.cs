using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
    public class Sprite
    {
        private int framecount;
        private int Frame;

        private float TotalElapsed;
        private float TimePerFrame;
        public float Rotation, Scale, Depth;

        private bool Paused;

        private string source;

        //vectors? Textures?

        public Sprite()
        {
            Frame = 0;
        }
        ~Sprite()
        {

        }
        public Sprite(string sourceLoc)
        {
            Frame = 0;
            source = sourceLoc;
        }
        public void Load(string asset, int frameCount, int framesPerSecond) // some sort of manager needed
        {
            framecount = frameCount;
            source = asset;
            TimePerFrame = (float)1 / framesPerSecond;

        }

    }
}
