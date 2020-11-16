using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstEntitiyFrameworkCore.ViewComponents
{
    public class Modal:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }


    }
}
