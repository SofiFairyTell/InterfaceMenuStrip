namespace VP_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматическоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самостоятельноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.взаимодействейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортирокаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.линейныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинарныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массиваСMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.сортировкаМассиваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массивОтсортированToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инкрименнтМассиваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дикриментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сОртСПИСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратныйПорядокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 363);
            this.dataGridView1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добалениеToolStripMenuItem,
            this.удалениеToolStripMenuItem,
            this.изменениеToolStripMenuItem,
            this.взаимодействейToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добалениеToolStripMenuItem
            // 
            this.добалениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автоматическоеToolStripMenuItem,
            this.самостоятельноеToolStripMenuItem});
            this.добалениеToolStripMenuItem.Name = "добалениеToolStripMenuItem";
            this.добалениеToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.добалениеToolStripMenuItem.Text = "Добаление";
            // 
            // автоматическоеToolStripMenuItem
            // 
            this.автоматическоеToolStripMenuItem.Name = "автоматическоеToolStripMenuItem";
            this.автоматическоеToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.автоматическоеToolStripMenuItem.Text = "Автоматическое";
            this.автоматическоеToolStripMenuItem.Click += new System.EventHandler(this.автоматическоеToolStripMenuItem_Click);
            // 
            // самостоятельноеToolStripMenuItem
            // 
            this.самостоятельноеToolStripMenuItem.Name = "самостоятельноеToolStripMenuItem";
            this.самостоятельноеToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.самостоятельноеToolStripMenuItem.Text = "Самостоятельное";
            this.самостоятельноеToolStripMenuItem.Click += new System.EventHandler(this.самостоятельноеToolStripMenuItem_Click);
            // 
            // удалениеToolStripMenuItem
            // 
            this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.удалениеToolStripMenuItem.Text = "Удаление";
            this.удалениеToolStripMenuItem.Click += new System.EventHandler(this.удалениеToolStripMenuItem_Click);
            // 
            // изменениеToolStripMenuItem
            // 
            this.изменениеToolStripMenuItem.Name = "изменениеToolStripMenuItem";
            this.изменениеToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.изменениеToolStripMenuItem.Text = "Изменение";
            this.изменениеToolStripMenuItem.Click += new System.EventHandler(this.изменениеToolStripMenuItem_Click);
            // 
            // взаимодействейToolStripMenuItem
            // 
            this.взаимодействейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортирокаToolStripMenuItem,
            this.поискToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.сортировкаМассиваToolStripMenuItem,
            this.сортToolStripMenuItem,
            this.массивОтсортированToolStripMenuItem,
            this.инкрименнтМассиваToolStripMenuItem,
            this.дикриментToolStripMenuItem,
            this.сОртСПИСToolStripMenuItem,
            this.обратныйПорядокToolStripMenuItem});
            this.взаимодействейToolStripMenuItem.Name = "взаимодействейToolStripMenuItem";
            this.взаимодействейToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.взаимодействейToolStripMenuItem.Text = "Взаимодействие";
            // 
            // сортирокаToolStripMenuItem
            // 
            this.сортирокаToolStripMenuItem.Name = "сортирокаToolStripMenuItem";
            this.сортирокаToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.сортирокаToolStripMenuItem.Text = "Сортировка списка";
            this.сортирокаToolStripMenuItem.Click += new System.EventHandler(this.сортирокаToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.линейныйToolStripMenuItem,
            this.бинарныйToolStripMenuItem,
            this.массиваСMaxToolStripMenuItem});
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.поискToolStripMenuItem1.Text = "Поиск";
            // 
            // линейныйToolStripMenuItem
            // 
            this.линейныйToolStripMenuItem.Name = "линейныйToolStripMenuItem";
            this.линейныйToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.линейныйToolStripMenuItem.Text = "Линейный";
            this.линейныйToolStripMenuItem.Click += new System.EventHandler(this.линейныйToolStripMenuItem_Click);
            // 
            // бинарныйToolStripMenuItem
            // 
            this.бинарныйToolStripMenuItem.Name = "бинарныйToolStripMenuItem";
            this.бинарныйToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.бинарныйToolStripMenuItem.Text = "Бинарный";
            this.бинарныйToolStripMenuItem.Click += new System.EventHandler(this.бинарныйToolStripMenuItem_Click);
            // 
            // массиваСMaxToolStripMenuItem
            // 
            this.массиваСMaxToolStripMenuItem.Name = "массиваСMaxToolStripMenuItem";
            this.массиваСMaxToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.массиваСMaxToolStripMenuItem.Text = "Массива с max";
            this.массиваСMaxToolStripMenuItem.Click += new System.EventHandler(this.массиваСMaxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // сортировкаМассиваToolStripMenuItem
            // 
            this.сортировкаМассиваToolStripMenuItem.Name = "сортировкаМассиваToolStripMenuItem";
            this.сортировкаМассиваToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.сортировкаМассиваToolStripMenuItem.Text = "Сортировка массива";
            this.сортировкаМассиваToolStripMenuItem.Click += new System.EventHandler(this.сортировкаМассиваToolStripMenuItem_Click);
            // 
            // сортToolStripMenuItem
            // 
            this.сортToolStripMenuItem.Name = "сортToolStripMenuItem";
            this.сортToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.сортToolStripMenuItem.Text = "Сортировка по уб.";
            this.сортToolStripMenuItem.Click += new System.EventHandler(this.сортToolStripMenuItem_Click);
            // 
            // массивОтсортированToolStripMenuItem
            // 
            this.массивОтсортированToolStripMenuItem.Name = "массивОтсортированToolStripMenuItem";
            this.массивОтсортированToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.массивОтсортированToolStripMenuItem.Text = "Массив отсортирован?";
            this.массивОтсортированToolStripMenuItem.Click += new System.EventHandler(this.массивОтсортированToolStripMenuItem_Click);
            // 
            // инкрименнтМассиваToolStripMenuItem
            // 
            this.инкрименнтМассиваToolStripMenuItem.Name = "инкрименнтМассиваToolStripMenuItem";
            this.инкрименнтМассиваToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.инкрименнтМассиваToolStripMenuItem.Text = "Инкримент массива";
            this.инкрименнтМассиваToolStripMenuItem.Click += new System.EventHandler(this.инкрименнтМассиваToolStripMenuItem_Click);
            // 
            // дикриментToolStripMenuItem
            // 
            this.дикриментToolStripMenuItem.Name = "дикриментToolStripMenuItem";
            this.дикриментToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.дикриментToolStripMenuItem.Text = "Дикримент массива";
            this.дикриментToolStripMenuItem.Click += new System.EventHandler(this.дикриментToolStripMenuItem_Click);
            // 
            // сОртСПИСToolStripMenuItem
            // 
            this.сОртСПИСToolStripMenuItem.Name = "сОртСПИСToolStripMenuItem";
            this.сОртСПИСToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.сОртСПИСToolStripMenuItem.Text = "Сортировка по сумме";
            this.сОртСПИСToolStripMenuItem.Click += new System.EventHandler(this.сОртСПИСToolStripMenuItem_Click);
            // 
            // обратныйПорядокToolStripMenuItem
            // 
            this.обратныйПорядокToolStripMenuItem.Name = "обратныйПорядокToolStripMenuItem";
            this.обратныйПорядокToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.обратныйПорядокToolStripMenuItem.Text = "Обратный порядок";
            this.обратныйПорядокToolStripMenuItem.Click += new System.EventHandler(this.обратныйПорядокToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добалениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоматическоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самостоятельноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem взаимодействейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортирокаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem линейныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаМассиваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem массивОтсортированToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инкрименнтМассиваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дикриментToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сОртСПИСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem массиваСMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратныйПорядокToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

