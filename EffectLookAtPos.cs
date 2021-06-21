using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001B")]
public class EffectLookAtPos : MonoBehaviour
{
	// Token: 0x0600004A RID: 74 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x22AC910", Offset = "0x22ACA11", VA = "0x22AC910")]
	private void Awake()
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x22AC9F0", Offset = "0x22ACAF1", VA = "0x22AC9F0")]
	private void Update()
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x22ACAB0", Offset = "0x22ACBB1", VA = "0x22ACAB0")]
	public EffectLookAtPos()
	{
	}

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject LookObject;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x20")]
	private Transform LookAtPosTransform;
}
