using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D00 RID: 3328
	[Token(Token = "0x2000892")]
	[Serializable]
	public class Constraints
	{
		// Token: 0x060054F7 RID: 21751 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		[Token(Token = "0x60046DB")]
		[Address(RVA = "0x28724C0", Offset = "0x28725C1", VA = "0x28724C0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DC")]
		[Address(RVA = "0x286DC10", Offset = "0x286DD11", VA = "0x286DC10")]
		public void Initiate(Transform transform)
		{
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x286DE00", Offset = "0x286DF01", VA = "0x286DE00")]
		public void Update()
		{
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x286E670", Offset = "0x286E771", VA = "0x286E670")]
		public Constraints()
		{
		}

		// Token: 0x0400B465 RID: 46181
		[Token(Token = "0x4008787")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		// Token: 0x0400B466 RID: 46182
		[Token(Token = "0x4008788")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x0400B467 RID: 46183
		[Token(Token = "0x4008789")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		// Token: 0x0400B468 RID: 46184
		[Token(Token = "0x400878A")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		// Token: 0x0400B469 RID: 46185
		[Token(Token = "0x400878B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1787E0", Offset = "0x1788E1")]
		public float positionWeight;

		// Token: 0x0400B46A RID: 46186
		[Token(Token = "0x400878C")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		// Token: 0x0400B46B RID: 46187
		[Token(Token = "0x400878D")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		// Token: 0x0400B46C RID: 46188
		[Token(Token = "0x400878E")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178800", Offset = "0x178901")]
		public float rotationWeight;
	}
}
