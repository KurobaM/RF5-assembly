using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006B0 RID: 1712
[Token(Token = "0x20004CA")]
public class AracneFlatWeb : CharacterBase
{
	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x060029A1 RID: 10657 RVA: 0x000103B0 File Offset: 0x0000E5B0
	[Token(Token = "0x1700053D")]
	public override Alliance Alliance
	{
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x243AD50", Offset = "0x243AE51", VA = "0x243AD50", Slot = "8")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002321")]
	[Address(RVA = "0x243A450", Offset = "0x243A551", VA = "0x243A450")]
	public void Setup(Alliance alliance)
	{
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002322")]
	[Address(RVA = "0x243AD60", Offset = "0x243AE61", VA = "0x243AD60")]
	private void Update()
	{
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x000103C8 File Offset: 0x0000E5C8
	[Token(Token = "0x6002323")]
	[Address(RVA = "0x243B040", Offset = "0x243B141", VA = "0x243B040", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002324")]
	[Address(RVA = "0x243AE90", Offset = "0x243AF91", VA = "0x243AE90")]
	public void End()
	{
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002325")]
	[Address(RVA = "0x243B130", Offset = "0x243B231", VA = "0x243B130")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002326")]
	[Address(RVA = "0x243B3D0", Offset = "0x243B4D1", VA = "0x243B3D0")]
	public AracneFlatWeb()
	{
	}

	// Token: 0x040071CA RID: 29130
	[Token(Token = "0x40069AB")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float ToLoopTime;

	// Token: 0x040071CB RID: 29131
	[Token(Token = "0x40069AC")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float DestroyTime;

	// Token: 0x040071CC RID: 29132
	[Token(Token = "0x40069AD")]
	[FieldOffset(Offset = "0x6C")]
	private bool IsLoop;

	// Token: 0x040071CD RID: 29133
	[Token(Token = "0x40069AE")]
	[FieldOffset(Offset = "0x70")]
	private float ElapasedTimer;

	// Token: 0x040071CE RID: 29134
	[Token(Token = "0x40069AF")]
	[FieldOffset(Offset = "0x78")]
	private InstantCountStatus Status;

	// Token: 0x040071CF RID: 29135
	[Token(Token = "0x40069B0")]
	[FieldOffset(Offset = "0x80")]
	private Alliance _Alliance;

	// Token: 0x040071D0 RID: 29136
	[Token(Token = "0x40069B1")]
	[FieldOffset(Offset = "0x88")]
	public Action EndCallback;

	// Token: 0x040071D1 RID: 29137
	[Token(Token = "0x40069B2")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private ParticleSystem StartEffect;

	// Token: 0x040071D2 RID: 29138
	[Token(Token = "0x40069B3")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ParticleSystem LoopEffect;

	// Token: 0x040071D3 RID: 29139
	[Token(Token = "0x40069B4")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private ParticleSystem EndEffect;
}
