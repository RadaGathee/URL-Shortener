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
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace urlShortener
{
	public partial class Form1 : Form
	{
		private static readonly HttpClient client = new HttpClient();
		private DateTime lastRequestTime = DateTime.MinValue;
		private const int RequestLimit = 10; // Max requests per min is 15
		private const int RateLimitDurationSeconds = 60;
		private int requestsSentThisMinute = 0;
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
			passwordValue.Clear();
		}
		private async void shortenBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(longUrlBox.Text))
			{
				MessageBox.Show("Please enter a valid URL to shorten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (requestsSentThisMinute >= RequestLimit)
			{
				MessageBox.Show($"Rate limit exceeded. Please wait before sending more requests.");
				return;
			}

			// Check if rate limit window has passed
			if (DateTime.Now - lastRequestTime > TimeSpan.FromSeconds(RateLimitDurationSeconds))
			{
				requestsSentThisMinute = 0;
			}
			// Update last request time
			lastRequestTime = DateTime.Now;

			string longUrl = longUrlBox.Text;
			string customAlias = "";
			string password = passwordValue.Text;  // Example password abcd@1234
			int maxClicks = 1000;  // Example max clicks

			var payload = new Dictionary<string, string>
			{
				{ "url", longUrl },
				{ "alias", customAlias },
				{ "password", password },
				{ "max-clicks", maxClicks.ToString() }
			};

			var content = new FormUrlEncodedContent(payload);

			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			try
			{
				var response = await client.PostAsync("https://spoo.me", content);
				if (response.IsSuccessStatusCode)
				{
					var responseContent = await response.Content.ReadAsStringAsync();
					var jsonResponse = JObject.Parse(responseContent);
					shortUrl.Text = jsonResponse["short_url"].ToString();
				}
				else
				{
					MessageBox.Show($"Error: {response.StatusCode}");
					var errorContent = await response.Content.ReadAsStringAsync();
					MessageBox.Show(errorContent);
				}
				// Adds to the count of requests
				requestsSentThisMinute++;
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
			if (string.IsNullOrEmpty(shortUrl.Text))
			{
				MessageBox.Show("Please shorten the URL first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Clipboard.SetText(shortUrl.Text);
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void nextPage_Click(object sender, EventArgs e)
		{
			secondApi secondApi = new secondApi();
			secondApi.Location = new System.Drawing.Point(145, 0);
			this.Controls.Add(secondApi);
			secondApi.BringToFront();

		}

		private void label16_Click(object sender, EventArgs e)
		{

		}

		private void label17_Click(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void secondApi1_Load(object sender, EventArgs e)
		{

		}
	}
}
