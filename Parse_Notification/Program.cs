
using System.Collections;
using System.Text;

var stringBuilder = new StringBuilder();
var channels = new List<string>()
{
    "[FE]",
    "[BE]",
    "[QA]",
    "[Urgent]"
};

Console.WriteLine("Hello, I am your middleware. Please input your notification content");
var content = Console.ReadLine();

if (string.IsNullOrEmpty(content))
{
    Console.WriteLine("Please provide notification content.");
    Environment.Exit(0);
}

foreach (string channel in channels)
{
    if(content.Contains(channel))
        stringBuilder.AppendFormat("{0}, ", channel.Substring(1, channel.Length - 2));
}

if (stringBuilder.Length > 0)
{
    stringBuilder.Length -= 2;
    Console.WriteLine("Receive channels: {0}", stringBuilder.ToString());
}else
{
    Console.WriteLine("No channel matched.");
    Console.Write($"{Environment.NewLine}Press any key to exit...");
    Console.ReadKey(true);
}