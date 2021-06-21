using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020E RID: 526
[Token(Token = "0x20001AA")]
public class CharaPersonalMotionController<T> : PersonalMotionController where T : Character
{
	// Token: 0x06000AFA RID: 2810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AA")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AB")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AC")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AD")]
	public override void DoPlayMotion()
	{
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AE")]
	public override void PlayMotion(int no)
	{
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AF")]
	public override void OnMotionPlay(int no)
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B0")]
	public CharaPersonalMotionController()
	{
	}

	// Token: 0x040006C3 RID: 1731
	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T m_chara;

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0x0")]
	protected int m_PlayCount;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x0")]
	protected bool m_isPlayVoice;

	// Token: 0x040006C6 RID: 1734
	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x0")]
	private static List<string> m_StateNames;
}
