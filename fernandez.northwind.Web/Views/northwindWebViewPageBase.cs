using Abp.Web.Mvc.Views;

namespace fernandez.northwind.Web.Views
{
    public abstract class northwindWebViewPageBase : northwindWebViewPageBase<dynamic>
    {

    }

    public abstract class northwindWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected northwindWebViewPageBase()
        {
            LocalizationSourceName = northwindConsts.LocalizationSourceName;
        }
    }
}