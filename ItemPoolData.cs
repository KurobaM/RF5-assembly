using System;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x02000282 RID: 642
[Token(Token = "0x20001FD")]
public class ItemPoolData
{
	// Token: 0x06001031 RID: 4145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x20910C0", Offset = "0x20911C1", VA = "0x20910C0")]
	private void Init()
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x2091120", Offset = "0x2091221", VA = "0x2091120")]
	public ItemPoolData(ItemID item_id, Action<ItemID> action)
	{
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x20911C0", Offset = "0x20912C1", VA = "0x20911C0")]
	public void Destroy()
	{
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x2091360", Offset = "0x2091461", VA = "0x2091360")]
	public void Add(Action<ItemID> action)
	{
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x000076B0 File Offset: 0x000058B0
	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0x20911D0", Offset = "0x20912D1", VA = "0x20911D0")]
	public bool Delete()
	{
		return default(bool);
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0x2091430", Offset = "0x2091531", VA = "0x2091430")]
	public void Update()
	{
	}

	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x10")]
	public ItemID itemID;

	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x14")]
	public bool IsActive;

	// Token: 0x04000925 RID: 2341
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x18")]
	public string[] ItemName;

	// Token: 0x04000926 RID: 2342
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x20")]
	public Prefab[] ItemDataID;

	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] Item;

	// Token: 0x04000928 RID: 2344
	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x30")]
	public int Reference;

	// Token: 0x04000929 RID: 2345
	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x38")]
	public Action<ItemID> Callback;
}
