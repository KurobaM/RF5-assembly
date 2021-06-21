using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000331 RID: 817
[Token(Token = "0x2000264")]
public class TimeScaleManager : SingletonMonoBehaviour<TimeScaleManager>
{
	// Token: 0x06001607 RID: 5639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001389")]
	[Address(RVA = "0x206B580", Offset = "0x206B681", VA = "0x206B580")]
	private void OnDisable()
	{
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138A")]
	[Address(RVA = "0x206B620", Offset = "0x206B721", VA = "0x206B620")]
	private void Update()
	{
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x00009E10 File Offset: 0x00008010
	[Token(Token = "0x600138B")]
	[Address(RVA = "0x206B730", Offset = "0x206B831", VA = "0x206B730")]
	public bool Play(TimeScaleID timeScaleID)
	{
		return default(bool);
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138C")]
	[Address(RVA = "0x206B5D0", Offset = "0x206B6D1", VA = "0x206B5D0")]
	public void Stop()
	{
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138D")]
	[Address(RVA = "0x206B8D0", Offset = "0x206B9D1", VA = "0x206B8D0")]
	public TimeScaleManager()
	{
	}

	// Token: 0x04000CB4 RID: 3252
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x18")]
	private float m_Elapsed;

	// Token: 0x04000CB5 RID: 3253
	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x1C")]
	private float m_EndTime;

	// Token: 0x04000CB6 RID: 3254
	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x20")]
	private AnimationCurve m_CurrentTimeScale;
}
