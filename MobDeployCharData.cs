using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000395 RID: 917
[Token(Token = "0x20002BD")]
[Serializable]
public class MobDeployCharData
{
	// Token: 0x06001714 RID: 5908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001480")]
	[Address(RVA = "0x1D797F0", Offset = "0x1D798F1", VA = "0x1D797F0")]
	public MobDeployCharData()
	{
	}

	// Token: 0x04001034 RID: 4148
	[Token(Token = "0x4000CE8")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public CharID CharID;

	// Token: 0x04001035 RID: 4149
	[Token(Token = "0x4000CE9")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public VariationNo VariationNo;
}
