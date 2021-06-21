using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EC2 RID: 3778
	[Token(Token = "0x20009AB")]
	public class GameSaveData : SaveDataBase
	{
		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060062B5 RID: 25269 RVA: 0x00021270 File Offset: 0x0001F470
		[Token(Token = "0x17000A09")]
		public override uint Version
		{
			[Token(Token = "0x60051D4")]
			[Address(RVA = "0x1EFB2B0", Offset = "0x1EFB3B1", VA = "0x1EFB2B0", Slot = "4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D5")]
		[Address(RVA = "0x1EFB2C0", Offset = "0x1EFB3C1", VA = "0x1EFB2C0", Slot = "14")]
		protected override void VersionInitialize()
		{
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060062B7 RID: 25271 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060062B8 RID: 25272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A0A")]
		public RF5SaveData Data
		{
			[Token(Token = "0x60051D6")]
			[Address(RVA = "0x1EFB450", Offset = "0x1EFB551", VA = "0x1EFB450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC9C0", Offset = "0x1ACAC1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051D7")]
			[Address(RVA = "0x1EFB460", Offset = "0x1EFB561", VA = "0x1EFB460")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC9D0", Offset = "0x1ACAD1")]
			private set
			{
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060062B9 RID: 25273 RVA: 0x00021288 File Offset: 0x0001F488
		// (set) Token: 0x060062BA RID: 25274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A0B")]
		public int SlotNo
		{
			[Token(Token = "0x60051D8")]
			[Address(RVA = "0x1EFB470", Offset = "0x1EFB571", VA = "0x1EFB470")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC9E0", Offset = "0x1ACAE1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60051D9")]
			[Address(RVA = "0x1EFB480", Offset = "0x1EFB581", VA = "0x1EFB480")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC9F0", Offset = "0x1ACAF1")]
			set
			{
			}
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051DA")]
		[Address(RVA = "0x1EFB490", Offset = "0x1EFB591", VA = "0x1EFB490")]
		public GameSaveData()
		{
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051DB")]
		[Address(RVA = "0x1EFBB20", Offset = "0x1EFBC21", VA = "0x1EFBB20", Slot = "5")]
		public override void Initialize()
		{
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051DC")]
		[Address(RVA = "0x1EFBB60", Offset = "0x1EFBC61", VA = "0x1EFBB60", Slot = "7")]
		public override void Save(SaveControllerBase controller)
		{
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x1EFBBD0", Offset = "0x1EFBCD1", VA = "0x1EFBBD0", Slot = "8")]
		public override void Load(SaveControllerBase controller)
		{
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051DE")]
		[Address(RVA = "0x1EFBCA0", Offset = "0x1EFBDA1", VA = "0x1EFBCA0", Slot = "9")]
		public override void BeforeSave()
		{
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x1EFBCC0", Offset = "0x1EFBDC1", VA = "0x1EFBCC0", Slot = "10")]
		public override void AfterLoad()
		{
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x1EFBCE0", Offset = "0x1EFBDE1", VA = "0x1EFBCE0", Slot = "11")]
		public override void Delete(SaveControllerBase controller)
		{
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x1EFBD20", Offset = "0x1EFBE21", VA = "0x1EFBD20", Slot = "15")]
		protected override void VersionWriter(BinaryWriter writer)
		{
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x1EFBD40", Offset = "0x1EFBE41", VA = "0x1EFBD40")]
		private void ReaderFunc0000(BinaryReader reader)
		{
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x1EFBFE0", Offset = "0x1EFC0E1", VA = "0x1EFBFE0")]
		private void ReaderFunc0001(BinaryReader reader)
		{
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x1EFC280", Offset = "0x1EFC381", VA = "0x1EFC280")]
		private void ReaderFunc0002(BinaryReader reader)
		{
		}

		// Token: 0x0400C2C8 RID: 49864
		[Token(Token = "0x40091F7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F300", Offset = "0x17F401")]
		private RF5SaveData <Data>k__BackingField;

		// Token: 0x0400C2C9 RID: 49865
		[Token(Token = "0x40091F8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F310", Offset = "0x17F411")]
		private int <SlotNo>k__BackingField;
	}
}
