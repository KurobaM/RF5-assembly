using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000674 RID: 1652
[Token(Token = "0x2000499")]
public class DamageHpPercentChecker
{
	// Token: 0x17000688 RID: 1672
	// (get) Token: 0x06002900 RID: 10496 RVA: 0x00010140 File Offset: 0x0000E340
	// (set) Token: 0x06002901 RID: 10497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000536")]
	public bool IsHit
	{
		[Token(Token = "0x60022A7")]
		[Address(RVA = "0x1DA1470", Offset = "0x1DA1571", VA = "0x1DA1470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A22A0", Offset = "0x1A23A1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60022A8")]
		[Address(RVA = "0x1DA1480", Offset = "0x1DA1581", VA = "0x1DA1480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A22B0", Offset = "0x1A23B1")]
		private set
		{
		}
	}

	// Token: 0x06002902 RID: 10498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A9")]
	[Address(RVA = "0x1DA1490", Offset = "0x1DA1591", VA = "0x1DA1490")]
	public void Setup(float removeTime, float hitHPPercent, float maxHP)
	{
	}

	// Token: 0x06002903 RID: 10499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AA")]
	[Address(RVA = "0x1DA1520", Offset = "0x1DA1621", VA = "0x1DA1520")]
	public void Reset()
	{
	}

	// Token: 0x06002904 RID: 10500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AB")]
	[Address(RVA = "0x1DA1580", Offset = "0x1DA1681", VA = "0x1DA1580")]
	public void Update()
	{
	}

	// Token: 0x06002905 RID: 10501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x1DA1750", Offset = "0x1DA1851", VA = "0x1DA1750")]
	public void TakeDamage(int amount)
	{
	}

	// Token: 0x06002906 RID: 10502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x1DA1880", Offset = "0x1DA1981", VA = "0x1DA1880")]
	public DamageHpPercentChecker()
	{
	}

	// Token: 0x04007098 RID: 28824
	[Token(Token = "0x400689A")]
	[FieldOffset(Offset = "0x10")]
	private List<DamageHpPercentChecker.DamageHPPercentChecker> DamageHPPercentCheckerList;

	// Token: 0x04007099 RID: 28825
	[Token(Token = "0x400689B")]
	[FieldOffset(Offset = "0x18")]
	private float RemoveTime;

	// Token: 0x0400709A RID: 28826
	[Token(Token = "0x400689C")]
	[FieldOffset(Offset = "0x1C")]
	private float HitHPPercent;

	// Token: 0x0400709B RID: 28827
	[Token(Token = "0x400689D")]
	[FieldOffset(Offset = "0x20")]
	private float MaxHP;

	// Token: 0x0400709C RID: 28828
	[Token(Token = "0x400689E")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168AD0", Offset = "0x168BD1")]
	private bool <IsHit>k__BackingField;

	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2001164")]
	private class DamageHPPercentChecker
	{
		// Token: 0x06002907 RID: 10503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007144")]
		[Address(RVA = "0x1DA1870", Offset = "0x1DA1971", VA = "0x1DA1870")]
		public DamageHPPercentChecker()
		{
		}

		// Token: 0x0400709D RID: 28829
		[Token(Token = "0x4019471")]
		[FieldOffset(Offset = "0x10")]
		public float DamageAmount;

		// Token: 0x0400709E RID: 28830
		[Token(Token = "0x4019472")]
		[FieldOffset(Offset = "0x14")]
		public float Timer;
	}

	// Token: 0x02000676 RID: 1654
	[Token(Token = "0x2001165")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158230", Offset = "0x158331")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002909 RID: 10505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007146")]
		[Address(RVA = "0x1DA1970", Offset = "0x1DA1A71", VA = "0x1DA1970")]
		public <>c()
		{
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x6007147")]
		[Address(RVA = "0x1DA1980", Offset = "0x1DA1A81", VA = "0x1DA1980")]
		internal bool <Update>b__11_0(DamageHpPercentChecker.DamageHPPercentChecker listInChecker)
		{
			return default(bool);
		}

		// Token: 0x0400709F RID: 28831
		[Token(Token = "0x4019473")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DamageHpPercentChecker.<>c <>9;

		// Token: 0x040070A0 RID: 28832
		[Token(Token = "0x4019474")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<DamageHpPercentChecker.DamageHPPercentChecker> <>9__11_0;
	}
}
