using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BCC RID: 3020
	[Token(Token = "0x20007D9")]
	[Serializable]
	public class AngleLimits
	{
		// Token: 0x06004D3B RID: 19771 RVA: 0x000188E8 File Offset: 0x00016AE8
		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x21255C0", Offset = "0x21256C1", VA = "0x21255C0")]
		public static Vector3 GetAngleVector(Vector3 sideVector, Vector3 forwardVector, float degrees)
		{
			return default(Vector3);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x21256F0", Offset = "0x21257F1", VA = "0x21256F0")]
		public void CopyTo(AngleLimits target)
		{
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x00018900 File Offset: 0x00016B00
		[Token(Token = "0x60040C8")]
		[Address(RVA = "0x2125720", Offset = "0x2125821", VA = "0x2125720")]
		private static float ComputeFalloff(float value, float range)
		{
			return 0f;
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00018918 File Offset: 0x00016B18
		[Token(Token = "0x60040C9")]
		[Address(RVA = "0x2125800", Offset = "0x2125901", VA = "0x2125800")]
		public bool ConstrainVector(Vector3 basisSide, Vector3 basisUp, Vector3 basisForward, float springStrength, float deltaTime, ref Vector3 vector)
		{
			return default(bool);
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040CA")]
		[Address(RVA = "0x2125AB0", Offset = "0x2125BB1", VA = "0x2125AB0")]
		public AngleLimits()
		{
		}

		// Token: 0x0400AEC8 RID: 44744
		[Token(Token = "0x40083DC")]
		[FieldOffset(Offset = "0x10")]
		public bool active;

		// Token: 0x0400AEC9 RID: 44745
		[Token(Token = "0x40083DD")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176C50", Offset = "0x176D51")]
		public float min;

		// Token: 0x0400AECA RID: 44746
		[Token(Token = "0x40083DE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176C70", Offset = "0x176D71")]
		public float max;
	}
}
