using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x2000195")]
public class BitController : MonoBehaviour
{
	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00005268 File Offset: 0x00003468
	[Token(Token = "0x170001BE")]
	public bool IsSummon
	{
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x2454550", Offset = "0x2454651", VA = "0x2454550")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000902")]
	[Address(RVA = "0x24545B0", Offset = "0x24546B1", VA = "0x24545B0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x00005280 File Offset: 0x00003480
	[Token(Token = "0x6000903")]
	[Address(RVA = "0x2454610", Offset = "0x2454711", VA = "0x2454610", Slot = "5")]
	public virtual bool DoCall(BitID bitID, int level)
	{
		return default(bool);
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00005298 File Offset: 0x00003498
	[Token(Token = "0x6000904")]
	[Address(RVA = "0x2454620", Offset = "0x2454721", VA = "0x2454620", Slot = "6")]
	public virtual bool DoRelease()
	{
		return default(bool);
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000905")]
	[Address(RVA = "0x2454790", Offset = "0x2454891", VA = "0x2454790", Slot = "7")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000906")]
	[Address(RVA = "0x2454980", Offset = "0x2454A81", VA = "0x2454980", Slot = "8")]
	public virtual void OnFixedUpdate()
	{
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000907")]
	[Address(RVA = "0x2454AC0", Offset = "0x2454BC1", VA = "0x2454AC0")]
	public BitController()
	{
	}

	// Token: 0x04000679 RID: 1657
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected List<Vector3> m_offsets;

	// Token: 0x0400067A RID: 1658
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x20")]
	protected List<BitBase> m_bits;
}
