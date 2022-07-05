using System.Windows.Forms;

namespace CBox
{
	public partial class Main
	{
		private void Startup()
		{
		}

		[CgsAddInMacro]
		public void Macro1()
		{
			MessageBox.Show("Macro1 - " + App.Name);
		}
	}
}
