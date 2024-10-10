using Nice3point.Revit.Toolkit.External;
using RevitAddIn.Nice.StatusBar.Commands;

namespace RevitAddIn.Nice.StatusBar
{
    /// <summary>
    ///     Application entry point
    /// </summary>
    [UsedImplicitly]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            CreateRibbon();
        }

        private void CreateRibbon()
        {
            var panel = Application.CreatePanel("Commands", "RevitAddIn.Nice.StatusBar");

            panel.AddPushButton<StartupCommand>("Execute")
                .SetImage("/RevitAddIn.Nice.StatusBar;component/Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("/RevitAddIn.Nice.StatusBar;component/Resources/Icons/RibbonIcon32.png");
        }
    }
}