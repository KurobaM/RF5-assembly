using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DB2 RID: 3506
	[Token(Token = "0x20008EF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148A20", Offset = "0x148B21")]
	public class CaptureFromTexture : CaptureBase
	{
		// Token: 0x06005AA8 RID: 23208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0x247ED90", Offset = "0x247EE91", VA = "0x247ED90")]
		public void SetSourceTexture(Texture texture)
		{
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x247F000", Offset = "0x247F101", VA = "0x247F000")]
		public void UpdateSourceTexture()
		{
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x0001DC40 File Offset: 0x0001BE40
		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x247F010", Offset = "0x247F111", VA = "0x247F010")]
		private bool ShouldCaptureFrame()
		{
			return default(bool);
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x0001DC58 File Offset: 0x0001BE58
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x247F0A0", Offset = "0x247F1A1", VA = "0x247F0A0")]
		private bool HasSourceTextureChanged()
		{
			return default(bool);
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x247F0C0", Offset = "0x247F1C1", VA = "0x247F0C0", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0x247F170", Offset = "0x247F271", VA = "0x247F170")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ABC20", Offset = "0x1ABD21")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADA")]
		[Address(RVA = "0x247F1F0", Offset = "0x247F2F1", VA = "0x247F1F0")]
		private void Capture()
		{
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADB")]
		[Address(RVA = "0x247F590", Offset = "0x247F691", VA = "0x247F590")]
		private void AccumulateMotionBlur()
		{
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADC")]
		[Address(RVA = "0x247F6A0", Offset = "0x247F7A1", VA = "0x247F6A0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x0001DC70 File Offset: 0x0001BE70
		[Token(Token = "0x6004ADD")]
		[Address(RVA = "0x247F750", Offset = "0x247F851", VA = "0x247F750", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x247F980", Offset = "0x247FA81", VA = "0x247F980", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x247FAA0", Offset = "0x247FBA1", VA = "0x247FAA0")]
		public CaptureFromTexture()
		{
		}

		// Token: 0x0400B9F9 RID: 47609
		[Token(Token = "0x4008AD5")]
		[FieldOffset(Offset = "0x1B0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CBE0", Offset = "0x17CCE1")]
		[SerializeField]
		private bool _manualUpdate;

		// Token: 0x0400B9FA RID: 47610
		[Token(Token = "0x4008AD6")]
		[FieldOffset(Offset = "0x1B8")]
		private Texture _sourceTexture;

		// Token: 0x0400B9FB RID: 47611
		[Token(Token = "0x4008AD7")]
		[FieldOffset(Offset = "0x1C0")]
		private RenderTexture _renderTexture;

		// Token: 0x0400B9FC RID: 47612
		[Token(Token = "0x4008AD8")]
		[FieldOffset(Offset = "0x1C8")]
		private IntPtr _targetNativePointer;

		// Token: 0x0400B9FD RID: 47613
		[Token(Token = "0x4008AD9")]
		[FieldOffset(Offset = "0x1D0")]
		public bool _isSourceTextureChanged;

		// Token: 0x02000DB3 RID: 3507
		[Token(Token = "0x2001430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159800", Offset = "0x159901")]
		private sealed class <FinalRenderCapture>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005AB4 RID: 23220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A8B")]
			[Address(RVA = "0x247F560", Offset = "0x247F661", VA = "0x247F560")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__10(int <>1__state)
			{
			}

			// Token: 0x06005AB5 RID: 23221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A8C")]
			[Address(RVA = "0x247FB10", Offset = "0x247FC11", VA = "0x247FB10", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005AB6 RID: 23222 RVA: 0x0001DC88 File Offset: 0x0001BE88
			[Token(Token = "0x6007A8D")]
			[Address(RVA = "0x247FB20", Offset = "0x247FC21", VA = "0x247FB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B96 RID: 2966
			// (get) Token: 0x06005AB7 RID: 23223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E55")]
			private object Current
			{
				[Token(Token = "0x6007A8E")]
				[Address(RVA = "0x247FBA0", Offset = "0x247FCA1", VA = "0x247FBA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005AB8 RID: 23224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A8F")]
			[Address(RVA = "0x247FBB0", Offset = "0x247FCB1", VA = "0x247FBB0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B97 RID: 2967
			// (get) Token: 0x06005AB9 RID: 23225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E56")]
			private object Current
			{
				[Token(Token = "0x6007A90")]
				[Address(RVA = "0x247FC10", Offset = "0x247FD11", VA = "0x247FC10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B9FE RID: 47614
			[Token(Token = "0x401BB3B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B9FF RID: 47615
			[Token(Token = "0x401BB3C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400BA00 RID: 47616
			[Token(Token = "0x401BB3D")]
			[FieldOffset(Offset = "0x20")]
			public CaptureFromTexture <>4__this;
		}
	}
}
