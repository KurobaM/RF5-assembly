using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DE4 RID: 3556
	[Token(Token = "0x2000910")]
	[Serializable]
	public class ColorKeyframe : BaseKeyframe
	{
		// Token: 0x06005BDC RID: 23516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x23D5200", Offset = "0x23D5301", VA = "0x23D5200")]
		public ColorKeyframe(Color c, float time)
		{
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x23D5280", Offset = "0x23D5381", VA = "0x23D5280")]
		public ColorKeyframe(ColorKeyframe keyframe)
		{
		}

		// Token: 0x0400BB30 RID: 47920
		[Token(Token = "0x4008BAF")]
		[FieldOffset(Offset = "0x24")]
		public Color color;
	}
}
