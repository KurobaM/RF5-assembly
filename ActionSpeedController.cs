using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BB RID: 443
[Token(Token = "0x200015B")]
public class ActionSpeedController : MonoBehaviour
{
	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x0600093F RID: 2367 RVA: 0x00004F38 File Offset: 0x00003138
	// (set) Token: 0x06000940 RID: 2368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A3")]
	public float Speed
	{
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1D45D50", Offset = "0x1D45E51", VA = "0x1D45D50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AE20", Offset = "0x19AF21")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1D45D60", Offset = "0x1D45E61", VA = "0x1D45D60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AE30", Offset = "0x19AF31")]
		protected set
		{
		}
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000941 RID: 2369 RVA: 0x00004F50 File Offset: 0x00003150
	// (set) Token: 0x06000942 RID: 2370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A4")]
	public float Duration
	{
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1D45D70", Offset = "0x1D45E71", VA = "0x1D45D70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AE40", Offset = "0x19AF41")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1D45D80", Offset = "0x1D45E81", VA = "0x1D45D80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AE50", Offset = "0x19AF51")]
		protected set
		{
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06000943 RID: 2371 RVA: 0x00004F68 File Offset: 0x00003168
	// (set) Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A5")]
	public float Elapsed
	{
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1D45D90", Offset = "0x1D45E91", VA = "0x1D45D90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AE60", Offset = "0x19AF61")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1D45DA0", Offset = "0x1D45EA1", VA = "0x1D45DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AE70", Offset = "0x19AF71")]
		protected set
		{
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06000945 RID: 2373 RVA: 0x00004F80 File Offset: 0x00003180
	// (set) Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A6")]
	public bool IsPlaying
	{
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1D45DB0", Offset = "0x1D45EB1", VA = "0x1D45DB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AE80", Offset = "0x19AF81")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1D45DC0", Offset = "0x1D45EC1", VA = "0x1D45DC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AE90", Offset = "0x19AF91")]
		set
		{
		}
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x1D45DD0", Offset = "0x1D45ED1", VA = "0x1D45DD0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x1D45DE0", Offset = "0x1D45EE1", VA = "0x1D45DE0", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x1D45DF0", Offset = "0x1D45EF1", VA = "0x1D45DF0", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x1D45E00", Offset = "0x1D45F01", VA = "0x1D45E00", Slot = "7")]
	public virtual void DoPlay(float speed, float duration)
	{
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x1D45EA0", Offset = "0x1D45FA1", VA = "0x1D45EA0", Slot = "8")]
	public virtual void DoStop()
	{
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x1D45EE0", Offset = "0x1D45FE1", VA = "0x1D45EE0")]
	public void OnUpdate()
	{
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x1D45E60", Offset = "0x1D45F61", VA = "0x1D45E60")]
	protected void ChangeSpeed(float next)
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x1D45F50", Offset = "0x1D46051", VA = "0x1D45F50", Slot = "9")]
	protected virtual void OnChangeSpeed(float current, float next)
	{
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x1D45F60", Offset = "0x1D46061", VA = "0x1D45F60")]
	public ActionSpeedController()
	{
	}

	// Token: 0x040005B9 RID: 1465
	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CB00", Offset = "0x15CC01")]
	private float <Speed>k__BackingField;

	// Token: 0x040005BA RID: 1466
	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CB10", Offset = "0x15CC11")]
	private float <Duration>k__BackingField;

	// Token: 0x040005BB RID: 1467
	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CB20", Offset = "0x15CC21")]
	private float <Elapsed>k__BackingField;

	// Token: 0x040005BC RID: 1468
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CB30", Offset = "0x15CC31")]
	private bool <IsPlaying>k__BackingField;
}
