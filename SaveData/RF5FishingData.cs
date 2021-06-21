using System;
using System.Collections.Generic;
using BinaryStream;
using Fishing;
using Il2CppDummyDll;
using UnityEngine;

namespace SaveData
{
	// Token: 0x02000ECC RID: 3788
	[Token(Token = "0x20009B1")]
	public class RF5FishingData : SaveDataValueBase
	{
		// Token: 0x060062FB RID: 25339 RVA: 0x00021330 File Offset: 0x0001F530
		[Token(Token = "0x6005210")]
		[Address(RVA = "0x1EFFCB0", Offset = "0x1EFFDB1", VA = "0x1EFFCB0")]
		public int GetIndex(ItemID fish_id)
		{
			return 0;
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005211")]
		[Address(RVA = "0x1EFFD90", Offset = "0x1EFFE91", VA = "0x1EFFD90")]
		public FishRecord Get(int index)
		{
			return null;
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005212")]
		[Address(RVA = "0x1EFFE10", Offset = "0x1EFFF11", VA = "0x1EFFE10")]
		public void SetSize(int index, Vector3Int size)
		{
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005213")]
		[Address(RVA = "0x1EFFEB0", Offset = "0x1EFFFB1", VA = "0x1EFFEB0")]
		public RF5FishingData()
		{
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005214")]
		[Address(RVA = "0x1EFFEE0", Offset = "0x1EFFFE1", VA = "0x1EFFEE0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005215")]
		[Address(RVA = "0x1F00040", Offset = "0x1F00141", VA = "0x1F00040", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005216")]
		[Address(RVA = "0x1F00050", Offset = "0x1F00151", VA = "0x1F00050", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005217")]
		[Address(RVA = "0x1F00060", Offset = "0x1F00161", VA = "0x1F00060", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005218")]
		[Address(RVA = "0x1F00200", Offset = "0x1F00301", VA = "0x1F00200")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C2F1 RID: 49905
		[Token(Token = "0x4009215")]
		[FieldOffset(Offset = "0x10")]
		public List<FishRecord> FishRecord;

		// Token: 0x0400C2F2 RID: 49906
		[Token(Token = "0x4009216")]
		[FieldOffset(Offset = "0x0")]
		private static ItemID[] FishArray;

		// Token: 0x02000ECD RID: 3789
		[Token(Token = "0x2001487")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159AD0", Offset = "0x159BD1")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06006305 RID: 25349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B9A")]
			[Address(RVA = "0x1EFFD80", Offset = "0x1EFFE81", VA = "0x1EFFD80")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06006306 RID: 25350 RVA: 0x00021348 File Offset: 0x0001F548
			[Token(Token = "0x6007B9B")]
			[Address(RVA = "0x1F003B0", Offset = "0x1F004B1", VA = "0x1F003B0")]
			internal bool <GetIndex>b__0(FishRecord n)
			{
				return default(bool);
			}

			// Token: 0x0400C2F3 RID: 49907
			[Token(Token = "0x401BCE8")]
			[FieldOffset(Offset = "0x10")]
			public ItemID fish_id;
		}
	}
}
