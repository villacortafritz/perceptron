using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Constants
    {
        public const double LEARNING_RATE = 0.1;

        public const int NUM_LETTERS = 26;

        public const int CHAR_BASE = 65;
        //Represents the ASCII code of the character 'A'.

        public const int BIAS = 1;

        public const int INPUT_SIZE = 50;

        public const int CELL_WIDTH = 7;

        public const int CELL_HEIGHT = 7;

        public const int CELL_SIZE = 7;

        public const string OPEN_FILE = "Open File: ";
        public const string SAMPLES_ADDED = "Samples Added: ";
        public const string OBTAINED_OUTPUT = "Obtained Output: ";
        public const string TRAINING_PHASES = "Training Phases: ";
        public const string TRAINING = "Training: ";
        public const string POSITIVE = "YES";
        public const string NEGATIVE = "NO";

        public static char[] LETTERS = new char[NUM_LETTERS] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    }
}
