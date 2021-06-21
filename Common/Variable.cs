using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common
{
	// Token: 0x020011C5 RID: 4549
	[Token(Token = "0x2000B9A")]
	[Serializable]
	public class Variable<T> : VariableBase
	{
		// Token: 0x0600711E RID: 28958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDA")]
		public Variable()
		{
		}

		// Token: 0x040182F6 RID: 99062
		[Token(Token = "0x4014D62")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public T Value;
	}
}
