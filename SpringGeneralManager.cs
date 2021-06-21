using System;
using Il2CppDummyDll;
using UnityEngine;
using UTJ;

// Token: 0x0200028F RID: 655
[Token(Token = "0x2000208")]
public class SpringGeneralManager : SingletonMonoBehaviour<SpringGeneralManager>
{
	// Token: 0x17000304 RID: 772
	// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00007B78 File Offset: 0x00005D78
	// (set) Token: 0x060010D3 RID: 4307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DA")]
	public bool IsPaused
	{
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x2387660", Offset = "0x2387761", VA = "0x2387660")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x2387670", Offset = "0x2387771", VA = "0x2387670")]
		set
		{
		}
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x00007B90 File Offset: 0x00005D90
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x2387790", Offset = "0x2387891", VA = "0x2387790")]
	public bool Regist(Character chara, SpringManager springManager)
	{
		return default(bool);
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00007BA8 File Offset: 0x00005DA8
	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x2387840", Offset = "0x2387941", VA = "0x2387840")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x2387990", Offset = "0x2387A91", VA = "0x2387990")]
	public SpringManager Get(Character chara)
	{
		return null;
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x2387680", Offset = "0x2387781", VA = "0x2387680")]
	private void ApplyPause()
	{
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x2387A40", Offset = "0x2387B41", VA = "0x2387A40")]
	public SpringGeneralManager()
	{
	}

	// Token: 0x04000974 RID: 2420
	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_isPaused;

	// Token: 0x04000975 RID: 2421
	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x20")]
	private Register<Character, SpringManager> m_Register;
}
