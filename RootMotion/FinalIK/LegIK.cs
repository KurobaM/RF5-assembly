using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D19 RID: 3353
	[Token(Token = "0x20008A4")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x1482C0", Offset = "0x1483C1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1482C0", Offset = "0x1483C1")]
	public class LegIK : IK
	{
		// Token: 0x060055E9 RID: 21993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479A")]
		[Address(RVA = "0x27C4340", Offset = "0x27C4441", VA = "0x27C4340", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA600", Offset = "0x1AA701")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479B")]
		[Address(RVA = "0x27C4390", Offset = "0x27C4491", VA = "0x27C4390", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA640", Offset = "0x1AA741")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479C")]
		[Address(RVA = "0x27C43E0", Offset = "0x27C44E1", VA = "0x27C43E0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA680", Offset = "0x1AA781")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479D")]
		[Address(RVA = "0x27C4430", Offset = "0x27C4531", VA = "0x27C4430")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA6C0", Offset = "0x1AA7C1")]
		private void ASThread()
		{
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479E")]
		[Address(RVA = "0x27C4480", Offset = "0x27C4581", VA = "0x27C4480", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479F")]
		[Address(RVA = "0x27C4490", Offset = "0x27C4591", VA = "0x27C4490")]
		public LegIK()
		{
		}

		// Token: 0x0400B50F RID: 46351
		[Token(Token = "0x4008807")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;
	}
}
