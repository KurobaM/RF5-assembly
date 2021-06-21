using System;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x020010F7 RID: 4343
	[Token(Token = "0x2000AEC")]
	public struct FocusObjectDataAccesser
	{
		// Token: 0x06006DD1 RID: 28113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B1A")]
		[Address(RVA = "0x2027C20", Offset = "0x2027D21", VA = "0x2027C20")]
		public static FocusObjectDataTableArray GetDataTableArray()
		{
			return null;
		}

		// Token: 0x06006DD2 RID: 28114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B1B")]
		[Address(RVA = "0x2027C70", Offset = "0x2027D71", VA = "0x2027C70")]
		public static FocusObjectDataTable[] GetDataTables()
		{
			return null;
		}

		// Token: 0x06006DD3 RID: 28115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1C")]
		[Address(RVA = "0x2027CD0", Offset = "0x2027DD1", VA = "0x2027CD0")]
		public static void LoadDataTable()
		{
		}

		// Token: 0x040180A9 RID: 98473
		[Token(Token = "0x4014B89")]
		[FieldOffset(Offset = "0x0")]
		private static FocusObjectDataTableArray DataTables;
	}
}
