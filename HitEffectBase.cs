using System;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000604 RID: 1540
[Token(Token = "0x2000455")]
[Serializable]
public class HitEffectBase
{
	// Token: 0x0600261F RID: 9759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002027")]
	[Address(RVA = "0x24F5E30", Offset = "0x24F5F31", VA = "0x24F5E30")]
	public void SetEffectID()
	{
	}

	// Token: 0x06002620 RID: 9760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002028")]
	[Address(RVA = "0x24F5EE0", Offset = "0x24F5FE1", VA = "0x24F5EE0")]
	public void Copy(HitEffectBase effectUnit)
	{
	}

	// Token: 0x06002621 RID: 9761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002029")]
	[Address(RVA = "0x24F5FB0", Offset = "0x24F60B1", VA = "0x24F5FB0")]
	public void EffectCreate(Vector3 position, Quaternion quaternion, [Optional] Transform target, float speed = 1f)
	{
	}

	// Token: 0x06002622 RID: 9762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600202A")]
	[Address(RVA = "0x24F6280", Offset = "0x24F6381", VA = "0x24F6280", Slot = "4")]
	protected virtual void EffectDestroy()
	{
	}

	// Token: 0x06002623 RID: 9763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600202B")]
	[Address(RVA = "0x24F6360", Offset = "0x24F6461", VA = "0x24F6360")]
	public HitEffectBase()
	{
	}

	// Token: 0x06002624 RID: 9764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600202C")]
	[Address(RVA = "0x24F6410", Offset = "0x24F6511", VA = "0x24F6410")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A10", Offset = "0x1A1B11")]
	private void <EffectCreate>b__8_0(ParticleSystem p)
	{
	}

	// Token: 0x04006D58 RID: 27992
	[Token(Token = "0x4006662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string EffectName;

	// Token: 0x04006D59 RID: 27993
	[Token(Token = "0x4006663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public EffectID EffectId;

	// Token: 0x04006D5A RID: 27994
	[Token(Token = "0x4006664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Vector3 Position;

	// Token: 0x04006D5B RID: 27995
	[Token(Token = "0x4006665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Vector3 Rotation;

	// Token: 0x04006D5C RID: 27996
	[Token(Token = "0x4006666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public Vector3 Scale;

	// Token: 0x04006D5D RID: 27997
	[Token(Token = "0x4006667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected ParticleSystem effectData;
}
