using System;

using Corel.Interop.VGCore;

namespace CBox
{
	[AttributeUsage(AttributeTargets.Class)]
	public class CgsAddInModule : Attribute { };

	[AttributeUsage(AttributeTargets.Constructor)]
	public class CgsAddInConstructor : Attribute { };

	[AttributeUsage(AttributeTargets.Method)]
	public class CgsAddInMacro : Attribute { };

	[AttributeUsage(AttributeTargets.Class)]
	public class CgsAddInTool : Attribute
	{
        public string Guid { get; set; }
        public string Name { get; set; }
    };

	[CgsAddInModule]
	public partial class Main
	{
		private readonly Application _app;

		[CgsAddInConstructor]
		public Main(object app)
		{
			_app = app as Application;
			Startup();
		}
	}
}
