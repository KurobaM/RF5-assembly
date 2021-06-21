using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000359 RID: 857
[Token(Token = "0x2000288")]
public class CraftCategoryDataTable : ScriptableObject
{
	// Token: 0x0600166B RID: 5739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x20E2290", Offset = "0x20E2391", VA = "0x20E2290")]
	public CraftCategoryDataTable()
	{
	}

	// Token: 0x04000E71 RID: 3697
	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x18")]
	public CraftCategoryDataTable.CraftCategoryData[] CraftCategoryDatas;

	// Token: 0x0200035A RID: 858
	[Token(Token = "0x200105A")]
	[Serializable]
	public class CraftCategoryData
	{
		// Token: 0x0600166C RID: 5740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D79")]
		[Address(RVA = "0x20E22A0", Offset = "0x20E23A1", VA = "0x20E22A0")]
		public CraftCategoryData()
		{
		}

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4018F92")]
		[FieldOffset(Offset = "0x10")]
		public SkillID SkillID;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4018F93")]
		[FieldOffset(Offset = "0x18")]
		public RecipeId[] RecipeIds;
	}
}
