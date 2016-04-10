namespace XN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Caculate = new System.Windows.Forms.Button();
            this.nTo = new System.Windows.Forms.TextBox();
            this.nFrom = new System.Windows.Forms.TextBox();
            this.nJump = new System.Windows.Forms.TextBox();
            this.xJump = new System.Windows.Forms.TextBox();
            this.xTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Result = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Caculate);
            this.groupBox1.Controls.Add(this.nTo);
            this.groupBox1.Controls.Add(this.nFrom);
            this.groupBox1.Controls.Add(this.nJump);
            this.groupBox1.Controls.Add(this.xJump);
            this.groupBox1.Controls.Add(this.xTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.xFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // Caculate
            // 
            this.Caculate.Location = new System.Drawing.Point(204, 71);
            this.Caculate.Name = "Caculate";
            this.Caculate.Size = new System.Drawing.Size(75, 23);
            this.Caculate.TabIndex = 7;
            this.Caculate.Text = "Caculate";
            this.Caculate.UseVisualStyleBackColor = true;
            this.Caculate.Click += new System.EventHandler(this.Caculate_Click);
            // 
            // nTo
            // 
            this.nTo.Location = new System.Drawing.Point(285, 51);
            this.nTo.Name = "nTo";
            this.nTo.Size = new System.Drawing.Size(100, 20);
            this.nTo.TabIndex = 5;
            // 
            // nFrom
            // 
            this.nFrom.Location = new System.Drawing.Point(101, 51);
            this.nFrom.Name = "nFrom";
            this.nFrom.Size = new System.Drawing.Size(100, 20);
            this.nFrom.TabIndex = 4;
            // 
            // nJump
            // 
            this.nJump.Location = new System.Drawing.Point(480, 51);
            this.nJump.Name = "nJump";
            this.nJump.Size = new System.Drawing.Size(100, 20);
            this.nJump.TabIndex = 6;
            this.nJump.Text = "1";
            // 
            // xJump
            // 
            this.xJump.Location = new System.Drawing.Point(480, 25);
            this.xJump.Name = "xJump";
            this.xJump.Size = new System.Drawing.Size(100, 20);
            this.xJump.TabIndex = 3;
            this.xJump.Text = "0.1";
            // 
            // xTo
            // 
            this.xTo.Location = new System.Drawing.Point(285, 25);
            this.xTo.Name = "xTo";
            this.xTo.Size = new System.Drawing.Size(100, 20);
            this.xTo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "đến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tăng theo:";
            // 
            // xFrom
            // 
            this.xFrom.Location = new System.Drawing.Point(101, 25);
            this.xFrom.Name = "xFrom";
            this.xFrom.Size = new System.Drawing.Size(100, 20);
            this.xFrom.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tăng theo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá trị N từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá trị X từ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Result);
            this.groupBox2.Location = new System.Drawing.Point(17, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // Result
            // 
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Location = new System.Drawing.Point(6, 19);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(729, 141);
            this.Result.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Khao sat X*N";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nTo;
        private System.Windows.Forms.TextBox nFrom;
        private System.Windows.Forms.TextBox xTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.Button Caculate;
        private System.Windows.Forms.TextBox nJump;
        private System.Windows.Forms.TextBox xJump;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;

    }
}

