using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200098A RID: 2442
[Token(Token = "0x2000667")]
public class UIQuickEquipMenuMain : MonoBehaviour
{
	// Token: 0x170008F9 RID: 2297
	// (get) Token: 0x06003FF6 RID: 16374 RVA: 0x00015AF8 File Offset: 0x00013CF8
	// (set) Token: 0x06003FF5 RID: 16373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700072F")]
	public bool isOpened
	{
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x1EAE730", Offset = "0x1EAE831", VA = "0x1EAE730")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x1EAE720", Offset = "0x1EAE821", VA = "0x1EAE720")]
		private set
		{
		}
	}

	// Token: 0x06003FF7 RID: 16375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003549")]
	[Address(RVA = "0x1EAE740", Offset = "0x1EAE841", VA = "0x1EAE740")]
	public void CloseWindow()
	{
	}

	// Token: 0x06003FF8 RID: 16376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600354A")]
	[Address(RVA = "0x1EAE8B0", Offset = "0x1EAE9B1", VA = "0x1EAE8B0")]
	private void Update()
	{
	}

	// Token: 0x06003FF9 RID: 16377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600354B")]
	[Address(RVA = "0x1EAEB00", Offset = "0x1EAEC01", VA = "0x1EAEB00")]
	public UIQuickEquipMenuMain()
	{
	}

	// Token: 0x04009E4C RID: 40524
	[Token(Token = "0x4007755")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIEMMainControl UIEMMainControl;

	// Token: 0x04009E4D RID: 40525
	[Token(Token = "0x4007756")]
	[FieldOffset(Offset = "0x20")]
	private bool _isOpened;
}
