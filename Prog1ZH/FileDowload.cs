using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace Prog1ZH
{
    class FileDowload
    {
        public async void StartDownload(string url, string localFilePath)
        {
            using(var _client = new WebClient())
            {
                _client.DownloadProgressChanged += ChangeProgressBar;
                _client.DownloadFileCompleted += DownloadingCompleted;
                await _client.DownloadFileTaskAsync(url, localFilePath);
            }
        }
        public delegate void WebClientCompletedHandler(object sender, AsyncCompletedEventArgs e);
        public event WebClientCompletedHandler WebClientCompletedEvent;

        public delegate void WebClientDowloadProgressChangeHandler(object sender, DownloadProgressChangedEventArgs e);
        public event WebClientDowloadProgressChangeHandler WebClientDowloadProgressChangeEvent;

        private void ChangeProgressBar(object sender, DownloadProgressChangedEventArgs e)
        {
            if(WebClientDowloadProgressChangeEvent != null)
            {

                WebClientDowloadProgressChangeEvent(sender, e);
            }
        }
        private void DownloadingCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(WebClientCompletedEvent != null)
            {

                WebClientCompletedEvent(sender, e);
            }
        }


    }
}
