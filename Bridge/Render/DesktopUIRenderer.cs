using Bridge.Interfaces;

namespace Bridge.Render
{
    public class DesktopUIRenderer : UIRenderer
    {
        public IUITheme _iUITheme { get; set; }

        public DesktopUIRenderer(IUITheme iUITheme)
        {
            _iUITheme = iUITheme;
        }

        public void RenderButton(string text)
        {
            Console.WriteLine($"Rendering button for Desktop UI: {text}");
            _iUITheme.ApplyPrimaryColor("Blue");
            _iUITheme.ApplyFont("Arial");
        }

        public void RenderTextBox()
        {
            Console.WriteLine("Rendering text box for Desktop UI");
            _iUITheme.ApplyBackground("White");
            _iUITheme.ApplyFont("Arial");
        }

        public void RenderLabel(string text)
        {
            Console.WriteLine($"Rendering label for Desktop UI: {text}");
            _iUITheme.ApplyFont("Arial");
        }

        public void RenderCheckBox(string text)
        {
            Console.WriteLine($"Rendering checkbox for Desktop UI: {text}");
            _iUITheme.ApplySecondaryColor("Gray");
        }       
    }
}
