using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000271 RID: 625
[Token(Token = "0x20001F2")]
public class CharaLazyManager : SingletonMonoBehaviour<CharaLazyManager>
{
	// Token: 0x06000F93 RID: 3987 RVA: 0x000070C8 File Offset: 0x000052C8
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x1E841E0", Offset = "0x1E842E1", VA = "0x1E841E0")]
	public bool Regist(Character chara, LazyController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x000070E0 File Offset: 0x000052E0
	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x1E84290", Offset = "0x1E84391", VA = "0x1E84290")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x1E84300", Offset = "0x1E84401", VA = "0x1E84300")]
	public LazyController Get(Character chara)
	{
		return null;
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0x1E843B0", Offset = "0x1E844B1", VA = "0x1E843B0")]
	public void SetLazy(bool isLazy)
	{
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E10")]
	[Address(RVA = "0x1E844F0", Offset = "0x1E845F1", VA = "0x1E844F0")]
	public void ResetLazy(Character chara)
	{
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x000070F8 File Offset: 0x000052F8
	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x1E84610", Offset = "0x1E84711", VA = "0x1E84610")]
	public bool IsLasy(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00007110 File Offset: 0x00005310
	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x1E84730", Offset = "0x1E84831", VA = "0x1E84730")]
	public bool DoUpdateEmotion(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x1E84860", Offset = "0x1E84961", VA = "0x1E84860")]
	private void OnValidate()
	{
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x1E84870", Offset = "0x1E84971", VA = "0x1E84870")]
	public CharaLazyManager()
	{
	}

	// Token: 0x040008DF RID: 2271
	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_isLazy;

	// Token: 0x040008E0 RID: 2272
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x20")]
	private Register<Character, LazyController> m_Register;
}
