using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000897 RID: 2199
[Token(Token = "0x20005AF")]
public class DamageTextManager : SingletonMonoBehaviour<DamageTextManager>
{
	// Token: 0x060039D6 RID: 14806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003046")]
	[Address(RVA = "0x1DA34B0", Offset = "0x1DA35B1", VA = "0x1DA34B0")]
	private void Update()
	{
	}

	// Token: 0x060039D7 RID: 14807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003047")]
	[Address(RVA = "0x1DA3700", Offset = "0x1DA3801", VA = "0x1DA3700")]
	public void AddText(CharacterBase chara, ref DamageTextInfo info)
	{
	}

	// Token: 0x060039D8 RID: 14808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003048")]
	[Address(RVA = "0x1DA38B0", Offset = "0x1DA39B1", VA = "0x1DA38B0")]
	public DamageTextManager()
	{
	}

	// Token: 0x04007D69 RID: 32105
	[Token(Token = "0x400715E")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<CharacterBase, DamageTextController> m_Controllers;

	// Token: 0x04007D6A RID: 32106
	[Token(Token = "0x400715F")]
	[FieldOffset(Offset = "0x20")]
	private List<CharacterBase> RemoveList;
}
