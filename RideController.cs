using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020F RID: 527
[Token(Token = "0x20001AB")]
public abstract class RideController : MonoBehaviour
{
	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06000B02 RID: 2818 RVA: 0x000055E0 File Offset: 0x000037E0
	// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D6")]
	public bool IsRiding
	{
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x2492E80", Offset = "0x2492F81", VA = "0x2492E80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B210", Offset = "0x19B311")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x2492E90", Offset = "0x2492F91", VA = "0x2492E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B220", Offset = "0x19B321")]
		protected set
		{
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D7")]
	public virtual Actor GetActor
	{
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x2492EA0", Offset = "0x2492FA1", VA = "0x2492EA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x2492EB0", Offset = "0x2492FB1", VA = "0x2492EB0", Slot = "5")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000B06 RID: 2822
	[Token(Token = "0x60009B6")]
	public abstract void Setup();

	// Token: 0x06000B07 RID: 2823 RVA: 0x000055F8 File Offset: 0x000037F8
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x2492EC0", Offset = "0x2492FC1", VA = "0x2492EC0", Slot = "7")]
	public virtual bool DoStartRide()
	{
		return default(bool);
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x2492EE0", Offset = "0x2492FE1", VA = "0x2492EE0", Slot = "8")]
	public virtual void DoEndRide()
	{
	}

	// Token: 0x06000B09 RID: 2825
	[Token(Token = "0x60009B9")]
	public abstract void UpdateFadeAlpha(float alpha);

	// Token: 0x06000B0A RID: 2826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x2492EF0", Offset = "0x2492FF1", VA = "0x2492EF0", Slot = "10")]
	public virtual void UpdateTransform(Vector3 position, Quaternion rotation)
	{
	}

	// Token: 0x06000B0B RID: 2827
	[Token(Token = "0x60009BB")]
	public abstract void PlayDamageAction(DamageResult damageResult);

	// Token: 0x06000B0C RID: 2828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x2492F90", Offset = "0x2493091", VA = "0x2492F90")]
	protected RideController()
	{
	}

	// Token: 0x040006C7 RID: 1735
	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D3E0", Offset = "0x15D4E1")]
	private bool <IsRiding>k__BackingField;
}
