using System.Collections.Generic;

namespace ThemeGenerator.Classes
{
    public class Frameworks
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Url { get; set; }

        public string Version { get; set; }

        public List<string> JSUrl { get; set; }

        public List<string> CSSUrl { get; set; }

        public static List<Frameworks> GenDataFrameworks()
        {
            return new List<Frameworks>() {
                new Frameworks() {
                    Id = 1,
                    Title = "Bootstrap",
                    Url = "https://getbootstrap.com/",
                    Version = "4.3.5",
                    JSUrl = new List<string>() {
                        "https://code.jquery.com/jquery-3.5.1.slim.min.js",
                        "https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"
                    },
                    CSSUrl = new List<string>()
                    {
                        "https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"
                    }
                },
                new Frameworks()
                {
                    Id = 2,
                    Title = "Material Design Lite",
                    Url = "https://getmdl.io/index.html",
                    Version = "1.3.0",
                    JSUrl = new List<string>() {
                        "https://code.getmdl.io/1.3.0/material.min.js"
                    },
                    CSSUrl = new List<string>()
                    {
                        "https://fonts.googleapis.com/icon?family=Material+Icons",
                        "https://code.getmdl.io/1.3.0/material.indigo-pink.min.css"
                    }
                }
            };
        }
    }
}
