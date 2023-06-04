namespace Einheit13.CounterExample
{
    partial class CounterView
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
            BtnCreatePerson = new Button();
            NudNumerToCreate = new NumericUpDown();
            LblShowStaticCounter = new Label();
            LblShowCounter = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)NudNumerToCreate).BeginInit();
            SuspendLayout();
            // 
            // BtnCreatePerson
            // 
            BtnCreatePerson.Location = new Point(26, 107);
            BtnCreatePerson.Name = "BtnCreatePerson";
            BtnCreatePerson.Size = new Size(154, 57);
            BtnCreatePerson.TabIndex = 0;
            BtnCreatePerson.Text = "Erstelle";
            BtnCreatePerson.UseVisualStyleBackColor = true;
            BtnCreatePerson.Click += BtnCreatePerson_Click;
            // 
            // NudNumerToCreate
            // 
            NudNumerToCreate.Location = new Point(26, 46);
            NudNumerToCreate.Name = "NudNumerToCreate";
            NudNumerToCreate.Size = new Size(154, 31);
            NudNumerToCreate.TabIndex = 1;
            // 
            // LblShowStaticCounter
            // 
            LblShowStaticCounter.AutoSize = true;
            LblShowStaticCounter.Location = new Point(437, 46);
            LblShowStaticCounter.Name = "LblShowStaticCounter";
            LblShowStaticCounter.Size = new Size(28, 25);
            LblShowStaticCounter.TabIndex = 2;
            LblShowStaticCounter.Text = "....";
            // 
            // LblShowCounter
            // 
            LblShowCounter.AutoSize = true;
            LblShowCounter.Location = new Point(437, 107);
            LblShowCounter.Name = "LblShowCounter";
            LblShowCounter.Size = new Size(28, 25);
            LblShowCounter.TabIndex = 3;
            LblShowCounter.Text = "....";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 46);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 4;
            label1.Text = "Wert static Counter:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 107);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 5;
            label2.Text = "Wert Counter:";
            // 
            // CounterView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblShowCounter);
            Controls.Add(LblShowStaticCounter);
            Controls.Add(NudNumerToCreate);
            Controls.Add(BtnCreatePerson);
            Name = "CounterView";
            Text = "CounterView";
            ((System.ComponentModel.ISupportInitialize)NudNumerToCreate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCreatePerson;
        private NumericUpDown NudNumerToCreate;
        private Label LblShowStaticCounter;
        private Label LblShowCounter;
        private Label label1;
        private Label label2;
    }
}