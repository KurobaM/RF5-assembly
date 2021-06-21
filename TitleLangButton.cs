using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000AEB RID: 2795
[Token(Token = "0x200074D")]
public class TitleLangButton : MonoBehaviour
{
	// Token: 0x0600488A RID: 18570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CBB")]
	[Address(RVA = "0x2071A70", Offset = "0x2071B71", VA = "0x2071A70")]
	private void Update()
	{
	}

	// Token: 0x0600488B RID: 18571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CBC")]
	[Address(RVA = "0x2071D30", Offset = "0x2071E31", VA = "0x2071D30")]
	public void actLR(int type)
	{
	}

	// Token: 0x0600488C RID: 18572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CBD")]
	[Address(RVA = "0x2071E50", Offset = "0x2071F51", VA = "0x2071E50")]
	public void FocusThis(bool stat)
	{
	}

	// Token: 0x0600488D RID: 18573 RVA: 0x000178F8 File Offset: 0x00015AF8
	[Token(Token = "0x6003CBE")]
	[Address(RVA = "0x2071EB0", Offset = "0x2071FB1", VA = "0x2071EB0")]
	public LanguageWindow.LngButtonType getButtonType()
	{
		return LanguageWindow.LngButtonType.SettingLanguage;
	}

	// Token: 0x0600488E RID: 18574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CBF")]
	[Address(RVA = "0x2071EC0", Offset = "0x2071FC1", VA = "0x2071EC0")]
	public TitleLangButton()
	{
	}

	// Token: 0x0400A86D RID: 43117
	[Token(Token = "0x4007F04")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LanguageWindow.LngButtonType type;

	// Token: 0x0400A86E RID: 43118
	[Token(Token = "0x4007F05")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LanguageWindow lngWinControl;

	// Token: 0x0400A86F RID: 43119
	[Token(Token = "0x4007F06")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject objOff;

	// Token: 0x0400A870 RID: 43120
	[Token(Token = "0x4007F07")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject objOn;

	// Token: 0x0400A871 RID: 43121
	[Token(Token = "0x4007F08")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject objOn_csrL;

	// Token: 0x0400A872 RID: 43122
	[Token(Token = "0x4007F09")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject objOn_csrR;

	// Token: 0x0400A873 RID: 43123
	[Token(Token = "0x4007F0A")]
	[FieldOffset(Offset = "0x48")]
	private bool OnFocus;

	// Token: 0x0400A874 RID: 43124
	[Token(Token = "0x4007F0B")]
	[FieldOffset(Offset = "0x4C")]
	private float activeTime;
}
