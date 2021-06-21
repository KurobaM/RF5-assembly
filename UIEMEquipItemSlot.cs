using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000981 RID: 2433
[Token(Token = "0x2000660")]
public class UIEMEquipItemSlot : MonoBehaviour
{
	// Token: 0x06003FA5 RID: 16293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034F9")]
	[Address(RVA = "0x2009FC0", Offset = "0x200A0C1", VA = "0x2009FC0")]
	private void Awake()
	{
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034FA")]
	[Address(RVA = "0x200A0E0", Offset = "0x200A1E1", VA = "0x200A0E0")]
	public void SetEvent(UnityAction _action)
	{
	}

	// Token: 0x06003FA7 RID: 16295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034FB")]
	[Address(RVA = "0x200A0F0", Offset = "0x200A1F1", VA = "0x200A0F0")]
	private void OnTouch()
	{
	}

	// Token: 0x06003FA8 RID: 16296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034FC")]
	[Address(RVA = "0x200A110", Offset = "0x200A211", VA = "0x200A110")]
	public void SetSlotType(EquipSlotType _EquipSlotType, UIEMMainControl _UIEMMainControl)
	{
	}

	// Token: 0x06003FA9 RID: 16297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60034FD")]
	[Address(RVA = "0x200A170", Offset = "0x200A271", VA = "0x200A170")]
	public ItemData GetItemData()
	{
		return null;
	}

	// Token: 0x06003FAA RID: 16298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034FE")]
	[Address(RVA = "0x200A140", Offset = "0x200A241", VA = "0x200A140")]
	public void SetItem(EquipSlotType _EquipSlotType, UIEMMainControl _UIEMMainControl)
	{
	}

	// Token: 0x06003FAB RID: 16299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034FF")]
	[Address(RVA = "0x200A1D0", Offset = "0x200A2D1", VA = "0x200A1D0")]
	public void DrawItem()
	{
	}

	// Token: 0x06003FAC RID: 16300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003500")]
	[Address(RVA = "0x200A330", Offset = "0x200A431", VA = "0x200A330")]
	public void Focus()
	{
	}

	// Token: 0x06003FAD RID: 16301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003501")]
	[Address(RVA = "0x200A380", Offset = "0x200A481", VA = "0x200A380")]
	public void UnFocus()
	{
	}

	// Token: 0x06003FAE RID: 16302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003502")]
	[Address(RVA = "0x200A3D0", Offset = "0x200A4D1", VA = "0x200A3D0")]
	public UIEMEquipItemSlot()
	{
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003503")]
	[Address(RVA = "0x200A440", Offset = "0x200A541", VA = "0x200A440")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A71A0", Offset = "0x1A72A1")]
	private void <Awake>b__7_0(BaseEventData _data)
	{
	}

	// Token: 0x04009E0B RID: 40459
	[Token(Token = "0x4007719")]
	[FieldOffset(Offset = "0x18")]
	private EquipSlotType EquipSlotType;

	// Token: 0x04009E0C RID: 40460
	[Token(Token = "0x400771A")]
	[FieldOffset(Offset = "0x20")]
	private UIEMMainControl UIEMMainControl;

	// Token: 0x04009E0D RID: 40461
	[Token(Token = "0x400771B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ItemIconLoader ItemIconLoader;

	// Token: 0x04009E0E RID: 40462
	[Token(Token = "0x400771C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image FocusImage;

	// Token: 0x04009E0F RID: 40463
	[Token(Token = "0x400771D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image ItemCountImage;

	// Token: 0x04009E10 RID: 40464
	[Token(Token = "0x400771E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Sprite[] ItemCountSprite;

	// Token: 0x04009E11 RID: 40465
	[Token(Token = "0x400771F")]
	[FieldOffset(Offset = "0x48")]
	private UnityAction touchAction;
}
