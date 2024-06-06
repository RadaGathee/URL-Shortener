using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace urlShortener
{
	public partial class Form1 : Form
	{
		private static readonly HttpClient client = new HttpClient();
		public Form1()
		{
			InitializeComponent();
			shortenBtn.Click += new EventHandler(shortenBtn_Click);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void clear_Click(object sender, EventArgs e)
		{
			longUrlBox.Clear();
			customName.Clear();
		}
		private void shortenBtn_Click(object sender, EventArgs e)
		{
			string longUrl = longUrlBox.Text;
			string apiUrl = $"https://ulvis.net/API/write/get?url={longUrl}";

			try
			{
				// Run curl command
				string curlCommand = $"curl \"{apiUrl}\"";
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = "curl",
					Arguments = curlCommand,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true
				};

				using (Process process = Process.Start(startInfo))
				{
					if (process != null)
					{
						string output = process.StandardOutput.ReadToEnd();
						shortUrl.Text = output;
					}
					else
					{
						MessageBox.Show("Failed to start curl process.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void clearBtn2_Click(object sender, EventArgs e)
		{
			shortUrl.Clear();
		}

		private void copyShortUrl_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(shortUrl.Text);
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
