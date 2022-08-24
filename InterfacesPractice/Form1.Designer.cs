namespace InterfacesPractice
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
            this.btnCreateAndSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAndSort
            // 
            this.btnCreateAndSort.Location = new System.Drawing.Point(40, 38);
            this.btnCreateAndSort.Name = "btnCreateAndSort";
            this.btnCreateAndSort.Size = new System.Drawing.Size(139, 73);
            this.btnCreateAndSort.TabIndex = 0;
            this.btnCreateAndSort.Text = "Create and Sort Candies";
            this.btnCreateAndSort.UseVisualStyleBackColor = true;
            this.btnCreateAndSort.Click += new System.EventHandler(this.btnCreateAndSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateAndSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateAndSort;
    }
}