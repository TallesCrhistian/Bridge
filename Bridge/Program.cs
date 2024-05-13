using Bridge.Interfaces;
using Bridge.Render;
using Bridge.Themes;

IUITheme lightTheme = new LightTheme();
IUITheme darkTheme = new DarkTheme();

// Render UI components with different themes on different platforms
UIRenderer desktopRenderer = new DesktopUIRenderer(lightTheme);
desktopRenderer.RenderButton("Submit");
desktopRenderer.RenderTextBox();

UIRenderer mobileRenderer = new MobileUiRenderer(darkTheme);
mobileRenderer.RenderLabel("Welcome");
mobileRenderer.RenderCheckBox("Remember me");

UIRenderer webRenderer = new DesktopUIRenderer(lightTheme);
webRenderer.RenderButton("Click here");
webRenderer.RenderLabel("Instructions");
