using System;
using System.Collections.Generic;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EE8 RID: 3816
	[Token(Token = "0x20009C4")]
	public abstract class SaveDataBase
	{
		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060063E0 RID: 25568
		[Token(Token = "0x17000A1B")]
		public abstract uint Version { [Token(Token = "0x60052F0")] get; }

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060063E1 RID: 25569 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063E2 RID: 25570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A1C")]
		public SaveDataHeader SaveDataHeader
		{
			[Token(Token = "0x60052F1")]
			[Address(RVA = "0x21CEC80", Offset = "0x21CED81", VA = "0x21CEC80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA80", Offset = "0x1ACB81")]
			get
			{
				return null;
			}
			[Token(Token = "0x60052F2")]
			[Address(RVA = "0x21CEC90", Offset = "0x21CED91", VA = "0x21CEC90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACA90", Offset = "0x1ACB91")]
			private set
			{
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060063E3 RID: 25571 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063E4 RID: 25572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A1D")]
		public SaveDataFooter SaveDataFooter
		{
			[Token(Token = "0x60052F3")]
			[Address(RVA = "0x21CECA0", Offset = "0x21CEDA1", VA = "0x21CECA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACAA0", Offset = "0x1ACBA1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60052F4")]
			[Address(RVA = "0x21CECB0", Offset = "0x21CEDB1", VA = "0x21CECB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACAB0", Offset = "0x1ACBB1")]
			private set
			{
			}
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F5")]
		[Address(RVA = "0x21CECC0", Offset = "0x21CEDC1", VA = "0x21CECC0")]
		public SaveDataBase()
		{
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F6")]
		[Address(RVA = "0x21CEF40", Offset = "0x21CF041", VA = "0x21CEF40", Slot = "5")]
		public virtual void Initialize()
		{
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F7")]
		[Address(RVA = "0x21CEF80", Offset = "0x21CF081", VA = "0x21CEF80", Slot = "6")]
		public virtual void Update()
		{
		}

		// Token: 0x060063E8 RID: 25576
		[Token(Token = "0x60052F8")]
		public abstract void Save(SaveControllerBase controller);

		// Token: 0x060063E9 RID: 25577
		[Token(Token = "0x60052F9")]
		public abstract void Load(SaveControllerBase controller);

		// Token: 0x060063EA RID: 25578
		[Token(Token = "0x60052FA")]
		public abstract void BeforeSave();

		// Token: 0x060063EB RID: 25579
		[Token(Token = "0x60052FB")]
		public abstract void AfterLoad();

		// Token: 0x060063EC RID: 25580
		[Token(Token = "0x60052FC")]
		public abstract void Delete(SaveControllerBase controller);

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060063ED RID: 25581 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063EE RID: 25582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A1E")]
		protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> VersionReader
		{
			[Token(Token = "0x60052FD")]
			[Address(RVA = "0x21CF0B0", Offset = "0x21CF1B1", VA = "0x21CF0B0", Slot = "12")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACAC0", Offset = "0x1ACBC1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60052FE")]
			[Address(RVA = "0x21CF0C0", Offset = "0x21CF1C1", VA = "0x21CF0C0", Slot = "13")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACAD0", Offset = "0x1ACBD1")]
			set
			{
			}
		}

		// Token: 0x060063EF RID: 25583
		[Token(Token = "0x60052FF")]
		protected abstract void VersionInitialize();

		// Token: 0x060063F0 RID: 25584
		[Token(Token = "0x6005300")]
		protected abstract void VersionWriter(BinaryWriter writer);

		// Token: 0x060063F1 RID: 25585 RVA: 0x00021750 File Offset: 0x0001F950
		[Token(Token = "0x6005301")]
		[Address(RVA = "0x21CF0D0", Offset = "0x21CF1D1", VA = "0x21CF0D0")]
		public static int RoundBlockSize(int length, int block_size)
		{
			return 0;
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005302")]
		[Address(RVA = "0x21CF0F0", Offset = "0x21CF1F1", VA = "0x21CF0F0")]
		protected byte[] Write()
		{
			return null;
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x00021768 File Offset: 0x0001F968
		[Token(Token = "0x6005303")]
		[Address(RVA = "0x21CF5D0", Offset = "0x21CF6D1", VA = "0x21CF5D0")]
		protected bool Read(byte[] data)
		{
			return default(bool);
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005304")]
		[Address(RVA = "0x21CFEB0", Offset = "0x21CFFB1", VA = "0x21CFEB0")]
		public static void FixedStringWriter(BinaryWriter writer, string text, int length)
		{
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005305")]
		[Address(RVA = "0x21D0020", Offset = "0x21D0121", VA = "0x21D0020")]
		public static string FixedStringReader(BinaryReader reader, int length)
		{
			return null;
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x00021780 File Offset: 0x0001F980
		[Token(Token = "0x6005306")]
		[Address(RVA = "0x21CF910", Offset = "0x21CFA11", VA = "0x21CF910")]
		protected bool CheckSum(uint sum, byte[] data, int length)
		{
			return default(bool);
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x00021798 File Offset: 0x0001F998
		[Token(Token = "0x6005307")]
		[Address(RVA = "0x21CF4D0", Offset = "0x21CF5D1", VA = "0x21CF4D0")]
		protected uint MakeSum(byte[] data, int length)
		{
			return 0U;
		}

		// Token: 0x0400C3C5 RID: 50117
		[Token(Token = "0x40092A4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F360", Offset = "0x17F461")]
		private SaveDataHeader <SaveDataHeader>k__BackingField;

		// Token: 0x0400C3C6 RID: 50118
		[Token(Token = "0x40092A5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F370", Offset = "0x17F471")]
		private SaveDataFooter <SaveDataFooter>k__BackingField;

		// Token: 0x0400C3C7 RID: 50119
		[Token(Token = "0x40092A6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F380", Offset = "0x17F481")]
		private Dictionary<uint, SaveDataBase.ReaderFunc> <VersionReader>k__BackingField;

		// Token: 0x02000EE9 RID: 3817
		// (Invoke) Token: 0x060063F9 RID: 25593
		[Token(Token = "0x2001490")]
		protected delegate void ReaderFunc(BinaryReader reader);
	}
}
