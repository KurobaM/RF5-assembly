using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D3C RID: 3388
	[Token(Token = "0x20008BC")]
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic
	{
		// Token: 0x06005718 RID: 22296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x25708C0", Offset = "0x25709C1", VA = "0x25708C0")]
		public void FadeOutBoneWeights()
		{
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004884")]
		[Address(RVA = "0x2570970", Offset = "0x2570A71", VA = "0x2570970", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004885")]
		[Address(RVA = "0x2570F70", Offset = "0x2571071", VA = "0x2570F70", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004886")]
		[Address(RVA = "0x25716D0", Offset = "0x25717D1", VA = "0x25716D0")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004887")]
		[Address(RVA = "0x2571E30", Offset = "0x2571F31", VA = "0x2571E30")]
		public IKSolverCCD()
		{
		}

		// Token: 0x0400B682 RID: 46722
		[Token(Token = "0x4008929")]
		[FieldOffset(Offset = "0x88")]
		public IKSolver.IterationDelegate OnPreIteration;
	}
}
