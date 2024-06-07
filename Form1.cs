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
		private async void shortenBtn_Click(object sender, EventArgs e)
		{
			string longUrl = longUrlBox.Text;
			string customAlias = customName.Text;
			string password = "edfhj@24535WDG";  // Example password
			int maxClicks = 10;  // Example max clicks

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

		private void nextPage_Click(object sender, EventArgs e)
		{
			var secondApi = new secondApi();
			secondApi.Show();

		}
	}
}
