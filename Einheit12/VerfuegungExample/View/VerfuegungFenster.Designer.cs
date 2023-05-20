namespace Einheit12.VerfuegungExample.View
{
    partial class VerfuegungFenster
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
            components = new System.ComponentModel.Container();
            LblVornameE = new Label();
            LblNachnameE = new Label();
            LblAdresseE = new Label();
            LblPlzE = new Label();
            LblOrtE = new Label();
            LblNrE = new Label();
            TxtVornameE = new TextBox();
            splitter1 = new Splitter();
            TxtNachnameE = new TextBox();
            TxtAdresseE = new TextBox();
            TxtOrtE = new TextBox();
            NupPlzE = new NumericUpDown();
            NupNrE = new NumericUpDown();
            LblErwaegung = new Label();
            TxtErwaegung = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            NupNrA = new NumericUpDown();
            NupPlzA = new NumericUpDown();
            TxtOrtA = new TextBox();
            TxtAdresseA = new TextBox();
            TxtNachnameA = new TextBox();
            TxtVornameA = new TextBox();
            LblNrA = new Label();
            LblOrtA = new Label();
            LblPlzA = new Label();
            LblAdresseA = new Label();
            LblNachnameA = new Label();
            LblVornameA = new Label();
            label12 = new Label();
            label13 = new Label();
            BtnDrucken = new Button();
            ((System.ComponentModel.ISupportInitialize)NupPlzE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupNrE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupNrA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupPlzA).BeginInit();
            SuspendLayout();
            // 
            // LblVornameE
            // 
            LblVornameE.AutoSize = true;
            LblVornameE.Location = new Point(40, 64);
            LblVornameE.Name = "LblVornameE";
            LblVornameE.Size = new Size(83, 25);
            LblVornameE.TabIndex = 0;
            LblVornameE.Text = "Vorname";
            // 
            // LblNachnameE
            // 
            LblNachnameE.AutoSize = true;
            LblNachnameE.Location = new Point(40, 106);
            LblNachnameE.Name = "LblNachnameE";
            LblNachnameE.Size = new Size(96, 25);
            LblNachnameE.TabIndex = 1;
            LblNachnameE.Text = "Nachname";
            // 
            // LblAdresseE
            // 
            LblAdresseE.AutoSize = true;
            LblAdresseE.Location = new Point(40, 147);
            LblAdresseE.Name = "LblAdresseE";
            LblAdresseE.Size = new Size(75, 25);
            LblAdresseE.TabIndex = 2;
            LblAdresseE.Text = "Adresse";
            // 
            // LblPlzE
            // 
            LblPlzE.AutoSize = true;
            LblPlzE.Location = new Point(43, 186);
            LblPlzE.Name = "LblPlzE";
            LblPlzE.Size = new Size(41, 25);
            LblPlzE.TabIndex = 3;
            LblPlzE.Text = "PLZ";
            // 
            // LblOrtE
            // 
            LblOrtE.AutoSize = true;
            LblOrtE.Location = new Point(40, 220);
            LblOrtE.Name = "LblOrtE";
            LblOrtE.Size = new Size(38, 25);
            LblOrtE.TabIndex = 4;
            LblOrtE.Text = "Ort";
            // 
            // LblNrE
            // 
            LblNrE.AutoSize = true;
            LblNrE.Location = new Point(343, 147);
            LblNrE.Name = "LblNrE";
            LblNrE.Size = new Size(35, 25);
            LblNrE.TabIndex = 5;
            LblNrE.Text = "Nr.";
            // 
            // TxtVornameE
            // 
            TxtVornameE.Location = new Point(147, 64);
            TxtVornameE.Name = "TxtVornameE";
            TxtVornameE.Size = new Size(150, 31);
            TxtVornameE.TabIndex = 6;
            TxtVornameE.Text = "Larissa";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 569);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // TxtNachnameE
            // 
            TxtNachnameE.Location = new Point(147, 101);
            TxtNachnameE.Name = "TxtNachnameE";
            TxtNachnameE.Size = new Size(150, 31);
            TxtNachnameE.TabIndex = 8;
            TxtNachnameE.Text = "Fitze";
            // 
            // TxtAdresseE
            // 
            TxtAdresseE.Location = new Point(147, 141);
            TxtAdresseE.Name = "TxtAdresseE";
            TxtAdresseE.Size = new Size(150, 31);
            TxtAdresseE.TabIndex = 9;
            TxtAdresseE.Text = "Rychstr";
            // 
            // TxtOrtE
            // 
            TxtOrtE.Location = new Point(147, 214);
            TxtOrtE.Name = "TxtOrtE";
            TxtOrtE.Size = new Size(150, 31);
            TxtOrtE.TabIndex = 11;
            TxtOrtE.Text = "Winterthur";
            // 
            // NupPlzE
            // 
            NupPlzE.Location = new Point(147, 177);
            NupPlzE.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NupPlzE.Minimum = new decimal(new int[] { 8400, 0, 0, 0 });
            NupPlzE.Name = "NupPlzE";
            NupPlzE.Size = new Size(150, 31);
            NupPlzE.TabIndex = 12;
            NupPlzE.Value = new decimal(new int[] { 8400, 0, 0, 0 });
            // 
            // NupNrE
            // 
            NupNrE.Location = new Point(375, 145);
            NupNrE.Name = "NupNrE";
            NupNrE.Size = new Size(64, 31);
            NupNrE.TabIndex = 13;
            NupNrE.Value = new decimal(new int[] { 23, 0, 0, 0 });
            // 
            // LblErwaegung
            // 
            LblErwaegung.AutoSize = true;
            LblErwaegung.Location = new Point(40, 290);
            LblErwaegung.Name = "LblErwaegung";
            LblErwaegung.Size = new Size(91, 25);
            LblErwaegung.TabIndex = 14;
            LblErwaegung.Text = "Erwägung";
            // 
            // TxtErwaegung
            // 
            TxtErwaegung.Location = new Point(147, 287);
            TxtErwaegung.Multiline = true;
            TxtErwaegung.Name = "TxtErwaegung";
            TxtErwaegung.Size = new Size(768, 126);
            TxtErwaegung.TabIndex = 15;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // NupNrA
            // 
            NupNrA.Location = new Point(851, 145);
            NupNrA.Name = "NupNrA";
            NupNrA.Size = new Size(64, 31);
            NupNrA.TabIndex = 27;
            NupNrA.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // NupPlzA
            // 
            NupPlzA.Location = new Point(623, 177);
            NupPlzA.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NupPlzA.Name = "NupPlzA";
            NupPlzA.Size = new Size(150, 31);
            NupPlzA.TabIndex = 26;
            NupPlzA.Value = new decimal(new int[] { 8000, 0, 0, 0 });
            // 
            // TxtOrtA
            // 
            TxtOrtA.Location = new Point(623, 214);
            TxtOrtA.Name = "TxtOrtA";
            TxtOrtA.Size = new Size(150, 31);
            TxtOrtA.TabIndex = 25;
            TxtOrtA.Text = "Zürich";
            // 
            // TxtAdresseA
            // 
            TxtAdresseA.Location = new Point(623, 141);
            TxtAdresseA.Name = "TxtAdresseA";
            TxtAdresseA.Size = new Size(150, 31);
            TxtAdresseA.TabIndex = 24;
            TxtAdresseA.Text = "Bachstrasse";
            // 
            // TxtNachnameA
            // 
            TxtNachnameA.Location = new Point(623, 101);
            TxtNachnameA.Name = "TxtNachnameA";
            TxtNachnameA.Size = new Size(150, 31);
            TxtNachnameA.TabIndex = 23;
            TxtNachnameA.Text = "Muster";
            // 
            // TxtVornameA
            // 
            TxtVornameA.Location = new Point(623, 64);
            TxtVornameA.Name = "TxtVornameA";
            TxtVornameA.Size = new Size(150, 31);
            TxtVornameA.TabIndex = 22;
            TxtVornameA.Text = "Maria";
            // 
            // LblNrA
            // 
            LblNrA.AutoSize = true;
            LblNrA.Location = new Point(819, 147);
            LblNrA.Name = "LblNrA";
            LblNrA.Size = new Size(35, 25);
            LblNrA.TabIndex = 21;
            LblNrA.Text = "Nr.";
            // 
            // LblOrtA
            // 
            LblOrtA.AutoSize = true;
            LblOrtA.Location = new Point(516, 220);
            LblOrtA.Name = "LblOrtA";
            LblOrtA.Size = new Size(38, 25);
            LblOrtA.TabIndex = 20;
            LblOrtA.Text = "Ort";
            // 
            // LblPlzA
            // 
            LblPlzA.AutoSize = true;
            LblPlzA.Location = new Point(519, 186);
            LblPlzA.Name = "LblPlzA";
            LblPlzA.Size = new Size(41, 25);
            LblPlzA.TabIndex = 19;
            LblPlzA.Text = "PLZ";
            // 
            // LblAdresseA
            // 
            LblAdresseA.AutoSize = true;
            LblAdresseA.Location = new Point(516, 147);
            LblAdresseA.Name = "LblAdresseA";
            LblAdresseA.Size = new Size(75, 25);
            LblAdresseA.TabIndex = 18;
            LblAdresseA.Text = "Adresse";
            // 
            // LblNachnameA
            // 
            LblNachnameA.AutoSize = true;
            LblNachnameA.Location = new Point(516, 106);
            LblNachnameA.Name = "LblNachnameA";
            LblNachnameA.Size = new Size(96, 25);
            LblNachnameA.TabIndex = 17;
            LblNachnameA.Text = "Nachname";
            // 
            // LblVornameA
            // 
            LblVornameA.AutoSize = true;
            LblVornameA.Location = new Point(516, 64);
            LblVornameA.Name = "LblVornameA";
            LblVornameA.Size = new Size(83, 25);
            LblVornameA.TabIndex = 16;
            LblVornameA.Text = "Vorname";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(40, 9);
            label12.Name = "label12";
            label12.Size = new Size(161, 38);
            label12.TabIndex = 28;
            label12.Text = "Empfänger";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(516, 9);
            label13.Name = "label13";
            label13.Size = new Size(141, 38);
            label13.TabIndex = 29;
            label13.Text = "Absender";
            // 
            // BtnDrucken
            // 
            BtnDrucken.Location = new Point(772, 471);
            BtnDrucken.Name = "BtnDrucken";
            BtnDrucken.Size = new Size(112, 34);
            BtnDrucken.TabIndex = 30;
            BtnDrucken.Text = "Drucken";
            BtnDrucken.UseVisualStyleBackColor = true;
            BtnDrucken.Click += BtnDrucken_Click;
            // 
            // VerfuegungFenster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 569);
            Controls.Add(BtnDrucken);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(NupNrA);
            Controls.Add(NupPlzA);
            Controls.Add(TxtOrtA);
            Controls.Add(TxtAdresseA);
            Controls.Add(TxtNachnameA);
            Controls.Add(TxtVornameA);
            Controls.Add(LblNrA);
            Controls.Add(LblOrtA);
            Controls.Add(LblPlzA);
            Controls.Add(LblAdresseA);
            Controls.Add(LblNachnameA);
            Controls.Add(LblVornameA);
            Controls.Add(TxtErwaegung);
            Controls.Add(LblErwaegung);
            Controls.Add(NupNrE);
            Controls.Add(NupPlzE);
            Controls.Add(TxtOrtE);
            Controls.Add(TxtAdresseE);
            Controls.Add(TxtNachnameE);
            Controls.Add(splitter1);
            Controls.Add(TxtVornameE);
            Controls.Add(LblNrE);
            Controls.Add(LblOrtE);
            Controls.Add(LblPlzE);
            Controls.Add(LblAdresseE);
            Controls.Add(LblNachnameE);
            Controls.Add(LblVornameE);
            Name = "VerfuegungFenster";
            Text = "MangerView";
            ((System.ComponentModel.ISupportInitialize)NupPlzE).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupNrE).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupNrA).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupPlzA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblVornameE;
        private Label LblNachnameE;
        private Label LblAdresseE;
        private Label LblPlzE;
        private Label LblOrtE;
        private Label LblNrE;
        private TextBox TxtVornameE;
        private Splitter splitter1;
        private TextBox TxtNachnameE;
        private TextBox TxtAdresseE;
        private TextBox TxtOrtE;
        private NumericUpDown NupPlzE;
        private NumericUpDown NupNrE;
        private Label LblErwaegung;
        private TextBox TxtErwaegung;
        private NotifyIcon notifyIcon1;
        private NumericUpDown NupNrA;
        private NumericUpDown NupPlzA;
        private TextBox TxtOrtA;
        private TextBox TxtAdresseA;
        private TextBox TxtNachnameA;
        private TextBox TxtVornameA;
        private Label LblNrA;
        private Label LblOrtA;
        private Label LblPlzA;
        private Label LblAdresseA;
        private Label LblNachnameA;
        private Label LblVornameA;
        private Label label12;
        private Label label13;
        private Button BtnDrucken;
    }
}