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

namespace NeuroComputing
{
    public partial class Form1 : Form
    {
        List<double> signals;
        List<List<double>> central;
        List<List<double>> valuesShifted;
        public Form1()
        {
            InitializeComponent();
            signals = new List<double>();
            central = new List<List<double>>();
            valuesShifted = new List<List<double>>();
        }

        private void sinusoidCentreButton_Click(object sender, EventArgs e)
        {
            List<List<double>> values = new List<List<double>>();
            double minFreq = Convert.ToDouble(minFreqTextBox.Text);
            double maxFreq = Convert.ToDouble(maxFreqTextBox.Text);
            double stepFreq = Convert.ToDouble(stepsTextBox.Text);
            int count = Convert.ToInt32(NTextBox.Text);
            saveFileDialog1.Title = "Save the text file";
            saveFileDialog1.ShowDialog();
            if(saveFileDialog1.FileName != "")
            {
                for (double value = minFreq; value <= maxFreq; value += stepFreq)
                {
                    values.Add(GenerateWaves.GenerateSinusoid(count, value));
                    values.Add(GenerateWaves.GenerateCosinusoid(count, value));
                }
                central = Centraling.Centre(values);                
                string path = saveFileDialog1.FileName;
                WriteToFile(central, path);
            }
            readFileButton.Enabled = true;
            resultLabel.ForeColor = Color.Blue;
            resultLabel.Text = "Закончил центрирование";

        }

        private void WriteToFile(List<List<double>> values, string path)
        {
            using(StreamWriter writer = new StreamWriter(path))
            {
                for (int j = 0; j < values[0].Count; j++)
                {
                    string value = "";
                    for (int i = 0; i < values.Count; i++)
                    {
                        value += string.Format("{0:F30}",values[i][j]) + "\t";
                    }
                    writer.WriteLine(value);
                }                
            }
        }
        private void WriteToFile(List<double> values, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join("\n", values));
                
            }
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File containing source signal";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string text = reader.ReadToEnd();
                    var values = text.Split(';',',','\n');
                    signals = values.Where(x=>x.Length>0).Select(x => Convert.ToDouble(x)).ToList<double>();
                    labelFileName.Text = "Закончил чтение из файла";
                }
            }
            covarianceButton.Enabled = true;
        }

        private void covarianceButton_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Title = "Save to file";
            if(saveFileDialog2.ShowDialog() == DialogResult.OK)
            {                
                {
                    var centered = Centraling.Centre(signals);
                    List<double> listSin = new List<double>();
                    List<double> listCosin = new List<double>();
                    for (int i = 0; i < central.Count; i++)
                    {                        
                        double value = Covariance.FindCovariance(centered, central[i]);
                        if (i % 2 == 0)
                        {
                            listSin.Add(value);
                        }
                        else
                        {
                            listCosin.Add(value);
                        }
                    }
                    WriteToFile(new List<List<double>> { listCosin, listSin }, saveFileDialog2.FileName);
                    labelCovariance.ForeColor = Color.Blue;
                    labelCovariance.Text = "Ковариации сохранилась";
                }                
            }
        }

        private void shiftCovarianceButton_Click(object sender, EventArgs e)
        {
            saveFileDialog3.Title = "SaveToFile";
            valuesShifted.Clear();
            if (saveFileDialog3.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < central.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        valuesShifted.AddRange(GenerateShift(central[i], central[i + 1]));
                    }
                }
                WriteToFile(valuesShifted, saveFileDialog3.FileName);
                shiftResultLabel.Text = "Закончил Вычисление";
            }
        }

        private List<List<double>> GenerateShift(List<double> signalToShiftSin, List<double> signalToShiftCosin)
        {
            List<List<double>> values = new List<List<double>>();
            for (int i = 0; i <= int.Parse(textBoxShift.Text); i+=1)
            {
                var signal = Shifting.shift(signalToShiftSin, signalToShiftCosin, i);
                values.Add(signal.ToList());
            }
            return values;
        }

        private List<double> CovarianceWithShift(List<double> signalToShiftSin, List<double> signalToShiftCosin, List<double> fixedSignal)
        {
            List<double> covariances = new List<double>();
            for(int i = 0; i < signalToShiftSin.Count; i+=100)
            {
                var signal = Shifting.shift(signalToShiftSin, signalToShiftCosin, i);
                double value = Covariance.FindCovariance(fixedSignal, signal.ToList());
                covariances.Add(value);
            }
            return covariances;
        }

        private void shiftCovariance_Click(object sender, EventArgs e)
        {
            saveFileDialog4.Title = "SaveToFile";
            if (saveFileDialog4.ShowDialog() == DialogResult.OK)
            {
                var centered = Centraling.Centre(signals);
                List<double> covariances = new List<double>();
                for (int i = 0; i < valuesShifted.Count; i++)
                {
                    double value = Covariance.FindCovariance(valuesShifted[i], centered);
                    covariances.Add(value);
                }
                WriteToFile(covariances, saveFileDialog4.FileName);
            }
        }
    }

}
