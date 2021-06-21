using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DC9 RID: 3529
	[Token(Token = "0x20008FA")]
	public class NativePlugin
	{
		// Token: 0x06005B48 RID: 23368
		[Token(Token = "0x6004B6C")]
		[Address(RVA = "0x2488E10", Offset = "0x2488F11", VA = "0x2488E10")]
		[PreserveSig]
		public static extern IntPtr GetRenderEventFunc();

		// Token: 0x06005B49 RID: 23369
		[Token(Token = "0x6004B6D")]
		[Address(RVA = "0x2488E80", Offset = "0x2488F81", VA = "0x2488E80")]
		[PreserveSig]
		public static extern IntPtr GetFreeResourcesEventFunc();

		// Token: 0x06005B4A RID: 23370
		[Token(Token = "0x6004B6E")]
		[Address(RVA = "0x2488EF0", Offset = "0x2488FF1", VA = "0x2488EF0")]
		[PreserveSig]
		public static extern bool Init();

		// Token: 0x06005B4B RID: 23371
		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x2488F70", Offset = "0x2489071", VA = "0x2488F70")]
		[PreserveSig]
		public static extern void Deinit();

		// Token: 0x06005B4C RID: 23372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B70")]
		[Address(RVA = "0x2488FE0", Offset = "0x24890E1", VA = "0x2488FE0")]
		public static string GetPluginVersionString()
		{
			return null;
		}

		// Token: 0x06005B4D RID: 23373
		[Token(Token = "0x6004B71")]
		[Address(RVA = "0x2489120", Offset = "0x2489221", VA = "0x2489120")]
		[PreserveSig]
		public static extern bool IsTrialVersion();

		// Token: 0x06005B4E RID: 23374
		[Token(Token = "0x6004B72")]
		[Address(RVA = "0x2480B50", Offset = "0x2480C51", VA = "0x2480B50")]
		[PreserveSig]
		public static extern int GetNumAVIVideoCodecs();

		// Token: 0x06005B4F RID: 23375
		[Token(Token = "0x6004B73")]
		[Address(RVA = "0x2480D00", Offset = "0x2480E01", VA = "0x2480D00")]
		[PreserveSig]
		public static extern bool IsConfigureVideoCodecSupported(int index);

		// Token: 0x06005B50 RID: 23376
		[Token(Token = "0x6004B74")]
		[Address(RVA = "0x24853E0", Offset = "0x24854E1", VA = "0x24853E0")]
		[PreserveSig]
		public static extern void ConfigureVideoCodec(int index);

		// Token: 0x06005B51 RID: 23377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B75")]
		[Address(RVA = "0x2480BC0", Offset = "0x2480CC1", VA = "0x2480BC0")]
		public static string GetAVIVideoCodecName(int index)
		{
			return null;
		}

		// Token: 0x06005B52 RID: 23378
		[Token(Token = "0x6004B76")]
		[Address(RVA = "0x2480F40", Offset = "0x2481041", VA = "0x2480F40")]
		[PreserveSig]
		public static extern int GetNumAVIAudioCodecs();

		// Token: 0x06005B53 RID: 23379
		[Token(Token = "0x6004B77")]
		[Address(RVA = "0x24810F0", Offset = "0x24811F1", VA = "0x24810F0")]
		[PreserveSig]
		public static extern bool IsConfigureAudioCodecSupported(int index);

		// Token: 0x06005B54 RID: 23380
		[Token(Token = "0x6004B78")]
		[Address(RVA = "0x2485460", Offset = "0x2485561", VA = "0x2485460")]
		[PreserveSig]
		public static extern void ConfigureAudioCodec(int index);

		// Token: 0x06005B55 RID: 23381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B79")]
		[Address(RVA = "0x2480FB0", Offset = "0x24810B1", VA = "0x2480FB0")]
		public static string GetAVIAudioCodecName(int index)
		{
			return null;
		}

		// Token: 0x06005B56 RID: 23382
		[Token(Token = "0x6004B7A")]
		[Address(RVA = "0x2480D90", Offset = "0x2480E91", VA = "0x2480D90")]
		[PreserveSig]
		public static extern int GetNumAVIAudioInputDevices();

		// Token: 0x06005B57 RID: 23383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7B")]
		[Address(RVA = "0x2480E00", Offset = "0x2480F01", VA = "0x2480E00")]
		public static string GetAVIAudioInputDeviceName(int index)
		{
			return null;
		}

		// Token: 0x06005B58 RID: 23384
		[Token(Token = "0x6004B7C")]
		[Address(RVA = "0x2489410", Offset = "0x2489511", VA = "0x2489410")]
		[PreserveSig]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush);

		// Token: 0x06005B59 RID: 23385
		[Token(Token = "0x6004B7D")]
		[Address(RVA = "0x2489550", Offset = "0x2489651", VA = "0x2489550")]
		[PreserveSig]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame);

		// Token: 0x06005B5A RID: 23386
		[Token(Token = "0x6004B7E")]
		[Address(RVA = "0x2489660", Offset = "0x2489761", VA = "0x2489660")]
		[PreserveSig]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush);

		// Token: 0x06005B5B RID: 23387
		[Token(Token = "0x6004B7F")]
		[Address(RVA = "0x2489740", Offset = "0x2489841", VA = "0x2489740")]
		[PreserveSig]
		public static extern bool Start(int handle);

		// Token: 0x06005B5C RID: 23388
		[Token(Token = "0x6004B80")]
		[Address(RVA = "0x24897D0", Offset = "0x24898D1", VA = "0x24897D0")]
		[PreserveSig]
		public static extern bool IsNewFrameDue(int handle);

		// Token: 0x06005B5D RID: 23389
		[Token(Token = "0x6004B81")]
		[Address(RVA = "0x2489860", Offset = "0x2489961", VA = "0x2489860")]
		[PreserveSig]
		public static extern void EncodeFrame(int handle, IntPtr data);

		// Token: 0x06005B5E RID: 23390
		[Token(Token = "0x6004B82")]
		[Address(RVA = "0x2479810", Offset = "0x2479911", VA = "0x2479810")]
		[PreserveSig]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		// Token: 0x06005B5F RID: 23391
		[Token(Token = "0x6004B83")]
		[Address(RVA = "0x24898F0", Offset = "0x24899F1", VA = "0x24898F0")]
		[PreserveSig]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		// Token: 0x06005B60 RID: 23392
		[Token(Token = "0x6004B84")]
		[Address(RVA = "0x24899A0", Offset = "0x2489AA1", VA = "0x24899A0")]
		[PreserveSig]
		public static extern void Pause(int handle);

		// Token: 0x06005B61 RID: 23393
		[Token(Token = "0x6004B85")]
		[Address(RVA = "0x2489A20", Offset = "0x2489B21", VA = "0x2489A20")]
		[PreserveSig]
		public static extern void Stop(int handle, bool skipPendingFrames);

		// Token: 0x06005B62 RID: 23394
		[Token(Token = "0x6004B86")]
		[Address(RVA = "0x24796B0", Offset = "0x24797B1", VA = "0x24796B0")]
		[PreserveSig]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		// Token: 0x06005B63 RID: 23395
		[Token(Token = "0x6004B87")]
		[Address(RVA = "0x2489AB0", Offset = "0x2489BB1", VA = "0x2489AB0")]
		[PreserveSig]
		public static extern void FreeRecorder(int handle);

		// Token: 0x06005B64 RID: 23396
		[Token(Token = "0x6004B88")]
		[Address(RVA = "0x2489B30", Offset = "0x2489C31", VA = "0x2489B30")]
		[PreserveSig]
		public static extern uint GetNumDroppedFrames(int handle);

		// Token: 0x06005B65 RID: 23397
		[Token(Token = "0x6004B89")]
		[Address(RVA = "0x2489BB0", Offset = "0x2489CB1", VA = "0x2489BB0")]
		[PreserveSig]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		// Token: 0x06005B66 RID: 23398
		[Token(Token = "0x6004B8A")]
		[Address(RVA = "0x2489C30", Offset = "0x2489D31", VA = "0x2489C30")]
		[PreserveSig]
		public static extern uint GetNumEncodedFrames(int handle);

		// Token: 0x06005B67 RID: 23399
		[Token(Token = "0x6004B8B")]
		[Address(RVA = "0x2489CB0", Offset = "0x2489DB1", VA = "0x2489CB0")]
		[PreserveSig]
		public static extern uint GetEncodedSeconds(int handle);

		// Token: 0x06005B68 RID: 23400
		[Token(Token = "0x6004B8C")]
		[Address(RVA = "0x24890B0", Offset = "0x24891B1", VA = "0x24890B0")]
		[PreserveSig]
		private static extern IntPtr GetPluginVersion();

		// Token: 0x06005B69 RID: 23401
		[Token(Token = "0x6004B8D")]
		[Address(RVA = "0x24891A0", Offset = "0x24892A1", VA = "0x24891A0")]
		[PreserveSig]
		private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		// Token: 0x06005B6A RID: 23402
		[Token(Token = "0x6004B8E")]
		[Address(RVA = "0x2489270", Offset = "0x2489371", VA = "0x2489270")]
		[PreserveSig]
		private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		// Token: 0x06005B6B RID: 23403
		[Token(Token = "0x6004B8F")]
		[Address(RVA = "0x2489340", Offset = "0x2489441", VA = "0x2489340")]
		[PreserveSig]
		private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		// Token: 0x06005B6C RID: 23404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B90")]
		[Address(RVA = "0x2489D30", Offset = "0x2489E31", VA = "0x2489D30")]
		public NativePlugin()
		{
		}

		// Token: 0x0400BAF0 RID: 47856
		[Token(Token = "0x4008B80")]
		public const int PluginID = 262340608;

		// Token: 0x0400BAF1 RID: 47857
		[Token(Token = "0x4008B81")]
		public const string ScriptVersion = "3.7.2";

		// Token: 0x0400BAF2 RID: 47858
		[Token(Token = "0x4008B82")]
		public const string ExpectedPluginVersion = "3.7.2";

		// Token: 0x0400BAF3 RID: 47859
		[Token(Token = "0x4008B83")]
		public const int MaxRenderWidth = 16384;

		// Token: 0x0400BAF4 RID: 47860
		[Token(Token = "0x4008B84")]
		public const int MaxRenderHeight = 16384;

		// Token: 0x02000DCA RID: 3530
		[Token(Token = "0x200143C")]
		public enum PixelFormat
		{
			// Token: 0x0400BAF6 RID: 47862
			[Token(Token = "0x401BB88")]
			RGBA32,
			// Token: 0x0400BAF7 RID: 47863
			[Token(Token = "0x401BB89")]
			BGRA32,
			// Token: 0x0400BAF8 RID: 47864
			[Token(Token = "0x401BB8A")]
			YCbCr422_YUY2,
			// Token: 0x0400BAF9 RID: 47865
			[Token(Token = "0x401BB8B")]
			YCbCr422_UYVY,
			// Token: 0x0400BAFA RID: 47866
			[Token(Token = "0x401BB8C")]
			YCbCr422_HDYC
		}

		// Token: 0x02000DCB RID: 3531
		[Token(Token = "0x200143D")]
		public enum PluginEvent
		{
			// Token: 0x0400BAFC RID: 47868
			[Token(Token = "0x401BB8E")]
			CaptureFrameBuffer,
			// Token: 0x0400BAFD RID: 47869
			[Token(Token = "0x401BB8F")]
			FreeResources
		}
	}
}
