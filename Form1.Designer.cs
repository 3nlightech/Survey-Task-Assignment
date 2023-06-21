
namespace Test_Assignment
{
    partial class frm_Home
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
            this.btn_Survey = new System.Windows.Forms.Button();
            this.Btn_Results = new System.Windows.Forms.Button();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Survey
            // 
            this.btn_Survey.Location = new System.Drawing.Point(308, 131);
            this.btn_Survey.Name = "btn_Survey";
            this.btn_Survey.Size = new System.Drawing.Size(116, 23);
            this.btn_Survey.TabIndex = 0;
            this.btn_Survey.Text = "Fill Out Survey";
            this.btn_Survey.UseVisualStyleBackColor = true;
            this.btn_Survey.Click += new System.EventHandler(this.btn_Survey_Click);
            // 
            // Btn_Results
            // 
            this.Btn_Results.Location = new System.Drawing.Point(308, 202);
            this.Btn_Results.Name = "Btn_Results";
            this.Btn_Results.Size = new System.Drawing.Size(116, 23);
            this.Btn_Results.TabIndex = 1;
            this.Btn_Results.Text = "View Survey Results";
            this.Btn_Results.UseVisualStyleBackColor = true;
            this.Btn_Results.Click += new System.EventHandler(this.Btn_Results_Click);
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(598, 28);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(100, 20);
            this.DisplayTextBox.TabIndex = 2;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.Btn_Results);
            this.Controls.Add(this.btn_Survey);
            this.Name = "frm_Home";
            this.Text = "Let\'s Begin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Survey;
        private System.Windows.Forms.Button Btn_Results;
        private System.Windows.Forms.TextBox DisplayTextBox;
    }
}

