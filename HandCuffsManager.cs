using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000281 RID: 641
[Token(Token = "0x20001FC")]
public class HandCuffsManager : SingletonMonoBehaviour<HandCuffsManager>
{
	// Token: 0x0600101E RID: 4126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0x24E5430", Offset = "0x24E5531", VA = "0x24E5430")]
	private void Update()
	{
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E90")]
	[Address(RVA = "0x24E5630", Offset = "0x24E5731", VA = "0x24E5630")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x000075A8 File Offset: 0x000057A8
	[Token(Token = "0x6000E91")]
	[Address(RVA = "0x24E3E90", Offset = "0x24E3F91", VA = "0x24E3E90")]
	public bool Regist(ActorID actorID, HandCuffsController controller)
	{
		return default(bool);
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x000075C0 File Offset: 0x000057C0
	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x24E4150", Offset = "0x24E4251", VA = "0x24E4150")]
	public bool Remove(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x24E5790", Offset = "0x24E5891", VA = "0x24E5790")]
	public void Initialize(ActorID actorID)
	{
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x000075D8 File Offset: 0x000057D8
	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x24E5850", Offset = "0x24E5951", VA = "0x24E5850")]
	public bool OnAim(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x000075F0 File Offset: 0x000057F0
	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x24E5970", Offset = "0x24E5A71", VA = "0x24E5970")]
	public bool OnThrow(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x24E5A60", Offset = "0x24E5B61", VA = "0x24E5A60")]
	public void DoCancel(ActorID actorID, bool immediate = false)
	{
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x24E5B30", Offset = "0x24E5C31", VA = "0x24E5B30")]
	public void DoCancelAll(bool immediate = false)
	{
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x24E5C50", Offset = "0x24E5D51", VA = "0x24E5C50")]
	public void DoShot(ActorID actorID, bool charge)
	{
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00007608 File Offset: 0x00005808
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x24E5D20", Offset = "0x24E5E21", VA = "0x24E5D20")]
	public bool IsPlaying(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00007620 File Offset: 0x00005820
	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x24E5DF0", Offset = "0x24E5EF1", VA = "0x24E5DF0")]
	public bool IsAiming(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x24E5EC0", Offset = "0x24E5FC1", VA = "0x24E5EC0")]
	public Collider GetAimTarget(ActorID actorID)
	{
		return null;
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x00007638 File Offset: 0x00005838
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x24E5F90", Offset = "0x24E6091", VA = "0x24E5F90")]
	public bool CanPlay(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00007650 File Offset: 0x00005850
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x24E60A0", Offset = "0x24E61A1", VA = "0x24E60A0")]
	public bool CanThrow(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00007668 File Offset: 0x00005868
	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x24E6170", Offset = "0x24E6271", VA = "0x24E6170")]
	public float CoolTimeNow(ActorID actorID)
	{
		return 0f;
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00007680 File Offset: 0x00005880
	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x24E6230", Offset = "0x24E6331", VA = "0x24E6230")]
	public float CoolTimeMax(ActorID actorID)
	{
		return 0f;
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00007698 File Offset: 0x00005898
	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x24E62F0", Offset = "0x24E63F1", VA = "0x24E62F0")]
	public float CoolTimePer(ActorID actorID)
	{
		return 0f;
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0x24E63C0", Offset = "0x24E64C1", VA = "0x24E63C0")]
	public HandCuffsManager()
	{
	}

	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x18")]
	private Register<ActorID, HandCuffsController> m_Register;

	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<ActorID, SphereCollider> m_AimTargets;
}
