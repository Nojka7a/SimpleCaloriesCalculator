namespace MyCaloriesCalculator
{
    partial class calculatorForm
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
            this.lblKg = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblFats = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblProteinResult = new System.Windows.Forms.Label();
            this.lblFatsResult = new System.Windows.Forms.Label();
            this.lblCarbsResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHeightInCM = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblTotalCaloriesResult = new System.Windows.Forms.Label();
            this.lblProteinResultInCalories = new System.Windows.Forms.Label();
            this.lblFatsResultInCalories = new System.Windows.Forms.Label();
            this.lblCarbsResultInCalories = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBRMResult = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.rbCleanBulk = new System.Windows.Forms.RadioButton();
            this.rbCutting = new System.Windows.Forms.RadioButton();
            this.rbMaintenance = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.gbProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(50, 47);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(24, 17);
            this.lblKg.TabIndex = 27;
            this.lblKg.Text = "Kg";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(139, 43);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(72, 25);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.Text = "0";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtein.Location = new System.Drawing.Point(319, 47);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(61, 17);
            this.lblProtein.TabIndex = 26;
            this.lblProtein.Text = "Protein :";
            // 
            // lblFats
            // 
            this.lblFats.AutoSize = true;
            this.lblFats.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFats.Location = new System.Drawing.Point(319, 102);
            this.lblFats.Name = "lblFats";
            this.lblFats.Size = new System.Drawing.Size(41, 17);
            this.lblFats.TabIndex = 25;
            this.lblFats.Text = "Fats :";
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbs.Location = new System.Drawing.Point(319, 161);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(50, 17);
            this.lblCarbs.TabIndex = 24;
            this.lblCarbs.Text = "Carbs :";
            // 
            // lblProteinResult
            // 
            this.lblProteinResult.AutoSize = true;
            this.lblProteinResult.Location = new System.Drawing.Point(439, 50);
            this.lblProteinResult.Name = "lblProteinResult";
            this.lblProteinResult.Size = new System.Drawing.Size(11, 17);
            this.lblProteinResult.TabIndex = 23;
            this.lblProteinResult.Text = ".";
            // 
            // lblFatsResult
            // 
            this.lblFatsResult.AutoSize = true;
            this.lblFatsResult.Location = new System.Drawing.Point(439, 104);
            this.lblFatsResult.Name = "lblFatsResult";
            this.lblFatsResult.Size = new System.Drawing.Size(11, 17);
            this.lblFatsResult.TabIndex = 22;
            this.lblFatsResult.Text = ".";
            // 
            // lblCarbsResult
            // 
            this.lblCarbsResult.AutoSize = true;
            this.lblCarbsResult.Location = new System.Drawing.Point(439, 163);
            this.lblCarbsResult.Name = "lblCarbsResult";
            this.lblCarbsResult.Size = new System.Drawing.Size(11, 17);
            this.lblCarbsResult.TabIndex = 21;
            this.lblCarbsResult.Text = ".";
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoEllipsis = true;
            this.btnCalculate.Location = new System.Drawing.Point(268, 457);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 43);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHeightInCM
            // 
            this.lblHeightInCM.AutoSize = true;
            this.lblHeightInCM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightInCM.Location = new System.Drawing.Point(50, 105);
            this.lblHeightInCM.Name = "lblHeightInCM";
            this.lblHeightInCM.Size = new System.Drawing.Size(28, 17);
            this.lblHeightInCM.TabIndex = 20;
            this.lblHeightInCM.Text = "Cm";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(139, 101);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(72, 25);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.Text = "182";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(139, 160);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(72, 25);
            this.txtAge.TabIndex = 3;
            this.txtAge.Text = "24";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(50, 163);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 17);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "Age";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalories.Location = new System.Drawing.Point(319, 225);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(100, 17);
            this.lblTotalCalories.TabIndex = 15;
            this.lblTotalCalories.Text = "Total Calories :";
            // 
            // lblTotalCaloriesResult
            // 
            this.lblTotalCaloriesResult.AutoSize = true;
            this.lblTotalCaloriesResult.Location = new System.Drawing.Point(439, 227);
            this.lblTotalCaloriesResult.Name = "lblTotalCaloriesResult";
            this.lblTotalCaloriesResult.Size = new System.Drawing.Size(11, 17);
            this.lblTotalCaloriesResult.TabIndex = 16;
            this.lblTotalCaloriesResult.Text = ".";
            // 
            // lblProteinResultInCalories
            // 
            this.lblProteinResultInCalories.AutoSize = true;
            this.lblProteinResultInCalories.Location = new System.Drawing.Point(531, 51);
            this.lblProteinResultInCalories.Name = "lblProteinResultInCalories";
            this.lblProteinResultInCalories.Size = new System.Drawing.Size(11, 17);
            this.lblProteinResultInCalories.TabIndex = 17;
            this.lblProteinResultInCalories.Text = ".";
            // 
            // lblFatsResultInCalories
            // 
            this.lblFatsResultInCalories.AutoSize = true;
            this.lblFatsResultInCalories.Location = new System.Drawing.Point(531, 109);
            this.lblFatsResultInCalories.Name = "lblFatsResultInCalories";
            this.lblFatsResultInCalories.Size = new System.Drawing.Size(11, 17);
            this.lblFatsResultInCalories.TabIndex = 18;
            this.lblFatsResultInCalories.Text = ".";
            // 
            // lblCarbsResultInCalories
            // 
            this.lblCarbsResultInCalories.AutoSize = true;
            this.lblCarbsResultInCalories.Location = new System.Drawing.Point(531, 168);
            this.lblCarbsResultInCalories.Name = "lblCarbsResultInCalories";
            this.lblCarbsResultInCalories.Size = new System.Drawing.Size(11, 17);
            this.lblCarbsResultInCalories.TabIndex = 19;
            this.lblCarbsResultInCalories.Text = ".";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(3, 18);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(55, 21);
            this.rbMale.TabIndex = 28;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(86, 18);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(67, 21);
            this.rbFemale.TabIndex = 29;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Location = new System.Drawing.Point(53, 203);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 70);
            this.panel1.TabIndex = 30;
            // 
            // lblBRMResult
            // 
            this.lblBRMResult.AutoSize = true;
            this.lblBRMResult.Location = new System.Drawing.Point(531, 225);
            this.lblBRMResult.Name = "lblBRMResult";
            this.lblBRMResult.Size = new System.Drawing.Size(11, 17);
            this.lblBRMResult.TabIndex = 31;
            this.lblBRMResult.Text = ".";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(322, 193);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(278, 17);
            this.lblSeparator.TabIndex = 34;
            this.lblSeparator.Text = "------------------------------------------------------";
            // 
            // gbProgram
            // 
            this.gbProgram.Controls.Add(this.rbMaintenance);
            this.gbProgram.Controls.Add(this.rbCutting);
            this.gbProgram.Controls.Add(this.rbCleanBulk);
            this.gbProgram.Location = new System.Drawing.Point(56, 292);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(158, 145);
            this.gbProgram.TabIndex = 37;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Program :";
            this.gbProgram.Enter += new System.EventHandler(this.gbProgram_Enter);
            // 
            // rbCleanBulk
            // 
            this.rbCleanBulk.AutoSize = true;
            this.rbCleanBulk.Location = new System.Drawing.Point(3, 106);
            this.rbCleanBulk.Name = "rbCleanBulk";
            this.rbCleanBulk.Size = new System.Drawing.Size(85, 21);
            this.rbCleanBulk.TabIndex = 0;
            this.rbCleanBulk.Text = "Clean Bulk";
            this.rbCleanBulk.UseVisualStyleBackColor = true;
            // 
            // rbCutting
            // 
            this.rbCutting.AutoSize = true;
            this.rbCutting.Location = new System.Drawing.Point(3, 63);
            this.rbCutting.Name = "rbCutting";
            this.rbCutting.Size = new System.Drawing.Size(67, 21);
            this.rbCutting.TabIndex = 1;
            this.rbCutting.Text = "Cutting";
            this.rbCutting.UseVisualStyleBackColor = true;
            // 
            // rbMaintenance
            // 
            this.rbMaintenance.AutoSize = true;
            this.rbMaintenance.Checked = true;
            this.rbMaintenance.Location = new System.Drawing.Point(3, 24);
            this.rbMaintenance.Name = "rbMaintenance";
            this.rbMaintenance.Size = new System.Drawing.Size(100, 21);
            this.rbMaintenance.TabIndex = 2;
            this.rbMaintenance.TabStop = true;
            this.rbMaintenance.Text = "Maintenance";
            this.rbMaintenance.UseVisualStyleBackColor = true;
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(643, 534);
            this.Controls.Add(this.gbProgram);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.lblBRMResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCarbsResultInCalories);
            this.Controls.Add(this.lblFatsResultInCalories);
            this.Controls.Add(this.lblProteinResultInCalories);
            this.Controls.Add(this.lblTotalCaloriesResult);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeightInCM);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCarbsResult);
            this.Controls.Add(this.lblFatsResult);
            this.Controls.Add(this.lblProteinResult);
            this.Controls.Add(this.lblCarbs);
            this.Controls.Add(this.lblFats);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblKg);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "calculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calories Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbProgram.ResumeLayout(false);
            this.gbProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblFats;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblProteinResult;
        private System.Windows.Forms.Label lblFatsResult;
        private System.Windows.Forms.Label lblCarbsResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHeightInCM;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblTotalCaloriesResult;
        private System.Windows.Forms.Label lblProteinResultInCalories;
        private System.Windows.Forms.Label lblFatsResultInCalories;
        private System.Windows.Forms.Label lblCarbsResultInCalories;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBRMResult;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.RadioButton rbMaintenance;
        private System.Windows.Forms.RadioButton rbCutting;
        private System.Windows.Forms.RadioButton rbCleanBulk;
    }
}

