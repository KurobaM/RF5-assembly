using System;
using Il2CppDummyDll;

// Token: 0x0200026A RID: 618
[Token(Token = "0x20001EC")]
public class BattleModeManager : SingletonMonoBehaviour<BattleModeManager>
{
	// Token: 0x06000F57 RID: 3927 RVA: 0x00006E10 File Offset: 0x00005010
	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x2207D80", Offset = "0x2207E81", VA = "0x2207D80")]
	public bool Regist(Character chara, BattleModeController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00006E28 File Offset: 0x00005028
	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0x2207DF0", Offset = "0x2207EF1", VA = "0x2207DF0")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DD4")]
	[Address(RVA = "0x2207E60", Offset = "0x2207F61", VA = "0x2207E60")]
	public BattleModeController Get(Character chara)
	{
		return null;
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00006E40 File Offset: 0x00005040
	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0x2207F10", Offset = "0x2208011", VA = "0x2207F10")]
	public bool CanStart(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00006E58 File Offset: 0x00005058
	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0x2208030", Offset = "0x2208131", VA = "0x2208030")]
	public bool DoStart(Character chara, bool Immediate)
	{
		return default(bool);
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00006E70 File Offset: 0x00005070
	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0x2208160", Offset = "0x2208261", VA = "0x2208160")]
	public bool DoEnd(Character chara, bool Immediate)
	{
		return default(bool);
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00006E88 File Offset: 0x00005088
	[Token(Token = "0x6000DD8")]
	[Address(RVA = "0x2208290", Offset = "0x2208391", VA = "0x2208290")]
	public bool IsBattleMode(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD9")]
	[Address(RVA = "0x22083B0", Offset = "0x22084B1", VA = "0x22083B0")]
	public BattleModeManager()
	{
	}

	// Token: 0x040008CC RID: 2252
	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x18")]
	private Register<Character, BattleModeController> m_Register;
}
