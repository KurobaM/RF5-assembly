using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018C RID: 396
[Token(Token = "0x2000137")]
public class BulletLaserNew : BulletSubModule
{
	// Token: 0x1700019D RID: 413
	// (get) Token: 0x0600082C RID: 2092 RVA: 0x00004CB0 File Offset: 0x00002EB0
	// (set) Token: 0x0600082D RID: 2093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000188")]
	public bool Penetrate
	{
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x21968B0", Offset = "0x21969B1", VA = "0x21968B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB20", Offset = "0x19AC21")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x21968C0", Offset = "0x21969C1", VA = "0x21968C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB30", Offset = "0x19AC31")]
		set
		{
		}
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x21968D0", Offset = "0x21969D1", VA = "0x21968D0", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x2196960", Offset = "0x2196A61", VA = "0x2196960", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000700")]
	[Address(RVA = "0x2196E70", Offset = "0x2196F71", VA = "0x2196E70")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000701")]
	[Address(RVA = "0x2197280", Offset = "0x2197381", VA = "0x2197280")]
	public BulletLaserNew()
	{
	}

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public ParticleDestroy mainParticle;

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public ParticleDestroy lastParticle;

	// Token: 0x040004CD RID: 1229
	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float radius;

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float maxLength;

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float speed;

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public LayerMask hitLayerMask;

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public QueryTriggerInteraction queryTriggerInteraction;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0x44")]
	private float currentLength;

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C5E0", Offset = "0x15C6E1")]
	private bool <Penetrate>k__BackingField;
}
