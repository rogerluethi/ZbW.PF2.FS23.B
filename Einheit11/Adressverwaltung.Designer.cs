namespace Einheit11
{
  partial class Adressverwaltung
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

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      CmdCreatePerson = new Button();
      LblShow = new Label();
      SuspendLayout();
      // 
      // CmdCreatePerson
      // 
      CmdCreatePerson.Location = new Point(114, 84);
      CmdCreatePerson.Name = "CmdCreatePerson";
      CmdCreatePerson.Size = new Size(156, 33);
      CmdCreatePerson.TabIndex = 0;
      CmdCreatePerson.Text = "Erzeuge Person";
      CmdCreatePerson.UseVisualStyleBackColor = true;
      CmdCreatePerson.Click += CmdCreatePerson_Click;
      // 
      // LblShow
      // 
      LblShow.AutoSize = true;
      LblShow.Location = new Point(114, 171);
      LblShow.Name = "LblShow";
      LblShow.Size = new Size(161, 15);
      LblShow.TabIndex = 1;
      LblShow.Text = "Vorname: Nachname: Alter: 0";
      // 
      // Adressverwaltung
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(374, 297);
      Controls.Add(LblShow);
      Controls.Add(CmdCreatePerson);
      Name = "Adressverwaltung";
      Text = "Adressverwaltung";
      ResumeLayout(false);
      PerformLayout();
    }

    private Button CmdCreatePerson;
    private Label LblShow;

    #region Windows Form Designer generated code


    #endregion
  }
}