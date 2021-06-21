using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F8 RID: 504
[Token(Token = "0x2000196")]
public abstract class CharaBitController<T> : BitController where T : Character
{
	// Token: 0x06000A57 RID: 2647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000908")]
	protected override void Awake()
	{
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000909")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090A")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x000052B0 File Offset: 0x000034B0
	[Token(Token = "0x600090B")]
	public override bool DoCall(BitID bitID, int level)
	{
		return default(bool);
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090C")]
	protected CharaBitController()
	{
	}

	// Token: 0x0400067B RID: 1659
	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;
}
