namespace Einheit13.InheritanceExample
{
    partial class DbView
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
            CmdCreateCd=new Button();
            TxtName=new TextBox();
            TxtInterpreter=new TextBox();
            TxtActor=new TextBox();
            LbShowAllMediums=new ListBox();
            CmdCreateDvd=new Button();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            CmdShowMedium=new Button();
            SuspendLayout();
            // 
            // CmdCreateCd
            // 
            CmdCreateCd.Location=new Point(31, 160);
            CmdCreateCd.Name="CmdCreateCd";
            CmdCreateCd.Size=new Size(150, 45);
            CmdCreateCd.TabIndex=0;
            CmdCreateCd.Text="Erstelle CD";
            CmdCreateCd.UseVisualStyleBackColor=true;
            CmdCreateCd.Click+=ClickOnCmdCreateCd;
            // 
            // TxtName
            // 
            TxtName.Location=new Point(108, 41);
            TxtName.Name="TxtName";
            TxtName.Size=new Size(150, 31);
            TxtName.TabIndex=1;
            // 
            // TxtInterpreter
            // 
            TxtInterpreter.Location=new Point(31, 123);
            TxtInterpreter.Name="TxtInterpreter";
            TxtInterpreter.Size=new Size(150, 31);
            TxtInterpreter.TabIndex=2;
            // 
            // TxtActor
            // 
            TxtActor.Location=new Point(187, 123);
            TxtActor.Name="TxtActor";
            TxtActor.Size=new Size(150, 31);
            TxtActor.TabIndex=3;
            // 
            // LbShowAllMediums
            // 
            LbShowAllMediums.FormattingEnabled=true;
            LbShowAllMediums.ItemHeight=25;
            LbShowAllMediums.Location=new Point(383, 116);
            LbShowAllMediums.Name="LbShowAllMediums";
            LbShowAllMediums.Size=new Size(306, 304);
            LbShowAllMediums.TabIndex=4;
            // 
            // CmdCreateDvd
            // 
            CmdCreateDvd.Location=new Point(187, 160);
            CmdCreateDvd.Name="CmdCreateDvd";
            CmdCreateDvd.Size=new Size(150, 45);
            CmdCreateDvd.TabIndex=5;
            CmdCreateDvd.Text="Erstelle DVD";
            CmdCreateDvd.UseVisualStyleBackColor=true;
            CmdCreateDvd.Click+=ClickOnCmdCreateDvd;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(108, 9);
            label1.Name="label1";
            label1.Size=new Size(59, 25);
            label1.TabIndex=6;
            label1.Text="Name";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(31, 86);
            label2.Name="label2";
            label2.Size=new Size(95, 25);
            label2.TabIndex=7;
            label2.Text="Interpreter";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(187, 86);
            label3.Name="label3";
            label3.Size=new Size(110, 25);
            label3.TabIndex=8;
            label3.Text="Schauspieler";
            // 
            // CmdShowMedium
            // 
            CmdShowMedium.Location=new Point(383, 41);
            CmdShowMedium.Name="CmdShowMedium";
            CmdShowMedium.Size=new Size(306, 45);
            CmdShowMedium.TabIndex=9;
            CmdShowMedium.Text="Zeig alle Mediums";
            CmdShowMedium.UseVisualStyleBackColor=true;
            CmdShowMedium.Click+=CmdShowMedium_Click;
            // 
            // DbView
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(748, 450);
            Controls.Add(CmdShowMedium);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdCreateDvd);
            Controls.Add(LbShowAllMediums);
            Controls.Add(TxtActor);
            Controls.Add(TxtInterpreter);
            Controls.Add(TxtName);
            Controls.Add(CmdCreateCd);
            Name="DbView";
            Text="DbView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdCreateCd;
        private TextBox TxtName;
        private TextBox TxtInterpreter;
        private TextBox TxtActor;
        private ListBox LbShowAllMediums;
        private Button CmdCreateDvd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button CmdShowMedium;
    }
}