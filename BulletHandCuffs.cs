using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018A RID: 394
[Token(Token = "0x2000135")]
public class BulletHandCuffs : BulletSubModule
{
	// Token: 0x06000823 RID: 2083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x2195010", Offset = "0x2195111", VA = "0x2195010", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x2195070", Offset = "0x2195171", VA = "0x2195070")]
	public void OnHit(CharacterBase chara, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00004C98 File Offset: 0x00002E98
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x2195350", Offset = "0x2195451", VA = "0x2195350", Slot = "13")]
	protected virtual bool Judge(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x21955A0", Offset = "0x21956A1", VA = "0x21955A0", Slot = "14")]
	public virtual void OnSuccess(CharacterBase chara, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x2195130", Offset = "0x2195231", VA = "0x2195130")]
	public void OnMiss(CharacterBase chara, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x2192B70", Offset = "0x2192C71", VA = "0x2192B70")]
	public BulletHandCuffs()
	{
	}

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40003A8")]
	private const EffectID HitEffectID = EffectID.Effect_BattleHandcuffs_Miss;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40003A9")]
	private const SoundID HitSoundID = SoundID.RF5_SE_chara_motion15;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x20")]
	protected Character m_Owner;
}
