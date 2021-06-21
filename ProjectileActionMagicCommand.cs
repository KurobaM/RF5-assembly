using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000076 RID: 118
[Token(Token = "0x2000058")]
public class ProjectileActionMagicCommand : ActionCommandBase
{
	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000230 RID: 560 RVA: 0x00002A78 File Offset: 0x00000C78
	[Token(Token = "0x1700005B")]
	public BulletID UseBulletID
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x216DD40", Offset = "0x216DE41", VA = "0x216DD40")]
		get
		{
			return BulletID.None;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000231 RID: 561 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x1700005C")]
	public Vector3 ShootPosition
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x216DE60", Offset = "0x216DF61", VA = "0x216DE60")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000232 RID: 562 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x1700005D")]
	public Vector2 ShootDirection
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x216DE80", Offset = "0x216DF81", VA = "0x216DE80")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000233 RID: 563 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x1700005E")]
	public float MotionPower
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x216DEA0", Offset = "0x216DFA1", VA = "0x216DEA0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000234 RID: 564 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x1700005F")]
	public bool IsTargetParent
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x216DEC0", Offset = "0x216DFC1", VA = "0x216DEC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000235 RID: 565 RVA: 0x00002AF0 File Offset: 0x00000CF0
	[Token(Token = "0x17000060")]
	public bool IsLateral
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x216DEE0", Offset = "0x216DFE1", VA = "0x216DEE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x216DF00", Offset = "0x216E001", VA = "0x216DF00")]
	public ProjectileActionMagicCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x216DF60", Offset = "0x216E061", VA = "0x216DF60", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x80")]
	public Action OnHit;

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x88")]
	public Action OnHitGround;
}
