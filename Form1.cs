using System;
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
			longUrl.Clear();
			customName.Clear();
		}
		// Flag to track if an error has been shown - if the user repeatedly clicks the shorten button, a lot of error message boxes will open- this limits it to one
		private bool isErrorShown = false; 

		private async void shortenBtn_Click(object sender, EventArgs e)
		{
			// Reset the flag before making the API call
			isErrorShown = false;
			var longUrlText = this.longUrl.Text;
			var customNameText = this.customName.Text;

			if (string.IsNullOrWhiteSpace(longUrlText))
			{
				MessageBox.Show("Please enter a long URL.");
				return;
			}
			var shortenedUrl = await ShortenUrl(longUrlText, customNameText);
			this.shortUrl.Text = shortenedUrl ?? "Error shortening URL";
		}


		private async Task<string> ShortenUrl(string longUrl, string customName = null)
		{
			string apiUrl = "https://ulvis.net/api/write/get?url=" + longUrl + "&custom=" + customName + "&type=json";

			try
			{
				var response = await client.GetAsync(apiUrl);
				response.EnsureSuccessStatusCode();
				var responseBody = await response.Content.ReadAsStringAsync();

				var json = JObject.Parse(responseBody);
				if (json["success"]?.ToString() == "1")
				{
					return json["data"]["url"]?.ToString();
				}
				else
				{
					if (!isErrorShown)
					{
						var error = json["error"];
						if (error != null)
						{
							var errorMsg = error["msg"]?.ToString();
							if (!string.IsNullOrWhiteSpace(errorMsg))
							{
								isErrorShown = true;
								MessageBox.Show($"Error: {errorMsg}");
							}
						}
					}
					return null;
				}
			}
			catch (HttpRequestException e)
			{
				MessageBox.Show($"Request error: {e.Message}");
				return null;
			}
		}





		private void clearBtn2_Click(object sender, EventArgs e)
		{
			shortUrl.Clear();
		}

		private void copyShortUrl_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(shortUrl.ToString());
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
