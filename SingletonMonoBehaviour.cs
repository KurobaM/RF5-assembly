using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000313 RID: 787
[Token(Token = "0x2000253")]
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
	// Token: 0x170003AC RID: 940
	// (get) Token: 0x060014C4 RID: 5316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700035E")]
	public static T Instance
	{
		[Token(Token = "0x6001290")]
		get
		{
			return null;
		}
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001291")]
	protected virtual void Awake()
	{
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x00009330 File Offset: 0x00007530
	[Token(Token = "0x6001292")]
	protected bool CheckInstance()
	{
		return default(bool);
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001293")]
	protected SingletonMonoBehaviour()
	{
	}

	// Token: 0x04000BE0 RID: 3040
	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x0")]
	private static T _Instance;
}
