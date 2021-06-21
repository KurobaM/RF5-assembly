using System;
using Il2CppDummyDll;

// Token: 0x02000066 RID: 102
[Token(Token = "0x200004A")]
public abstract class ActionCommandBase
{
	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700002D")]
	public ActionCode ActionCode
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1FD5D20", Offset = "0x1FD5E21", VA = "0x1FD5D20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F00", Offset = "0x19A001")]
		get
		{
			return null;
		}
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1FD5D30", Offset = "0x1FD5E31", VA = "0x1FD5D30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F10", Offset = "0x19A011")]
		set
		{
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x1700002E")]
	public float DelayTime
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1FD5690", Offset = "0x1FD5791", VA = "0x1FD5690")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x1700002F")]
	public virtual float Duration
	{
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1FD5D40", Offset = "0x1FD5E41", VA = "0x1FD5D40", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x17000030")]
	public virtual bool HasEndAction
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1FD5D50", Offset = "0x1FD5E51", VA = "0x1FD5D50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002790 File Offset: 0x00000990
	// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000031")]
	private protected ActionCommandDataTable ActionCommandData
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1FD5D80", Offset = "0x1FD5E81", VA = "0x1FD5D80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F20", Offset = "0x19A021")]
		protected get
		{
			return default(ActionCommandDataTable);
		}
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1FD5DC0", Offset = "0x1FD5EC1", VA = "0x1FD5DC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F30", Offset = "0x19A031")]
		private set
		{
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000032")]
	private protected ActionScriptControllerBase Controller
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1FD5DF0", Offset = "0x1FD5EF1", VA = "0x1FD5DF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F40", Offset = "0x19A041")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1FD5E00", Offset = "0x1FD5F01", VA = "0x1FD5E00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199F50", Offset = "0x19A051")]
		private set
		{
		}
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1FD5E10", Offset = "0x1FD5F11", VA = "0x1FD5E10", Slot = "6")]
	public virtual bool IsDoneCommand(float currentTime)
	{
		return default(bool);
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1FD5E70", Offset = "0x1FD5F71", VA = "0x1FD5E70")]
	public ActionCommandBase(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1FD5ED0", Offset = "0x1FD5FD1", VA = "0x1FD5ED0", Slot = "7")]
	public virtual void ActionInitial()
	{
	}

	// Token: 0x060001DA RID: 474
	[Token(Token = "0x6000197")]
	public abstract void DoAction();

	// Token: 0x060001DB RID: 475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1FD5EE0", Offset = "0x1FD5FE1", VA = "0x1FD5EE0", Slot = "9")]
	public virtual void UpdateAction(float elapsedTime)
	{
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1FD5EF0", Offset = "0x1FD5FF1", VA = "0x1FD5EF0", Slot = "10")]
	public virtual void EndAction()
	{
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1FD5F00", Offset = "0x1FD6001", VA = "0x1FD5F00", Slot = "11")]
	public virtual void ActionFinal()
	{
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1FD5F10", Offset = "0x1FD6011", VA = "0x1FD5F10", Slot = "12")]
	public virtual void Destroy()
	{
	}

	// Token: 0x0400017B RID: 379
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x10")]
	public ActionCommandBase.State CurrentState;

	// Token: 0x0400017C RID: 380
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B610", Offset = "0x15B711")]
	private ActionCode <ActionCode>k__BackingField;

	// Token: 0x0400017D RID: 381
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B620", Offset = "0x15B721")]
	private ActionCommandDataTable <ActionCommandData>k__BackingField;

	// Token: 0x0400017E RID: 382
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B630", Offset = "0x15B731")]
	private ActionScriptControllerBase <Controller>k__BackingField;

	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000FA6")]
	public enum State
	{
		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4018CD5")]
		Stop,
		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4018CD6")]
		Wait,
		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4018CD7")]
		Update,
		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4018CD8")]
		End
	}
}
