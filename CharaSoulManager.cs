using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000273 RID: 627
[Token(Token = "0x20001F4")]
public class CharaSoulManager : SingletonMonoBehaviour<CharaSoulManager>
{
	// Token: 0x06000FA2 RID: 4002 RVA: 0x00007158 File Offset: 0x00005358
	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x1E85310", Offset = "0x1E85411", VA = "0x1E85310")]
	public bool Regist(CharacterBase chara, SoulController controller)
	{
		return default(bool);
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00007170 File Offset: 0x00005370
	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0x1E85380", Offset = "0x1E85481", VA = "0x1E85380")]
	public bool Remove(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0x1E853F0", Offset = "0x1E854F1", VA = "0x1E853F0")]
	public SoulController Get(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00007188 File Offset: 0x00005388
	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0x1E854A0", Offset = "0x1E855A1", VA = "0x1E854A0")]
	public bool DoPlay(CharacterBase chara, Collider target, Action collback)
	{
		return default(bool);
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x1E855E0", Offset = "0x1E856E1", VA = "0x1E855E0")]
	public void DoEndAll()
	{
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x1E85700", Offset = "0x1E85801", VA = "0x1E85700")]
	public CharaSoulManager()
	{
	}

	// Token: 0x040008E2 RID: 2274
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x18")]
	private Register<CharacterBase, SoulController> m_Register;
}
