using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;

namespace RegistrationApp.Filters
{
    public class TrackExecutionTime :ActionFilterAttribute
    {
        // D:\.NET\MVC\RegistrationApp\RegistrationApp\Data\ExecutionTime.txt

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            StringBuilder data = new StringBuilder();
            data.Append("\n");
            data.Append(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName);
            data.Append("-->");
            data.Append(filterContext.ActionDescriptor.ActionName);
            data.Append("\t");
            data.Append("After Execution");
            data.Append("\t");
            data.Append(DateTime.Now);
            LogExecutionData(data.ToString());
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            StringBuilder data = new StringBuilder();
            data.Append("\n");
            data.Append(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName);
            data.Append("-->");
            data.Append(filterContext.ActionDescriptor.ActionName);
            data.Append("\t");
            data.Append("On Execution");
            data.Append("\t");
            data.Append(DateTime.Now);
            LogExecutionData(data.ToString());
        }

        private void LogExecutionData(string data)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("/Data/ExecutionTime.txt"), data);
        }
    }
}