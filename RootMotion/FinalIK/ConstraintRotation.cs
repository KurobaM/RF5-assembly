using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000CFE RID: 3326
	[Token(Token = "0x2000890")]
	[Serializable]
	public class ConstraintRotation : Constraint
	{
		// Token: 0x060054F0 RID: 21744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D4")]
		[Address(RVA = "0x2871FC0", Offset = "0x28720C1", VA = "0x2871FC0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D5")]
		[Address(RVA = "0x2872140", Offset = "0x2872241", VA = "0x2872140")]
		public ConstraintRotation()
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D6")]
		[Address(RVA = "0x2872150", Offset = "0x2872251", VA = "0x2872150")]
		public ConstraintRotation(Transform transform)
		{
		}

		// Token: 0x0400B45E RID: 46174
		[Token(Token = "0x4008780")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;
	}
}
