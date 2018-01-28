using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Perceptron
{
    class FileManagement
    {
        public static bool saveFile(List<TrainingSet> c, string directory)
        {
            bool flag = true;

            try
            {
                Directory.CreateDirectory(directory.Substring(0, directory.LastIndexOfAny(new char[2] { '/', '\\' })));

                StreamWriter stream = new StreamWriter(directory, false, Encoding.ASCII);

                foreach(TrainingSet s in c)
                {
                    string content = "";

                    char letter = (char)s.getLetter();
                    int[] inputs = s.getInputs();

                    content += letter + "\n";
                    content += GetStringVector(inputs) + "\n";

                    stream.Write(content); 
                }
                stream.Dispose();
                stream.Close();
            }
            catch { flag = false; }

            return flag;
        }

        public static List<TrainingSet> openFile(string directory)
        {
            List<TrainingSet> c = new List<TrainingSet>();

            StreamReader stream = new StreamReader(directory, Encoding.ASCII);

            string line;
            int accountLine = 1;

            char letter = ' ';
            int[] inputs = new int[Constants.INPUT_SIZE];

            do
            {
                line = stream.ReadLine();

                if (line != null)
                {
                    if (accountLine % 2 != 0)
                    {
                        letter = line.ToCharArray()[0];
                    }
                    else
                    {
                        string[] e = line.Split(' ');
                        for (int i = 0; i < e.Length; i++)
                        {
                            inputs[i] = int.Parse(e[i]);
                        }
                    }
                    if (accountLine % 2 == 0)
                    {
                        c.Add(new TrainingSet(inputs, letter));
                        letter = ' ';
                        inputs = new int[Constants.INPUT_SIZE];
                    }
                    accountLine++;
                }
            } while (line != null);

            stream.Dispose();
            stream.Close();

            return c;
        }

        public static bool writeLog(string directory, List<Neuron> neurons, List<TrainingSet> trainset)
        {
            bool flag = true;

            try
            {
                Directory.CreateDirectory(directory.Substring(0, directory.LastIndexOfAny(new char[2] { '/', '\\' })));

                StreamWriter stream = new StreamWriter(directory, false, Encoding.ASCII);

                stream.WriteLine("NEURONS: ");

                for(int i=0; i<neurons.Count; i++)
                {
                    string line = "N-" + i + " =\tOutput: " + neurons[i].getOutput() + "\tInputs\tWeights\n";

                    double[] weights = neurons[i].getWeights();
                    int[] inputs = neurons[i].getInput();

                    for(int j=0; j<inputs.Length; j++)
                    {
                        line += inputs[j] + "\t" + weights[j] + "\n";
                    }
                    stream.WriteLine(line);
                }

                stream.WriteLine("TRAINING SETS: ");

                for(int i=0; i<trainset.Count; i++)
                {
                    string line = "C-" + i + ": \tLetter\tInput\n";
                    char letter = (char)trainset[i].getLetter();
                    int[] inputs = trainset[i].getInputs();

                    line += letter + " ";
                    line += GetStringVector(inputs) + "\n";

                    stream.WriteLine(line);
                }
            }
            catch { flag = false; }

            return flag;
        }


        //helper functions
        private static string GetStringVector(int[] vector)
        {
            string s = "";

            for (int i=0; i<vector.Length; i++)
            {
                s += vector[i].ToString() + "";
            }
            return s.Trim();
        }     

        private static string GetStringVector(double[] vector)
        {
            string s = "";

            for (int i = 0; i < vector.Length; i++)
            {
                s += vector[i].ToString() + "";
            }
            return s.Trim();
        }
    }
}
