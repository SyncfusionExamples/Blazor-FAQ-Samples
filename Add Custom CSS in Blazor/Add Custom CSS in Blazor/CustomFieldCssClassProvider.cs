using Microsoft.AspNetCore.Components.Forms;

namespace Add_Custom_CSS_in_Blazor
{
    public class CustomFieldCssClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass ( EditContext editContext,
        in FieldIdentifier fieldIdentifier )
        {
            var isValid = !editContext.GetValidationMessages(fieldIdentifier).Any();

            return isValid ? "validField" : "invalidField";
        }
    }
}
