namespace Lab3
{
    partial class createNewMammaliaDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createNewMammaliaDialog));
            this.addAndClose = new System.Windows.Forms.Button();
            this.exitDiolog = new System.Windows.Forms.Button();
            this.labelMulticellular = new System.Windows.Forms.Label();
            this.labelDioecious = new System.Windows.Forms.Label();
            this.labelPhylum = new System.Windows.Forms.Label();
            this.labelClassis = new System.Windows.Forms.Label();
            this.labelAerobe = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHabitat1 = new System.Windows.Forms.TextBox();
            this.textBoxHabitat2 = new System.Windows.Forms.TextBox();
            this.textBoxHabitat3 = new System.Windows.Forms.TextBox();
            this.textBoxHabitat4 = new System.Windows.Forms.TextBox();
            this.textBoxPhylum = new System.Windows.Forms.TextBox();
            this.textBoxClassis = new System.Windows.Forms.TextBox();
            this.textBoxSpecies = new System.Windows.Forms.TextBox();
            this.labelYes = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.checkBoxDioeciousYes = new System.Windows.Forms.CheckBox();
            this.checkBoxDioeciousNo = new System.Windows.Forms.CheckBox();
            this.radioMulticellularYes = new System.Windows.Forms.RadioButton();
            this.radioMulticellularNo = new System.Windows.Forms.RadioButton();
            this.checkBoxAerobeNo = new System.Windows.Forms.CheckBox();
            this.checkBoxAerobeYes = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // addAndClose
            // 
            this.addAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addAndClose.Location = new System.Drawing.Point(30, 335);
            this.addAndClose.Name = "addAndClose";
            this.addAndClose.Size = new System.Drawing.Size(75, 40);
            this.addAndClose.TabIndex = 0;
            this.addAndClose.Text = "Добавить записи";
            this.addAndClose.UseVisualStyleBackColor = true;
            this.addAndClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitDiolog
            // 
            this.exitDiolog.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitDiolog.Location = new System.Drawing.Point(174, 335);
            this.exitDiolog.Name = "exitDiolog";
            this.exitDiolog.Size = new System.Drawing.Size(75, 40);
            this.exitDiolog.TabIndex = 1;
            this.exitDiolog.Text = "Выход";
            this.exitDiolog.UseVisualStyleBackColor = true;
            this.exitDiolog.Click += new System.EventHandler(this.exitDiolog_Click);
            // 
            // labelMulticellular
            // 
            this.labelMulticellular.AutoSize = true;
            this.labelMulticellular.Location = new System.Drawing.Point(27, 31);
            this.labelMulticellular.Name = "labelMulticellular";
            this.labelMulticellular.Size = new System.Drawing.Size(93, 13);
            this.labelMulticellular.TabIndex = 2;
            this.labelMulticellular.Text = "Многоклеточные";
            // 
            // labelDioecious
            // 
            this.labelDioecious.AutoSize = true;
            this.labelDioecious.Location = new System.Drawing.Point(27, 68);
            this.labelDioecious.Name = "labelDioecious";
            this.labelDioecious.Size = new System.Drawing.Size(66, 13);
            this.labelDioecious.TabIndex = 4;
            this.labelDioecious.Text = "Двоеполые";
            // 
            // labelPhylum
            // 
            this.labelPhylum.AutoSize = true;
            this.labelPhylum.Location = new System.Drawing.Point(27, 98);
            this.labelPhylum.Name = "labelPhylum";
            this.labelPhylum.Size = new System.Drawing.Size(26, 13);
            this.labelPhylum.TabIndex = 5;
            this.labelPhylum.Text = "Тип";
            // 
            // labelClassis
            // 
            this.labelClassis.AutoSize = true;
            this.labelClassis.Location = new System.Drawing.Point(27, 126);
            this.labelClassis.Name = "labelClassis";
            this.labelClassis.Size = new System.Drawing.Size(38, 13);
            this.labelClassis.TabIndex = 6;
            this.labelClassis.Text = "Класс";
            // 
            // labelAerobe
            // 
            this.labelAerobe.AutoSize = true;
            this.labelAerobe.Location = new System.Drawing.Point(27, 49);
            this.labelAerobe.Name = "labelAerobe";
            this.labelAerobe.Size = new System.Drawing.Size(58, 13);
            this.labelAerobe.TabIndex = 7;
            this.labelAerobe.Text = "Аэробные";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(27, 153);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(26, 13);
            this.labelSpecies.TabIndex = 8;
            this.labelSpecies.Text = "Вид";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(86, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Места обитания";
            // 
            // textBoxHabitat1
            // 
            this.textBoxHabitat1.Location = new System.Drawing.Point(30, 227);
            this.textBoxHabitat1.Name = "textBoxHabitat1";
            this.textBoxHabitat1.Size = new System.Drawing.Size(219, 20);
            this.textBoxHabitat1.TabIndex = 10;
            this.textBoxHabitat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxHabitat2
            // 
            this.textBoxHabitat2.Location = new System.Drawing.Point(30, 253);
            this.textBoxHabitat2.Name = "textBoxHabitat2";
            this.textBoxHabitat2.Size = new System.Drawing.Size(219, 20);
            this.textBoxHabitat2.TabIndex = 11;
            this.textBoxHabitat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxHabitat3
            // 
            this.textBoxHabitat3.Location = new System.Drawing.Point(30, 279);
            this.textBoxHabitat3.Name = "textBoxHabitat3";
            this.textBoxHabitat3.Size = new System.Drawing.Size(219, 20);
            this.textBoxHabitat3.TabIndex = 12;
            this.textBoxHabitat3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxHabitat4
            // 
            this.textBoxHabitat4.Location = new System.Drawing.Point(30, 305);
            this.textBoxHabitat4.Name = "textBoxHabitat4";
            this.textBoxHabitat4.Size = new System.Drawing.Size(219, 20);
            this.textBoxHabitat4.TabIndex = 13;
            this.textBoxHabitat4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPhylum
            // 
            this.textBoxPhylum.Location = new System.Drawing.Point(89, 98);
            this.textBoxPhylum.Name = "textBoxPhylum";
            this.textBoxPhylum.ReadOnly = true;
            this.textBoxPhylum.Size = new System.Drawing.Size(160, 20);
            this.textBoxPhylum.TabIndex = 14;
            this.textBoxPhylum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxClassis
            // 
            this.textBoxClassis.Location = new System.Drawing.Point(89, 124);
            this.textBoxClassis.Name = "textBoxClassis";
            this.textBoxClassis.ReadOnly = true;
            this.textBoxClassis.Size = new System.Drawing.Size(160, 20);
            this.textBoxClassis.TabIndex = 15;
            this.textBoxClassis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSpecies
            // 
            this.textBoxSpecies.Location = new System.Drawing.Point(89, 150);
            this.textBoxSpecies.Name = "textBoxSpecies";
            this.textBoxSpecies.Size = new System.Drawing.Size(160, 20);
            this.textBoxSpecies.TabIndex = 16;
            this.textBoxSpecies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSpecies.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // labelYes
            // 
            this.labelYes.AutoSize = true;
            this.labelYes.Location = new System.Drawing.Point(180, 9);
            this.labelYes.Name = "labelYes";
            this.labelYes.Size = new System.Drawing.Size(22, 13);
            this.labelYes.TabIndex = 17;
            this.labelYes.Text = "Да";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(223, 9);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(26, 13);
            this.labelNo.TabIndex = 18;
            this.labelNo.Text = "Нет";
            // 
            // checkBoxDioeciousYes
            // 
            this.checkBoxDioeciousYes.AutoSize = true;
            this.checkBoxDioeciousYes.Location = new System.Drawing.Point(183, 68);
            this.checkBoxDioeciousYes.Name = "checkBoxDioeciousYes";
            this.checkBoxDioeciousYes.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDioeciousYes.TabIndex = 19;
            this.checkBoxDioeciousYes.UseVisualStyleBackColor = true;
            this.checkBoxDioeciousYes.CheckedChanged += new System.EventHandler(this.checkBoxDioeciousYes_CheckedChanged);
            // 
            // checkBoxDioeciousNo
            // 
            this.checkBoxDioeciousNo.AutoSize = true;
            this.checkBoxDioeciousNo.Location = new System.Drawing.Point(226, 68);
            this.checkBoxDioeciousNo.Name = "checkBoxDioeciousNo";
            this.checkBoxDioeciousNo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDioeciousNo.TabIndex = 20;
            this.checkBoxDioeciousNo.UseVisualStyleBackColor = true;
            this.checkBoxDioeciousNo.CheckedChanged += new System.EventHandler(this.checkBoxDioeciousNo_CheckedChanged);
            // 
            // radioMulticellularYes
            // 
            this.radioMulticellularYes.AutoSize = true;
            this.radioMulticellularYes.Location = new System.Drawing.Point(184, 30);
            this.radioMulticellularYes.Name = "radioMulticellularYes";
            this.radioMulticellularYes.Size = new System.Drawing.Size(14, 13);
            this.radioMulticellularYes.TabIndex = 23;
            this.radioMulticellularYes.TabStop = true;
            this.radioMulticellularYes.UseVisualStyleBackColor = true;
            this.radioMulticellularYes.CheckedChanged += new System.EventHandler(this.radioMulticellularYes_CheckedChanged);
            // 
            // radioMulticellularNo
            // 
            this.radioMulticellularNo.AutoSize = true;
            this.radioMulticellularNo.Location = new System.Drawing.Point(226, 30);
            this.radioMulticellularNo.Name = "radioMulticellularNo";
            this.radioMulticellularNo.Size = new System.Drawing.Size(14, 13);
            this.radioMulticellularNo.TabIndex = 24;
            this.radioMulticellularNo.TabStop = true;
            this.radioMulticellularNo.UseVisualStyleBackColor = true;
            this.radioMulticellularNo.CheckedChanged += new System.EventHandler(this.radioMulticellularNo_CheckedChanged);
            // 
            // checkBoxAerobeNo
            // 
            this.checkBoxAerobeNo.AutoSize = true;
            this.checkBoxAerobeNo.Location = new System.Drawing.Point(226, 48);
            this.checkBoxAerobeNo.Name = "checkBoxAerobeNo";
            this.checkBoxAerobeNo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAerobeNo.TabIndex = 26;
            this.checkBoxAerobeNo.UseVisualStyleBackColor = true;
            this.checkBoxAerobeNo.CheckedChanged += new System.EventHandler(this.checkBoxAerobeNo_CheckedChanged);
            // 
            // checkBoxAerobeYes
            // 
            this.checkBoxAerobeYes.AutoSize = true;
            this.checkBoxAerobeYes.Location = new System.Drawing.Point(183, 48);
            this.checkBoxAerobeYes.Name = "checkBoxAerobeYes";
            this.checkBoxAerobeYes.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAerobeYes.TabIndex = 25;
            this.checkBoxAerobeYes.UseVisualStyleBackColor = true;
            this.checkBoxAerobeYes.CheckedChanged += new System.EventHandler(this.checkBoxAerobeYes_CheckedChanged);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(174, 177);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownWeight.TabIndex = 27;
            this.numericUpDownWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(28, 181);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(85, 13);
            this.labelWeight.TabIndex = 28;
            this.labelWeight.Text = "Средняя масса";
            // 
            // createNewMammaliaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 402);
            this.ControlBox = false;
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.checkBoxAerobeNo);
            this.Controls.Add(this.checkBoxAerobeYes);
            this.Controls.Add(this.radioMulticellularNo);
            this.Controls.Add(this.radioMulticellularYes);
            this.Controls.Add(this.checkBoxDioeciousNo);
            this.Controls.Add(this.checkBoxDioeciousYes);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.labelYes);
            this.Controls.Add(this.textBoxSpecies);
            this.Controls.Add(this.textBoxClassis);
            this.Controls.Add(this.textBoxPhylum);
            this.Controls.Add(this.textBoxHabitat4);
            this.Controls.Add(this.textBoxHabitat3);
            this.Controls.Add(this.textBoxHabitat2);
            this.Controls.Add(this.textBoxHabitat1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.labelAerobe);
            this.Controls.Add(this.labelClassis);
            this.Controls.Add(this.labelPhylum);
            this.Controls.Add(this.labelDioecious);
            this.Controls.Add(this.labelMulticellular);
            this.Controls.Add(this.exitDiolog);
            this.Controls.Add(this.addAndClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "createNewMammaliaDialog";
            this.Text = "Ввод данных";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Button addAndClose;
        private System.Windows.Forms.Button exitDiolog;
        private System.Windows.Forms.Label labelMulticellular;
        private System.Windows.Forms.Label labelDioecious;
        private System.Windows.Forms.Label labelPhylum;
        private System.Windows.Forms.Label labelClassis;
        private System.Windows.Forms.Label labelAerobe;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHabitat1;
        private System.Windows.Forms.TextBox textBoxHabitat2;
        private System.Windows.Forms.TextBox textBoxHabitat3;
        private System.Windows.Forms.TextBox textBoxHabitat4;
        private System.Windows.Forms.TextBox textBoxPhylum;
        private System.Windows.Forms.TextBox textBoxClassis;
        private System.Windows.Forms.TextBox textBoxSpecies;
        private System.Windows.Forms.Label labelYes;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.CheckBox checkBoxDioeciousYes;
        private System.Windows.Forms.CheckBox checkBoxDioeciousNo;
        private System.Windows.Forms.RadioButton radioMulticellularYes;
        private System.Windows.Forms.RadioButton radioMulticellularNo;
        private System.Windows.Forms.CheckBox checkBoxAerobeNo;
        private System.Windows.Forms.CheckBox checkBoxAerobeYes;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelWeight;
    }
}