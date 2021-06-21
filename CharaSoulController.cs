using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000212 RID: 530
[Token(Token = "0x20001AE")]
public class CharaSoulController<T> : SoulController where T : CharacterBase
{
	// Token: 0x06000B1B RID: 2843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CB")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CC")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CD")]
	public CharaSoulController()
	{
	}

	// Token: 0x040006CB RID: 1739
	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T m_chara;
}
