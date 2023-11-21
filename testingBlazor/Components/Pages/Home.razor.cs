using Microsoft.AspNetCore.Components;

namespace testingBlazor.Components.Pages
{
    public partial class Home
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; }

        [CascadingParameter]
        public string Color { get; set; }

        [Parameter]
        public RenderFragment VisitShopContent { get; set; }


        protected override void OnInitialized()
        {
            base.OnInitialized();

            // Log the color to the browser console
            Console.WriteLine($"Color: {Color}");
 
        }
    }
}
