using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000535 RID: 1333
[Token(Token = "0x20003C6")]
public class FestivalSnowball : MonoBehaviour
{
	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x06002048 RID: 8264 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002049 RID: 8265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700043C")]
	public SnowballData SnowballData
	{
		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x1F81950", Offset = "0x1F81A51", VA = "0x1F81950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0310", Offset = "0x1A0411")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x1F81960", Offset = "0x1F81A61", VA = "0x1F81960")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0320", Offset = "0x1A0421")]
		private set
		{
		}
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6B")]
	[Address(RVA = "0x1F81970", Offset = "0x1F81A71", VA = "0x1F81970")]
	private void Update()
	{
	}

	// Token: 0x0600204B RID: 8267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6C")]
	[Address(RVA = "0x1F81AC0", Offset = "0x1F81BC1", VA = "0x1F81AC0")]
	public void SwitchSnowball(SnowmanObjectID _id)
	{
	}

	// Token: 0x0600204C RID: 8268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6D")]
	[Address(RVA = "0x1F81D20", Offset = "0x1F81E21", VA = "0x1F81D20")]
	public void StartFlash()
	{
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6E")]
	[Address(RVA = "0x1F81980", Offset = "0x1F81A81", VA = "0x1F81980")]
	private void UpdateFlashing()
	{
	}

	// Token: 0x0600204E RID: 8270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6F")]
	[Address(RVA = "0x1F81D30", Offset = "0x1F81E31", VA = "0x1F81D30")]
	public FestivalSnowball()
	{
	}

	// Token: 0x0400672B RID: 26411
	[Token(Token = "0x4006130")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165C30", Offset = "0x165D31")]
	private SnowballData <SnowballData>k__BackingField;

	// Token: 0x0400672C RID: 26412
	[Token(Token = "0x4006131")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Renderer rend;

	// Token: 0x0400672D RID: 26413
	[Token(Token = "0x4006132")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material[] material;

	// Token: 0x0400672E RID: 26414
	[Token(Token = "0x4006133")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] snowball;

	// Token: 0x0400672F RID: 26415
	[Token(Token = "0x4006134")]
	private const float FLASHING_SPEED = 15f;

	// Token: 0x04006730 RID: 26416
	[Token(Token = "0x4006135")]
	[FieldOffset(Offset = "0x38")]
	private bool isFlashing;
}
