using Microsoft.AspNet.SignalR;
using Owin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace SignalRChat
{
    public partial class Vedio : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            var source = false;

            Boolean.TryParse(this.Request.QueryString["Source"], out source);

            this.video.Source = source;

            if (source == false)
            {
                this.video.Style[HtmlTextWriterStyle.Display] = "none";
            }
            else
            {
                //this.video.StreamingMode = VideoStreamingMode.None;
            }

            base.OnInit(e);
        }
    }
}