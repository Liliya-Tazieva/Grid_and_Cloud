namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtunSub = new System.Windows.Forms.Button();
            this.ButtonMul = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.ButtonMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(33, 136);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(33, 10);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(33, 57);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            this.txtB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(56, 99);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(191, 20);
            this.txtRes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // ButtunSub
            // 
            this.ButtunSub.Location = new System.Drawing.Point(152, 136);
            this.ButtunSub.Name = "ButtunSub";
            this.ButtunSub.Size = new System.Drawing.Size(75, 23);
            this.ButtunSub.TabIndex = 7;
            this.ButtunSub.Text = "-";
            this.ButtunSub.UseVisualStyleBackColor = true;
            this.ButtunSub.Click += new System.EventHandler(this.ButtunSub_Click);
            // 
            // ButtonMul
            // 
            this.ButtonMul.Location = new System.Drawing.Point(33, 174);
            this.ButtonMul.Name = "ButtonMul";
            this.ButtonMul.Size = new System.Drawing.Size(75, 23);
            this.ButtonMul.TabIndex = 8;
            this.ButtonMul.Text = "*";
            this.ButtonMul.UseVisualStyleBackColor = true;
            this.ButtonMul.Click += new System.EventHandler(this.ButtonMul_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Location = new System.Drawing.Point(152, 174);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(75, 23);
            this.ButtonDiv.TabIndex = 9;
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // ButtonMsg
            // 
            this.ButtonMsg.Location = new System.Drawing.Point(74, 203);
            this.ButtonMsg.Name = "ButtonMsg";
            this.ButtonMsg.Size = new System.Drawing.Size(119, 23);
            this.ButtonMsg.TabIndex = 10;
            this.ButtonMsg.Text = "Message";
            this.ButtonMsg.UseVisualStyleBackColor = true;
            this.ButtonMsg.Click += new System.EventHandler(this.ButtonMsg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 235);
            this.Controls.Add(this.ButtonMsg);
            this.Controls.Add(this.ButtonDiv);
            this.Controls.Add(this.ButtonMul);
            this.Controls.Add(this.ButtunSub);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAdd);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtunSub;
        private System.Windows.Forms.Button ButtonMul;
        private System.Windows.Forms.Button ButtonDiv;
        private System.Windows.Forms.Button ButtonMsg;
    }
}

