using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D12 RID: 3346
	[Token(Token = "0x200089D")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x1480E0", Offset = "0x1481E1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1480E0", Offset = "0x1481E1")]
	public class ArmIK : IK
	{
		// Token: 0x060055B6 RID: 21942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004767")]
		[Address(RVA = "0x286CB80", Offset = "0x286CC81", VA = "0x286CB80", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA000", Offset = "0x1AA101")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004768")]
		[Address(RVA = "0x286CBD0", Offset = "0x286CCD1", VA = "0x286CBD0", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA040", Offset = "0x1AA141")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004769")]
		[Address(RVA = "0x286CC20", Offset = "0x286CD21", VA = "0x286CC20")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA080", Offset = "0x1AA181")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476A")]
		[Address(RVA = "0x286CC70", Offset = "0x286CD71", VA = "0x286CC70")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA0C0", Offset = "0x1AA1C1")]
		private void ASThread()
		{
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600476B")]
		[Address(RVA = "0x286CCC0", Offset = "0x286CDC1", VA = "0x286CCC0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476C")]
		[Address(RVA = "0x286CCD0", Offset = "0x286CDD1", VA = "0x286CCD0")]
		public ArmIK()
		{
		}

		// Token: 0x0400B506 RID: 46342
		[Token(Token = "0x40087FE")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;
	}
}
