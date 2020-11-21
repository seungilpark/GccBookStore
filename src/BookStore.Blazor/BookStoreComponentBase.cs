using BookStore.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BookStore.Blazor
{
    public class BookStoreComponentBase : AbpComponentBase
    {
        public BookStoreComponentBase()
        {
            LocalizationResource = typeof(BookStoreResource);
        }
    }
}
