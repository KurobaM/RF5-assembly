using System;
using System.Collections.Generic;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000ED3 RID: 3795
	[Token(Token = "0x20009B5")]
	public class RF5LpocketData : SaveDataValueBase
	{
		// Token: 0x06006336 RID: 25398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005247")]
		[Address(RVA = "0x1F02B00", Offset = "0x1F02C01", VA = "0x1F02B00")]
		public RF5LpocketData()
		{
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005248")]
		[Address(RVA = "0x1F02B30", Offset = "0x1F02C31", VA = "0x1F02B30", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005249")]
		[Address(RVA = "0x1F02C50", Offset = "0x1F02D51", VA = "0x1F02C50", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524A")]
		[Address(RVA = "0x1F02C60", Offset = "0x1F02D61", VA = "0x1F02C60", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524B")]
		[Address(RVA = "0x1F02C70", Offset = "0x1F02D71", VA = "0x1F02C70", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524C")]
		[Address(RVA = "0x1F02DC0", Offset = "0x1F02EC1", VA = "0x1F02DC0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C30B RID: 49931
		[Token(Token = "0x4009226")]
		[FieldOffset(Offset = "0x10")]
		public bool SyncToCampEquip;

		// Token: 0x0400C30C RID: 49932
		[Token(Token = "0x4009227")]
		[FieldOffset(Offset = "0x14")]
		public int QuickLastFocus;

		// Token: 0x0400C30D RID: 49933
		[Token(Token = "0x4009228")]
		[FieldOffset(Offset = "0x18")]
		public int CampLastFocus;

		// Token: 0x0400C30E RID: 49934
		[Token(Token = "0x4009229")]
		[FieldOffset(Offset = "0x20")]
		public List<int> UIEMCategoriesCustomNo;

		// Token: 0x0400C30F RID: 49935
		[Token(Token = "0x400922A")]
		[FieldOffset(Offset = "0x28")]
		public List<int> UIEMQuckCategories;
	}
}
