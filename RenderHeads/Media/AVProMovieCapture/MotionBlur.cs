using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DB5 RID: 3509
	[Token(Token = "0x20008F1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148AA0", Offset = "0x148BA1")]
	public class MotionBlur : MonoBehaviour
	{
		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06005AC7 RID: 23239 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		// (set) Token: 0x06005AC8 RID: 23240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008FE")]
		public bool IsFrameAccumulated
		{
			[Token(Token = "0x6004AED")]
			[Address(RVA = "0x24881A0", Offset = "0x24882A1", VA = "0x24881A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABC90", Offset = "0x1ABD91")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AEE")]
			[Address(RVA = "0x24881B0", Offset = "0x24882B1", VA = "0x24881B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABCA0", Offset = "0x1ABDA1")]
			private set
			{
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06005AC9 RID: 23241 RVA: 0x0001DCB8 File Offset: 0x0001BEB8
		// (set) Token: 0x06005ACA RID: 23242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008FF")]
		public int NumSamples
		{
			[Token(Token = "0x6004AEF")]
			[Address(RVA = "0x24881C0", Offset = "0x24882C1", VA = "0x24881C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004AF0")]
			[Address(RVA = "0x24881D0", Offset = "0x24882D1", VA = "0x24881D0")]
			set
			{
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06005ACB RID: 23243 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		[Token(Token = "0x17000900")]
		public int FrameCount
		{
			[Token(Token = "0x6004AF1")]
			[Address(RVA = "0x24882B0", Offset = "0x24883B1", VA = "0x24882B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06005ACC RID: 23244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000901")]
		public RenderTexture FinalTexture
		{
			[Token(Token = "0x6004AF2")]
			[Address(RVA = "0x24882C0", Offset = "0x24883C1", VA = "0x24882C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x24882D0", Offset = "0x24883D1", VA = "0x24882D0")]
		private void Awake()
		{
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x2488370", Offset = "0x2488471", VA = "0x2488370")]
		public void SetTargetSize(int width, int height)
		{
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x24883A0", Offset = "0x24884A1", VA = "0x24883A0")]
		private void Start()
		{
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x24886D0", Offset = "0x24887D1", VA = "0x24886D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x24883B0", Offset = "0x24884B1", VA = "0x24883B0")]
		private void Setup()
		{
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x2488730", Offset = "0x2488831", VA = "0x2488730")]
		private void ClearAccumulation()
		{
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x2488790", Offset = "0x2488891", VA = "0x2488790")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x24881E0", Offset = "0x24882E1", VA = "0x24881E0")]
		public void OnNumSamplesChanged()
		{
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x24889C0", Offset = "0x2488AC1", VA = "0x24889C0")]
		private static float LerpUnclamped(float a, float b, float t)
		{
			return 0f;
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x24889D0", Offset = "0x2488AD1", VA = "0x24889D0")]
		private void ApplyWeighting()
		{
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFD")]
		[Address(RVA = "0x247B620", Offset = "0x247B721", VA = "0x247B620")]
		public void Accumulate(Texture src)
		{
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFE")]
		[Address(RVA = "0x2488AD0", Offset = "0x2488BD1", VA = "0x2488AD0")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFF")]
		[Address(RVA = "0x2488B60", Offset = "0x2488C61", VA = "0x2488B60")]
		public MotionBlur()
		{
		}

		// Token: 0x0400BA17 RID: 47639
		[Token(Token = "0x4008AF0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public RenderTextureFormat _format;

		// Token: 0x0400BA18 RID: 47640
		[Token(Token = "0x4008AF1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _numSamples;

		// Token: 0x0400BA19 RID: 47641
		[Token(Token = "0x4008AF2")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture _accum;

		// Token: 0x0400BA1A RID: 47642
		[Token(Token = "0x4008AF3")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture _lastComp;

		// Token: 0x0400BA1B RID: 47643
		[Token(Token = "0x4008AF4")]
		[FieldOffset(Offset = "0x30")]
		private Material _addMaterial;

		// Token: 0x0400BA1C RID: 47644
		[Token(Token = "0x4008AF5")]
		[FieldOffset(Offset = "0x38")]
		private Material _divMaterial;

		// Token: 0x0400BA1D RID: 47645
		[Token(Token = "0x4008AF6")]
		[FieldOffset(Offset = "0x40")]
		private int _frameCount;

		// Token: 0x0400BA1E RID: 47646
		[Token(Token = "0x4008AF7")]
		[FieldOffset(Offset = "0x44")]
		private int _targetWidth;

		// Token: 0x0400BA1F RID: 47647
		[Token(Token = "0x4008AF8")]
		[FieldOffset(Offset = "0x48")]
		private int _targetHeight;

		// Token: 0x0400BA20 RID: 47648
		[Token(Token = "0x4008AF9")]
		[FieldOffset(Offset = "0x4C")]
		private bool _isDirty;

		// Token: 0x0400BA21 RID: 47649
		[Token(Token = "0x4008AFA")]
		[FieldOffset(Offset = "0x0")]
		private static int _propNumSamples;

		// Token: 0x0400BA22 RID: 47650
		[Token(Token = "0x4008AFB")]
		[FieldOffset(Offset = "0x4")]
		private static int _propWeight;

		// Token: 0x0400BA23 RID: 47651
		[Token(Token = "0x4008AFC")]
		[FieldOffset(Offset = "0x4D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17CC50", Offset = "0x17CD51")]
		private bool <IsFrameAccumulated>k__BackingField;

		// Token: 0x0400BA24 RID: 47652
		[Token(Token = "0x4008AFD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public float _bias;

		// Token: 0x0400BA25 RID: 47653
		[Token(Token = "0x4008AFE")]
		[FieldOffset(Offset = "0x54")]
		private float _total;
	}
}
