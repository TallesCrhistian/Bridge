using Bridge.Interfaces;

namespace Bridge.Themes
{
    public class LightTheme : IUITheme
    {
        public void ApplyPrimaryColor(string color)
        {
            Console.WriteLine($"Applying primary color for Light theme: {color}");
        }

        public void ApplySecondaryColor(string color)
        {
            Console.WriteLine($"Applying secondary color for Light theme: {color}");
        }

        public void ApplyFont(string font)
        {
            Console.WriteLine($"Applying font for Light theme: {font}");
        }

        public void ApplyBackground(string background)
        {
            Console.WriteLine($"Applying background for Light theme: {background}");
        }
    }
}
