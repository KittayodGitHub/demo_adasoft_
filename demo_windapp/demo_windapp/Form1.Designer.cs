namespace demo_windapp
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
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.pnl_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AllowUserToDeleteRows = false;
            this.dgv_data.AllowUserToResizeColumns = false;
            this.dgv_data.AllowUserToResizeRows = false;
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(12, 50);
            this.dgv_data.MultiSelect = false;
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersVisible = false;
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 29;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(460, 214);
            this.dgv_data.TabIndex = 0;
            this.dgv_data.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_data_CellMouseClick);
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(12, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(102, 32);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pnl_data
            // 
            this.pnl_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_data.Controls.Add(this.btn_confirm);
            this.pnl_data.Controls.Add(this.btn_update);
            this.pnl_data.Controls.Add(this.btn_delete);
            this.pnl_data.Controls.Add(this.lbl_mode);
            this.pnl_data.Controls.Add(this.rdo_male);
            this.pnl_data.Controls.Add(this.rdo_female);
            this.pnl_data.Controls.Add(this.label3);
            this.pnl_data.Controls.Add(this.label2);
            this.pnl_data.Controls.Add(this.label1);
            this.pnl_data.Controls.Add(this.txt_age);
            this.pnl_data.Controls.Add(this.txt_name);
            this.pnl_data.Location = new System.Drawing.Point(478, 50);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(397, 214);
            this.pnl_data.TabIndex = 2;
            // 
            // btn_confirm
            // 
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Location = new System.Drawing.Point(249, 165);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(135, 32);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "Insert Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(33, 165);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(102, 32);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(141, 165);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 32);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mode.Location = new System.Drawing.Point(22, 11);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(141, 23);
            this.lbl_mode.TabIndex = 8;
            this.lbl_mode.Text = "Information Data";
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.Location = new System.Drawing.Point(187, 115);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(63, 24);
            this.rdo_male.TabIndex = 7;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Male";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.Location = new System.Drawing.Point(93, 115);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(78, 24);
            this.rdo_female.TabIndex = 6;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "Female";
            this.rdo_female.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(291, 68);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(79, 27);
            this.txt_age.TabIndex = 1;
            this.txt_age.Text = "0";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(77, 68);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(135, 27);
            this.txt_name.TabIndex = 0;
            // 
            // btn_insert
            // 
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Location = new System.Drawing.Point(120, 12);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(102, 32);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 282);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "dem_windapp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.pnl_data.ResumeLayout(false);
            this.pnl_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_data;
        private Button btn_search;
        private Panel pnl_data;
        private RadioButton rdo_male;
        private RadioButton rdo_female;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_age;
        private TextBox txt_name;
        private Button btn_insert;
        private Button btn_confirm;
        private Label lbl_mode;
        private Button btn_update;
        private Button btn_delete;
    }
}