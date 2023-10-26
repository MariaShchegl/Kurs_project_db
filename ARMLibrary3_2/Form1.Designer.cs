namespace ARMLibrary3_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.войтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧитателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧитателяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принятьКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списатьКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемкаКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.войтиToolStripMenuItem,
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1199, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // войтиToolStripMenuItem
            // 
            this.войтиToolStripMenuItem.Name = "войтиToolStripMenuItem";
            this.войтиToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
            this.войтиToolStripMenuItem.Text = "Войти";
            this.войтиToolStripMenuItem.Click += new System.EventHandler(this.войтиToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЧитателяToolStripMenuItem,
            this.книгиToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.действияToolStripMenuItem.Text = "Действия";
            this.действияToolStripMenuItem.Visible = false;
            // 
            // добавитьЧитателяToolStripMenuItem
            // 
            this.добавитьЧитателяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЧитателяToolStripMenuItem1,
            this.просмотретьToolStripMenuItem,
            this.должникиToolStripMenuItem});
            this.добавитьЧитателяToolStripMenuItem.Name = "добавитьЧитателяToolStripMenuItem";
            this.добавитьЧитателяToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.добавитьЧитателяToolStripMenuItem.Text = "Читатели";
            this.добавитьЧитателяToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧитателяToolStripMenuItem_Click);
            // 
            // добавитьЧитателяToolStripMenuItem1
            // 
            this.добавитьЧитателяToolStripMenuItem1.Name = "добавитьЧитателяToolStripMenuItem1";
            this.добавитьЧитателяToolStripMenuItem1.Size = new System.Drawing.Size(280, 32);
            this.добавитьЧитателяToolStripMenuItem1.Text = "Добавить читателя";
            this.добавитьЧитателяToolStripMenuItem1.Click += new System.EventHandler(this.добавитьЧитателяToolStripMenuItem1_Click);
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(280, 32);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть список";
            this.просмотретьToolStripMenuItem.Click += new System.EventHandler(this.просмотретьToolStripMenuItem_Click);
            // 
            // должникиToolStripMenuItem
            // 
            this.должникиToolStripMenuItem.Name = "должникиToolStripMenuItem";
            this.должникиToolStripMenuItem.Size = new System.Drawing.Size(280, 32);
            this.должникиToolStripMenuItem.Text = "Должники";
            this.должникиToolStripMenuItem.Click += new System.EventHandler(this.должникиToolStripMenuItem_Click);
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.принятьКнигиToolStripMenuItem,
            this.списатьКнигиToolStripMenuItem,
            this.приемкаКнигToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // принятьКнигиToolStripMenuItem
            // 
            this.принятьКнигиToolStripMenuItem.Name = "принятьКнигиToolStripMenuItem";
            this.принятьКнигиToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.принятьКнигиToolStripMenuItem.Text = "Забрать книги";
            this.принятьКнигиToolStripMenuItem.Click += new System.EventHandler(this.принятьКнигиToolStripMenuItem_Click);
            // 
            // списатьКнигиToolStripMenuItem
            // 
            this.списатьКнигиToolStripMenuItem.Name = "списатьКнигиToolStripMenuItem";
            this.списатьКнигиToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.списатьКнигиToolStripMenuItem.Text = "Списать книги";
            // 
            // приемкаКнигToolStripMenuItem
            // 
            this.приемкаКнигToolStripMenuItem.Name = "приемкаКнигToolStripMenuItem";
            this.приемкаКнигToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.приемкаКнигToolStripMenuItem.Text = "Приемка книг";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(96, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(972, 30);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1075, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(15, 86);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(1164, 454);
            this.checkedListBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1055, 585);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Заказать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(892, 585);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Подробнее";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(765, 585);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "Выдать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 642);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1065, 513);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧитателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧитателяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem принятьКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списатьКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемкаКнигToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        public System.Windows.Forms.ToolStripMenuItem войтиToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
    }
}

