using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WaterColorFilterSystem
{
	// Token: 0x020011D2 RID: 4562
	[Token(Token = "0x2000BA7")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x14A310", Offset = "0x14A411")]
	public class WaterColorFilter : MonoBehaviour
	{
		// Token: 0x06007168 RID: 29032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E24")]
		[Address(RVA = "0x1E502D0", Offset = "0x1E503D1", VA = "0x1E502D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E25")]
		[Address(RVA = "0x1E50350", Offset = "0x1E50451", VA = "0x1E50350")]
		private void OnDisable()
		{
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E26")]
		[Address(RVA = "0x1E503C0", Offset = "0x1E504C1", VA = "0x1E503C0")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E27")]
		[Address(RVA = "0x1E507C0", Offset = "0x1E508C1", VA = "0x1E507C0")]
		private void Swap(ref RenderTexture src, ref RenderTexture dst)
		{
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E28")]
		[Address(RVA = "0x1E508B0", Offset = "0x1E509B1", VA = "0x1E508B0")]
		public WaterColorFilter()
		{
		}

		// Token: 0x04018317 RID: 99095
		[Token(Token = "0x4014D83")]
		public const int PASS_WOBB = 0;

		// Token: 0x04018318 RID: 99096
		[Token(Token = "0x4014D84")]
		public const int PASS_EDGE = 1;

		// Token: 0x04018319 RID: 99097
		[Token(Token = "0x4014D85")]
		public const int PASS_PAPER = 2;

		// Token: 0x0401831A RID: 99098
		[Token(Token = "0x4014D86")]
		public const string PROP_WOBB_TEX = "_WobbTex";

		// Token: 0x0401831B RID: 99099
		[Token(Token = "0x4014D87")]
		public const string PROP_WOBB_TEX_SCALE = "_WobbScale";

		// Token: 0x0401831C RID: 99100
		[Token(Token = "0x4014D88")]
		public const string PROP_WOBB_POWER = "_WobbPower";

		// Token: 0x0401831D RID: 99101
		[Token(Token = "0x4014D89")]
		public const string PROP_EDGE_SIZE = "_EdgeSize";

		// Token: 0x0401831E RID: 99102
		[Token(Token = "0x4014D8A")]
		public const string PROP_EDGE_POWER = "_EdgePower";

		// Token: 0x0401831F RID: 99103
		[Token(Token = "0x4014D8B")]
		public const string PROP_PAPER_TEX = "_PaperTex";

		// Token: 0x04018320 RID: 99104
		[Token(Token = "0x4014D8C")]
		public const string PROP_PAPER_SCALE = "_PaperScale";

		// Token: 0x04018321 RID: 99105
		[Token(Token = "0x4014D8D")]
		public const string PROP_PAPER_POWER = "_PaperPower";

		// Token: 0x04018322 RID: 99106
		[Token(Token = "0x4014D8E")]
		[FieldOffset(Offset = "0x18")]
		public Shader filter;

		// Token: 0x04018323 RID: 99107
		[Token(Token = "0x4014D8F")]
		[FieldOffset(Offset = "0x20")]
		public Texture wobbTex;

		// Token: 0x04018324 RID: 99108
		[Token(Token = "0x4014D90")]
		[FieldOffset(Offset = "0x28")]
		public float wobbScale;

		// Token: 0x04018325 RID: 99109
		[Token(Token = "0x4014D91")]
		[FieldOffset(Offset = "0x2C")]
		public float wobbPower;

		// Token: 0x04018326 RID: 99110
		[Token(Token = "0x4014D92")]
		[FieldOffset(Offset = "0x30")]
		public float edgeSize;

		// Token: 0x04018327 RID: 99111
		[Token(Token = "0x4014D93")]
		[FieldOffset(Offset = "0x34")]
		public float edgePower;

		// Token: 0x04018328 RID: 99112
		[Token(Token = "0x4014D94")]
		[FieldOffset(Offset = "0x38")]
		public WaterColorFilter.PaperData[] paperDataset;

		// Token: 0x04018329 RID: 99113
		[Token(Token = "0x4014D95")]
		[FieldOffset(Offset = "0x40")]
		private Material _filterMat;

		// Token: 0x020011D3 RID: 4563
		[Token(Token = "0x2001597")]
		[Serializable]
		public class PaperData
		{
			// Token: 0x0600716D RID: 29037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF3")]
			[Address(RVA = "0x1E50800", Offset = "0x1E50901", VA = "0x1E50800")]
			public void SetProps(Material mat)
			{
			}

			// Token: 0x0600716E RID: 29038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF4")]
			[Address(RVA = "0x1E508D0", Offset = "0x1E509D1", VA = "0x1E508D0")]
			public PaperData()
			{
			}

			// Token: 0x0401832A RID: 99114
			[Token(Token = "0x401C1A0")]
			[FieldOffset(Offset = "0x10")]
			public Texture paperTex;

			// Token: 0x0401832B RID: 99115
			[Token(Token = "0x401C1A1")]
			[FieldOffset(Offset = "0x18")]
			public float paperScale;

			// Token: 0x0401832C RID: 99116
			[Token(Token = "0x401C1A2")]
			[FieldOffset(Offset = "0x1C")]
			public float paperPower;
		}
	}
}
