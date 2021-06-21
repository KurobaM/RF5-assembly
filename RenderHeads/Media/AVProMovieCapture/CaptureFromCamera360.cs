using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DAA RID: 3498
	[Token(Token = "0x20008EC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148960", Offset = "0x148A61")]
	public class CaptureFromCamera360 : CaptureBase
	{
		// Token: 0x06005A74 RID: 23156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x247A270", Offset = "0x247A371", VA = "0x247A270")]
		public CaptureFromCamera360()
		{
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x0001DB98 File Offset: 0x0001BD98
		[Token(Token = "0x6004AB4")]
		[Address(RVA = "0x247A300", Offset = "0x247A401", VA = "0x247A300")]
		private CaptureFromCamera360.CubemapRenderMethod GetCubemapRenderingMethod()
		{
			return CaptureFromCamera360.CubemapRenderMethod.Manual;
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB5")]
		[Address(RVA = "0x247A340", Offset = "0x247A441", VA = "0x247A340")]
		public void SetCamera(Camera camera)
		{
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB6")]
		[Address(RVA = "0x247A350", Offset = "0x247A451", VA = "0x247A350", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x247A410", Offset = "0x247A511", VA = "0x247A410")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ABAD0", Offset = "0x1ABBD1")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x247A490", Offset = "0x247A591", VA = "0x247A490")]
		private void Capture()
		{
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB9")]
		[Address(RVA = "0x247AC40", Offset = "0x247AD41", VA = "0x247AC40")]
		private static void ClearCubemap(RenderTexture texture, Color color)
		{
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABA")]
		[Address(RVA = "0x247AE20", Offset = "0x247AF21", VA = "0x247AE20")]
		private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft)
		{
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABB")]
		[Address(RVA = "0x247A870", Offset = "0x247A971", VA = "0x247A870")]
		private void UpdateTexture()
		{
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABC")]
		[Address(RVA = "0x247AF90", Offset = "0x247B091", VA = "0x247AF90")]
		private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget)
		{
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABD")]
		[Address(RVA = "0x247A780", Offset = "0x247A881", VA = "0x247A780")]
		private void AccumulateMotionBlur()
		{
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		[Token(Token = "0x6004ABE")]
		[Address(RVA = "0x247B760", Offset = "0x247B861", VA = "0x247B760", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		// Token: 0x06005A80 RID: 23168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABF")]
		[Address(RVA = "0x247C300", Offset = "0x247C401", VA = "0x247C300", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC0")]
		[Address(RVA = "0x247C350", Offset = "0x247C451", VA = "0x247C350", Slot = "5")]
		public override void Start()
		{
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC1")]
		[Address(RVA = "0x247C520", Offset = "0x247C621", VA = "0x247C520", Slot = "6")]
		public override void OnDestroy()
		{
		}

		// Token: 0x0400B9C9 RID: 47561
		[Token(Token = "0x4008ABA")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		public int _cubemapResolution;

		// Token: 0x0400B9CA RID: 47562
		[Token(Token = "0x4008ABB")]
		[FieldOffset(Offset = "0x1B4")]
		[SerializeField]
		public int _cubemapDepth;

		// Token: 0x0400B9CB RID: 47563
		[Token(Token = "0x4008ABC")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		public bool _supportGUI;

		// Token: 0x0400B9CC RID: 47564
		[Token(Token = "0x4008ABD")]
		[FieldOffset(Offset = "0x1B9")]
		[SerializeField]
		public bool _supportCameraRotation;

		// Token: 0x0400B9CD RID: 47565
		[Token(Token = "0x4008ABE")]
		[FieldOffset(Offset = "0x1BA")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CB10", Offset = "0x17CC11")]
		public bool _render180Degrees;

		// Token: 0x0400B9CE RID: 47566
		[Token(Token = "0x4008ABF")]
		[FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		public StereoPacking _stereoRendering;

		// Token: 0x0400B9CF RID: 47567
		[Token(Token = "0x4008AC0")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CB70", Offset = "0x17CC71")]
		public float _ipd;

		// Token: 0x0400B9D0 RID: 47568
		[Token(Token = "0x4008AC1")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400B9D1 RID: 47569
		[Token(Token = "0x4008AC2")]
		[FieldOffset(Offset = "0x1D0")]
		private RenderTexture _faceTarget;

		// Token: 0x0400B9D2 RID: 47570
		[Token(Token = "0x4008AC3")]
		[FieldOffset(Offset = "0x1D8")]
		private Material _blitMaterial;

		// Token: 0x0400B9D3 RID: 47571
		[Token(Token = "0x4008AC4")]
		[FieldOffset(Offset = "0x1E0")]
		private Material _cubemapToEquirectangularMaterial;

		// Token: 0x0400B9D4 RID: 47572
		[Token(Token = "0x4008AC5")]
		[FieldOffset(Offset = "0x1E8")]
		private RenderTexture _cubeTarget;

		// Token: 0x0400B9D5 RID: 47573
		[Token(Token = "0x4008AC6")]
		[FieldOffset(Offset = "0x1F0")]
		private RenderTexture _finalTarget;

		// Token: 0x0400B9D6 RID: 47574
		[Token(Token = "0x4008AC7")]
		[FieldOffset(Offset = "0x1F8")]
		private IntPtr _targetNativePointer;

		// Token: 0x0400B9D7 RID: 47575
		[Token(Token = "0x4008AC8")]
		[FieldOffset(Offset = "0x200")]
		private int _propFlipX;

		// Token: 0x02000DAB RID: 3499
		[Token(Token = "0x200142B")]
		private enum CubemapRenderMethod
		{
			// Token: 0x0400B9D9 RID: 47577
			[Token(Token = "0x401BB27")]
			Manual,
			// Token: 0x0400B9DA RID: 47578
			[Token(Token = "0x401BB28")]
			Unity,
			// Token: 0x0400B9DB RID: 47579
			[Token(Token = "0x401BB29")]
			Unity2018
		}

		// Token: 0x02000DAC RID: 3500
		[Token(Token = "0x200142C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1597D0", Offset = "0x1598D1")]
		private sealed class <FinalRenderCapture>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005A83 RID: 23171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A78")]
			[Address(RVA = "0x247A750", Offset = "0x247A851", VA = "0x247A750")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			// Token: 0x06005A84 RID: 23172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A79")]
			[Address(RVA = "0x247C710", Offset = "0x247C811", VA = "0x247C710", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005A85 RID: 23173 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
			[Token(Token = "0x6007A7A")]
			[Address(RVA = "0x247C720", Offset = "0x247C821", VA = "0x247C720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B8F RID: 2959
			// (get) Token: 0x06005A86 RID: 23174 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E4F")]
			private object Current
			{
				[Token(Token = "0x6007A7B")]
				[Address(RVA = "0x247C7A0", Offset = "0x247C8A1", VA = "0x247C7A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A87 RID: 23175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A7C")]
			[Address(RVA = "0x247C7B0", Offset = "0x247C8B1", VA = "0x247C7B0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B90 RID: 2960
			// (get) Token: 0x06005A88 RID: 23176 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E50")]
			private object Current
			{
				[Token(Token = "0x6007A7D")]
				[Address(RVA = "0x247C810", Offset = "0x247C911", VA = "0x247C810", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B9DC RID: 47580
			[Token(Token = "0x401BB2A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B9DD RID: 47581
			[Token(Token = "0x401BB2B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B9DE RID: 47582
			[Token(Token = "0x401BB2C")]
			[FieldOffset(Offset = "0x20")]
			public CaptureFromCamera360 <>4__this;
		}
	}
}
