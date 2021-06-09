
using Calculator.UI.Properties;

namespace Calculator.UI
{
    partial class Form
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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontStyle));
            this.kryptonListBox_Results = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonRichTBResults = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kButton_Multiply = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton9 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton8 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton7 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButtonCE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButtonC = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_Divide = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_Equal = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_Subtract = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton0 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonListBox_Results
            // 
            this.kryptonListBox_Results.Location = new System.Drawing.Point(12, 12);
            this.kryptonListBox_Results.Name = "kryptonListBox_Results";
            this.kryptonListBox_Results.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonListBox_Results.Size = new System.Drawing.Size(109, 236);
            this.kryptonListBox_Results.TabIndex = 0;
            // 
            // kryptonRichTBResults
            // 
            this.kryptonRichTBResults.Location = new System.Drawing.Point(127, 12);
            this.kryptonRichTBResults.MinimumSize = new System.Drawing.Size(5, 5);
            this.kryptonRichTBResults.Multiline = false;
            this.kryptonRichTBResults.Name = "kryptonRichTBResults";
            this.kryptonRichTBResults.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonRichTBResults.ReadOnly = true;
            this.kryptonRichTBResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonRichTBResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.kryptonRichTBResults.Size = new System.Drawing.Size(274, 38);
            this.kryptonRichTBResults.TabIndex = 1;
            this.kryptonRichTBResults.Text = "";
            this.kryptonRichTBResults.TextChanged += new System.EventHandler(this.kryptonRichTBResults_TextChanged);
            // 
            // kButton_Multiply
            // 
            this.kButton_Multiply.Location = new System.Drawing.Point(295, 54);
            this.kButton_Multiply.Name = "kButton_Multiply";
            this.kButton_Multiply.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton_Multiply.Size = new System.Drawing.Size(50, 44);
            this.kButton_Multiply.TabIndex = 2;
            this.kButton_Multiply.Values.Text = "*";
            this.kButton_Multiply.Click += new System.EventHandler(this.kButton_Multiply_Click);
            // 
            // kButton9
            // 
            this.kButton9.Location = new System.Drawing.Point(239, 54);
            this.kButton9.Name = "kButton9";
            this.kButton9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton9.Size = new System.Drawing.Size(50, 44);
            this.kButton9.TabIndex = 3;
            this.kButton9.Values.Text = "9";
            this.kButton9.Click += new System.EventHandler(this.kButton9_Click);
            // 
            // kButton8
            // 
            this.kButton8.Location = new System.Drawing.Point(183, 54);
            this.kButton8.Name = "kButton8";
            this.kButton8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton8.Size = new System.Drawing.Size(50, 44);
            this.kButton8.TabIndex = 4;
            this.kButton8.Values.Text = "8";
            this.kButton8.Click += new System.EventHandler(this.kButton8_Click);
            // 
            // kButton7
            // 
            this.kButton7.Location = new System.Drawing.Point(127, 54);
            this.kButton7.Name = "kButton7";
            this.kButton7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton7.Size = new System.Drawing.Size(50, 44);
            this.kButton7.TabIndex = 5;
            this.kButton7.Values.Text = "7";
            this.kButton7.Click += new System.EventHandler(this.kButton7_Click);
            // 
            // kButtonCE
            // 
            this.kButtonCE.Location = new System.Drawing.Point(351, 54);
            this.kButtonCE.Name = "kButtonCE";
            this.kButtonCE.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButtonCE.Size = new System.Drawing.Size(50, 44);
            this.kButtonCE.TabIndex = 6;
            this.kButtonCE.Values.Text = "CE";
            this.kButtonCE.Click += new System.EventHandler(this.kButtonCE_Click);
            // 
            // kButtonC
            // 
            this.kButtonC.Location = new System.Drawing.Point(351, 104);
            this.kButtonC.Name = "kButtonC";
            this.kButtonC.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButtonC.Size = new System.Drawing.Size(50, 44);
            this.kButtonC.TabIndex = 7;
            this.kButtonC.Values.Text = "C";
            // 
            // kButton_Divide
            // 
            this.kButton_Divide.Location = new System.Drawing.Point(295, 104);
            this.kButton_Divide.Name = "kButton_Divide";
            this.kButton_Divide.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton_Divide.Size = new System.Drawing.Size(50, 44);
            this.kButton_Divide.TabIndex = 8;
            this.kButton_Divide.Values.Text = "/";
            this.kButton_Divide.Click += new System.EventHandler(this.kButton_Divide_Click);
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.Location = new System.Drawing.Point(239, 104);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonButton6.Size = new System.Drawing.Size(50, 44);
            this.kryptonButton6.TabIndex = 9;
            this.kryptonButton6.Values.Text = "6";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // kButton5
            // 
            this.kButton5.Location = new System.Drawing.Point(183, 104);
            this.kButton5.Name = "kButton5";
            this.kButton5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton5.Size = new System.Drawing.Size(50, 44);
            this.kButton5.TabIndex = 10;
            this.kButton5.Values.Text = "5";
            this.kButton5.Click += new System.EventHandler(this.kButton5_Click);
            // 
            // kButton4
            // 
            this.kButton4.Location = new System.Drawing.Point(127, 104);
            this.kButton4.Name = "kButton4";
            this.kButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton4.Size = new System.Drawing.Size(50, 44);
            this.kButton4.TabIndex = 11;
            this.kButton4.Values.Text = "4";
            this.kButton4.Click += new System.EventHandler(this.kButton4_Click);
            // 
            // kButton_Equal
            // 
            this.kButton_Equal.Location = new System.Drawing.Point(351, 154);
            this.kButton_Equal.Name = "kButton_Equal";
            this.kButton_Equal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton_Equal.Size = new System.Drawing.Size(50, 94);
            this.kButton_Equal.TabIndex = 12;
            this.kButton_Equal.Values.Text = "=";
            this.kButton_Equal.Click += new System.EventHandler(this.kButton_Equal_Click);
            // 
            // kButton_Subtract
            // 
            this.kButton_Subtract.Location = new System.Drawing.Point(295, 154);
            this.kButton_Subtract.Name = "kButton_Subtract";
            this.kButton_Subtract.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton_Subtract.Size = new System.Drawing.Size(50, 44);
            this.kButton_Subtract.TabIndex = 13;
            this.kButton_Subtract.Values.Text = "-";
            this.kButton_Subtract.Click += new System.EventHandler(this.kButton_Subtract_Click);
            // 
            // kButton3
            // 
            this.kButton3.Location = new System.Drawing.Point(239, 154);
            this.kButton3.Name = "kButton3";
            this.kButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton3.Size = new System.Drawing.Size(50, 44);
            this.kButton3.TabIndex = 14;
            this.kButton3.Values.Text = "3";
            this.kButton3.Click += new System.EventHandler(this.kButton3_Click);
            // 
            // kButton2
            // 
            this.kButton2.Location = new System.Drawing.Point(183, 154);
            this.kButton2.Name = "kButton2";
            this.kButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton2.Size = new System.Drawing.Size(50, 44);
            this.kButton2.TabIndex = 15;
            this.kButton2.Values.Text = "2";
            this.kButton2.Click += new System.EventHandler(this.kButton2_Click);
            // 
            // kButton1
            // 
            this.kButton1.Location = new System.Drawing.Point(127, 154);
            this.kButton1.Name = "kButton1";
            this.kButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton1.Size = new System.Drawing.Size(50, 44);
            this.kButton1.TabIndex = 16;
            this.kButton1.Values.Text = "1";
            this.kButton1.Click += new System.EventHandler(this.kButton1_Click);
            // 
            // kButton_Add
            // 
            this.kButton_Add.Location = new System.Drawing.Point(295, 204);
            this.kButton_Add.Name = "kButton_Add";
            this.kButton_Add.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton_Add.Size = new System.Drawing.Size(50, 44);
            this.kButton_Add.TabIndex = 17;
            this.kButton_Add.Values.Text = "+";
            this.kButton_Add.Click += new System.EventHandler(this.kButton_Add_Click);
            // 
            // kButton0
            // 
            this.kButton0.Location = new System.Drawing.Point(127, 204);
            this.kButton0.Name = "kButton0";
            this.kButton0.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kButton0.Size = new System.Drawing.Size(162, 44);
            this.kButton0.TabIndex = 18;
            this.kButton0.Values.Text = "0";
            this.kButton0.Click += new System.EventHandler(this.kButton0_Click);
            // 
            // FontStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(413, 255);
            this.Controls.Add(this.kButton0);
            this.Controls.Add(this.kButton_Add);
            this.Controls.Add(this.kButton1);
            this.Controls.Add(this.kButton2);
            this.Controls.Add(this.kButton3);
            this.Controls.Add(this.kButton_Subtract);
            this.Controls.Add(this.kButton_Equal);
            this.Controls.Add(this.kButton4);
            this.Controls.Add(this.kButton5);
            this.Controls.Add(this.kryptonButton6);
            this.Controls.Add(this.kButton_Divide);
            this.Controls.Add(this.kButtonC);
            this.Controls.Add(this.kButtonCE);
            this.Controls.Add(this.kButton7);
            this.Controls.Add(this.kButton8);
            this.Controls.Add(this.kButton9);
            this.Controls.Add(this.kButton_Multiply);
            this.Controls.Add(this.kryptonRichTBResults);
            this.Controls.Add(this.kryptonListBox_Results);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
           // this.Icon = ((System.Drawing.Icon)(Resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FontStyle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonListBox kryptonListBox_Results;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTBResults;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_Multiply;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton8;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButtonCE;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButtonC;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_Divide;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_Equal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_Subtract;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton0;
    }
}

