namespace Addressbook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_save = new Button();
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_phonenumber = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 85);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 136);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 190);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 2;
            label3.Text = "Phone number";
            label3.Click += label3_Click;
            // 
            // txt_save
            // 
            txt_save.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_save.Location = new Point(277, 251);
            txt_save.Name = "txt_save";
            txt_save.Size = new Size(73, 23);
            txt_save.TabIndex = 3;
            txt_save.Text = "Save";
            txt_save.UseVisualStyleBackColor = true;
            txt_save.Click += txt_save_Click;
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_name.Location = new Point(193, 85);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(157, 23);
            txt_name.TabIndex = 4;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Location = new Point(193, 136);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(157, 23);
            txt_email.TabIndex = 5;
            // 
            // txt_phonenumber
            // 
            txt_phonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_phonenumber.Location = new Point(193, 188);
            txt_phonenumber.Name = "txt_phonenumber";
            txt_phonenumber.Size = new Size(157, 23);
            txt_phonenumber.TabIndex = 6;
            txt_phonenumber.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 368);
            Controls.Add(txt_phonenumber);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Controls.Add(txt_save);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button txt_save;
        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_phonenumber;
    }
}
