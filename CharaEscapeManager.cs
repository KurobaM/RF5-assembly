using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026F RID: 623
[Token(Token = "0x20001F0")]
public class CharaEscapeManager : SingletonMonoBehaviour<CharaEscapeManager>
{
	// Token: 0x170002DB RID: 731
	// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002B1")]
	public EscapeShineBall ShineBall
	{
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x1E83300", Offset = "0x1E83401", VA = "0x1E83300")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002B2")]
	public ParticleSystem AuraEffect
	{
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x1E83310", Offset = "0x1E83411", VA = "0x1E83310")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00007008 File Offset: 0x00005208
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x1E83320", Offset = "0x1E83421", VA = "0x1E83320")]
	public bool Regist(CharacterBase chara, EscapeController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00007020 File Offset: 0x00005220
	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x1E83390", Offset = "0x1E83491", VA = "0x1E83390")]
	public bool Remove(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x1E83400", Offset = "0x1E83501", VA = "0x1E83400")]
	public EscapeController Get(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x1E834B0", Offset = "0x1E835B1", VA = "0x1E834B0")]
	private void Update()
	{
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00007038 File Offset: 0x00005238
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x1E835D0", Offset = "0x1E836D1", VA = "0x1E835D0")]
	public bool DoRise(CharacterBase chara, [Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00007050 File Offset: 0x00005250
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x1E83700", Offset = "0x1E83801", VA = "0x1E83700")]
	public bool DoFall(CharacterBase chara, [Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00007068 File Offset: 0x00005268
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x1E83830", Offset = "0x1E83931", VA = "0x1E83830")]
	public bool DoTakeOff(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x1E83950", Offset = "0x1E83A51", VA = "0x1E83950")]
	public void DoEndAll()
	{
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x1E83A70", Offset = "0x1E83B71", VA = "0x1E83A70")]
	public CharaEscapeManager()
	{
	}

	// Token: 0x040008DB RID: 2267
	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private EscapeShineBall m_ShileBall;

	// Token: 0x040008DC RID: 2268
	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem m_AuraEffect;

	// Token: 0x040008DD RID: 2269
	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Register<CharacterBase, EscapeController> m_Register;
}
