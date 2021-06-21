using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D14 RID: 3348
	[Token(Token = "0x200089F")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x1481A0", Offset = "0x1482A1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1481A0", Offset = "0x1482A1")]
	public class FABRIK : IK
	{
		// Token: 0x060055C2 RID: 21954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004773")]
		[Address(RVA = "0x28726C0", Offset = "0x28727C1", VA = "0x28726C0", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA200", Offset = "0x1AA301")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004774")]
		[Address(RVA = "0x2872710", Offset = "0x2872811", VA = "0x2872710", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA240", Offset = "0x1AA341")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004775")]
		[Address(RVA = "0x2872760", Offset = "0x2872861", VA = "0x2872760")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA280", Offset = "0x1AA381")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004776")]
		[Address(RVA = "0x28727B0", Offset = "0x28728B1", VA = "0x28727B0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA2C0", Offset = "0x1AA3C1")]
		private void ASThread()
		{
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004777")]
		[Address(RVA = "0x2872800", Offset = "0x2872901", VA = "0x2872800", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004778")]
		[Address(RVA = "0x2872810", Offset = "0x2872911", VA = "0x2872810")]
		public FABRIK()
		{
		}

		// Token: 0x0400B508 RID: 46344
		[Token(Token = "0x4008800")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;
	}
}
