using System.Web.Mvc;
using Orchard;
using Orchard.DisplayManagement;
using Orchard.Mvc.Filters;
using Orchard.UI.Admin;

namespace Lombiq.Hosting.Deployments.Filters
{
    /// <summary>
    /// Displays the BuildNumber shape in the Footer Zone of the Dashboard
    /// that can be used to indicate the current build number.
    /// </summary>
    public class BuildNumberDisplayingFilter : FilterProvider, IResultFilter
    {
        private readonly dynamic _shapeFactory;
        private readonly IWorkContextAccessor _workContextAccessor;


        public BuildNumberDisplayingFilter(IShapeFactory shapeFactory, IWorkContextAccessor workContextAccessor)
        {
            _shapeFactory = shapeFactory;
            _workContextAccessor = workContextAccessor;
        }


        public void OnResultExecuted(ResultExecutedContext filterContext) { }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (!(filterContext.Result is ViewResult && AdminFilter.IsApplied(filterContext.RequestContext))) return;

            var footerZone = _workContextAccessor.GetContext(filterContext).Layout.Zones["Footer"];
            footerZone = footerZone.Add(_shapeFactory.BuildNumber());
        }
    }
}