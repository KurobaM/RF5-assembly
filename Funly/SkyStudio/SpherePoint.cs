using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E0D RID: 3597
	[Token(Token = "0x2000933")]
	[Serializable]
	public class SpherePoint
	{
		// Token: 0x06005D74 RID: 23924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0x23D9C10", Offset = "0x23D9D11", VA = "0x23D9C10")]
		public SpherePoint(float horizontalRotation, float verticalRotation)
		{
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8C")]
		[Address(RVA = "0x23E3810", Offset = "0x23E3911", VA = "0x23E3810")]
		public SpherePoint(Vector3 worldDirection)
		{
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8D")]
		[Address(RVA = "0x23E3870", Offset = "0x23E3971", VA = "0x23E3870")]
		public void SetFromWorldDirection(Vector3 worldDirection)
		{
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x0001EF18 File Offset: 0x0001D118
		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0x23D9C50", Offset = "0x23D9D51", VA = "0x23D9C50")]
		public Vector3 GetWorldDirection()
		{
			return default(Vector3);
		}

		// Token: 0x0400BD9E RID: 48542
		[Token(Token = "0x4008E07")]
		[FieldOffset(Offset = "0x10")]
		public float horizontalRotation;

		// Token: 0x0400BD9F RID: 48543
		[Token(Token = "0x4008E08")]
		[FieldOffset(Offset = "0x14")]
		public float verticalRotation;

		// Token: 0x0400BDA0 RID: 48544
		[Token(Token = "0x4008E09")]
		public const float MinHorizontalRotation = -3.14159274f;

		// Token: 0x0400BDA1 RID: 48545
		[Token(Token = "0x4008E0A")]
		public const float MaxHorizontalRotation = 3.14159274f;

		// Token: 0x0400BDA2 RID: 48546
		[Token(Token = "0x4008E0B")]
		public const float MinVerticalRotation = -1.57079637f;

		// Token: 0x0400BDA3 RID: 48547
		[Token(Token = "0x4008E0C")]
		public const float MaxVerticalRotation = 1.57079637f;
	}
}
