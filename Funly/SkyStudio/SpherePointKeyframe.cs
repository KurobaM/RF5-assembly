using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DE9 RID: 3561
	[Token(Token = "0x2000915")]
	[Serializable]
	public class SpherePointKeyframe : BaseKeyframe
	{
		// Token: 0x06005BE7 RID: 23527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x23E2810", Offset = "0x23E2911", VA = "0x23E2810")]
		public SpherePointKeyframe(SpherePoint spherePoint, float time)
		{
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x23E38A0", Offset = "0x23E39A1", VA = "0x23E38A0")]
		public SpherePointKeyframe(SpherePointKeyframe keyframe)
		{
		}

		// Token: 0x0400BB3A RID: 47930
		[Token(Token = "0x4008BB9")]
		[FieldOffset(Offset = "0x28")]
		public SpherePoint spherePoint;
	}
}
