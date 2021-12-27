
namespace WindowsFormsApp1
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
            this.addToOrder = new System.Windows.Forms.Button();
            this.completeOrder = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.smallCheck = new System.Windows.Forms.RadioButton();
            this.mediumCheck = new System.Windows.Forms.RadioButton();
            this.largeCheck = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // addToOrder
            // 
            this.addToOrder.Location = new System.Drawing.Point(12, 89);
            this.addToOrder.Name = "addToOrder";
            this.addToOrder.Size = new System.Drawing.Size(271, 50);
            this.addToOrder.TabIndex = 3;
            this.addToOrder.Text = "Add To Order";
            this.addToOrder.UseVisualStyleBackColor = true;
            this.addToOrder.Click += new System.EventHandler(this.addToOrder_Click);
            // 
            // completeOrder
            // 
            this.completeOrder.Location = new System.Drawing.Point(12, 155);
            this.completeOrder.Name = "completeOrder";
            this.completeOrder.Size = new System.Drawing.Size(271, 50);
            this.completeOrder.TabIndex = 4;
            this.completeOrder.Text = "Complete Order";
            this.completeOrder.UseVisualStyleBackColor = true;
            this.completeOrder.Click += new System.EventHandler(this.completeOrder_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 221);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(271, 50);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(314, 89);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 13);
            this.price.TabIndex = 6;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(30, 32);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(122, 20);
            this.amountBox.TabIndex = 7;
            this.amountBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // smallCheck
            // 
            this.smallCheck.AutoSize = true;
            this.smallCheck.Location = new System.Drawing.Point(198, 32);
            this.smallCheck.Name = "smallCheck";
            this.smallCheck.Size = new System.Drawing.Size(86, 17);
            this.smallCheck.TabIndex = 8;
            this.smallCheck.TabStop = true;
            this.smallCheck.Text = "Small ($1.75)";
            this.smallCheck.UseVisualStyleBackColor = true;
            // 
            // mediumCheck
            // 
            this.mediumCheck.AutoSize = true;
            this.mediumCheck.Location = new System.Drawing.Point(289, 31);
            this.mediumCheck.Name = "mediumCheck";
            this.mediumCheck.Size = new System.Drawing.Size(98, 17);
            this.mediumCheck.TabIndex = 9;
            this.mediumCheck.TabStop = true;
            this.mediumCheck.Text = "Medium ($1.90)";
            this.mediumCheck.UseVisualStyleBackColor = true;
            // 
            // largeCheck
            // 
            this.largeCheck.AutoSize = true;
            this.largeCheck.Location = new System.Drawing.Point(393, 31);
            this.largeCheck.Name = "largeCheck";
            this.largeCheck.Size = new System.Drawing.Size(88, 17);
            this.largeCheck.TabIndex = 10;
            this.largeCheck.TabStop = true;
            this.largeCheck.Text = "Large ($2.00)";
            this.largeCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 343);
            this.Controls.Add(this.largeCheck);
            this.Controls.Add(this.mediumCheck);
            this.Controls.Add(this.smallCheck);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.completeOrder);
            this.Controls.Add(this.addToOrder);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToOrder;
        private System.Windows.Forms.Button completeOrder;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.RadioButton smallCheck;
        private System.Windows.Forms.RadioButton mediumCheck;
        private System.Windows.Forms.RadioButton largeCheck;
    }
}

