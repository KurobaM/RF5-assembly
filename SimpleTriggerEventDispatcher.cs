using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CE RID: 718
[Token(Token = "0x200022F")]
public class SimpleTriggerEventDispatcher : MonoBehaviour
{
	// Token: 0x1700036A RID: 874
	// (get) Token: 0x06001321 RID: 4897 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001322 RID: 4898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000336")]
	public Collider Collider
	{
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x1DE4C50", Offset = "0x1DE4D51", VA = "0x1DE4C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C9C0", Offset = "0x19CAC1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x1DE4C60", Offset = "0x1DE4D61", VA = "0x1DE4C60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C9D0", Offset = "0x19CAD1")]
		private set
		{
		}
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001166")]
	[Address(RVA = "0x1DE4C70", Offset = "0x1DE4D71", VA = "0x1DE4C70")]
	private void Start()
	{
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001167")]
	[Address(RVA = "0x1DE4CD0", Offset = "0x1DE4DD1", VA = "0x1DE4CD0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001168")]
	[Address(RVA = "0x1DE4D40", Offset = "0x1DE4E41", VA = "0x1DE4D40")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001169")]
	[Address(RVA = "0x1DE4DB0", Offset = "0x1DE4EB1", VA = "0x1DE4DB0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x1DE4E20", Offset = "0x1DE4F21", VA = "0x1DE4E20")]
	public SimpleTriggerEventDispatcher()
	{
	}

	// Token: 0x04000ACF RID: 2767
	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F370", Offset = "0x15F471")]
	private Collider <Collider>k__BackingField;

	// Token: 0x04000AD0 RID: 2768
	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x20")]
	public ColliderTriggerEvent OnTriggerEnterEvent;

	// Token: 0x04000AD1 RID: 2769
	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x28")]
	public ColliderTriggerEvent OnTriggerExitEvent;

	// Token: 0x04000AD2 RID: 2770
	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x30")]
	public ColliderTriggerEvent OnTriggerStayEvent;
}
