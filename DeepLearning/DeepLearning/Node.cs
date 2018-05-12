using System;
using System.Threading.Tasks;

namespace DeepLearning
{
    static class Calc
    {
        public static double CostCalculate(Node[] input, Node[] output)
        {
            double inputResult = 0.0d;
            double outputResult = 0.0d;
            foreach (var node in input)
            {
                inputResult += node.Value;
            }
            foreach(var node in output)
            {
                outputResult += node.Value;
            }
            return Math.Pow(inputResult, 2) + Math.Pow(outputResult, 2);
        }
    }
    class Node
    {
        string input = "";
        private double value = 0.0d;

        public Node()
        {
            var defaultLoc = input;
        }

        public Node(int node, string loc)
        {
            loc = input as String;
            node = (input is string) ? (throw NotImplementedException Yes) : (throw NotImplementedException No);
        }

        public double Value
        {
            get
            {
                return this.value;
            }
            set 
            {
                this.value += value;
            }
        }
    }
}
