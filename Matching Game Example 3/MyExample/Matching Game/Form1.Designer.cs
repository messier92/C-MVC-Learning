namespace Matching_Game
{
    partial class UserProfile
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
            this.submitButton = new System.Windows.Forms.Button();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.labelUP = new System.Windows.Forms.Label();
            this.labelSalute = new System.Windows.Forms.Label();
            this.salutationCB = new System.Windows.Forms.ComboBox();
            this.labelFN = new System.Windows.Forms.Label();
            this.firstNameError = new System.Windows.Forms.Label();
            this.lastNameError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.emailError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.salutationError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(520, 319);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(148, 61);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNameTB
            // 
            this.firstNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTB.Location = new System.Drawing.Point(337, 137);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(121, 22);
            this.firstNameTB.TabIndex = 1;
            // 
            // labelUP
            // 
            this.labelUP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUP.AutoSize = true;
            this.labelUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUP.Location = new System.Drawing.Point(336, 36);
            this.labelUP.Name = "labelUP";
            this.labelUP.Size = new System.Drawing.Size(124, 25);
            this.labelUP.TabIndex = 2;
            this.labelUP.Text = "User Profile";
            // 
            // labelSalute
            // 
            this.labelSalute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalute.AutoSize = true;
            this.labelSalute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalute.Location = new System.Drawing.Point(193, 97);
            this.labelSalute.Name = "labelSalute";
            this.labelSalute.Size = new System.Drawing.Size(99, 20);
            this.labelSalute.TabIndex = 4;
            this.labelSalute.Text = "Salutation:";
            // 
            // salutationCB
            // 
            this.salutationCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salutationCB.FormattingEnabled = true;
            this.salutationCB.Items.AddRange(new object[] {
            "",
            "Mr.",
            "Ms.",
            "Mdm.",
            "Dr."});
            this.salutationCB.Location = new System.Drawing.Point(337, 97);
            this.salutationCB.Name = "salutationCB";
            this.salutationCB.Size = new System.Drawing.Size(121, 24);
            this.salutationCB.TabIndex = 5;
            // 
            // labelFN
            // 
            this.labelFN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.Location = new System.Drawing.Point(184, 137);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(108, 20);
            this.labelFN.TabIndex = 6;
            this.labelFN.Text = "First Name:";
            // 
            // firstNameError
            // 
            this.firstNameError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameError.AutoSize = true;
            this.firstNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameError.Location = new System.Drawing.Point(477, 139);
            this.firstNameError.Name = "firstNameError";
            this.firstNameError.Size = new System.Drawing.Size(0, 20);
            this.firstNameError.TabIndex = 7;
            // 
            // lastNameError
            // 
            this.lastNameError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameError.AutoSize = true;
            this.lastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameError.Location = new System.Drawing.Point(477, 181);
            this.lastNameError.Name = "lastNameError";
            this.lastNameError.Size = new System.Drawing.Size(0, 20);
            this.lastNameError.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTB.Location = new System.Drawing.Point(337, 179);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(121, 22);
            this.lastNameTB.TabIndex = 8;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(129, 319);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(148, 61);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // emailError
            // 
            this.emailError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailError.AutoSize = true;
            this.emailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailError.Location = new System.Drawing.Point(477, 220);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(0, 20);
            this.emailError.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-mail:";
            // 
            // emailTB
            // 
            this.emailTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTB.Location = new System.Drawing.Point(337, 218);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(121, 22);
            this.emailTB.TabIndex = 12;
            // 
            // salutationError
            // 
            this.salutationError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salutationError.AutoSize = true;
            this.salutationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salutationError.Location = new System.Drawing.Point(477, 101);
            this.salutationError.Name = "salutationError";
            this.salutationError.Size = new System.Drawing.Size(0, 20);
            this.salutationError.TabIndex = 15;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salutationError);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.lastNameError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameError);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.salutationCB);
            this.Controls.Add(this.labelSalute);
            this.Controls.Add(this.labelUP);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.submitButton);
            this.Name = "UserProfile";
            this.Text = "User Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label labelUP;
        private System.Windows.Forms.Label labelSalute;
        private System.Windows.Forms.ComboBox salutationCB;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label firstNameError;
        private System.Windows.Forms.Label lastNameError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label salutationError;
    }
}

