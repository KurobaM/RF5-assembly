using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AEE RID: 2798
[Token(Token = "0x200074F")]
public class UILogoControl : MonoBehaviour
{
	// Token: 0x1700099C RID: 2460
	// (get) Token: 0x06004893 RID: 18579 RVA: 0x00017910 File Offset: 0x00015B10
	// (set) Token: 0x06004894 RID: 18580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007B0")]
	public static bool IsEnd
	{
		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x201F810", Offset = "0x201F911", VA = "0x201F810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8460", Offset = "0x1A8561")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x201F860", Offset = "0x201F961", VA = "0x201F860")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8470", Offset = "0x1A8571")]
		private set
		{
		}
	}

	// Token: 0x06004895 RID: 18581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CC6")]
	[Address(RVA = "0x201F8C0", Offset = "0x201F9C1", VA = "0x201F8C0")]
	private void Start()
	{
	}

	// Token: 0x06004896 RID: 18582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CC7")]
	[Address(RVA = "0x201FA10", Offset = "0x201FB11", VA = "0x201FA10")]
	private void Update()
	{
	}

	// Token: 0x06004897 RID: 18583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CC8")]
	[Address(RVA = "0x201F9F0", Offset = "0x201FAF1", VA = "0x201F9F0")]
	private void SetLogoImg(Sprite spr)
	{
	}

	// Token: 0x06004898 RID: 18584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CC9")]
	[Address(RVA = "0x201FF30", Offset = "0x2020031", VA = "0x201FF30")]
	private void OnLogoImg(bool flg)
	{
	}

	// Token: 0x06004899 RID: 18585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CCA")]
	[Address(RVA = "0x201F9D0", Offset = "0x201FAD1", VA = "0x201F9D0")]
	public void OnTouchScreen(bool flg)
	{
	}

	// Token: 0x0600489A RID: 18586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CCB")]
	[Address(RVA = "0x201FF40", Offset = "0x2020041", VA = "0x201FF40")]
	public void touchStartUpButton()
	{
	}

	// Token: 0x0600489B RID: 18587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CCC")]
	[Address(RVA = "0x201FF50", Offset = "0x2020051", VA = "0x201FF50")]
	public UILogoControl()
	{
	}

	// Token: 0x0400A880 RID: 43136
	[Token(Token = "0x4007F13")]
	private const float LOGO_TIME = 2f;

	// Token: 0x0400A881 RID: 43137
	[Token(Token = "0x4007F14")]
	private const float LOGOBTN_TIME = 0.5f;

	// Token: 0x0400A882 RID: 43138
	[Token(Token = "0x4007F15")]
	private const float FADE_TIME_S = 0.5f;

	// Token: 0x0400A883 RID: 43139
	[Token(Token = "0x4007F16")]
	private const float STAY_TIME_S = 1f;

	// Token: 0x0400A884 RID: 43140
	[Token(Token = "0x4007F17")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image LogoBg;

	// Token: 0x0400A885 RID: 43141
	[Token(Token = "0x4007F18")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite[] m_CompanyImg;

	// Token: 0x0400A886 RID: 43142
	[Token(Token = "0x4007F19")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject touchScreen;

	// Token: 0x0400A887 RID: 43143
	[Token(Token = "0x4007F1A")]
	[FieldOffset(Offset = "0x30")]
	private UILogoControl.MODE m_mode;

	// Token: 0x0400A888 RID: 43144
	[Token(Token = "0x4007F1B")]
	[FieldOffset(Offset = "0x34")]
	private float m_stayTime;

	// Token: 0x0400A889 RID: 43145
	[Token(Token = "0x4007F1C")]
	[FieldOffset(Offset = "0x38")]
	private bool m_touchBtn;

	// Token: 0x0400A88A RID: 43146
	[Token(Token = "0x4007F1D")]
	[FieldOffset(Offset = "0x3C")]
	private int m_logoCnt;

	// Token: 0x0400A88B RID: 43147
	[Token(Token = "0x4007F1E")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174240", Offset = "0x174341")]
	private static bool <IsEnd>k__BackingField;

	// Token: 0x02000AEF RID: 2799
	[Token(Token = "0x2001321")]
	private enum MODE
	{
		// Token: 0x0400A88D RID: 43149
		[Token(Token = "0x401B5D1")]
		NONE,
		// Token: 0x0400A88E RID: 43150
		[Token(Token = "0x401B5D2")]
		INIT_LOGO,
		// Token: 0x0400A88F RID: 43151
		[Token(Token = "0x401B5D3")]
		INPUT_LOGO,
		// Token: 0x0400A890 RID: 43152
		[Token(Token = "0x401B5D4")]
		FADE_LOGO,
		// Token: 0x0400A891 RID: 43153
		[Token(Token = "0x401B5D5")]
		CHNG_LOGO,
		// Token: 0x0400A892 RID: 43154
		[Token(Token = "0x401B5D6")]
		WAIT_LOGO,
		// Token: 0x0400A893 RID: 43155
		[Token(Token = "0x401B5D7")]
		END_LOGO,
		// Token: 0x0400A894 RID: 43156
		[Token(Token = "0x401B5D8")]
		END_FADE,
		// Token: 0x0400A895 RID: 43157
		[Token(Token = "0x401B5D9")]
		END,
		// Token: 0x0400A896 RID: 43158
		[Token(Token = "0x401B5DA")]
		END_
	}
}
