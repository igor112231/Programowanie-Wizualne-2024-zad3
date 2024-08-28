namespace Zad_3
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
            pictureBox = new PictureBox();
            Load = new Button();
            Crop = new Button();
            Scale = new Button();
            label1 = new Label();
            Rotate = new Button();
            Flip = new Button();
            H_box = new TextBox();
            W_box = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Enter = new Button();
            Save = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(24, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(285, 330);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // Load
            // 
            Load.Location = new Point(530, 27);
            Load.Name = "Load";
            Load.Size = new Size(94, 29);
            Load.TabIndex = 1;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // Crop
            // 
            Crop.Location = new Point(530, 96);
            Crop.Name = "Crop";
            Crop.Size = new Size(94, 29);
            Crop.TabIndex = 2;
            Crop.Text = "Crop";
            Crop.UseVisualStyleBackColor = true;
            Crop.Click += Crop_Click;
            // 
            // Scale
            // 
            Scale.Location = new Point(530, 161);
            Scale.Name = "Scale";
            Scale.Size = new Size(94, 29);
            Scale.TabIndex = 3;
            Scale.Text = "Scale";
            Scale.UseVisualStyleBackColor = true;
            Scale.Click += Scale_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 408);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Rotate
            // 
            Rotate.Location = new Point(530, 229);
            Rotate.Name = "Rotate";
            Rotate.Size = new Size(94, 29);
            Rotate.TabIndex = 6;
            Rotate.Text = "Rotate";
            Rotate.UseVisualStyleBackColor = true;
            Rotate.Click += Rotate_Click;
            // 
            // Flip
            // 
            Flip.Location = new Point(530, 294);
            Flip.Name = "Flip";
            Flip.Size = new Size(94, 29);
            Flip.TabIndex = 7;
            Flip.Text = "Flip";
            Flip.UseVisualStyleBackColor = true;
            Flip.Click += Flip_Click;
            // 
            // H_box
            // 
            H_box.Location = new Point(663, 161);
            H_box.Name = "H_box";
            H_box.Size = new Size(125, 27);
            H_box.TabIndex = 8;
            H_box.Visible = false;
            // 
            // W_box
            // 
            W_box.Location = new Point(663, 229);
            W_box.Name = "W_box";
            W_box.Size = new Size(125, 27);
            W_box.TabIndex = 9;
            W_box.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(684, 138);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 10;
            label2.Text = "Enter height";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(684, 206);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 11;
            label3.Text = "Enter width";
            label3.Visible = false;
            // 
            // Enter
            // 
            Enter.Location = new Point(684, 280);
            Enter.Name = "Enter";
            Enter.Size = new Size(94, 29);
            Enter.TabIndex = 12;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Visible = false;
            Enter.Click += Enter_Click;
            // 
            // Save
            // 
            Save.Location = new Point(530, 358);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 13;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save);
            Controls.Add(Enter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(W_box);
            Controls.Add(H_box);
            Controls.Add(Flip);
            Controls.Add(Rotate);
            Controls.Add(label1);
            Controls.Add(Scale);
            Controls.Add(Crop);
            Controls.Add(Load);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button Load;
        private Button Crop;
        private Button Scale;
        private Label label1;
        private Button Rotate;
        private Button Flip;
        private TextBox H_box;
        private TextBox W_box;
        private Label label2;
        private Label label3;
        private Button Enter;
        private Button Save;
    }
}