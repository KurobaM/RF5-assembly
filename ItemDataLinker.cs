using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000638 RID: 1592
[Token(Token = "0x200047D")]
public class ItemDataLinker
{
	// Token: 0x17000644 RID: 1604
	// (get) Token: 0x06002744 RID: 10052 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002745 RID: 10053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004FE")]
	public ItemStorage ItemStorage
	{
		[Token(Token = "0x600212A")]
		[Address(RVA = "0x22373A0", Offset = "0x22374A1", VA = "0x22373A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1C80", Offset = "0x1A1D81")]
		get
		{
			return null;
		}
		[Token(Token = "0x600212B")]
		[Address(RVA = "0x22373B0", Offset = "0x22374B1", VA = "0x22373B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1C90", Offset = "0x1A1D91")]
		private set
		{
		}
	}

	// Token: 0x17000645 RID: 1605
	// (get) Token: 0x06002746 RID: 10054 RVA: 0x0000F678 File Offset: 0x0000D878
	[Token(Token = "0x170004FF")]
	public int Index
	{
		[Token(Token = "0x600212C")]
		[Address(RVA = "0x22373C0", Offset = "0x22374C1", VA = "0x22373C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1CA0", Offset = "0x1A1DA1")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000646 RID: 1606
	// (get) Token: 0x06002747 RID: 10055 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002748 RID: 10056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000500")]
	public ItemData ItemData
	{
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x22373D0", Offset = "0x22374D1", VA = "0x22373D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x2237490", Offset = "0x2237591", VA = "0x2237490")]
		set
		{
		}
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600212F")]
	[Address(RVA = "0x2237430", Offset = "0x2237531", VA = "0x2237430")]
	private ItemData GetItemData()
	{
		return null;
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002130")]
	[Address(RVA = "0x22374A0", Offset = "0x22375A1", VA = "0x22374A0")]
	private void SetItemData(ItemData itemData)
	{
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002131")]
	[Address(RVA = "0x2237530", Offset = "0x2237631", VA = "0x2237530")]
	public ItemDataLinker(int num, StorageType storageType, ItemStorage itemStorage)
	{
	}

	// Token: 0x04006EFE RID: 28414
	[Token(Token = "0x40067CF")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168410", Offset = "0x168511")]
	private ItemStorage <ItemStorage>k__BackingField;

	// Token: 0x04006EFF RID: 28415
	[Token(Token = "0x40067D0")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168420", Offset = "0x168521")]
	private readonly int <Index>k__BackingField;
}
