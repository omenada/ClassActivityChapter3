using System;
using System.Windows.Forms;


public class frmMain :Form

{
    private Label label2;
    private TextBox txtOperand1;
    private TextBox txtOperand2;
    private TextBox txtResult;
    private Button btnCalc;
    private Button btnExit;
    private Label label1;
    #region Windowns Code
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First integer value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Integer Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(189, 12);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 2;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(189, 54);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(25, 90);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(264, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(25, 134);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(218, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(313, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interger Division";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion


    public frmMain()
    {

        InitializeComponent();
    }
    [STAThread]

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);

    }

    private void Button1_Click(object sender, EventArgs e)
    {

    }

    private void BtnCalc_Click(object sender, EventArgs e)
    {
        {
            bool flag;
            //example int 
            //int operand1;
            //int operand2;
            //int answer;

            //example float
            //float operand1;
            //float operand2;
            //float answer;

            //example double
            //double operand1;
            //double operand2;
            //double answer;

            //example decimal
            decimal operand1;
            decimal operand2;
            decimal answer;

            // Input Step
            // Check first input...
            flag = decimal.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand1.Focus();
                return;
            }
            // Check second input...
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }
            // Process Step
            answer = operand1 / operand2;
            // Display Step
            txtResult.Text = operand1.ToString() + " divided by " +
            operand2.ToString() + " equals " + answer.ToString();
            txtResult.Visible = true;
        }
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}