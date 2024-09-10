namespace tema1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alfaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRadioButton = new System.Windows.Forms.RadioButton();
            this.gradRadioButton = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            this.z1Label = new System.Windows.Forms.Label();
            this.z2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // alfaTextBox
            // 
            this.alfaTextBox.Location = new System.Drawing.Point(35, 270);
            this.alfaTextBox.Name = "alfaTextBox";
            this.alfaTextBox.Size = new System.Drawing.Size(157, 20);
            this.alfaTextBox.TabIndex = 1;
            this.alfaTextBox.TextChanged += new System.EventHandler(this.alfaTextBox_TextChanged);
            this.alfaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alfaTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите угол альфа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRadioButton);
            this.groupBox1.Controls.Add(this.gradRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(283, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод угла:";
            // 
            // radRadioButton
            // 
            this.radRadioButton.AutoSize = true;
            this.radRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radRadioButton.Location = new System.Drawing.Point(20, 68);
            this.radRadioButton.Name = "radRadioButton";
            this.radRadioButton.Size = new System.Drawing.Size(99, 20);
            this.radRadioButton.TabIndex = 1;
            this.radRadioButton.Text = "в радианах";
            this.radRadioButton.UseVisualStyleBackColor = true;
            // 
            // gradRadioButton
            // 
            this.gradRadioButton.AutoSize = true;
            this.gradRadioButton.Checked = true;
            this.gradRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradRadioButton.Location = new System.Drawing.Point(20, 32);
            this.gradRadioButton.Name = "gradRadioButton";
            this.gradRadioButton.Size = new System.Drawing.Size(96, 20);
            this.gradRadioButton.TabIndex = 0;
            this.gradRadioButton.TabStop = true;
            this.gradRadioButton.Text = "в градусах";
            this.gradRadioButton.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.calcButton.Enabled = false;
            this.calcButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcButton.ForeColor = System.Drawing.Color.White;
            this.calcButton.Location = new System.Drawing.Point(175, 372);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(147, 51);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Вычислить";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // z1Label
            // 
            this.z1Label.AutoSize = true;
            this.z1Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.z1Label.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z1Label.Location = new System.Drawing.Point(31, 441);
            this.z1Label.Name = "z1Label";
            this.z1Label.Size = new System.Drawing.Size(33, 20);
            this.z1Label.TabIndex = 7;
            this.z1Label.Text = "z1 =";
            this.z1Label.MouseLeave += new System.EventHandler(this.z1Label_MouseLeave);
            this.z1Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.z1Label_MouseMove);
            // 
            // z2Label
            // 
            this.z2Label.AutoSize = true;
            this.z2Label.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z2Label.Location = new System.Drawing.Point(32, 479);
            this.z2Label.Name = "z2Label";
            this.z2Label.Size = new System.Drawing.Size(35, 20);
            this.z2Label.TabIndex = 8;
            this.z2Label.Text = "z2 =";
            this.z2Label.MouseLeave += new System.EventHandler(this.z2Label_MouseLeave);
            this.z2Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.z2Label_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(520, 553);
            this.Controls.Add(this.z2Label);
            this.Controls.Add(this.z1Label);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alfaTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Вычисление по формулам";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox alfaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRadioButton;
        private System.Windows.Forms.RadioButton gradRadioButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label z1Label;
        private System.Windows.Forms.Label z2Label;
    }
}

