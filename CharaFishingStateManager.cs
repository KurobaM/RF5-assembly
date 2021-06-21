using System;
using Il2CppDummyDll;

// Token: 0x02000270 RID: 624
[Token(Token = "0x20001F1")]
public class CharaFishingStateManager : SingletonMonoBehaviour<CharaFishingStateManager>
{
	// Token: 0x06000F8C RID: 3980 RVA: 0x00007080 File Offset: 0x00005280
	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x1E83C50", Offset = "0x1E83D51", VA = "0x1E83C50")]
	public bool Regist(CharacterBase chara, FishingStateController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00007098 File Offset: 0x00005298
	[Token(Token = "0x6000E06")]
	[Address(RVA = "0x1E83CC0", Offset = "0x1E83DC1", VA = "0x1E83CC0")]
	public bool Remove(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E07")]
	[Address(RVA = "0x1E83D30", Offset = "0x1E83E31", VA = "0x1E83D30")]
	public FishingStateController Get(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x1E83DE0", Offset = "0x1E83EE1", VA = "0x1E83DE0")]
	public void SetState(CharacterBase chara, FishingState state)
	{
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x1E83F10", Offset = "0x1E84011", VA = "0x1E83F10")]
	public void OnExit(CharacterBase chara)
	{
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x000070B0 File Offset: 0x000052B0
	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x1E84030", Offset = "0x1E84131", VA = "0x1E84030")]
	public bool DoWkiCast(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x1E84150", Offset = "0x1E84251", VA = "0x1E84150")]
	public CharaFishingStateManager()
	{
	}

	// Token: 0x040008DE RID: 2270
	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x18")]
	private Register<CharacterBase, FishingStateController> m_Register;
}
