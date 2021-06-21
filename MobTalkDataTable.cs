using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A3 RID: 931
[Token(Token = "0x20002CB")]
[Serializable]
public class MobTalkDataTable : ScriptableObject
{
	// Token: 0x06001729 RID: 5929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001495")]
	[Address(RVA = "0x1D7B070", Offset = "0x1D7B171", VA = "0x1D7B070")]
	public static MobTalkData GetDataTable(CharID charID, VariationNo no)
	{
		return null;
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x0000A2A8 File Offset: 0x000084A8
	[Token(Token = "0x6001496")]
	[Address(RVA = "0x1D7B2A0", Offset = "0x1D7B3A1", VA = "0x1D7B2A0")]
	public static bool HasDataTable(CharID charID, VariationNo no)
	{
		return default(bool);
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001497")]
	[Address(RVA = "0x1D7B450", Offset = "0x1D7B551", VA = "0x1D7B450")]
	public MobTalkDataTable()
	{
	}

	// Token: 0x04001044 RID: 4164
	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public SerializeMobCharTalkDataTableArray Talks;

	// Token: 0x04001045 RID: 4165
	[Token(Token = "0x4000CF9")]
	[FieldOffset(Offset = "0x0")]
	private static MobTalkDataTable _MobTalkDataTable;
}
