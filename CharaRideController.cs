using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000210 RID: 528
[Token(Token = "0x20001AC")]
public abstract class CharaRideController<T> : RideController where T : Character
{
	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D8")]
	public override Actor GetActor
	{
		[Token(Token = "0x60009BD")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D9")]
	public T Character
	{
		[Token(Token = "0x60009BE")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BF")]
	protected override void Awake()
	{
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C0")]
	public override void UpdateFadeAlpha(float alpha)
	{
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C1")]
	public override void UpdateTransform(Vector3 position, Quaternion rotation)
	{
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C2")]
	public override void PlayDamageAction(DamageResult damageResult)
	{
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00005610 File Offset: 0x00003810
	[Token(Token = "0x60009C3")]
	public override bool DoStartRide()
	{
		return default(bool);
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C4")]
	public override void DoEndRide()
	{
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C5")]
	protected CharaRideController()
	{
	}

	// Token: 0x040006C8 RID: 1736
	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T m_chara;

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected Transform m_hips;
}
