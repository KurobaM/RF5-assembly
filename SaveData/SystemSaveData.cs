using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EF7 RID: 3831
	[Token(Token = "0x20009CF")]
	public class SystemSaveData : SaveDataBase
	{
		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06006480 RID: 25728 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		[Token(Token = "0x17000A4A")]
		public override uint Version
		{
			[Token(Token = "0x600538C")]
			[Address(RVA = "0x21D3B10", Offset = "0x21D3C11", VA = "0x21D3B10", Slot = "4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538D")]
		[Address(RVA = "0x21D3B20", Offset = "0x21D3C21", VA = "0x21D3B20", Slot = "14")]
		protected override void VersionInitialize()
		{
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06006482 RID: 25730 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006483 RID: 25731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4B")]
		public RF5SystemData Data
		{
			[Token(Token = "0x600538E")]
			[Address(RVA = "0x21D3C10", Offset = "0x21D3D11", VA = "0x21D3C10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACB40", Offset = "0x1ACC41")]
			get
			{
				return null;
			}
			[Token(Token = "0x600538F")]
			[Address(RVA = "0x21D3C20", Offset = "0x21D3D21", VA = "0x21D3C20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACB50", Offset = "0x1ACC51")]
			private set
			{
			}
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005390")]
		[Address(RVA = "0x21D2380", Offset = "0x21D2481", VA = "0x21D2380")]
		public SystemSaveData()
		{
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005391")]
		[Address(RVA = "0x21D3C30", Offset = "0x21D3D31", VA = "0x21D3C30", Slot = "5")]
		public override void Initialize()
		{
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005392")]
		[Address(RVA = "0x21D2950", Offset = "0x21D2A51", VA = "0x21D2950")]
		public void UpdateSaveData(int slot, RF5SaveData saveData)
		{
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005393")]
		[Address(RVA = "0x21D3CC0", Offset = "0x21D3DC1", VA = "0x21D3CC0", Slot = "7")]
		public override void Save(SaveControllerBase controller)
		{
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005394")]
		[Address(RVA = "0x21D3D40", Offset = "0x21D3E41", VA = "0x21D3D40", Slot = "8")]
		public override void Load(SaveControllerBase controller)
		{
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005395")]
		[Address(RVA = "0x21D3E10", Offset = "0x21D3F11", VA = "0x21D3E10", Slot = "9")]
		public override void BeforeSave()
		{
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005396")]
		[Address(RVA = "0x21D3E30", Offset = "0x21D3F31", VA = "0x21D3E30", Slot = "10")]
		public override void AfterLoad()
		{
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005397")]
		[Address(RVA = "0x21D3E50", Offset = "0x21D3F51", VA = "0x21D3E50", Slot = "11")]
		public override void Delete(SaveControllerBase controller)
		{
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005398")]
		[Address(RVA = "0x21D3EB0", Offset = "0x21D3FB1", VA = "0x21D3EB0", Slot = "15")]
		protected override void VersionWriter(BinaryWriter writer)
		{
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005399")]
		[Address(RVA = "0x21D3ED0", Offset = "0x21D3FD1", VA = "0x21D3ED0")]
		private void ReaderFunc0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C458 RID: 50264
		[Token(Token = "0x40092ED")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F3C0", Offset = "0x17F4C1")]
		private RF5SystemData <Data>k__BackingField;
	}
}
