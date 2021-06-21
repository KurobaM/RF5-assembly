using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000A0A RID: 2570
[Token(Token = "0x20006BD")]
public class FriendEquipSlot : MonoBehaviour
{
	// Token: 0x06004352 RID: 17234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003853")]
	[Address(RVA = "0x1ED9360", Offset = "0x1ED9461", VA = "0x1ED9360")]
	private void Awake()
	{
	}

	// Token: 0x06004353 RID: 17235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003854")]
	[Address(RVA = "0x1ED9480", Offset = "0x1ED9581", VA = "0x1ED9480")]
	public void SetupSlotData(ActorID _actor)
	{
	}

	// Token: 0x06004354 RID: 17236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003855")]
	[Address(RVA = "0x1ED9550", Offset = "0x1ED9651", VA = "0x1ED9550")]
	public ItemData GetEquipItemData()
	{
		return null;
	}

	// Token: 0x06004355 RID: 17237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003856")]
	[Address(RVA = "0x1ED9570", Offset = "0x1ED9671", VA = "0x1ED9570")]
	public void SetTouchAction(UnityAction _action)
	{
	}

	// Token: 0x06004356 RID: 17238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003857")]
	[Address(RVA = "0x1ED9590", Offset = "0x1ED9691", VA = "0x1ED9590")]
	private void OnTouch()
	{
	}

	// Token: 0x06004357 RID: 17239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003858")]
	[Address(RVA = "0x1ED95B0", Offset = "0x1ED96B1", VA = "0x1ED95B0")]
	public void OnFocus()
	{
	}

	// Token: 0x06004358 RID: 17240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003859")]
	[Address(RVA = "0x1ED95D0", Offset = "0x1ED96D1", VA = "0x1ED95D0")]
	public void OffFocus()
	{
	}

	// Token: 0x06004359 RID: 17241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600385A")]
	[Address(RVA = "0x1ED95F0", Offset = "0x1ED96F1", VA = "0x1ED95F0")]
	public FriendEquipSlot()
	{
	}

	// Token: 0x0600435A RID: 17242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600385B")]
	[Address(RVA = "0x1ED9600", Offset = "0x1ED9701", VA = "0x1ED9600")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A76F0", Offset = "0x1A77F1")]
	private void <Awake>b__3_0(BaseEventData _data)
	{
	}

	// Token: 0x0400A22F RID: 41519
	[Token(Token = "0x4007A88")]
	[FieldOffset(Offset = "0x18")]
	private UIEquipSlot equipSlot;

	// Token: 0x0400A230 RID: 41520
	[Token(Token = "0x4007A89")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image focusImage;

	// Token: 0x0400A231 RID: 41521
	[Token(Token = "0x4007A8A")]
	[FieldOffset(Offset = "0x28")]
	private UnityAction touchAction;
}
