using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009D6 RID: 2518
[Token(Token = "0x2000697")]
public class ShipmentSortMenu : MonoBehaviour
{
	// Token: 0x060041DA RID: 16858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036FE")]
	[Address(RVA = "0x1E37BE0", Offset = "0x1E37CE1", VA = "0x1E37BE0")]
	public void OnInstantiate(UIShipmentRecordMain _UIShipmentRecordMain, bool _useSize)
	{
	}

	// Token: 0x060041DB RID: 16859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036FF")]
	[Address(RVA = "0x1E37C80", Offset = "0x1E37D81", VA = "0x1E37C80")]
	private void SetCursorPos()
	{
	}

	// Token: 0x060041DC RID: 16860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003700")]
	[Address(RVA = "0x1E37D70", Offset = "0x1E37E71", VA = "0x1E37D70")]
	private void Start()
	{
	}

	// Token: 0x060041DD RID: 16861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003701")]
	[Address(RVA = "0x1E37E00", Offset = "0x1E37F01", VA = "0x1E37E00")]
	private void Update()
	{
	}

	// Token: 0x060041DE RID: 16862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003702")]
	[Address(RVA = "0x1E38040", Offset = "0x1E38141", VA = "0x1E38040")]
	private void CloseWindows()
	{
	}

	// Token: 0x060041DF RID: 16863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003703")]
	[Address(RVA = "0x1E38100", Offset = "0x1E38201", VA = "0x1E38100")]
	public ShipmentSortMenu()
	{
	}

	// Token: 0x0400A0C4 RID: 41156
	[Token(Token = "0x400794D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image[] MenuItem;

	// Token: 0x0400A0C5 RID: 41157
	[Token(Token = "0x400794E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite selectedBorderSprite;

	// Token: 0x0400A0C6 RID: 41158
	[Token(Token = "0x400794F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite NonSelectBorderSprite;

	// Token: 0x0400A0C7 RID: 41159
	[Token(Token = "0x4007950")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite selectedLastBorderSprite;

	// Token: 0x0400A0C8 RID: 41160
	[Token(Token = "0x4007951")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite NonSelectLastBorderSprite;

	// Token: 0x0400A0C9 RID: 41161
	[Token(Token = "0x4007952")]
	[FieldOffset(Offset = "0x40")]
	private ItemStorage sortStorage;

	// Token: 0x0400A0CA RID: 41162
	[Token(Token = "0x4007953")]
	[FieldOffset(Offset = "0x48")]
	private UIShipmentRecordMain UIShipmentRecordMain;

	// Token: 0x0400A0CB RID: 41163
	[Token(Token = "0x4007954")]
	[FieldOffset(Offset = "0x50")]
	private int selectingtItem;

	// Token: 0x0400A0CC RID: 41164
	[Token(Token = "0x4007955")]
	[FieldOffset(Offset = "0x54")]
	private bool useSize;
}
