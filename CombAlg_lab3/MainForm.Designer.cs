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
            this.Name_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weigth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVPermut = new System.Windows.Forms.ListView();
            this.Name_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weigth_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrig = new System.Windows.Forms.Label();
            this.lblPerm = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblMaxWeigth = new System.Windows.Forms.Label();
            this.tbMaxW = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.LVGen = new System.Windows.Forms.ListView();
            this.Name_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weigth_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTimePerm = new System.Windows.Forms.Label();
            this.tbTimePerm = new System.Windows.Forms.TextBox();
            this.lblTimeGen = new System.Windows.Forms.Label();
            this.tbTimeGen = new System.Windows.Forms.TextBox();
            this.lblForGen = new System.Windows.Forms.Label();
            this.lblCntSteps = new System.Windows.Forms.Label();
            this.nudCntSteps = new System.Windows.Forms.NumericUpDown();
            this.lblCntChr = new System.Windows.Forms.Label();
            this.nudCntChr = new System.Windows.Forms.NumericUpDown();
            this.lblCntParChr = new System.Windows.Forms.Label();
            this.nudCntParChr = new System.Windows.Forms.NumericUpDown();
            this.lblCntMutChr = new System.Windows.Forms.Label();
            this.nudCnrMutChr = new System.Windows.Forms.NumericUpDown();
            this.lblProcMut = new System.Windows.Forms.Label();
            this.nudMutProc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCntSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCntChr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCntParChr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCnrMutChr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutProc)).BeginInit();
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
            this.OrigLV.Size = new System.Drawing.Size(396, 226);
            this.OrigLV.TabIndex = 0;
            this.OrigLV.UseCompatibleStateImageBehavior = false;
            this.OrigLV.View = System.Windows.Forms.View.Details;
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
            // LVPermut
            // 
            this.LVPermut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_2,
            this.Weigth_1,
            this.Price_1});
            this.LVPermut.Location = new System.Drawing.Point(15, 318);
            this.LVPermut.Name = "LVPermut";
            this.LVPermut.Size = new System.Drawing.Size(396, 189);
            this.LVPermut.TabIndex = 1;
            this.LVPermut.UseCompatibleStateImageBehavior = false;
            this.LVPermut.View = System.Windows.Forms.View.Details;
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
            // lblOrig
            // 
            this.lblOrig.AutoSize = true;
            this.lblOrig.Location = new System.Drawing.Point(12, 23);
            this.lblOrig.Name = "lblOrig";
            this.lblOrig.Size = new System.Drawing.Size(127, 17);
            this.lblOrig.TabIndex = 2;
            this.lblOrig.Text = "Исходные данные";
            // 
            // lblPerm
            // 
            this.lblPerm.AutoSize = true;
            this.lblPerm.Location = new System.Drawing.Point(12, 298);
            this.lblPerm.Name = "lblPerm";
            this.lblPerm.Size = new System.Drawing.Size(139, 17);
            this.lblPerm.TabIndex = 3;
            this.lblPerm.Text = "Перебор вариантов";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(438, 238);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(136, 31);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Найти решение";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblMaxWeigth
            // 
            this.lblMaxWeigth.AutoSize = true;
            this.lblMaxWeigth.Location = new System.Drawing.Point(435, 23);
            this.lblMaxWeigth.Name = "lblMaxWeigth";
            this.lblMaxWeigth.Size = new System.Drawing.Size(91, 17);
            this.lblMaxWeigth.TabIndex = 5;
            this.lblMaxWeigth.Text = "Вес рюкзака";
            // 
            // tbMaxW
            // 
            this.tbMaxW.Location = new System.Drawing.Point(532, 20);
            this.tbMaxW.Name = "tbMaxW";
            this.tbMaxW.Size = new System.Drawing.Size(100, 22);
            this.tbMaxW.TabIndex = 6;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(485, 298);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(166, 17);
            this.lblGen.TabIndex = 7;
            this.lblGen.Text = "Генетический алгоритм";
            // 
            // LVGen
            // 
            this.LVGen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_3,
            this.Weigth_3,
            this.Price_3});
            this.LVGen.Location = new System.Drawing.Point(488, 318);
            this.LVGen.Name = "LVGen";
            this.LVGen.Size = new System.Drawing.Size(401, 189);
            this.LVGen.TabIndex = 8;
            this.LVGen.UseCompatibleStateImageBehavior = false;
            // 
            // Name_3
            // 
            this.Name_3.Text = "Название";
            // 
            // Weigth_3
            // 
            this.Weigth_3.Text = "Вес";
            // 
            // Price_3
            // 
            this.Price_3.Text = "Стоимость";
            // 
            // lblTimePerm
            // 
            this.lblTimePerm.AutoSize = true;
            this.lblTimePerm.Location = new System.Drawing.Point(12, 522);
            this.lblTimePerm.Name = "lblTimePerm";
            this.lblTimePerm.Size = new System.Drawing.Size(124, 17);
            this.lblTimePerm.TabIndex = 9;
            this.lblTimePerm.Text = "Время в секундах";
            // 
            // tbTimePerm
            // 
            this.tbTimePerm.Location = new System.Drawing.Point(15, 542);
            this.tbTimePerm.Name = "tbTimePerm";
            this.tbTimePerm.ReadOnly = true;
            this.tbTimePerm.Size = new System.Drawing.Size(121, 22);
            this.tbTimePerm.TabIndex = 10;
            // 
            // lblTimeGen
            // 
            this.lblTimeGen.AutoSize = true;
            this.lblTimeGen.Location = new System.Drawing.Point(485, 522);
            this.lblTimeGen.Name = "lblTimeGen";
            this.lblTimeGen.Size = new System.Drawing.Size(124, 17);
            this.lblTimeGen.TabIndex = 11;
            this.lblTimeGen.Text = "Время в секундах";
            // 
            // tbTimeGen
            // 
            this.tbTimeGen.Location = new System.Drawing.Point(488, 542);
            this.tbTimeGen.Name = "tbTimeGen";
            this.tbTimeGen.ReadOnly = true;
            this.tbTimeGen.Size = new System.Drawing.Size(121, 22);
            this.tbTimeGen.TabIndex = 12;
            // 
            // lblForGen
            // 
            this.lblForGen.AutoSize = true;
            this.lblForGen.Location = new System.Drawing.Point(435, 55);
            this.lblForGen.Name = "lblForGen";
            this.lblForGen.Size = new System.Drawing.Size(207, 17);
            this.lblForGen.TabIndex = 13;
            this.lblForGen.Text = "Для генетического алгоритма";
            // 
            // lblCntSteps
            // 
            this.lblCntSteps.AutoSize = true;
            this.lblCntSteps.Location = new System.Drawing.Point(435, 82);
            this.lblCntSteps.Name = "lblCntSteps";
            this.lblCntSteps.Size = new System.Drawing.Size(129, 17);
            this.lblCntSteps.TabIndex = 14;
            this.lblCntSteps.Text = "Количество шагов";
            // 
            // nudCntSteps
            // 
            this.nudCntSteps.Location = new System.Drawing.Point(570, 80);
            this.nudCntSteps.Name = "nudCntSteps";
            this.nudCntSteps.Size = new System.Drawing.Size(92, 22);
            this.nudCntSteps.TabIndex = 15;
            // 
            // lblCntChr
            // 
            this.lblCntChr.AutoSize = true;
            this.lblCntChr.Location = new System.Drawing.Point(435, 114);
            this.lblCntChr.Name = "lblCntChr";
            this.lblCntChr.Size = new System.Drawing.Size(153, 17);
            this.lblCntChr.TabIndex = 16;
            this.lblCntChr.Text = "Количество хромосом";
            // 
            // nudCntChr
            // 
            this.nudCntChr.Location = new System.Drawing.Point(594, 114);
            this.nudCntChr.Name = "nudCntChr";
            this.nudCntChr.Size = new System.Drawing.Size(95, 22);
            this.nudCntChr.TabIndex = 17;
            // 
            // lblCntParChr
            // 
            this.lblCntParChr.AutoSize = true;
            this.lblCntParChr.Location = new System.Drawing.Point(435, 142);
            this.lblCntParChr.Name = "lblCntParChr";
            this.lblCntParChr.Size = new System.Drawing.Size(343, 17);
            this.lblCntParChr.TabIndex = 18;
            this.lblCntParChr.Text = "Кол-во отбираемых хромосом в каждом поколении";
            // 
            // nudCntParChr
            // 
            this.nudCntParChr.Location = new System.Drawing.Point(784, 142);
            this.nudCntParChr.Name = "nudCntParChr";
            this.nudCntParChr.Size = new System.Drawing.Size(91, 22);
            this.nudCntParChr.TabIndex = 19;
            // 
            // lblCntMutChr
            // 
            this.lblCntMutChr.AutoSize = true;
            this.lblCntMutChr.Location = new System.Drawing.Point(435, 171);
            this.lblCntMutChr.Name = "lblCntMutChr";
            this.lblCntMutChr.Size = new System.Drawing.Size(205, 17);
            this.lblCntMutChr.TabIndex = 20;
            this.lblCntMutChr.Text = "Кол-во мутирующих хромосом";
            // 
            // nudCnrMutChr
            // 
            this.nudCnrMutChr.Location = new System.Drawing.Point(646, 171);
            this.nudCnrMutChr.Name = "nudCnrMutChr";
            this.nudCnrMutChr.Size = new System.Drawing.Size(95, 22);
            this.nudCnrMutChr.TabIndex = 21;
            // 
            // lblProcMut
            // 
            this.lblProcMut.AutoSize = true;
            this.lblProcMut.Location = new System.Drawing.Point(435, 203);
            this.lblProcMut.Name = "lblProcMut";
            this.lblProcMut.Size = new System.Drawing.Size(262, 17);
            this.lblProcMut.TabIndex = 22;
            this.lblProcMut.Text = "Вероятность мутации (в процентах %)";
            // 
            // nudMutProc
            // 
            this.nudMutProc.Location = new System.Drawing.Point(703, 203);
            this.nudMutProc.Name = "nudMutProc";
            this.nudMutProc.Size = new System.Drawing.Size(98, 22);
            this.nudMutProc.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 578);
            this.Controls.Add(this.nudMutProc);
            this.Controls.Add(this.lblProcMut);
            this.Controls.Add(this.nudCnrMutChr);
            this.Controls.Add(this.lblCntMutChr);
            this.Controls.Add(this.nudCntParChr);
            this.Controls.Add(this.lblCntParChr);
            this.Controls.Add(this.nudCntChr);
            this.Controls.Add(this.lblCntChr);
            this.Controls.Add(this.nudCntSteps);
            this.Controls.Add(this.lblCntSteps);
            this.Controls.Add(this.lblForGen);
            this.Controls.Add(this.tbTimeGen);
            this.Controls.Add(this.lblTimeGen);
            this.Controls.Add(this.tbTimePerm);
            this.Controls.Add(this.lblTimePerm);
            this.Controls.Add(this.LVGen);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.tbMaxW);
            this.Controls.Add(this.lblMaxWeigth);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblPerm);
            this.Controls.Add(this.lblOrig);
            this.Controls.Add(this.LVPermut);
            this.Controls.Add(this.OrigLV);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.nudCntSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCntChr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCntParChr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCnrMutChr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutProc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OrigLV;
        private System.Windows.Forms.ListView LVPermut;
        private System.Windows.Forms.Label lblOrig;
        private System.Windows.Forms.Label lblPerm;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblMaxWeigth;
        private System.Windows.Forms.TextBox tbMaxW;
        private System.Windows.Forms.ColumnHeader Name_1;
        private System.Windows.Forms.ColumnHeader Weigth;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Name_2;
        private System.Windows.Forms.ColumnHeader Weigth_1;
        private System.Windows.Forms.ColumnHeader Price_1;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.ListView LVGen;
        private System.Windows.Forms.ColumnHeader Name_3;
        private System.Windows.Forms.ColumnHeader Weigth_3;
        private System.Windows.Forms.ColumnHeader Price_3;
        private System.Windows.Forms.Label lblTimePerm;
        private System.Windows.Forms.TextBox tbTimePerm;
        private System.Windows.Forms.Label lblTimeGen;
        private System.Windows.Forms.TextBox tbTimeGen;
        private System.Windows.Forms.Label lblForGen;
        private System.Windows.Forms.Label lblCntSteps;
        private System.Windows.Forms.NumericUpDown nudCntSteps;
        private System.Windows.Forms.Label lblCntChr;
        private System.Windows.Forms.NumericUpDown nudCntChr;
        private System.Windows.Forms.Label lblCntParChr;
        private System.Windows.Forms.NumericUpDown nudCntParChr;
        private System.Windows.Forms.Label lblCntMutChr;
        private System.Windows.Forms.NumericUpDown nudCnrMutChr;
        private System.Windows.Forms.Label lblProcMut;
        private System.Windows.Forms.NumericUpDown nudMutProc;
    }
}

