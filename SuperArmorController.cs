using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D2 RID: 722
[Token(Token = "0x2000233")]
public class SuperArmorController : MonoBehaviour
{
	// Token: 0x1700036C RID: 876
	// (get) Token: 0x0600133B RID: 4923 RVA: 0x00008A48 File Offset: 0x00006C48
	// (set) Token: 0x0600133C RID: 4924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000338")]
	public float Duration
	{
		[Token(Token = "0x600117E")]
		[Address(RVA = "0x1FAB7A0", Offset = "0x1FAB8A1", VA = "0x1FAB7A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA10", Offset = "0x19CB11")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600117F")]
		[Address(RVA = "0x1FAB7B0", Offset = "0x1FAB8B1", VA = "0x1FAB7B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA20", Offset = "0x19CB21")]
		protected set
		{
		}
	}

	// Token: 0x1700036D RID: 877
	// (get) Token: 0x0600133D RID: 4925 RVA: 0x00008A60 File Offset: 0x00006C60
	// (set) Token: 0x0600133E RID: 4926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000339")]
	public float Elapsed
	{
		[Token(Token = "0x6001180")]
		[Address(RVA = "0x1FAB7C0", Offset = "0x1FAB8C1", VA = "0x1FAB7C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA30", Offset = "0x19CB31")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001181")]
		[Address(RVA = "0x1FAB7D0", Offset = "0x1FAB8D1", VA = "0x1FAB7D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA40", Offset = "0x19CB41")]
		protected set
		{
		}
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x0600133F RID: 4927 RVA: 0x00008A78 File Offset: 0x00006C78
	// (set) Token: 0x06001340 RID: 4928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700033A")]
	public bool IsPlaying
	{
		[Token(Token = "0x6001182")]
		[Address(RVA = "0x1FAB7E0", Offset = "0x1FAB8E1", VA = "0x1FAB7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA50", Offset = "0x19CB51")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001183")]
		[Address(RVA = "0x1FAB7F0", Offset = "0x1FAB8F1", VA = "0x1FAB7F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA60", Offset = "0x19CB61")]
		set
		{
		}
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001184")]
	[Address(RVA = "0x1FAB800", Offset = "0x1FAB901", VA = "0x1FAB800", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001185")]
	[Address(RVA = "0x1FAB810", Offset = "0x1FAB911", VA = "0x1FAB810", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001186")]
	[Address(RVA = "0x1FAB820", Offset = "0x1FAB921", VA = "0x1FAB820", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001187")]
	[Address(RVA = "0x1FAB830", Offset = "0x1FAB931", VA = "0x1FAB830", Slot = "7")]
	public virtual void DoPlay(float duration)
	{
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001188")]
	[Address(RVA = "0x1FAB850", Offset = "0x1FAB951", VA = "0x1FAB850", Slot = "8")]
	public virtual void DoStop()
	{
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001189")]
	[Address(RVA = "0x1FAB860", Offset = "0x1FAB961", VA = "0x1FAB860")]
	public void OnUpdate()
	{
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118A")]
	[Address(RVA = "0x1FAB8D0", Offset = "0x1FAB9D1", VA = "0x1FAB8D0")]
	public SuperArmorController()
	{
	}

	// Token: 0x04000ADB RID: 2779
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F3B0", Offset = "0x15F4B1")]
	private float <Duration>k__BackingField;

	// Token: 0x04000ADC RID: 2780
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F3C0", Offset = "0x15F4C1")]
	private float <Elapsed>k__BackingField;

	// Token: 0x04000ADD RID: 2781
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F3D0", Offset = "0x15F4D1")]
	private bool <IsPlaying>k__BackingField;
}
