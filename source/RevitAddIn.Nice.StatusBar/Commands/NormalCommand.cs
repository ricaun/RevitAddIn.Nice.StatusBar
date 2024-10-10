using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using ricaun.Revit.UI.StatusBar;

namespace RevitAddIn.Nice.StatusBar.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class NormalCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elementSet)
        {
            UIApplication uiapp = commandData.Application;

            int repeat = 1000;
            RevitProgressBarUtils.Run("Revit Repeat", repeat, (i) =>
            {
                Thread.Sleep(1);
            });

            return Result.Succeeded;
        }
    }

}