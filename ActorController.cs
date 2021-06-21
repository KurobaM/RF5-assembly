using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E7 RID: 231
[Token(Token = "0x20000BA")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x144CB0", Offset = "0x144DB1")]
public abstract class ActorController : CharacterBase
{
	// Token: 0x17000112 RID: 274
	// (get) Token: 0x0600049A RID: 1178 RVA: 0x00003AE0 File Offset: 0x00001CE0
	[Token(Token = "0x1700010F")]
	public ActorID ActorID
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1D4A340", Offset = "0x1D4A441", VA = "0x1D4A340")]
		get
		{
			return ActorID.act000;
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000110")]
	public virtual Actor Actor
	{
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1D4A350", Offset = "0x1D4A451", VA = "0x1D4A350", Slot = "15")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x0600049C RID: 1180 RVA: 0x00003AF8 File Offset: 0x00001CF8
	[Token(Token = "0x17000111")]
	public virtual bool IsActive
	{
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1D4A480", Offset = "0x1D4A581", VA = "0x1D4A480", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x0600049D RID: 1181 RVA: 0x00003B10 File Offset: 0x00001D10
	// (set) Token: 0x0600049E RID: 1182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000112")]
	public bool DispOn
	{
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1D4A4D0", Offset = "0x1D4A5D1", VA = "0x1D4A4D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1D4A520", Offset = "0x1D4A621", VA = "0x1D4A520")]
		set
		{
		}
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x1D4A570", Offset = "0x1D4A671", VA = "0x1D4A570", Slot = "13")]
	public override void ResetAnimator()
	{
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x1D4A810", Offset = "0x1D4A911", VA = "0x1D4A810")]
	public void SwicthActorBase(ActorType actor_type)
	{
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x1D4A870", Offset = "0x1D4A971", VA = "0x1D4A870", Slot = "17")]
	public virtual void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x1D4A9D0", Offset = "0x1D4AAD1", VA = "0x1D4A9D0", Slot = "18")]
	public virtual void BeforeSwitchActorBase(bool on)
	{
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x1D49810", Offset = "0x1D49911", VA = "0x1D49810")]
	public void RemoveAsset()
	{
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x1D4A9E0", Offset = "0x1D4AAE1", VA = "0x1D4A9E0", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x1D4AAA0", Offset = "0x1D4ABA1", VA = "0x1D4AAA0", Slot = "19")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x1D4AB20", Offset = "0x1D4AC21", VA = "0x1D4AB20")]
	public void SetActorId(ActorID actor_id)
	{
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x1D49270", Offset = "0x1D49371", VA = "0x1D49270")]
	public void SetActorId(ActorID actor_id, int id)
	{
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x1D4AB30", Offset = "0x1D4AC31", VA = "0x1D4AB30")]
	protected ActorController()
	{
	}

	// Token: 0x04000288 RID: 648
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15B980", Offset = "0x15BA81")]
	[SerializeField]
	private ActorID actorId;

	// Token: 0x04000289 RID: 649
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private RebindFrequency rebindFrequency;

	// Token: 0x0400028A RID: 650
	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x6C")]
	private int LoaderId;
}
