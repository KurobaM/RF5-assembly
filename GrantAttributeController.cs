using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022B RID: 555
[Token(Token = "0x20001BE")]
public abstract class GrantAttributeController : MonoBehaviour
{
	// Token: 0x17000278 RID: 632
	// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000061F8 File Offset: 0x000043F8
	// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000258")]
	public AttackAttribute CurrentAttribute
	{
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x1FF4340", Offset = "0x1FF4441", VA = "0x1FF4340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BBB0", Offset = "0x19BCB1")]
		get
		{
			return (AttackAttribute)0;
		}
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x1FF4350", Offset = "0x1FF4451", VA = "0x1FF4350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BBC0", Offset = "0x19BCC1")]
		protected set
		{
		}
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000259")]
	public Dictionary<AttackAttribute, float> Timer
	{
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x1FF4360", Offset = "0x1FF4461", VA = "0x1FF4360")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x06000CD0 RID: 3280
	[Token(Token = "0x1700025A")]
	protected abstract Transform EffectPoint { [Token(Token = "0x6000B74")] get; }

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00006210 File Offset: 0x00004410
	[Token(Token = "0x1700025B")]
	protected virtual float EffectScale
	{
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x1FF4370", Offset = "0x1FF4471", VA = "0x1FF4370", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00006228 File Offset: 0x00004428
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x1FF4380", Offset = "0x1FF4481", VA = "0x1FF4380", Slot = "6")]
	public virtual bool DoSet(AttackAttribute attribute, float duration = 2f)
	{
		return default(bool);
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00006240 File Offset: 0x00004440
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x1FF4490", Offset = "0x1FF4591", VA = "0x1FF4490", Slot = "7")]
	public virtual bool DoAdd()
	{
		return default(bool);
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x1FF47C0", Offset = "0x1FF48C1", VA = "0x1FF47C0", Slot = "8")]
	public virtual void DoRemove(AttackAttribute attribute)
	{
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x1FF49A0", Offset = "0x1FF4AA1", VA = "0x1FF49A0")]
	public void DoClear()
	{
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x1FF49B0", Offset = "0x1FF4AB1", VA = "0x1FF49B0")]
	public void OnUpdate()
	{
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x1FF4630", Offset = "0x1FF4731", VA = "0x1FF4630")]
	protected void PlayEffect(AttackAttribute attribute)
	{
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x1FF48C0", Offset = "0x1FF49C1", VA = "0x1FF48C0")]
	protected void StopEffect(AttackAttribute attribute)
	{
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x1FF4B20", Offset = "0x1FF4C21", VA = "0x1FF4B20")]
	protected GrantAttributeController()
	{
	}

	// Token: 0x0400079E RID: 1950
	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x0")]
	protected static readonly int AttributeNum;

	// Token: 0x0400079F RID: 1951
	[Token(Token = "0x400062E")]
	protected const AttackAttribute AllAttribute = (AttackAttribute)(-1);

	// Token: 0x040007A0 RID: 1952
	[Token(Token = "0x400062F")]
	protected const float DefaultDuration = 2f;

	// Token: 0x040007A1 RID: 1953
	[Token(Token = "0x4000630")]
	[FieldOffset(Offset = "0x8")]
	protected static Dictionary<AttackAttribute, EffectID> m_AuraEffectIds;

	// Token: 0x040007A2 RID: 1954
	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<AttackAttribute, float> m_AddAttribute;

	// Token: 0x040007A3 RID: 1955
	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DD70", Offset = "0x15DE71")]
	private AttackAttribute <CurrentAttribute>k__BackingField;

	// Token: 0x040007A4 RID: 1956
	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<AttackAttribute, float> m_Timer;

	// Token: 0x040007A5 RID: 1957
	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<AttackAttribute, ParticleSystem> m_Effects;

	// Token: 0x0200022C RID: 556
	[Token(Token = "0x2000FF6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157260", Offset = "0x157361")]
	private sealed class <>c__DisplayClass22_0
	{
		// Token: 0x06000CDB RID: 3291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C47")]
		[Address(RVA = "0x1FF4B10", Offset = "0x1FF4C11", VA = "0x1FF4B10")]
		public <>c__DisplayClass22_0()
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C48")]
		[Address(RVA = "0x1FF4D90", Offset = "0x1FF4E91", VA = "0x1FF4D90")]
		internal void <PlayEffect>b__0(ParticleSystem effect)
		{
		}

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x4018DE4")]
		[FieldOffset(Offset = "0x10")]
		public GrantAttributeController <>4__this;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x4018DE5")]
		[FieldOffset(Offset = "0x18")]
		public AttackAttribute attribute;
	}
}
