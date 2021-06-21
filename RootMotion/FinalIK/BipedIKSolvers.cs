using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000CFA RID: 3322
	[Token(Token = "0x200088C")]
	[Serializable]
	public class BipedIKSolvers
	{
		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060054E2 RID: 21730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A1")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60046C6")]
			[Address(RVA = "0x286D690", Offset = "0x286D791", VA = "0x286D690")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060054E3 RID: 21731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A2")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60046C7")]
			[Address(RVA = "0x286E440", Offset = "0x286E541", VA = "0x286E440")]
			get
			{
				return null;
			}
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C8")]
		[Address(RVA = "0x286DAE0", Offset = "0x286DBE1", VA = "0x286DAE0")]
		public void AssignReferences(BipedReferences references)
		{
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C9")]
		[Address(RVA = "0x286E290", Offset = "0x286E391", VA = "0x286E290")]
		public BipedIKSolvers()
		{
		}

		// Token: 0x0400B44D RID: 46157
		[Token(Token = "0x400876F")]
		[FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		// Token: 0x0400B44E RID: 46158
		[Token(Token = "0x4008770")]
		[FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		// Token: 0x0400B44F RID: 46159
		[Token(Token = "0x4008771")]
		[FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		// Token: 0x0400B450 RID: 46160
		[Token(Token = "0x4008772")]
		[FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		// Token: 0x0400B451 RID: 46161
		[Token(Token = "0x4008773")]
		[FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		// Token: 0x0400B452 RID: 46162
		[Token(Token = "0x4008774")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		// Token: 0x0400B453 RID: 46163
		[Token(Token = "0x4008775")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		// Token: 0x0400B454 RID: 46164
		[Token(Token = "0x4008776")]
		[FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		// Token: 0x0400B455 RID: 46165
		[Token(Token = "0x4008777")]
		[FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		// Token: 0x0400B456 RID: 46166
		[Token(Token = "0x4008778")]
		[FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;
	}
}
