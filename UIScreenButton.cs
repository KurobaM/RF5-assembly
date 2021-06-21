using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000952 RID: 2386
[Token(Token = "0x2000640")]
public class UIScreenButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x06003F45 RID: 16197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600349C")]
	[Address(RVA = "0x1EB5D30", Offset = "0x1EB5E31", VA = "0x1EB5D30", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06003F46 RID: 16198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600349D")]
	[Address(RVA = "0x1EB5DA0", Offset = "0x1EB5EA1", VA = "0x1EB5DA0")]
	public UIScreenButton()
	{
	}

	// Token: 0x040080CC RID: 32972
	[Token(Token = "0x40073FD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Key KeyID;
}
