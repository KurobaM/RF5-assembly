using System;
using Il2CppDummyDll;

// Token: 0x02000291 RID: 657
[Token(Token = "0x200020A")]
public class ThrottleManager : SingletonMonoBehaviour<ThrottleManager>
{
	// Token: 0x060010E0 RID: 4320 RVA: 0x00007C20 File Offset: 0x00005E20
	[Token(Token = "0x6000F51")]
	[Address(RVA = "0x205E340", Offset = "0x205E441", VA = "0x205E340")]
	public bool Regist(CharacterBase chara, ThrottleController controller)
	{
		return default(bool);
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00007C38 File Offset: 0x00005E38
	[Token(Token = "0x6000F52")]
	[Address(RVA = "0x205E3B0", Offset = "0x205E4B1", VA = "0x205E3B0")]
	public bool Remove(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F53")]
	[Address(RVA = "0x205E420", Offset = "0x205E521", VA = "0x205E420")]
	public ThrottleController Get(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F54")]
	[Address(RVA = "0x205E4D0", Offset = "0x205E5D1", VA = "0x205E4D0")]
	private void Update()
	{
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00007C50 File Offset: 0x00005E50
	[Token(Token = "0x6000F55")]
	[Address(RVA = "0x205E5F0", Offset = "0x205E6F1", VA = "0x205E5F0")]
	public bool DoPlay(CharacterBase chara, ThrottleID slot)
	{
		return default(bool);
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00007C68 File Offset: 0x00005E68
	[Token(Token = "0x6000F56")]
	[Address(RVA = "0x205E720", Offset = "0x205E821", VA = "0x205E720")]
	public bool DoStop(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00007C80 File Offset: 0x00005E80
	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x205E850", Offset = "0x205E951", VA = "0x205E850")]
	public bool DoStop(CharacterBase chara, ThrottleID throttleID)
	{
		return default(bool);
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x205E980", Offset = "0x205EA81", VA = "0x205E980")]
	public void DoStopAll()
	{
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00007C98 File Offset: 0x00005E98
	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x205EA90", Offset = "0x205EB91", VA = "0x205EA90")]
	public bool IsPlaying(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00007CB0 File Offset: 0x00005EB0
	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x205EBB0", Offset = "0x205ECB1", VA = "0x205EBB0")]
	public ThrottleID CurrentThrottleID(CharacterBase chara)
	{
		return ThrottleID.A;
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x205ECD0", Offset = "0x205EDD1", VA = "0x205ECD0")]
	public ThrottleManager()
	{
	}

	// Token: 0x04000977 RID: 2423
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x18")]
	private Register<CharacterBase, ThrottleController> m_Register;
}
