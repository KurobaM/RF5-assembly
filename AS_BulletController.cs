using System;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000044")]
public class AS_BulletController : ActionScriptControllerBase
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000C")]
	public override Character Character
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1FC4B70", Offset = "0x1FC4C71", VA = "0x1FC4B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1FC4C00", Offset = "0x1FC4D01", VA = "0x1FC4C00")]
	public void DoAction(string actionCodeName, BulletBase bullet)
	{
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1FC4E80", Offset = "0x1FC4F81", VA = "0x1FC4E80", Slot = "16")]
	protected override void BulletShot(ProjectileActionMagicCommand onProjectileActionCommand, [Optional] Collider targetCollider)
	{
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1FC5030", Offset = "0x1FC5131", VA = "0x1FC5030", Slot = "17")]
	protected override void CreateBullet(BulletID bulletID, Character chara, Vector3 offset, Quaternion rotation, bool isTargetParent, bool isLateral)
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1FC53F0", Offset = "0x1FC54F1", VA = "0x1FC53F0")]
	public AS_BulletController()
	{
	}

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected BulletBase m_bullet;

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected Character creater;

	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000F9A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F80", Offset = "0x157081")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B16")]
		[Address(RVA = "0x1FC53E0", Offset = "0x1FC54E1", VA = "0x1FC53E0")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B17")]
		[Address(RVA = "0x1FC55D0", Offset = "0x1FC56D1", VA = "0x1FC55D0")]
		internal void <CreateBullet>b__0(BulletBase bullet, BulletDataTable table)
		{
		}

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4018CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Character chara;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4018CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AS_BulletController <>4__this;
	}
}
