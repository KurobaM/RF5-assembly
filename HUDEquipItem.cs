using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009A9 RID: 2473
[Token(Token = "0x2000679")]
public class HUDEquipItem : MonoBehaviour
{
	// Token: 0x0600409A RID: 16538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D5")]
	[Address(RVA = "0x204A3E0", Offset = "0x204A4E1", VA = "0x204A3E0")]
	private void Start()
	{
	}

	// Token: 0x0600409B RID: 16539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D6")]
	[Address(RVA = "0x204A440", Offset = "0x204A541", VA = "0x204A440")]
	private void UpdateItem()
	{
	}

	// Token: 0x0600409C RID: 16540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D7")]
	[Address(RVA = "0x204A840", Offset = "0x204A941", VA = "0x204A840")]
	private void Update()
	{
	}

	// Token: 0x0600409D RID: 16541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D8")]
	[Address(RVA = "0x204A8D0", Offset = "0x204A9D1", VA = "0x204A8D0")]
	public HUDEquipItem()
	{
	}

	// Token: 0x04009F32 RID: 40754
	[Token(Token = "0x40077F8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image ToolItemIcon;

	// Token: 0x04009F33 RID: 40755
	[Token(Token = "0x40077F9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image RuneXItemIcon;

	// Token: 0x04009F34 RID: 40756
	[Token(Token = "0x40077FA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image RuneYItemIcon;

	// Token: 0x04009F35 RID: 40757
	[Token(Token = "0x40077FB")]
	[FieldOffset(Offset = "0x30")]
	private HUDFadeMove HUDFadeMove;
}
