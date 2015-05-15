using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            
            if (FileUpload1.HasFile)
            {
                try
                {
                    Response.Write(AppDomain.CurrentDomain);
                    Response.Write(string.Format(" Uploading file: {0}", "foto1.png"));

                    string path = Server.MapPath(@"~\" + @"Francisco\");
                    Directory.CreateDirectory(path);
                                      
                    FileUpload1.SaveAs(path + "foto1.png");

                    //Showing the file information
                   
                    

                    Response.Write(string.Format("<br/> Save As: {0}", FileUpload1.PostedFile.FileName));
                    Response.Write(string.Format("<br/> File type: {0}", FileUpload1.PostedFile.ContentType));
                    Response.Write(string.Format("<br/> File length: {0}", FileUpload1.PostedFile.ContentLength));
                    Response.Write(string.Format("<br/> File name: {0}", FileUpload1.PostedFile.FileName));

                }
                catch (Exception ex)
                {
                    Response.Write(string.Format("<br/> Error <br/>"));
                    Response.Write(string.Format("Unable to save file <br/> {0}", ex.Message));
                }
            }
            else
            {
                
            }
        }
    }
}