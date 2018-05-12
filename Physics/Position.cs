using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public class Position
    {
        int xpos = 0;
        int ypos = 0;
        int zpos = 0;
        int gravForce = 0;
        bool gravity = false;
        
        public Position()
        {
            int xpos;
            int ypos;
            int zpos;

            xpos = this.xpos;
            ypos = this.ypos;
            zpos = this.zpos;
        }
        public Position(bool gravity, int gravForce)
        {
            int xpos;
            int ypos;
            int zpos;

            xpos = this.xpos;
            ypos = this.ypos;
            zpos = this.zpos;
            this.gravity = gravity;

            if(gravity)
            {
                gravForce = 32; //(feet/sec)
            }
        }
    }


}
