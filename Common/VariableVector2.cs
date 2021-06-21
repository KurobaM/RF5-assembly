using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common
{
	// Token: 0x020011CA RID: 4554
	[Token(Token = "0x2000B9F")]
	[Serializable]
	public class VariableVector2 : Variable<Vector2>
	{
		// Token: 0x06007127 RID: 28967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE3")]
		[Address(RVA = "0x20DBE70", Offset = "0x20DBF71", VA = "0x20DBE70")]
		public VariableVector2(Vector2 value)
		{
		}

		// Token: 0x06007128 RID: 28968 RVA: 0x00026FE8 File Offset: 0x000251E8
		[Token(Token = "0x6005DE4")]
		[Address(RVA = "0x20DBEE0", Offset = "0x20DBFE1", VA = "0x20DBEE0", Slot = "8")]
		public override Vector2 GetVector2()
		{
			return default(Vector2);
		}
	}
}
