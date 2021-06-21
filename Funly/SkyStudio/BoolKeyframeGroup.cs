using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DDB RID: 3547
	[Token(Token = "0x2000907")]
	[Serializable]
	public class BoolKeyframeGroup : KeyframeGroup<BoolKeyframe>
	{
		// Token: 0x06005B9C RID: 23452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0x23D4E40", Offset = "0x23D4F41", VA = "0x23D4E40")]
		public BoolKeyframeGroup(string name)
		{
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB8")]
		[Address(RVA = "0x23D4EA0", Offset = "0x23D4FA1", VA = "0x23D4EA0")]
		public BoolKeyframeGroup(string name, BoolKeyframe keyframe)
		{
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x0001E198 File Offset: 0x0001C398
		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x23D4F20", Offset = "0x23D5021", VA = "0x23D4F20")]
		public bool BoolForTime(float time)
		{
			return default(bool);
		}
	}
}
