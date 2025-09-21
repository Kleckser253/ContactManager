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
            FirstNameBox = new TextBox();
            searchBtn = new Button();
            PersonViewer = new DataGridView();
            create_btn = new Button();
            groupBox1 = new GroupBox();
            TypeCheck = new CheckBox();
            BirthdayCheck = new CheckBox();
            label4 = new Label();
            FirstNameCheck = new CheckBox();
            LastNameCheck = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TypeSearchBox = new ComboBox();
            BirthdayBox = new DateTimePicker();
            LastNameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PersonViewer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // read_btn
            // 
            read_btn.Location = new Point(186, 10);
            read_btn.Name = "read_btn";
            read_btn.Size = new Size(75, 23);
            read_btn.TabIndex = 1;
            read_btn.Text = "Read";
            read_btn.UseVisualStyleBackColor = true;
            read_btn.Click += read_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(266, 10);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(75, 23);
            update_btn.TabIndex = 2;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(347, 10);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 23);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(5, 49);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(100, 23);
            FirstNameBox.TabIndex = 4;
            FirstNameBox.TextChanged += FirstNameBox_TextChanged;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(620, 60);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(99, 29);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Suchen";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += suchen_btn_Click;
            // 
            // PersonViewer
            // 
            PersonViewer.AllowUserToAddRows = false;
            PersonViewer.AllowUserToDeleteRows = false;
            PersonViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonViewer.Location = new Point(106, 174);
            PersonViewer.MultiSelect = false;
            PersonViewer.Name = "PersonViewer";
            PersonViewer.ReadOnly = true;
            PersonViewer.RowHeadersWidth = 51;
            PersonViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersonViewer.Size = new Size(1172, 448);
            PersonViewer.TabIndex = 6;
            PersonViewer.CellContentClick += PersonViewer_CellContentClick;
            PersonViewer.RowPrePaint += PersonViewer_RowPrePaint_1;
            // 
            // create_btn
            // 
            create_btn.Location = new Point(104, 10);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(75, 23);
            create_btn.TabIndex = 7;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TypeCheck);
            groupBox1.Controls.Add(BirthdayCheck);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(FirstNameCheck);
            groupBox1.Controls.Add(LastNameCheck);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TypeSearchBox);
            groupBox1.Controls.Add(BirthdayBox);
            groupBox1.Controls.Add(LastNameBox);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(FirstNameBox);
            groupBox1.Location = new Point(106, 55);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(724, 104);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Suchkriterien";
            // 
            // TypeCheck
            // 
            TypeCheck.AutoSize = true;
            TypeCheck.Location = new Point(439, 72);
            TypeCheck.Margin = new Padding(3, 2, 3, 2);
            TypeCheck.Name = "TypeCheck";
            TypeCheck.Size = new Size(82, 19);
            TypeCheck.TabIndex = 14;
            TypeCheck.Text = "mitsuchen";
            TypeCheck.UseVisualStyleBackColor = true;
            // 
            // BirthdayCheck
            // 
            BirthdayCheck.AutoSize = true;
            BirthdayCheck.Location = new Point(217, 73);
            BirthdayCheck.Margin = new Padding(3, 2, 3, 2);
            BirthdayCheck.Name = "BirthdayCheck";
            BirthdayCheck.Size = new Size(82, 19);
            BirthdayCheck.TabIndex = 11;
            BirthdayCheck.Text = "mitsuchen";
            BirthdayCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 30);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 13;
            label4.Text = "Kontakttyp:";
            // 
            // FirstNameCheck
            // 
            FirstNameCheck.AutoSize = true;
            FirstNameCheck.Location = new Point(5, 71);
            FirstNameCheck.Margin = new Padding(3, 2, 3, 2);
            FirstNameCheck.Name = "FirstNameCheck";
            FirstNameCheck.Size = new Size(82, 19);
            FirstNameCheck.TabIndex = 9;
            FirstNameCheck.Text = "mitsuchen";
            FirstNameCheck.UseVisualStyleBackColor = true;
            FirstNameCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LastNameCheck
            // 
            LastNameCheck.AutoSize = true;
            LastNameCheck.Location = new Point(110, 72);
            LastNameCheck.Margin = new Padding(3, 2, 3, 2);
            LastNameCheck.Name = "LastNameCheck";
            LastNameCheck.Size = new Size(82, 19);
            LastNameCheck.TabIndex = 10;
            LastNameCheck.Text = "mitsuchen";
            LastNameCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 30);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 12;
            label3.Text = "Geburtsdatum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 11;
            label2.Text = "Nachname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 30);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 10;
            label1.Text = "Vorname:";
            // 
            // TypeSearchBox
            // 
            TypeSearchBox.FormattingEnabled = true;
            TypeSearchBox.Location = new Point(439, 48);
            TypeSearchBox.Margin = new Padding(3, 2, 3, 2);
            TypeSearchBox.Name = "TypeSearchBox";
            TypeSearchBox.Size = new Size(133, 23);
            TypeSearchBox.TabIndex = 9;
            TypeSearchBox.SelectedIndexChanged += TypeSearchBox_SelectedIndexChanged;
            // 
            // BirthdayBox
            // 
            BirthdayBox.Location = new Point(215, 48);
            BirthdayBox.Margin = new Padding(3, 2, 3, 2);
            BirthdayBox.Name = "BirthdayBox";
            BirthdayBox.Size = new Size(219, 23);
            BirthdayBox.TabIndex = 7;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(110, 48);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(100, 23);
            LastNameBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1375, 748);
            Controls.Add(groupBox1);
            Controls.Add(create_btn);
            Controls.Add(PersonViewer);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(read_btn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PersonViewer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button read_btn;
        private Button update_btn;
        private Button delete_btn;
        private TextBox FirstNameBox;
        private Button searchBtn;
        private DataGridView PersonViewer;
        private Button create_btn;
        private GroupBox groupBox1;
        private TextBox LastNameBox;
        private ComboBox TypeSearchBox;
        private DateTimePicker BirthdayBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox LastNameCheck;
        private CheckBox FirstNameCheck;
        private CheckBox BirthdayCheck;
        private CheckBox TypeCheck;
    }
}
