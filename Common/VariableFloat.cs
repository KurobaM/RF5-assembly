using System;
using Il2CppDummyDll;

namespace Common
{
	// Token: 0x020011C8 RID: 4552
	[Token(Token = "0x2000B9D")]
	[Serializable]
	public class VariableFloat : Variable<float>
	{
		// Token: 0x06007123 RID: 28963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDF")]
		[Address(RVA = "0x20DBCF0", Offset = "0x20DBDF1", VA = "0x20DBCF0")]
		public VariableFloat(float value)
		{
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x00026FD0 File Offset: 0x000251D0
		[Token(Token = "0x6005DE0")]
		[Address(RVA = "0x20DBD60", Offset = "0x20DBE61", VA = "0x20DBD60", Slot = "6")]
		public override float GetFloat()
		{
			return 0f;
		}
	}
}
