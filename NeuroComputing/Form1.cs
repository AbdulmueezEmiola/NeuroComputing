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
        public Form1()
        {
            InitializeComponent();
            signals = new List<double>();
            central = new List<List<double>>();
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
                        value += string.Format("{0:F10}",values[i][j]) + "\t";
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
                    WriteToFile(central[9], @"C:\Users\emiol\source\repos\NeuroComputing\NeuroComputing\TextFile4.txt");
                    List<double> list = new List<double>();
                    for (int i = 0; i < central.Count; i++)
                    {
                        double value = Covariance.FindCovariance(centered, central[i]);
                        list.Add(value);
                    }
                    using (StreamWriter writer = new StreamWriter(saveFileDialog2.FileName))
                    {
                        writer.WriteLine(string.Join("\n", list));
                    }
                    labelCovariance.ForeColor = Color.Blue;
                    labelCovariance.Text = "Ковариации сохранилась";
                }                
            }
        }
    }
}
