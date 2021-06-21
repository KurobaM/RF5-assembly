using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008BB RID: 2235
[Token(Token = "0x20005CA")]
[Serializable]
public class ChangeAvatorClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000879 RID: 2169
	// (get) Token: 0x06003B36 RID: 15158 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B37 RID: 15159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006BC")]
	public Animator TargetAnimator
	{
		[Token(Token = "0x600319B")]
		[Address(RVA = "0x1E82050", Offset = "0x1E82151", VA = "0x1E82050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A64B0", Offset = "0x1A65B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600319C")]
		[Address(RVA = "0x1E82060", Offset = "0x1E82161", VA = "0x1E82060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A64C0", Offset = "0x1A65C1")]
		set
		{
		}
	}

	// Token: 0x1700087A RID: 2170
	// (get) Token: 0x06003B38 RID: 15160 RVA: 0x00014C28 File Offset: 0x00012E28
	[Token(Token = "0x170006BD")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600319D")]
		[Address(RVA = "0x1E82070", Offset = "0x1E82171", VA = "0x1E82070", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06003B39 RID: 15161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600319E")]
	[Address(RVA = "0x1E82080", Offset = "0x1E82181", VA = "0x1E82080")]
	public void SetAvatar(Avatar avatar)
	{
	}

	// Token: 0x06003B3A RID: 15162 RVA: 0x00014C40 File Offset: 0x00012E40
	[Token(Token = "0x600319F")]
	[Address(RVA = "0x1E82090", Offset = "0x1E82191", VA = "0x1E82090", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003B3B RID: 15163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031A0")]
	[Address(RVA = "0x1E82190", Offset = "0x1E82291", VA = "0x1E82190")]
	public ChangeAvatorClip()
	{
	}

	// Token: 0x04007E19 RID: 32281
	[Token(Token = "0x40071D5")]
	[FieldOffset(Offset = "0x18")]
	public ChangeAvatorBehavior template;

	// Token: 0x04007E1A RID: 32282
	[Token(Token = "0x40071D6")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E820", Offset = "0x16E921")]
	private Animator <TargetAnimator>k__BackingField;

	// Token: 0x04007E1B RID: 32283
	[Token(Token = "0x40071D7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Avatar Avatar;
}
