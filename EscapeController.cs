using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FC RID: 508
[Token(Token = "0x2000199")]
public abstract class EscapeController : MonoBehaviour
{
	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06000A6E RID: 2670
	[Token(Token = "0x170001C2")]
	public abstract bool IsPlaying { [Token(Token = "0x600091E")] get; }

	// Token: 0x06000A6F RID: 2671
	[Token(Token = "0x600091F")]
	public abstract bool DoRise([Optional] Action callback);

	// Token: 0x06000A70 RID: 2672
	[Token(Token = "0x6000920")]
	public abstract bool DoFall([Optional] Action callback);

	// Token: 0x06000A71 RID: 2673
	[Token(Token = "0x6000921")]
	public abstract void DoEnd();

	// Token: 0x06000A72 RID: 2674
	[Token(Token = "0x6000922")]
	public abstract bool DoTakeOff();

	// Token: 0x06000A73 RID: 2675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000923")]
	[Address(RVA = "0x1DAE190", Offset = "0x1DAE291", VA = "0x1DAE190", Slot = "9")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000924")]
	[Address(RVA = "0x1DAE1A0", Offset = "0x1DAE2A1", VA = "0x1DAE1A0")]
	protected EscapeController()
	{
	}

	// Token: 0x04000684 RID: 1668
	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Action m_Callback;
}
