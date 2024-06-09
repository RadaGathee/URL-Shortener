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
			this.passwordValue = new System.Windows.Forms.TextBox();
			this.longUrlBox = new System.Windows.Forms.TextBox();
			this.nextPage = new System.Windows.Forms.Button();
			this.backPage = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.ClearTwo = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
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
			this.copyShortUrl.Location = new System.Drawing.Point(91, 441);
			this.copyShortUrl.Name = "copyShortUrl";
			this.copyShortUrl.Size = new System.Drawing.Size(83, 32);
			this.copyShortUrl.TabIndex = 18;
			this.copyShortUrl.Text = "Copy";
			this.copyShortUrl.UseVisualStyleBackColor = false;
			this.copyShortUrl.Click += new System.EventHandler(this.copyShortUrl_Click_1);
			// 
			// clear
			// 
			this.clear.BackColor = System.Drawing.Color.LimeGreen;
			this.clear.FlatAppearance.BorderSize = 0;
			this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clear.Location = new System.Drawing.Point(529, 305);
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
			this.shortenBtn.Location = new System.Drawing.Point(91, 305);
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
			this.label3.Location = new System.Drawing.Point(88, 357);
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
			this.label11.Location = new System.Drawing.Point(278, 219);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(251, 16);
			this.label11.TabIndex = 9;
			this.label11.Text = "(Min 8 characters, have @, number, letter)";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(91, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Add a Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(48, 31);
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
			this.label6.Location = new System.Drawing.Point(53, 81);
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
			this.label4.Location = new System.Drawing.Point(91, 133);
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
			this.label1.Location = new System.Drawing.Point(90, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Paste the url to be shortened";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// shortUrl
			// 
			this.shortUrl.BackColor = System.Drawing.Color.Honeydew;
			this.shortUrl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.shortUrl.Location = new System.Drawing.Point(91, 387);
			this.shortUrl.Name = "shortUrl";
			this.shortUrl.ReadOnly = true;
			this.shortUrl.Size = new System.Drawing.Size(521, 22);
			this.shortUrl.TabIndex = 5;
			// 
			// passwordValue
			// 
			this.passwordValue.ForeColor = System.Drawing.Color.DarkOrange;
			this.passwordValue.Location = new System.Drawing.Point(91, 252);
			this.passwordValue.Name = "passwordValue";
			this.passwordValue.Size = new System.Drawing.Size(521, 22);
			this.passwordValue.TabIndex = 6;
			// 
			// longUrlBox
			// 
			this.longUrlBox.ForeColor = System.Drawing.Color.DodgerBlue;
			this.longUrlBox.Location = new System.Drawing.Point(91, 168);
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
			this.nextPage.Location = new System.Drawing.Point(529, 503);
			this.nextPage.Name = "nextPage";
			this.nextPage.Size = new System.Drawing.Size(83, 32);
			this.nextPage.TabIndex = 19;
			this.nextPage.Text = "Next --->";
			this.nextPage.UseVisualStyleBackColor = false;
			this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
			// 
			// backPage
			// 
			this.backPage.BackColor = System.Drawing.Color.LimeGreen;
			this.backPage.FlatAppearance.BorderSize = 0;
			this.backPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backPage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.backPage.Location = new System.Drawing.Point(91, 503);
			this.backPage.Name = "backPage";
			this.backPage.Size = new System.Drawing.Size(83, 32);
			this.backPage.TabIndex = 19;
			this.backPage.Text = "<---Back";
			this.backPage.UseVisualStyleBackColor = false;
			this.backPage.Click += new System.EventHandler(this.backPage_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label7.Location = new System.Drawing.Point(775, 488);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 50);
			this.label7.TabIndex = 20;
			this.label7.Text = "u R L";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label8.Location = new System.Drawing.Point(809, 548);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(150, 76);
			this.label8.TabIndex = 20;
			this.label8.Text = "u R L";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label9.Location = new System.Drawing.Point(704, 569);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(99, 50);
			this.label9.TabIndex = 20;
			this.label9.Text = "u R L";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label10.Location = new System.Drawing.Point(819, 525);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 23);
			this.label10.TabIndex = 20;
			this.label10.Text = "u R L";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label12.Location = new System.Drawing.Point(724, 546);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 23);
			this.label12.TabIndex = 20;
			this.label12.Text = "u R L";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.ForeColor = System.Drawing.Color.LightCyan;
			this.label17.Location = new System.Drawing.Point(207, 219);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(65, 16);
			this.label17.TabIndex = 9;
			this.label17.Text = "(Optional)";
			this.label17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label17.Click += new System.EventHandler(this.label11_Click);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label18.Location = new System.Drawing.Point(651, 113);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(66, 40);
			this.label18.TabIndex = 21;
			this.label18.Text = "N/B";
			this.label18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label19.Location = new System.Drawing.Point(637, 184);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(166, 48);
			this.label19.TabIndex = 22;
			this.label19.Text = "Maximum number of clicks \r\nbefore the url becomes \r\ninactive - Can edit in codes";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label20.Location = new System.Drawing.Point(637, 158);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(110, 16);
			this.label20.TabIndex = 23;
			this.label20.Text = "Max clicks = 1000";
			this.label20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// ClearTwo
			// 
			this.ClearTwo.BackColor = System.Drawing.Color.LimeGreen;
			this.ClearTwo.FlatAppearance.BorderSize = 0;
			this.ClearTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClearTwo.Location = new System.Drawing.Point(529, 441);
			this.ClearTwo.Name = "ClearTwo";
			this.ClearTwo.Size = new System.Drawing.Size(83, 32);
			this.ClearTwo.TabIndex = 24;
			this.ClearTwo.Text = "Clear";
			this.ClearTwo.UseVisualStyleBackColor = false;
			this.ClearTwo.Click += new System.EventHandler(this.ClearTwo_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label13.Location = new System.Drawing.Point(786, -16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(131, 65);
			this.label13.TabIndex = 20;
			this.label13.Text = "u R L";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label16.Location = new System.Drawing.Point(751, 28);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(53, 26);
			this.label16.TabIndex = 20;
			this.label16.Text = "u R L";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label15.Location = new System.Drawing.Point(821, 49);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(53, 26);
			this.label15.TabIndex = 20;
			this.label15.Text = "u R L";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label14.Location = new System.Drawing.Point(723, -9);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 30);
			this.label14.TabIndex = 20;
			this.label14.Text = "u R L";
			// 
			// secondApi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.DarkGreen;
			this.Controls.Add(this.ClearTwo);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.backPage);
			this.Controls.Add(this.nextPage);
			this.Controls.Add(this.copyShortUrl);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.shortenBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.shortUrl);
			this.Controls.Add(this.passwordValue);
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
		private System.Windows.Forms.TextBox passwordValue;
		private System.Windows.Forms.TextBox longUrlBox;
		private System.Windows.Forms.Button nextPage;
		private System.Windows.Forms.Button backPage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button ClearTwo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
	}
}
