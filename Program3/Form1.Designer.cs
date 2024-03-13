namespace Program3
{
    partial class Form1
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
            this.gardenLbl = new System.Windows.Forms.Label();
            this.flowerNumLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.flowerCostLbl = new System.Windows.Forms.Label();
            this.baseCostLbl = new System.Windows.Forms.Label();
            this.discountPercentLbl = new System.Windows.Forms.Label();
            this.finalCostLbl = new System.Windows.Forms.Label();
            this.flowerNumTbx = new System.Windows.Forms.TextBox();
            this.quantityTbx = new System.Windows.Forms.TextBox();
            this.flowersCostTbx = new System.Windows.Forms.TextBox();
            this.baseCostTbx = new System.Windows.Forms.TextBox();
            this.discountPercentTbx = new System.Windows.Forms.TextBox();
            this.finalCostTbx = new System.Windows.Forms.TextBox();
            this.gardenTxBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gardenLbl
            // 
            this.gardenLbl.AutoSize = true;
            this.gardenLbl.Location = new System.Drawing.Point(102, 51);
            this.gardenLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gardenLbl.Name = "gardenLbl";
            this.gardenLbl.Size = new System.Drawing.Size(45, 13);
            this.gardenLbl.TabIndex = 0;
            this.gardenLbl.Text = "Garden:";
            // 
            // flowerNumLbl
            // 
            this.flowerNumLbl.AutoSize = true;
            this.flowerNumLbl.Location = new System.Drawing.Point(68, 79);
            this.flowerNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flowerNumLbl.Name = "flowerNumLbl";
            this.flowerNumLbl.Size = new System.Drawing.Size(79, 13);
            this.flowerNumLbl.TabIndex = 1;
            this.flowerNumLbl.Text = "Flower number:";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(99, 109);
            this.quantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(49, 13);
            this.quantityLbl.TabIndex = 2;
            this.quantityLbl.Text = "Quantity:";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(121, 136);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(65, 21);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // flowerCostLbl
            // 
            this.flowerCostLbl.AutoSize = true;
            this.flowerCostLbl.Location = new System.Drawing.Point(79, 167);
            this.flowerCostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flowerCostLbl.Name = "flowerCostLbl";
            this.flowerCostLbl.Size = new System.Drawing.Size(69, 13);
            this.flowerCostLbl.TabIndex = 4;
            this.flowerCostLbl.Text = "Flowers cost:";
            // 
            // baseCostLbl
            // 
            this.baseCostLbl.AutoSize = true;
            this.baseCostLbl.Location = new System.Drawing.Point(89, 197);
            this.baseCostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseCostLbl.Name = "baseCostLbl";
            this.baseCostLbl.Size = new System.Drawing.Size(58, 13);
            this.baseCostLbl.TabIndex = 5;
            this.baseCostLbl.Text = "Base Cost:";
            // 
            // discountPercentLbl
            // 
            this.discountPercentLbl.AutoSize = true;
            this.discountPercentLbl.Location = new System.Drawing.Point(57, 226);
            this.discountPercentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discountPercentLbl.Name = "discountPercentLbl";
            this.discountPercentLbl.Size = new System.Drawing.Size(91, 13);
            this.discountPercentLbl.TabIndex = 6;
            this.discountPercentLbl.Text = "Discount percent:";
            // 
            // finalCostLbl
            // 
            this.finalCostLbl.AutoSize = true;
            this.finalCostLbl.Location = new System.Drawing.Point(91, 252);
            this.finalCostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.finalCostLbl.Name = "finalCostLbl";
            this.finalCostLbl.Size = new System.Drawing.Size(56, 13);
            this.finalCostLbl.TabIndex = 7;
            this.finalCostLbl.Text = "Final Cost:";
            // 
            // flowerNumTbx
            // 
            this.flowerNumTbx.Location = new System.Drawing.Point(170, 79);
            this.flowerNumTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowerNumTbx.Name = "flowerNumTbx";
            this.flowerNumTbx.Size = new System.Drawing.Size(68, 20);
            this.flowerNumTbx.TabIndex = 9;
            // 
            // quantityTbx
            // 
            this.quantityTbx.Location = new System.Drawing.Point(170, 109);
            this.quantityTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityTbx.Name = "quantityTbx";
            this.quantityTbx.Size = new System.Drawing.Size(68, 20);
            this.quantityTbx.TabIndex = 10;
            // 
            // flowersCostTbx
            // 
            this.flowersCostTbx.Location = new System.Drawing.Point(170, 167);
            this.flowersCostTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowersCostTbx.Name = "flowersCostTbx";
            this.flowersCostTbx.Size = new System.Drawing.Size(68, 20);
            this.flowersCostTbx.TabIndex = 11;
            // 
            // baseCostTbx
            // 
            this.baseCostTbx.Location = new System.Drawing.Point(170, 197);
            this.baseCostTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baseCostTbx.Name = "baseCostTbx";
            this.baseCostTbx.Size = new System.Drawing.Size(68, 20);
            this.baseCostTbx.TabIndex = 12;
            // 
            // discountPercentTbx
            // 
            this.discountPercentTbx.Location = new System.Drawing.Point(170, 226);
            this.discountPercentTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.discountPercentTbx.Name = "discountPercentTbx";
            this.discountPercentTbx.Size = new System.Drawing.Size(68, 20);
            this.discountPercentTbx.TabIndex = 13;
            // 
            // finalCostTbx
            // 
            this.finalCostTbx.Location = new System.Drawing.Point(170, 252);
            this.finalCostTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finalCostTbx.Name = "finalCostTbx";
            this.finalCostTbx.Size = new System.Drawing.Size(68, 20);
            this.finalCostTbx.TabIndex = 14;
            // 
            // gardenTxBx
            // 
            this.gardenTxBx.Location = new System.Drawing.Point(170, 51);
            this.gardenTxBx.Name = "gardenTxBx";
            this.gardenTxBx.Size = new System.Drawing.Size(68, 20);
            this.gardenTxBx.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 324);
            this.Controls.Add(this.gardenTxBx);
            this.Controls.Add(this.finalCostTbx);
            this.Controls.Add(this.discountPercentTbx);
            this.Controls.Add(this.baseCostTbx);
            this.Controls.Add(this.flowersCostTbx);
            this.Controls.Add(this.quantityTbx);
            this.Controls.Add(this.flowerNumTbx);
            this.Controls.Add(this.finalCostLbl);
            this.Controls.Add(this.discountPercentLbl);
            this.Controls.Add(this.baseCostLbl);
            this.Controls.Add(this.flowerCostLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.flowerNumLbl);
            this.Controls.Add(this.gardenLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gardenLbl;
        private System.Windows.Forms.Label flowerNumLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label flowerCostLbl;
        private System.Windows.Forms.Label baseCostLbl;
        private System.Windows.Forms.Label discountPercentLbl;
        private System.Windows.Forms.Label finalCostLbl;
        private System.Windows.Forms.TextBox flowerNumTbx;
        private System.Windows.Forms.TextBox quantityTbx;
        private System.Windows.Forms.TextBox flowersCostTbx;
        private System.Windows.Forms.TextBox baseCostTbx;
        private System.Windows.Forms.TextBox discountPercentTbx;
        private System.Windows.Forms.TextBox finalCostTbx;
        private System.Windows.Forms.TextBox gardenTxBx;
    }
}

