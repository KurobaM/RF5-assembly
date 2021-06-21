using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000211 RID: 529
[Token(Token = "0x20001AD")]
public class SoulController : MonoBehaviour
{
	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00005628 File Offset: 0x00003828
	// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DA")]
	public virtual bool IsPlaying
	{
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x2257800", Offset = "0x2257901", VA = "0x2257800", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B230", Offset = "0x19B331")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x2257810", Offset = "0x2257911", VA = "0x2257810", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B240", Offset = "0x19B341")]
		protected set
		{
		}
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00005640 File Offset: 0x00003840
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x2257820", Offset = "0x2257921", VA = "0x2257820", Slot = "6")]
	public virtual bool DoPlay(Collider target, Action callback)
	{
		return default(bool);
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x2257830", Offset = "0x2257931", VA = "0x2257830", Slot = "7")]
	public virtual void DoEnd()
	{
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x2257840", Offset = "0x2257941", VA = "0x2257840")]
	public SoulController()
	{
	}

	// Token: 0x040006CA RID: 1738
	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D410", Offset = "0x15D511")]
	private bool <IsPlaying>k__BackingField;
}
