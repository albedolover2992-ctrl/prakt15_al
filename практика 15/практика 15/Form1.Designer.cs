namespace практика_15
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
            Z_end = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Y_end = new TextBox();
            X_end = new TextBox();
            Add = new Button();
            Vec_1 = new TextBox();
            Vec_2 = new TextBox();
            Res = new TextBox();
            Sum = new Button();
            Sub = new Button();
            Com = new Button();
            Len = new Button();
            Replay = new Button();
            Cos = new Button();
            SuspendLayout();
            // 
            // Z_end
            // 
            Z_end.Location = new Point(58, 56);
            Z_end.Name = "Z_end";
            Z_end.Size = new Size(57, 23);
            Z_end.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 56);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 10;
            label4.Text = "Z";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 32);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 9;
            label5.Text = "Y";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 9);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 8;
            label6.Text = "X";
            // 
            // Y_end
            // 
            Y_end.Location = new Point(58, 32);
            Y_end.Name = "Y_end";
            Y_end.Size = new Size(57, 23);
            Y_end.TabIndex = 7;
            // 
            // X_end
            // 
            X_end.Location = new Point(58, 6);
            X_end.Name = "X_end";
            X_end.Size = new Size(57, 23);
            X_end.TabIndex = 6;
            // 
            // Add
            // 
            Add.Location = new Point(25, 85);
            Add.Name = "Add";
            Add.Size = new Size(90, 23);
            Add.TabIndex = 12;
            Add.Text = "Добавить вектор";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Vec_1
            // 
            Vec_1.Location = new Point(173, 12);
            Vec_1.Name = "Vec_1";
            Vec_1.ReadOnly = true;
            Vec_1.Size = new Size(123, 23);
            Vec_1.TabIndex = 13;
            // 
            // Vec_2
            // 
            Vec_2.Location = new Point(302, 12);
            Vec_2.Name = "Vec_2";
            Vec_2.ReadOnly = true;
            Vec_2.Size = new Size(123, 23);
            Vec_2.TabIndex = 14;
            // 
            // Res
            // 
            Res.Location = new Point(431, 12);
            Res.Multiline = true;
            Res.Name = "Res";
            Res.ReadOnly = true;
            Res.Size = new Size(168, 55);
            Res.TabIndex = 15;
            // 
            // Sum
            // 
            Sum.Location = new Point(173, 79);
            Sum.Name = "Sum";
            Sum.Size = new Size(252, 23);
            Sum.TabIndex = 16;
            Sum.Text = "Сложить вектора";
            Sum.UseVisualStyleBackColor = true;
            Sum.Click += Sum_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(173, 108);
            Sub.Name = "Sub";
            Sub.Size = new Size(252, 23);
            Sub.TabIndex = 17;
            Sub.Text = "Вычесть вектора";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // Com
            // 
            Com.Location = new Point(173, 137);
            Com.Name = "Com";
            Com.Size = new Size(252, 23);
            Com.TabIndex = 18;
            Com.Text = "Скалярное произведение";
            Com.UseVisualStyleBackColor = true;
            Com.Click += Com_Click;
            // 
            // Len
            // 
            Len.Location = new Point(173, 166);
            Len.Name = "Len";
            Len.Size = new Size(252, 23);
            Len.TabIndex = 19;
            Len.Text = "Длины векторов";
            Len.UseVisualStyleBackColor = true;
            Len.Click += Len_Click;
            // 
            // Replay
            // 
            Replay.Location = new Point(25, 114);
            Replay.Name = "Replay";
            Replay.Size = new Size(90, 23);
            Replay.TabIndex = 20;
            Replay.Text = "Пересоздать";
            Replay.UseVisualStyleBackColor = true;
            Replay.Click += Replay_Click;
            // 
            // Cos
            // 
            Cos.Location = new Point(173, 195);
            Cos.Name = "Cos";
            Cos.Size = new Size(252, 23);
            Cos.TabIndex = 21;
            Cos.Text = "Косинус угла между векторами";
            Cos.UseVisualStyleBackColor = true;
            Cos.Click += Cos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cos);
            Controls.Add(Replay);
            Controls.Add(Len);
            Controls.Add(Com);
            Controls.Add(Sub);
            Controls.Add(Sum);
            Controls.Add(Res);
            Controls.Add(Vec_2);
            Controls.Add(Vec_1);
            Controls.Add(Add);
            Controls.Add(Z_end);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(Y_end);
            Controls.Add(X_end);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Z_end;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Y_end;
        private TextBox X_end;
        private Button Add;
        private TextBox Vec_1;
        private TextBox Vec_2;
        private TextBox Res;
        private Button Sum;
        private Button Sub;
        private Button Com;
        private Button Len;
        private Button Replay;
        private Button Cos;
    }
}
