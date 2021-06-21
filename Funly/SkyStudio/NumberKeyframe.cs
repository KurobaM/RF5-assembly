using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DE8 RID: 3560
	[Token(Token = "0x2000914")]
	[Serializable]
	public class NumberKeyframe : BaseKeyframe
	{
		// Token: 0x06005BE5 RID: 23525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x23D9400", Offset = "0x23D9501", VA = "0x23D9400")]
		public NumberKeyframe(float time, float value)
		{
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C01")]
		[Address(RVA = "0x23D9430", Offset = "0x23D9531", VA = "0x23D9430")]
		public NumberKeyframe(NumberKeyframe keyframe)
		{
		}

		// Token: 0x0400BB39 RID: 47929
		[Token(Token = "0x4008BB8")]
		[FieldOffset(Offset = "0x24")]
		public float value;
	}
}
