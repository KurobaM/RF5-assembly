using System;
using Il2CppDummyDll;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E1E RID: 3614
	[Token(Token = "0x2000943")]
	[Serializable]
	public class Preset
	{
		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06005E04 RID: 24068 RVA: 0x0001F260 File Offset: 0x0001D460
		[Token(Token = "0x170009B9")]
		public bool paintSplat
		{
			[Token(Token = "0x6004E1B")]
			[Address(RVA = "0x1DAC540", Offset = "0x1DAC641", VA = "0x1DAC540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x1DAC590", Offset = "0x1DAC691", VA = "0x1DAC590")]
		public Preset Copy()
		{
			return null;
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x1DAC620", Offset = "0x1DAC721", VA = "0x1DAC620")]
		public Preset()
		{
		}

		// Token: 0x0400BDFD RID: 48637
		[Token(Token = "0x4008E61")]
		[FieldOffset(Offset = "0x10")]
		public float brushSize;

		// Token: 0x0400BDFE RID: 48638
		[Token(Token = "0x4008E62")]
		[FieldOffset(Offset = "0x14")]
		public float brushFallof;

		// Token: 0x0400BDFF RID: 48639
		[Token(Token = "0x4008E63")]
		[FieldOffset(Offset = "0x18")]
		public float brushSpacing;

		// Token: 0x0400BE00 RID: 48640
		[Token(Token = "0x4008E64")]
		[FieldOffset(Offset = "0x1C")]
		public int downscale;

		// Token: 0x0400BE01 RID: 48641
		[Token(Token = "0x4008E65")]
		[FieldOffset(Offset = "0x20")]
		public float blur;

		// Token: 0x0400BE02 RID: 48642
		[Token(Token = "0x4008E66")]
		[FieldOffset(Offset = "0x24")]
		public bool preserveDetail;

		// Token: 0x0400BE03 RID: 48643
		[Token(Token = "0x4008E67")]
		[FieldOffset(Offset = "0x25")]
		public bool isErosion;

		// Token: 0x0400BE04 RID: 48644
		[Token(Token = "0x4008E68")]
		[FieldOffset(Offset = "0x26")]
		public bool isNoise;

		// Token: 0x0400BE05 RID: 48645
		[Token(Token = "0x4008E69")]
		[FieldOffset(Offset = "0x28")]
		public int noise_seed;

		// Token: 0x0400BE06 RID: 48646
		[Token(Token = "0x4008E6A")]
		[FieldOffset(Offset = "0x2C")]
		public float noise_amount;

		// Token: 0x0400BE07 RID: 48647
		[Token(Token = "0x4008E6B")]
		[FieldOffset(Offset = "0x30")]
		public float noise_size;

		// Token: 0x0400BE08 RID: 48648
		[Token(Token = "0x4008E6C")]
		[FieldOffset(Offset = "0x34")]
		public float noise_detail;

		// Token: 0x0400BE09 RID: 48649
		[Token(Token = "0x4008E6D")]
		[FieldOffset(Offset = "0x38")]
		public float noise_uplift;

		// Token: 0x0400BE0A RID: 48650
		[Token(Token = "0x4008E6E")]
		[FieldOffset(Offset = "0x3C")]
		public float noise_ruffle;

		// Token: 0x0400BE0B RID: 48651
		[Token(Token = "0x4008E6F")]
		[FieldOffset(Offset = "0x40")]
		public int erosion_iterations;

		// Token: 0x0400BE0C RID: 48652
		[Token(Token = "0x4008E70")]
		[FieldOffset(Offset = "0x44")]
		public float erosion_durability;

		// Token: 0x0400BE0D RID: 48653
		[Token(Token = "0x4008E71")]
		[FieldOffset(Offset = "0x48")]
		public int erosion_fluidityIterations;

		// Token: 0x0400BE0E RID: 48654
		[Token(Token = "0x4008E72")]
		[FieldOffset(Offset = "0x4C")]
		public float erosion_amount;

		// Token: 0x0400BE0F RID: 48655
		[Token(Token = "0x4008E73")]
		[FieldOffset(Offset = "0x50")]
		public float sediment_amount;

		// Token: 0x0400BE10 RID: 48656
		[Token(Token = "0x4008E74")]
		[FieldOffset(Offset = "0x54")]
		public float wind_amount;

		// Token: 0x0400BE11 RID: 48657
		[Token(Token = "0x4008E75")]
		[FieldOffset(Offset = "0x58")]
		public float erosion_smooth;

		// Token: 0x0400BE12 RID: 48658
		[Token(Token = "0x4008E76")]
		[FieldOffset(Offset = "0x5C")]
		public float ruffle;

		// Token: 0x0400BE13 RID: 48659
		[Token(Token = "0x4008E77")]
		[FieldOffset(Offset = "0x60")]
		public Preset.SplatPreset foreground;

		// Token: 0x0400BE14 RID: 48660
		[Token(Token = "0x4008E78")]
		[FieldOffset(Offset = "0x6C")]
		public Preset.SplatPreset background;

		// Token: 0x0400BE15 RID: 48661
		[Token(Token = "0x4008E79")]
		[FieldOffset(Offset = "0x78")]
		public string name;

		// Token: 0x0400BE16 RID: 48662
		[Token(Token = "0x4008E7A")]
		[FieldOffset(Offset = "0x80")]
		public bool saveBrushSize;

		// Token: 0x0400BE17 RID: 48663
		[Token(Token = "0x4008E7B")]
		[FieldOffset(Offset = "0x81")]
		public bool saveBrushParams;

		// Token: 0x0400BE18 RID: 48664
		[Token(Token = "0x4008E7C")]
		[FieldOffset(Offset = "0x82")]
		public bool saveErosionNoiseParams;

		// Token: 0x0400BE19 RID: 48665
		[Token(Token = "0x4008E7D")]
		[FieldOffset(Offset = "0x83")]
		public bool saveSplatParams;

		// Token: 0x02000E1F RID: 3615
		[Token(Token = "0x2001448")]
		[Serializable]
		public struct SplatPreset
		{
			// Token: 0x0400BE1A RID: 48666
			[Token(Token = "0x401BBB3")]
			[FieldOffset(Offset = "0x0")]
			public bool apply;

			// Token: 0x0400BE1B RID: 48667
			[Token(Token = "0x401BBB4")]
			[FieldOffset(Offset = "0x4")]
			public float opacity;

			// Token: 0x0400BE1C RID: 48668
			[Token(Token = "0x401BBB5")]
			[FieldOffset(Offset = "0x8")]
			public int num;
		}
	}
}
