using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Neuron
    {
        private int[] Input;
        private double[] Weights;
        private double WeightBias;

        public Neuron()
        {
            Weights = new Double[Constants.INPUT_SIZE];

            RandomHolder rand = RandomHolder.GetInstance();
            WeightBias = 1 / ((rand.getRandomDouble() * 100) + 1);
        }

        public void SetSample(int[] input)
        {
            if(Input == null)
            {
                Input = input;
                generateWeight();
            }
            Input = input;
        }

        public double getOutput()
        {
            double net = 0.0;

            for(int i = 0; i< Input.Length; i++)
            {
                net += Weights[i] * Input[i];
            }

            net += Constants.BIAS * WeightBias;

            return functionSigmoid(net);

        }

        public void adjustWeights(double learning)
        {
            for(int i=0; i<Input.Length; i++)
            {
                double d = Weights[i];
                d += Constants.LEARNING_RATE * learning * Input[i];
                Weights.SetValue(d, i);
            }

            WeightBias += Constants.LEARNING_RATE * learning * Constants.BIAS;
        }


        //helper methods
        public void generateWeight()
        {
            RandomHolder rand = RandomHolder.GetInstance();

            for(int i=0; i< Weights.Length; i++)
            {
                Weights[i] = 1 / ((rand.getRandomDouble() * 100) + 1);
            }
        }

        public double functionSigmoid(double x)
        {
            return (1 / (1 + Math.Pow(Math.E, -x)));
        }

        public int[] getInput()
        {
            return Input;
        }

        public double[] getWeights()
        {
            return Weights;
        }
    }
}
