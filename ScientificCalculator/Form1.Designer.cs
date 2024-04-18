namespace ScientificCalculator
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
            btnBackspace = new Button();
            txtResult = new TextBox();
            btnClearEntry = new Button();
            btnCancle = new Button();
            btnPlusMinus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnZero = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btnDiv = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitCalculatorToolStripMenuItem = new ToolStripMenuItem();
            btnPI = new Button();
            btnSine = new Button();
            btnInverseSine = new Button();
            btnTangent = new Button();
            btnModulo = new Button();
            btnLog = new Button();
            btnCos = new Button();
            btnInverseCos = new Button();
            btnSqrt = new Button();
            btnInverseTangent = new Button();
            btnPercentage = new Button();
            btnBinary = new Button();
            btnDecimal = new Button();
            btnExponential = new Button();
            btnHexadecimal = new Button();
            btnOcta = new Button();
            btnInverseLog = new Button();
            btnPower2 = new Button();
            btnPower3 = new Button();
            btnInverse = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBackspace
            // 
            btnBackspace.Font = new Font("Comic Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackspace.Location = new Point(24, 90);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(78, 63);
            btnBackspace.TabIndex = 0;
            btnBackspace.Text = "Backspace";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            txtResult.Location = new Point(23, 31);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(760, 44);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnClearEntry.Location = new Point(123, 90);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(78, 63);
            btnClearEntry.TabIndex = 2;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnCancle
            // 
            btnCancle.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnCancle.Location = new Point(216, 90);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(78, 63);
            btnCancle.TabIndex = 3;
            btnCancle.Text = "C";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnPlusMinus.Location = new Point(313, 90);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(78, 63);
            btnPlusMinus.TabIndex = 4;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = true;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn7.Location = new Point(24, 159);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 63);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn8.Location = new Point(123, 159);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 63);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn9.Location = new Point(216, 159);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 63);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnAdd.Location = new Point(313, 159);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 63);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += NumberOperators;
            // 
            // btn4
            // 
            btn4.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn4.Location = new Point(24, 229);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 63);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn1.Location = new Point(24, 298);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 63);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn5.Location = new Point(123, 229);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 63);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn2.Location = new Point(123, 298);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 63);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn6.Location = new Point(216, 229);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 63);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btn3.Location = new Point(216, 298);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 63);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnSub.Location = new Point(313, 229);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(78, 63);
            btnSub.TabIndex = 4;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += NumberOperators;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnMult.Location = new Point(313, 298);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(78, 63);
            btnMult.TabIndex = 4;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += NumberOperators;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnZero.Location = new Point(23, 367);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(78, 63);
            btnZero.TabIndex = 0;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += EnterNumbers;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnDot.Location = new Point(122, 367);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(78, 63);
            btnDot.TabIndex = 2;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnEqual.Location = new Point(215, 367);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(78, 63);
            btnEqual.TabIndex = 3;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnDiv.Location = new Point(312, 367);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(78, 63);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += NumberOperators;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitCalculatorToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitCalculatorToolStripMenuItem
            // 
            exitCalculatorToolStripMenuItem.Name = "exitCalculatorToolStripMenuItem";
            exitCalculatorToolStripMenuItem.Size = new Size(150, 22);
            exitCalculatorToolStripMenuItem.Text = "Exit Calculator";
            exitCalculatorToolStripMenuItem.Click += exitCalculatorToolStripMenuItem_Click;
            // 
            // btnPI
            // 
            btnPI.Font = new Font("Comic Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPI.Location = new Point(417, 90);
            btnPI.Name = "btnPI";
            btnPI.Size = new Size(78, 63);
            btnPI.TabIndex = 0;
            btnPI.Text = "PI";
            btnPI.UseVisualStyleBackColor = true;
            btnPI.Click += btnPI_Click;
            // 
            // btnSine
            // 
            btnSine.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnSine.Location = new Point(417, 159);
            btnSine.Name = "btnSine";
            btnSine.Size = new Size(78, 63);
            btnSine.TabIndex = 0;
            btnSine.Text = "Sin";
            btnSine.UseVisualStyleBackColor = true;
            btnSine.Click += btnSine_Click;
            // 
            // btnInverseSine
            // 
            btnInverseSine.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnInverseSine.Location = new Point(417, 229);
            btnInverseSine.Name = "btnInverseSine";
            btnInverseSine.Size = new Size(78, 63);
            btnInverseSine.TabIndex = 0;
            btnInverseSine.Text = "Sinh";
            btnInverseSine.UseVisualStyleBackColor = true;
            btnInverseSine.Click += btnInverseSine_Click;
            // 
            // btnTangent
            // 
            btnTangent.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnTangent.Location = new Point(417, 298);
            btnTangent.Name = "btnTangent";
            btnTangent.Size = new Size(78, 63);
            btnTangent.TabIndex = 0;
            btnTangent.Text = "Tan";
            btnTangent.UseVisualStyleBackColor = true;
            btnTangent.Click += btnTangent_Click;
            // 
            // btnModulo
            // 
            btnModulo.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnModulo.Location = new Point(416, 367);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(78, 63);
            btnModulo.TabIndex = 0;
            btnModulo.Text = "Mod";
            btnModulo.UseVisualStyleBackColor = true;
            btnModulo.Click += btnModulo_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnLog.Location = new Point(516, 90);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(78, 63);
            btnLog.TabIndex = 2;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnCos.Location = new Point(516, 159);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(78, 63);
            btnCos.TabIndex = 2;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnInverseCos
            // 
            btnInverseCos.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnInverseCos.Location = new Point(516, 229);
            btnInverseCos.Name = "btnInverseCos";
            btnInverseCos.Size = new Size(78, 63);
            btnInverseCos.TabIndex = 2;
            btnInverseCos.Text = "Cosh";
            btnInverseCos.UseVisualStyleBackColor = true;
            btnInverseCos.Click += btnInverseCos_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnSqrt.Location = new Point(609, 90);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(78, 63);
            btnSqrt.TabIndex = 3;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnInverseTangent
            // 
            btnInverseTangent.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnInverseTangent.Location = new Point(516, 298);
            btnInverseTangent.Name = "btnInverseTangent";
            btnInverseTangent.Size = new Size(78, 63);
            btnInverseTangent.TabIndex = 2;
            btnInverseTangent.Text = "Tanh";
            btnInverseTangent.UseVisualStyleBackColor = true;
            btnInverseTangent.Click += btnInverseTangent_Click;
            // 
            // btnPercentage
            // 
            btnPercentage.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnPercentage.Location = new Point(515, 367);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(78, 63);
            btnPercentage.TabIndex = 2;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            btnPercentage.Click += btnPercentage_Click;
            // 
            // btnBinary
            // 
            btnBinary.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnBinary.Location = new Point(609, 159);
            btnBinary.Name = "btnBinary";
            btnBinary.Size = new Size(78, 63);
            btnBinary.TabIndex = 3;
            btnBinary.Text = "Bin";
            btnBinary.UseVisualStyleBackColor = true;
            btnBinary.Click += btnBinary_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnDecimal.Location = new Point(609, 229);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(78, 63);
            btnDecimal.TabIndex = 3;
            btnDecimal.Text = "Dec";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnExponential
            // 
            btnExponential.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnExponential.Location = new Point(706, 90);
            btnExponential.Name = "btnExponential";
            btnExponential.Size = new Size(78, 63);
            btnExponential.TabIndex = 4;
            btnExponential.Text = "Exp";
            btnExponential.UseVisualStyleBackColor = true;
            btnExponential.Click += btnExponential_Click;
            // 
            // btnHexadecimal
            // 
            btnHexadecimal.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnHexadecimal.Location = new Point(609, 298);
            btnHexadecimal.Name = "btnHexadecimal";
            btnHexadecimal.Size = new Size(78, 63);
            btnHexadecimal.TabIndex = 3;
            btnHexadecimal.Text = "Hex";
            btnHexadecimal.UseVisualStyleBackColor = true;
            btnHexadecimal.Click += btnHexadecimal_Click;
            // 
            // btnOcta
            // 
            btnOcta.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnOcta.Location = new Point(608, 367);
            btnOcta.Name = "btnOcta";
            btnOcta.Size = new Size(78, 63);
            btnOcta.TabIndex = 3;
            btnOcta.Text = "Oct";
            btnOcta.UseVisualStyleBackColor = true;
            btnOcta.Click += btnOcta_Click;
            // 
            // btnInverseLog
            // 
            btnInverseLog.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnInverseLog.Location = new Point(706, 159);
            btnInverseLog.Name = "btnInverseLog";
            btnInverseLog.Size = new Size(78, 63);
            btnInverseLog.TabIndex = 4;
            btnInverseLog.Text = "ln x";
            btnInverseLog.UseVisualStyleBackColor = true;
            btnInverseLog.Click += btnInverseLog_Click;
            // 
            // btnPower2
            // 
            btnPower2.Font = new Font("Comic Mono", 15F, FontStyle.Bold);
            btnPower2.Location = new Point(706, 229);
            btnPower2.Name = "btnPower2";
            btnPower2.Size = new Size(78, 63);
            btnPower2.TabIndex = 4;
            btnPower2.Text = "^2";
            btnPower2.UseVisualStyleBackColor = true;
            btnPower2.Click += btnPower2_Click;
            // 
            // btnPower3
            // 
            btnPower3.Font = new Font("Comic Mono", 12.75F, FontStyle.Bold);
            btnPower3.Location = new Point(706, 298);
            btnPower3.Name = "btnPower3";
            btnPower3.Size = new Size(78, 63);
            btnPower3.TabIndex = 4;
            btnPower3.Text = "^3";
            btnPower3.UseVisualStyleBackColor = true;
            btnPower3.Click += btnPower3_Click;
            // 
            // btnInverse
            // 
            btnInverse.Font = new Font("Comic Mono", 15.75F, FontStyle.Bold);
            btnInverse.Location = new Point(705, 367);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(78, 63);
            btnInverse.TabIndex = 4;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = true;
            btnInverse.Click += btnInverse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInverse);
            Controls.Add(btnDiv);
            Controls.Add(btnPower3);
            Controls.Add(btnMult);
            Controls.Add(btnPower2);
            Controls.Add(btnSub);
            Controls.Add(btnInverseLog);
            Controls.Add(btnAdd);
            Controls.Add(btnOcta);
            Controls.Add(btnEqual);
            Controls.Add(btnHexadecimal);
            Controls.Add(btn3);
            Controls.Add(btnExponential);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnDecimal);
            Controls.Add(btn6);
            Controls.Add(btnBinary);
            Controls.Add(btn9);
            Controls.Add(btnPercentage);
            Controls.Add(btnDot);
            Controls.Add(btnInverseTangent);
            Controls.Add(btn2);
            Controls.Add(btnSqrt);
            Controls.Add(btnCancle);
            Controls.Add(btnInverseCos);
            Controls.Add(btn5);
            Controls.Add(btnCos);
            Controls.Add(btn8);
            Controls.Add(btnLog);
            Controls.Add(btnClearEntry);
            Controls.Add(btnModulo);
            Controls.Add(btnTangent);
            Controls.Add(btnZero);
            Controls.Add(btn1);
            Controls.Add(btnInverseSine);
            Controls.Add(txtResult);
            Controls.Add(btnSine);
            Controls.Add(btn4);
            Controls.Add(btnPI);
            Controls.Add(btn7);
            Controls.Add(btnBackspace);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Scientific Calculator (Phil's)";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackspace;
        private TextBox txtResult;
        private Button btnClearEntry;
        private Button btnCancle;
        private Button btnPlusMinus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btn4;
        private Button btn1;
        private Button btn5;
        private Button btn2;
        private Button btn6;
        private Button btn3;
        private Button btnSub;
        private Button btnMult;
        private Button btnZero;
        private Button btnDot;
        private Button btnEqual;
        private Button btnDiv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitCalculatorToolStripMenuItem;
        private Button btnPI;
        private Button btnSine;
        private Button btnInverseSine;
        private Button btnTangent;
        private Button btnModulo;
        private Button btnLog;
        private Button btnCos;
        private Button btnInverseCos;
        private Button btnSqrt;
        private Button btnInverseTangent;
        private Button btnPercentage;
        private Button btnBinary;
        private Button btnDecimal;
        private Button btnExponential;
        private Button btnHexadecimal;
        private Button btnOcta;
        private Button btnInverseLog;
        private Button btnPower2;
        private Button btnPower3;
        private Button btnInverse;
    }
}
