using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000045")]
public class AS_MagicController : ActionScriptControllerBase
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000D")]
	public override Character Character
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1FC5620", Offset = "0x1FC5721", VA = "0x1FC5620", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1FC5630", Offset = "0x1FC5731", VA = "0x1FC5630")]
	public void DoAction(MagicID magicId, Character character, int level, AttackAttribute attribute)
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1FC57A0", Offset = "0x1FC58A1", VA = "0x1FC57A0", Slot = "19")]
	public override void DoMagicEfficacy(MagicParamID magicParamID, int level)
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1FC63A0", Offset = "0x1FC64A1", VA = "0x1FC63A0", Slot = "20")]
	public override void DoMagicMedi(MagicParamID magicParamID1, MagicParamID magicParamID2, MagicParamID magicParamID3, int level)
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1FC6440", Offset = "0x1FC6541", VA = "0x1FC6440", Slot = "17")]
	protected override void CreateBullet(BulletID useBulletID, Character chara, Vector3 offset, Quaternion rotation, bool isTargetParent, bool isLateral)
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1FC6BE0", Offset = "0x1FC6CE1", VA = "0x1FC6BE0", Slot = "15")]
	public override void OnBulletLoad(BulletLoadCommand bulletLoadCmmand)
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1FC6E40", Offset = "0x1FC6F41", VA = "0x1FC6E40", Slot = "22")]
	public override void DoScore(ScoreType scoreType, int level)
	{
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1FC75F0", Offset = "0x1FC76F1", VA = "0x1FC75F0")]
	public void UpdateBulletExtension()
	{
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1FC7760", Offset = "0x1FC7861", VA = "0x1FC7760", Slot = "21")]
	public override void DoCallBit(BitID bitID, int level)
	{
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1FC7850", Offset = "0x1FC7951", VA = "0x1FC7850")]
	public void DoBranchAttributeMagic(AtrubuteMagicCommand atrubuteMagicCommand)
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1FC7AA0", Offset = "0x1FC7BA1", VA = "0x1FC7AA0")]
	public AS_MagicController()
	{
	}

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x140")]
	protected Character creater;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	protected List<BulletBase> m_Bullets;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	protected List<BulletID> m_LoadedBulletID;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x158")]
	protected int m_Level;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x15C")]
	protected AttackAttribute m_AttackAttribute;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x160")]
	protected MagicID m_MagicID;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x168")]
	protected MagicData m_MagicData;

	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000F9B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F90", Offset = "0x157091")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B18")]
		[Address(RVA = "0x1FC6BB0", Offset = "0x1FC6CB1", VA = "0x1FC6BB0")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x4018CA6")]
		[FieldOffset(Offset = "0x10")]
		public AS_MagicController <>4__this;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x4018CA7")]
		[FieldOffset(Offset = "0x18")]
		public Character chara;
	}

	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000F9C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156FA0", Offset = "0x1570A1")]
	private sealed class <>c__DisplayClass12_1
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B19")]
		[Address(RVA = "0x1FC6BC0", Offset = "0x1FC6CC1", VA = "0x1FC6BC0")]
		public <>c__DisplayClass12_1()
		{
		}

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x4018CA8")]
		[FieldOffset(Offset = "0x10")]
		public Collider target;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x4018CA9")]
		[FieldOffset(Offset = "0x18")]
		public AS_MagicController.<>c__DisplayClass12_0 CS$<>8__locals1;
	}

	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000F9D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156FB0", Offset = "0x1570B1")]
	private sealed class <>c__DisplayClass12_2
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1A")]
		[Address(RVA = "0x1FC6BD0", Offset = "0x1FC6CD1", VA = "0x1FC6BD0")]
		public <>c__DisplayClass12_2()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1B")]
		[Address(RVA = "0x1FC7B60", Offset = "0x1FC7C61", VA = "0x1FC7B60")]
		internal void <CreateBullet>b__0(BulletBase bullet, BulletDataTable table)
		{
		}

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x4018CAA")]
		[FieldOffset(Offset = "0x10")]
		public Transform parent;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4018CAB")]
		[FieldOffset(Offset = "0x18")]
		public AS_MagicController.<>c__DisplayClass12_1 CS$<>8__locals2;
	}
}
