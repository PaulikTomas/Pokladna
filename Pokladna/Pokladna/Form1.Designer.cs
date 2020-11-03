namespace Pokladna
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxObdobi = new System.Windows.Forms.GroupBox();
            this.comboBoxMesic = new System.Windows.Forms.ComboBox();
            this.comboBoxRok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxPolozka = new System.Windows.Forms.GroupBox();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.buttonUlozitJako = new System.Windows.Forms.Button();
            this.textBoxPoznamka = new System.Windows.Forms.TextBox();
            this.numericUpDownCastka = new System.Windows.Forms.NumericUpDown();
            this.textBoxPopis = new System.Windows.Forms.TextBox();
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxObdobi.SuspendLayout();
            this.groupBoxPolozka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCastka)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxObdobi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(579, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxObdobi
            // 
            this.groupBoxObdobi.Controls.Add(this.comboBoxMesic);
            this.groupBoxObdobi.Controls.Add(this.comboBoxRok);
            this.groupBoxObdobi.Controls.Add(this.label2);
            this.groupBoxObdobi.Controls.Add(this.label1);
            this.groupBoxObdobi.Location = new System.Drawing.Point(3, 3);
            this.groupBoxObdobi.Name = "groupBoxObdobi";
            this.groupBoxObdobi.Size = new System.Drawing.Size(221, 86);
            this.groupBoxObdobi.TabIndex = 0;
            this.groupBoxObdobi.TabStop = false;
            this.groupBoxObdobi.Text = "Účetní období";
            // 
            // comboBoxMesic
            // 
            this.comboBoxMesic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMesic.FormattingEnabled = true;
            this.comboBoxMesic.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červenec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.comboBoxMesic.Location = new System.Drawing.Point(63, 51);
            this.comboBoxMesic.Name = "comboBoxMesic";
            this.comboBoxMesic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMesic.TabIndex = 3;
            this.comboBoxMesic.SelectedIndexChanged += new System.EventHandler(this.comboBoxRok_SelectedIndexChanged);
            // 
            // comboBoxRok
            // 
            this.comboBoxRok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRok.FormattingEnabled = true;
            this.comboBoxRok.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.comboBoxRok.Location = new System.Drawing.Point(63, 24);
            this.comboBoxRok.Name = "comboBoxRok";
            this.comboBoxRok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRok.TabIndex = 2;
            this.comboBoxRok.SelectedIndexChanged += new System.EventHandler(this.comboBoxRok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Měsíc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rok:";
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvData.GridLines = true;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(0, 0);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(579, 450);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Číslo dokladu";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popis";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Příjmy";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Výdaje";
            this.columnHeader5.Width = 55;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zůstatek";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Poznámka";
            this.columnHeader7.Width = 261;
            // 
            // groupBoxPolozka
            // 
            this.groupBoxPolozka.Controls.Add(this.buttonUlozit);
            this.groupBoxPolozka.Controls.Add(this.buttonUlozitJako);
            this.groupBoxPolozka.Controls.Add(this.textBoxPoznamka);
            this.groupBoxPolozka.Controls.Add(this.numericUpDownCastka);
            this.groupBoxPolozka.Controls.Add(this.textBoxPopis);
            this.groupBoxPolozka.Controls.Add(this.textBoxCislo);
            this.groupBoxPolozka.Controls.Add(this.dateTimePickerDatum);
            this.groupBoxPolozka.Controls.Add(this.label7);
            this.groupBoxPolozka.Controls.Add(this.label6);
            this.groupBoxPolozka.Controls.Add(this.label5);
            this.groupBoxPolozka.Controls.Add(this.label4);
            this.groupBoxPolozka.Controls.Add(this.label3);
            this.groupBoxPolozka.Location = new System.Drawing.Point(583, 96);
            this.groupBoxPolozka.Name = "groupBoxPolozka";
            this.groupBoxPolozka.Size = new System.Drawing.Size(217, 198);
            this.groupBoxPolozka.TabIndex = 4;
            this.groupBoxPolozka.TabStop = false;
            this.groupBoxPolozka.Text = "Položka";
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(113, 155);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonUlozit.TabIndex = 11;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            // 
            // buttonUlozitJako
            // 
            this.buttonUlozitJako.Location = new System.Drawing.Point(13, 155);
            this.buttonUlozitJako.Name = "buttonUlozitJako";
            this.buttonUlozitJako.Size = new System.Drawing.Size(94, 23);
            this.buttonUlozitJako.TabIndex = 10;
            this.buttonUlozitJako.Text = "Uložit jako nový";
            this.buttonUlozitJako.UseVisualStyleBackColor = true;
            this.buttonUlozitJako.Click += new System.EventHandler(this.buttonUlozitJako_Click);
            // 
            // textBoxPoznamka
            // 
            this.textBoxPoznamka.Location = new System.Drawing.Point(67, 129);
            this.textBoxPoznamka.Name = "textBoxPoznamka";
            this.textBoxPoznamka.Size = new System.Drawing.Size(121, 20);
            this.textBoxPoznamka.TabIndex = 9;
            // 
            // numericUpDownCastka
            // 
            this.numericUpDownCastka.Location = new System.Drawing.Point(67, 103);
            this.numericUpDownCastka.Name = "numericUpDownCastka";
            this.numericUpDownCastka.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownCastka.TabIndex = 8;
            this.numericUpDownCastka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCastka.ValueChanged += new System.EventHandler(this.numericUpDownCastka_ValueChanged);
            // 
            // textBoxPopis
            // 
            this.textBoxPopis.Location = new System.Drawing.Point(67, 77);
            this.textBoxPopis.Name = "textBoxPopis";
            this.textBoxPopis.Size = new System.Drawing.Size(121, 20);
            this.textBoxPopis.TabIndex = 7;
            this.textBoxPopis.TextChanged += new System.EventHandler(this.textBoxPopis_TextChanged);
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Location = new System.Drawing.Point(67, 51);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.ReadOnly = true;
            this.textBoxCislo.Size = new System.Drawing.Size(121, 20);
            this.textBoxCislo.TabIndex = 6;
            this.textBoxCislo.TextChanged += new System.EventHandler(this.textBoxCislo_TextChanged);
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(67, 25);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDatum.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Poznámka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Částka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Popis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Č. dokladu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.groupBoxPolozka);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxObdobi.ResumeLayout(false);
            this.groupBoxObdobi.PerformLayout();
            this.groupBoxPolozka.ResumeLayout(false);
            this.groupBoxPolozka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCastka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBoxObdobi;
        private System.Windows.Forms.ComboBox comboBoxMesic;
        private System.Windows.Forms.ComboBox comboBoxRok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPolozka;
        private System.Windows.Forms.TextBox textBoxPopis;
        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPoznamka;
        private System.Windows.Forms.NumericUpDown numericUpDownCastka;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Button buttonUlozitJako;
    }
}

