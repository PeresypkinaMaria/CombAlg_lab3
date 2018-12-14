namespace CombAlg_lab3
{
    partial class MainForm
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
            this.OrigLV = new System.Windows.Forms.ListView();
            this.NewLV = new System.Windows.Forms.ListView();
            this.lblOrig = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxW = new System.Windows.Forms.TextBox();
            this.Name_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weigth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weigth_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // OrigLV
            // 
            this.OrigLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_1,
            this.Weigth,
            this.Price});
            this.OrigLV.Location = new System.Drawing.Point(12, 43);
            this.OrigLV.Name = "OrigLV";
            this.OrigLV.Size = new System.Drawing.Size(396, 277);
            this.OrigLV.TabIndex = 0;
            this.OrigLV.UseCompatibleStateImageBehavior = false;
            this.OrigLV.View = System.Windows.Forms.View.Details;
            // 
            // NewLV
            // 
            this.NewLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_2,
            this.Weigth_1,
            this.Price_1});
            this.NewLV.Location = new System.Drawing.Point(438, 131);
            this.NewLV.Name = "NewLV";
            this.NewLV.Size = new System.Drawing.Size(396, 189);
            this.NewLV.TabIndex = 1;
            this.NewLV.UseCompatibleStateImageBehavior = false;
            this.NewLV.View = System.Windows.Forms.View.Details;
            // 
            // lblOrig
            // 
            this.lblOrig.AutoSize = true;
            this.lblOrig.Location = new System.Drawing.Point(12, 23);
            this.lblOrig.Name = "lblOrig";
            this.lblOrig.Size = new System.Drawing.Size(127, 17);
            this.lblOrig.TabIndex = 2;
            this.lblOrig.Text = "Исходные данные";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(435, 111);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(68, 17);
            this.lblNew.TabIndex = 3;
            this.lblNew.Text = "Решение";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(438, 52);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(136, 31);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Найти решение";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Максимальный вес рюкзака";
            // 
            // tbMaxW
            // 
            this.tbMaxW.Location = new System.Drawing.Point(650, 20);
            this.tbMaxW.Name = "tbMaxW";
            this.tbMaxW.Size = new System.Drawing.Size(100, 22);
            this.tbMaxW.TabIndex = 6;
            // 
            // Name_1
            // 
            this.Name_1.Text = "Название";
            this.Name_1.Width = 120;
            // 
            // Weigth
            // 
            this.Weigth.Text = "Вес";
            this.Weigth.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "Стоимость";
            this.Price.Width = 120;
            // 
            // Name_2
            // 
            this.Name_2.Text = "Название";
            this.Name_2.Width = 133;
            // 
            // Weigth_1
            // 
            this.Weigth_1.Text = "Вес";
            this.Weigth_1.Width = 98;
            // 
            // Price_1
            // 
            this.Price_1.Text = "Стоимость";
            this.Price_1.Width = 147;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 628);
            this.Controls.Add(this.tbMaxW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblOrig);
            this.Controls.Add(this.NewLV);
            this.Controls.Add(this.OrigLV);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OrigLV;
        private System.Windows.Forms.ListView NewLV;
        private System.Windows.Forms.Label lblOrig;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxW;
        private System.Windows.Forms.ColumnHeader Name_1;
        private System.Windows.Forms.ColumnHeader Weigth;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Name_2;
        private System.Windows.Forms.ColumnHeader Weigth_1;
        private System.Windows.Forms.ColumnHeader Price_1;
    }
}

