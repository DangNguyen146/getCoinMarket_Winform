namespace HTTPWEBREQUEST
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
            this.lb_bitcoin = new System.Windows.Forms.Label();
            this.lb_ethereum = new System.Windows.Forms.Label();
            this.lb_tether = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_bitcoin = new System.Windows.Forms.TextBox();
            this.tb_eere = new System.Windows.Forms.TextBox();
            this.tb_tt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lb_bitcoin
            // 
            this.lb_bitcoin.AutoSize = true;
            this.lb_bitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bitcoin.Location = new System.Drawing.Point(66, 66);
            this.lb_bitcoin.Name = "lb_bitcoin";
            this.lb_bitcoin.Size = new System.Drawing.Size(48, 16);
            this.lb_bitcoin.TabIndex = 0;
            this.lb_bitcoin.Text = "Bitcoin";
            // 
            // lb_ethereum
            // 
            this.lb_ethereum.AutoSize = true;
            this.lb_ethereum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ethereum.Location = new System.Drawing.Point(66, 114);
            this.lb_ethereum.Name = "lb_ethereum";
            this.lb_ethereum.Size = new System.Drawing.Size(65, 16);
            this.lb_ethereum.TabIndex = 1;
            this.lb_ethereum.Text = "Ethereum";
            // 
            // lb_tether
            // 
            this.lb_tether.AutoSize = true;
            this.lb_tether.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tether.Location = new System.Drawing.Point(66, 162);
            this.lb_tether.Name = "lb_tether";
            this.lb_tether.Size = new System.Drawing.Size(47, 16);
            this.lb_tether.TabIndex = 2;
            this.lb_tether.Text = "Tether";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(105, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đồng tiền điện tử";
            // 
            // tb_bitcoin
            // 
            this.tb_bitcoin.Location = new System.Drawing.Point(157, 66);
            this.tb_bitcoin.Name = "tb_bitcoin";
            this.tb_bitcoin.Size = new System.Drawing.Size(150, 20);
            this.tb_bitcoin.TabIndex = 4;
            // 
            // tb_eere
            // 
            this.tb_eere.Location = new System.Drawing.Point(157, 112);
            this.tb_eere.Name = "tb_eere";
            this.tb_eere.Size = new System.Drawing.Size(150, 20);
            this.tb_eere.TabIndex = 5;
            // 
            // tb_tt
            // 
            this.tb_tt.Location = new System.Drawing.Point(157, 158);
            this.tb_tt.Name = "tb_tt";
            this.tb_tt.Size = new System.Drawing.Size(150, 20);
            this.tb_tt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(116, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Auto refresh in";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_time.Location = new System.Drawing.Point(226, 265);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(27, 20);
            this.lb_time.TabIndex = 9;
            this.lb_time.Text = "30";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(357, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 154);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 304);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_tt);
            this.Controls.Add(this.tb_eere);
            this.Controls.Add(this.tb_bitcoin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_tether);
            this.Controls.Add(this.lb_ethereum);
            this.Controls.Add(this.lb_bitcoin);
            this.Name = "Form1";
            this.Text = "Get coin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_bitcoin;
        private System.Windows.Forms.Label lb_ethereum;
        private System.Windows.Forms.Label lb_tether;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_bitcoin;
        private System.Windows.Forms.TextBox tb_eere;
        private System.Windows.Forms.TextBox tb_tt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

