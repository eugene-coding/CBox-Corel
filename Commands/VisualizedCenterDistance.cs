using CBox.Resources;

using Corel.Interop.VGCore;

namespace CBox.Commands
{
    public class VisualizedCenterDistance : ICommand
    {
        private readonly CenterDistance _centerDistance;

        public VisualizedCenterDistance(CenterDistance centerDistance)
        {
            _centerDistance = centerDistance;
        }

        public VisualizedCenterDistance(double horizontal, double vertical)
        {
            _centerDistance = new CenterDistance(horizontal, vertical);
        }

        public void Execute()
        {
            var shapeRange = Main.App.ActiveSelectionRange;

            if (shapeRange.Count == 0)
            {
                return;
            }

            foreach (Shape shape in shapeRange)
            {
                var ellipse = Main.App.ActiveLayer.CreateEllipse(0, 0, _centerDistance.Horizontal, _centerDistance.Vertical);

                ellipse.Name = Resource.CenterDistanceEllipseName;
                ellipse.CenterX = shape.CenterX;
                ellipse.CenterY = shape.CenterY;
                ellipse.RotationAngle = shape.RotationAngle;

                shape.AddToSelection();
                Main.App.ActiveSelection.Group();
            }
        }
    }
}
