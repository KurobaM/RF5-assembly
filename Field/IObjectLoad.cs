using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x020010FD RID: 4349
	[Token(Token = "0x2000AF2")]
	public interface IObjectLoad
	{
		// Token: 0x06006DEE RID: 28142
		[Token(Token = "0x6005B37")]
		int GetLoadingCount();

		// Token: 0x06006DEF RID: 28143
		[Token(Token = "0x6005B38")]
		bool IsUpdate();

		// Token: 0x06006DF0 RID: 28144
		[Token(Token = "0x6005B39")]
		bool IsCompleted();

		// Token: 0x06006DF1 RID: 28145
		[Token(Token = "0x6005B3A")]
		List<GameObject> GetLoadObjectList();

		// Token: 0x06006DF2 RID: 28146
		[Token(Token = "0x6005B3B")]
		IEnumerator LoadAsync(string path, bool visible);

		// Token: 0x06006DF3 RID: 28147
		[Token(Token = "0x6005B3C")]
		IEnumerator LoadAsync();
	}
}
