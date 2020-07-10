using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTraining3._2.Pages
{
    public class MyHead : ComponentBase

    {
        [Parameter]
        public string Title { get; set; }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(1, "H1");
            builder.AddContent(2,Title);
            builder.CloseElement();

        }
    }
}
