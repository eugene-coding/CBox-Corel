using CBox.Resources;

namespace CBox.Commands
{
    public class DeleteCenterDistance : ICommand
    {
        public void Execute()
        {
            var shapeRange = Main.App.ActiveSelectionRange;

            if (shapeRange.Count > 0)
            {
                var shapes = shapeRange.Shapes.FindShapes(Resource.CenterDistanceEllipseName);
                shapes.Delete();
            }
        }
    }
}
