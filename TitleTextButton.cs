using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AEC RID: 2796
[Token(Token = "0x200074E")]
public class TitleTextButton : MonoBehaviour
{
	// Token: 0x0600488F RID: 18575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CC0")]
	[Address(RVA = "0x2074910", Offset = "0x2074A11", VA = "0x2074910")]
	public void FocusThis(bool stat)
	{
	}

	// Token: 0x06004890 RID: 18576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CC1")]
	[Address(RVA = "0x2074970", Offset = "0x2074A71", VA = "0x2074970")]
	private void Start()
	{
	}

	// Token: 0x06004891 RID: 18577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CC2")]
	[Address(RVA = "0x2074AB0", Offset = "0x2074BB1", VA = "0x2074AB0")]
	private void Update()
	{
	}

	// Token: 0x06004892 RID: 18578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CC3")]
	[Address(RVA = "0x2074AC0", Offset = "0x2074BC1", VA = "0x2074AC0")]
	public TitleTextButton()
	{
	}

	// Token: 0x0400A875 RID: 43125
	[Token(Token = "0x4007F0C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TitleTextButton.TextButtonType type;

	// Token: 0x0400A876 RID: 43126
	[Token(Token = "0x4007F0D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject objOff;

	// Token: 0x0400A877 RID: 43127
	[Token(Token = "0x4007F0E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject objOn;

	// Token: 0x0400A878 RID: 43128
	[Token(Token = "0x4007F0F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text objText;

	// Token: 0x0400A879 RID: 43129
	[Token(Token = "0x4007F10")]
	[FieldOffset(Offset = "0x38")]
	private bool OnFocus;

	// Token: 0x0400A87A RID: 43130
	[Token(Token = "0x4007F11")]
	[FieldOffset(Offset = "0x3C")]
	private float activeTime;

	// Token: 0x0400A87B RID: 43131
	[Token(Token = "0x4007F12")]
	[FieldOffset(Offset = "0x40")]
	private string[] textDataList;

	// Token: 0x02000AED RID: 2797
	[Token(Token = "0x2001320")]
	public enum TextButtonType
	{
		// Token: 0x0400A87D RID: 43133
		[Token(Token = "0x401B5CD")]
		Yes,
		// Token: 0x0400A87E RID: 43134
		[Token(Token = "0x401B5CE")]
		No,
		// Token: 0x0400A87F RID: 43135
		[Token(Token = "0x401B5CF")]
		Ok
	}
}
