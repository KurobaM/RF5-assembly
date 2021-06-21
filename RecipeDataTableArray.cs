using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B9 RID: 953
[Token(Token = "0x20002DE")]
public class RecipeDataTableArray : ScriptableObject
{
	// Token: 0x0600175F RID: 5983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C8")]
	[Address(RVA = "0x1F3B780", Offset = "0x1F3B881", VA = "0x1F3B780")]
	public RecipeDataTableArray()
	{
	}

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x18")]
	public RecipeDataTableArray.RecipeDataTable[] RecipeDatas;

	// Token: 0x020003BA RID: 954
	[Token(Token = "0x2001064")]
	[Serializable]
	public class RecipeDataTable
	{
		// Token: 0x06001760 RID: 5984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D82")]
		[Address(RVA = "0x1F3B790", Offset = "0x1F3B891", VA = "0x1F3B790")]
		public RecipeDataTable()
		{
		}

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4018FC5")]
		[FieldOffset(Offset = "0x10")]
		public CraftCategoryId categoryId;

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4018FC6")]
		[FieldOffset(Offset = "0x14")]
		public RecipeId id;

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4018FC7")]
		[FieldOffset(Offset = "0x18")]
		public ItemID ResultItemId;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4018FC8")]
		[FieldOffset(Offset = "0x20")]
		public ItemID[] SourceItems;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4018FC9")]
		[FieldOffset(Offset = "0x28")]
		public int RpUse;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4018FCA")]
		[FieldOffset(Offset = "0x2C")]
		public int SkillLv;

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4018FCB")]
		[FieldOffset(Offset = "0x30")]
		public RecipeRelease RecipeRelease;
	}
}
