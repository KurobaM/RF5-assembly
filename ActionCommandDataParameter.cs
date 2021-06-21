using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200008C RID: 140
[Token(Token = "0x200006C")]
[Serializable]
public class ActionCommandDataParameter<T> : ActionCommandDataParameterBase
{
	// Token: 0x0600027A RID: 634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000224")]
	public ActionCommandDataParameter()
	{
	}

	// Token: 0x0400020D RID: 525
	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public T Value;
}
