using System;
using Il2CppDummyDll;

// Token: 0x02000272 RID: 626
[Token(Token = "0x20001F3")]
public class CharaPersonalMotionManager : SingletonMonoBehaviour<CharaPersonalMotionManager>
{
	// Token: 0x06000F9C RID: 3996 RVA: 0x00007128 File Offset: 0x00005328
	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x1E84E90", Offset = "0x1E84F91", VA = "0x1E84E90")]
	public bool Regist(CharacterBase chara, PersonalMotionController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00007140 File Offset: 0x00005340
	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x1E84F00", Offset = "0x1E85001", VA = "0x1E84F00")]
	public bool Remove(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x1E84F70", Offset = "0x1E85071", VA = "0x1E84F70")]
	public PersonalMotionController Get(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x1E85020", Offset = "0x1E85121", VA = "0x1E85020")]
	public void SetActivate(CharacterBase chara, bool active)
	{
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x1E85150", Offset = "0x1E85251", VA = "0x1E85150")]
	public void OnMotionPlay(CharacterBase chara, int no)
	{
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x1E85280", Offset = "0x1E85381", VA = "0x1E85280")]
	public CharaPersonalMotionManager()
	{
	}

	// Token: 0x040008E1 RID: 2273
	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x18")]
	private Register<CharacterBase, PersonalMotionController> m_Register;
}
