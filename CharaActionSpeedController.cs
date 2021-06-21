using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BC RID: 444
[Token(Token = "0x200015C")]
public class CharaActionSpeedController<T> : ActionSpeedController where T : Character
{
	// Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000803")]
	protected override void Awake()
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000804")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000805")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000806")]
	protected override void OnChangeSpeed(float current, float next)
	{
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000807")]
	public override void DoPlay(float speed, float duration)
	{
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000808")]
	public override void DoStop()
	{
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000809")]
	public CharaActionSpeedController()
	{
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AEA0", Offset = "0x19AFA1")]
	private void <DoPlay>b__6_0(ParticleSystem effect)
	{
	}

	// Token: 0x040005BD RID: 1469
	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x0")]
	protected ParticleSystem m_effect;
}
