namespace TimeCounter
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Time = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("新細明體", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Time.Location = new System.Drawing.Point(125, 135);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(181, 67);
            this.Time.TabIndex = 0;
            this.Time.Text = "label1";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Save.Location = new System.Drawing.Point(119, 299);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(187, 74);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load_Btn
            // 
            this.Load_Btn.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Load_Btn.Location = new System.Drawing.Point(441, 299);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(187, 74);
            this.Load_Btn.TabIndex = 2;
            this.Load_Btn.Text = "Load";
            this.Load_Btn.UseVisualStyleBackColor = true;
            this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
            // 
            // Load
            // 
            this.Load.AutoSize = true;
            this.Load.Font = new System.Drawing.Font("新細明體", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Load.Location = new System.Drawing.Point(447, 135);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(157, 67);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load_Btn;
        private System.Windows.Forms.Label Load;
    }
}

