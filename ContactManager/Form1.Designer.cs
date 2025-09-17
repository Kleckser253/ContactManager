namespace ContactManager
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
            read_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            textBox1 = new TextBox();
            suchen_btn = new Button();
            dataGridView1 = new DataGridView();
            create_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // read_btn
            // 
            read_btn.Location = new Point(187, 69);
            read_btn.Name = "read_btn";
            read_btn.Size = new Size(75, 23);
            read_btn.TabIndex = 1;
            read_btn.Text = "Read";
            read_btn.UseVisualStyleBackColor = true;
            read_btn.Click += read_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(268, 69);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(75, 23);
            update_btn.TabIndex = 2;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(349, 69);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 23);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Suchen";
            // 
            // suchen_btn
            // 
            suchen_btn.Location = new Point(231, 135);
            suchen_btn.Name = "suchen_btn";
            suchen_btn.Size = new Size(75, 23);
            suchen_btn.TabIndex = 5;
            suchen_btn.Text = "Suchen";
            suchen_btn.UseVisualStyleBackColor = true;
            suchen_btn.Click += suchen_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(349, 467);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(709, 407);
            dataGridView1.TabIndex = 6;
            // 
            // create_btn
            // 
            create_btn.Location = new Point(106, 69);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(75, 23);
            create_btn.TabIndex = 7;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 971);
            Controls.Add(create_btn);
            Controls.Add(dataGridView1);
            Controls.Add(suchen_btn);
            Controls.Add(textBox1);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(read_btn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button read_btn;
        private Button update_btn;
        private Button delete_btn;
        private TextBox textBox1;
        private Button suchen_btn;
        private DataGridView dataGridView1;
        private Button create_btn;
    }
}
