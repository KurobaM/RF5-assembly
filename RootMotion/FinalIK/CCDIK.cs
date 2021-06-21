using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D13 RID: 3347
	[Token(Token = "0x200089E")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148140", Offset = "0x148241")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148140", Offset = "0x148241")]
	public class CCDIK : IK
	{
		// Token: 0x060055BC RID: 21948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476D")]
		[Address(RVA = "0x286E930", Offset = "0x286EA31", VA = "0x286E930", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA100", Offset = "0x1AA201")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476E")]
		[Address(RVA = "0x286E980", Offset = "0x286EA81", VA = "0x286E980", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA140", Offset = "0x1AA241")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476F")]
		[Address(RVA = "0x286E9D0", Offset = "0x286EAD1", VA = "0x286E9D0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA180", Offset = "0x1AA281")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004770")]
		[Address(RVA = "0x286EA20", Offset = "0x286EB21", VA = "0x286EA20")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA1C0", Offset = "0x1AA2C1")]
		private void ASThread()
		{
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004771")]
		[Address(RVA = "0x286EA70", Offset = "0x286EB71", VA = "0x286EA70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004772")]
		[Address(RVA = "0x286EA80", Offset = "0x286EB81", VA = "0x286EA80")]
		public CCDIK()
		{
		}

		// Token: 0x0400B507 RID: 46343
		[Token(Token = "0x40087FF")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;
	}
}
