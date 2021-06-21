using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200062E RID: 1582
[Token(Token = "0x2000477")]
public class ItemTool : ItemEquip
{
	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x0600270F RID: 9999 RVA: 0x0000F600 File Offset: 0x0000D800
	// (set) Token: 0x06002710 RID: 10000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004FB")]
	public bool IsRightEquip
	{
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x2241440", Offset = "0x2241541", VA = "0x2241440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1C60", Offset = "0x1A1D61")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x2241450", Offset = "0x2241551", VA = "0x2241450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1C70", Offset = "0x1A1D71")]
		private set
		{
		}
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x2241460", Offset = "0x2241561", VA = "0x2241460", Slot = "4")]
	public override void Awake()
	{
	}

	// Token: 0x06002712 RID: 10002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020FA")]
	[Address(RVA = "0x2241470", Offset = "0x2241571", VA = "0x2241470", Slot = "8")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020FB")]
	[Address(RVA = "0x2241500", Offset = "0x2241601", VA = "0x2241500", Slot = "9")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x0000F618 File Offset: 0x0000D818
	[Token(Token = "0x60020FC")]
	[Address(RVA = "0x2241590", Offset = "0x2241691", VA = "0x2241590", Slot = "5")]
	public override bool Attach(HumanController human, HumanAttachIDEnum attachId)
	{
		return default(bool);
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x22415D0", Offset = "0x22416D1", VA = "0x22415D0")]
	public void OnTrail()
	{
	}

	// Token: 0x06002716 RID: 10006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x22415E0", Offset = "0x22416E1", VA = "0x22415E0")]
	public void OffTrail(float fadeTime = 0.1f)
	{
	}

	// Token: 0x06002717 RID: 10007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x22415F0", Offset = "0x22416F1", VA = "0x22415F0", Slot = "7")]
	public override void SetVisible(bool visible)
	{
	}

	// Token: 0x06002718 RID: 10008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002100")]
	[Address(RVA = "0x2241600", Offset = "0x2241701", VA = "0x2241600")]
	public static void DisableAllHit()
	{
	}

	// Token: 0x06002719 RID: 10009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002101")]
	[Address(RVA = "0x2241610", Offset = "0x2241711", VA = "0x2241610")]
	public ItemTool()
	{
	}

	// Token: 0x04006DCB RID: 28107
	[Token(Token = "0x40066B2")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LayerMask m_HitLayer;

	// Token: 0x04006DCC RID: 28108
	[Token(Token = "0x40066B3")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Transform LeftHandIkTarget;

	// Token: 0x04006DCD RID: 28109
	[Token(Token = "0x40066B4")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1683F0", Offset = "0x1684F1")]
	private bool <IsRightEquip>k__BackingField;

	// Token: 0x04006DCE RID: 28110
	[Token(Token = "0x40066B5")]
	[FieldOffset(Offset = "0x0")]
	public static List<ItemTool> m_ActiveToolList;
}
