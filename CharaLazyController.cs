using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000207 RID: 519
[Token(Token = "0x20001A3")]
public abstract class CharaLazyController<T> : LazyController where T : Character
{
	// Token: 0x06000AC0 RID: 2752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000970")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000971")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000972")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000973")]
	public override void DoUpdateEmotion()
	{
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000974")]
	public void DoPlayEmotion()
	{
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000975")]
	public void DoStopEmotion()
	{
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000976")]
	protected CharaLazyController()
	{
	}

	// Token: 0x040006AE RID: 1710
	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T m_chara;

	// Token: 0x040006AF RID: 1711
	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private EmotionController m_EmotionController;
}
