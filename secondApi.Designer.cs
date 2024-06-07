namespace urlShortener
{
	partial class secondApi
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.copyShortUrl = new System.Windows.Forms.Button();
			this.clearBtn2 = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.shortenBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.shortUrl = new System.Windows.Forms.TextBox();
			this.customName = new System.Windows.Forms.TextBox();
			this.longUrlBox = new System.Windows.Forms.TextBox();
			this.nextPage = new System.Windows.Forms.Button();
			this.backPage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// copyShortUrl
			// 
			this.copyShortUrl.BackColor = System.Drawing.Color.LimeGreen;
			this.copyShortUrl.FlatAppearance.BorderSize = 0;
			this.copyShortUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyShortUrl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.copyShortUrl.Location = new System.Drawing.Point(121, 439);
			this.copyShortUrl.Name = "copyShortUrl";
			this.copyShortUrl.Size = new System.Drawing.Size(83, 32);
			this.copyShortUrl.TabIndex = 18;
			this.copyShortUrl.Text = "Copy";
			this.copyShortUrl.UseVisualStyleBackColor = false;
			// 
			// clearBtn2
			// 
			this.clearBtn2.BackColor = System.Drawing.Color.LimeGreen;
			this.clearBtn2.FlatAppearance.BorderSize = 0;
			this.clearBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearBtn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clearBtn2.Location = new System.Drawing.Point(559, 439);
			this.clearBtn2.Name = "clearBtn2";
			this.clearBtn2.Size = new System.Drawing.Size(83, 32);
			this.clearBtn2.TabIndex = 17;
			this.clearBtn2.Text = "Clear";
			this.clearBtn2.UseVisualStyleBackColor = false;
			// 
			// clear
			// 
			this.clear.BackColor = System.Drawing.Color.LimeGreen;
			this.clear.FlatAppearance.BorderSize = 0;
			this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clear.Location = new System.Drawing.Point(559, 303);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(83, 32);
			this.clear.TabIndex = 15;
			this.clear.Text = "Clear";
			this.clear.UseVisualStyleBackColor = false;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// shortenBtn
			// 
			this.shortenBtn.BackColor = System.Drawing.Color.LimeGreen;
			this.shortenBtn.FlatAppearance.BorderSize = 0;
			this.shortenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.shortenBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.shortenBtn.Location = new System.Drawing.Point(121, 303);
			this.shortenBtn.Name = "shortenBtn";
			this.shortenBtn.Size = new System.Drawing.Size(83, 32);
			this.shortenBtn.TabIndex = 16;
			this.shortenBtn.Text = "Shorten";
			this.shortenBtn.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(118, 355);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Shortened url";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.LightCyan;
			this.label11.Location = new System.Drawing.Point(255, 217);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 16);
			this.label11.TabIndex = 9;
			this.label11.Text = "(Optional)";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(118, 217);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Add a Custom name ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(78, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(350, 50);
			this.label5.TabIndex = 11;
			this.label5.Text = "A URL Shortening App";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(83, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(585, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "................................................................................." +
    "...............................................................\r\n";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(118, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Paste the url to be shortened";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(118, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Paste the url to be shortened";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// shortUrl
			// 
			this.shortUrl.BackColor = System.Drawing.Color.Honeydew;
			this.shortUrl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.shortUrl.Location = new System.Drawing.Point(121, 385);
			this.shortUrl.Name = "shortUrl";
			this.shortUrl.ReadOnly = true;
			this.shortUrl.Size = new System.Drawing.Size(521, 22);
			this.shortUrl.TabIndex = 5;
			// 
			// customName
			// 
			this.customName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.customName.Location = new System.Drawing.Point(121, 250);
			this.customName.Name = "customName";
			this.customName.Size = new System.Drawing.Size(521, 22);
			this.customName.TabIndex = 6;
			// 
			// longUrlBox
			// 
			this.longUrlBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.longUrlBox.Location = new System.Drawing.Point(121, 166);
			this.longUrlBox.Name = "longUrlBox";
			this.longUrlBox.Size = new System.Drawing.Size(521, 22);
			this.longUrlBox.TabIndex = 7;
			// 
			// nextPage
			// 
			this.nextPage.BackColor = System.Drawing.Color.LimeGreen;
			this.nextPage.FlatAppearance.BorderSize = 0;
			this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nextPage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.nextPage.Location = new System.Drawing.Point(559, 501);
			this.nextPage.Name = "nextPage";
			this.nextPage.Size = new System.Drawing.Size(83, 32);
			this.nextPage.TabIndex = 19;
			this.nextPage.Text = "Next --->";
			this.nextPage.UseVisualStyleBackColor = false;
			// 
			// backPage
			// 
			this.backPage.BackColor = System.Drawing.Color.LimeGreen;
			this.backPage.FlatAppearance.BorderSize = 0;
			this.backPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backPage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.backPage.Location = new System.Drawing.Point(121, 501);
			this.backPage.Name = "backPage";
			this.backPage.Size = new System.Drawing.Size(83, 32);
			this.backPage.TabIndex = 19;
			this.backPage.Text = "<---Back";
			this.backPage.UseVisualStyleBackColor = false;
			this.backPage.Click += new System.EventHandler(this.backPage_Click);
			// 
			// secondApi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.DarkGreen;
			this.Controls.Add(this.backPage);
			this.Controls.Add(this.nextPage);
			this.Controls.Add(this.copyShortUrl);
			this.Controls.Add(this.clearBtn2);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.shortenBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.shortUrl);
			this.Controls.Add(this.customName);
			this.Controls.Add(this.longUrlBox);
			this.Name = "secondApi";
			this.Size = new System.Drawing.Size(850, 597);
			this.Load += new System.EventHandler(this.secondApi_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.BindingSource bindingSource2;
		private System.Windows.Forms.Button copyShortUrl;
		private System.Windows.Forms.Button clearBtn2;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button shortenBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox shortUrl;
		private System.Windows.Forms.TextBox customName;
		private System.Windows.Forms.TextBox longUrlBox;
		private System.Windows.Forms.Button nextPage;
		private System.Windows.Forms.Button backPage;
	}
}
