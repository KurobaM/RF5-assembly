using System;
using System.Collections.Generic;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EC9 RID: 3785
	[Token(Token = "0x20009B0")]
	public class RF5FarmSupportMonsterData : SaveDataValueBase
	{
		// Token: 0x060062ED RID: 25325 RVA: 0x000212D0 File Offset: 0x0001F4D0
		[Token(Token = "0x6005207")]
		[Address(RVA = "0x1EFF630", Offset = "0x1EFF731", VA = "0x1EFF630")]
		public int GetFreeIndex()
		{
			return 0;
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x000212E8 File Offset: 0x0001F4E8
		[Token(Token = "0x6005208")]
		[Address(RVA = "0x1EFF750", Offset = "0x1EFF851", VA = "0x1EFF750")]
		public int GetIndex(uint friendMonsterDataID)
		{
			return 0;
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005209")]
		[Address(RVA = "0x1EFF830", Offset = "0x1EFF931", VA = "0x1EFF830")]
		public FarmSupportMonsterData Get(int index)
		{
			return null;
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600520A")]
		[Address(RVA = "0x1EFF8B0", Offset = "0x1EFF9B1", VA = "0x1EFF8B0")]
		public RF5FarmSupportMonsterData()
		{
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600520B")]
		[Address(RVA = "0x1EFF8E0", Offset = "0x1EFF9E1", VA = "0x1EFF8E0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600520C")]
		[Address(RVA = "0x1EFFA00", Offset = "0x1EFFB01", VA = "0x1EFFA00", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600520D")]
		[Address(RVA = "0x1EFFA10", Offset = "0x1EFFB11", VA = "0x1EFFA10", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600520E")]
		[Address(RVA = "0x1EFFA20", Offset = "0x1EFFB21", VA = "0x1EFFA20", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600520F")]
		[Address(RVA = "0x1EFFAF0", Offset = "0x1EFFBF1", VA = "0x1EFFAF0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C2ED RID: 49901
		[Token(Token = "0x4009214")]
		[FieldOffset(Offset = "0x10")]
		public List<FarmSupportMonsterData> FarmSupportMonsterDataList;

		// Token: 0x02000ECA RID: 3786
		[Token(Token = "0x2001485")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159AB0", Offset = "0x159BB1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060062F7 RID: 25335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B96")]
			[Address(RVA = "0x1EFFC40", Offset = "0x1EFFD41", VA = "0x1EFFC40")]
			public <>c()
			{
			}

			// Token: 0x060062F8 RID: 25336 RVA: 0x00021300 File Offset: 0x0001F500
			[Token(Token = "0x6007B97")]
			[Address(RVA = "0x1EFFC50", Offset = "0x1EFFD51", VA = "0x1EFFC50")]
			internal bool <GetFreeIndex>b__1_0(FarmSupportMonsterData data)
			{
				return default(bool);
			}

			// Token: 0x0400C2EE RID: 49902
			[Token(Token = "0x401BCE5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RF5FarmSupportMonsterData.<>c <>9;

			// Token: 0x0400C2EF RID: 49903
			[Token(Token = "0x401BCE6")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<FarmSupportMonsterData> <>9__1_0;
		}

		// Token: 0x02000ECB RID: 3787
		[Token(Token = "0x2001486")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159AC0", Offset = "0x159BC1")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x060062F9 RID: 25337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B98")]
			[Address(RVA = "0x1EFF820", Offset = "0x1EFF921", VA = "0x1EFF820")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x060062FA RID: 25338 RVA: 0x00021318 File Offset: 0x0001F518
			[Token(Token = "0x6007B99")]
			[Address(RVA = "0x1EFFC80", Offset = "0x1EFFD81", VA = "0x1EFFC80")]
			internal bool <GetIndex>b__0(FarmSupportMonsterData data)
			{
				return default(bool);
			}

			// Token: 0x0400C2F0 RID: 49904
			[Token(Token = "0x401BCE7")]
			[FieldOffset(Offset = "0x10")]
			public uint friendMonsterDataID;
		}
	}
}
