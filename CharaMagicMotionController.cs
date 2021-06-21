using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020B RID: 523
[Token(Token = "0x20001A7")]
public abstract class CharaMagicMotionController<T1, T2> : MagicMotionController where T1 : Character
{
	// Token: 0x06000AE7 RID: 2791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000997")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000998")]
	public override void Setup()
	{
	}

	// Token: 0x06000AE9 RID: 2793
	[Token(Token = "0x6000999")]
	public abstract bool DoPlay(T2 motion, MagicID magicId, int level);

	// Token: 0x06000AEA RID: 2794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099A")]
	protected CharaMagicMotionController()
	{
	}

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T1 m_chara;
}
