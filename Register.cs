using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000289 RID: 649
[Token(Token = "0x2000203")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x145960", Offset = "0x145A61")]
public class Register<T> where T : MonoBehaviour
{
	// Token: 0x060010A8 RID: 4264 RVA: 0x00007A28 File Offset: 0x00005C28
	[Token(Token = "0x6000F19")]
	public bool Regist(T value)
	{
		return default(bool);
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00007A40 File Offset: 0x00005C40
	[Token(Token = "0x6000F1A")]
	public bool Remove(T value)
	{
		return default(bool);
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00007A58 File Offset: 0x00005C58
	[Token(Token = "0x6000F1B")]
	public bool Get(int index, out T value)
	{
		return default(bool);
	}

	// Token: 0x170002FE RID: 766
	// (get) Token: 0x060010AB RID: 4267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002D4")]
	public T Item
	{
		[Token(Token = "0x6000F1C")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002FF RID: 767
	// (get) Token: 0x060010AC RID: 4268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002D5")]
	public List<T> Values
	{
		[Token(Token = "0x6000F1D")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1E")]
	public Register()
	{
	}

	// Token: 0x0400095D RID: 2397
	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x0")]
	private List<T> m_registed;
}
