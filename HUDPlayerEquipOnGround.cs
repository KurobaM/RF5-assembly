using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009BA RID: 2490
[Token(Token = "0x2000685")]
public class HUDPlayerEquipOnGround : MonoBehaviour
{
	// Token: 0x06004114 RID: 16660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003647")]
	[Address(RVA = "0x2059A70", Offset = "0x2059B71", VA = "0x2059A70")]
	private void Update()
	{
	}

	// Token: 0x06004115 RID: 16661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003648")]
	[Address(RVA = "0x2059C40", Offset = "0x2059D41", VA = "0x2059C40")]
	public HUDPlayerEquipOnGround()
	{
	}

	// Token: 0x04009FD8 RID: 40920
	[Token(Token = "0x400788B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image ItemIconImage;

	// Token: 0x04009FD9 RID: 40921
	[Token(Token = "0x400788C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HUDEquipItemSlot HUDEquipItemSlot;

	// Token: 0x04009FDA RID: 40922
	[Token(Token = "0x400788D")]
	[FieldOffset(Offset = "0x28")]
	private bool NowPulled;
}
