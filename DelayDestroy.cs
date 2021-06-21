using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005C0 RID: 1472
[Token(Token = "0x2000422")]
public class DelayDestroy : MonoBehaviour
{
	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x0600241A RID: 9242 RVA: 0x0000EA78 File Offset: 0x0000CC78
	// (set) Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004B7")]
	public float ElapsedTime
	{
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x1DFA4D0", Offset = "0x1DFA5D1", VA = "0x1DFA4D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A12B0", Offset = "0x1A13B1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x1DFA4E0", Offset = "0x1DFA5E1", VA = "0x1DFA4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A12C0", Offset = "0x1A13C1")]
		private set
		{
		}
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E62")]
	[Address(RVA = "0x1DFA4F0", Offset = "0x1DFA5F1", VA = "0x1DFA4F0")]
	private void Start()
	{
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E63")]
	[Address(RVA = "0x1DFA500", Offset = "0x1DFA601", VA = "0x1DFA500")]
	private void Update()
	{
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E64")]
	[Address(RVA = "0x1DFA5F0", Offset = "0x1DFA6F1", VA = "0x1DFA5F0")]
	public DelayDestroy()
	{
	}

	// Token: 0x04006B81 RID: 27521
	[Token(Token = "0x40064D8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float DelayTime;

	// Token: 0x04006B82 RID: 27522
	[Token(Token = "0x40064D9")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166BF0", Offset = "0x166CF1")]
	private float <ElapsedTime>k__BackingField;
}
