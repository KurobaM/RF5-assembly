using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200062B RID: 1579
[Token(Token = "0x2000474")]
public class ItemEquipEffectPlayer : MonoBehaviour
{
	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x060026FE RID: 9982 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060026FF RID: 9983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004F8")]
	public ParticleSystem Effect
	{
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x2238FF0", Offset = "0x22390F1", VA = "0x2238FF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1C20", Offset = "0x1A1D21")]
		get
		{
			return null;
		}
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x2239000", Offset = "0x2239101", VA = "0x2239000")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1C30", Offset = "0x1A1D31")]
		private set
		{
		}
	}

	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x06002700 RID: 9984 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
	// (set) Token: 0x06002701 RID: 9985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004F9")]
	public bool IsPlaying
	{
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x2239010", Offset = "0x2239111", VA = "0x2239010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1C40", Offset = "0x1A1D41")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x2239020", Offset = "0x2239121", VA = "0x2239020")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1C50", Offset = "0x1A1D51")]
		private set
		{
		}
	}

	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x06002702 RID: 9986 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
	// (set) Token: 0x06002703 RID: 9987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004FA")]
	public float Scale
	{
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x2239030", Offset = "0x2239131", VA = "0x2239030")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x2239040", Offset = "0x2239141", VA = "0x2239040")]
		set
		{
		}
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x22390F0", Offset = "0x22391F1", VA = "0x22390F0")]
	private void OnLoaded(ParticleSystem effect)
	{
	}

	// Token: 0x06002705 RID: 9989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x22392F0", Offset = "0x22393F1", VA = "0x22392F0")]
	public void Play(EffectID effectID, float scale = 1f)
	{
	}

	// Token: 0x06002706 RID: 9990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x22393E0", Offset = "0x22394E1", VA = "0x22393E0")]
	public void Stop()
	{
	}

	// Token: 0x06002707 RID: 9991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x22393D0", Offset = "0x22394D1", VA = "0x22393D0")]
	public void SetScale(float scale)
	{
	}

	// Token: 0x06002708 RID: 9992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x22394C0", Offset = "0x22395C1", VA = "0x22394C0")]
	public void LerpScale(float scale, float t)
	{
	}

	// Token: 0x06002709 RID: 9993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x2239560", Offset = "0x2239661", VA = "0x2239560")]
	public ItemEquipEffectPlayer()
	{
	}

	// Token: 0x04006DC8 RID: 28104
	[Token(Token = "0x40066AF")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1683B0", Offset = "0x1684B1")]
	private ParticleSystem <Effect>k__BackingField;

	// Token: 0x04006DC9 RID: 28105
	[Token(Token = "0x40066B0")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1683C0", Offset = "0x1684C1")]
	private bool <IsPlaying>k__BackingField;

	// Token: 0x04006DCA RID: 28106
	[Token(Token = "0x40066B1")]
	[FieldOffset(Offset = "0x24")]
	private float m_scale;
}
