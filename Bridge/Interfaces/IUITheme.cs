namespace Bridge.Interfaces
{
    public interface IUITheme
    {
        void ApplyPrimaryColor(string color);
        void ApplySecondaryColor(string color);
        void ApplyFont(string font);
        void ApplyBackground(string background);
    }
}
