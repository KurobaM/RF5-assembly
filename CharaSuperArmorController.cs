using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D3 RID: 723
[Token(Token = "0x2000234")]
public class CharaSuperArmorController<T> : SuperArmorController where T : Character
{
	// Token: 0x06001348 RID: 4936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118B")]
	protected override void Awake()
	{
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118C")]
	protected override void OnEnable()
	{
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118D")]
	protected override void OnDisable()
	{
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118E")]
	public override void DoPlay(float duration)
	{
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118F")]
	public override void DoStop()
	{
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001190")]
	public CharaSuperArmorController()
	{
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001191")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA70", Offset = "0x19CB71")]
	private void <DoPlay>b__5_0(ParticleSystem effect)
	{
	}

	// Token: 0x04000ADE RID: 2782
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;

	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x0")]
	protected ParticleSystem m_effect;
}
