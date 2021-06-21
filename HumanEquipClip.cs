using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008DD RID: 2269
[Token(Token = "0x20005E9")]
[Serializable]
public class HumanEquipClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x1700089D RID: 2205
	// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x00014E98 File Offset: 0x00013098
	[Token(Token = "0x170006E0")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6003235")]
		[Address(RVA = "0x20A2D90", Offset = "0x20A2E91", VA = "0x20A2D90", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x1700089E RID: 2206
	// (get) Token: 0x06003BDA RID: 15322 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BDB RID: 15323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006E1")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x6003236")]
		[Address(RVA = "0x20A2DA0", Offset = "0x20A2EA1", VA = "0x20A2DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6860", Offset = "0x1A6961")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003237")]
		[Address(RVA = "0x20A2DB0", Offset = "0x20A2EB1", VA = "0x20A2DB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6870", Offset = "0x1A6971")]
		set
		{
		}
	}

	// Token: 0x1700089F RID: 2207
	// (get) Token: 0x06003BDC RID: 15324 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BDD RID: 15325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006E2")]
	public GameObject BindTarget
	{
		[Token(Token = "0x6003238")]
		[Address(RVA = "0x20A2DC0", Offset = "0x20A2EC1", VA = "0x20A2DC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6880", Offset = "0x1A6981")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003239")]
		[Address(RVA = "0x20A2DD0", Offset = "0x20A2ED1", VA = "0x20A2DD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6890", Offset = "0x1A6991")]
		set
		{
		}
	}

	// Token: 0x06003BDE RID: 15326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600323A")]
	[Address(RVA = "0x20A2DE0", Offset = "0x20A2EE1", VA = "0x20A2DE0")]
	public void SetHumanModel(HumanModel humanModel)
	{
	}

	// Token: 0x06003BDF RID: 15327 RVA: 0x00014EB0 File Offset: 0x000130B0
	[Token(Token = "0x600323B")]
	[Address(RVA = "0x20A2E30", Offset = "0x20A2F31", VA = "0x20A2E30", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003BE0 RID: 15328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600323C")]
	[Address(RVA = "0x20A2FF0", Offset = "0x20A30F1", VA = "0x20A2FF0")]
	public HumanEquipClip()
	{
	}

	// Token: 0x04007E6E RID: 32366
	[Token(Token = "0x4007223")]
	[FieldOffset(Offset = "0x18")]
	public HumanEquipBehavior template;

	// Token: 0x04007E6F RID: 32367
	[Token(Token = "0x4007224")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EB20", Offset = "0x16EC21")]
	private HumanModel <HumanModel>k__BackingField;

	// Token: 0x04007E70 RID: 32368
	[Token(Token = "0x4007225")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EB30", Offset = "0x16EC31")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E71 RID: 32369
	[Token(Token = "0x4007226")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ExposedReference<Transform> equipItem;

	// Token: 0x04007E72 RID: 32370
	[Token(Token = "0x4007227")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private HumanAttachIDEnum attachIDEnum;

	// Token: 0x04007E73 RID: 32371
	[Token(Token = "0x4007228")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ExposedReference<Transform> returnItem;

	// Token: 0x04007E74 RID: 32372
	[Token(Token = "0x4007229")]
	[FieldOffset(Offset = "0x58")]
	private HumanEquipBehavior humanEquipBehavior;
}
