using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200040D RID: 1037
[Token(Token = "0x200032A")]
public class EscapeShineBall : MonoBehaviour
{
	// Token: 0x06001807 RID: 6151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001564")]
	[Address(RVA = "0x1DAE8C0", Offset = "0x1DAE9C1", VA = "0x1DAE8C0")]
	public void Hide()
	{
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x0000A620 File Offset: 0x00008820
	[Token(Token = "0x6001565")]
	[Address(RVA = "0x1DAE910", Offset = "0x1DAEA11", VA = "0x1DAE910")]
	public bool DoStartRise([Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001566")]
	[Address(RVA = "0x1DAE990", Offset = "0x1DAEA91", VA = "0x1DAE990")]
	public void DoEndRise()
	{
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x0000A638 File Offset: 0x00008838
	[Token(Token = "0x6001567")]
	[Address(RVA = "0x1DAEB80", Offset = "0x1DAEC81", VA = "0x1DAEB80")]
	public bool DoStartFall([Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001568")]
	[Address(RVA = "0x1DAEC00", Offset = "0x1DAED01", VA = "0x1DAEC00", Slot = "4")]
	public virtual void DoEndFall()
	{
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001569")]
	[Address(RVA = "0x1DAEDF0", Offset = "0x1DAEEF1", VA = "0x1DAEDF0", Slot = "5")]
	public virtual void DoPlayDust()
	{
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600156A")]
	[Address(RVA = "0x1DAF040", Offset = "0x1DAF141", VA = "0x1DAF040")]
	public EscapeShineBall()
	{
	}

	// Token: 0x04005BF0 RID: 23536
	[Token(Token = "0x4005877")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem m_ball;

	// Token: 0x04005BF1 RID: 23537
	[Token(Token = "0x4005878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator m_animator;

	// Token: 0x04005BF2 RID: 23538
	[Token(Token = "0x4005879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action m_callback;
}
