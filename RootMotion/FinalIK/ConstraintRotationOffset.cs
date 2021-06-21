using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000CFF RID: 3327
	[Token(Token = "0x2000891")]
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		// Token: 0x060054F3 RID: 21747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D7")]
		[Address(RVA = "0x2872190", Offset = "0x2872291", VA = "0x2872190", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D8")]
		[Address(RVA = "0x2872470", Offset = "0x2872571", VA = "0x2872470")]
		public ConstraintRotationOffset()
		{
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D9")]
		[Address(RVA = "0x2872480", Offset = "0x2872581", VA = "0x2872480")]
		public ConstraintRotationOffset(Transform transform)
		{
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060054F6 RID: 21750 RVA: 0x0001BF90 File Offset: 0x0001A190
		[Token(Token = "0x170008A5")]
		private bool rotationChanged
		{
			[Token(Token = "0x60046DA")]
			[Address(RVA = "0x28723A0", Offset = "0x28724A1", VA = "0x28723A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400B45F RID: 46175
		[Token(Token = "0x4008781")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		// Token: 0x0400B460 RID: 46176
		[Token(Token = "0x4008782")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		// Token: 0x0400B461 RID: 46177
		[Token(Token = "0x4008783")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		// Token: 0x0400B462 RID: 46178
		[Token(Token = "0x4008784")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		// Token: 0x0400B463 RID: 46179
		[Token(Token = "0x4008785")]
		[FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		// Token: 0x0400B464 RID: 46180
		[Token(Token = "0x4008786")]
		[FieldOffset(Offset = "0x6C")]
		private bool initiated;
	}
}
