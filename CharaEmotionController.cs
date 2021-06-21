using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FB RID: 507
[Token(Token = "0x2000198")]
public abstract class CharaEmotionController<T> : EmotionController where T : Character
{
	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C1")]
	public T Character
	{
		[Token(Token = "0x6000917")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000918")]
	protected override void Awake()
	{
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000919")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091A")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091B")]
	public override void Init(Transform point)
	{
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00005328 File Offset: 0x00003528
	[Token(Token = "0x600091C")]
	public override bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091D")]
	protected CharaEmotionController()
	{
	}

	// Token: 0x04000683 RID: 1667
	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T m_chara;
}
