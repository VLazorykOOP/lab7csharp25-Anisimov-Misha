namespace GraphPlotter

{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupColor, groupWidth, groupStyle;
        private System.Windows.Forms.RadioButton rbRed, rbGreen, rbBlue;
        private System.Windows.Forms.RadioButton rbThin, rbMedium, rbThick;
        private System.Windows.Forms.RadioButton rbSolid, rbDash, rbDot;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.groupWidth = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.groupStyle = new System.Windows.Forms.GroupBox();
            this.rbSolid = new System.Windows.Forms.RadioButton();
            this.rbDash = new System.Windows.Forms.RadioButton();
            this.rbDot = new System.Windows.Forms.RadioButton();
            this.groupColor.SuspendLayout();
            this.groupWidth.SuspendLayout();
            this.groupStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.Location = new System.Drawing.Point(20, 20);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(500, 300);
            this.panelGraph.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(540, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Побудувати";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.rbRed);
            this.groupColor.Controls.Add(this.rbGreen);
            this.groupColor.Controls.Add(this.rbBlue);
            this.groupColor.Location = new System.Drawing.Point(540, 20);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(120, 90);
            this.groupColor.TabIndex = 2;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Колір";
            // 
            // rbRed
            // 
            this.rbRed.Checked = true;
            this.rbRed.Location = new System.Drawing.Point(10, 20);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(104, 24);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Червоний";
            // 
            // rbGreen
            // 
            this.rbGreen.Location = new System.Drawing.Point(10, 40);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(104, 24);
            this.rbGreen.TabIndex = 1;
            this.rbGreen.Text = "Зелений";
            // 
            // rbBlue
            // 
            this.rbBlue.Location = new System.Drawing.Point(10, 60);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(104, 24);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.Text = "Синій";
            // 
            // groupWidth
            // 
            this.groupWidth.Controls.Add(this.rbThin);
            this.groupWidth.Controls.Add(this.rbMedium);
            this.groupWidth.Controls.Add(this.rbThick);
            this.groupWidth.Location = new System.Drawing.Point(540, 120);
            this.groupWidth.Name = "groupWidth";
            this.groupWidth.Size = new System.Drawing.Size(120, 90);
            this.groupWidth.TabIndex = 3;
            this.groupWidth.TabStop = false;
            this.groupWidth.Text = "Товщина";
            // 
            // rbThin
            // 
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(10, 20);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(104, 24);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Тонка";
            // 
            // rbMedium
            // 
            this.rbMedium.Location = new System.Drawing.Point(10, 40);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(104, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "Середня";
            // 
            // rbThick
            // 
            this.rbThick.Location = new System.Drawing.Point(10, 60);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(104, 24);
            this.rbThick.TabIndex = 2;
            this.rbThick.Text = "Товста";
            // 
            // groupStyle
            // 
            this.groupStyle.Controls.Add(this.rbSolid);
            this.groupStyle.Controls.Add(this.rbDash);
            this.groupStyle.Controls.Add(this.rbDot);
            this.groupStyle.Location = new System.Drawing.Point(540, 220);
            this.groupStyle.Name = "groupStyle";
            this.groupStyle.Size = new System.Drawing.Size(120, 90);
            this.groupStyle.TabIndex = 4;
            this.groupStyle.TabStop = false;
            this.groupStyle.Text = "Стиль";
            // 
            // rbSolid
            // 
            this.rbSolid.Checked = true;
            this.rbSolid.Location = new System.Drawing.Point(10, 20);
            this.rbSolid.Name = "rbSolid";
            this.rbSolid.Size = new System.Drawing.Size(104, 24);
            this.rbSolid.TabIndex = 0;
            this.rbSolid.TabStop = true;
            this.rbSolid.Text = "Суцільна";
            // 
            // rbDash
            // 
            this.rbDash.Location = new System.Drawing.Point(10, 40);
            this.rbDash.Name = "rbDash";
            this.rbDash.Size = new System.Drawing.Size(104, 24);
            this.rbDash.TabIndex = 1;
            this.rbDash.Text = "Штрихова";
            // 
            // rbDot
            // 
            this.rbDot.Location = new System.Drawing.Point(10, 60);
            this.rbDot.Name = "rbDot";
            this.rbDot.Size = new System.Drawing.Size(104, 24);
            this.rbDot.TabIndex = 2;
            this.rbDot.Text = "Пунктирна";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(869, 543);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.groupWidth);
            this.Controls.Add(this.groupStyle);
            this.Name = "Form1";
            this.Text = "Графік функції";
            this.groupColor.ResumeLayout(false);
            this.groupWidth.ResumeLayout(false);
            this.groupStyle.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
