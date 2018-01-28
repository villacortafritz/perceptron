namespace Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputArea = new System.Windows.Forms.TableLayoutPanel();
            this.trainingBox = new System.Windows.Forms.GroupBox();
            this.lblIsTraining = new System.Windows.Forms.Label();
            this.lblTrainingCount = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.numTrainingCycles = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSamplesAdded = new System.Windows.Forms.Label();
            this.btnAddSample = new System.Windows.Forms.Button();
            this.txtExpectedOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateLog = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblOpenedFile = new System.Windows.Forms.Label();
            this.btnResetScreen = new System.Windows.Forms.Button();
            this.btnIdentifyPattern = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trainingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrainingCycles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputArea
            // 
            this.inputArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputArea.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.inputArea.ColumnCount = 7;
            this.inputArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputArea.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.inputArea.Location = new System.Drawing.Point(272, 12);
            this.inputArea.Margin = new System.Windows.Forms.Padding(0);
            this.inputArea.Name = "inputArea";
            this.inputArea.RowCount = 7;
            this.inputArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.inputArea.Size = new System.Drawing.Size(500, 400);
            this.inputArea.TabIndex = 14;
            this.inputArea.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.inputArea_CellPaint);
            this.inputArea.Paint += new System.Windows.Forms.PaintEventHandler(this.inputArea_Paint);
            this.inputArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputArea_MouseDown);
            this.inputArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inputArea_MouseMove);
            // 
            // trainingBox
            // 
            this.trainingBox.Controls.Add(this.lblIsTraining);
            this.trainingBox.Controls.Add(this.lblTrainingCount);
            this.trainingBox.Controls.Add(this.btnTrain);
            this.trainingBox.Controls.Add(this.numTrainingCycles);
            this.trainingBox.Controls.Add(this.label3);
            this.trainingBox.Controls.Add(this.lblSamplesAdded);
            this.trainingBox.Controls.Add(this.btnAddSample);
            this.trainingBox.Controls.Add(this.txtExpectedOutput);
            this.trainingBox.Controls.Add(this.label1);
            this.trainingBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingBox.Location = new System.Drawing.Point(12, 12);
            this.trainingBox.Name = "trainingBox";
            this.trainingBox.Size = new System.Drawing.Size(250, 250);
            this.trainingBox.TabIndex = 1;
            this.trainingBox.TabStop = false;
            this.trainingBox.Text = "Train Neural Network";
            // 
            // lblIsTraining
            // 
            this.lblIsTraining.AutoSize = true;
            this.lblIsTraining.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsTraining.Location = new System.Drawing.Point(5, 220);
            this.lblIsTraining.Name = "lblIsTraining";
            this.lblIsTraining.Size = new System.Drawing.Size(78, 15);
            this.lblIsTraining.TabIndex = 8;
            this.lblIsTraining.Text = "Training? No";
            // 
            // lblTrainingCount
            // 
            this.lblTrainingCount.AutoSize = true;
            this.lblTrainingCount.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingCount.Location = new System.Drawing.Point(5, 200);
            this.lblTrainingCount.Name = "lblTrainingCount";
            this.lblTrainingCount.Size = new System.Drawing.Size(112, 15);
            this.lblTrainingCount.TabIndex = 7;
            this.lblTrainingCount.Text = "Training Phases: 0";
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Location = new System.Drawing.Point(50, 155);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(120, 30);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // numTrainingCycles
            // 
            this.numTrainingCycles.Location = new System.Drawing.Point(166, 121);
            this.numTrainingCycles.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTrainingCycles.Name = "numTrainingCycles";
            this.numTrainingCycles.Size = new System.Drawing.Size(40, 23);
            this.numTrainingCycles.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of training cycles:";
            // 
            // lblSamplesAdded
            // 
            this.lblSamplesAdded.AutoSize = true;
            this.lblSamplesAdded.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamplesAdded.Location = new System.Drawing.Point(5, 105);
            this.lblSamplesAdded.Name = "lblSamplesAdded";
            this.lblSamplesAdded.Size = new System.Drawing.Size(109, 15);
            this.lblSamplesAdded.TabIndex = 3;
            this.lblSamplesAdded.Text = "Samples Added: 0";
            // 
            // btnAddSample
            // 
            this.btnAddSample.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSample.Location = new System.Drawing.Point(50, 65);
            this.btnAddSample.Name = "btnAddSample";
            this.btnAddSample.Size = new System.Drawing.Size(120, 30);
            this.btnAddSample.TabIndex = 2;
            this.btnAddSample.Text = "Add Sample";
            this.btnAddSample.UseVisualStyleBackColor = true;
            this.btnAddSample.Click += new System.EventHandler(this.btnAddSample_Click);
            // 
            // txtExpectedOutput
            // 
            this.txtExpectedOutput.Location = new System.Drawing.Point(114, 34);
            this.txtExpectedOutput.Name = "txtExpectedOutput";
            this.txtExpectedOutput.Size = new System.Drawing.Size(100, 23);
            this.txtExpectedOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expected Output:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateLog);
            this.groupBox1.Controls.Add(this.btnSaveFile);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.lblOpenedFile);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // btnGenerateLog
            // 
            this.btnGenerateLog.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLog.Location = new System.Drawing.Point(50, 135);
            this.btnGenerateLog.Name = "btnGenerateLog";
            this.btnGenerateLog.Size = new System.Drawing.Size(120, 30);
            this.btnGenerateLog.TabIndex = 11;
            this.btnGenerateLog.Text = "Generate Log File";
            this.btnGenerateLog.UseVisualStyleBackColor = true;
            this.btnGenerateLog.Click += new System.EventHandler(this.btnGenerateLog_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.Location = new System.Drawing.Point(50, 95);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(120, 30);
            this.btnSaveFile.TabIndex = 10;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(50, 55);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(120, 30);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblOpenedFile
            // 
            this.lblOpenedFile.AutoSize = true;
            this.lblOpenedFile.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenedFile.Location = new System.Drawing.Point(5, 25);
            this.lblOpenedFile.Name = "lblOpenedFile";
            this.lblOpenedFile.Size = new System.Drawing.Size(88, 15);
            this.lblOpenedFile.TabIndex = 9;
            this.lblOpenedFile.Text = "Opened File: --";
            // 
            // btnResetScreen
            // 
            this.btnResetScreen.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetScreen.Location = new System.Drawing.Point(652, 420);
            this.btnResetScreen.Name = "btnResetScreen";
            this.btnResetScreen.Size = new System.Drawing.Size(120, 30);
            this.btnResetScreen.TabIndex = 12;
            this.btnResetScreen.Text = "Reset Screen";
            this.btnResetScreen.UseVisualStyleBackColor = true;
            this.btnResetScreen.Click += new System.EventHandler(this.btnResetScreen_Click);
            // 
            // btnIdentifyPattern
            // 
            this.btnIdentifyPattern.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifyPattern.Location = new System.Drawing.Point(272, 420);
            this.btnIdentifyPattern.Name = "btnIdentifyPattern";
            this.btnIdentifyPattern.Size = new System.Drawing.Size(120, 30);
            this.btnIdentifyPattern.TabIndex = 13;
            this.btnIdentifyPattern.Text = "Identify Pattern";
            this.btnIdentifyPattern.UseVisualStyleBackColor = true;
            this.btnIdentifyPattern.Click += new System.EventHandler(this.btnIdentifyPattern_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(398, 425);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(213, 23);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Text = "Pattern recognized as: --";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.inputArea);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnIdentifyPattern);
            this.Controls.Add(this.btnResetScreen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trainingBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Perceptron";
            this.trainingBox.ResumeLayout(false);
            this.trainingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrainingCycles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel inputArea;
        private System.Windows.Forms.GroupBox trainingBox;
        private System.Windows.Forms.Label lblIsTraining;
        private System.Windows.Forms.Label lblTrainingCount;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.NumericUpDown numTrainingCycles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSamplesAdded;
        private System.Windows.Forms.Button btnAddSample;
        private System.Windows.Forms.TextBox txtExpectedOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateLog;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblOpenedFile;
        private System.Windows.Forms.Button btnResetScreen;
        private System.Windows.Forms.Button btnIdentifyPattern;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

