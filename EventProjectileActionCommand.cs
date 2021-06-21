using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[Token(Token = "0x200008B")]
public class EventProjectileActionCommand : MonsterProjectileActionCommand
{
	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000381 RID: 897 RVA: 0x00003228 File Offset: 0x00001428
	[Token(Token = "0x170000A0")]
	private EventProjectileActionCommand.CreateTimingType Type
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x21B5E20", Offset = "0x21B5F21", VA = "0x21B5E20")]
		get
		{
			return EventProjectileActionCommand.CreateTimingType.OnEnd;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A1")]
	public override string NextActionCode
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x21B5E80", Offset = "0x21B5F81", VA = "0x21B5E80", Slot = "13")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000383 RID: 899 RVA: 0x00003240 File Offset: 0x00001440
	[Token(Token = "0x170000A2")]
	public override bool UseRotate
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x21B5EA0", Offset = "0x21B5FA1", VA = "0x21B5EA0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000384 RID: 900 RVA: 0x00003258 File Offset: 0x00001458
	[Token(Token = "0x170000A3")]
	public override Vector2 DirectionBlurAngle
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x21B5EC0", Offset = "0x21B5FC1", VA = "0x21B5EC0", Slot = "15")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x21B5EE0", Offset = "0x21B5FE1", VA = "0x21B5EE0")]
	public EventProjectileActionCommand(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x21B5F60", Offset = "0x21B6061", VA = "0x21B5F60", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x21B6160", Offset = "0x21B6261", VA = "0x21B6160")]
	private void Create()
	{
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x21B6170", Offset = "0x21B6271", VA = "0x21B6170", Slot = "17")]
	protected override void ProjcticlePostprocess(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController)
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x21B61C0", Offset = "0x21B62C1", VA = "0x21B61C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A100", Offset = "0x19A201")]
	private void <DoAction>b__11_0()
	{
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x21B6280", Offset = "0x21B6381", VA = "0x21B6280")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A110", Offset = "0x19A211")]
	private void <DoAction>b__11_1(Collider collide)
	{
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x21B6320", Offset = "0x21B6421", VA = "0x21B6320")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A120", Offset = "0x19A221")]
	private void <DoAction>b__11_2(Collider collider)
	{
	}

	// Token: 0x04000243 RID: 579
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x88")]
	private MonsterProjectileActionScriptsController projectileActionScriptsController;

	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x2000FB3")]
	private enum CreateTimingType
	{
		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4018CFA")]
		OnEnd,
		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4018CFB")]
		OnHit,
		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4018CFC")]
		OnHitGround
	}
}
