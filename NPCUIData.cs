using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000971 RID: 2417
[Token(Token = "0x2000655")]
public class NPCUIData : ScriptableObject
{
	// Token: 0x06003F90 RID: 16272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034E5")]
	[Address(RVA = "0x1E22960", Offset = "0x1E22A61", VA = "0x1E22960")]
	public NPCUIData()
	{
	}

	// Token: 0x04008370 RID: 33648
	[Token(Token = "0x400765E")]
	[FieldOffset(Offset = "0x18")]
	public NPCUIData.Data[] datas;

	// Token: 0x02000972 RID: 2418
	[Token(Token = "0x200129E")]
	[Serializable]
	public struct Data
	{
		// Token: 0x04008371 RID: 33649
		[Token(Token = "0x4019975")]
		[FieldOffset(Offset = "0x0")]
		public NPCID id;

		// Token: 0x04008372 RID: 33650
		[Token(Token = "0x4019976")]
		[FieldOffset(Offset = "0x4")]
		public int sizeScale;

		// Token: 0x04008373 RID: 33651
		[Token(Token = "0x4019977")]
		[FieldOffset(Offset = "0x8")]
		public int bdSeason;

		// Token: 0x04008374 RID: 33652
		[Token(Token = "0x4019978")]
		[FieldOffset(Offset = "0xC")]
		public int bdDate;
	}
}
