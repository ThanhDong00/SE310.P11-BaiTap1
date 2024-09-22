namespace AnimalFarm
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txbCow = new TextBox();
            txbSheep = new TextBox();
            txbGoat = new TextBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(579, 38);
            label1.TabIndex = 0;
            label1.Text = "Nhập số lượng vật nuôi có trong trang trại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Cow: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Sheep: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 92);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Goat: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbGoat);
            groupBox1.Controls.Add(txbSheep);
            groupBox1.Controls.Add(txbCow);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // txbCow
            // 
            txbCow.Location = new Point(77, 20);
            txbCow.Name = "txbCow";
            txbCow.Size = new Size(496, 27);
            txbCow.TabIndex = 4;
            // 
            // txbSheep
            // 
            txbSheep.Location = new Point(77, 54);
            txbSheep.Name = "txbSheep";
            txbSheep.Size = new Size(496, 27);
            txbSheep.TabIndex = 5;
            // 
            // txbGoat
            // 
            txbGoat.Location = new Point(77, 89);
            txbGoat.Name = "txbGoat";
            txbGoat.Size = new Size(496, 27);
            txbGoat.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(491, 197);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 236);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txbGoat;
        private TextBox txbSheep;
        private TextBox txbCow;
        private Button btnSave;
    }
}