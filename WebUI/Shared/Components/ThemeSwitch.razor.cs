using Radzen;

namespace WebUI.Shared.Components
{
    /// <summary>
    /// ThemeSwitch component.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ThemeSwitch @bind-Value=@value Change=@(args => Console.WriteLine($"Value: {args}")) /&gt;
    /// </code>
    /// </example>
    public partial class ThemeSwitch : FormComponent<bool>
    {
        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return GetClassList("theme-switch").Add("theme-switch-checked", Value).ToString();
        }

        /// <summary>
        /// Toggles this instance checked state.
        /// </summary>
        public async System.Threading.Tasks.Task Toggle()
        {
            if (Disabled)
                return;

            Value = !Value;

            await ValueChanged.InvokeAsync(Value);
            if (FieldIdentifier.FieldName != null) { EditContext?.NotifyFieldChanged(FieldIdentifier); }
            await Change.InvokeAsync(Value);
        }
    }
}
