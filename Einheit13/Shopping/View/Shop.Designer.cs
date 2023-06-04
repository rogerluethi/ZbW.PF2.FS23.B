namespace Einheit13.Shopping.View
{
    partial class Shop
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
            ClbProducts=new CheckedListBox();
            BtnAdd=new Button();
            LbProductsInBasket=new ListBox();
            label1=new Label();
            label2=new Label();
            SuspendLayout();
            // 
            // ClbProducts
            // 
            ClbProducts.FormattingEnabled=true;
            ClbProducts.Location=new Point(42, 75);
            ClbProducts.Name="ClbProducts";
            ClbProducts.Size=new Size(524, 144);
            ClbProducts.TabIndex=0;
            // 
            // BtnAdd
            // 
            BtnAdd.Location=new Point(594, 75);
            BtnAdd.Name="BtnAdd";
            BtnAdd.Size=new Size(159, 144);
            BtnAdd.TabIndex=2;
            BtnAdd.Text="Hinzufügen";
            BtnAdd.UseVisualStyleBackColor=false;
            BtnAdd.Click+=ClickOnBtnAdd;
            // 
            // LbProductsInBasket
            // 
            LbProductsInBasket.FormattingEnabled=true;
            LbProductsInBasket.ItemHeight=25;
            LbProductsInBasket.Location=new Point(42, 347);
            LbProductsInBasket.Name="LbProductsInBasket";
            LbProductsInBasket.Size=new Size(516, 229);
            LbProductsInBasket.TabIndex=3;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(46, 26);
            label1.Name="label1";
            label1.Size=new Size(226, 45);
            label1.TabIndex=4;
            label1.Text="Alle Produkte";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(42, 278);
            label2.Name="label2";
            label2.Size=new Size(188, 45);
            label2.TabIndex=5;
            label2.Text="Warenkorb";
            // 
            // Shop
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 642);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LbProductsInBasket);
            Controls.Add(BtnAdd);
            Controls.Add(ClbProducts);
            Name="Shop";
            Text="Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ClbProducts;
        private ListView LvProductsInBasket;
        private Button BtnAdd;
        private ListBox LbProductsInBasket;
        private Label label1;
        private Label label2;
    }
}