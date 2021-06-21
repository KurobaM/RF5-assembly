using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000CFC RID: 3324
	[Token(Token = "0x200088E")]
	[Serializable]
	public class ConstraintPosition : Constraint
	{
		// Token: 0x060054E9 RID: 21737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CD")]
		[Address(RVA = "0x2871AF0", Offset = "0x2871BF1", VA = "0x2871AF0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CE")]
		[Address(RVA = "0x2871C50", Offset = "0x2871D51", VA = "0x2871C50")]
		public ConstraintPosition()
		{
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CF")]
		[Address(RVA = "0x2871C60", Offset = "0x2871D61", VA = "0x2871C60")]
		public ConstraintPosition(Transform transform)
		{
		}

		// Token: 0x0400B459 RID: 46169
		[Token(Token = "0x400877B")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 position;
	}
}
