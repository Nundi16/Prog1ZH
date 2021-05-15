using System;
using System.Collections.Generic;
using System.IO;

namespace Prog1ZH
{
    class Program
    {
        static List<Planet> Planets { get; set; }
        static FileDowload FileDownloader;
        static void Main(string[] args)
        {
            Planets = new List<Planet>();
            var _curPath = Directory.GetCurrentDirectory();
            foreach (var _planetStr in ReadFile(_curPath + "\\planets.txt"))
            {
                Planets.Add(new Planet(_planetStr));
            }
            FileDownloader = new FileDowload();
            FileDownloader.WebClientCompletedEvent += FileDownloader_WebClientCompletedEvent;
            FileDownloader.WebClientDowloadProgressChangeEvent += FileDownloader_WebClientDowloadProgressChangeEvent;
            foreach (var _planet in Planets)
            {
                var filePath = _curPath + "\\" + _planet.Name + ".jpg";
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                Console.WriteLine("Start: {0}", _planet.Url);
                FileDownloader.StartDownload(_planet.Url, filePath);
            }
            Console.ReadKey();

        }

        private static void FileDownloader_WebClientDowloadProgressChangeEvent(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("-> {0}%",e.ProgressPercentage);
        }

        private static void FileDownloader_WebClientCompletedEvent(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Download Finish!");
        }

        static string[] ReadFile(string path)
        {

            using (var _reader = new StreamReader(path))
            {
                return _reader.ReadToEnd().Split('\n');
            }
        }
    }
}
