using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000280 RID: 640
[Token(Token = "0x20001FB")]
public class GrapplingManager : SingletonMonoBehaviour<GrapplingManager>
{
	// Token: 0x0600100A RID: 4106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x1FF7210", Offset = "0x1FF7311", VA = "0x1FF7210")]
	private void Update()
	{
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x1FF7510", Offset = "0x1FF7611", VA = "0x1FF7510")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x1FF7640", Offset = "0x1FF7741", VA = "0x1FF7640")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x00007470 File Offset: 0x00005670
	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x1FF7770", Offset = "0x1FF7871", VA = "0x1FF7770")]
	public bool RegistCharaGrapController(ActorID actorID, GrappleController charaGrappleController)
	{
		return default(bool);
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x1FF77E0", Offset = "0x1FF78E1", VA = "0x1FF77E0")]
	public void RemoveCharaGrapController(ActorID actorID)
	{
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00007488 File Offset: 0x00005688
	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x1FF7850", Offset = "0x1FF7951", VA = "0x1FF7850")]
	public bool IsGrappling(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x000074A0 File Offset: 0x000056A0
	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x1FF6B10", Offset = "0x1FF6C11", VA = "0x1FF6B10")]
	public bool DoAttach(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x000074B8 File Offset: 0x000056B8
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x1FF78F0", Offset = "0x1FF79F1", VA = "0x1FF78F0")]
	public bool DoGrap(ActorID actorID, GrapInterface target)
	{
		return default(bool);
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x000074D0 File Offset: 0x000056D0
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x1FF7450", Offset = "0x1FF7551", VA = "0x1FF7450")]
	public bool DoRelease(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x000074E8 File Offset: 0x000056E8
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x1FF7100", Offset = "0x1FF7201", VA = "0x1FF7100")]
	public bool DoThrow(ActorID actorID, float angle, float power, MagicParamID id1, MagicParamID id2)
	{
		return default(bool);
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x00007500 File Offset: 0x00005700
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x1FF79C0", Offset = "0x1FF7AC1", VA = "0x1FF79C0")]
	public bool DoPound(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00007518 File Offset: 0x00005718
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x1FF7A70", Offset = "0x1FF7B71", VA = "0x1FF7A70")]
	public bool DoFlung(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00007530 File Offset: 0x00005730
	[Token(Token = "0x6000E87")]
	[Address(RVA = "0x1FF7B40", Offset = "0x1FF7C41", VA = "0x1FF7B40")]
	public bool DoSwing(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00007548 File Offset: 0x00005748
	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x1FF7C10", Offset = "0x1FF7D11", VA = "0x1FF7C10")]
	public bool DoSlam(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x00007560 File Offset: 0x00005760
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x1FF6F40", Offset = "0x1FF7041", VA = "0x1FF6F40")]
	public bool OnThrowEnd(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00007578 File Offset: 0x00005778
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x1FF6E90", Offset = "0x1FF6F91", VA = "0x1FF6E90")]
	public bool TakeDamage(ActorID actorID, MagicParamID id)
	{
		return default(bool);
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x1FF7CE0", Offset = "0x1FF7DE1", VA = "0x1FF7CE0")]
	public void DoCancel(ActorID actorID)
	{
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x1FF7CF0", Offset = "0x1FF7DF1", VA = "0x1FF7CF0")]
	public void DoCancelAll()
	{
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00007590 File Offset: 0x00005790
	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x1FF67C0", Offset = "0x1FF68C1", VA = "0x1FF67C0")]
	public bool ChangeDirection(ActorID actorID, float rate)
	{
		return default(bool);
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0x1FF7E00", Offset = "0x1FF7F01", VA = "0x1FF7E00")]
	public GrapplingManager()
	{
	}

	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x18")]
	private Register<ActorID, GrappleController> m_Register;

	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<ActorID, float> m_charaTimeCounters;
}
