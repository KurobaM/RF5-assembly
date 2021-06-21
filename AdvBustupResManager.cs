using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x0200090D RID: 2317
[Token(Token = "0x2000615")]
public class AdvBustupResManager : SingletonMonoBehaviour<AdvBustupResManager>
{
	// Token: 0x06003CBA RID: 15546 RVA: 0x000151B0 File Offset: 0x000133B0
	[Token(Token = "0x600330E")]
	[Address(RVA = "0x1D57500", Offset = "0x1D57601", VA = "0x1D57500")]
	private BUSTUPID CheckChangeBUSTUPID(BUSTUPID npcid, int poseId, int costumeId)
	{
		return BUSTUPID.Ares;
	}

	// Token: 0x06003CBB RID: 15547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600330F")]
	[Address(RVA = "0x1D57940", Offset = "0x1D57A41", VA = "0x1D57940")]
	private void CheckInit()
	{
	}

	// Token: 0x06003CBC RID: 15548 RVA: 0x000151C8 File Offset: 0x000133C8
	[Token(Token = "0x6003310")]
	[Address(RVA = "0x1D57A90", Offset = "0x1D57B91", VA = "0x1D57A90")]
	private int ChildColor(int ChildNo)
	{
		return 0;
	}

	// Token: 0x06003CBD RID: 15549 RVA: 0x000151E0 File Offset: 0x000133E0
	[Token(Token = "0x6003311")]
	[Address(RVA = "0x1D57B30", Offset = "0x1D57C31", VA = "0x1D57B30")]
	public int GetLoaderID(BUSTUPID npcid, int poseId, int costumeId, AdvCharaImageControl advCharaImageControl)
	{
		return 0;
	}

	// Token: 0x06003CBE RID: 15550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003312")]
	[Address(RVA = "0x1D57EC0", Offset = "0x1D57FC1", VA = "0x1D57EC0")]
	public BustupDataList.MouthTable GetDefaultMouthID(BUSTUPID bustupId, int poseId, int costumeId)
	{
		return null;
	}

	// Token: 0x06003CBF RID: 15551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003313")]
	[Address(RVA = "0x1D580C0", Offset = "0x1D581C1", VA = "0x1D580C0")]
	public static void SetLoader(int loaderId, AdvCharaImageControl advCharaImageControl)
	{
	}

	// Token: 0x06003CC0 RID: 15552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003314")]
	[Address(RVA = "0x1D58280", Offset = "0x1D58381", VA = "0x1D58280")]
	public static void RemoveLoader(int loaderId, GameObject go)
	{
	}

	// Token: 0x06003CC1 RID: 15553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003315")]
	[Address(RVA = "0x1D583C0", Offset = "0x1D584C1", VA = "0x1D583C0")]
	public static string GetShortName(BUSTUPID npcid, int val1, int val2, int poseId, int costumeId)
	{
		return null;
	}

	// Token: 0x06003CC2 RID: 15554 RVA: 0x000151F8 File Offset: 0x000133F8
	[Token(Token = "0x6003316")]
	[Address(RVA = "0x1D57740", Offset = "0x1D57841", VA = "0x1D57740")]
	private static bool IsLucusWearingGlasses()
	{
		return default(bool);
	}

	// Token: 0x06003CC3 RID: 15555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003317")]
	[Address(RVA = "0x1D58950", Offset = "0x1D58A51", VA = "0x1D58950")]
	public AdvBustupResManager()
	{
	}

	// Token: 0x04007F21 RID: 32545
	[Token(Token = "0x40072C6")]
	[FieldOffset(Offset = "0x0")]
	public static float[] BustupScaleTable;

	// Token: 0x04007F22 RID: 32546
	[Token(Token = "0x40072C7")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, int> LoaderDictionary;

	// Token: 0x04007F23 RID: 32547
	[Token(Token = "0x40072C8")]
	[FieldOffset(Offset = "0x20")]
	private BustupDataList BustupDataList;

	// Token: 0x0200090E RID: 2318
	[Token(Token = "0x200127B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158DE0", Offset = "0x158EE1")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x06003CC5 RID: 15557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007493")]
		[Address(RVA = "0x1D58260", Offset = "0x1D58361", VA = "0x1D58260")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x04007F24 RID: 32548
		[Token(Token = "0x40198C0")]
		[FieldOffset(Offset = "0x10")]
		public AdvCharaImageControl advCharaImageControl;
	}

	// Token: 0x0200090F RID: 2319
	[Token(Token = "0x200127C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158DF0", Offset = "0x158EF1")]
	private sealed class <>c__DisplayClass7_1
	{
		// Token: 0x06003CC6 RID: 15558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007494")]
		[Address(RVA = "0x1D58270", Offset = "0x1D58371", VA = "0x1D58270")]
		public <>c__DisplayClass7_1()
		{
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007495")]
		[Address(RVA = "0x1D58A20", Offset = "0x1D58B21", VA = "0x1D58A20")]
		internal void <SetLoader>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04007F25 RID: 32549
		[Token(Token = "0x40198C1")]
		[FieldOffset(Offset = "0x10")]
		public int instanceID;

		// Token: 0x04007F26 RID: 32550
		[Token(Token = "0x40198C2")]
		[FieldOffset(Offset = "0x18")]
		public AdvBustupResManager.<>c__DisplayClass7_0 CS$<>8__locals1;
	}
}
