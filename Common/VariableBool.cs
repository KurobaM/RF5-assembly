using System;
using Il2CppDummyDll;

namespace Common
{
	// Token: 0x020011C6 RID: 4550
	[Token(Token = "0x2000B9B")]
	[Serializable]
	public class VariableBool : Variable<bool>
	{
		// Token: 0x0600711F RID: 28959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0x20DBC70", Offset = "0x20DBD71", VA = "0x20DBC70")]
		public VariableBool(bool value)
		{
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x00026FA0 File Offset: 0x000251A0
		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0x20DBCE0", Offset = "0x20DBDE1", VA = "0x20DBCE0", Slot = "4")]
		public override bool GetBool()
		{
			return default(bool);
		}
	}
}
