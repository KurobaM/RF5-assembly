using System;
using Il2CppDummyDll;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000A6")]
public class MotionCommand : ToolActionCommandBase
{
	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060003EA RID: 1002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000C4")]
	public string StateName
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1E0F3E0", Offset = "0x1E0F4E1", VA = "0x1E0F3E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060003EB RID: 1003 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x170000C5")]
	public bool AutoEnd
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1E0F400", Offset = "0x1E0F501", VA = "0x1E0F400")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060003EC RID: 1004 RVA: 0x00003510 File Offset: 0x00001710
	[Token(Token = "0x170000C6")]
	public float SkipStart
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1E0F420", Offset = "0x1E0F521", VA = "0x1E0F420")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060003ED RID: 1005 RVA: 0x00003528 File Offset: 0x00001728
	[Token(Token = "0x170000C7")]
	public float MotionSpeed
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1E0F440", Offset = "0x1E0F541", VA = "0x1E0F440")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060003EE RID: 1006 RVA: 0x00003540 File Offset: 0x00001740
	[Token(Token = "0x170000C8")]
	public float FadeTime
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1E0F460", Offset = "0x1E0F561", VA = "0x1E0F460")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060003EF RID: 1007 RVA: 0x00003558 File Offset: 0x00001758
	// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C9")]
	private bool IsMotionDone
	{
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1E0F480", Offset = "0x1E0F581", VA = "0x1E0F480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A140", Offset = "0x19A241")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1E0F490", Offset = "0x1E0F591", VA = "0x1E0F490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A150", Offset = "0x19A251")]
		set
		{
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x170000CA")]
	public override bool HasEndAction
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1E0F4A0", Offset = "0x1E0F5A1", VA = "0x1E0F4A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00003588 File Offset: 0x00001788
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x1E0F4C0", Offset = "0x1E0F5C1", VA = "0x1E0F4C0", Slot = "6")]
	public override bool IsDoneCommand(float currentTime)
	{
		return default(bool);
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x1E0F4F0", Offset = "0x1E0F5F1", VA = "0x1E0F4F0")]
	public MotionCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x1E0F550", Offset = "0x1E0F651", VA = "0x1E0F550", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x1E0F610", Offset = "0x1E0F711", VA = "0x1E0F610", Slot = "9")]
	public override void UpdateAction(float elapsedTime)
	{
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000338")]
	[Address(RVA = "0x1E0F740", Offset = "0x1E0F841", VA = "0x1E0F740", Slot = "11")]
	public override void ActionFinal()
	{
	}

	// Token: 0x04000261 RID: 609
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B870", Offset = "0x15B971")]
	private bool <IsMotionDone>k__BackingField;

	// Token: 0x04000262 RID: 610
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x89")]
	private bool IsActionFrame;
}
