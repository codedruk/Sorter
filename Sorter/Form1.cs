/*Name:     Zigmyal Wangchuk
Program:    Sorts a randomly generated list of intergers using bubble sort, insertion sort, 
            selection sort and merge sort. Displays the number of ticks and time in milliseconds
            using the Stropwatch
Assignment: Extra Credit
 */

namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            toolStripStatusLabel1.Text = "0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = Clipboard.GetText();
            if (a.EndsWith(Convert.ToString((char)10)))
                a = a.Remove(a.Length - 2);
            richTextBox1.Text = a;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (pasteToolStripMenuItem.Enabled = Clipboard.ContainsText())
                pasteToolStripMenuItem.Checked = pasteToolStripMenuItem.Enabled;
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(MousePosition);
        }

        //using bubble sort
        private void button1_Click(object sender, EventArgs e)
        {
            bubble x = new bubble();
            string[] a = richTextBox1.Lines;
            x.arrayToSort = ConvertToInt(ref a);
            x.sort();
            richTextBox1.Lines = ConvertToStr(ref x.arrayToSort);
            toolStripStatusLabel1.Text = "ticks:" + x.stopWatch.ElapsedTicks.ToString() +
                "  milisec:" + x.stopWatch.ElapsedMilliseconds.ToString();
        }

        #region
        public double ConvertToDbl(string a)
        { return Convert.ToDouble(a); }
        public double ConvertToDbl(ref string a)
        { return Convert.ToDouble(a); }

        public string ConvertToStr(double a)
        { return a.ToString(); }
        public string ConvertToStr(ref double a)
        { return a.ToString(); }
        public string ConvertToStr(ref int a)
        { return a.ToString(); }

        public int ConvertToInt(double a)
        { return Convert.ToInt32(a); }
        public int ConvertToInt(ref double a)
        { return Convert.ToInt32(a); }
        public int ConvertToInt(ref string a)
        { return Convert.ToInt32(a); }

        // convert string to double
        public double[] ConvertToDbl(ref string[] stringIn)
        {
            int al = stringIn.Length;
            double[] d = new double[al];
            for (int i = 0; i < al; i++)
                d[i] = ConvertToDbl(ref stringIn[i]);
            return d;
        }

        // convert double to string
        public string[] ConvertToStr(ref double[] dblIn)
        {
            int al = dblIn.Length;
            string[] s = new string[al];
            for (int i = 0; i < al; i++)
                s[i] = ConvertToStr(ref dblIn[i]);
            return s;
        }

        // convert double to string
        public string[] ConvertToStr(ref int[] intIn)
        {
            int al = intIn.Length;
            string[] s = new string[al];
            for (int i = 0; i < al; i++)
                s[i] = ConvertToStr(ref intIn[i]);
            return s;
        }

        // convert double to integer
        public int[] ConvertToInt(ref double[] dblIn)
        {
            int al = dblIn.Length;
            int[] r = new int[al];
            for (int i = 0; i < al; i++)
                r[i] = ConvertToInt(ref dblIn[i]);
            return r;
        }

        // convert double to integer
        public int[] ConvertToInt(ref string[] strIn)
        {
            int al = strIn.Length;
            int[] r = new int[al];
            for (int i = 0; i < al; i++)
                r[i] = ConvertToInt(ref strIn[i]);
            return r;
        }

        // convert string to double
        public double[][] ConvertToDbl(ref string[][] strIn)
        {
            int al = strIn.Length;
            double[][] r = new double[al][];
            for (int i = 0; i < al; i++)
                r[i] = ConvertToDbl(ref strIn[i]);
            return r;
        }

        // convert double to string
        public string[][] ConvertToStr(ref double[][] dblIn)
        {
            int al = dblIn.Length;
            string[][] r = new string[al][];
            for (int i = 0; i < al; i++)
                r[i] = ConvertToStr(ref dblIn[i]);
            return r;
        }

        // convert double to integer
        public int[][] ConvertToInt(ref double[][] dblIn)
        {
            int al = dblIn.Length;
            int[][] r = new int[al][];
            for (int i = 0; i < al; i++)
                r[i] = ConvertToInt(ref dblIn[i]);
            return r;
        }
        #endregion

        //using insertion sort
        private void button2_Click(object sender, EventArgs e)
        {
            Insertion x = new Insertion();
            string[] a = richTextBox1.Lines;
            x.arrayToSort = ConvertToInt(ref a);
            x.sort();
            richTextBox1.Lines = ConvertToStr(ref x.arrayToSort);
            toolStripStatusLabel1.Text = "ticks:" + x.stopWatch.ElapsedTicks.ToString() +
                "  milisec:" + x.stopWatch.ElapsedMilliseconds.ToString();

        }

        //using selection sort
        private void button3_Click(object sender, EventArgs e)
        {
            Selection x = new Selection();
            string[] a = richTextBox1.Lines;
            x.arrayToSort = ConvertToInt(ref a);
            x.sort();
            richTextBox1.Lines = ConvertToStr(ref x.arrayToSort);
            toolStripStatusLabel1.Text = "ticks:" + x.stopWatch.ElapsedTicks.ToString() +
                "  milisec:" + x.stopWatch.ElapsedMilliseconds.ToString();

        }

        //Using merge sort
        private void button4_Click(object sender, EventArgs e)
        {
            Merge x = new Merge();
            string[] a = richTextBox1.Lines;
            x.arrayToSort = ConvertToInt(ref a);
            x.sort();
            richTextBox1.Lines = ConvertToStr(ref x.arrayToSort);
            toolStripStatusLabel1.Text = "ticks:" + x.stopWatch.ElapsedTicks.ToString() +
                "  milisec:" + x.stopWatch.ElapsedMilliseconds.ToString();

        }

        //checking if random number list is sorted
        private void button5_Click(object sender, EventArgs e)
        {
            string[] a = richTextBox1.Lines;
            int[] x = ConvertToInt(ref a);
            bool b = true;
            for (int i = 0; i < x.Length - 1; i++)
            {
                if (x[i] > x[i + 1])
                {
                    b = false;
                    break;
                }
            }
            MessageBox.Show(b.ToString());
        }

        // random number list generator
        private void button6_Click(object sender, EventArgs e)
        {
            int[] rnd = new int[10000];
            Random r = new Random();
            for (int i = 0; i < rnd.Length; i++)
                rnd[i] = r.Next();
            richTextBox1.Lines = ConvertToStr(ref rnd);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
