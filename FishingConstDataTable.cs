using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000371 RID: 881
[Token(Token = "0x200029D")]
[Serializable]
public class FishingConstDataTable
{
	// Token: 0x060016B9 RID: 5817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600142A")]
	[Address(RVA = "0x1EC7960", Offset = "0x1EC7A61", VA = "0x1EC7960")]
	public static FishingConstDataTable GetDataTable(int index)
	{
		return null;
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x0000A0E0 File Offset: 0x000082E0
	[Token(Token = "0x600142B")]
	[Address(RVA = "0x1EC7B00", Offset = "0x1EC7C01", VA = "0x1EC7B00")]
	public static float GetValue(int index)
	{
		return 0f;
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142C")]
	[Address(RVA = "0x1EC7B80", Offset = "0x1EC7C81", VA = "0x1EC7B80")]
	public static void LoadData()
	{
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142D")]
	[Address(RVA = "0x1EC7CB0", Offset = "0x1EC7DB1", VA = "0x1EC7CB0")]
	public FishingConstDataTable()
	{
	}

	// Token: 0x04000F1A RID: 3866
	[Token(Token = "0x4000BE2")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float Value;

	// Token: 0x04000F1B RID: 3867
	[Token(Token = "0x4000BE3")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04000F1C RID: 3868
	[Token(Token = "0x4000BE4")]
	[FieldOffset(Offset = "0x8")]
	private static FishingConstDataTableArray _FishingConstDataTableArray;
}
