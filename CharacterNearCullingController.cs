using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B3 RID: 691
[Token(Token = "0x2000220")]
public class CharacterNearCullingController : MonoBehaviour
{
	// Token: 0x1700032E RID: 814
	// (get) Token: 0x0600120A RID: 4618 RVA: 0x00008478 File Offset: 0x00006678
	// (set) Token: 0x0600120B RID: 4619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000304")]
	public bool IsStay
	{
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x1E95760", Offset = "0x1E95861", VA = "0x1E95760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C610", Offset = "0x19C711")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001074")]
		[Address(RVA = "0x1E95770", Offset = "0x1E95871", VA = "0x1E95770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C620", Offset = "0x19C721")]
		set
		{
		}
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001075")]
	[Address(RVA = "0x1E95780", Offset = "0x1E95881", VA = "0x1E95780")]
	private void Start()
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001076")]
	[Address(RVA = "0x1E95910", Offset = "0x1E95A11", VA = "0x1E95910")]
	private void OnEnable()
	{
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x1E95920", Offset = "0x1E95A21", VA = "0x1E95920")]
	private void Update()
	{
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x1E958B0", Offset = "0x1E959B1", VA = "0x1E958B0")]
	public void Reset()
	{
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x1E95A00", Offset = "0x1E95B01", VA = "0x1E95A00")]
	public CharacterNearCullingController()
	{
	}

	// Token: 0x04000A27 RID: 2599
	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CharacterModel model;

	// Token: 0x04000A28 RID: 2600
	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float FadeTime;

	// Token: 0x04000A29 RID: 2601
	[Token(Token = "0x4000802")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EF30", Offset = "0x15F031")]
	private bool <IsStay>k__BackingField;
}
