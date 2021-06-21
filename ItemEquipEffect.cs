using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000628 RID: 1576
[Token(Token = "0x2000472")]
[Serializable]
public class ItemEquipEffect
{
	// Token: 0x060026E7 RID: 9959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020D1")]
	[Address(RVA = "0x2238FA0", Offset = "0x22390A1", VA = "0x2238FA0")]
	public ItemEquipEffect(EffectID _effectID, Transform _parent)
	{
	}

	// Token: 0x04006DB9 RID: 28089
	[Token(Token = "0x40066A4")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public EffectID effectID;

	// Token: 0x04006DBA RID: 28090
	[Token(Token = "0x40066A5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Transform parent;
}
