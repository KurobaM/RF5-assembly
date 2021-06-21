using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003FE RID: 1022
[Token(Token = "0x200031F")]
public class AssetCounter : MonoBehaviour
{
	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x0600179A RID: 6042 RVA: 0x0000A470 File Offset: 0x00008670
	// (set) Token: 0x0600179B RID: 6043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003B4")]
	private bool HasEntry
	{
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x2443D70", Offset = "0x2443E71", VA = "0x2443D70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D500", Offset = "0x19D601")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x2443D80", Offset = "0x2443E81", VA = "0x2443D80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D510", Offset = "0x19D611")]
		set
		{
		}
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x2443D90", Offset = "0x2443E91", VA = "0x2443D90")]
	public void SetAndEntryAssetID(int assetId)
	{
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001500")]
	[Address(RVA = "0x2443E30", Offset = "0x2443F31", VA = "0x2443E30")]
	private void Start()
	{
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001501")]
	[Address(RVA = "0x2443EE0", Offset = "0x2443FE1", VA = "0x2443EE0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001502")]
	[Address(RVA = "0x2443F70", Offset = "0x2444071", VA = "0x2443F70")]
	public AssetCounter()
	{
	}

	// Token: 0x04005BAD RID: 23469
	[Token(Token = "0x4005848")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int AssetID;

	// Token: 0x04005BAE RID: 23470
	[Token(Token = "0x4005849")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162710", Offset = "0x162811")]
	private bool <HasEntry>k__BackingField;
}
