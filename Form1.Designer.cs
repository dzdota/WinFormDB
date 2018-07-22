namespace SimpleDBProject
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
            this.comboBoxCountryes = new System.Windows.Forms.ComboBox();
            this.comboBoxRegions = new System.Windows.Forms.ComboBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.dataGridViewEstablishment = new System.Windows.Forms.DataGridView();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.buttonAddEstablishment = new System.Windows.Forms.Button();
            this.buttonRemoveEstablishment = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.labelEstablishmentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEstablishmentType = new System.Windows.Forms.ComboBox();
            this.textBoxEstablishmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstablishment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCountryes
            // 
            this.comboBoxCountryes.FormattingEnabled = true;
            this.comboBoxCountryes.Location = new System.Drawing.Point(80, 348);
            this.comboBoxCountryes.Name = "comboBoxCountryes";
            this.comboBoxCountryes.Size = new System.Drawing.Size(262, 24);
            this.comboBoxCountryes.TabIndex = 0;
            this.comboBoxCountryes.TextChanged += new System.EventHandler(this.comboBoxCountryes_TextChanged);
            // 
            // comboBoxRegions
            // 
            this.comboBoxRegions.FormattingEnabled = true;
            this.comboBoxRegions.Location = new System.Drawing.Point(348, 348);
            this.comboBoxRegions.Name = "comboBoxRegions";
            this.comboBoxRegions.Size = new System.Drawing.Size(262, 24);
            this.comboBoxRegions.TabIndex = 0;
            this.comboBoxRegions.TextChanged += new System.EventHandler(this.comboBoxRegions_TextChanged);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(616, 348);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(340, 24);
            this.comboBoxCities.TabIndex = 0;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(80, 378);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(876, 22);
            this.textBoxAdress.TabIndex = 1;
            // 
            // dataGridViewEstablishment
            // 
            this.dataGridViewEstablishment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstablishment.Location = new System.Drawing.Point(56, 79);
            this.dataGridViewEstablishment.Name = "dataGridViewEstablishment";
            this.dataGridViewEstablishment.RowHeadersVisible = false;
            this.dataGridViewEstablishment.RowTemplate.Height = 24;
            this.dataGridViewEstablishment.Size = new System.Drawing.Size(900, 150);
            this.dataGridViewEstablishment.TabIndex = 2;
            this.dataGridViewEstablishment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstablishment_CellDoubleClick);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(56, 438);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowHeadersVisible = false;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.Size = new System.Drawing.Size(900, 150);
            this.dataGridViewRoom.TabIndex = 2;
            this.dataGridViewRoom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellDoubleClick);
            // 
            // buttonAddEstablishment
            // 
            this.buttonAddEstablishment.Location = new System.Drawing.Point(56, 236);
            this.buttonAddEstablishment.Name = "buttonAddEstablishment";
            this.buttonAddEstablishment.Size = new System.Drawing.Size(149, 23);
            this.buttonAddEstablishment.TabIndex = 3;
            this.buttonAddEstablishment.Text = "Додати заклад";
            this.buttonAddEstablishment.UseVisualStyleBackColor = true;
            this.buttonAddEstablishment.Click += new System.EventHandler(this.buttonAddEstablishment_Click);
            // 
            // buttonRemoveEstablishment
            // 
            this.buttonRemoveEstablishment.Location = new System.Drawing.Point(211, 236);
            this.buttonRemoveEstablishment.Name = "buttonRemoveEstablishment";
            this.buttonRemoveEstablishment.Size = new System.Drawing.Size(149, 23);
            this.buttonRemoveEstablishment.TabIndex = 3;
            this.buttonRemoveEstablishment.Text = "Видалити";
            this.buttonRemoveEstablishment.UseVisualStyleBackColor = true;
            this.buttonRemoveEstablishment.Click += new System.EventHandler(this.buttonRemoveEstablishment_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(56, 622);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(149, 23);
            this.buttonAddRoom.TabIndex = 3;
            this.buttonAddRoom.Text = "Додати приміщення";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.Location = new System.Drawing.Point(211, 622);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(149, 23);
            this.buttonRemoveRoom.TabIndex = 3;
            this.buttonRemoveRoom.Text = "Видалити";
            this.buttonRemoveRoom.UseVisualStyleBackColor = true;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.buttonRemoveRoom_Click);
            // 
            // labelEstablishmentName
            // 
            this.labelEstablishmentName.AutoSize = true;
            this.labelEstablishmentName.Location = new System.Drawing.Point(53, 39);
            this.labelEstablishmentName.Name = "labelEstablishmentName";
            this.labelEstablishmentName.Size = new System.Drawing.Size(0, 17);
            this.labelEstablishmentName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва закладу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип закладу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адреса закладу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(696, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "_________________________________________________________________________________" +
    "_____";
            // 
            // comboBoxEstablishmentType
            // 
            this.comboBoxEstablishmentType.FormattingEnabled = true;
            this.comboBoxEstablishmentType.Items.AddRange(new object[] {
            "Театр",
            "Готель",
            "Кафе"});
            this.comboBoxEstablishmentType.Location = new System.Drawing.Point(211, 292);
            this.comboBoxEstablishmentType.Name = "comboBoxEstablishmentType";
            this.comboBoxEstablishmentType.Size = new System.Drawing.Size(203, 24);
            this.comboBoxEstablishmentType.TabIndex = 0;
            this.comboBoxEstablishmentType.TextChanged += new System.EventHandler(this.comboBoxRegions_TextChanged);
            // 
            // textBoxEstablishmentName
            // 
            this.textBoxEstablishmentName.Location = new System.Drawing.Point(211, 265);
            this.textBoxEstablishmentName.Name = "textBoxEstablishmentName";
            this.textBoxEstablishmentName.Size = new System.Drawing.Size(587, 22);
            this.textBoxEstablishmentName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(52, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Приміщення закладу";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(755, 594);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(889, 594);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 594);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(693, 22);
            this.textBox3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 690);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEstablishmentName);
            this.Controls.Add(this.buttonRemoveRoom);
            this.Controls.Add(this.buttonRemoveEstablishment);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.buttonAddEstablishment);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.dataGridViewEstablishment);
            this.Controls.Add(this.textBoxEstablishmentName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.comboBoxEstablishmentType);
            this.Controls.Add(this.comboBoxRegions);
            this.Controls.Add(this.comboBoxCountryes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstablishment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCountryes;
        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.DataGridView dataGridViewEstablishment;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Button buttonAddEstablishment;
        private System.Windows.Forms.Button buttonRemoveEstablishment;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Label labelEstablishmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEstablishmentType;
        private System.Windows.Forms.TextBox textBoxEstablishmentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

