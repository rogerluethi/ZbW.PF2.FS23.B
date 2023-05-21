namespace Einheit12
{
    partial class StartView
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
            BtnVerfuegungExample = new Button();
            BtnRefExample = new Button();
            SuspendLayout();
            // 
            // BtnVerfuegungExample
            // 
            BtnVerfuegungExample.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerfuegungExample.Location = new Point(49, 34);
            BtnVerfuegungExample.Name = "BtnVerfuegungExample";
            BtnVerfuegungExample.Size = new Size(188, 79);
            BtnVerfuegungExample.TabIndex = 0;
            BtnVerfuegungExample.Text = "Verfügung Beispiel";
            BtnVerfuegungExample.UseVisualStyleBackColor = true;
            BtnVerfuegungExample.Click += ClickOnBtnVerfuegungExample;
            // 
            // BtnRefExample
            // 
            BtnRefExample.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRefExample.Location = new Point(53, 141);
            BtnRefExample.Name = "BtnRefExample";
            BtnRefExample.Size = new Size(188, 79);
            BtnRefExample.TabIndex = 1;
            BtnRefExample.Text = "Referenz Beispiel";
            BtnRefExample.UseVisualStyleBackColor = true;
            BtnRefExample.Click += ClickOnBtnRefExample;
            // 
            // StartView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 361);
            Controls.Add(BtnRefExample);
            Controls.Add(BtnVerfuegungExample);
            Name = "StartView";
            Text = "StartView";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVerfuegungExample;
        private Button BtnRefExample;
    }
}