using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008CE RID: 2254
[Token(Token = "0x20005DC")]
[Serializable]
public class EmotionBehavior : PlayableBehaviour
{
	// Token: 0x17000889 RID: 2185
	// (get) Token: 0x06003B82 RID: 15234 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B83 RID: 15235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006CC")]
	public GameObject BindTarget
	{
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x22AEB30", Offset = "0x22AEC31", VA = "0x22AEB30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6630", Offset = "0x1A6731")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x22AEB40", Offset = "0x22AEC41", VA = "0x22AEB40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6640", Offset = "0x1A6741")]
		set
		{
		}
	}

	// Token: 0x1700088A RID: 2186
	// (get) Token: 0x06003B84 RID: 15236 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B85 RID: 15237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006CD")]
	public CharacterModel CharaModel
	{
		[Token(Token = "0x60031E6")]
		[Address(RVA = "0x22AEB50", Offset = "0x22AEC51", VA = "0x22AEB50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6650", Offset = "0x1A6751")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x22AEB60", Offset = "0x22AEC61", VA = "0x22AEB60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6660", Offset = "0x1A6761")]
		set
		{
		}
	}

	// Token: 0x1700088B RID: 2187
	// (get) Token: 0x06003B86 RID: 15238 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B87 RID: 15239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006CE")]
	public EmotionEffectController Effect
	{
		[Token(Token = "0x60031E8")]
		[Address(RVA = "0x22AEB70", Offset = "0x22AEC71", VA = "0x22AEB70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6670", Offset = "0x1A6771")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031E9")]
		[Address(RVA = "0x22AEB80", Offset = "0x22AEC81", VA = "0x22AEB80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6680", Offset = "0x1A6781")]
		set
		{
		}
	}

	// Token: 0x06003B88 RID: 15240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031EA")]
	[Address(RVA = "0x22AEB90", Offset = "0x22AEC91", VA = "0x22AEB90", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	// Token: 0x06003B89 RID: 15241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031EB")]
	[Address(RVA = "0x22AEC90", Offset = "0x22AED91", VA = "0x22AEC90", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003B8A RID: 15242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031EC")]
	[Address(RVA = "0x22AF100", Offset = "0x22AF201", VA = "0x22AF100", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003B8B RID: 15243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031ED")]
	[Address(RVA = "0x22AF1C0", Offset = "0x22AF2C1", VA = "0x22AF1C0")]
	public EmotionBehavior()
	{
	}

	// Token: 0x04007E37 RID: 32311
	[Token(Token = "0x40071F1")]
	[FieldOffset(Offset = "0x10")]
	public EmotionType EmotionType;

	// Token: 0x04007E38 RID: 32312
	[Token(Token = "0x40071F2")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 Offset;

	// Token: 0x04007E39 RID: 32313
	[Token(Token = "0x40071F3")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E930", Offset = "0x16EA31")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E3A RID: 32314
	[Token(Token = "0x40071F4")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E940", Offset = "0x16EA41")]
	private CharacterModel <CharaModel>k__BackingField;

	// Token: 0x04007E3B RID: 32315
	[Token(Token = "0x40071F5")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E950", Offset = "0x16EA51")]
	private EmotionEffectController <Effect>k__BackingField;
}
