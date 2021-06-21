using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000841 RID: 2113
[Token(Token = "0x200056B")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x146330", Offset = "0x146431")]
[Serializable]
public class RuneAbilityMagicDataTable : RuneAbilityDataTable
{
	// Token: 0x06003827 RID: 14375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB7")]
	[Address(RVA = "0x1EF40C0", Offset = "0x1EF41C1", VA = "0x1EF40C0")]
	public RuneAbilityMagicDataTable()
	{
	}

	// Token: 0x04007B3B RID: 31547
	[Token(Token = "0x4006F6E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject InjectionObject;

	// Token: 0x04007B3C RID: 31548
	[Token(Token = "0x4006F6F")]
	[FieldOffset(Offset = "0x28")]
	public int UseRP;

	// Token: 0x04007B3D RID: 31549
	[Token(Token = "0x4006F70")]
	[FieldOffset(Offset = "0x2C")]
	public int RapidCastNum;
}
