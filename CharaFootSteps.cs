using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000109 RID: 265
[Token(Token = "0x20000CF")]
public abstract class CharaFootSteps<T> : FootSteps where T : Character
{
	// Token: 0x17000157 RID: 343
	// (get) Token: 0x060005BF RID: 1471 RVA: 0x00004158 File Offset: 0x00002358
	[Token(Token = "0x17000151")]
	public override float FootEffectScale
	{
		[Token(Token = "0x60004DC")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00004170 File Offset: 0x00002370
	[Token(Token = "0x17000152")]
	public override float LandingEffectScale
	{
		[Token(Token = "0x60004DD")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DE")]
	protected override void Awake()
	{
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DF")]
	protected virtual void Start()
	{
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E0")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E1")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E2")]
	protected CharaFootSteps()
	{
	}

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;
}
