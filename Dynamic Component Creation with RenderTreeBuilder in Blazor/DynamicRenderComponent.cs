using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorServerApp
{
    public class DynamicRenderComponent: ComponentBase
    {
        protected override void BuildRenderTree ( RenderTreeBuilder builder )
        {

            builder.OpenElement(0, "h1");
            builder.AddContent(0, "This is Example of Dynamically Render Component");
            builder.CloseElement();

        }
    }
}
