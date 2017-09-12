using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    public class Sprite
    {
        private int xpos, ypos;
        private int xlen, ylen;
        private int frameCount;
        public bool isOldFrame = false;
        public bool isNewFrame = true;
        public bool cancel = false;

        private string loc;

        public Sprite()
        {
            xpos = 0;
            xpos = 0;
            xlen = 64;
            ylen = 64;
            loc = "";
            frameCount = 0;

        }

        public Sprite(string str, int x, int y, int width, int height)
        {
            xpos = x;
            ypos = y;
            xlen = width;
            ylen = height;
            loc = str;
            frameCount = 0;
        }

        public int count
        {
            get
            {
                return frameCount;
            }
        }

        public void update()
        {
            xpos += xlen;
            ypos += ylen;
        }

        public int resetCount()
        {
            frameCount = 0;
            return frameCount;
        }
    }

    public delegate Sprite UpdateHandler(Sprite val);
    public class SpriteHandler
    {
        //TODO: make an event handler for sprites or at least learn some the delegates.
        const int FrameMax = 60;
        int frameCount = 0;

        event UpdateHandler UpdateSprite;

        public Sprite UpdateSpite(Sprite temp)
        {

            //event updateframe
            if (temp.isOldFrame & temp.count < FrameMax)
            {
                temp.isOldFrame = false;
                //event update frame;
                temp.update();
            }
            else
            {
                temp.isOldFrame = true;
                if (temp.count <= FrameMax | temp.cancel)
                {
                    temp.resetCount();
                }
            }
            return temp;
        }

        static void main(string[] args)
        {
            //try the hook up
            SpriteHandler SH = new SpriteHandler();

        }
    }
}
