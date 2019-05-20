using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Tweet
    {
        public string From{get;}
        public string To{get;}
        public string Body{get;}
        public string Tag{get;}
        public string Id{get;}
        static int CURRENT_ID;

        public Tweet(string from, string to, string body, string tag){
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = CURRENT_ID.ToString();
            CURRENT_ID++;
            }

        public Tweet(string from, string to, string body, string tag, string id) {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = id;
            }

        public override string ToString()
        {
            return base.ToString();
        }

        public static Tweet Parse(string line){
            string[] newline =line.Split(new char[]{'\t'});
            return new Tweet(newline[0], newline[1], newline[2], newline[3], newline[4]); ;
}
    }
}

