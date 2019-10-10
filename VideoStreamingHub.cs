using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat
{
    public class VideoStreamingHub
    {
        public void Send(String imageUrl, Int32 imageWidth, Int32 imageHeight)
        {
            this.Clients.All.Send(imageUrl, imageWidth, imageHeight);
        }
    }
}