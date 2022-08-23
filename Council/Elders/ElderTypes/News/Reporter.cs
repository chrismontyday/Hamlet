using System;
using System.Collections.Generic;
using System.Text;

namespace Council.Elders.ElderTypes.News
{
    public class Reporter : Elder
    {
        private String[] randomReport = { "A cat got stuck in a tree... it's still there.",
        "Have you tried the bread? It's definitely bread. ",
        "Thunderstorms came throught this week. Everyone was fine.",
        "A new type of squirrel might be invading our aread. ",
        "There was a circus a few towns over a few days ago.",
        "Someone found a bunch of exciting fruit to go with our bread.",
        "Literally nothing happened since the last gathering",
        "An unusual man claims he has spoken to the Creator of all things... weird fella...",
        "John Gleeberman and well known baker passed since the last gathering",
        "Rumors say that a plague has been affecting the local towns. We can only hope we are not affected.",
        "Most towns people agree, you should wear a special hat."};

        public Reporter(string name)
        {
            this.Name = name;
        }
        
        public string ReturnRandomReport()
        {
            Random r = new Random();
            return randomReport[r.Next(0, randomReport.Length)];
        }
    }
}
