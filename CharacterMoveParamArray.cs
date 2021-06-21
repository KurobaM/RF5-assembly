using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000350 RID: 848
[Token(Token = "0x200027F")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x145A70", Offset = "0x145B71")]
public class CharacterMoveParamArray : ScriptableObject
{
	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x0600165B RID: 5723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700039B")]
	public CharacterMoveParam Item
	{
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x1E8F9F0", Offset = "0x1E8FAF1", VA = "0x1E8F9F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x1E8FAA0", Offset = "0x1E8FBA1", VA = "0x1E8FAA0")]
	public CharacterMoveParamArray()
	{
	}

	// Token: 0x04000E39 RID: 3641
	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public CharacterMoveParamTable Table;
}
