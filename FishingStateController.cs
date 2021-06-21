using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000202 RID: 514
[Token(Token = "0x200019E")]
public abstract class FishingStateController : MonoBehaviour
{
	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000053D0 File Offset: 0x000035D0
	// (set) Token: 0x06000A89 RID: 2697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C6")]
	public FishingState State
	{
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1EC84C0", Offset = "0x1EC85C1", VA = "0x1EC84C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B0B0", Offset = "0x19B1B1")]
		get
		{
			return FishingState.None;
		}
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1EC84D0", Offset = "0x1EC85D1", VA = "0x1EC84D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B0C0", Offset = "0x19B1C1")]
		protected set
		{
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06000A8A RID: 2698 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x170001C7")]
	public bool IsPlaying
	{
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x1EC84E0", Offset = "0x1EC85E1", VA = "0x1EC84E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093B")]
	[Address(RVA = "0x1EC84F0", Offset = "0x1EC85F1", VA = "0x1EC84F0")]
	public void SetState(FishingState newState)
	{
	}

	// Token: 0x06000A8C RID: 2700
	[Token(Token = "0x600093C")]
	public abstract void OnExit();

	// Token: 0x06000A8D RID: 2701
	[Token(Token = "0x600093D")]
	public abstract bool DoWkiCast();

	// Token: 0x06000A8E RID: 2702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093E")]
	[Address(RVA = "0x1EC8500", Offset = "0x1EC8601", VA = "0x1EC8500")]
	protected FishingStateController()
	{
	}

	// Token: 0x040006A1 RID: 1697
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D250", Offset = "0x15D351")]
	private FishingState <State>k__BackingField;
}
