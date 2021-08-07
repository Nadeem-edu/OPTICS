namespace OM_EYE_CARE.UI
{
    partial class frmusers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusers));
            this.usertoppanal = new System.Windows.Forms.Panel();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbluserfname = new System.Windows.Forms.Label();
            this.txtuserfname = new System.Windows.Forms.TextBox();
            this.txtuserLname = new System.Windows.Forms.TextBox();
            this.lbluserpass = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lbluserusername = new System.Windows.Forms.Label();
            this.txtuserpass = new System.Windows.Forms.TextBox();
            this.lbluserlname = new System.Windows.Forms.Label();
            this.txtuseremail_id = new System.Windows.Forms.TextBox();
            this.lbluseremail = new System.Windows.Forms.Label();
            this.lblusercontact_no = new System.Windows.Forms.Label();
            this.lbluseraddress = new System.Windows.Forms.Label();
            this.lblusergender = new System.Windows.Forms.Label();
            this.txtuseraddress = new System.Windows.Forms.TextBox();
            this.cbusergender = new System.Windows.Forms.ComboBox();
            this.txtusercontact_no = new System.Windows.Forms.TextBox();
            this.btnusersubmit = new System.Windows.Forms.Button();
            this.panelright = new System.Windows.Forms.Panel();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.dgvuserview = new System.Windows.Forms.DataGridView();
            this.txtusersearch = new System.Windows.Forms.TextBox();
            this.lblusersearch = new System.Windows.Forms.Label();
            this.btnuserdelete = new System.Windows.Forms.Button();
            this.txtuserID = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.btnuserupdate = new System.Windows.Forms.Button();
            this.btnuserclear = new System.Windows.Forms.Button();
            this.emailerroruser = new System.Windows.Forms.ErrorProvider(this.components);
            this.panalleft = new System.Windows.Forms.Panel();
            this.usertoppanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailerroruser)).BeginInit();
            this.SuspendLayout();
            // 
            // usertoppanal
            // 
            this.usertoppanal.BackColor = System.Drawing.Color.Turquoise;
            this.usertoppanal.Controls.Add(this.lbluser);
            this.usertoppanal.Controls.Add(this.pictureBox1);
            this.usertoppanal.Dock = System.Windows.Forms.DockStyle.Top;
            this.usertoppanal.Location = new System.Drawing.Point(0, 0);
            this.usertoppanal.Name = "usertoppanal";
            this.usertoppanal.Size = new System.Drawing.Size(626, 28);
            this.usertoppanal.TabIndex = 0;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(272, 2);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(43, 21);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbluserfname
            // 
            this.lbluserfname.AutoSize = true;
            this.lbluserfname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserfname.Location = new System.Drawing.Point(30, 81);
            this.lbluserfname.Name = "lbluserfname";
            this.lbluserfname.Size = new System.Drawing.Size(79, 17);
            this.lbluserfname.TabIndex = 1;
            this.lbluserfname.Text = "First Name:";
            // 
            // txtuserfname
            // 
            this.txtuserfname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserfname.Location = new System.Drawing.Point(113, 75);
            this.txtuserfname.Name = "txtuserfname";
            this.txtuserfname.Size = new System.Drawing.Size(125, 23);
            this.txtuserfname.TabIndex = 2;
            // 
            // txtuserLname
            // 
            this.txtuserLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserLname.Location = new System.Drawing.Point(113, 117);
            this.txtuserLname.Name = "txtuserLname";
            this.txtuserLname.Size = new System.Drawing.Size(125, 23);
            this.txtuserLname.TabIndex = 4;
            this.txtuserLname.TextChanged += new System.EventHandler(this.txtuserLname_TextChanged);
            // 
            // lbluserpass
            // 
            this.lbluserpass.AutoSize = true;
            this.lbluserpass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserpass.Location = new System.Drawing.Point(30, 189);
            this.lbluserpass.Name = "lbluserpass";
            this.lbluserpass.Size = new System.Drawing.Size(70, 17);
            this.lbluserpass.TabIndex = 3;
            this.lbluserpass.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(113, 153);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(125, 23);
            this.txtusername.TabIndex = 6;
            // 
            // lbluserusername
            // 
            this.lbluserusername.AutoSize = true;
            this.lbluserusername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserusername.Location = new System.Drawing.Point(30, 153);
            this.lbluserusername.Name = "lbluserusername";
            this.lbluserusername.Size = new System.Drawing.Size(73, 17);
            this.lbluserusername.TabIndex = 5;
            this.lbluserusername.Text = "Username:";
            // 
            // txtuserpass
            // 
            this.txtuserpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserpass.Location = new System.Drawing.Point(113, 188);
            this.txtuserpass.Name = "txtuserpass";
            this.txtuserpass.PasswordChar = '*';
            this.txtuserpass.Size = new System.Drawing.Size(125, 23);
            this.txtuserpass.TabIndex = 8;
            // 
            // lbluserlname
            // 
            this.lbluserlname.AutoSize = true;
            this.lbluserlname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserlname.Location = new System.Drawing.Point(30, 118);
            this.lbluserlname.Name = "lbluserlname";
            this.lbluserlname.Size = new System.Drawing.Size(77, 17);
            this.lbluserlname.TabIndex = 7;
            this.lbluserlname.Text = "Last Name:";
            // 
            // txtuseremail_id
            // 
            this.txtuseremail_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuseremail_id.Location = new System.Drawing.Point(113, 226);
            this.txtuseremail_id.Name = "txtuseremail_id";
            this.txtuseremail_id.Size = new System.Drawing.Size(125, 23);
            this.txtuseremail_id.TabIndex = 10;
            this.txtuseremail_id.Leave += new System.EventHandler(this.txtuseremail_id_Leave);
            // 
            // lbluseremail
            // 
            this.lbluseremail.AutoSize = true;
            this.lbluseremail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluseremail.Location = new System.Drawing.Point(30, 227);
            this.lbluseremail.Name = "lbluseremail";
            this.lbluseremail.Size = new System.Drawing.Size(64, 17);
            this.lbluseremail.TabIndex = 9;
            this.lbluseremail.Text = "Email ID:";
            // 
            // lblusercontact_no
            // 
            this.lblusercontact_no.AutoSize = true;
            this.lblusercontact_no.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusercontact_no.Location = new System.Drawing.Point(30, 332);
            this.lblusercontact_no.Name = "lblusercontact_no";
            this.lblusercontact_no.Size = new System.Drawing.Size(81, 17);
            this.lblusercontact_no.TabIndex = 11;
            this.lblusercontact_no.Text = "Contact No:";
            // 
            // lbluseraddress
            // 
            this.lbluseraddress.AutoSize = true;
            this.lbluseraddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluseraddress.Location = new System.Drawing.Point(30, 259);
            this.lbluseraddress.Name = "lbluseraddress";
            this.lbluseraddress.Size = new System.Drawing.Size(61, 17);
            this.lbluseraddress.TabIndex = 12;
            this.lbluseraddress.Text = "Address:";
            // 
            // lblusergender
            // 
            this.lblusergender.AutoSize = true;
            this.lblusergender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusergender.Location = new System.Drawing.Point(30, 297);
            this.lblusergender.Name = "lblusergender";
            this.lblusergender.Size = new System.Drawing.Size(56, 17);
            this.lblusergender.TabIndex = 13;
            this.lblusergender.Text = "Gender:";
            // 
            // txtuseraddress
            // 
            this.txtuseraddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuseraddress.Location = new System.Drawing.Point(113, 258);
            this.txtuseraddress.Multiline = true;
            this.txtuseraddress.Name = "txtuseraddress";
            this.txtuseraddress.Size = new System.Drawing.Size(125, 25);
            this.txtuseraddress.TabIndex = 14;
            // 
            // cbusergender
            // 
            this.cbusergender.FormattingEnabled = true;
            this.cbusergender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbusergender.Location = new System.Drawing.Point(113, 297);
            this.cbusergender.Name = "cbusergender";
            this.cbusergender.Size = new System.Drawing.Size(125, 21);
            this.cbusergender.TabIndex = 15;
            // 
            // txtusercontact_no
            // 
            this.txtusercontact_no.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusercontact_no.Location = new System.Drawing.Point(113, 331);
            this.txtusercontact_no.MaxLength = 10;
            this.txtusercontact_no.Name = "txtusercontact_no";
            this.txtusercontact_no.Size = new System.Drawing.Size(125, 23);
            this.txtusercontact_no.TabIndex = 16;
            this.txtusercontact_no.TextChanged += new System.EventHandler(this.txtusercontact_no_TextChanged);
            this.txtusercontact_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusercontact_no_KeyPress);
            // 
            // btnusersubmit
            // 
            this.btnusersubmit.BackColor = System.Drawing.Color.Green;
            this.btnusersubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusersubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusersubmit.ForeColor = System.Drawing.Color.Azure;
            this.btnusersubmit.Location = new System.Drawing.Point(77, 377);
            this.btnusersubmit.Name = "btnusersubmit";
            this.btnusersubmit.Size = new System.Drawing.Size(88, 34);
            this.btnusersubmit.TabIndex = 17;
            this.btnusersubmit.Text = "Submit";
            this.btnusersubmit.UseVisualStyleBackColor = false;
            this.btnusersubmit.Click += new System.EventHandler(this.btnusersubmit_Click);
            // 
            // panelright
            // 
            this.panelright.BackColor = System.Drawing.Color.Turquoise;
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(616, 28);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(10, 422);
            this.panelright.TabIndex = 19;
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.Turquoise;
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(10, 440);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(606, 10);
            this.panelbottom.TabIndex = 20;
            // 
            // dgvuserview
            // 
            this.dgvuserview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuserview.Location = new System.Drawing.Point(259, 122);
            this.dgvuserview.Name = "dgvuserview";
            this.dgvuserview.Size = new System.Drawing.Size(351, 237);
            this.dgvuserview.TabIndex = 21;
            this.dgvuserview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvuserview_RowHeaderMouseClick);
            // 
            // txtusersearch
            // 
            this.txtusersearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusersearch.Location = new System.Drawing.Point(331, 75);
            this.txtusersearch.Name = "txtusersearch";
            this.txtusersearch.Size = new System.Drawing.Size(250, 23);
            this.txtusersearch.TabIndex = 23;
            this.txtusersearch.TextChanged += new System.EventHandler(this.txtusersearch_TextChanged);
            // 
            // lblusersearch
            // 
            this.lblusersearch.AutoSize = true;
            this.lblusersearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusersearch.Location = new System.Drawing.Point(273, 81);
            this.lblusersearch.Name = "lblusersearch";
            this.lblusersearch.Size = new System.Drawing.Size(52, 17);
            this.lblusersearch.TabIndex = 22;
            this.lblusersearch.Text = "Search:";
            // 
            // btnuserdelete
            // 
            this.btnuserdelete.BackColor = System.Drawing.Color.Red;
            this.btnuserdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuserdelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserdelete.ForeColor = System.Drawing.Color.Azure;
            this.btnuserdelete.Location = new System.Drawing.Point(464, 377);
            this.btnuserdelete.Name = "btnuserdelete";
            this.btnuserdelete.Size = new System.Drawing.Size(88, 34);
            this.btnuserdelete.TabIndex = 25;
            this.btnuserdelete.Text = "Delete";
            this.btnuserdelete.UseVisualStyleBackColor = false;
            this.btnuserdelete.Click += new System.EventHandler(this.btnuserdelete_Click);
            // 
            // txtuserID
            // 
            this.txtuserID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtuserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtuserID.Location = new System.Drawing.Point(285, 34);
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.ReadOnly = true;
            this.txtuserID.Size = new System.Drawing.Size(79, 29);
            this.txtuserID.TabIndex = 27;
            this.txtuserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(222, 35);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(57, 17);
            this.lbluserid.TabIndex = 26;
            this.lbluserid.Text = "User ID:";
            // 
            // btnuserupdate
            // 
            this.btnuserupdate.BackColor = System.Drawing.Color.Crimson;
            this.btnuserupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuserupdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserupdate.ForeColor = System.Drawing.Color.Azure;
            this.btnuserupdate.Location = new System.Drawing.Point(332, 377);
            this.btnuserupdate.Name = "btnuserupdate";
            this.btnuserupdate.Size = new System.Drawing.Size(88, 34);
            this.btnuserupdate.TabIndex = 28;
            this.btnuserupdate.Text = "Update";
            this.btnuserupdate.UseVisualStyleBackColor = false;
            this.btnuserupdate.Click += new System.EventHandler(this.btnuserupdate_Click);
            // 
            // btnuserclear
            // 
            this.btnuserclear.BackColor = System.Drawing.SystemColors.Menu;
            this.btnuserclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuserclear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserclear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnuserclear.Location = new System.Drawing.Point(204, 377);
            this.btnuserclear.Name = "btnuserclear";
            this.btnuserclear.Size = new System.Drawing.Size(88, 34);
            this.btnuserclear.TabIndex = 29;
            this.btnuserclear.Text = "Clear";
            this.btnuserclear.UseVisualStyleBackColor = false;
            this.btnuserclear.Click += new System.EventHandler(this.btnuserclear_Click);
            // 
            // emailerroruser
            // 
            this.emailerroruser.ContainerControl = this;
            // 
            // panalleft
            // 
            this.panalleft.BackColor = System.Drawing.Color.Turquoise;
            this.panalleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panalleft.Location = new System.Drawing.Point(0, 28);
            this.panalleft.Name = "panalleft";
            this.panalleft.Size = new System.Drawing.Size(10, 422);
            this.panalleft.TabIndex = 18;
            // 
            // frmusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.btnuserclear);
            this.Controls.Add(this.btnuserupdate);
            this.Controls.Add(this.txtuserID);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.btnuserdelete);
            this.Controls.Add(this.txtusersearch);
            this.Controls.Add(this.lblusersearch);
            this.Controls.Add(this.dgvuserview);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panalleft);
            this.Controls.Add(this.btnusersubmit);
            this.Controls.Add(this.txtusercontact_no);
            this.Controls.Add(this.cbusergender);
            this.Controls.Add(this.txtuseraddress);
            this.Controls.Add(this.lblusergender);
            this.Controls.Add(this.lbluseraddress);
            this.Controls.Add(this.lblusercontact_no);
            this.Controls.Add(this.txtuseremail_id);
            this.Controls.Add(this.lbluseremail);
            this.Controls.Add(this.txtuserpass);
            this.Controls.Add(this.lbluserlname);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lbluserusername);
            this.Controls.Add(this.txtuserLname);
            this.Controls.Add(this.lbluserpass);
            this.Controls.Add(this.txtuserfname);
            this.Controls.Add(this.lbluserfname);
            this.Controls.Add(this.usertoppanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmusers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmusers_Load);
            this.usertoppanal.ResumeLayout(false);
            this.usertoppanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailerroruser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel usertoppanal;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbluserfname;
        private System.Windows.Forms.TextBox txtuserfname;
        private System.Windows.Forms.TextBox txtuserLname;
        private System.Windows.Forms.Label lbluserpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lbluserusername;
        private System.Windows.Forms.TextBox txtuserpass;
        private System.Windows.Forms.Label lbluserlname;
        private System.Windows.Forms.TextBox txtuseremail_id;
        private System.Windows.Forms.Label lbluseremail;
        private System.Windows.Forms.Label lblusercontact_no;
        private System.Windows.Forms.Label lbluseraddress;
        private System.Windows.Forms.Label lblusergender;
        private System.Windows.Forms.TextBox txtuseraddress;
        private System.Windows.Forms.ComboBox cbusergender;
        private System.Windows.Forms.TextBox txtusercontact_no;
        private System.Windows.Forms.Button btnusersubmit;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.DataGridView dgvuserview;
        private System.Windows.Forms.TextBox txtusersearch;
        private System.Windows.Forms.Label lblusersearch;
        private System.Windows.Forms.Button btnuserdelete;
        private System.Windows.Forms.TextBox txtuserID;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Button btnuserupdate;
        private System.Windows.Forms.Button btnuserclear;
        private System.Windows.Forms.ErrorProvider emailerroruser;
        private System.Windows.Forms.Panel panalleft;
    }
}