using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D1A RID: 3354
	[Token(Token = "0x20008A5")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148320", Offset = "0x148421")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148320", Offset = "0x148421")]
	public class LimbIK : IK
	{
		// Token: 0x060055EF RID: 21999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A0")]
		[Address(RVA = "0x27C4510", Offset = "0x27C4611", VA = "0x27C4510", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA700", Offset = "0x1AA801")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A1")]
		[Address(RVA = "0x27C4560", Offset = "0x27C4661", VA = "0x27C4560", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA740", Offset = "0x1AA841")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x27C45B0", Offset = "0x27C46B1", VA = "0x27C45B0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA780", Offset = "0x1AA881")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x27C4600", Offset = "0x27C4701", VA = "0x27C4600")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA7C0", Offset = "0x1AA8C1")]
		private void ASThread()
		{
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A4")]
		[Address(RVA = "0x27C4650", Offset = "0x27C4751", VA = "0x27C4650", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A5")]
		[Address(RVA = "0x27C4660", Offset = "0x27C4761", VA = "0x27C4660")]
		public LimbIK()
		{
		}

		// Token: 0x0400B510 RID: 46352
		[Token(Token = "0x4008808")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;
	}
}
