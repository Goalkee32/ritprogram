namespace ritprogram
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSudd = new System.Windows.Forms.Button();
            this.btnEllips = new System.Windows.Forms.Button();
            this.btnRektangel = new System.Windows.Forms.Button();
            this.tbxStorlek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPenna = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 425);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(597, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 38);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSudd
            // 
            this.btnSudd.BackColor = System.Drawing.Color.White;
            this.btnSudd.Image = ((System.Drawing.Image)(resources.GetObject("btnSudd.Image")));
            this.btnSudd.Location = new System.Drawing.Point(708, 67);
            this.btnSudd.Name = "btnSudd";
            this.btnSudd.Size = new System.Drawing.Size(70, 70);
            this.btnSudd.TabIndex = 2;
            this.btnSudd.UseVisualStyleBackColor = false;
            this.btnSudd.Click += new System.EventHandler(this.btnSudd_Click);
            // 
            // btnEllips
            // 
            this.btnEllips.BackColor = System.Drawing.Color.White;
            this.btnEllips.Image = ((System.Drawing.Image)(resources.GetObject("btnEllips.Image")));
            this.btnEllips.Location = new System.Drawing.Point(619, 158);
            this.btnEllips.Name = "btnEllips";
            this.btnEllips.Size = new System.Drawing.Size(70, 70);
            this.btnEllips.TabIndex = 2;
            this.btnEllips.UseVisualStyleBackColor = false;
            this.btnEllips.Click += new System.EventHandler(this.btnEllips_Click);
            // 
            // btnRektangel
            // 
            this.btnRektangel.BackColor = System.Drawing.Color.White;
            this.btnRektangel.Image = ((System.Drawing.Image)(resources.GetObject("btnRektangel.Image")));
            this.btnRektangel.Location = new System.Drawing.Point(708, 158);
            this.btnRektangel.Name = "btnRektangel";
            this.btnRektangel.Size = new System.Drawing.Size(70, 70);
            this.btnRektangel.TabIndex = 2;
            this.btnRektangel.UseVisualStyleBackColor = false;
            this.btnRektangel.Click += new System.EventHandler(this.btnRektangel_Click);
            // 
            // tbxStorlek
            // 
            this.tbxStorlek.Location = new System.Drawing.Point(692, 258);
            this.tbxStorlek.Name = "tbxStorlek";
            this.tbxStorlek.Size = new System.Drawing.Size(100, 26);
            this.tbxStorlek.TabIndex = 3;
            this.tbxStorlek.Text = "5";
            this.tbxStorlek.TextChanged += new System.EventHandler(this.tbxStorlek_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Linje storlek";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(692, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPenna
            // 
            this.btnPenna.BackColor = System.Drawing.Color.White;
            this.btnPenna.Image = ((System.Drawing.Image)(resources.GetObject("btnPenna.Image")));
            this.btnPenna.Location = new System.Drawing.Point(619, 67);
            this.btnPenna.Name = "btnPenna";
            this.btnPenna.Size = new System.Drawing.Size(70, 70);
            this.btnPenna.TabIndex = 2;
            this.btnPenna.UseVisualStyleBackColor = false;
            this.btnPenna.Click += new System.EventHandler(this.btnPenna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxStorlek);
            this.Controls.Add(this.btnRektangel);
            this.Controls.Add(this.btnEllips);
            this.Controls.Add(this.btnSudd);
            this.Controls.Add(this.btnPenna);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ritprogram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSudd;
        private System.Windows.Forms.Button btnEllips;
        private System.Windows.Forms.Button btnRektangel;
        private System.Windows.Forms.TextBox tbxStorlek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPenna;
    }
}

