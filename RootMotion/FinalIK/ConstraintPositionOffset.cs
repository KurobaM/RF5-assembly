using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000CFD RID: 3325
	[Token(Token = "0x200088F")]
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		// Token: 0x060054EC RID: 21740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x2871CA0", Offset = "0x2871DA1", VA = "0x2871CA0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x2871F70", Offset = "0x2872071", VA = "0x2871F70")]
		public ConstraintPositionOffset()
		{
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x2871F80", Offset = "0x2872081", VA = "0x2871F80")]
		public ConstraintPositionOffset(Transform transform)
		{
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x0001BF78 File Offset: 0x0001A178
		[Token(Token = "0x170008A4")]
		private bool positionChanged
		{
			[Token(Token = "0x60046D3")]
			[Address(RVA = "0x2871EB0", Offset = "0x2871FB1", VA = "0x2871EB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400B45A RID: 46170
		[Token(Token = "0x400877C")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		// Token: 0x0400B45B RID: 46171
		[Token(Token = "0x400877D")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		// Token: 0x0400B45C RID: 46172
		[Token(Token = "0x400877E")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		// Token: 0x0400B45D RID: 46173
		[Token(Token = "0x400877F")]
		[FieldOffset(Offset = "0x40")]
		private bool initiated;
	}
}
