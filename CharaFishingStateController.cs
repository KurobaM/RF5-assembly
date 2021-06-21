using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000203 RID: 515
[Token(Token = "0x200019F")]
public abstract class CharaFishingStateController<T> : FishingStateController where T : CharacterBase
{
	// Token: 0x06000A8F RID: 2703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093F")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000940")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000941")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000942")]
	protected CharaFishingStateController()
	{
	}

	// Token: 0x040006A2 RID: 1698
	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T m_chara;
}
