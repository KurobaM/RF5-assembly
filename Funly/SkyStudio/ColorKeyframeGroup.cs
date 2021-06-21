using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DDC RID: 3548
	[Token(Token = "0x2000908")]
	[Serializable]
	public class ColorKeyframeGroup : KeyframeGroup<ColorKeyframe>
	{
		// Token: 0x06005B9F RID: 23455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x23D52F0", Offset = "0x23D53F1", VA = "0x23D52F0")]
		public ColorKeyframeGroup(string name)
		{
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x23D5350", Offset = "0x23D5451", VA = "0x23D5350")]
		public ColorKeyframeGroup(string name, ColorKeyframe frame)
		{
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0x23D53D0", Offset = "0x23D54D1", VA = "0x23D53D0")]
		public Color ColorForTime(float time)
		{
			return default(Color);
		}
	}
}
