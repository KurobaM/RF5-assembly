using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000536 RID: 1334
[Token(Token = "0x20003C7")]
public class PlayerSnowball : MonoBehaviour
{
	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x0600204F RID: 8271 RVA: 0x0000D530 File Offset: 0x0000B730
	// (set) Token: 0x06002050 RID: 8272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700043D")]
	public bool EnableMove
	{
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x2497CB0", Offset = "0x2497DB1", VA = "0x2497CB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0330", Offset = "0x1A0431")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x2497CC0", Offset = "0x2497DC1", VA = "0x2497CC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0340", Offset = "0x1A0441")]
		private set
		{
		}
	}

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x06002051 RID: 8273 RVA: 0x0000D548 File Offset: 0x0000B748
	// (set) Token: 0x06002052 RID: 8274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700043E")]
	public bool IsSpeedUp
	{
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x2497CD0", Offset = "0x2497DD1", VA = "0x2497CD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0350", Offset = "0x1A0451")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x2497CE0", Offset = "0x2497DE1", VA = "0x2497CE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0360", Offset = "0x1A0461")]
		private set
		{
		}
	}

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x06002053 RID: 8275 RVA: 0x0000D560 File Offset: 0x0000B760
	// (set) Token: 0x06002054 RID: 8276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700043F")]
	public bool IsInvincible
	{
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x2497CF0", Offset = "0x2497DF1", VA = "0x2497CF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0370", Offset = "0x1A0471")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x2497D00", Offset = "0x2497E01", VA = "0x2497D00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0380", Offset = "0x1A0481")]
		set
		{
		}
	}

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x06002055 RID: 8277 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002056 RID: 8278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000440")]
	public ParticleSystem SpeedUpEffect
	{
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x2497D10", Offset = "0x2497E11", VA = "0x2497D10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0390", Offset = "0x1A0491")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x2497D20", Offset = "0x2497E21", VA = "0x2497D20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A03A0", Offset = "0x1A04A1")]
		set
		{
		}
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x2497D30", Offset = "0x2497E31", VA = "0x2497D30")]
	private void Update()
	{
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x2498570", Offset = "0x2498671", VA = "0x2498570")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B7A")]
	[Address(RVA = "0x24992B0", Offset = "0x24993B1", VA = "0x24992B0")]
	private void StartSpeedUp()
	{
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B7B")]
	[Address(RVA = "0x2498230", Offset = "0x2498331", VA = "0x2498230")]
	private void UpdateSpeedUp()
	{
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B7C")]
	[Address(RVA = "0x2499310", Offset = "0x2499411", VA = "0x2499310")]
	private void ResetMove()
	{
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B7D")]
	[Address(RVA = "0x2499330", Offset = "0x2499431", VA = "0x2499330")]
	private void ResetInvincible()
	{
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B7E")]
	[Address(RVA = "0x2499340", Offset = "0x2499441", VA = "0x2499340")]
	public PlayerSnowball()
	{
	}

	// Token: 0x04006731 RID: 26417
	[Token(Token = "0x4006136")]
	[FieldOffset(Offset = "0x18")]
	public float Scale;

	// Token: 0x04006732 RID: 26418
	[Token(Token = "0x4006137")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165C70", Offset = "0x165D71")]
	private bool <EnableMove>k__BackingField;

	// Token: 0x04006733 RID: 26419
	[Token(Token = "0x4006138")]
	[FieldOffset(Offset = "0x1D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165C80", Offset = "0x165D81")]
	private bool <IsSpeedUp>k__BackingField;

	// Token: 0x04006734 RID: 26420
	[Token(Token = "0x4006139")]
	[FieldOffset(Offset = "0x1E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165C90", Offset = "0x165D91")]
	private bool <IsInvincible>k__BackingField;

	// Token: 0x04006735 RID: 26421
	[Token(Token = "0x400613A")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165CA0", Offset = "0x165DA1")]
	private ParticleSystem <SpeedUpEffect>k__BackingField;

	// Token: 0x04006736 RID: 26422
	[Token(Token = "0x400613B")]
	private const float SCALE_MIN = 1f;

	// Token: 0x04006737 RID: 26423
	[Token(Token = "0x400613C")]
	private const float SNOWBALL_BASE_DISTANCE = 0.5f;

	// Token: 0x04006738 RID: 26424
	[Token(Token = "0x400613D")]
	private const float SNOWBALL_RADIUS = 0.5f;

	// Token: 0x04006739 RID: 26425
	[Token(Token = "0x400613E")]
	private const float INVINCIBLE_TIME = 3f;

	// Token: 0x0400673A RID: 26426
	[Token(Token = "0x400613F")]
	[FieldOffset(Offset = "0x28")]
	private float speedUpTimeCount;

	// Token: 0x0400673B RID: 26427
	[Token(Token = "0x4006140")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 pastAxis;

	// Token: 0x0400673C RID: 26428
	[Token(Token = "0x4006141")]
	[FieldOffset(Offset = "0x38")]
	private float rotateSpeed;

	// Token: 0x0400673D RID: 26429
	[Token(Token = "0x4006142")]
	[FieldOffset(Offset = "0x3C")]
	private float effectScale;

	// Token: 0x0400673E RID: 26430
	[Token(Token = "0x4006143")]
	[FieldOffset(Offset = "0x40")]
	private float effectHeight;

	// Token: 0x0400673F RID: 26431
	[Token(Token = "0x4006144")]
	[FieldOffset(Offset = "0x44")]
	private float effectHeightScale;

	// Token: 0x04006740 RID: 26432
	[Token(Token = "0x4006145")]
	[FieldOffset(Offset = "0x48")]
	private MonsterControllerBase HitMocomoco;
}
