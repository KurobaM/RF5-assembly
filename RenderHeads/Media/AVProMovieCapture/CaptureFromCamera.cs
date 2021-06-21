using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DA8 RID: 3496
	[Token(Token = "0x20008EB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148920", Offset = "0x148A21")]
	public class CaptureFromCamera : CaptureBase
	{
		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06005A5F RID: 23135 RVA: 0x0001DB20 File Offset: 0x0001BD20
		// (set) Token: 0x06005A60 RID: 23136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008FC")]
		public bool UseContributingCameras
		{
			[Token(Token = "0x6004AA4")]
			[Address(RVA = "0x2478680", Offset = "0x2478781", VA = "0x2478680")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AA5")]
			[Address(RVA = "0x2478690", Offset = "0x2478791", VA = "0x2478690")]
			set
			{
			}
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA6")]
		[Address(RVA = "0x24786A0", Offset = "0x24787A1", VA = "0x24786A0")]
		public void SetCamera(Camera mainCamera, bool useContributingCameras = true)
		{
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA7")]
		[Address(RVA = "0x2478D30", Offset = "0x2478E31", VA = "0x2478D30")]
		public void SetCamera(Camera mainCamera, Camera[] contributingCameras)
		{
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x0001DB38 File Offset: 0x0001BD38
		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0x2478D70", Offset = "0x2478E71", VA = "0x2478D70")]
		private bool HasCamera()
		{
			return default(bool);
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x0001DB50 File Offset: 0x0001BD50
		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x2478DE0", Offset = "0x2478EE1", VA = "0x2478DE0")]
		private bool HasContributingCameras()
		{
			return default(bool);
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x2478E10", Offset = "0x2478F11", VA = "0x2478E10", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x2478F30", Offset = "0x2479031", VA = "0x2478F30")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ABA60", Offset = "0x1ABB61")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x2478FB0", Offset = "0x24790B1", VA = "0x2478FB0")]
		private void Capture()
		{
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAD")]
		[Address(RVA = "0x24792D0", Offset = "0x24793D1", VA = "0x24792D0")]
		private void UpdateTexture()
		{
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x24798B0", Offset = "0x24799B1", VA = "0x24798B0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AAF")]
		[Address(RVA = "0x24799C0", Offset = "0x2479AC1", VA = "0x24799C0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x0001DB68 File Offset: 0x0001BD68
		[Token(Token = "0x6004AB0")]
		[Address(RVA = "0x24799D0", Offset = "0x2479AD1", VA = "0x24799D0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB1")]
		[Address(RVA = "0x247A030", Offset = "0x247A131", VA = "0x247A030", Slot = "6")]
		public override void OnDestroy()
		{
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x247A0E0", Offset = "0x247A1E1", VA = "0x247A0E0")]
		public CaptureFromCamera()
		{
		}

		// Token: 0x0400B9C1 RID: 47553
		[Token(Token = "0x4008AB5")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Camera _lastCamera;

		// Token: 0x0400B9C2 RID: 47554
		[Token(Token = "0x4008AB6")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private Camera[] _contribCameras;

		// Token: 0x0400B9C3 RID: 47555
		[Token(Token = "0x4008AB7")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private bool _useContributingCameras;

		// Token: 0x0400B9C4 RID: 47556
		[Token(Token = "0x4008AB8")]
		[FieldOffset(Offset = "0x1C8")]
		private RenderTexture _target;

		// Token: 0x0400B9C5 RID: 47557
		[Token(Token = "0x4008AB9")]
		[FieldOffset(Offset = "0x1D0")]
		private IntPtr _targetNativePointer;

		// Token: 0x02000DA9 RID: 3497
		[Token(Token = "0x200142A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1597C0", Offset = "0x1598C1")]
		private sealed class <FinalRenderCapture>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005A6E RID: 23150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A72")]
			[Address(RVA = "0x24792A0", Offset = "0x24793A1", VA = "0x24792A0")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__13(int <>1__state)
			{
			}

			// Token: 0x06005A6F RID: 23151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A73")]
			[Address(RVA = "0x247A160", Offset = "0x247A261", VA = "0x247A160", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005A70 RID: 23152 RVA: 0x0001DB80 File Offset: 0x0001BD80
			[Token(Token = "0x6007A74")]
			[Address(RVA = "0x247A170", Offset = "0x247A271", VA = "0x247A170", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B8D RID: 2957
			// (get) Token: 0x06005A71 RID: 23153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E4D")]
			private object Current
			{
				[Token(Token = "0x6007A75")]
				[Address(RVA = "0x247A1F0", Offset = "0x247A2F1", VA = "0x247A1F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A72 RID: 23154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A76")]
			[Address(RVA = "0x247A200", Offset = "0x247A301", VA = "0x247A200", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B8E RID: 2958
			// (get) Token: 0x06005A73 RID: 23155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E4E")]
			private object Current
			{
				[Token(Token = "0x6007A77")]
				[Address(RVA = "0x247A260", Offset = "0x247A361", VA = "0x247A260", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B9C6 RID: 47558
			[Token(Token = "0x401BB23")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B9C7 RID: 47559
			[Token(Token = "0x401BB24")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B9C8 RID: 47560
			[Token(Token = "0x401BB25")]
			[FieldOffset(Offset = "0x20")]
			public CaptureFromCamera <>4__this;
		}
	}
}
