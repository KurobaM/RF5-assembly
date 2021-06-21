using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000279 RID: 633
[Token(Token = "0x20001F7")]
public class EquipItemPool : MonoBehaviour
{
	// Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x22B94B0", Offset = "0x22B95B1", VA = "0x22B94B0")]
	public static GameObject[] GetItems(ItemID item_id)
	{
		return null;
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x22B9560", Offset = "0x22B9661", VA = "0x22B9560")]
	public static void Add(ItemID item_id, Action<ItemID> action)
	{
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x22B9700", Offset = "0x22B9801", VA = "0x22B9700")]
	public static void Delete(ItemID item_id)
	{
	}

	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002B6")]
	private static EquipItemPool Instance
	{
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x22B97A0", Offset = "0x22B98A1", VA = "0x22B97A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C2B0", Offset = "0x19C3B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x22B97F0", Offset = "0x22B98F1", VA = "0x22B97F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C2C0", Offset = "0x19C3C1")]
		set
		{
		}
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x22B9850", Offset = "0x22B9951", VA = "0x22B9850")]
	private void Awake()
	{
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x22B98B0", Offset = "0x22B99B1", VA = "0x22B98B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x22B9A60", Offset = "0x22B9B61", VA = "0x22B9A60")]
	private void Start()
	{
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x22B9A70", Offset = "0x22B9B71", VA = "0x22B9A70")]
	private void Update()
	{
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x22B9DE0", Offset = "0x22B9EE1", VA = "0x22B9DE0")]
	public EquipItemPool()
	{
	}

	// Token: 0x04000901 RID: 2305
	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<ItemID, ItemPoolData> ItemPoolDatas;

	// Token: 0x04000902 RID: 2306
	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x20")]
	private List<ItemID> ItemDelDatas;

	// Token: 0x04000903 RID: 2307
	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x28")]
	private List<ItemID> ItemRemainDatas;

	// Token: 0x04000904 RID: 2308
	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E950", Offset = "0x15EA51")]
	private static EquipItemPool <Instance>k__BackingField;
}
