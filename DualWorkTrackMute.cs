using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008C9 RID: 2249
[Token(Token = "0x20005D7")]
public class DualWorkTrackMute : MonoBehaviour
{
	// Token: 0x17000882 RID: 2178
	// (get) Token: 0x06003B68 RID: 15208 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B69 RID: 15209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006C5")]
	private PlayableDirector Director
	{
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x1E0E200", Offset = "0x1E0E301", VA = "0x1E0E200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6570", Offset = "0x1A6671")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031CB")]
		[Address(RVA = "0x1E0E210", Offset = "0x1E0E311", VA = "0x1E0E210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6580", Offset = "0x1A6681")]
		set
		{
		}
	}

	// Token: 0x17000883 RID: 2179
	// (get) Token: 0x06003B6A RID: 15210 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B6B RID: 15211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006C6")]
	private GroupTrack SuccessGroup
	{
		[Token(Token = "0x60031CC")]
		[Address(RVA = "0x1E0E220", Offset = "0x1E0E321", VA = "0x1E0E220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6590", Offset = "0x1A6691")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031CD")]
		[Address(RVA = "0x1E0E230", Offset = "0x1E0E331", VA = "0x1E0E230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A65A0", Offset = "0x1A66A1")]
		set
		{
		}
	}

	// Token: 0x17000884 RID: 2180
	// (get) Token: 0x06003B6C RID: 15212 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B6D RID: 15213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006C7")]
	private GroupTrack FailGroup
	{
		[Token(Token = "0x60031CE")]
		[Address(RVA = "0x1E0E240", Offset = "0x1E0E341", VA = "0x1E0E240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A65B0", Offset = "0x1A66B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031CF")]
		[Address(RVA = "0x1E0E250", Offset = "0x1E0E351", VA = "0x1E0E250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A65C0", Offset = "0x1A66C1")]
		set
		{
		}
	}

	// Token: 0x06003B6E RID: 15214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x1E0E260", Offset = "0x1E0E361", VA = "0x1E0E260")]
	private void Awake()
	{
	}

	// Token: 0x06003B6F RID: 15215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031D1")]
	[Address(RVA = "0x1E0C540", Offset = "0x1E0C641", VA = "0x1E0C540")]
	public void Success()
	{
	}

	// Token: 0x06003B70 RID: 15216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031D2")]
	[Address(RVA = "0x1E0C5C0", Offset = "0x1E0C6C1", VA = "0x1E0C5C0")]
	public void Fail()
	{
	}

	// Token: 0x06003B71 RID: 15217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031D3")]
	[Address(RVA = "0x1E0E730", Offset = "0x1E0E831", VA = "0x1E0E730")]
	private void RebuildGraph()
	{
	}

	// Token: 0x06003B72 RID: 15218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031D4")]
	[Address(RVA = "0x1E0E790", Offset = "0x1E0E891", VA = "0x1E0E790")]
	public DualWorkTrackMute()
	{
	}

	// Token: 0x04007E2F RID: 32303
	[Token(Token = "0x40071E9")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E8C0", Offset = "0x16E9C1")]
	private PlayableDirector <Director>k__BackingField;

	// Token: 0x04007E30 RID: 32304
	[Token(Token = "0x40071EA")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E8D0", Offset = "0x16E9D1")]
	private GroupTrack <SuccessGroup>k__BackingField;

	// Token: 0x04007E31 RID: 32305
	[Token(Token = "0x40071EB")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E8E0", Offset = "0x16E9E1")]
	private GroupTrack <FailGroup>k__BackingField;
}
