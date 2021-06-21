using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200058A RID: 1418
[Token(Token = "0x20003FA")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x146040", Offset = "0x146141")]
[Serializable]
public class SeasonTextureDataTableArray : ScriptableObject
{
	// Token: 0x06002245 RID: 8773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CDE")]
	[Address(RVA = "0x1E2F200", Offset = "0x1E2F301", VA = "0x1E2F200")]
	public Dictionary<string, SeasonTextureData> GetTable()
	{
		return null;
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CDF")]
	[Address(RVA = "0x1E2F260", Offset = "0x1E2F361", VA = "0x1E2F260")]
	public Dictionary<string, SeasonTextureAssetIdData> GetIdTable()
	{
		return null;
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CE0")]
	[Address(RVA = "0x1E2F270", Offset = "0x1E2F371", VA = "0x1E2F270")]
	public void Initialize()
	{
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0x1E2F710", Offset = "0x1E2F811", VA = "0x1E2F710")]
	public SeasonTextureDataTableArray()
	{
	}

	// Token: 0x04006A88 RID: 27272
	[Token(Token = "0x400641B")]
	[FieldOffset(Offset = "0x18")]
	public SeasonTextureDataTable SeasonTextureDataTable;

	// Token: 0x04006A89 RID: 27273
	[Token(Token = "0x400641C")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<string, SeasonTextureAssetIdData> SeasonTextureAssetIdDataTable;
}
