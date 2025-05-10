namespace CalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1, label2, label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtNumber1
            this.txtNumber1.Location = new System.Drawing.Point(120, 30);
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);

            // txtNumber2
            this.txtNumber2.Location = new System.Drawing.Point(120, 60);
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(120, 90);
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);

            // Radio Buttons
            this.rbAdd.Text = "Додати";
            this.rbAdd.Location = new System.Drawing.Point(250, 30);

            this.rbSubtract.Text = "Відняти";
            this.rbSubtract.Location = new System.Drawing.Point(250, 50);

            this.rbMultiply.Text = "Множити";
            this.rbMultiply.Location = new System.Drawing.Point(250, 70);

            this.rbDivide.Text = "Ділити";
            this.rbDivide.Location = new System.Drawing.Point(250, 90);

            // Button
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.Location = new System.Drawing.Point(120, 130);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // Labels
            this.label1.Text = "Число 1:";
            this.label1.Location = new System.Drawing.Point(30, 30);

            this.label2.Text = "Число 2:";
            this.label2.Location = new System.Drawing.Point(30, 60);

            this.label3.Text = "Результат:";
            this.label3.Location = new System.Drawing.Point(30, 90);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.rbSubtract);
            this.Controls.Add(this.rbMultiply);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
