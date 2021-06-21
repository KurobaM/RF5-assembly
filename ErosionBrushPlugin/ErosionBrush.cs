using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E20 RID: 3616
	[Token(Token = "0x2000944")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x149030", Offset = "0x149131")]
	public class ErosionBrush : MonoBehaviour
	{
		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06005E07 RID: 24071 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005E08 RID: 24072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BA")]
		public Terrain terrain
		{
			[Token(Token = "0x6004E1E")]
			[Address(RVA = "0x2C22B10", Offset = "0x2C22C11", VA = "0x2C22B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E1F")]
			[Address(RVA = "0x2C22BC0", Offset = "0x2C22CC1", VA = "0x2C22BC0")]
			set
			{
			}
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E20")]
		[Address(RVA = "0x2C22BD0", Offset = "0x2C22CD1", VA = "0x2C22BD0")]
		public Terrain[] GetTerrains()
		{
			return null;
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E21")]
		[Address(RVA = "0x2C22D10", Offset = "0x2C22E11", VA = "0x2C22D10")]
		public void ApplyNoise(Matrix height, Matrix bedrock, Matrix sediment)
		{
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E22")]
		[Address(RVA = "0x2C22FA0", Offset = "0x2C230A1", VA = "0x2C22FA0")]
		public void ApplyErosion(Matrix height, Matrix bedrock, Matrix sediment)
		{
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x2C234F0", Offset = "0x2C235F1", VA = "0x2C234F0")]
		public void ApplyBrush(Vector3 pos, float radius, bool useFallof = true)
		{
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E24")]
		[Address(RVA = "0x2C24180", Offset = "0x2C24281", VA = "0x2C24180")]
		public void GetHeight(Matrix matrix, Terrain terrain)
		{
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E25")]
		[Address(RVA = "0x2C249C0", Offset = "0x2C24AC1", VA = "0x2C249C0")]
		public void AddHeight(Matrix matrix, Terrain terrain)
		{
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E26")]
		[Address(RVA = "0x2C24C30", Offset = "0x2C24D31", VA = "0x2C24C30")]
		public void AddSplat(Matrix matrix, Terrain terrain, int channel)
		{
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E27")]
		[Address(RVA = "0x2C25370", Offset = "0x2C25471", VA = "0x2C25370")]
		public void TestUndo(Vector3 pos, float radius)
		{
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E28")]
		[Address(RVA = "0x2C26680", Offset = "0x2C26781", VA = "0x2C26680")]
		public void NewUndo()
		{
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E29")]
		[Address(RVA = "0x2C26700", Offset = "0x2C26801", VA = "0x2C26700")]
		public void AddUndo(Vector3 pos, float radius)
		{
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2A")]
		[Address(RVA = "0x2C26970", Offset = "0x2C26A71", VA = "0x2C26970")]
		public void AddGlobalUndo()
		{
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2B")]
		[Address(RVA = "0x2C26E20", Offset = "0x2C26F21", VA = "0x2C26E20")]
		public void PerformUndo()
		{
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x2C27450", Offset = "0x2C27551", VA = "0x2C27450")]
		public ErosionBrush()
		{
		}

		// Token: 0x0400BE1D RID: 48669
		[Token(Token = "0x4008E7E")]
		[FieldOffset(Offset = "0x18")]
		public Terrain[] terrains;

		// Token: 0x0400BE1E RID: 48670
		[Token(Token = "0x4008E7F")]
		[FieldOffset(Offset = "0x20")]
		private Terrain _terrain;

		// Token: 0x0400BE1F RID: 48671
		[Token(Token = "0x4008E80")]
		[FieldOffset(Offset = "0x28")]
		public Preset preset;

		// Token: 0x0400BE20 RID: 48672
		[Token(Token = "0x4008E81")]
		[FieldOffset(Offset = "0x30")]
		public Preset[] presets;

		// Token: 0x0400BE21 RID: 48673
		[Token(Token = "0x4008E82")]
		[FieldOffset(Offset = "0x38")]
		public int guiSelectedPreset;

		// Token: 0x0400BE22 RID: 48674
		[Token(Token = "0x4008E83")]
		[FieldOffset(Offset = "0x3C")]
		public bool paint;

		// Token: 0x0400BE23 RID: 48675
		[Token(Token = "0x4008E84")]
		[FieldOffset(Offset = "0x3D")]
		public bool wasPaint;

		// Token: 0x0400BE24 RID: 48676
		[Token(Token = "0x4008E85")]
		[FieldOffset(Offset = "0x3E")]
		public bool moveDown;

		// Token: 0x0400BE25 RID: 48677
		[Token(Token = "0x4008E86")]
		[FieldOffset(Offset = "0x40")]
		public Transform moveTfm;

		// Token: 0x0400BE26 RID: 48678
		[Token(Token = "0x4008E87")]
		[FieldOffset(Offset = "0x48")]
		public bool gen;

		// Token: 0x0400BE27 RID: 48679
		[Token(Token = "0x4008E88")]
		[FieldOffset(Offset = "0x49")]
		public bool undo;

		// Token: 0x0400BE28 RID: 48680
		[Token(Token = "0x4008E89")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Texture2D guiHydraulicIcon;

		// Token: 0x0400BE29 RID: 48681
		[Token(Token = "0x4008E8A")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Texture2D guiWindIcon;

		// Token: 0x0400BE2A RID: 48682
		[Token(Token = "0x4008E8B")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Texture2D guiPluginIcon;

		// Token: 0x0400BE2B RID: 48683
		[Token(Token = "0x4008E8C")]
		[FieldOffset(Offset = "0x68")]
		public int guiApplyIterations;

		// Token: 0x0400BE2C RID: 48684
		[Token(Token = "0x4008E8D")]
		[FieldOffset(Offset = "0x70")]
		public int[] guiChannels;

		// Token: 0x0400BE2D RID: 48685
		[Token(Token = "0x4008E8E")]
		[FieldOffset(Offset = "0x78")]
		public string[] guiChannelNames;

		// Token: 0x0400BE2E RID: 48686
		[Token(Token = "0x4008E8F")]
		[FieldOffset(Offset = "0x80")]
		public Color guiBrushColor;

		// Token: 0x0400BE2F RID: 48687
		[Token(Token = "0x4008E90")]
		[FieldOffset(Offset = "0x90")]
		public float guiBrushThickness;

		// Token: 0x0400BE30 RID: 48688
		[Token(Token = "0x4008E91")]
		[FieldOffset(Offset = "0x94")]
		public int guiBrushNumCorners;

		// Token: 0x0400BE31 RID: 48689
		[Token(Token = "0x4008E92")]
		[FieldOffset(Offset = "0x98")]
		public bool recordUndo;

		// Token: 0x0400BE32 RID: 48690
		[Token(Token = "0x4008E93")]
		[FieldOffset(Offset = "0x99")]
		public bool unity5positioning;

		// Token: 0x0400BE33 RID: 48691
		[Token(Token = "0x4008E94")]
		[FieldOffset(Offset = "0x9A")]
		public bool focusOnBrush;

		// Token: 0x0400BE34 RID: 48692
		[Token(Token = "0x4008E95")]
		[FieldOffset(Offset = "0x9B")]
		public bool guiShowPreset;

		// Token: 0x0400BE35 RID: 48693
		[Token(Token = "0x4008E96")]
		[FieldOffset(Offset = "0x9C")]
		public bool guiShowBrush;

		// Token: 0x0400BE36 RID: 48694
		[Token(Token = "0x4008E97")]
		[FieldOffset(Offset = "0x9D")]
		public bool guiShowErosion;

		// Token: 0x0400BE37 RID: 48695
		[Token(Token = "0x4008E98")]
		[FieldOffset(Offset = "0x9E")]
		public bool guiShowNoise;

		// Token: 0x0400BE38 RID: 48696
		[Token(Token = "0x4008E99")]
		[FieldOffset(Offset = "0x9F")]
		public bool guiShowTextures;

		// Token: 0x0400BE39 RID: 48697
		[Token(Token = "0x4008E9A")]
		[FieldOffset(Offset = "0xA0")]
		public bool guiShowGlobal;

		// Token: 0x0400BE3A RID: 48698
		[Token(Token = "0x4008E9B")]
		[FieldOffset(Offset = "0xA1")]
		public bool guiShowSettings;

		// Token: 0x0400BE3B RID: 48699
		[Token(Token = "0x4008E9C")]
		[FieldOffset(Offset = "0xA2")]
		public bool guiShowAbout;

		// Token: 0x0400BE3C RID: 48700
		[Token(Token = "0x4008E9D")]
		[FieldOffset(Offset = "0xA4")]
		public int guiMaxBrushSize;

		// Token: 0x0400BE3D RID: 48701
		[Token(Token = "0x4008E9E")]
		[FieldOffset(Offset = "0xA8")]
		public bool guiSelectPresetsUsingNumkeys;

		// Token: 0x0400BE3E RID: 48702
		[Token(Token = "0x4008E9F")]
		[FieldOffset(Offset = "0xA9")]
		public bool guiControlUsed;

		// Token: 0x0400BE3F RID: 48703
		[Token(Token = "0x4008EA0")]
		[FieldOffset(Offset = "0xAC")]
		public int applyCount;

		// Token: 0x0400BE40 RID: 48704
		[Token(Token = "0x4008EA1")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public Stack<ErosionBrush.TerrainUndoStep[]> undoSteps;

		// Token: 0x0400BE41 RID: 48705
		[Token(Token = "0x4008EA2")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public Stack<ErosionBrush.TerrainUndoStep[]> redoSteps;

		// Token: 0x0400BE42 RID: 48706
		[Token(Token = "0x4008EA3")]
		[FieldOffset(Offset = "0xC0")]
		public int currentUndoState;

		// Token: 0x0400BE43 RID: 48707
		[Token(Token = "0x4008EA4")]
		[FieldOffset(Offset = "0xC4")]
		public int referenceUndoState;

		// Token: 0x0400BE44 RID: 48708
		[Token(Token = "0x4008EA5")]
		[FieldOffset(Offset = "0xC8")]
		public List<List<ErosionBrush.UndoStep>> undoList;

		// Token: 0x0400BE45 RID: 48709
		[Token(Token = "0x4008EA6")]
		[FieldOffset(Offset = "0xD0")]
		public bool allowUndo;

		// Token: 0x02000E21 RID: 3617
		[Token(Token = "0x2001449")]
		public class TerrainUndoStep
		{
			// Token: 0x06005E16 RID: 24086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA0")]
			[Address(RVA = "0x2C25580", Offset = "0x2C25681", VA = "0x2C25580")]
			public void Add(Vector3 pos, float radius)
			{
			}

			// Token: 0x06005E17 RID: 24087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA1")]
			[Address(RVA = "0x2C26420", Offset = "0x2C26521", VA = "0x2C26420")]
			public void Perform()
			{
			}

			// Token: 0x06005E18 RID: 24088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA2")]
			[Address(RVA = "0x2C27070", Offset = "0x2C27171", VA = "0x2C27070")]
			public void GetCurrentState(ErosionBrush.TerrainUndoStep reference)
			{
			}

			// Token: 0x06005E19 RID: 24089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA3")]
			[Address(RVA = "0x2C25570", Offset = "0x2C25671", VA = "0x2C25570")]
			public TerrainUndoStep()
			{
			}

			// Token: 0x0400BE46 RID: 48710
			[Token(Token = "0x401BBB6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int cellSize;

			// Token: 0x0400BE47 RID: 48711
			[Token(Token = "0x401BBB7")]
			[FieldOffset(Offset = "0x10")]
			public Terrain terrain;

			// Token: 0x0400BE48 RID: 48712
			[Token(Token = "0x401BBB8")]
			[FieldOffset(Offset = "0x18")]
			private Matrix2<float[,]> heights;

			// Token: 0x0400BE49 RID: 48713
			[Token(Token = "0x401BBB9")]
			[FieldOffset(Offset = "0x20")]
			private Matrix2<float[,,]> splats;
		}

		// Token: 0x02000E22 RID: 3618
		[Token(Token = "0x200144A")]
		public struct UndoStep
		{
			// Token: 0x06005E1B RID: 24091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA5")]
			[Address(RVA = "0x37D780", Offset = "0x37D881", VA = "0x37D780")]
			public UndoStep(float[,] heights, float[,,] splats, int heightsOffsetX, int heightsOffsetZ, int splatsOffsetX, int splatsOffsetZ)
			{
			}

			// Token: 0x06005E1C RID: 24092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA6")]
			[Address(RVA = "0x37D790", Offset = "0x37D891", VA = "0x37D790")]
			public void Perform(TerrainData data)
			{
			}

			// Token: 0x0400BE4A RID: 48714
			[Token(Token = "0x401BBBA")]
			[FieldOffset(Offset = "0x0")]
			private float[,] heights;

			// Token: 0x0400BE4B RID: 48715
			[Token(Token = "0x401BBBB")]
			[FieldOffset(Offset = "0x8")]
			private int heightsOffsetX;

			// Token: 0x0400BE4C RID: 48716
			[Token(Token = "0x401BBBC")]
			[FieldOffset(Offset = "0xC")]
			private int heightsOffsetZ;

			// Token: 0x0400BE4D RID: 48717
			[Token(Token = "0x401BBBD")]
			[FieldOffset(Offset = "0x10")]
			private float[,,] splats;

			// Token: 0x0400BE4E RID: 48718
			[Token(Token = "0x401BBBE")]
			[FieldOffset(Offset = "0x18")]
			private int splatsOffsetX;

			// Token: 0x0400BE4F RID: 48719
			[Token(Token = "0x401BBBF")]
			[FieldOffset(Offset = "0x1C")]
			private int splatsOffsetZ;
		}
	}
}
