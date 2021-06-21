using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.ObjectDrawers
{
	// Token: 0x020012BE RID: 4798
	[Token(Token = "0x2000C8B")]
	public class FloatSliderAttribute : ObjectDrawerAttribute
	{
		// Token: 0x060071C5 RID: 29125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E79")]
		[Address(RVA = "0x220C6E0", Offset = "0x220C7E1", VA = "0x220C6E0")]
		public FloatSliderAttribute(float min, float max)
		{
		}

		// Token: 0x0401B50C RID: 111884
		[Token(Token = "0x4017F35")]
		[FieldOffset(Offset = "0x10")]
		public float min;

		// Token: 0x0401B50D RID: 111885
		[Token(Token = "0x4017F36")]
		[FieldOffset(Offset = "0x14")]
		public float max;
	}
}
