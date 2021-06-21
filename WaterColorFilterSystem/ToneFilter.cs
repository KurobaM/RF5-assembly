using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WaterColorFilterSystem
{
	// Token: 0x020011D1 RID: 4561
	[Token(Token = "0x2000BA6")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x14A290", Offset = "0x14A391")]
	[Attribute(Name = "RequireComponent", RVA = "0x14A290", Offset = "0x14A391")]
	public class ToneFilter : MonoBehaviour
	{
		// Token: 0x06007164 RID: 29028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E20")]
		[Address(RVA = "0x1E4FF80", Offset = "0x1E50081", VA = "0x1E4FF80")]
		private void OnEnable()
		{
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E21")]
		[Address(RVA = "0x1E50040", Offset = "0x1E50141", VA = "0x1E50040")]
		private void OnDisable()
		{
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E22")]
		[Address(RVA = "0x1E500B0", Offset = "0x1E501B1", VA = "0x1E500B0")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E23")]
		[Address(RVA = "0x1E502C0", Offset = "0x1E503C1", VA = "0x1E502C0")]
		public ToneFilter()
		{
		}

		// Token: 0x0401830C RID: 99084
		[Token(Token = "0x4014D78")]
		public const string PROP_COLOR_WARM = "_ColorWarm";

		// Token: 0x0401830D RID: 99085
		[Token(Token = "0x4014D79")]
		public const string PROP_COLOR_COOL = "_ColorCool";

		// Token: 0x0401830E RID: 99086
		[Token(Token = "0x4014D7A")]
		public const string PROP_TONE_POWER = "_TonePower";

		// Token: 0x0401830F RID: 99087
		[Token(Token = "0x4014D7B")]
		public const string PROP_LIGHT_DIR = "_LightDir";

		// Token: 0x04018310 RID: 99088
		[Token(Token = "0x4014D7C")]
		[FieldOffset(Offset = "0x18")]
		public Shader filter;

		// Token: 0x04018311 RID: 99089
		[Token(Token = "0x4014D7D")]
		[FieldOffset(Offset = "0x20")]
		public Color warm;

		// Token: 0x04018312 RID: 99090
		[Token(Token = "0x4014D7E")]
		[FieldOffset(Offset = "0x30")]
		public Color cool;

		// Token: 0x04018313 RID: 99091
		[Token(Token = "0x4014D7F")]
		[FieldOffset(Offset = "0x40")]
		public float tonePower;

		// Token: 0x04018314 RID: 99092
		[Token(Token = "0x4014D80")]
		[FieldOffset(Offset = "0x48")]
		public Transform dirLight;

		// Token: 0x04018315 RID: 99093
		[Token(Token = "0x4014D81")]
		[FieldOffset(Offset = "0x50")]
		private Material _filterMat;

		// Token: 0x04018316 RID: 99094
		[Token(Token = "0x4014D82")]
		[FieldOffset(Offset = "0x58")]
		private Camera _cam;
	}
}
