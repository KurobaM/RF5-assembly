using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DB7 RID: 3511
	[Token(Token = "0x20008F3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148B20", Offset = "0x148C21")]
	public class UnityAudioCapture : MonoBehaviour
	{
		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000902")]
		public float[] Buffer
		{
			[Token(Token = "0x6004B04")]
			[Address(RVA = "0x2489D40", Offset = "0x2489E41", VA = "0x2489D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06005ADF RID: 23263 RVA: 0x0001DD00 File Offset: 0x0001BF00
		[Token(Token = "0x17000903")]
		public int BufferLength
		{
			[Token(Token = "0x6004B05")]
			[Address(RVA = "0x2489D50", Offset = "0x2489E51", VA = "0x2489D50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x0001DD18 File Offset: 0x0001BF18
		[Token(Token = "0x17000904")]
		public int NumChannels
		{
			[Token(Token = "0x6004B06")]
			[Address(RVA = "0x2489D60", Offset = "0x2489E61", VA = "0x2489D60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06005AE1 RID: 23265 RVA: 0x0001DD30 File Offset: 0x0001BF30
		[Token(Token = "0x17000905")]
		public IntPtr BufferPtr
		{
			[Token(Token = "0x6004B07")]
			[Address(RVA = "0x2489D70", Offset = "0x2489E71", VA = "0x2489D70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x0001DD48 File Offset: 0x0001BF48
		[Token(Token = "0x17000906")]
		public int OverflowCount
		{
			[Token(Token = "0x6004B08")]
			[Address(RVA = "0x2489D80", Offset = "0x2489E81", VA = "0x2489D80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B09")]
		[Address(RVA = "0x2489D90", Offset = "0x2489E91", VA = "0x2489D90")]
		private void OnEnable()
		{
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0A")]
		[Address(RVA = "0x248A1D0", Offset = "0x248A2D1", VA = "0x248A1D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x0001DD60 File Offset: 0x0001BF60
		[Token(Token = "0x6004B0B")]
		[Address(RVA = "0x2479740", Offset = "0x2479841", VA = "0x2479740")]
		public IntPtr ReadData(out int length)
		{
			return 0;
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0C")]
		[Address(RVA = "0x248A2D0", Offset = "0x248A3D1", VA = "0x248A2D0")]
		public void FlushBuffer()
		{
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0D")]
		[Address(RVA = "0x248A360", Offset = "0x248A461", VA = "0x248A360")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x0001DD78 File Offset: 0x0001BF78
		[Token(Token = "0x6004B0E")]
		[Address(RVA = "0x248A1A0", Offset = "0x248A2A1", VA = "0x248A1A0")]
		public static int GetNumChannels(AudioSpeakerMode mode)
		{
			return 0;
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0x248A640", Offset = "0x248A741", VA = "0x248A640")]
		public UnityAudioCapture()
		{
		}

		// Token: 0x0400BA2B RID: 47659
		[Token(Token = "0x4008B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _debugLogging;

		// Token: 0x0400BA2C RID: 47660
		[Token(Token = "0x4008B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _muteAudio;

		// Token: 0x0400BA2D RID: 47661
		[Token(Token = "0x4008B06")]
		private const int BufferSize = 16;

		// Token: 0x0400BA2E RID: 47662
		[Token(Token = "0x4008B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float[] _buffer;

		// Token: 0x0400BA2F RID: 47663
		[Token(Token = "0x4008B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float[] _readBuffer;

		// Token: 0x0400BA30 RID: 47664
		[Token(Token = "0x4008B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _bufferIndex;

		// Token: 0x0400BA31 RID: 47665
		[Token(Token = "0x4008B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private GCHandle _bufferHandle;

		// Token: 0x0400BA32 RID: 47666
		[Token(Token = "0x4008B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _numChannels;

		// Token: 0x0400BA33 RID: 47667
		[Token(Token = "0x4008B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _overflowCount;

		// Token: 0x0400BA34 RID: 47668
		[Token(Token = "0x4008B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _lockObject;
	}
}
