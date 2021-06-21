using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DE3 RID: 3555
	[Token(Token = "0x200090F")]
	[Serializable]
	public class BoolKeyframe : BaseKeyframe
	{
		// Token: 0x06005BDA RID: 23514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF5")]
		[Address(RVA = "0x23D4DC0", Offset = "0x23D4EC1", VA = "0x23D4DC0")]
		public BoolKeyframe(float time, bool value)
		{
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0x23D4DF0", Offset = "0x23D4EF1", VA = "0x23D4DF0")]
		public BoolKeyframe(BoolKeyframe keyframe)
		{
		}

		// Token: 0x0400BB2F RID: 47919
		[Token(Token = "0x4008BAE")]
		[FieldOffset(Offset = "0x24")]
		public bool value;
	}
}
