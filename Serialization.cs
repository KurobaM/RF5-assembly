using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000312 RID: 786
[Token(Token = "0x2000252")]
[Serializable]
public class Serialization<T>
{
	// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600128D")]
	public List<T> ToList()
	{
		return null;
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128E")]
	public Serialization(List<T> target)
	{
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128F")]
	public Serialization(T[] target)
	{
	}

	// Token: 0x04000BDF RID: 3039
	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private List<T> target;
}
