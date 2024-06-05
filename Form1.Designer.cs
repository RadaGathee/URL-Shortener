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
			this.SuspendLayout();
			// 
			// longUrl
			// 
			this.longUrl.Location = new System.Drawing.Point(233, 168);
			this.longUrl.Name = "longUrl";
			this.longUrl.Size = new System.Drawing.Size(521, 22);
			this.longUrl.TabIndex = 0;
			this.longUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// customName
			// 
			this.customName.Location = new System.Drawing.Point(233, 252);
			this.customName.Name = "customName";
			this.customName.Size = new System.Drawing.Size(521, 22);
			this.customName.TabIndex = 0;
			// 
			// shortUrl
			// 
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(975, 586);
			this.Controls.Add(this.copyShortUrl);
			this.Controls.Add(this.clearBtn2);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.shortenBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.shortUrl);
			this.Controls.Add(this.customName);
			this.Controls.Add(this.longUrl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(758, 515);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "URL Shortener ";
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
	}
}

