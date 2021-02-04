using Singleton;
using System.Web.Mvc;

namespace EmployeePortal.Controllers
{
    public class BaseController : Controller
    {
        private ILog _ILog;
        public BaseController()
        {
            _ILog = Log.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            _ILog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("ErrorPage").ExecuteResult(this.ControllerContext);
        }
    }
}