namespace WinFormsApp9
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_surname = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(32, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(325, 408);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(443, 44);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(136, 27);
            this.tbox_name.TabIndex = 1;
            // 
            // tbox_surname
            // 
            this.tbox_surname.Location = new System.Drawing.Point(443, 133);
            this.tbox_surname.Name = "tbox_surname";
            this.tbox_surname.Size = new System.Drawing.Size(136, 27);
            this.tbox_surname.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(443, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_surname.Location = new System.Drawing.Point(443, 105);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(82, 25);
            this.lbl_surname.TabIndex = 2;
            this.lbl_surname.Text = "Surname";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(443, 200);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(114, 35);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 575);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tbox_surname);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private TextBox tbox_name;
        private TextBox tbox_surname;
        private Label lbl_name;
        private Label lbl_surname;
        private Button btn_add;
    }
}