using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D1B RID: 3355
	[Token(Token = "0x20008A6")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148380", Offset = "0x148481")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148380", Offset = "0x148481")]
	public class LookAtIK : IK
	{
		// Token: 0x060055F5 RID: 22005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A6")]
		[Address(RVA = "0x27C5570", Offset = "0x27C5671", VA = "0x27C5570", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA800", Offset = "0x1AA901")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A7")]
		[Address(RVA = "0x27C55C0", Offset = "0x27C56C1", VA = "0x27C55C0", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA840", Offset = "0x1AA941")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x27C5610", Offset = "0x27C5711", VA = "0x27C5610")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA880", Offset = "0x1AA981")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x27C5660", Offset = "0x27C5761", VA = "0x27C5660")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA8C0", Offset = "0x1AA9C1")]
		private void ASThread()
		{
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x27C56B0", Offset = "0x27C57B1", VA = "0x27C56B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x27C56C0", Offset = "0x27C57C1", VA = "0x27C56C0")]
		public LookAtIK()
		{
		}

		// Token: 0x0400B511 RID: 46353
		[Token(Token = "0x4008809")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;
	}
}
