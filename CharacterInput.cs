using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025E RID: 606
[Token(Token = "0x20001E5")]
public class CharacterInput : MonoBehaviour
{
	// Token: 0x06000ECC RID: 3788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x1E8DF50", Offset = "0x1E8E051", VA = "0x1E8DF50", Slot = "4")]
	protected virtual void Start()
	{
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x1E8E010", Offset = "0x1E8E111", VA = "0x1E8E010", Slot = "5")]
	protected virtual void Reset()
	{
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x1E8E070", Offset = "0x1E8E171", VA = "0x1E8E070", Slot = "6")]
	public virtual void SetCharacter(Character character)
	{
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x1E8E080", Offset = "0x1E8E181", VA = "0x1E8E080")]
	public CharacterInput()
	{
	}

	// Token: 0x04000899 RID: 2201
	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Character m_ControllCharacter;
}
