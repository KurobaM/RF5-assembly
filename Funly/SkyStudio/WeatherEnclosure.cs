using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E1C RID: 3612
	[Token(Token = "0x2000941")]
	[Attribute(Name = "RequireComponent", RVA = "0x148FC0", Offset = "0x1490C1")]
	public class WeatherEnclosure : MonoBehaviour
	{
		// Token: 0x06005DFD RID: 24061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E14")]
		[Address(RVA = "0x23F0470", Offset = "0x23F0571", VA = "0x23F0470")]
		public WeatherEnclosure()
		{
		}

		// Token: 0x0400BDF7 RID: 48631
		[Token(Token = "0x4008E5B")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 nearTextureTiling;

		// Token: 0x0400BDF8 RID: 48632
		[Token(Token = "0x4008E5C")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 farTextureTiling;
	}
}
