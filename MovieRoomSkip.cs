using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000A8A RID: 2698
[Token(Token = "0x2000711")]
public class MovieRoomSkip : MonoBehaviour
{
	// Token: 0x0600464E RID: 17998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD2")]
	[Address(RVA = "0x1E14F10", Offset = "0x1E15011", VA = "0x1E14F10")]
	public void IsMoviePlaying(UnityAction _call_back, bool _enable_skip = true)
	{
	}

	// Token: 0x17000973 RID: 2419
	// (get) Token: 0x0600464F RID: 17999 RVA: 0x00017268 File Offset: 0x00015468
	// (set) Token: 0x06004650 RID: 18000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000795")]
	public bool IsReady
	{
		[Token(Token = "0x6003AD3")]
		[Address(RVA = "0x1E172D0", Offset = "0x1E173D1", VA = "0x1E172D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E80", Offset = "0x1A7F81")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003AD4")]
		[Address(RVA = "0x1E172E0", Offset = "0x1E173E1", VA = "0x1E172E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E90", Offset = "0x1A7F91")]
		set
		{
		}
	}

	// Token: 0x06004651 RID: 18001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD5")]
	[Address(RVA = "0x1E172F0", Offset = "0x1E173F1", VA = "0x1E172F0")]
	private void Start()
	{
	}

	// Token: 0x06004652 RID: 18002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD6")]
	[Address(RVA = "0x1E17480", Offset = "0x1E17581", VA = "0x1E17480")]
	private void Update()
	{
	}

	// Token: 0x06004653 RID: 18003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD7")]
	[Address(RVA = "0x1E178B0", Offset = "0x1E179B1", VA = "0x1E178B0")]
	public MovieRoomSkip()
	{
	}

	// Token: 0x0400A54D RID: 42317
	[Token(Token = "0x4007CDF")]
	[FieldOffset(Offset = "0x18")]
	public Key ActiveKey;

	// Token: 0x0400A54E RID: 42318
	[Token(Token = "0x4007CE0")]
	[FieldOffset(Offset = "0x20")]
	private UnityAction action;

	// Token: 0x0400A54F RID: 42319
	[Token(Token = "0x4007CE1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Sprite> dotSprite;

	// Token: 0x0400A550 RID: 42320
	[Token(Token = "0x4007CE2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Image> dotImage;

	// Token: 0x0400A551 RID: 42321
	[Token(Token = "0x4007CE3")]
	[FieldOffset(Offset = "0x38")]
	private CanvasGroup canvasGroup;

	// Token: 0x0400A552 RID: 42322
	[Token(Token = "0x4007CE4")]
	private const float FADE_SPEED = 5f;

	// Token: 0x0400A553 RID: 42323
	[Token(Token = "0x4007CE5")]
	private const float ACTIVE_TIME = 2f;

	// Token: 0x0400A554 RID: 42324
	[Token(Token = "0x4007CE6")]
	[FieldOffset(Offset = "0x40")]
	private float activeTimeCount;

	// Token: 0x0400A555 RID: 42325
	[Token(Token = "0x4007CE7")]
	private const float SKIP_TIME = 0.5f;

	// Token: 0x0400A556 RID: 42326
	[Token(Token = "0x4007CE8")]
	[FieldOffset(Offset = "0x44")]
	private float animInterval;

	// Token: 0x0400A557 RID: 42327
	[Token(Token = "0x4007CE9")]
	[FieldOffset(Offset = "0x48")]
	private float skipTimeCount;

	// Token: 0x0400A558 RID: 42328
	[Token(Token = "0x4007CEA")]
	[FieldOffset(Offset = "0x4C")]
	private int dot;

	// Token: 0x0400A559 RID: 42329
	[Token(Token = "0x4007CEB")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1730C0", Offset = "0x1731C1")]
	private bool <IsReady>k__BackingField;

	// Token: 0x0400A55A RID: 42330
	[Token(Token = "0x4007CEC")]
	[FieldOffset(Offset = "0x54")]
	private MovieRoomSkip.State state;

	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x20012FB")]
	public enum OnOff
	{
		// Token: 0x0400A55C RID: 42332
		[Token(Token = "0x401B4D2")]
		On,
		// Token: 0x0400A55D RID: 42333
		[Token(Token = "0x401B4D3")]
		Off
	}

	// Token: 0x02000A8C RID: 2700
	[Token(Token = "0x20012FC")]
	private enum State
	{
		// Token: 0x0400A55F RID: 42335
		[Token(Token = "0x401B4D5")]
		Wait,
		// Token: 0x0400A560 RID: 42336
		[Token(Token = "0x401B4D6")]
		Active,
		// Token: 0x0400A561 RID: 42337
		[Token(Token = "0x401B4D7")]
		Skipped
	}
}
