using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab3._2
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndUp();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Enlarge();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            count++;
            int randSize = r.Next(40, 200);
            int rand = r.Next(0, 623-randSize);
            int rand2 = r.Next(0, 455-randSize);
            
            CEmblem figure = new CEmblem(rand, rand2, randSize, "Фігура " + count, Color.DarkBlue);
            figure.Show();
            figure.Draw(pictureBox1);
            comboBox1.Items.Add(figure);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Reduce();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveUp();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveLeft();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveRight();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveDown();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndLeft();
            figure.Show();
            figure.Draw(pictureBox1);

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndRight();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndDown();
            figure.Show();
            figure.Draw(pictureBox1);
        }
    }
}
