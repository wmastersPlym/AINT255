using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimplePerceptonExample
{
    public partial class SimplePerceptron : Form
    {

        private int numberInputs;
        private int numberEpochs;

        /// <summary>
        /// perceptron learning rate
        /// should be in range 0...1
        /// </summary>
        private double alpha;

        /// <summary>
        /// holds the training data, format is:
        /// index 0 is x0 with a constant value of -1
        /// index 1 is x1
        /// index 2 is x2
        /// index 3 is target (classification)
        /// </summary>
        private List<double[]> trainingData;

        /// <summary>
        /// fixed size array holding the weights of perceptron
        /// index 0 is wo, the bias 
        /// index 1 is w1, the weight of x1
        /// index 2 is w2 the weight of x2
        /// </summary>
        private double[] weights;

        /// <summary>
        /// used to generate randomw weights
        /// </summary>
        private Random randNumber;


        public SimplePerceptron()
        {
            InitializeComponent();

            randNumber = new Random();

            numberInputs = 2;

            trainingData = new List<double[]>();

            isLogicalDataSet = (andRadioButton.Checked || orRadioButton.Checked) ? true : false;

            BuildChart();

            InitialiseWeights();
        }

        private void TrainPerceptron()
        {

            // initialise number epochs counter
            numberEpochs = 0;

            // get the learning rate, alpha, from the text box
            alpha = Convert.ToDouble(alphaTextBox.Text);


            // **********************************
            // add code here to train the perceptron 
            // **********************************

            int maxNumberOfEpochs = 20;

            for (int x = 0; x < maxNumberOfEpochs; x++)
            {
                for (int i = 0; i < trainingData.Count; i++)
                {

                    // Calculate weighted sum
                    double weightedSum = 0;
                    for (int j = 0; j < trainingData.ElementAt(i).Length - 1; j++)
                    {
                        weightedSum += (trainingData.ElementAt(i)[j] * weights[j]);
                    }


                    // Activation Function
                    double actualOutput = 0;
                    if (weightedSum >= 0)
                    {
                        actualOutput = 1;
                    }


                    // Calculate error
                    double error = trainingData.ElementAt(i)[trainingData.ElementAt(i).Length - 1] - actualOutput;

                    // Calculate change in weight
                    for (int j = 0; j < weights[j]; j++)
                    {
                        double weightChange = alpha * trainingData.ElementAt(i)[j] * error;

                        // adjust the weight accordingly
                        weights[j] += weightChange;
                    }

                    // Incrament number of epochs
                    numberEpochs++;
                }
            }
            




            // when finished display the number Epochs taken
            numberEpochsTextBox.Text = numberEpochs.ToString();
        }

        private void TestPerceptron()
        {

            double x0;  // fixed input for the bias
            double x1;
            double x2;

            double output; // the output from the perceptron (should be 0 or 1)

            // assign a arbitary high value prior to processing
            output = -1000;

            x0 = -1;

            // read inputs from text boxes
            x1 = Convert.ToDouble(X1TextBox.Text);
            x2 = Convert.ToDouble(X2TextBox.Text);

            // **********************************
            // add code here to test the perceptron 
            // **********************************

            OutputTextBox.Text = output.ToString("0.00");

        }

        /// <summary>
        /// Creates the weight vector (array) and initialises each element with 
        /// a value in the range -1...+1
        /// </summary>
        private void InitialiseWeights()
        {
            // add 1 to number of inputs to allow for the bias
            weights = new double[numberInputs + 1];

            // weights need to be randomly initialially initialised between -1...1
            // randNumber.NextDouble()  returns a random value 0...1
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = 1 - (randNumber.NextDouble() * 2);
            }
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            TrainPerceptron();
        }

        private void logicalTestButton_Click(object sender, EventArgs e)
        {
            TestPerceptron();
        }

        // ===========================================
        // housekeeping code: Do not ammend 

        private bool isLogicalDataSet;
        private Series typeASeries;
        private Series typeBSeries;
        private Series lineSeries;

        private const int TYPE_A = 0;
        private const int TYPE_B = 1;




        private void loaddataButton_Click(object sender, EventArgs e)
        {
            string fileName = @"trainingData\" + fileNameTextBox.Text + ".txt";

            string[] splitLine;
            double[] pattern;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    trainingData.Clear();

                    while (!reader.EndOfStream)
                    {
                        splitLine = reader.ReadLine().Split(new char[] { ',' });

                        pattern = new double[splitLine.Length];

                        for (int i = 0; i < splitLine.Length; i++)
                        {
                            pattern[i] = Convert.ToDouble(splitLine[i]);
                        }
                        AddToTrainingSet(pattern);
                    }
                }

                DisplayTrainingData();
                AddDataToSeries();

                initialiseButton.Enabled = true;
                trainButton.Enabled = true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File Not Found: " + fileNameTextBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("cannot process data file");
            }
        }



        private void AddToTrainingSet(double[] pattern)
        {
            if (!isLogicalDataSet)
            {
                pattern = NormaliseData(pattern);
            }
            trainingData.Add(pattern);
        }

        /// <summary>
        /// Rather crude normalisation in range 0...1 
        /// based on chart area size
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private double[] NormaliseData(double[] pattern)
        {

            int min = 50;
            int max = 455;

            // 2nd element of array is x1
            pattern[1] = (pattern[1] - min) /(max - min);

            // 3nd element of array is x2
            pattern[2] = (pattern[2] - min) / (max - min);

            return pattern;
        }

        private void BuildChart()
        {
            
            typeASeries = new Series
            {
                Name = "Type A Series",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Point,
                MarkerSize = 15,
                MarkerStyle = MarkerStyle.Circle
            };

            typeBSeries = new Series
            {
                Name = "Type B Series",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Point,
                MarkerSize = 15,
                MarkerStyle = MarkerStyle.Square
            };

            lineSeries = new Series
            {
                Name = "Line Series",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line,
                MarkerSize = 5,
                MarkerStyle = MarkerStyle.Triangle
            };

            dataChart.ChartAreas[0].AxisX.Minimum = 0;
            dataChart.ChartAreas[0].AxisX.Maximum = 1;

            dataChart.ChartAreas[0].AxisY.Minimum = 0;
            dataChart.ChartAreas[0].AxisY.Maximum = 1;

            dataChart.ChartAreas[0].AxisX.Interval = 1;
            dataChart.ChartAreas[0].AxisY.Interval = 1;

            dataChart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            dataChart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;

           
            dataChart.Series.Add(typeASeries);
            dataChart.Series.Add(typeBSeries);
            dataChart.Series.Add(lineSeries);


            dataChart.Invalidate();
        }

        private void AddDataToSeries()
        {
            typeASeries.Points.Clear();
            typeBSeries.Points.Clear();

            foreach (double[] pattern in trainingData)
            {
                if (pattern[3] == TYPE_A)
                {
                    typeASeries.Points.AddXY(pattern[1], pattern[2]);
                }
                else
                {
                    typeBSeries.Points.AddXY(pattern[1], pattern[2]);
                }
            }
        }


        private void andRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (andRadioButton.Checked)
            {
                fileNameTextBox.Enabled = false;
                fileNameTextBox.Text = "AND";
            }
            else if (orRadioButton.Checked)
            {
                fileNameTextBox.Enabled = false;
                fileNameTextBox.Text = "OR";
            }
            else if (userRadioButton.Checked)
            {
                fileNameTextBox.Enabled = true;
                fileNameTextBox.Text = "sample";
            }

            isLogicalDataSet = (andRadioButton.Checked || orRadioButton.Checked) ? true : false;

            typegroupBox.Enabled = !isLogicalDataSet;

        }



        private void dataChart_MouseClick(object sender, MouseEventArgs e)
        {
            double[] newPattern;

            if (!isLogicalDataSet)
            {
                newPattern = new double[4];

                 // build a non-normalised pattern

                // 1st element is the bias
                newPattern[0] = -1;

                newPattern[1] = e.Location.X;

                newPattern[2] = dataChart.Height - e.Location.Y;

                // 4th element is the output category
                newPattern[3] = typeAradioButton.Checked ? TYPE_A : TYPE_B;

                newPattern = NormaliseData(newPattern);


                if ((newPattern[1] >= 0 && newPattern[1] <= 1.0) && (newPattern[2] >= 0 && newPattern[2] <= 1.0))
                {
                    trainingData.Add(newPattern);
                    DisplayTrainingData();
                }

                // finally update the data series on the charts
                AddDataToSeries();
            } 
        }

        private void DisplayTrainingData()
        {
            trainingDataTextBox.Clear();

            foreach (double[] pattern in trainingData)
            {

                trainingDataTextBox.AppendText("  " + pattern[0] + ",   ");

                if (isLogicalDataSet)
                    trainingDataTextBox.AppendText(pattern[1] + ",   " + pattern[2] + ",   ");

                else
                    trainingDataTextBox.AppendText(pattern[1].ToString("0.00") + ",   " + pattern[2].ToString("0.00") + ",   ");

                trainingDataTextBox.AppendText("" + pattern[3]);

                trainingDataTextBox.AppendText(Environment.NewLine);
            }
        }


        private void DisplayWeights()
        {
            for (int i = 0; i < weights.Length; i++)
            {
                Console.WriteLine("weight {0} = {1} ", i, weights[i]);
            }
        }

        private void decisionLineButton_Click(object sender, EventArgs e)
        {
            double x1, x2;

            lineSeries.Points.Clear();

            x2 = weights[0] / weights[2];

            x1 = weights[0] / weights[1];


            lineSeries.Points.AddXY(0.0, x2);

            lineSeries.Points.AddXY(x1, 0.0);
        }

        private void initialiseButton_Click(object sender, EventArgs e)
        {
            InitialiseWeights();
        }
    }
}
