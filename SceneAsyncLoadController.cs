using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000305 RID: 773
[Token(Token = "0x2000250")]
public class SceneAsyncLoadController : SingletonMonoBehaviour<SceneAsyncLoadController>
{
	// Token: 0x06001465 RID: 5221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x21D4330", Offset = "0x21D4431", VA = "0x21D4330", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001262")]
	[Address(RVA = "0x21D43E0", Offset = "0x21D44E1", VA = "0x21D43E0")]
	public SceneAsyncLoadController()
	{
	}

	// Token: 0x04000BA2 RID: 2978
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x18")]
	private List<string> NowLoadingScene;

	// Token: 0x04000BA3 RID: 2979
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x20")]
	private Canvas Canvas;
}
