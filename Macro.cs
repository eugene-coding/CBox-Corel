using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corel.Interop.VGCore;

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
			MessageBox.Show("Macro1 - " + app.Name);
		}
	}
}
