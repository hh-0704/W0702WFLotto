namespace W0702WFLotto
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.num6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.Info;
            this.num1.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.num1.Location = new System.Drawing.Point(12, 9);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(142, 89);
            this.num1.TabIndex = 0;
            this.num1.Text = "Lucky";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Info;
            this.num2.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.num2.Location = new System.Drawing.Point(160, 9);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(142, 89);
            this.num2.TabIndex = 0;
            this.num2.Text = "Lucky";
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.Info;
            this.num3.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.num3.Location = new System.Drawing.Point(308, 9);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(142, 89);
            this.num3.TabIndex = 0;
            this.num3.Text = "Lucky";
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.Info;
            this.num4.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.num4.Location = new System.Drawing.Point(456, 9);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(142, 89);
            this.num4.TabIndex = 0;
            this.num4.Text = "Lucky";
            this.num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.Info;
            this.num5.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.num5.Location = new System.Drawing.Point(604, 9);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(142, 89);
            this.num5.TabIndex = 0;
            this.num5.Text = "Lucky";
            this.num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.Info;
            this.num6.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.num6.Location = new System.Drawing.Point(752, 9);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(142, 89);
            this.num6.TabIndex = 0;
            this.num6.Text = "Lucky";
            this.num6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(12, 163);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(873, 81);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "번호생성";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.OnGeneration);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 277);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label num1;
        private Label num2;
        private Label num3;
        private Label num4;
        private Label num5;
        private Label num6;
        private Button btnGenerate;
    }
}