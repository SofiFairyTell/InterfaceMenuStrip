﻿namespace VP_LW_6
{
    partial class MenuStrip
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
            this.массивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиСКлавиатурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AвтоматическиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранныйМассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПонаибольшемуколичествунулейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинарныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруСтолбцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранныхМассивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменениеЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьВсеНа1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьВсеНа1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // массивToolStripMenuItem
            // 
            this.массивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.просмотретьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выгрузитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.массивToolStripMenuItem.Name = "массивToolStripMenuItem";
            this.массивToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.массивToolStripMenuItem.Text = "Работа с массивом";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ввестиСКлавиатурыToolStripMenuItem,
            this.AвтоматическиToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // ввестиСКлавиатурыToolStripMenuItem
            // 
            this.ввестиСКлавиатурыToolStripMenuItem.Name = "ввестиСКлавиатурыToolStripMenuItem";
            this.ввестиСКлавиатурыToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ввестиСКлавиатурыToolStripMenuItem.Text = "Ввести с клавиатуры";
            this.ввестиСКлавиатурыToolStripMenuItem.Click += new System.EventHandler(this.ВвестиСКлавиатурыToolStripMenuItem_Click);
            // 
            // AвтоматическиToolStripMenuItem
            // 
            this.AвтоматическиToolStripMenuItem.Name = "AвтоматическиToolStripMenuItem";
            this.AвтоматическиToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.AвтоматическиToolStripMenuItem.Text = "Автоматически";
            this.AвтоматическиToolStripMenuItem.Click += new System.EventHandler(this.АвтоматическиToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьВсеToolStripMenuItem,
            this.выбранныйМассивToolStripMenuItem});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            this.очиститьВсеToolStripMenuItem.Click += new System.EventHandler(this.ОчиститьВсеToolStripMenuItem_Click);
            // 
            // выбранныйМассивToolStripMenuItem
            // 
            this.выбранныйМассивToolStripMenuItem.Name = "выбранныйМассивToolStripMenuItem";
            this.выбранныйМассивToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.выбранныйМассивToolStripMenuItem.Text = "Выбранный массив";
            this.выбранныйМассивToolStripMenuItem.Click += new System.EventHandler(this.ВыбранныйМассивToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem.Click += new System.EventHandler(this.ПросмотретьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // выгрузитьToolStripMenuItem
            // 
            this.выгрузитьToolStripMenuItem.Name = "выгрузитьToolStripMenuItem";
            this.выгрузитьToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.выгрузитьToolStripMenuItem.Text = "Выгрузить";
            this.выгрузитьToolStripMenuItem.Click += new System.EventHandler(this.ВыгрузитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // работаToolStripMenuItem
            // 
            this.работаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.суммаToolStripMenuItem,
            this.изменениеЭлементовToolStripMenuItem});
            this.работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            this.работаToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.работаToolStripMenuItem.Text = "Действия над данными";
            this.работаToolStripMenuItem.Click += new System.EventHandler(this.работаToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ПонаибольшемуколичествунулейToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // ПонаибольшемуколичествунулейToolStripMenuItem
            // 
            this.ПонаибольшемуколичествунулейToolStripMenuItem.Name = "ПонаибольшемуколичествунулейToolStripMenuItem";
            this.ПонаибольшемуколичествунулейToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.ПонаибольшемуколичествунулейToolStripMenuItem.Text = "По наибольшему количеству нулей";
            this.ПонаибольшемуколичествунулейToolStripMenuItem.Click += new System.EventHandler(this.ПонаибольшемуколичествунулейToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.линейныйToolStripMenuItem,
            this.бинарныйToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // линейныйToolStripMenuItem
            // 
            this.линейныйToolStripMenuItem.Name = "линейныйToolStripMenuItem";
            this.линейныйToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.линейныйToolStripMenuItem.Text = "Линейный";
            this.линейныйToolStripMenuItem.Click += new System.EventHandler(this.линейныйToolStripMenuItem_Click);
            // 
            // бинарныйToolStripMenuItem
            // 
            this.бинарныйToolStripMenuItem.Name = "бинарныйToolStripMenuItem";
            this.бинарныйToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.бинарныйToolStripMenuItem.Text = "Бинарный";
            this.бинарныйToolStripMenuItem.Click += new System.EventHandler(this.бинарныйToolStripMenuItem_Click);
            // 
            // суммаToolStripMenuItem
            // 
            this.суммаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруСтолбцаToolStripMenuItem,
            this.выбранныхМассивовToolStripMenuItem});
            this.суммаToolStripMenuItem.Name = "суммаToolStripMenuItem";
            this.суммаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.суммаToolStripMenuItem.Text = "Сумма";
            // 
            // поНомеруСтолбцаToolStripMenuItem
            // 
            this.поНомеруСтолбцаToolStripMenuItem.Name = "поНомеруСтолбцаToolStripMenuItem";
            this.поНомеруСтолбцаToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.поНомеруСтолбцаToolStripMenuItem.Text = "По номеру столбца";
            this.поНомеруСтолбцаToolStripMenuItem.Click += new System.EventHandler(this.ПоНомеруСтолбцаToolStripMenuItem_Click);
            // 
            // выбранныхМассивовToolStripMenuItem
            // 
            this.выбранныхМассивовToolStripMenuItem.Name = "выбранныхМассивовToolStripMenuItem";
            this.выбранныхМассивовToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.выбранныхМассивовToolStripMenuItem.Text = "Выбранных массивов";
            this.выбранныхМассивовToolStripMenuItem.Click += new System.EventHandler(this.ВыбранныхМассивовToolStripMenuItem_Click);
            // 
            // изменениеЭлементовToolStripMenuItem
            // 
            this.изменениеЭлементовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьВсеНа1ToolStripMenuItem,
            this.уменьшитьВсеНа1ToolStripMenuItem});
            this.изменениеЭлементовToolStripMenuItem.Name = "изменениеЭлементовToolStripMenuItem";
            this.изменениеЭлементовToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.изменениеЭлементовToolStripMenuItem.Text = "Изменение элементов";
            // 
            // увеличитьВсеНа1ToolStripMenuItem
            // 
            this.увеличитьВсеНа1ToolStripMenuItem.Name = "увеличитьВсеНа1ToolStripMenuItem";
            this.увеличитьВсеНа1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.увеличитьВсеНа1ToolStripMenuItem.Text = "Увеличить все на 1";
            this.увеличитьВсеНа1ToolStripMenuItem.Click += new System.EventHandler(this.УвеличитьВсеНа1ToolStripMenuItem_Click);
            // 
            // уменьшитьВсеНа1ToolStripMenuItem
            // 
            this.уменьшитьВсеНа1ToolStripMenuItem.Name = "уменьшитьВсеНа1ToolStripMenuItem";
            this.уменьшитьВсеНа1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.уменьшитьВсеНа1ToolStripMenuItem.Text = "Уменьшить все на 1";
            this.уменьшитьВсеНа1ToolStripMenuItem.Click += new System.EventHandler(this.УменьшитьВсеНа1ToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.массивToolStripMenuItem,
            this.работаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 46);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(360, 292);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridView2_AllowUserToAddRowsChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(31, 394);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(228, 44);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Записать данные";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowBox
            // 
            this.ShowBox.Location = new System.Drawing.Point(413, 65);
            this.ShowBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowBox.Multiline = true;
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(375, 91);
            this.ShowBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результаты";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuStrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с массивами";
            this.Load += new System.EventHandler(this.MenuStrip_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem массивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиСКлавиатурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AвтоматическиToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменениеЭлементовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьВсеНа1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьВсеНа1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поНомеруСтолбцаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбранныхМассивовToolStripMenuItem;
        internal System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ShowBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбранныйМассивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПонаибольшемуколичествунулейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныйToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

