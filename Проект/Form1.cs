using System.Diagnostics;
using System.IO;

namespace Проект
{
    public partial class Form1 : Form
    {
        string path = "";
        int currentIndex = 0;
        int fontSize = 12;
        public Form1()
        {
            InitializeComponent();

            textBoxSearch.Visible = false;
            button1.Visible = false;
            buttonUp.Visible = false;
            buttonDown.Visible = false;
        }
        private void HideSearch()
        {
            textBoxSearch.Visible = false;
            button1.Visible = false;
            buttonUp.Visible = false;
            buttonDown.Visible = false;
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
            button1.Visible = true;
            buttonUp.Visible = true;
            buttonDown.Visible = true;
            textBoxSearch.Focus();
        }



        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
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
            fontSize += 1;

            textBox1.Font = new Font(
                textBox1.Font.FontFamily,
                fontSize
            );
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSize -= 1;

            textBox1.Font = new Font(
                textBox1.Font.FontFamily,
                fontSize
            );
        }

        private void поУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSize = 12;

            textBox1.Font = new Font(
                textBox1.Font.FontFamily,
                fontSize
            );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            HideSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = textBox1.Text.IndexOf(
        textBoxSearch.Text,
        StringComparison.OrdinalIgnoreCase);

            if (index >= 0)
            {
                textBox1.Focus();
                textBox1.Select(index, textBoxSearch.Text.Length);
            }
            else
            {
                MessageBox.Show("Текст не найден");
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            string word = textBoxSearch.Text;

            if (word == "")
                return;

            if (currentIndex == 0)
            {
                int first = textBox1.Text.IndexOf(
                    word,
                    StringComparison.OrdinalIgnoreCase);

                if (first >= 0)
                {
                    textBox1.Focus();
                    textBox1.Select(first, word.Length);
                    textBox1.ScrollToCaret();

                    currentIndex = first;

                    buttonUp.ForeColor = Color.Red;
                    buttonDown.ForeColor = Color.Black;
                }

                return;
            }


            int index = textBox1.Text.LastIndexOf(
                word,
                currentIndex - 1,
                StringComparison.OrdinalIgnoreCase);

            if (index >= 0)
            {
                textBox1.Focus();
                textBox1.Select(index, word.Length);
                textBox1.ScrollToCaret();

                currentIndex = index;

                buttonUp.ForeColor = Color.Black;
                buttonDown.ForeColor = Color.Black;
            }
            else
            {
                buttonUp.ForeColor = Color.Red;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            string word = textBoxSearch.Text;

            if (word == "")
                return;

            int index = textBox1.Text.IndexOf(
                word,
                currentIndex + 1,
                StringComparison.OrdinalIgnoreCase);

            if (index >= 0)
            {
                textBox1.Focus();
                textBox1.Select(index, word.Length);
                textBox1.ScrollToCaret();

                currentIndex = index;

                buttonDown.ForeColor = Color.Black;
                buttonUp.ForeColor = Color.Black;
            }
            else
            {
                buttonDown.ForeColor = Color.Red;
            }
        }
    }
}

