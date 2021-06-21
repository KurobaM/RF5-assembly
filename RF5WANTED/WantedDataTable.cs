using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5WANTED
{
	// Token: 0x02000E81 RID: 3713
	[Token(Token = "0x2000983")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1496C0", Offset = "0x1497C1")]
	[Serializable]
	public class WantedDataTable : ScriptableObject
	{
		// Token: 0x06006152 RID: 24914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005093")]
		[Address(RVA = "0x1F37D20", Offset = "0x1F37E21", VA = "0x1F37D20")]
		public WantedDataTable()
		{
		}

		// Token: 0x0400C0E8 RID: 49384
		[Token(Token = "0x4009094")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public WantedDataTable.Data[] wantedDatas;

		// Token: 0x0400C0E9 RID: 49385
		[Token(Token = "0x4009095")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public WantedDataTable.Data[] randomWantedForestDatas;

		// Token: 0x0400C0EA RID: 49386
		[Token(Token = "0x4009096")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public WantedDataTable.Data[] randomWantedVolcanoDatas;

		// Token: 0x0400C0EB RID: 49387
		[Token(Token = "0x4009097")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public WantedDataTable.Data[] randomWantedIcyDatas;

		// Token: 0x0400C0EC RID: 49388
		[Token(Token = "0x4009098")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public WantedDataTable.Reward[] RewardDatas;

		// Token: 0x0400C0ED RID: 49389
		[Token(Token = "0x4009099")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public WantedDataTable.Reward[] RandomRewardDatas;

		// Token: 0x02000E82 RID: 3714
		[Token(Token = "0x200146A")]
		[Serializable]
		public class Data
		{
			// Token: 0x06006153 RID: 24915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B6E")]
			[Address(RVA = "0x1F37D30", Offset = "0x1F37E31", VA = "0x1F37D30")]
			public Data()
			{
			}

			// Token: 0x0400C0EE RID: 49390
			[Token(Token = "0x401BC60")]
			[FieldOffset(Offset = "0x10")]
			public MonsterDataID MonsterDataID;

			// Token: 0x0400C0EF RID: 49391
			[Token(Token = "0x401BC61")]
			[FieldOffset(Offset = "0x14")]
			public WantedFieldType FieldType;

			// Token: 0x0400C0F0 RID: 49392
			[Token(Token = "0x401BC62")]
			[FieldOffset(Offset = "0x18")]
			public int FieldId;

			// Token: 0x0400C0F1 RID: 49393
			[Token(Token = "0x401BC63")]
			[FieldOffset(Offset = "0x1C")]
			public int StarLevel;

			// Token: 0x0400C0F2 RID: 49394
			[Token(Token = "0x401BC64")]
			[FieldOffset(Offset = "0x20")]
			public PoliceRank PoliceRank;

			// Token: 0x0400C0F3 RID: 49395
			[Token(Token = "0x401BC65")]
			[FieldOffset(Offset = "0x24")]
			public int RewardId;

			// Token: 0x0400C0F4 RID: 49396
			[Token(Token = "0x401BC66")]
			[FieldOffset(Offset = "0x28")]
			public int MonsterSpriteId;
		}

		// Token: 0x02000E83 RID: 3715
		[Token(Token = "0x200146B")]
		[Serializable]
		public class Reward
		{
			// Token: 0x06006154 RID: 24916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B6F")]
			[Address(RVA = "0x1F37D40", Offset = "0x1F37E41", VA = "0x1F37D40")]
			public Reward()
			{
			}

			// Token: 0x0400C0F5 RID: 49397
			[Token(Token = "0x401BC67")]
			[FieldOffset(Offset = "0x10")]
			public ItemID ItemID;

			// Token: 0x0400C0F6 RID: 49398
			[Token(Token = "0x401BC68")]
			[FieldOffset(Offset = "0x14")]
			public int ItemPieces;

			// Token: 0x0400C0F7 RID: 49399
			[Token(Token = "0x401BC69")]
			[FieldOffset(Offset = "0x18")]
			public PoliceBatchId ReleaseBatchId;
		}
	}
}
