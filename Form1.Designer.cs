namespace Hello_World
{
    partial class frm_HelloWorld
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.bttn_nameIn = new System.Windows.Forms.Button();
            this.bttn_editInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Blue;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_close.Location = new System.Drawing.Point(502, 62);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseMnemonic = false;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // btn_go
            // 
            this.btn_go.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_go.FlatAppearance.BorderSize = 0;
            this.btn_go.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_go.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_go.Location = new System.Drawing.Point(583, 41);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 23);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Visible = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_output.Location = new System.Drawing.Point(170, 91);
            this.txt_output.MaxLength = 20;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(407, 44);
            this.txt_output.TabIndex = 2;
            this.txt_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_output.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.txt_name.Location = new System.Drawing.Point(170, 12);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(407, 44);
            this.txt_name.TabIndex = 4;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // bttn_nameIn
            // 
            this.bttn_nameIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttn_nameIn.FlatAppearance.BorderSize = 0;
            this.bttn_nameIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.bttn_nameIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.bttn_nameIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_nameIn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttn_nameIn.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttn_nameIn.Location = new System.Drawing.Point(583, 12);
            this.bttn_nameIn.Name = "bttn_nameIn";
            this.bttn_nameIn.Size = new System.Drawing.Size(108, 23);
            this.bttn_nameIn.TabIndex = 5;
            this.bttn_nameIn.Text = "Submit Name";
            this.bttn_nameIn.UseVisualStyleBackColor = true;
            this.bttn_nameIn.Visible = false;
            this.bttn_nameIn.Click += new System.EventHandler(this.bttn_nameIn_Click);
            // 
            // bttn_editInfo
            // 
            this.bttn_editInfo.FlatAppearance.BorderSize = 0;
            this.bttn_editInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.bttn_editInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.bttn_editInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_editInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttn_editInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttn_editInfo.Location = new System.Drawing.Point(583, 80);
            this.bttn_editInfo.Name = "bttn_editInfo";
            this.bttn_editInfo.Size = new System.Drawing.Size(75, 23);
            this.bttn_editInfo.TabIndex = 6;
            this.bttn_editInfo.Text = "Edit Info?";
            this.bttn_editInfo.UseVisualStyleBackColor = true;
            this.bttn_editInfo.Visible = false;
            this.bttn_editInfo.Click += new System.EventHandler(this.bttn_editInfo_Click);
            // 
            // frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(735, 483);
            this.Controls.Add(this.bttn_editInfo);
            this.Controls.Add(this.bttn_nameIn);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_HelloWorld";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button bttn_nameIn;
        private System.Windows.Forms.Button bttn_editInfo;
    }
}

