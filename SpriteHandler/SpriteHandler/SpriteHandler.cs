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
        private int frameCount = 0;
        public bool isOldFrame = false;
        public bool isNewFrame = true;
        public bool cancel = false;

        private string loc;

        public Sprite() : this("", 0, 0, 64, 64) {}

        public Sprite(string str, int x, int y, int width, int height)
        {
            loc = str;
            xpos = x;
            ypos = y;
            xlen = width;
            ylen = height;
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
        static Sprite[][] sprites = new Sprite[10][];

        event UpdateHandler update;
        public static Dictionary<int, Sprite> group = new Dictionary<int, Sprite>();

        public SpriteHandler() : this(sprites[0], null, 0) {}

        public SpriteHandler(Sprite[] obj, Sprite s, int loc)
        {
            obj[loc] = s;
        }

        public static void __init__()
        {
            Sprite player = new Sprite();
            Sprite enemy = new Sprite();
            Sprite boss = new Sprite();
            group.Add(1, player);
            group.Add(2, enemy);
            group.Add(3, boss);
            
        }

        public Sprite UpdateSprite(Sprite temp)
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

        public void run(Sprite sprite)
        {
            bool end = false;
            if (!end)
            {
                for (int i = 0; i < FrameMax; i++)
                {
                    UpdateSprite(sprite);
                }
                run(sprite);
            }
        }

        static void main(string[] args)
        {
            SpriteHandler SH = new SpriteHandler();

            Sprite littleBoy = new Sprite();

            UpdateHandler UH = new UpdateHandler(littleBoy.update);
            SH.run(littleBoy);
            Console.WriteLine(SH.frameCount);
        }
    }
}
