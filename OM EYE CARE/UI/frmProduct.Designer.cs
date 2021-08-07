namespace OM_EYE_CARE.UI
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.usertoppanal = new System.Windows.Forms.Panel();
            this.proclose = new System.Windows.Forms.PictureBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.panalleft = new System.Windows.Forms.Panel();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.panelright = new System.Windows.Forms.Panel();
            this.gbproduct = new System.Windows.Forms.GroupBox();
            this.btngbproAdd = new System.Windows.Forms.Button();
            this.txtgbproqty = new System.Windows.Forms.TextBox();
            this.txtgbprodName = new System.Windows.Forms.TextBox();
            this.btngbprodelete = new System.Windows.Forms.Button();
            this.btngbproupdate = new System.Windows.Forms.Button();
            this.lblgbproquantity = new System.Windows.Forms.Label();
            this.lblgbproname = new System.Windows.Forms.Label();
            this.lblgbproiddisplay = new System.Windows.Forms.Label();
            this.lblgbproid = new System.Windows.Forms.Label();
            this.lblproSearch = new System.Windows.Forms.Label();
            this.txtproSearch = new System.Windows.Forms.TextBox();
            this.dgvproductview = new System.Windows.Forms.DataGridView();
            this.usertoppanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proclose)).BeginInit();
            this.gbproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductview)).BeginInit();
            this.SuspendLayout();
            // 
            // usertoppanal
            // 
            this.usertoppanal.BackColor = System.Drawing.Color.Turquoise;
            this.usertoppanal.Controls.Add(this.proclose);
            this.usertoppanal.Controls.Add(this.lbluser);
            this.usertoppanal.Dock = System.Windows.Forms.DockStyle.Top;
            this.usertoppanal.Location = new System.Drawing.Point(0, 0);
            this.usertoppanal.Name = "usertoppanal";
            this.usertoppanal.Size = new System.Drawing.Size(648, 31);
            this.usertoppanal.TabIndex = 1;
            // 
            // proclose
            // 
            this.proclose.Image = ((System.Drawing.Image)(resources.GetObject("proclose.Image")));
            this.proclose.Location = new System.Drawing.Point(620, 3);
            this.proclose.Name = "proclose";
            this.proclose.Size = new System.Drawing.Size(25, 25);
            this.proclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.proclose.TabIndex = 27;
            this.proclose.TabStop = false;
            this.proclose.Click += new System.EventHandler(this.proclose_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(282, 3);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(82, 24);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "Product";
            // 
            // panalleft
            // 
            this.panalleft.BackColor = System.Drawing.Color.Turquoise;
            this.panalleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panalleft.Location = new System.Drawing.Point(0, 31);
            this.panalleft.Name = "panalleft";
            this.panalleft.Size = new System.Drawing.Size(10, 443);
            this.panalleft.TabIndex = 19;
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.Turquoise;
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(10, 464);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(638, 10);
            this.panelbottom.TabIndex = 21;
            // 
            // panelright
            // 
            this.panelright.BackColor = System.Drawing.Color.Turquoise;
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(638, 31);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(10, 433);
            this.panelright.TabIndex = 22;
            // 
            // gbproduct
            // 
            this.gbproduct.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.gbproduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbproduct.BackColor = System.Drawing.SystemColors.Window;
            this.gbproduct.Controls.Add(this.btngbproAdd);
            this.gbproduct.Controls.Add(this.txtgbproqty);
            this.gbproduct.Controls.Add(this.txtgbprodName);
            this.gbproduct.Controls.Add(this.btngbprodelete);
            this.gbproduct.Controls.Add(this.btngbproupdate);
            this.gbproduct.Controls.Add(this.lblgbproquantity);
            this.gbproduct.Controls.Add(this.lblgbproname);
            this.gbproduct.Controls.Add(this.lblgbproiddisplay);
            this.gbproduct.Controls.Add(this.lblgbproid);
            this.gbproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbproduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbproduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbproduct.Location = new System.Drawing.Point(16, 320);
            this.gbproduct.Name = "gbproduct";
            this.gbproduct.Size = new System.Drawing.Size(616, 138);
            this.gbproduct.TabIndex = 23;
            this.gbproduct.TabStop = false;
            this.gbproduct.Text = "Item Info";
            // 
            // btngbproAdd
            // 
            this.btngbproAdd.BackColor = System.Drawing.Color.Green;
            this.btngbproAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngbproAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngbproAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btngbproAdd.Location = new System.Drawing.Point(102, 99);
            this.btngbproAdd.Name = "btngbproAdd";
            this.btngbproAdd.Size = new System.Drawing.Size(122, 31);
            this.btngbproAdd.TabIndex = 29;
            this.btngbproAdd.Text = "Add Product";
            this.btngbproAdd.UseVisualStyleBackColor = false;
            this.btngbproAdd.Click += new System.EventHandler(this.btngbproAdd_Click);
            // 
            // txtgbproqty
            // 
            this.txtgbproqty.BackColor = System.Drawing.Color.Honeydew;
            this.txtgbproqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgbproqty.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgbproqty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtgbproqty.Location = new System.Drawing.Point(415, 48);
            this.txtgbproqty.Multiline = true;
            this.txtgbproqty.Name = "txtgbproqty";
            this.txtgbproqty.Size = new System.Drawing.Size(129, 31);
            this.txtgbproqty.TabIndex = 28;
            this.txtgbproqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgbproqty_KeyPress);
            // 
            // txtgbprodName
            // 
            this.txtgbprodName.BackColor = System.Drawing.Color.Honeydew;
            this.txtgbprodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgbprodName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgbprodName.Location = new System.Drawing.Point(202, 50);
            this.txtgbprodName.Multiline = true;
            this.txtgbprodName.Name = "txtgbprodName";
            this.txtgbprodName.Size = new System.Drawing.Size(129, 29);
            this.txtgbprodName.TabIndex = 26;
            // 
            // btngbprodelete
            // 
            this.btngbprodelete.BackColor = System.Drawing.Color.Red;
            this.btngbprodelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngbprodelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngbprodelete.ForeColor = System.Drawing.Color.Azure;
            this.btngbprodelete.Location = new System.Drawing.Point(411, 99);
            this.btngbprodelete.Name = "btngbprodelete";
            this.btngbprodelete.Size = new System.Drawing.Size(122, 31);
            this.btngbprodelete.TabIndex = 25;
            this.btngbprodelete.Text = "Delete";
            this.btngbprodelete.UseVisualStyleBackColor = false;
            this.btngbprodelete.Click += new System.EventHandler(this.btngbprodelete_Click);
            // 
            // btngbproupdate
            // 
            this.btngbproupdate.BackColor = System.Drawing.Color.Crimson;
            this.btngbproupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngbproupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngbproupdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btngbproupdate.Location = new System.Drawing.Point(259, 99);
            this.btngbproupdate.Name = "btngbproupdate";
            this.btngbproupdate.Size = new System.Drawing.Size(122, 31);
            this.btngbproupdate.TabIndex = 24;
            this.btngbproupdate.Text = "Update";
            this.btngbproupdate.UseVisualStyleBackColor = false;
            this.btngbproupdate.Click += new System.EventHandler(this.btngbproupdate_Click);
            // 
            // lblgbproquantity
            // 
            this.lblgbproquantity.AutoSize = true;
            this.lblgbproquantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgbproquantity.Location = new System.Drawing.Point(337, 53);
            this.lblgbproquantity.Name = "lblgbproquantity";
            this.lblgbproquantity.Size = new System.Drawing.Size(76, 21);
            this.lblgbproquantity.TabIndex = 3;
            this.lblgbproquantity.Text = "Quantity:";
            // 
            // lblgbproname
            // 
            this.lblgbproname.AutoSize = true;
            this.lblgbproname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgbproname.Location = new System.Drawing.Point(77, 53);
            this.lblgbproname.Name = "lblgbproname";
            this.lblgbproname.Size = new System.Drawing.Size(119, 21);
            this.lblgbproname.TabIndex = 2;
            this.lblgbproname.Text = "Product Name:";
            // 
            // lblgbproiddisplay
            // 
            this.lblgbproiddisplay.AutoSize = true;
            this.lblgbproiddisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgbproiddisplay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblgbproiddisplay.Location = new System.Drawing.Point(337, 16);
            this.lblgbproiddisplay.Name = "lblgbproiddisplay";
            this.lblgbproiddisplay.Size = new System.Drawing.Size(19, 20);
            this.lblgbproiddisplay.TabIndex = 1;
            this.lblgbproiddisplay.Text = "0";
            // 
            // lblgbproid
            // 
            this.lblgbproid.AutoSize = true;
            this.lblgbproid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgbproid.Location = new System.Drawing.Point(236, 16);
            this.lblgbproid.Name = "lblgbproid";
            this.lblgbproid.Size = new System.Drawing.Size(95, 21);
            this.lblgbproid.TabIndex = 0;
            this.lblgbproid.Text = "Product ID:";
            // 
            // lblproSearch
            // 
            this.lblproSearch.AutoSize = true;
            this.lblproSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproSearch.Location = new System.Drawing.Point(183, 44);
            this.lblproSearch.Name = "lblproSearch";
            this.lblproSearch.Size = new System.Drawing.Size(76, 25);
            this.lblproSearch.TabIndex = 24;
            this.lblproSearch.Text = "Search:";
            // 
            // txtproSearch
            // 
            this.txtproSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.txtproSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproSearch.Location = new System.Drawing.Point(265, 36);
            this.txtproSearch.Multiline = true;
            this.txtproSearch.Name = "txtproSearch";
            this.txtproSearch.Size = new System.Drawing.Size(221, 33);
            this.txtproSearch.TabIndex = 25;
            this.txtproSearch.TextChanged += new System.EventHandler(this.txtproSearch_TextChanged);
            // 
            // dgvproductview
            // 
            this.dgvproductview.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvproductview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproductview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductview.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvproductview.Location = new System.Drawing.Point(41, 78);
            this.dgvproductview.Name = "dgvproductview";
            this.dgvproductview.Size = new System.Drawing.Size(560, 236);
            this.dgvproductview.TabIndex = 26;
            this.dgvproductview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproductview_RowHeaderMouseClick);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(648, 474);
            this.Controls.Add(this.dgvproductview);
            this.Controls.Add(this.txtproSearch);
            this.Controls.Add(this.lblproSearch);
            this.Controls.Add(this.gbproduct);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.panalleft);
            this.Controls.Add(this.usertoppanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.usertoppanal.ResumeLayout(false);
            this.usertoppanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proclose)).EndInit();
            this.gbproduct.ResumeLayout(false);
            this.gbproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel usertoppanal;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Panel panalleft;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.GroupBox gbproduct;
        private System.Windows.Forms.Label lblgbproquantity;
        private System.Windows.Forms.Label lblgbproname;
        private System.Windows.Forms.Label lblgbproiddisplay;
        private System.Windows.Forms.Label lblgbproid;
        private System.Windows.Forms.TextBox txtgbproqty;
        private System.Windows.Forms.TextBox txtgbprodName;
        private System.Windows.Forms.Button btngbprodelete;
        private System.Windows.Forms.Button btngbproupdate;
        private System.Windows.Forms.Label lblproSearch;
        private System.Windows.Forms.TextBox txtproSearch;
        private System.Windows.Forms.DataGridView dgvproductview;
        private System.Windows.Forms.Button btngbproAdd;
        private System.Windows.Forms.PictureBox proclose;
    }
}