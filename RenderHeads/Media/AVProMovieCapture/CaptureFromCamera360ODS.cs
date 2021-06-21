using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DAD RID: 3501
	[Token(Token = "0x20008ED")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1489A0", Offset = "0x148AA1")]
	public class CaptureFromCamera360ODS : CaptureBase
	{
		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06005A89 RID: 23177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FD")]
		public CaptureFromCamera360ODS.Settings Setup
		{
			[Token(Token = "0x6004AC2")]
			[Address(RVA = "0x247C820", Offset = "0x247C921", VA = "0x247C820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC3")]
		[Address(RVA = "0x247C830", Offset = "0x247C931", VA = "0x247C830")]
		public CaptureFromCamera360ODS()
		{
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC4")]
		[Address(RVA = "0x247C980", Offset = "0x247CA81", VA = "0x247C980")]
		public void SetCamera(Camera camera)
		{
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC5")]
		[Address(RVA = "0x247C9A0", Offset = "0x247CAA1", VA = "0x247C9A0", Slot = "5")]
		public override void Start()
		{
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x247CAC0", Offset = "0x247CBC1", VA = "0x247CAC0")]
		private Camera CreateEye(Camera camera, string gameObjectName, float yRot, float xOffset, int cameraTargetHeight, int cullingMask, float fov, float aspect, int aalevel)
		{
			return null;
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x247D080", Offset = "0x247D181", VA = "0x247D080", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x247D140", Offset = "0x247D241", VA = "0x247D140")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ABB40", Offset = "0x1ABC41")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC9")]
		[Address(RVA = "0x247D1C0", Offset = "0x247D2C1", VA = "0x247D1C0")]
		private void Capture()
		{
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACA")]
		[Address(RVA = "0x247D3F0", Offset = "0x247D4F1", VA = "0x247D3F0")]
		private void AccumulateMotionBlur()
		{
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x247D4F0", Offset = "0x247D5F1", VA = "0x247D4F0")]
		private void RenderFrame()
		{
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0x247D910", Offset = "0x247DA11", VA = "0x247D910", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x247D960", Offset = "0x247DA61", VA = "0x247D960", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x247E3C0", Offset = "0x247E4C1", VA = "0x247E3C0")]
		private static void DestroyEye(Camera camera)
		{
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x247E4A0", Offset = "0x247E5A1", VA = "0x247E4A0", Slot = "6")]
		public override void OnDestroy()
		{
		}

		// Token: 0x0400B9DF RID: 47583
		[Token(Token = "0x4008AC9")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private CaptureFromCamera360ODS.Settings _settings;

		// Token: 0x0400B9E0 RID: 47584
		[Token(Token = "0x4008ACA")]
		[FieldOffset(Offset = "0x1B8")]
		private int _eyeWidth;

		// Token: 0x0400B9E1 RID: 47585
		[Token(Token = "0x4008ACB")]
		[FieldOffset(Offset = "0x1BC")]
		private int _eyeHeight;

		// Token: 0x0400B9E2 RID: 47586
		[Token(Token = "0x4008ACC")]
		[FieldOffset(Offset = "0x1C0")]
		private Transform _cameraGroup;

		// Token: 0x0400B9E3 RID: 47587
		[Token(Token = "0x4008ACD")]
		[FieldOffset(Offset = "0x1C8")]
		private Camera _leftCameraTop;

		// Token: 0x0400B9E4 RID: 47588
		[Token(Token = "0x4008ACE")]
		[FieldOffset(Offset = "0x1D0")]
		private Camera _leftCameraBot;

		// Token: 0x0400B9E5 RID: 47589
		[Token(Token = "0x4008ACF")]
		[FieldOffset(Offset = "0x1D8")]
		private Camera _rightCameraTop;

		// Token: 0x0400B9E6 RID: 47590
		[Token(Token = "0x4008AD0")]
		[FieldOffset(Offset = "0x1E0")]
		private Camera _rightCameraBot;

		// Token: 0x0400B9E7 RID: 47591
		[Token(Token = "0x4008AD1")]
		[FieldOffset(Offset = "0x1E8")]
		private RenderTexture _final;

		// Token: 0x0400B9E8 RID: 47592
		[Token(Token = "0x4008AD2")]
		[FieldOffset(Offset = "0x1F0")]
		private IntPtr _targetNativePointer;

		// Token: 0x0400B9E9 RID: 47593
		[Token(Token = "0x4008AD3")]
		[FieldOffset(Offset = "0x1F8")]
		private Material _finalMaterial;

		// Token: 0x0400B9EA RID: 47594
		[Token(Token = "0x4008AD4")]
		[FieldOffset(Offset = "0x200")]
		private int _propSliceCenter;

		// Token: 0x02000DAE RID: 3502
		[Token(Token = "0x200142D")]
		[Serializable]
		public class Settings
		{
			// Token: 0x06005A97 RID: 23191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A7E")]
			[Address(RVA = "0x247C920", Offset = "0x247CA21", VA = "0x247C920")]
			public Settings()
			{
			}

			// Token: 0x0400B9EB RID: 47595
			[Token(Token = "0x401BB2D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Camera camera;

			// Token: 0x0400B9EC RID: 47596
			[Token(Token = "0x401BB2E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1990F0", Offset = "0x1991F1")]
			public bool render180Degrees;

			// Token: 0x0400B9ED RID: 47597
			[Token(Token = "0x401BB2F")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[Attribute(Name = "TooltipAttribute", RVA = "0x199140", Offset = "0x199241")]
			public float ipd;

			// Token: 0x0400B9EE RID: 47598
			[Token(Token = "0x401BB30")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Attribute(Name = "TooltipAttribute", RVA = "0x199190", Offset = "0x199291")]
			public int pixelSliceSize;

			// Token: 0x0400B9EF RID: 47599
			[Token(Token = "0x401BB31")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			[Attribute(Name = "RangeAttribute", RVA = "0x1991E0", Offset = "0x1992E1")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1991E0", Offset = "0x1992E1")]
			public int paddingSize;

			// Token: 0x0400B9F0 RID: 47600
			[Token(Token = "0x401BB32")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public CameraClearFlags cameraClearMode;

			// Token: 0x0400B9F1 RID: 47601
			[Token(Token = "0x401BB33")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			public Color cameraClearColor;

			// Token: 0x0400B9F2 RID: 47602
			[Token(Token = "0x401BB34")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			public Behaviour[] cameraImageEffects;
		}

		// Token: 0x02000DAF RID: 3503
		[Token(Token = "0x200142E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1597E0", Offset = "0x1598E1")]
		private sealed class <FinalRenderCapture>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005A98 RID: 23192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A7F")]
			[Address(RVA = "0x247D3C0", Offset = "0x247D4C1", VA = "0x247D3C0")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			// Token: 0x06005A99 RID: 23193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A80")]
			[Address(RVA = "0x247E6D0", Offset = "0x247E7D1", VA = "0x247E6D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005A9A RID: 23194 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
			[Token(Token = "0x6007A81")]
			[Address(RVA = "0x247E6E0", Offset = "0x247E7E1", VA = "0x247E6E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B92 RID: 2962
			// (get) Token: 0x06005A9B RID: 23195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E51")]
			private object Current
			{
				[Token(Token = "0x6007A82")]
				[Address(RVA = "0x247E760", Offset = "0x247E861", VA = "0x247E760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A9C RID: 23196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A83")]
			[Address(RVA = "0x247E770", Offset = "0x247E871", VA = "0x247E770", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x06005A9D RID: 23197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E52")]
			private object Current
			{
				[Token(Token = "0x6007A84")]
				[Address(RVA = "0x247E7D0", Offset = "0x247E8D1", VA = "0x247E7D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B9F3 RID: 47603
			[Token(Token = "0x401BB35")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B9F4 RID: 47604
			[Token(Token = "0x401BB36")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B9F5 RID: 47605
			[Token(Token = "0x401BB37")]
			[FieldOffset(Offset = "0x20")]
			public CaptureFromCamera360ODS <>4__this;
		}
	}
}
