namespace Laba1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsWord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsCB = new System.Windows.Forms.ToolStripComboBox();
            this.tsbSystemMonitor = new System.Windows.Forms.ToolStripButton();
            this.lvMainData = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsWord
            // 
            this.tsWord.Name = "tsWord";
            this.tsWord.Size = new System.Drawing.Size(32, 19);
            // 
            // tsPDF
            // 
            this.tsPDF.Name = "tsPDF";
            this.tsPDF.Size = new System.Drawing.Size(32, 19);
            // 
            // tsTxt
            // 
            this.tsTxt.Name = "tsTxt";
            this.tsTxt.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.tsCB,
            this.tsbSystemMonitor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(749, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(115, 25);
            this.toolStripTextBox1.Text = "Выберите элемент :";
            // 
            // tsCB
            // 
            this.tsCB.Items.AddRange(new object[] {
            "Процессор",
            "Чипсет",
            "Батарея",
            "Биос",
            "Оперативная память",
            "Кэш",
            "USB",
            "Диск",
            "Логические диски",
            "Клавиатура",
            "Сеть",
            "Пользователь"});
            this.tsCB.Name = "tsCB";
            this.tsCB.Size = new System.Drawing.Size(121, 25);
            this.tsCB.Click += new System.EventHandler(this.tsCB_Click);
            // 
            // tsbSystemMonitor
            // 
            this.tsbSystemMonitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSystemMonitor.Image = ((System.Drawing.Image)(resources.GetObject("tsbSystemMonitor.Image")));
            this.tsbSystemMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSystemMonitor.Name = "tsbSystemMonitor";
            this.tsbSystemMonitor.Size = new System.Drawing.Size(23, 22);
            this.tsbSystemMonitor.Text = "toolStripButton1";
            this.tsbSystemMonitor.Click += new System.EventHandler(this.tsbSystemMonitor_Click);
            // 
            // lvMainData
            // 
            this.lvMainData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMainData.HideSelection = false;
            this.lvMainData.Location = new System.Drawing.Point(70, 70);
            this.lvMainData.Name = "lvMainData";
            this.lvMainData.Size = new System.Drawing.Size(603, 288);
            this.lvMainData.TabIndex = 2;
            this.lvMainData.UseCompatibleStateImageBehavior = false;
            this.lvMainData.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 407);
            this.Controls.Add(this.lvMainData);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Характеристики элементов компьютера";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tsCB;
        private System.Windows.Forms.ListView lvMainData;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem tsWord;
        private System.Windows.Forms.ToolStripMenuItem tsPDF;
        private System.Windows.Forms.ToolStripMenuItem tsTxt;
        private System.Windows.Forms.ToolStripButton tsbSystemMonitor;
    }
}

