using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008BE RID: 2238
[Token(Token = "0x20005CD")]
[Serializable]
public class ConstraintBehavior : PlayableBehaviour
{
	// Token: 0x1700087B RID: 2171
	// (get) Token: 0x06003B3F RID: 15167 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B40 RID: 15168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006BE")]
	public GameObject BindTarget
	{
		[Token(Token = "0x60031A4")]
		[Address(RVA = "0x20E0F50", Offset = "0x20E1051", VA = "0x20E0F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A64D0", Offset = "0x1A65D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031A5")]
		[Address(RVA = "0x20E0F60", Offset = "0x20E1061", VA = "0x20E0F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A64E0", Offset = "0x1A65E1")]
		set
		{
		}
	}

	// Token: 0x1700087C RID: 2172
	// (get) Token: 0x06003B41 RID: 15169 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B42 RID: 15170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006BF")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x60031A6")]
		[Address(RVA = "0x20E0F70", Offset = "0x20E1071", VA = "0x20E0F70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A64F0", Offset = "0x1A65F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031A7")]
		[Address(RVA = "0x20E0F80", Offset = "0x20E1081", VA = "0x20E0F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6500", Offset = "0x1A6601")]
		set
		{
		}
	}

	// Token: 0x06003B43 RID: 15171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031A8")]
	[Address(RVA = "0x20E0F90", Offset = "0x20E1091", VA = "0x20E0F90", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	// Token: 0x06003B44 RID: 15172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031A9")]
	[Address(RVA = "0x20E1090", Offset = "0x20E1191", VA = "0x20E1090", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003B45 RID: 15173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031AA")]
	[Address(RVA = "0x20E1130", Offset = "0x20E1231", VA = "0x20E1130", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003B46 RID: 15174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031AB")]
	[Address(RVA = "0x20E1140", Offset = "0x20E1241", VA = "0x20E1140")]
	public ConstraintBehavior()
	{
	}

	// Token: 0x04007E1C RID: 32284
	[Token(Token = "0x40071D8")]
	[FieldOffset(Offset = "0x10")]
	public ConstraintPresetID PresetID;

	// Token: 0x04007E1D RID: 32285
	[Token(Token = "0x40071D9")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E840", Offset = "0x16E941")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E1E RID: 32286
	[Token(Token = "0x40071DA")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E850", Offset = "0x16E951")]
	private HumanModel <HumanModel>k__BackingField;
}
