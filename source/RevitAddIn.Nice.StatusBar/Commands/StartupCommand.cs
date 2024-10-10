using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using ricaun.Revit.UI.StatusBar;

namespace RevitAddIn.Nice.StatusBar.Commands
{
    /// <summary>
    ///     External command entry point invoked from the Revit interface
    /// </summary>
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
            int repeat = 2500;
            RevitProgressBarUtils.Run("Revit Repeat", repeat, (i) =>
            {
                Thread.Sleep(1);
            });
        }
    }
}