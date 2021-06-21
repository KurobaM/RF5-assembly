using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D17 RID: 3351
	[Token(Token = "0x20008A2")]
	public abstract class IK : SolverManager
	{
		// Token: 0x060055DB RID: 21979
		[Token(Token = "0x600478C")]
		public abstract IKSolver GetIKSolver();

		// Token: 0x060055DC RID: 21980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478D")]
		[Address(RVA = "0x2C11C90", Offset = "0x2C11D91", VA = "0x2C11C90", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478E")]
		[Address(RVA = "0x2C11D60", Offset = "0x2C11E61", VA = "0x2C11D60", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478F")]
		[Address(RVA = "0x2C11DD0", Offset = "0x2C11ED1", VA = "0x2C11DD0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		// Token: 0x060055DF RID: 21983
		[Token(Token = "0x6004790")]
		protected abstract void OpenUserManual();

		// Token: 0x060055E0 RID: 21984
		[Token(Token = "0x6004791")]
		protected abstract void OpenScriptReference();

		// Token: 0x060055E1 RID: 21985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004792")]
		[Address(RVA = "0x2C037F0", Offset = "0x2C038F1", VA = "0x2C037F0")]
		protected IK()
		{
		}
	}
}
