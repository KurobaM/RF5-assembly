using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DDF RID: 3551
	[Token(Token = "0x200090B")]
	[Serializable]
	public class NumberKeyframeGroup : KeyframeGroup<NumberKeyframe>
	{
		// Token: 0x06005BC4 RID: 23492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0x23D9480", Offset = "0x23D9581", VA = "0x23D9480")]
		public NumberKeyframeGroup(string name, float min, float max)
		{
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x23D9500", Offset = "0x23D9601", VA = "0x23D9500")]
		public NumberKeyframeGroup(string name, float min, float max, NumberKeyframe frame)
		{
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x0001E300 File Offset: 0x0001C500
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x23D9590", Offset = "0x23D9691", VA = "0x23D9590")]
		public float GetFirstValue()
		{
			return 0f;
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x0001E318 File Offset: 0x0001C518
		[Token(Token = "0x6004BE2")]
		[Address(RVA = "0x23D9600", Offset = "0x23D9701", VA = "0x23D9600")]
		public float ValueToPercent(float value)
		{
			return 0f;
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x0001E330 File Offset: 0x0001C530
		[Token(Token = "0x6004BE3")]
		[Address(RVA = "0x23D9690", Offset = "0x23D9791", VA = "0x23D9690")]
		public float ValuePercentAtTime(float time)
		{
			return 0f;
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x0001E348 File Offset: 0x0001C548
		[Token(Token = "0x6004BE4")]
		[Address(RVA = "0x23D98A0", Offset = "0x23D99A1", VA = "0x23D98A0")]
		public float PercentToValue(float percent)
		{
			return 0f;
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x0001E360 File Offset: 0x0001C560
		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x23D9720", Offset = "0x23D9821", VA = "0x23D9720")]
		public float NumericValueAtTime(float time)
		{
			return 0f;
		}

		// Token: 0x0400BB25 RID: 47909
		[Token(Token = "0x4008BA4")]
		[FieldOffset(Offset = "0x2C")]
		public float minValue;

		// Token: 0x0400BB26 RID: 47910
		[Token(Token = "0x4008BA5")]
		[FieldOffset(Offset = "0x30")]
		public float maxValue;
	}
}
