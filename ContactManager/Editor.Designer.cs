namespace ContactManager
{
    partial class Editor
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
            save_btn = new Button();
            dropbox = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            anrede_txt = new TextBox();
            dropbox_gender = new ComboBox();
            SuspendLayout();
            // 
            // save_btn
            // 
            save_btn.Location = new Point(635, 77);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(66, 31);
            save_btn.TabIndex = 0;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // dropbox
            // 
            dropbox.FormattingEnabled = true;
            dropbox.Location = new Point(82, 77);
            dropbox.Name = "dropbox";
            dropbox.Size = new Size(121, 23);
            dropbox.TabIndex = 1;
            dropbox.Text = "Choose";
            dropbox.SelectedIndexChanged += dropbox_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Vorname";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Nachname";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(82, 170);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // anrede_txt
            // 
            anrede_txt.Location = new Point(314, 115);
            anrede_txt.Name = "anrede_txt";
            anrede_txt.Size = new Size(100, 23);
            anrede_txt.TabIndex = 5;
            anrede_txt.Text = "Anrede";
            // 
            // dropbox_gender
            // 
            dropbox_gender.FormattingEnabled = true;
            dropbox_gender.Location = new Point(246, 77);
            dropbox_gender.Name = "dropbox_gender";
            dropbox_gender.Size = new Size(121, 23);
            dropbox_gender.TabIndex = 6;
            dropbox_gender.SelectedIndexChanged += dropbox_gender_SelectedIndexChanged;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dropbox_gender);
            Controls.Add(anrede_txt);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dropbox);
            Controls.Add(save_btn);
            Name = "Editor";
            Text = "Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_btn;
        private ComboBox dropbox;
        private TextBox textBox1;
        private TextBox textBox2;
        private MonthCalendar monthCalendar1;
        private TextBox anrede_txt;
        private ComboBox dropbox_gender;
    }
}