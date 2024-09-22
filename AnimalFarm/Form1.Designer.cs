namespace AnimalFarm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnLoad = new Button();
            getMilk = new Button();
            Breed = new Button();
            Voice = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnLoad);
            splitContainer1.Panel1.Controls.Add(getMilk);
            splitContainer1.Panel1.Controls.Add(Breed);
            splitContainer1.Panel1.Controls.Add(Voice);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 53;
            splitContainer1.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(694, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load ";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // getMilk
            // 
            getMilk.Location = new Point(215, 12);
            getMilk.Name = "getMilk";
            getMilk.Size = new Size(94, 29);
            getMilk.TabIndex = 2;
            getMilk.Text = "Lấy Sữa";
            getMilk.UseVisualStyleBackColor = true;
            getMilk.Click += getMilk_Click;
            // 
            // Breed
            // 
            Breed.Location = new Point(115, 12);
            Breed.Name = "Breed";
            Breed.Size = new Size(94, 29);
            Breed.TabIndex = 1;
            Breed.Text = "Sinh Con";
            Breed.UseVisualStyleBackColor = true;
            Breed.Click += Breed_Click;
            // 
            // Voice
            // 
            Voice.Location = new Point(15, 12);
            Voice.Name = "Voice";
            Voice.Size = new Size(94, 29);
            Voice.TabIndex = 0;
            Voice.Text = "Tiếng Kêu";
            Voice.UseVisualStyleBackColor = true;
            Voice.Click += Voice_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 393);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button getMilk;
        private Button Breed;
        private Button Voice;
        private DataGridView dataGridView1;
        private Button btnLoad;
    }
}
