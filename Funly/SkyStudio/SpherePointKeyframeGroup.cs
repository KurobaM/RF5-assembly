using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DE0 RID: 3552
	[Token(Token = "0x200090C")]
	[Serializable]
	public class SpherePointKeyframeGroup : KeyframeGroup<SpherePointKeyframe>
	{
		// Token: 0x06005BCB RID: 23499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE6")]
		[Address(RVA = "0x23E3960", Offset = "0x23E3A61", VA = "0x23E3960")]
		public SpherePointKeyframeGroup(string name)
		{
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE7")]
		[Address(RVA = "0x23E28E0", Offset = "0x23E29E1", VA = "0x23E28E0")]
		public SpherePointKeyframeGroup(string name, SpherePointKeyframe keyframe)
		{
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x23E09B0", Offset = "0x23E0AB1", VA = "0x23E09B0")]
		public SpherePoint SpherePointForTime(float time)
		{
			return null;
		}

		// Token: 0x0400BB27 RID: 47911
		[Token(Token = "0x4008BA6")]
		public const float MinHorizontalRotation = -3.14159274f;

		// Token: 0x0400BB28 RID: 47912
		[Token(Token = "0x4008BA7")]
		public const float MaxHorizontalRotation = 3.14159274f;

		// Token: 0x0400BB29 RID: 47913
		[Token(Token = "0x4008BA8")]
		public const float MinVerticalRotation = -1.57079637f;

		// Token: 0x0400BB2A RID: 47914
		[Token(Token = "0x4008BA9")]
		public const float MaxVerticalRotation = 1.57079637f;
	}
}
