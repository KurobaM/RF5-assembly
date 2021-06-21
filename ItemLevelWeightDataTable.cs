using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000388 RID: 904
[Token(Token = "0x20002B2")]
[Serializable]
public class ItemLevelWeightDataTable
{
	// Token: 0x060016FB RID: 5883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146B")]
	[Address(RVA = "0x208F290", Offset = "0x208F391", VA = "0x208F290")]
	public ItemLevelWeightDataTable()
	{
	}

	// Token: 0x04000FE3 RID: 4067
	[Token(Token = "0x4000C9B")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int Id;

	// Token: 0x04000FE4 RID: 4068
	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public GameFlagData GameFlagData;

	// Token: 0x04000FE5 RID: 4069
	[Token(Token = "0x4000C9D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int[] LevelWeights;
}
