namespace Проект
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьФайлToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem1 = new ToolStripMenuItem();
            сохранитьtxtToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            выделитьВсеToolStripMenuItem = new ToolStripMenuItem();
            просмотрToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            масштабToolStripMenuItem = new ToolStripMenuItem();
            увеличитьToolStripMenuItem = new ToolStripMenuItem();
            уменьшитьToolStripMenuItem = new ToolStripMenuItem();
            поУмолчаниюToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBoxSearch = new TextBox();
            button1 = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, изменитьToolStripMenuItem, просмотрToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьФайлToolStripMenuItem, открытьФайлToolStripMenuItem, изменитьToolStripMenuItem1, сохранитьtxtToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // создатьФайлToolStripMenuItem
            // 
            создатьФайлToolStripMenuItem.Name = "создатьФайлToolStripMenuItem";
            создатьФайлToolStripMenuItem.Size = new Size(216, 26);
            создатьФайлToolStripMenuItem.Text = "Создать файл";
            создатьФайлToolStripMenuItem.Click += создатьФайлToolStripMenuItem_Click;
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(216, 26);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem1
            // 
            изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            изменитьToolStripMenuItem1.Size = new Size(216, 26);
            изменитьToolStripMenuItem1.Text = "Сохранить";
            изменитьToolStripMenuItem1.Click += изменитьToolStripMenuItem1_Click;
            // 
            // сохранитьtxtToolStripMenuItem
            // 
            сохранитьtxtToolStripMenuItem.Name = "сохранитьtxtToolStripMenuItem";
            сохранитьtxtToolStripMenuItem.Size = new Size(216, 26);
            сохранитьtxtToolStripMenuItem.Text = "Сохранить как .txt";
            сохранитьtxtToolStripMenuItem.Click += сохранитьtxtToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копироватьToolStripMenuItem, вырезатьToolStripMenuItem, вставитьToolStripMenuItem, выделитьВсеToolStripMenuItem });
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(92, 24);
            изменитьToolStripMenuItem.Text = "Изменить";
            изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(186, 26);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(186, 26);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(186, 26);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // выделитьВсеToolStripMenuItem
            // 
            выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            выделитьВсеToolStripMenuItem.Size = new Size(186, 26);
            выделитьВсеToolStripMenuItem.Text = "Выделить все";
            выделитьВсеToolStripMenuItem.Click += выделитьВсеToolStripMenuItem_Click;
            // 
            // просмотрToolStripMenuItem
            // 
            просмотрToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поискToolStripMenuItem, шрифтToolStripMenuItem, масштабToolStripMenuItem });
            просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            просмотрToolStripMenuItem.Size = new Size(94, 24);
            просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(224, 26);
            поискToolStripMenuItem.Text = "Поиск";
            поискToolStripMenuItem.Click += поискToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(224, 26);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // масштабToolStripMenuItem
            // 
            масштабToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { увеличитьToolStripMenuItem, уменьшитьToolStripMenuItem, поУмолчаниюToolStripMenuItem });
            масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            масштабToolStripMenuItem.Size = new Size(224, 26);
            масштабToolStripMenuItem.Text = "Масштаб";
            масштабToolStripMenuItem.Click += масштабToolStripMenuItem_Click;
            // 
            // увеличитьToolStripMenuItem
            // 
            увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            увеличитьToolStripMenuItem.Size = new Size(197, 26);
            увеличитьToolStripMenuItem.Text = "Увеличить";
            увеличитьToolStripMenuItem.Click += увеличитьToolStripMenuItem_Click;
            // 
            // уменьшитьToolStripMenuItem
            // 
            уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            уменьшитьToolStripMenuItem.Size = new Size(197, 26);
            уменьшитьToolStripMenuItem.Text = "Уменьшить";
            уменьшитьToolStripMenuItem.Click += уменьшитьToolStripMenuItem_Click;
            // 
            // поУмолчаниюToolStripMenuItem
            // 
            поУмолчаниюToolStripMenuItem.Name = "поУмолчаниюToolStripMenuItem";
            поУмолчаниюToolStripMenuItem.Size = new Size(197, 26);
            поУмолчаниюToolStripMenuItem.Text = "По умолчанию";
            поУмолчаниюToolStripMenuItem.Click += поУмолчаниюToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(800, 422);
            textBox1.TabIndex = 1;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(394, 28);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(260, 27);
            textBoxSearch.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(653, 27);
            button1.Name = "button1";
            button1.Size = new Size(37, 29);
            button1.TabIndex = 3;
            button1.Text = "⌕";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(747, 31);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(32, 29);
            buttonUp.TabIndex = 4;
            buttonUp.Text = "↑";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(747, 66);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(29, 29);
            buttonDown.TabIndex = 5;
            buttonDown.Text = "↓";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(button1);
            Controls.Add(textBoxSearch);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьФайлToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem1;
        private ToolStripMenuItem сохранитьtxtToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem увеличитьToolStripMenuItem;
        private ToolStripMenuItem уменьшитьToolStripMenuItem;
        private ToolStripMenuItem поУмолчаниюToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBoxSearch;
        private Button button1;
        private Button buttonUp;
        private Button buttonDown;
    }
}
