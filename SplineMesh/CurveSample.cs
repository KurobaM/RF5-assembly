using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E3A RID: 3642
	[Token(Token = "0x200094F")]
	public struct CurveSample
	{
		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06005FD2 RID: 24530 RVA: 0x00020160 File Offset: 0x0001E360
		[Token(Token = "0x170009CF")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6004F43")]
			[Address(RVA = "0x2E1D10", Offset = "0x2E1E11", VA = "0x2E1D10")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F44")]
		[Address(RVA = "0x2E1D20", Offset = "0x2E1E21", VA = "0x2E1D20")]
		public CurveSample(Vector3 location, Vector3 tangent, Vector3 up, Vector2 scale, float roll, float distanceInCurve, float timeInCurve)
		{
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x00020178 File Offset: 0x0001E378
		[Token(Token = "0x6004F45")]
		[Address(RVA = "0x2E1D60", Offset = "0x2E1E61", VA = "0x2E1D60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x00020190 File Offset: 0x0001E390
		[Token(Token = "0x6004F46")]
		[Address(RVA = "0x2E1D70", Offset = "0x2E1E71", VA = "0x2E1D70", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x000201A8 File Offset: 0x0001E3A8
		[Token(Token = "0x6004F47")]
		[Address(RVA = "0x2264690", Offset = "0x2264791", VA = "0x2264690")]
		public static bool operator ==(CurveSample cs1, CurveSample cs2)
		{
			return default(bool);
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x000201C0 File Offset: 0x0001E3C0
		[Token(Token = "0x6004F48")]
		[Address(RVA = "0x2265BC0", Offset = "0x2265CC1", VA = "0x2265BC0")]
		public static bool operator !=(CurveSample cs1, CurveSample cs2)
		{
			return default(bool);
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x000201D8 File Offset: 0x0001E3D8
		[Token(Token = "0x6004F49")]
		[Address(RVA = "0x2264730", Offset = "0x2264831", VA = "0x2264730")]
		public static CurveSample Lerp(CurveSample a, CurveSample b, float t)
		{
			return default(CurveSample);
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x2E1E10", Offset = "0x2E1F11", VA = "0x2E1E10")]
		public MeshVertex GetBent(MeshVertex vert)
		{
			return null;
		}

		// Token: 0x0400BEE0 RID: 48864
		[Token(Token = "0x4008EBB")]
		[FieldOffset(Offset = "0x0")]
		public readonly Vector3 location;

		// Token: 0x0400BEE1 RID: 48865
		[Token(Token = "0x4008EBC")]
		[FieldOffset(Offset = "0xC")]
		public readonly Vector3 tangent;

		// Token: 0x0400BEE2 RID: 48866
		[Token(Token = "0x4008EBD")]
		[FieldOffset(Offset = "0x18")]
		public readonly Vector3 up;

		// Token: 0x0400BEE3 RID: 48867
		[Token(Token = "0x4008EBE")]
		[FieldOffset(Offset = "0x24")]
		public readonly Vector2 scale;

		// Token: 0x0400BEE4 RID: 48868
		[Token(Token = "0x4008EBF")]
		[FieldOffset(Offset = "0x2C")]
		public readonly float roll;

		// Token: 0x0400BEE5 RID: 48869
		[Token(Token = "0x4008EC0")]
		[FieldOffset(Offset = "0x30")]
		public readonly float distanceInCurve;

		// Token: 0x0400BEE6 RID: 48870
		[Token(Token = "0x4008EC1")]
		[FieldOffset(Offset = "0x34")]
		public readonly float timeInCurve;

		// Token: 0x0400BEE7 RID: 48871
		[Token(Token = "0x4008EC2")]
		[FieldOffset(Offset = "0x38")]
		private Quaternion rotation;
	}
}
