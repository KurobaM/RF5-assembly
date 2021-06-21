using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000980 RID: 2432
[Token(Token = "0x200065F")]
public class UICampEquipMenuMain : MonoBehaviour
{
	// Token: 0x06003FA0 RID: 16288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034F4")]
	[Address(RVA = "0x2000DC0", Offset = "0x2000EC1", VA = "0x2000DC0")]
	public void CloseWindow()
	{
	}

	// Token: 0x06003FA1 RID: 16289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034F5")]
	[Address(RVA = "0x2000E50", Offset = "0x2000F51", VA = "0x2000E50")]
	private void OnDisable()
	{
	}

	// Token: 0x06003FA2 RID: 16290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034F6")]
	[Address(RVA = "0x2000EB0", Offset = "0x2000FB1", VA = "0x2000EB0")]
	private void OnEnable()
	{
	}

	// Token: 0x06003FA3 RID: 16291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034F7")]
	[Address(RVA = "0x2001250", Offset = "0x2001351", VA = "0x2001250")]
	private void Update()
	{
	}

	// Token: 0x06003FA4 RID: 16292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034F8")]
	[Address(RVA = "0x2001320", Offset = "0x2001421", VA = "0x2001320")]
	public UICampEquipMenuMain()
	{
	}

	// Token: 0x04009E07 RID: 40455
	[Token(Token = "0x4007715")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIEMMainControl UIEMMainControl;

	// Token: 0x04009E08 RID: 40456
	[Token(Token = "0x4007716")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UIOnOffAnimate StatusLeft;

	// Token: 0x04009E09 RID: 40457
	[Token(Token = "0x4007717")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UIOnOffAnimate StatusRight;

	// Token: 0x04009E0A RID: 40458
	[Token(Token = "0x4007718")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CampBadStatusController CampBadStatusController;
}
