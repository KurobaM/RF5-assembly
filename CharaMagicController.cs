using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000209 RID: 521
[Token(Token = "0x20001A5")]
public abstract class CharaMagicController<T> : MagicController where T : Character
{
	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D2")]
	private protected MagicDataTable CurrentDataTable
	{
		[Token(Token = "0x6000985")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B1B0", Offset = "0x19B2B1")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6000986")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B1C0", Offset = "0x19B2C1")]
		private set
		{
		}
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000987")]
	protected void Awake()
	{
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000988")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000989")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00005538 File Offset: 0x00003738
	[Token(Token = "0x600098A")]
	public override bool CanPlay()
	{
		return default(bool);
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00005550 File Offset: 0x00003750
	[Token(Token = "0x600098B")]
	public override bool DoPlay(MagicID magicId, int level, AttackAttribute attribute, Vector3 offset)
	{
		return default(bool);
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098C")]
	protected void SetTargets(MagicTarget target)
	{
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00005568 File Offset: 0x00003768
	[Token(Token = "0x600098D")]
	public virtual bool AddTarget(Collider target, TargetAlliance alliance, CharacterBase owner)
	{
		return default(bool);
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00005580 File Offset: 0x00003780
	[Token(Token = "0x600098E")]
	public virtual bool AddTarget(Collider target, CharacterBase targetChara, TargetAlliance alliance, CharacterBase owner)
	{
		return default(bool);
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098F")]
	protected CharaMagicController()
	{
	}

	// Token: 0x040006B8 RID: 1720
	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;

	// Token: 0x040006B9 RID: 1721
	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D350", Offset = "0x15D451")]
	private MagicDataTable <CurrentDataTable>k__BackingField;
}
