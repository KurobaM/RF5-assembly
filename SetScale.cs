using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B2 RID: 178
[Token(Token = "0x200008A")]
public class SetScale : MonsterProjectileActionCommandBase
{
	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000376 RID: 886 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x1700009B")]
	private bool IsCollision
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1E351D0", Offset = "0x1E352D1", VA = "0x1E351D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000377 RID: 887 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x1700009C")]
	private bool IsRelative
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1E351F0", Offset = "0x1E352F1", VA = "0x1E351F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000378 RID: 888 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x1700009D")]
	private float Time
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1E35210", Offset = "0x1E35311", VA = "0x1E35210")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000379 RID: 889 RVA: 0x000031F8 File Offset: 0x000013F8
	[Token(Token = "0x1700009E")]
	private float Scale
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1E35230", Offset = "0x1E35331", VA = "0x1E35230")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x0600037A RID: 890 RVA: 0x00003210 File Offset: 0x00001410
	[Token(Token = "0x1700009F")]
	private Ease Easing
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1E35250", Offset = "0x1E35351", VA = "0x1E35250")]
		get
		{
			return Ease.Unset;
		}
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x1E352B0", Offset = "0x1E353B1", VA = "0x1E352B0")]
	public SetScale(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x1E35310", Offset = "0x1E35411", VA = "0x1E35310", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x2000FB2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157060", Offset = "0x157161")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA5")]
		[Address(RVA = "0x1E35990", Offset = "0x1E35A91", VA = "0x1E35990")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA6")]
		[Address(RVA = "0x1E359A0", Offset = "0x1E35AA1", VA = "0x1E359A0")]
		internal void <DoAction>b__0(float x)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA7")]
		[Address(RVA = "0x1E359C0", Offset = "0x1E35AC1", VA = "0x1E359C0")]
		internal void <DoAction>b__1(float x)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA8")]
		[Address(RVA = "0x1E359E0", Offset = "0x1E35AE1", VA = "0x1E359E0")]
		internal void <DoAction>b__2(float x)
		{
		}

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4018CF7")]
		[FieldOffset(Offset = "0x10")]
		public SphereCollider sphereCollider;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4018CF8")]
		[FieldOffset(Offset = "0x18")]
		public CapsuleCollider capsuleCollider;
	}
}
