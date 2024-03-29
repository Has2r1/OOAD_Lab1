namespace Lab1_Test
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.edQuality = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btAddGem = new System.Windows.Forms.Button();
            this.edGemWeight = new System.Windows.Forms.NumericUpDown();
            this.edGemMult = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edBaseDamage = new System.Windows.Forms.NumericUpDown();
            this.edBaseCapacity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btBuildItem = new System.Windows.Forms.Button();
            this.itemDataOutput = new System.Windows.Forms.Label();
            this.currentGemsOutput = new System.Windows.Forms.Label();
            this.clearGemsList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edDurability = new System.Windows.Forms.NumericUpDown();
            this.edRarity = new System.Windows.Forms.ComboBox();
            this.edVeiled = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edGemWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edGemMult)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edBaseDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBaseCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDurability)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edQuality);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btAddGem);
            this.panel1.Controls.Add(this.edGemWeight);
            this.panel1.Controls.Add(this.edGemMult);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 165);
            this.panel1.TabIndex = 0;
            // 
            // edQuality
            // 
            this.edQuality.Location = new System.Drawing.Point(170, 102);
            this.edQuality.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.edQuality.Name = "edQuality";
            this.edQuality.Size = new System.Drawing.Size(88, 20);
            this.edQuality.TabIndex = 7;
            this.edQuality.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Качество:";
            // 
            // btAddGem
            // 
            this.btAddGem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddGem.Location = new System.Drawing.Point(74, 132);
            this.btAddGem.Name = "btAddGem";
            this.btAddGem.Size = new System.Drawing.Size(127, 26);
            this.btAddGem.TabIndex = 5;
            this.btAddGem.Text = "Добавить";
            this.btAddGem.UseVisualStyleBackColor = true;
            this.btAddGem.Click += new System.EventHandler(this.btAddGem_Click);
            // 
            // edGemWeight
            // 
            this.edGemWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edGemWeight.Location = new System.Drawing.Point(170, 46);
            this.edGemWeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.edGemWeight.Name = "edGemWeight";
            this.edGemWeight.Size = new System.Drawing.Size(88, 20);
            this.edGemWeight.TabIndex = 4;
            this.edGemWeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edGemMult
            // 
            this.edGemMult.DecimalPlaces = 1;
            this.edGemMult.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edGemMult.Location = new System.Drawing.Point(170, 74);
            this.edGemMult.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edGemMult.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edGemMult.Name = "edGemMult";
            this.edGemMult.Size = new System.Drawing.Size(88, 20);
            this.edGemMult.TabIndex = 3;
            this.edGemMult.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Множитель урона: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить камень";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.edVeiled);
            this.panel2.Controls.Add(this.edRarity);
            this.panel2.Controls.Add(this.edDurability);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.edBaseDamage);
            this.panel2.Controls.Add(this.edBaseCapacity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(309, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 224);
            this.panel2.TabIndex = 1;
            // 
            // edBaseDamage
            // 
            this.edBaseDamage.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edBaseDamage.Location = new System.Drawing.Point(170, 46);
            this.edBaseDamage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edBaseDamage.Name = "edBaseDamage";
            this.edBaseDamage.Size = new System.Drawing.Size(88, 20);
            this.edBaseDamage.TabIndex = 4;
            this.edBaseDamage.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edBaseDamage.ValueChanged += new System.EventHandler(this.edBaseDamage_ValueChanged);
            // 
            // edBaseCapacity
            // 
            this.edBaseCapacity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edBaseCapacity.Location = new System.Drawing.Point(170, 89);
            this.edBaseCapacity.Name = "edBaseCapacity";
            this.edBaseCapacity.Size = new System.Drawing.Size(88, 20);
            this.edBaseCapacity.TabIndex = 3;
            this.edBaseCapacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Вместимость:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Урон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(351, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Базовые значения";
            // 
            // btBuildItem
            // 
            this.btBuildItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBuildItem.Location = new System.Drawing.Point(603, 26);
            this.btBuildItem.Name = "btBuildItem";
            this.btBuildItem.Size = new System.Drawing.Size(252, 37);
            this.btBuildItem.TabIndex = 8;
            this.btBuildItem.Text = "Собрать со строителем";
            this.btBuildItem.UseVisualStyleBackColor = true;
            this.btBuildItem.Click += new System.EventHandler(this.btBuildItem_Click);
            // 
            // itemDataOutput
            // 
            this.itemDataOutput.AutoSize = true;
            this.itemDataOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemDataOutput.Location = new System.Drawing.Point(599, 195);
            this.itemDataOutput.Name = "itemDataOutput";
            this.itemDataOutput.Size = new System.Drawing.Size(255, 24);
            this.itemDataOutput.TabIndex = 9;
            this.itemDataOutput.Text = "Характеристики предмета:";
            // 
            // currentGemsOutput
            // 
            this.currentGemsOutput.AutoSize = true;
            this.currentGemsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentGemsOutput.Location = new System.Drawing.Point(12, 195);
            this.currentGemsOutput.Name = "currentGemsOutput";
            this.currentGemsOutput.Size = new System.Drawing.Size(118, 18);
            this.currentGemsOutput.TabIndex = 10;
            this.currentGemsOutput.Text = "Текущие камни:";
            // 
            // clearGemsList
            // 
            this.clearGemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearGemsList.Location = new System.Drawing.Point(12, 471);
            this.clearGemsList.Name = "clearGemsList";
            this.clearGemsList.Size = new System.Drawing.Size(164, 28);
            this.clearGemsList.TabIndex = 6;
            this.clearGemsList.Text = "Очистить список ";
            this.clearGemsList.UseVisualStyleBackColor = true;
            this.clearGemsList.Click += new System.EventHandler(this.clearGemsList_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(603, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Собрать без строителя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(185, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Убрать последний";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Прочность:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Редкость:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(15, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Зачарование:";
            // 
            // edDurability
            // 
            this.edDurability.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edDurability.Location = new System.Drawing.Point(170, 125);
            this.edDurability.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edDurability.Name = "edDurability";
            this.edDurability.Size = new System.Drawing.Size(88, 20);
            this.edDurability.TabIndex = 14;
            this.edDurability.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.edDurability.ValueChanged += new System.EventHandler(this.edDurability_ValueChanged);
            // 
            // edRarity
            // 
            this.edRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edRarity.FormattingEnabled = true;
            this.edRarity.Items.AddRange(new object[] {
            "Normal",
            "Magic",
            "Rare",
            "Unique",
            "Legendary"});
            this.edRarity.Location = new System.Drawing.Point(170, 159);
            this.edRarity.Name = "edRarity";
            this.edRarity.Size = new System.Drawing.Size(88, 21);
            this.edRarity.TabIndex = 12;
            this.edRarity.SelectedIndex = 0;
            this.edRarity.SelectedIndexChanged += new System.EventHandler(this.edRarity_SelectedIndexChanged);
            // 
            // edVeiled
            // 
            this.edVeiled.AutoSize = true;
            this.edVeiled.Location = new System.Drawing.Point(201, 199);
            this.edVeiled.Name = "edVeiled";
            this.edVeiled.Size = new System.Drawing.Size(15, 14);
            this.edVeiled.TabIndex = 12;
            this.edVeiled.UseVisualStyleBackColor = true;
            this.edVeiled.CheckedChanged += new System.EventHandler(this.edVeiled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearGemsList);
            this.Controls.Add(this.currentGemsOutput);
            this.Controls.Add(this.itemDataOutput);
            this.Controls.Add(this.btBuildItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edGemWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edGemMult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edBaseDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBaseCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDurability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edGemWeight;
        private System.Windows.Forms.NumericUpDown edGemMult;
        private System.Windows.Forms.Button btAddGem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown edBaseDamage;
        private System.Windows.Forms.NumericUpDown edBaseCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBuildItem;
        public System.Windows.Forms.Label itemDataOutput;
        private System.Windows.Forms.Label currentGemsOutput;
        private System.Windows.Forms.Button clearGemsList;
        private System.Windows.Forms.NumericUpDown edQuality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox edRarity;
        private System.Windows.Forms.NumericUpDown edDurability;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox edVeiled;
    }
}

