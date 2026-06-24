using System.Diagnostics;
using System.IO;

namespace Проект
{
    public partial class Form1 : Form
    {
        string path = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создатьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            path = "";
            this.Text = "Без_имени";
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(path);
                this.Text = Path.GetFileName(path);
            }
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                File.WriteAllText(path, textBox1.Text);
            }
        }

        private void сохранитьtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                    File.WriteAllText(path, textBox1.Text);
                }
            }
            else
            {
                File.WriteAllText(path, textBox1.Text);
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxSearch.Visible = true;
            textBoxSearch.Focus();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void масштабToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxSearch.Visible = false;
        }
    }
}
