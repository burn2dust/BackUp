//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DeepLearning
{
    class Layers : Node
    {
        static public int start = 3000;
        static public int hidden = 16;
        static public int end = 10;

        public Node[] startLayer = new Node[start];
        private Node[] hiddenLayer1 = new Node[hidden];
        private Node[] hiddenLayer2 = new Node[hidden];
        public Node[] finalLayer = new Node[end];


    }
}
