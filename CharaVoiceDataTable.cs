using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000348 RID: 840
[Token(Token = "0x2000277")]
[Serializable]
public class CharaVoiceDataTable
{
	// Token: 0x06001650 RID: 5712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x1E85790", Offset = "0x1E85891", VA = "0x1E85790")]
	public static CharaVoiceDataTable GetDataTable(CharID charID)
	{
		return null;
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x00009EB8 File Offset: 0x000080B8
	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x1E85910", Offset = "0x1E85A11", VA = "0x1E85910")]
	public static bool HasDataTable(CharID charID)
	{
		return default(bool);
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x1E85A50", Offset = "0x1E85B51", VA = "0x1E85A50")]
	public CharaVoiceDataTable()
	{
	}

	// Token: 0x04000E2A RID: 3626
	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public List<CharaVoiceGroupDataArray> Datas;

	// Token: 0x04000E2B RID: 3627
	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x0")]
	private static CharaVoiceDataTableArray _CharaVoiceDataTableArray;
}
