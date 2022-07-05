namespace CBox.Commands
{
    public class Refresh : ICommand
    {
        public void Execute()
        {
            Main.App.Optimization = false;
            Main.App.Refresh();
        }
    }
}
