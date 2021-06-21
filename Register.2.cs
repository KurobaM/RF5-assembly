using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200028A RID: 650
[Token(Token = "0x2000204")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x1459A0", Offset = "0x145AA1")]
public class Register<T1, T2> where T2 : MonoBehaviour
{
	// Token: 0x060010AE RID: 4270 RVA: 0x00007A70 File Offset: 0x00005C70
	[Token(Token = "0x6000F1F")]
	public bool Regist(T1 key, T2 value)
	{
		return default(bool);
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x00007A88 File Offset: 0x00005C88
	[Token(Token = "0x6000F20")]
	public bool Remove(T1 key)
	{
		return default(bool);
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x00007AA0 File Offset: 0x00005CA0
	[Token(Token = "0x6000F21")]
	public bool Get(T1 key, out T2 value)
	{
		return default(bool);
	}

	// Token: 0x17000300 RID: 768
	// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002D6")]
	public T2 Item
	{
		[Token(Token = "0x6000F22")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002D7")]
	public Dictionary<T1, T2>.KeyCollection Keys
	{
		[Token(Token = "0x6000F23")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000302 RID: 770
	// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002D8")]
	public Dictionary<T1, T2>.ValueCollection Values
	{
		[Token(Token = "0x6000F24")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F25")]
	public Register()
	{
	}

	// Token: 0x0400095E RID: 2398
	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<T1, T2> m_registed;
}
