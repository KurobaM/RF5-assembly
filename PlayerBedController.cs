using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005BB RID: 1467
[Token(Token = "0x200041D")]
public class PlayerBedController : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x060023F5 RID: 9205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0x2144280", Offset = "0x2144381", VA = "0x2144280", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x170005E0 RID: 1504
	// (get) Token: 0x060023F6 RID: 9206 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
	[Token(Token = "0x170004B2")]
	public bool Focusable
	{
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x2144370", Offset = "0x2144471", VA = "0x2144370", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
	[Token(Token = "0x170004B3")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x2144430", Offset = "0x2144531", VA = "0x2144430", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x060023F8 RID: 9208 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
	[Token(Token = "0x170004B4")]
	public int FocusPriority
	{
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x2144440", Offset = "0x2144541", VA = "0x2144440", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170005E3 RID: 1507
	// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0000EA00 File Offset: 0x0000CC00
	[Token(Token = "0x170004B5")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x2144450", Offset = "0x2144551", VA = "0x2144450", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E40")]
	[Address(RVA = "0x2144460", Offset = "0x2144561", VA = "0x2144460", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E41")]
	[Address(RVA = "0x2144470", Offset = "0x2144571", VA = "0x2144470", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x060023FC RID: 9212 RVA: 0x0000EA18 File Offset: 0x0000CC18
	[Token(Token = "0x6001E42")]
	[Address(RVA = "0x2144480", Offset = "0x2144581", VA = "0x2144480", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E43")]
	[Address(RVA = "0x2144540", Offset = "0x2144641", VA = "0x2144540", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E44")]
	[Address(RVA = "0x2144900", Offset = "0x2144A01", VA = "0x2144900")]
	private void Unmarried()
	{
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E45")]
	[Address(RVA = "0x2144840", Offset = "0x2144941", VA = "0x2144840")]
	private void Married()
	{
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x0000EA30 File Offset: 0x0000CC30
	[Token(Token = "0x6001E46")]
	[Address(RVA = "0x21445D0", Offset = "0x21446D1", VA = "0x21445D0")]
	private bool BedJudgment()
	{
		return default(bool);
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E47")]
	[Address(RVA = "0x2144B50", Offset = "0x2144C51", VA = "0x2144B50")]
	public void OnSelected(int select)
	{
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E48")]
	[Address(RVA = "0x2144CB0", Offset = "0x2144DB1", VA = "0x2144CB0")]
	public static void PlayerSleep()
	{
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E49")]
	[Address(RVA = "0x2144D10", Offset = "0x2144E11", VA = "0x2144D10")]
	public static void ProcessingPlayerSleep()
	{
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x0000EA48 File Offset: 0x0000CC48
	[Token(Token = "0x6001E4A")]
	[Address(RVA = "0x2144510", Offset = "0x2144611", VA = "0x2144510", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E4B")]
	[Address(RVA = "0x2144E90", Offset = "0x2144F91", VA = "0x2144E90", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0x2144EE0", Offset = "0x2144FE1", VA = "0x2144EE0", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x0000EA60 File Offset: 0x0000CC60
	[Token(Token = "0x6001E4D")]
	[Address(RVA = "0x2144EF0", Offset = "0x2144FF1", VA = "0x2144EF0", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0x2144F00", Offset = "0x2145001", VA = "0x2144F00")]
	public PlayerBedController()
	{
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0x2144F10", Offset = "0x2145011", VA = "0x2144F10", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x2144F20", Offset = "0x2145021", VA = "0x2144F20", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04006B77 RID: 27511
	[Token(Token = "0x40064CE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float AllowDot;
}
