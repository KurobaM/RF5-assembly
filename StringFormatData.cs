using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B1B RID: 2843
[Token(Token = "0x2000768")]
public class StringFormatData : ScriptableObject
{
	// Token: 0x06004993 RID: 18835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D85")]
	[Address(RVA = "0x238F5C0", Offset = "0x238F6C1", VA = "0x238F5C0")]
	public StringFormatData()
	{
	}

	// Token: 0x0400A95B RID: 43355
	[Token(Token = "0x4007F92")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public StringFormatData.FormatData[] formatData;

	// Token: 0x02000B1C RID: 2844
	[Token(Token = "0x2001335")]
	[Serializable]
	public struct FormatData
	{
		// Token: 0x0400A95C RID: 43356
		[Token(Token = "0x401B62C")]
		[FieldOffset(Offset = "0x0")]
		public string format;

		// Token: 0x0400A95D RID: 43357
		[Token(Token = "0x401B62D")]
		[FieldOffset(Offset = "0x8")]
		public int[] paramId;
	}
}
