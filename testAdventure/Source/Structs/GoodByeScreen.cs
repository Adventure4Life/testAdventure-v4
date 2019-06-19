using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class GoodByeScreen
    {
        private List<string> GoodByeFrame;
        private List<string> GoodByeType;

        public GoodByeScreen()
        {
            GoodByeFrame = new List<string>();
            GoodByeType= new List<string>();

            GoodByeFrame = FillFrame();
            GoodByeType = FillType();
        }

        public List<string> GetFrame() => GoodByeFrame;
        public List<string> GetTypeWrite() => GoodByeType;

        private List<string> FillFrame()
        {
            List<string> f = new List<string>();
            f.Add(@" ");
            f.Add(@" ");
            f.Add(@" ");
            f.Add(@" ");
            f.Add(@" ");
            f.Add(@"                                      ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗");
            f.Add(@"                                     ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗");
            f.Add(@"                                     ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝");
            f.Add(@"                                     ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗");
            f.Add(@"                                     ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║");
            f.Add(@"                                      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝");
            f.Add(@" ");
            f.Add(@" ");
            return f;
        }

        private List<string> FillType()
        {
            List<string> t = new List<string>();
            t.Add("Thank you so much for playing my short hobby learning project. This project is designed to teach my C#.");
            t.Add("");
            t.Add("This is only a short text demo. A much larger version of the game should be coming soon. So please watch my twitter or my blog at GameDev.net if you would like to keep updated on the progress of my hobbies.");
            t.Add("");
            t.Add("Twitter : https://twitter.com/Advent_4Life");
            t.Add("GameDev Blog : https://www.gamedev.net/blogs/blog/3358-open-blog-read-blog/");
            t.Add("");
            t.Add("Anyway.. thanks for playing!");
            t.Add("-AFL");
            return t;
        }
    }
}
