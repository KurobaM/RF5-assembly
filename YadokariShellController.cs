using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200077D RID: 1917
[Token(Token = "0x200051F")]
public class YadokariShellController : MonoBehaviour
{
	// Token: 0x170006EC RID: 1772
	// (get) Token: 0x06003199 RID: 12697 RVA: 0x000112E0 File Offset: 0x0000F4E0
	// (set) Token: 0x0600319A RID: 12698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700057E")]
	public bool IsThrow
	{
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x284DFB0", Offset = "0x284E0B1", VA = "0x284DFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4780", Offset = "0x1A4881")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x284DFC0", Offset = "0x284E0C1", VA = "0x284DFC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4790", Offset = "0x1A4891")]
		private set
		{
		}
	}

	// Token: 0x0600319B RID: 12699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029A6")]
	[Address(RVA = "0x284DFD0", Offset = "0x284E0D1", VA = "0x284DFD0")]
	private void Start()
	{
	}

	// Token: 0x0600319C RID: 12700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029A7")]
	[Address(RVA = "0x284E050", Offset = "0x284E151", VA = "0x284E050")]
	public void ResetShell()
	{
	}

	// Token: 0x0600319D RID: 12701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029A8")]
	[Address(RVA = "0x284D700", Offset = "0x284D801", VA = "0x284D700")]
	public void Throw(Vector3 controllerforward, Vector3 targetPosition, float jumpPower, float duration)
	{
	}

	// Token: 0x0600319E RID: 12702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029A9")]
	[Address(RVA = "0x284D9D0", Offset = "0x284DAD1", VA = "0x284D9D0")]
	public void Pickup(float duration)
	{
	}

	// Token: 0x0600319F RID: 12703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029AA")]
	[Address(RVA = "0x284CBA0", Offset = "0x284CCA1", VA = "0x284CBA0")]
	public void Clear()
	{
	}

	// Token: 0x060031A0 RID: 12704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029AB")]
	[Address(RVA = "0x284E130", Offset = "0x284E231", VA = "0x284E130")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x060031A1 RID: 12705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029AC")]
	[Address(RVA = "0x284E2E0", Offset = "0x284E3E1", VA = "0x284E2E0")]
	public YadokariShellController()
	{
	}

	// Token: 0x060031A2 RID: 12706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029AD")]
	[Address(RVA = "0x284E390", Offset = "0x284E491", VA = "0x284E390")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A47A0", Offset = "0x1A48A1")]
	private void <Pickup>b__17_1()
	{
	}

	// Token: 0x060031A3 RID: 12707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029AE")]
	[Address(RVA = "0x284E3A0", Offset = "0x284E4A1", VA = "0x284E3A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A47B0", Offset = "0x1A48B1")]
	private void <Clear>b__18_0()
	{
	}

	// Token: 0x0400765F RID: 30303
	[Token(Token = "0x4006C53")]
	[FieldOffset(Offset = "0x18")]
	private readonly Vector3 StartLocalPosition;

	// Token: 0x04007660 RID: 30304
	[Token(Token = "0x4006C54")]
	[FieldOffset(Offset = "0x24")]
	private readonly Vector3 StartLocalRotation;

	// Token: 0x04007661 RID: 30305
	[Token(Token = "0x4006C55")]
	private const float Angle = 360f;

	// Token: 0x04007662 RID: 30306
	[Token(Token = "0x4006C56")]
	private const float ShellAroundRotateTime = 1f;

	// Token: 0x04007663 RID: 30307
	[Token(Token = "0x4006C57")]
	private const float ClearTime = 1f;

	// Token: 0x04007664 RID: 30308
	[Token(Token = "0x4006C58")]
	[FieldOffset(Offset = "0x30")]
	private Collider Collider;

	// Token: 0x04007665 RID: 30309
	[Token(Token = "0x4006C59")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform ParentTransform;

	// Token: 0x04007666 RID: 30310
	[Token(Token = "0x4006C5A")]
	[FieldOffset(Offset = "0x40")]
	private TweenerCore<Vector3, Vector3, VectorOptions> ShellTweenCore;

	// Token: 0x04007667 RID: 30311
	[Token(Token = "0x4006C5B")]
	[FieldOffset(Offset = "0x48")]
	private TweenerCore<Vector3, Vector3, VectorOptions> ParentShellTweenCore;

	// Token: 0x04007668 RID: 30312
	[Token(Token = "0x4006C5C")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1699D0", Offset = "0x169AD1")]
	private bool <IsThrow>k__BackingField;

	// Token: 0x04007669 RID: 30313
	[Token(Token = "0x4006C5D")]
	[FieldOffset(Offset = "0x51")]
	private bool IsClear;

	// Token: 0x0200077E RID: 1918
	[Token(Token = "0x20011E5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158770", Offset = "0x158871")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060031A5 RID: 12709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E1")]
		[Address(RVA = "0x284E490", Offset = "0x284E591", VA = "0x284E490")]
		public <>c()
		{
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E2")]
		[Address(RVA = "0x284E4A0", Offset = "0x284E5A1", VA = "0x284E4A0")]
		internal void <Pickup>b__17_0()
		{
		}

		// Token: 0x0400766A RID: 30314
		[Token(Token = "0x4019675")]
		[FieldOffset(Offset = "0x0")]
		public static readonly YadokariShellController.<>c <>9;

		// Token: 0x0400766B RID: 30315
		[Token(Token = "0x4019676")]
		[FieldOffset(Offset = "0x8")]
		public static TweenCallback <>9__17_0;
	}
}
