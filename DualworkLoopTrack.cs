using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008CD RID: 2253
[Token(Token = "0x20005DB")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146A60", Offset = "0x146B61")]
public class DualworkLoopTrack : TrackAsset
{
	// Token: 0x17000888 RID: 2184
	// (get) Token: 0x06003B7D RID: 15229 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B7E RID: 15230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006CB")]
	public static TimelineClip DualworkLoopClip
	{
		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x1E0E8D0", Offset = "0x1E0E9D1", VA = "0x1E0E8D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6610", Offset = "0x1A6711")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x1E0E940", Offset = "0x1E0EA41", VA = "0x1E0E940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6620", Offset = "0x1A6721")]
		set
		{
		}
	}

	// Token: 0x06003B7F RID: 15231 RVA: 0x00014D78 File Offset: 0x00012F78
	[Token(Token = "0x60031E1")]
	[Address(RVA = "0x1E0E9B0", Offset = "0x1E0EAB1", VA = "0x1E0E9B0", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003B80 RID: 15232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031E2")]
	[Address(RVA = "0x1E0EE00", Offset = "0x1E0EF01", VA = "0x1E0EE00")]
	public DualworkLoopTrack()
	{
	}

	// Token: 0x04007E35 RID: 32309
	[Token(Token = "0x40071EF")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public bool IsLoopThrough;

	// Token: 0x04007E36 RID: 32310
	[Token(Token = "0x40071F0")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E920", Offset = "0x16EA21")]
	private static TimelineClip <DualworkLoopClip>k__BackingField;
}
