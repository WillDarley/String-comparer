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
            this.lblResultStringX = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TbxResultStringY = new System.Windows.Forms.Label();
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
            // lblResultStringX
            // 
            this.lblResultStringX.AutoSize = true;
            this.lblResultStringX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultStringX.Location = new System.Drawing.Point(442, 195);
            this.lblResultStringX.Name = "lblResultStringX";
            this.lblResultStringX.Size = new System.Drawing.Size(81, 29);
            this.lblResultStringX.TabIndex = 4;
            this.lblResultStringX.Text = "Result";
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
            // TbxResultStringY
            // 
            this.TbxResultStringY.AutoSize = true;
            this.TbxResultStringY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxResultStringY.Location = new System.Drawing.Point(444, 305);
            this.TbxResultStringY.Name = "TbxResultStringY";
            this.TbxResultStringY.Size = new System.Drawing.Size(81, 29);
            this.TbxResultStringY.TabIndex = 6;
            this.TbxResultStringY.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 751);
            this.Controls.Add(this.TbxResultStringY);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblResultStringX);
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
        private System.Windows.Forms.Label lblResultStringX;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label TbxResultStringY;
    }
}

