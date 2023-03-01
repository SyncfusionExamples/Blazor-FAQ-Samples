using Microsoft.AspNetCore.Components.Forms;
using System.Linq;
namespace Custom_CSS_App
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
