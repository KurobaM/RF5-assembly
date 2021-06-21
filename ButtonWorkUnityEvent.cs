using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200093C RID: 2364
[Token(Token = "0x2000630")]
public class ButtonWorkUnityEvent : ButtonWorkBase
{
	// Token: 0x06003E82 RID: 16002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033F5")]
	[Address(RVA = "0x219C010", Offset = "0x219C111", VA = "0x219C010", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x06003E83 RID: 16003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033F6")]
	[Address(RVA = "0x219C140", Offset = "0x219C241", VA = "0x219C140")]
	public ButtonWorkUnityEvent()
	{
	}

	// Token: 0x04008039 RID: 32825
	[Token(Token = "0x400738D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent unityEvent;
}
