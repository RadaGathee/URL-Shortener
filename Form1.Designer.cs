namespace urlShortener
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.longUrl = new System.Windows.Forms.TextBox();
			this.customName = new System.Windows.Forms.TextBox();
			this.shortUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.shortenBtn = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.clearBtn2 = new System.Windows.Forms.Button();
			this.copyShortUrl = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// longUrl
			// 
			this.longUrl.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.longUrl.Location = new System.Drawing.Point(233, 168);
			this.longUrl.Name = "longUrl";
			this.longUrl.Size = new System.Drawing.Size(521, 22);
			this.longUrl.TabIndex = 0;
			this.longUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// customName
			// 
			this.customName.ForeColor = System.Drawing.Color.DarkOrange;
			this.customName.Location = new System.Drawing.Point(233, 252);
			this.customName.Name = "customName";
			this.customName.Size = new System.Drawing.Size(521, 22);
			this.customName.TabIndex = 0;
			// 
			// shortUrl
			// 
			this.shortUrl.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.shortUrl.Location = new System.Drawing.Point(233, 387);
			this.shortUrl.Name = "shortUrl";
			this.shortUrl.Size = new System.Drawing.Size(521, 22);
			this.shortUrl.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.DarkGreen;
			this.label1.Location = new System.Drawing.Point(230, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Paste the url to be shortened";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.DarkGreen;
			this.label2.Location = new System.Drawing.Point(230, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Add a Custom name (Optional)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// shortenBtn
			// 
			this.shortenBtn.BackColor = System.Drawing.Color.LimeGreen;
			this.shortenBtn.FlatAppearance.BorderSize = 0;
			this.shortenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.shortenBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.shortenBtn.Location = new System.Drawing.Point(233, 305);
			this.shortenBtn.Name = "shortenBtn";
			this.shortenBtn.Size = new System.Drawing.Size(83, 32);
			this.shortenBtn.TabIndex = 2;
			this.shortenBtn.Text = "Shorten";
			this.shortenBtn.UseVisualStyleBackColor = false;
			this.shortenBtn.Click += new System.EventHandler(this.shortenBtn_Click);
			// 
			// clear
			// 
			this.clear.BackColor = System.Drawing.Color.LimeGreen;
			this.clear.FlatAppearance.BorderSize = 0;
			this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clear.Location = new System.Drawing.Point(671, 305);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(83, 32);
			this.clear.TabIndex = 2;
			this.clear.Text = "Clear";
			this.clear.UseVisualStyleBackColor = false;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.DarkGreen;
			this.label3.Location = new System.Drawing.Point(230, 357);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Shortened url";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// clearBtn2
			// 
			this.clearBtn2.BackColor = System.Drawing.Color.LimeGreen;
			this.clearBtn2.FlatAppearance.BorderSize = 0;
			this.clearBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearBtn2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.clearBtn2.Location = new System.Drawing.Point(671, 441);
			this.clearBtn2.Name = "clearBtn2";
			this.clearBtn2.Size = new System.Drawing.Size(83, 32);
			this.clearBtn2.TabIndex = 3;
			this.clearBtn2.Text = "Clear";
			this.clearBtn2.UseVisualStyleBackColor = false;
			this.clearBtn2.Click += new System.EventHandler(this.clearBtn2_Click);
			// 
			// copyShortUrl
			// 
			this.copyShortUrl.BackColor = System.Drawing.Color.LimeGreen;
			this.copyShortUrl.FlatAppearance.BorderSize = 0;
			this.copyShortUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyShortUrl.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.copyShortUrl.Location = new System.Drawing.Point(233, 441);
			this.copyShortUrl.Name = "copyShortUrl";
			this.copyShortUrl.Size = new System.Drawing.Size(83, 32);
			this.copyShortUrl.TabIndex = 4;
			this.copyShortUrl.Text = "Copy";
			this.copyShortUrl.UseVisualStyleBackColor = false;
			this.copyShortUrl.Click += new System.EventHandler(this.copyShortUrl_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGreen;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(142, 586);
			this.panel1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.DarkGreen;
			this.label4.Location = new System.Drawing.Point(230, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Paste the url to be shortened";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkGreen;
			this.label5.Location = new System.Drawing.Point(190, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(350, 50);
			this.label5.TabIndex = 1;
			this.label5.Text = "A URL Shortening App";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkGreen;
			this.label6.Location = new System.Drawing.Point(195, 81);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(585, 20);
			this.label6.TabIndex = 1;
			this.label6.Text = "................................................................................." +
    "...............................................................\r\n";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label7.Location = new System.Drawing.Point(64, 489);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 50);
			this.label7.TabIndex = 6;
			this.label7.Text = "u R L";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label8.Location = new System.Drawing.Point(-26, 539);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 84);
			this.label8.TabIndex = 6;
			this.label8.Text = "u R L";
			this.label8.Click += new System.EventHandler(this.label7_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label9.Location = new System.Drawing.Point(-78, 419);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(165, 84);
			this.label9.TabIndex = 6;
			this.label9.Text = "u R L";
			this.label9.Click += new System.EventHandler(this.label7_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold);
			this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label10.Location = new System.Drawing.Point(-73, 489);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 50);
			this.label10.TabIndex = 6;
			this.label10.Text = "u R L";
			this.label10.Click += new System.EventHandler(this.label7_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(975, 586);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.copyShortUrl);
			this.Controls.Add(this.clearBtn2);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.shortenBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.shortUrl);
			this.Controls.Add(this.customName);
			this.Controls.Add(this.longUrl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(758, 515);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "URL Shortener ";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox longUrl;
		private System.Windows.Forms.TextBox customName;
		private System.Windows.Forms.TextBox shortUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button shortenBtn;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button clearBtn2;
		private System.Windows.Forms.Button copyShortUrl;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
	}
}

