namespace String_comparer
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbxStringX = new System.Windows.Forms.TextBox();
            this.tbxStringY = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(37, 447);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(197, 77);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // tbxStringX
            // 
            this.tbxStringX.Location = new System.Drawing.Point(37, 184);
            this.tbxStringX.Multiline = true;
            this.tbxStringX.Name = "tbxStringX";
            this.tbxStringX.Size = new System.Drawing.Size(238, 40);
            this.tbxStringX.TabIndex = 1;
            this.tbxStringX.TextChanged += new System.EventHandler(this.tbxStringX_TextChanged);
            // 
            // tbxStringY
            // 
            this.tbxStringY.Location = new System.Drawing.Point(37, 284);
            this.tbxStringY.Multiline = true;
            this.tbxStringY.Name = "tbxStringY";
            this.tbxStringY.Size = new System.Drawing.Size(238, 59);
            this.tbxStringY.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(1011, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(116, 39);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(97, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(538, 55);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "String overlap calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 751);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbxStringY);
            this.Controls.Add(this.tbxStringX);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "String Comparer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbxStringX;
        private System.Windows.Forms.TextBox tbxStringY;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTitle;
    }
}

