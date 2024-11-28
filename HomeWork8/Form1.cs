using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HomeWork8
{
    public partial class Form1 : Form
    {
        private ToolTip toolTip = new ToolTip(); // Tooltip instance
        private List<Rectangle> originalBarRegions = new List<Rectangle>(); // Regions for original bars
        private List<Rectangle> encryptedBarRegions = new List<Rectangle>(); // Regions for encrypted bars
        private Dictionary<int, string> alphabet = new Dictionary<int, string>();
        private Dictionary<Rectangle, string> toolTipTexts = new Dictionary<Rectangle, string>();

        public Form1()
        {
            InitializeComponent();
            InitializeAlphabet();
        }

        private void InitializeAlphabet()
        {
            for (int i = 1; i <= 26; i++)
            {
                char letter = (char)('A' + (i - 1));
                alphabet.Add(i, letter.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graph = pictureBox1.CreateGraphics();
            graph.Clear(Color.White);

            // Input text
            string original = Originaltext.Text.ToUpper();

            // Generate a random shift
            Random rand = new Random();
            int shift = rand.Next(1, 25);

            // Encrypt the text
            string encryptedText = CaesarEncryption(original, shift);
            Cyphertext.Text = encryptedText; // Display encrypted text

            Dictionary<char, double> originalFrequencies = LetterFrequencyDistribution(original);
            Dictionary<char, double> encryptedFrequencies = LetterFrequencyDistribution(encryptedText);

            
            DrawFrequencyDistribution(graph, originalFrequencies, encryptedFrequencies);

            pictureBox1.MouseMove += PictureBox1_MouseMove;
        }

        private string CaesarEncryption(string original, int shift)
        {
            string res = "";
            foreach (char c in original)
            {
                if (char.IsLetter(c))
                {
                    char offset = 'A';
                    char shiftedChar = (char)(((c - offset + shift) % 26) + offset);
                    res += shiftedChar;
                }
                else
                {
                    res += c;
                }
            }
            return res;
        }

        private Dictionary<char, double> LetterFrequencyDistribution(string text)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            int totalLetters = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    if (!letterCounts.ContainsKey(c))
                        letterCounts[c] = 0;
                    letterCounts[c]++;
                    totalLetters++;
                }
            }

            Dictionary<char, double> frequencies = new Dictionary<char, double>();
            foreach (var pair in letterCounts)
            {
                frequencies[pair.Key] = (pair.Value / (double)totalLetters) * 100;
            }

            return frequencies;
        }

        private void DrawFrequencyDistribution(Graphics graph, Dictionary<char, double> originalFrequencies, Dictionary<char, double> encryptedFrequencies)
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            originalBarRegions.Clear();
            encryptedBarRegions.Clear();
            toolTipTexts.Clear();

            int barWidth = width / (26 * 2); 
            int maxHeight = height - 50;
            double maxFrequency = Math.Max(
                originalFrequencies.Values.Count > 0 ? originalFrequencies.Values.Max() : 1,
                encryptedFrequencies.Values.Count > 0 ? encryptedFrequencies.Values.Max() : 1
            );

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)('A' + i);
                int xBase = i * barWidth * 2;

                // Original text
                if (originalFrequencies.ContainsKey(letter))
                {
                    double frequency = originalFrequencies[letter];
                    int barHeight = (int)((frequency / maxFrequency) * maxHeight);
                    Rectangle barRect = new Rectangle(xBase, height - barHeight, barWidth, barHeight);
                    originalBarRegions.Add(barRect);
                    toolTipTexts[barRect] = $"Original '{letter}': {frequency:F2}%";
                    graph.FillRectangle(Brushes.Chartreuse, barRect);
                }

                // Encrypted text
                if (encryptedFrequencies.ContainsKey(letter))
                {
                    double frequency = encryptedFrequencies[letter];
                    int barHeight = (int)((frequency / maxFrequency) * maxHeight);
                    Rectangle barRect = new Rectangle(xBase + barWidth, height - barHeight, barWidth, barHeight);
                    encryptedBarRegions.Add(barRect);
                    toolTipTexts[barRect] = $"Encrypted '{letter}': {frequency:F2}%";
                    graph.FillRectangle(Brushes.Sienna, barRect);
                }

                // Draw letter labels
                graph.DrawString(letter.ToString(), new Font("Arial", 10), Brushes.Black, xBase, height - 20);
            }
        }

        
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var rect in toolTipTexts.Keys)
            {
                if (rect.Contains(e.Location))
                {
                    toolTip.SetToolTip(pictureBox1, toolTipTexts[rect]);
                    return;
                }
            }
            toolTip.SetToolTip(pictureBox1, ""); 
        }
    }
}
