using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        Perceptron p;

        int trainingsDone = 0;
        int samplesAdded = 0;
        int currentLetter = 0;

        bool isTraining = false;

        Color[,] bgColors = new Color[7, 7] {
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control}
        };

        public Form1()
        {
            InitializeComponent();
            inputArea.ColumnCount = Constants.CELL_SIZE;
            inputArea.RowCount = Constants.CELL_SIZE;

            p = new Perceptron();
            txtExpectedOutput.Text = Constants.LETTERS[currentLetter].ToString();
        }



        private void inputArea_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Point p = GetIndex(inputArea, e.Location);

                if (e.Button.Equals(MouseButtons.Left))
                {
                    bgColors[p.X, p.Y] = Color.Red;
                    inputArea.Refresh();    
                }
                else if (e.Button.Equals(MouseButtons.Right))
                {
                    bgColors[p.X, p.Y] = Color.WhiteSmoke;
                    inputArea.Refresh();
                }
            }
            catch { }
        }

        private void btnResetScreen_Click(object sender, EventArgs e)
        {
            bgColors = new Color[7, 7] {
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control}
            };
            inputArea.Refresh();
        }

        private void inputArea_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(bgColors[e.Column, e.Row]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }

        private void inputArea_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = GetIndex(inputArea, e.Location);

            if (bgColors[p.X, p.Y].Equals(Color.Red))
            {
                bgColors[p.X, p.Y] = Color.WhiteSmoke;
                inputArea.Refresh();
            }
            else
            {
                bgColors[p.X, p.Y] = Color.Red;
                inputArea.Refresh();
            }
        }

        private void btnAddSample_Click(object sender, EventArgs e)
        {
            int letter = txtExpectedOutput.Text.ToUpper().ToCharArray()[0];

            p.addTrainingSet(GetInput(), letter);

            samplesAdded++;
            lblSamplesAdded.Text = Constants.SAMPLES_ADDED + samplesAdded.ToString();

            if (currentLetter >= 26)
            {
                currentLetter = 0;
            }

            txtExpectedOutput.Text = Constants.LETTERS[currentLetter].ToString();
            currentLetter++;
        }


        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (!isTraining)
            {
                Thread train = new Thread(new ThreadStart(startTraining));
                train.IsBackground = true;
                train.Start();

                lblIsTraining.Text = Constants.TRAINING + Constants.POSITIVE;
                isTraining = true;
            }
            else
            {
                MessageBox.Show("Training is still ongoing.");
            }

        }

        private void btnIdentifyPattern_Click(object sender, EventArgs e)
        {
            p.setInputs(GetInput());

            double[] outputs = p.getOutputs();
            int index = 0;

            for(int i=0; i< outputs.Length; i++)
            {
                if (outputs[i] > outputs[index])
                {
                    index = i;
                }
            }

            char obtainedLetter = (char)(Constants.CHAR_BASE + index);
            lblOutput.Text = "Pattern recognized as: " + obtainedLetter;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if(!FileManagement.saveFile(p.getTrainingSet(), saveFileDialog1.FileName))
            {
                MessageBox.Show("The file could not be saved.");
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if(openFileDialog1.FileName != "")
            {
                List<TrainingSet> t = FileManagement.openFile(openFileDialog1.FileName);

                if(t != null)
                {
                    int sampleAccounts = 0;

                    foreach(TrainingSet m in t)
                    {
                        p.addTrainingSet(m.getInputs(), m.getLetter());
                        sampleAccounts++;
                    }

                    lblOpenedFile.Text = Constants.OPEN_FILE + openFileDialog1.SafeFileName;
                    lblSamplesAdded.Text = Constants.SAMPLES_ADDED + sampleAccounts;
                }
                else
                {
                    MessageBox.Show("The file could not be read.");
                }
            }
        }

        private void btnGenerateLog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if (!p.generatesLog(saveFileDialog1.FileName))
            {
                MessageBox.Show("Could not save log file.");
            }
        }

        //Helper Methods
        public Point GetIndex(TableLayoutPanel t, Point p)
        {
            int w = 0, h = 0;
            int[] widths = t.GetColumnWidths(), heights = t.GetRowHeights();
            int i;

            for(i=0; i<widths.Length && p.X>w; i++)
            {
                w += widths[i];
            }

            int col = i - 1;

            for(i=0; i<heights.Length && p.Y + t.VerticalScroll.Value >h; i++)
            {
                h += heights[i];
            }

            int row = i - 1;

            return new Point(col, row);
        }

        private int[] GetInput()
        {
            int i = 0;
            int[] inputs = new int[Constants.INPUT_SIZE];

            for(int j=0; j<Constants.CELL_SIZE; j++)
            {
                for(int k=0; k < Constants.CELL_SIZE; k++)
                {
                    if (bgColors[j, k].Equals(Color.Red))
                    {
                        inputs[i] = 1;
                    }
                    else
                    {
                        inputs[i] = 0;
                    }
                    i++;
                }
            }

            return inputs;
        }

        public void startTraining()
        {
            p.train((int)numTrainingCycles.Value);

            Func<int> update = delegate ()
           {
               trainingsDone++;
               lblIsTraining.Text = Constants.TRAINING + Constants.NEGATIVE;
               lblTrainingCount.Text = Constants.TRAINING_PHASES + trainingsDone.ToString();

               isTraining = false;
               return 0;
           };

            Invoke(update);
        }

        private void inputArea_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
