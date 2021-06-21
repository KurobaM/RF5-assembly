using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000924 RID: 2340
[Token(Token = "0x2000620")]
public class AdvStaffRollControl : MonoBehaviour
{
	// Token: 0x06003D4E RID: 15694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003386")]
	[Address(RVA = "0x2434330", Offset = "0x2434431", VA = "0x2434330")]
	public void StartStaffRoll(float time)
	{
	}

	// Token: 0x06003D4F RID: 15695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003387")]
	[Address(RVA = "0x2434940", Offset = "0x2434A41", VA = "0x2434940")]
	public void EndStaffRoll()
	{
	}

	// Token: 0x06003D50 RID: 15696 RVA: 0x00015408 File Offset: 0x00013608
	[Token(Token = "0x6003388")]
	[Address(RVA = "0x2434CA0", Offset = "0x2434DA1", VA = "0x2434CA0")]
	public bool getScrollFlg()
	{
		return default(bool);
	}

	// Token: 0x06003D51 RID: 15697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003389")]
	[Address(RVA = "0x2434CB0", Offset = "0x2434DB1", VA = "0x2434CB0")]
	private void Awake()
	{
	}

	// Token: 0x06003D52 RID: 15698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338A")]
	[Address(RVA = "0x2434E30", Offset = "0x2434F31", VA = "0x2434E30")]
	private void Update()
	{
	}

	// Token: 0x06003D53 RID: 15699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338B")]
	[Address(RVA = "0x2435210", Offset = "0x2435311", VA = "0x2435210")]
	public AdvStaffRollControl()
	{
	}

	// Token: 0x04007F97 RID: 32663
	[Token(Token = "0x4007319")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image[] imageList;

	// Token: 0x04007F98 RID: 32664
	[Token(Token = "0x400731A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite[] staffrollList;

	// Token: 0x04007F99 RID: 32665
	[Token(Token = "0x400731B")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 ScreenSize;

	// Token: 0x04007F9A RID: 32666
	[Token(Token = "0x400731C")]
	[FieldOffset(Offset = "0x30")]
	private int cnt;

	// Token: 0x04007F9B RID: 32667
	[Token(Token = "0x400731D")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform[] imageRect;

	// Token: 0x04007F9C RID: 32668
	[Token(Token = "0x400731E")]
	private const int base_scale = 2;

	// Token: 0x04007F9D RID: 32669
	[Token(Token = "0x400731F")]
	[FieldOffset(Offset = "0x40")]
	private int imageCntMax;

	// Token: 0x04007F9E RID: 32670
	[Token(Token = "0x4007320")]
	[FieldOffset(Offset = "0x44")]
	private bool scrollFlg;

	// Token: 0x04007F9F RID: 32671
	[Token(Token = "0x4007321")]
	[FieldOffset(Offset = "0x48")]
	private float scroll_spd;

	// Token: 0x04007FA0 RID: 32672
	[Token(Token = "0x4007322")]
	[FieldOffset(Offset = "0x4C")]
	private float scroll_time;

	// Token: 0x04007FA1 RID: 32673
	[Token(Token = "0x4007323")]
	[FieldOffset(Offset = "0x50")]
	private float scroll_hmax;

	// Token: 0x04007FA2 RID: 32674
	[Token(Token = "0x4007324")]
	[FieldOffset(Offset = "0x54")]
	private float time_count;

	// Token: 0x04007FA3 RID: 32675
	[Token(Token = "0x4007325")]
	[FieldOffset(Offset = "0x58")]
	private int lastImgNo;

	// Token: 0x02000925 RID: 2341
	[Token(Token = "0x2001286")]
	public enum StaffRollType
	{
		// Token: 0x04007FA5 RID: 32677
		[Token(Token = "0x40198E2")]
		FakeStaffRoll,
		// Token: 0x04007FA6 RID: 32678
		[Token(Token = "0x40198E3")]
		MainStaffRoll,
		// Token: 0x04007FA7 RID: 32679
		[Token(Token = "0x40198E4")]
		LoveStaffRoll
	}
}
