using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.ObjectDrawers
{
	// Token: 0x020012BF RID: 4799
	[Token(Token = "0x2000C8C")]
	public class IntSliderAttribute : ObjectDrawerAttribute
	{
		// Token: 0x060071C6 RID: 29126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7A")]
		[Address(RVA = "0x220C720", Offset = "0x220C821", VA = "0x220C720")]
		public IntSliderAttribute(int min, int max)
		{
		}

		// Token: 0x0401B50E RID: 111886
		[Token(Token = "0x4017F37")]
		[FieldOffset(Offset = "0x10")]
		public int min;

		// Token: 0x0401B50F RID: 111887
		[Token(Token = "0x4017F38")]
		[FieldOffset(Offset = "0x14")]
		public int max;
	}
}
