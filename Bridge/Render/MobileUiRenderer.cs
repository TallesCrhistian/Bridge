using Bridge.Interfaces;

namespace Bridge.Render
{
    public class MobileUiRenderer : UIRenderer
    {
        public IUITheme _iUITheme { get; set; }

        public MobileUiRenderer(IUITheme iUITheme)
        {
            _iUITheme = iUITheme;
        }

        public void RenderButton(string text)
        {
            Console.WriteLine($"Rendering button for Mobile UI: {text}");
            _iUITheme.ApplyPrimaryColor("Green");
            _iUITheme.ApplyFont("Verdana");
        }

        public void RenderTextBox()
        {
            Console.WriteLine("Rendering text box for Mobile UI");
            _iUITheme.ApplyBackground("LightGray");
            _iUITheme.ApplyFont("Verdana");
        }

        public void RenderLabel(string text)
        {
            Console.WriteLine($"Rendering label for Mobile UI: {text}");
            _iUITheme.ApplyFont("Verdana");
        }

        public void RenderCheckBox(string text)
        {
            Console.WriteLine($"Rendering checkbox for Mobile UI: {text}");
            _iUITheme.ApplySecondaryColor("DarkGray");
        }      
    }
}
