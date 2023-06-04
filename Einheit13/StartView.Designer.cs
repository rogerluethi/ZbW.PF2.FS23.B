namespace Einheit13
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
            BtnStaticExample=new Button();
            BtnShopping=new Button();
            BtnInheritance=new Button();
            SuspendLayout();
            // 
            // BtnStaticExample
            // 
            BtnStaticExample.Location=new Point(37, 34);
            BtnStaticExample.Name="BtnStaticExample";
            BtnStaticExample.Size=new Size(169, 49);
            BtnStaticExample.TabIndex=0;
            BtnStaticExample.Text="Static Example";
            BtnStaticExample.UseVisualStyleBackColor=true;
            BtnStaticExample.Click+=OnClickBtnStaticExample;
            // 
            // BtnShopping
            // 
            BtnShopping.Location=new Point(37, 102);
            BtnShopping.Name="BtnShopping";
            BtnShopping.Size=new Size(169, 50);
            BtnShopping.TabIndex=1;
            BtnShopping.Text="Shopping";
            BtnShopping.UseVisualStyleBackColor=true;
            BtnShopping.Click+=ClickOnBtnShopping;
            // 
            // BtnInheritance
            // 
            BtnInheritance.Location=new Point(37, 172);
            BtnInheritance.Name="BtnInheritance";
            BtnInheritance.Size=new Size(169, 50);
            BtnInheritance.TabIndex=2;
            BtnInheritance.Text="Inheritance";
            BtnInheritance.UseVisualStyleBackColor=true;
            BtnInheritance.Click+=ClickOnBtnInheritance;
            // 
            // StartView
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(247, 262);
            Controls.Add(BtnInheritance);
            Controls.Add(BtnShopping);
            Controls.Add(BtnStaticExample);
            Name="StartView";
            Text="StartView";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnStaticExample;
        private Button BtnShopping;
        private Button BtnInheritance;
    }
}