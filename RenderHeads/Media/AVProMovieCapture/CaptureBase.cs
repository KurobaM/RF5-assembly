using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DB8 RID: 3512
	[Token(Token = "0x20008F4")]
	public class CaptureBase : MonoBehaviour
	{
		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06005AEA RID: 23274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000907")]
		public string LastFilePath
		{
			[Token(Token = "0x6004B10")]
			[Address(RVA = "0x1F40C40", Offset = "0x1F40D41", VA = "0x1F40C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06005AEB RID: 23275 RVA: 0x0001DD90 File Offset: 0x0001BF90
		[Token(Token = "0x17000908")]
		public uint NumDroppedFrames
		{
			[Token(Token = "0x6004B11")]
			[Address(RVA = "0x1F40C50", Offset = "0x1F40D51", VA = "0x1F40C50")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06005AEC RID: 23276 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
		[Token(Token = "0x17000909")]
		public uint NumDroppedEncoderFrames
		{
			[Token(Token = "0x6004B12")]
			[Address(RVA = "0x1F40C60", Offset = "0x1F40D61", VA = "0x1F40C60")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06005AED RID: 23277 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
		[Token(Token = "0x1700090A")]
		public uint NumEncodedFrames
		{
			[Token(Token = "0x6004B13")]
			[Address(RVA = "0x1F40C70", Offset = "0x1F40D71", VA = "0x1F40C70")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06005AEE RID: 23278 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		[Token(Token = "0x1700090B")]
		public uint TotalEncodedSeconds
		{
			[Token(Token = "0x6004B14")]
			[Address(RVA = "0x1F40C80", Offset = "0x1F40D81", VA = "0x1F40C80")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06005AEF RID: 23279 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AF0 RID: 23280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090C")]
		public string[] VideoCodecPriority
		{
			[Token(Token = "0x6004B15")]
			[Address(RVA = "0x1F40C90", Offset = "0x1F40D91", VA = "0x1F40C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B16")]
			[Address(RVA = "0x1F40CA0", Offset = "0x1F40DA1", VA = "0x1F40CA0")]
			set
			{
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06005AF1 RID: 23281 RVA: 0x0001DDF0 File Offset: 0x0001BFF0
		// (set) Token: 0x06005AF2 RID: 23282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090D")]
		public int TimelapseScale
		{
			[Token(Token = "0x6004B17")]
			[Address(RVA = "0x1F410E0", Offset = "0x1F411E1", VA = "0x1F410E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004B18")]
			[Address(RVA = "0x1F410F0", Offset = "0x1F411F1", VA = "0x1F410F0")]
			set
			{
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06005AF3 RID: 23283 RVA: 0x0001DE08 File Offset: 0x0001C008
		// (set) Token: 0x06005AF4 RID: 23284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090E")]
		public bool UseWaitForEndOfFrame
		{
			[Token(Token = "0x6004B19")]
			[Address(RVA = "0x1F41100", Offset = "0x1F41201", VA = "0x1F41100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B1A")]
			[Address(RVA = "0x1F41110", Offset = "0x1F41211", VA = "0x1F41110")]
			set
			{
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700090F")]
		public CaptureBase.PostCaptureSettings PostCapture
		{
			[Token(Token = "0x6004B1B")]
			[Address(RVA = "0x1F41120", Offset = "0x1F41221", VA = "0x1F41120")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x1F41130", Offset = "0x1F41231", VA = "0x1F41130", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x1F41A60", Offset = "0x1F41B61", VA = "0x1F41A60")]
		protected void SetupRenderFunctions()
		{
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x1F42140", Offset = "0x1F42241", VA = "0x1F42140", Slot = "5")]
		public virtual void Start()
		{
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x1F40CD0", Offset = "0x1F40DD1", VA = "0x1F40CD0")]
		public void SelectCodec(bool listCodecs)
		{
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x1F41AA0", Offset = "0x1F41BA1", VA = "0x1F41AA0")]
		public void SelectAudioCodec(bool listCodecs)
		{
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x1F41EB0", Offset = "0x1F41FB1", VA = "0x1F41EB0")]
		public void SelectAudioDevice(bool display)
		{
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x0001DE20 File Offset: 0x0001C020
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x1F423B0", Offset = "0x1F424B1", VA = "0x1F423B0")]
		public static Vector2 GetRecordingResolution(int width, int height, CaptureBase.DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x1F424E0", Offset = "0x1F425E1", VA = "0x1F424E0")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x1F42600", Offset = "0x1F42701", VA = "0x1F42600", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x1F42640", Offset = "0x1F42741", VA = "0x1F42640")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x1F426F0", Offset = "0x1F427F1", VA = "0x1F426F0")]
		protected void EncodeTexture(Texture2D texture)
		{
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x0001DE38 File Offset: 0x0001C038
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x1F42770", Offset = "0x1F42871", VA = "0x1F42770")]
		protected bool IsUsingUnityAudio()
		{
			return default(bool);
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x0001DE50 File Offset: 0x0001C050
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x1F42810", Offset = "0x1F42911", VA = "0x1F42810")]
		protected bool IsRecordingUnityAudio()
		{
			return default(bool);
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x0001DE68 File Offset: 0x0001C068
		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x1F428C0", Offset = "0x1F429C1", VA = "0x1F428C0")]
		protected bool IsUsingMotionBlur()
		{
			return default(bool);
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x1F42950", Offset = "0x1F42A51", VA = "0x1F42950", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		// Token: 0x06005B05 RID: 23301 RVA: 0x0001DE80 File Offset: 0x0001C080
		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x1F429E0", Offset = "0x1F42AE1", VA = "0x1F429E0")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		// Token: 0x06005B06 RID: 23302 RVA: 0x0001DE98 File Offset: 0x0001C098
		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x1F429F0", Offset = "0x1F42AF1", VA = "0x1F429F0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x06005B07 RID: 23303 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x1F42A00", Offset = "0x1F42B01", VA = "0x1F42A00")]
		public int GetRecordingWidth()
		{
			return 0;
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x1F42A10", Offset = "0x1F42B11", VA = "0x1F42A10")]
		public int GetRecordingHeight()
		{
			return 0;
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B2F")]
		[Address(RVA = "0x1F42A20", Offset = "0x1F42B21", VA = "0x1F42A20", Slot = "8")]
		protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension)
		{
			return null;
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x1F42DC0", Offset = "0x1F42EC1", VA = "0x1F42DC0")]
		private static string GetFolder(CaptureBase.OutputPath outputPathType, string path)
		{
			return null;
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x1F42ED0", Offset = "0x1F42FD1", VA = "0x1F42ED0")]
		private static string AutoGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x1F42F80", Offset = "0x1F43081", VA = "0x1F42F80")]
		private static string ManualGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		[Token(Token = "0x6004B33")]
		[Address(RVA = "0x1F43080", Offset = "0x1F43181", VA = "0x1F43080")]
		protected static bool HasExtension(string path, string extension)
		{
			return default(bool);
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x1F430C0", Offset = "0x1F431C1", VA = "0x1F430C0")]
		protected void GenerateFilename()
		{
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x1F43600", Offset = "0x1F43701", VA = "0x1F43600", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x1F444F0", Offset = "0x1F445F1", VA = "0x1F444F0")]
		public void QueueStartCapture()
		{
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x0001DF10 File Offset: 0x0001C110
		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x1F421D0", Offset = "0x1F422D1", VA = "0x1F421D0")]
		public bool StartCapture()
		{
			return default(bool);
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x1F44540", Offset = "0x1F44641", VA = "0x1F44540")]
		public void PauseCapture()
		{
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x1F44630", Offset = "0x1F44731", VA = "0x1F44630")]
		public void ResumeCapture()
		{
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x1F44740", Offset = "0x1F44841", VA = "0x1F44740")]
		public void CancelCapture()
		{
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x1F447A0", Offset = "0x1F448A1", VA = "0x1F447A0", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06005B16 RID: 23318 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B17 RID: 23319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000910")]
		public static string LastFileSaved
		{
			[Token(Token = "0x6004B3C")]
			[Address(RVA = "0x1F44840", Offset = "0x1F44941", VA = "0x1F44840")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B3D")]
			[Address(RVA = "0x1F448A0", Offset = "0x1F449A1", VA = "0x1F448A0")]
			set
			{
			}
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3E")]
		[Address(RVA = "0x1F44900", Offset = "0x1F44A01", VA = "0x1F44900")]
		protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent)
		{
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x1F449C0", Offset = "0x1F44AC1", VA = "0x1F449C0", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false)
		{
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x1F44DD0", Offset = "0x1F44ED1", VA = "0x1F44DD0")]
		protected void ApplyPostOperations(string path)
		{
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B41")]
		[Address(RVA = "0x1F44FB0", Offset = "0x1F450B1", VA = "0x1F44FB0")]
		private void ToggleCapture()
		{
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x0001DF28 File Offset: 0x0001C128
		[Token(Token = "0x6004B42")]
		[Address(RVA = "0x1F44FD0", Offset = "0x1F450D1", VA = "0x1F44FD0")]
		private bool IsEnoughDiskSpace()
		{
			return default(bool);
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B43")]
		[Address(RVA = "0x1F44FE0", Offset = "0x1F450E1", VA = "0x1F44FE0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B44")]
		[Address(RVA = "0x1F45040", Offset = "0x1F45141", VA = "0x1F45040")]
		private void CheckFreeDiskSpace()
		{
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x0001DF40 File Offset: 0x0001C140
		[Token(Token = "0x6004B45")]
		[Address(RVA = "0x1F45080", Offset = "0x1F45181", VA = "0x1F45080")]
		protected bool IsProgressComplete()
		{
			return default(bool);
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x0001DF58 File Offset: 0x0001C158
		[Token(Token = "0x6004B46")]
		[Address(RVA = "0x1F45160", Offset = "0x1F45261", VA = "0x1F45160")]
		public float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x0001DF70 File Offset: 0x0001C170
		[Token(Token = "0x6004B47")]
		[Address(RVA = "0x1F44510", Offset = "0x1F44611", VA = "0x1F44510")]
		protected float GetSecondsPerCaptureFrame()
		{
			return 0f;
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x0001DF88 File Offset: 0x0001C188
		[Token(Token = "0x6004B48")]
		[Address(RVA = "0x1F45220", Offset = "0x1F45321", VA = "0x1F45220")]
		protected bool CanOutputFrame()
		{
			return default(bool);
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B49")]
		[Address(RVA = "0x1F45300", Offset = "0x1F45401", VA = "0x1F45300")]
		protected void TickFrameTimer()
		{
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4A")]
		[Address(RVA = "0x1F45340", Offset = "0x1F45441", VA = "0x1F45340")]
		protected void RenormTimer()
		{
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B4B")]
		[Address(RVA = "0x1F45380", Offset = "0x1F45481", VA = "0x1F45380", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4C")]
		[Address(RVA = "0x1F45390", Offset = "0x1F45491", VA = "0x1F45390", Slot = "13")]
		public virtual void UpdateFrame()
		{
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06005B27 RID: 23335 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		[Token(Token = "0x17000911")]
		public float FPS
		{
			[Token(Token = "0x6004B4D")]
			[Address(RVA = "0x1F45500", Offset = "0x1F45601", VA = "0x1F45500")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		[Token(Token = "0x17000912")]
		public float FramesTotal
		{
			[Token(Token = "0x6004B4E")]
			[Address(RVA = "0x1F45510", Offset = "0x1F45611", VA = "0x1F45510")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x1F44500", Offset = "0x1F44601", VA = "0x1F44500")]
		protected void ResetFPS()
		{
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x1F45520", Offset = "0x1F45621", VA = "0x1F45520")]
		public void UpdateFPS()
		{
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x1F45590", Offset = "0x1F45691", VA = "0x1F45590")]
		protected int GetCameraAntiAliasingLevel(Camera camera)
		{
			return 0;
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B52")]
		[Address(RVA = "0x1F45730", Offset = "0x1F45831", VA = "0x1F45730")]
		private void ConfigureCodec()
		{
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		[Token(Token = "0x6004B53")]
		[Address(RVA = "0x1F45780", Offset = "0x1F45881", VA = "0x1F45780")]
		public long GetCaptureFileSize()
		{
			return 0L;
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B54")]
		[Address(RVA = "0x1F45860", Offset = "0x1F45961", VA = "0x1F45860")]
		public static void GetResolution(CaptureBase.Resolution res, ref int width, ref int height)
		{
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x0001E000 File Offset: 0x0001C200
		[Token(Token = "0x6004B55")]
		[Address(RVA = "0x1F424D0", Offset = "0x1F425D1", VA = "0x1F424D0")]
		protected static int NextMultipleOf4(int value)
		{
			return 0;
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B56")]
		[Address(RVA = "0x1F45890", Offset = "0x1F45991", VA = "0x1F45890")]
		public CaptureBase()
		{
		}

		// Token: 0x0400BA35 RID: 47669
		[Token(Token = "0x4008B0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CaptureBase.PostCaptureSettings _postCaptureSettings;

		// Token: 0x0400BA36 RID: 47670
		[Token(Token = "0x4008B0F")]
		[FieldOffset(Offset = "0x20")]
		public KeyCode _captureKey;

		// Token: 0x0400BA37 RID: 47671
		[Token(Token = "0x4008B10")]
		[FieldOffset(Offset = "0x24")]
		public bool _captureOnStart;

		// Token: 0x0400BA38 RID: 47672
		[Token(Token = "0x4008B11")]
		[FieldOffset(Offset = "0x25")]
		public bool _startPaused;

		// Token: 0x0400BA39 RID: 47673
		[Token(Token = "0x4008B12")]
		[FieldOffset(Offset = "0x26")]
		public bool _listVideoCodecsOnStart;

		// Token: 0x0400BA3A RID: 47674
		[Token(Token = "0x4008B13")]
		[FieldOffset(Offset = "0x27")]
		public bool _isRealTime;

		// Token: 0x0400BA3B RID: 47675
		[Token(Token = "0x4008B14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _persistAcrossSceneLoads;

		// Token: 0x0400BA3C RID: 47676
		[Token(Token = "0x4008B15")]
		[FieldOffset(Offset = "0x2C")]
		public StopMode _stopMode;

		// Token: 0x0400BA3D RID: 47677
		[Token(Token = "0x4008B16")]
		[FieldOffset(Offset = "0x30")]
		public int _stopFrames;

		// Token: 0x0400BA3E RID: 47678
		[Token(Token = "0x4008B17")]
		[FieldOffset(Offset = "0x34")]
		public float _stopSeconds;

		// Token: 0x0400BA3F RID: 47679
		[Token(Token = "0x4008B18")]
		[FieldOffset(Offset = "0x38")]
		public bool _useMediaFoundationH264;

		// Token: 0x0400BA40 RID: 47680
		[Token(Token = "0x4008B19")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] _videoCodecPriority;

		// Token: 0x0400BA41 RID: 47681
		[Token(Token = "0x4008B1A")]
		[FieldOffset(Offset = "0x48")]
		public CaptureBase.FrameRate _frameRate;

		// Token: 0x0400BA42 RID: 47682
		[Token(Token = "0x4008B1B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CD30", Offset = "0x17CE31")]
		private int _timelapseScale;

		// Token: 0x0400BA43 RID: 47683
		[Token(Token = "0x4008B1C")]
		[FieldOffset(Offset = "0x50")]
		public CaptureBase.DownScale _downScale;

		// Token: 0x0400BA44 RID: 47684
		[Token(Token = "0x4008B1D")]
		[FieldOffset(Offset = "0x54")]
		public Vector2 _maxVideoSize;

		// Token: 0x0400BA45 RID: 47685
		[Token(Token = "0x4008B1E")]
		[FieldOffset(Offset = "0x5C")]
		public int _forceVideoCodecIndex;

		// Token: 0x0400BA46 RID: 47686
		[Token(Token = "0x4008B1F")]
		[FieldOffset(Offset = "0x60")]
		public bool _flipVertically;

		// Token: 0x0400BA47 RID: 47687
		[Token(Token = "0x4008B20")]
		[FieldOffset(Offset = "0x61")]
		public bool _supportAlpha;

		// Token: 0x0400BA48 RID: 47688
		[Token(Token = "0x4008B21")]
		[FieldOffset(Offset = "0x62")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CD80", Offset = "0x17CE81")]
		[SerializeField]
		private bool _forceGpuFlush;

		// Token: 0x0400BA49 RID: 47689
		[Token(Token = "0x4008B22")]
		[FieldOffset(Offset = "0x63")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CDD0", Offset = "0x17CED1")]
		[SerializeField]
		protected bool _useWaitForEndOfFrame;

		// Token: 0x0400BA4A RID: 47690
		[Token(Token = "0x4008B23")]
		[FieldOffset(Offset = "0x64")]
		public bool _noAudio;

		// Token: 0x0400BA4B RID: 47691
		[Token(Token = "0x4008B24")]
		[FieldOffset(Offset = "0x68")]
		public string[] _audioCodecPriority;

		// Token: 0x0400BA4C RID: 47692
		[Token(Token = "0x4008B25")]
		[FieldOffset(Offset = "0x70")]
		public int _forceAudioCodecIndex;

		// Token: 0x0400BA4D RID: 47693
		[Token(Token = "0x4008B26")]
		[FieldOffset(Offset = "0x74")]
		public int _forceAudioDeviceIndex;

		// Token: 0x0400BA4E RID: 47694
		[Token(Token = "0x4008B27")]
		[FieldOffset(Offset = "0x78")]
		public UnityAudioCapture _audioCapture;

		// Token: 0x0400BA4F RID: 47695
		[Token(Token = "0x4008B28")]
		[FieldOffset(Offset = "0x80")]
		public bool _autoGenerateFilename;

		// Token: 0x0400BA50 RID: 47696
		[Token(Token = "0x4008B29")]
		[FieldOffset(Offset = "0x84")]
		public CaptureBase.OutputPath _outputFolderType;

		// Token: 0x0400BA51 RID: 47697
		[Token(Token = "0x4008B2A")]
		[FieldOffset(Offset = "0x88")]
		public string _outputFolderPath;

		// Token: 0x0400BA52 RID: 47698
		[Token(Token = "0x4008B2B")]
		[FieldOffset(Offset = "0x90")]
		public string _autoFilenamePrefix;

		// Token: 0x0400BA53 RID: 47699
		[Token(Token = "0x4008B2C")]
		[FieldOffset(Offset = "0x98")]
		public string _autoFilenameExtension;

		// Token: 0x0400BA54 RID: 47700
		[Token(Token = "0x4008B2D")]
		[FieldOffset(Offset = "0xA0")]
		public string _forceFilename;

		// Token: 0x0400BA55 RID: 47701
		[Token(Token = "0x4008B2E")]
		[FieldOffset(Offset = "0xA8")]
		public int _imageSequenceStartFrame;

		// Token: 0x0400BA56 RID: 47702
		[Token(Token = "0x4008B2F")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17CE20", Offset = "0x17CF21")]
		public int _imageSequenceZeroDigits;

		// Token: 0x0400BA57 RID: 47703
		[Token(Token = "0x4008B30")]
		[FieldOffset(Offset = "0xB0")]
		public CaptureBase.OutputType _outputType;

		// Token: 0x0400BA58 RID: 47704
		[Token(Token = "0x4008B31")]
		[FieldOffset(Offset = "0xB4")]
		public ImageSequenceFormat _imageSequenceFormat;

		// Token: 0x0400BA59 RID: 47705
		[Token(Token = "0x4008B32")]
		[FieldOffset(Offset = "0xB8")]
		public CaptureBase.Resolution _renderResolution;

		// Token: 0x0400BA5A RID: 47706
		[Token(Token = "0x4008B33")]
		[FieldOffset(Offset = "0xBC")]
		public Vector2 _renderSize;

		// Token: 0x0400BA5B RID: 47707
		[Token(Token = "0x4008B34")]
		[FieldOffset(Offset = "0xC4")]
		public int _renderAntiAliasing;

		// Token: 0x0400BA5C RID: 47708
		[Token(Token = "0x4008B35")]
		[FieldOffset(Offset = "0xC8")]
		public bool _useMotionBlur;

		// Token: 0x0400BA5D RID: 47709
		[Token(Token = "0x4008B36")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17CE40", Offset = "0x17CF41")]
		public int _motionBlurSamples;

		// Token: 0x0400BA5E RID: 47710
		[Token(Token = "0x4008B37")]
		[FieldOffset(Offset = "0xD0")]
		public Camera[] _motionBlurCameras;

		// Token: 0x0400BA5F RID: 47711
		[Token(Token = "0x4008B38")]
		[FieldOffset(Offset = "0xD8")]
		protected MotionBlur _motionBlur;

		// Token: 0x0400BA60 RID: 47712
		[Token(Token = "0x4008B39")]
		[FieldOffset(Offset = "0xE0")]
		public bool _allowVSyncDisable;

		// Token: 0x0400BA61 RID: 47713
		[Token(Token = "0x4008B3A")]
		[FieldOffset(Offset = "0xE1")]
		[SerializeField]
		protected bool _supportTextureRecreate;

		// Token: 0x0400BA62 RID: 47714
		[Token(Token = "0x4008B3B")]
		[FieldOffset(Offset = "0xE2")]
		public bool _captureMouseCursor;

		// Token: 0x0400BA63 RID: 47715
		[Token(Token = "0x4008B3C")]
		[FieldOffset(Offset = "0xE8")]
		public MouseCursor _mouseCursor;

		// Token: 0x0400BA64 RID: 47716
		[Token(Token = "0x4008B3D")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public string _codecName;

		// Token: 0x0400BA65 RID: 47717
		[Token(Token = "0x4008B3E")]
		[FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		public int _codecIndex;

		// Token: 0x0400BA66 RID: 47718
		[Token(Token = "0x4008B3F")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		public string _audioCodecName;

		// Token: 0x0400BA67 RID: 47719
		[Token(Token = "0x4008B40")]
		[FieldOffset(Offset = "0x108")]
		[NonSerialized]
		public int _audioCodecIndex;

		// Token: 0x0400BA68 RID: 47720
		[Token(Token = "0x4008B41")]
		[FieldOffset(Offset = "0x110")]
		[NonSerialized]
		public string _audioDeviceName;

		// Token: 0x0400BA69 RID: 47721
		[Token(Token = "0x4008B42")]
		[FieldOffset(Offset = "0x118")]
		[NonSerialized]
		public int _audioDeviceIndex;

		// Token: 0x0400BA6A RID: 47722
		[Token(Token = "0x4008B43")]
		[FieldOffset(Offset = "0x11C")]
		[NonSerialized]
		public int _unityAudioSampleRate;

		// Token: 0x0400BA6B RID: 47723
		[Token(Token = "0x4008B44")]
		[FieldOffset(Offset = "0x120")]
		[NonSerialized]
		public int _unityAudioChannelCount;

		// Token: 0x0400BA6C RID: 47724
		[Token(Token = "0x4008B45")]
		[FieldOffset(Offset = "0x128")]
		protected Texture2D _texture;

		// Token: 0x0400BA6D RID: 47725
		[Token(Token = "0x4008B46")]
		[FieldOffset(Offset = "0x130")]
		protected int _handle;

		// Token: 0x0400BA6E RID: 47726
		[Token(Token = "0x4008B47")]
		[FieldOffset(Offset = "0x134")]
		protected int _targetWidth;

		// Token: 0x0400BA6F RID: 47727
		[Token(Token = "0x4008B48")]
		[FieldOffset(Offset = "0x138")]
		protected int _targetHeight;

		// Token: 0x0400BA70 RID: 47728
		[Token(Token = "0x4008B49")]
		[FieldOffset(Offset = "0x13C")]
		protected bool _capturing;

		// Token: 0x0400BA71 RID: 47729
		[Token(Token = "0x4008B4A")]
		[FieldOffset(Offset = "0x13D")]
		protected bool _paused;

		// Token: 0x0400BA72 RID: 47730
		[Token(Token = "0x4008B4B")]
		[FieldOffset(Offset = "0x140")]
		protected string _filePath;

		// Token: 0x0400BA73 RID: 47731
		[Token(Token = "0x4008B4C")]
		[FieldOffset(Offset = "0x148")]
		protected FileInfo _fileInfo;

		// Token: 0x0400BA74 RID: 47732
		[Token(Token = "0x4008B4D")]
		[FieldOffset(Offset = "0x150")]
		protected NativePlugin.PixelFormat _pixelFormat;

		// Token: 0x0400BA75 RID: 47733
		[Token(Token = "0x4008B4E")]
		[FieldOffset(Offset = "0x154")]
		private int _oldVSyncCount;

		// Token: 0x0400BA76 RID: 47734
		[Token(Token = "0x4008B4F")]
		[FieldOffset(Offset = "0x158")]
		private float _oldFixedDeltaTime;

		// Token: 0x0400BA77 RID: 47735
		[Token(Token = "0x4008B50")]
		[FieldOffset(Offset = "0x15C")]
		protected bool _isTopDown;

		// Token: 0x0400BA78 RID: 47736
		[Token(Token = "0x4008B51")]
		[FieldOffset(Offset = "0x15D")]
		protected bool _isDirectX11;

		// Token: 0x0400BA79 RID: 47737
		[Token(Token = "0x4008B52")]
		[FieldOffset(Offset = "0x15E")]
		private bool _queuedStartCapture;

		// Token: 0x0400BA7A RID: 47738
		[Token(Token = "0x4008B53")]
		[FieldOffset(Offset = "0x15F")]
		private bool _queuedStopCapture;

		// Token: 0x0400BA7B RID: 47739
		[Token(Token = "0x4008B54")]
		[FieldOffset(Offset = "0x160")]
		private float _captureStartTime;

		// Token: 0x0400BA7C RID: 47740
		[Token(Token = "0x4008B55")]
		[FieldOffset(Offset = "0x164")]
		private float _timeSinceLastFrame;

		// Token: 0x0400BA7D RID: 47741
		[Token(Token = "0x4008B56")]
		[FieldOffset(Offset = "0x168")]
		protected YieldInstruction _waitForEndOfFrame;

		// Token: 0x0400BA7E RID: 47742
		[Token(Token = "0x4008B57")]
		[FieldOffset(Offset = "0x170")]
		public int _minimumDiskSpaceMB;

		// Token: 0x0400BA7F RID: 47743
		[Token(Token = "0x4008B58")]
		[FieldOffset(Offset = "0x178")]
		private long _freeDiskSpaceMB;

		// Token: 0x0400BA80 RID: 47744
		[Token(Token = "0x4008B59")]
		[FieldOffset(Offset = "0x180")]
		private uint _numDroppedFrames;

		// Token: 0x0400BA81 RID: 47745
		[Token(Token = "0x4008B5A")]
		[FieldOffset(Offset = "0x184")]
		private uint _numDroppedEncoderFrames;

		// Token: 0x0400BA82 RID: 47746
		[Token(Token = "0x4008B5B")]
		[FieldOffset(Offset = "0x188")]
		private uint _numEncodedFrames;

		// Token: 0x0400BA83 RID: 47747
		[Token(Token = "0x4008B5C")]
		[FieldOffset(Offset = "0x18C")]
		private uint _totalEncodedSeconds;

		// Token: 0x0400BA84 RID: 47748
		[Token(Token = "0x4008B5D")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isInitialised;

		// Token: 0x0400BA85 RID: 47749
		[Token(Token = "0x4008B5E")]
		[FieldOffset(Offset = "0x190")]
		protected IntPtr _renderEventFunction;

		// Token: 0x0400BA86 RID: 47750
		[Token(Token = "0x4008B5F")]
		[FieldOffset(Offset = "0x198")]
		protected IntPtr _freeEventFunction;

		// Token: 0x0400BA87 RID: 47751
		[Token(Token = "0x4008B60")]
		[FieldOffset(Offset = "0x1A0")]
		private float _fps;

		// Token: 0x0400BA88 RID: 47752
		[Token(Token = "0x4008B61")]
		[FieldOffset(Offset = "0x1A4")]
		private int _frameTotal;

		// Token: 0x0400BA89 RID: 47753
		[Token(Token = "0x4008B62")]
		[FieldOffset(Offset = "0x1A8")]
		private int _frameCount;

		// Token: 0x0400BA8A RID: 47754
		[Token(Token = "0x4008B63")]
		[FieldOffset(Offset = "0x1AC")]
		private float _startFrameTime;

		// Token: 0x02000DB9 RID: 3513
		[Token(Token = "0x2001431")]
		public enum FrameRate
		{
			// Token: 0x0400BA8C RID: 47756
			[Token(Token = "0x401BB3F")]
			One = 1,
			// Token: 0x0400BA8D RID: 47757
			[Token(Token = "0x401BB40")]
			Ten = 10,
			// Token: 0x0400BA8E RID: 47758
			[Token(Token = "0x401BB41")]
			Fifteen = 15,
			// Token: 0x0400BA8F RID: 47759
			[Token(Token = "0x401BB42")]
			TwentyFour = 24,
			// Token: 0x0400BA90 RID: 47760
			[Token(Token = "0x401BB43")]
			TwentyFive,
			// Token: 0x0400BA91 RID: 47761
			[Token(Token = "0x401BB44")]
			Thirty = 30,
			// Token: 0x0400BA92 RID: 47762
			[Token(Token = "0x401BB45")]
			Fifty = 50,
			// Token: 0x0400BA93 RID: 47763
			[Token(Token = "0x401BB46")]
			Sixty = 60,
			// Token: 0x0400BA94 RID: 47764
			[Token(Token = "0x401BB47")]
			SeventyFive = 75,
			// Token: 0x0400BA95 RID: 47765
			[Token(Token = "0x401BB48")]
			Ninety = 90,
			// Token: 0x0400BA96 RID: 47766
			[Token(Token = "0x401BB49")]
			OneTwenty = 120
		}

		// Token: 0x02000DBA RID: 3514
		[Token(Token = "0x2001432")]
		public enum Resolution
		{
			// Token: 0x0400BA98 RID: 47768
			[Token(Token = "0x401BB4B")]
			POW2_8192x8192,
			// Token: 0x0400BA99 RID: 47769
			[Token(Token = "0x401BB4C")]
			POW2_8192x4096,
			// Token: 0x0400BA9A RID: 47770
			[Token(Token = "0x401BB4D")]
			POW2_4096x4096,
			// Token: 0x0400BA9B RID: 47771
			[Token(Token = "0x401BB4E")]
			POW2_4096x2048,
			// Token: 0x0400BA9C RID: 47772
			[Token(Token = "0x401BB4F")]
			POW2_2048x4096,
			// Token: 0x0400BA9D RID: 47773
			[Token(Token = "0x401BB50")]
			UHD_3840x2160,
			// Token: 0x0400BA9E RID: 47774
			[Token(Token = "0x401BB51")]
			UHD_3840x2048,
			// Token: 0x0400BA9F RID: 47775
			[Token(Token = "0x401BB52")]
			UHD_3840x1920,
			// Token: 0x0400BAA0 RID: 47776
			[Token(Token = "0x401BB53")]
			POW2_2048x2048,
			// Token: 0x0400BAA1 RID: 47777
			[Token(Token = "0x401BB54")]
			POW2_2048x1024,
			// Token: 0x0400BAA2 RID: 47778
			[Token(Token = "0x401BB55")]
			HD_1920x1080,
			// Token: 0x0400BAA3 RID: 47779
			[Token(Token = "0x401BB56")]
			HD_1280x720,
			// Token: 0x0400BAA4 RID: 47780
			[Token(Token = "0x401BB57")]
			SD_1024x768,
			// Token: 0x0400BAA5 RID: 47781
			[Token(Token = "0x401BB58")]
			SD_800x600,
			// Token: 0x0400BAA6 RID: 47782
			[Token(Token = "0x401BB59")]
			SD_800x450,
			// Token: 0x0400BAA7 RID: 47783
			[Token(Token = "0x401BB5A")]
			SD_640x480,
			// Token: 0x0400BAA8 RID: 47784
			[Token(Token = "0x401BB5B")]
			SD_640x360,
			// Token: 0x0400BAA9 RID: 47785
			[Token(Token = "0x401BB5C")]
			SD_320x240,
			// Token: 0x0400BAAA RID: 47786
			[Token(Token = "0x401BB5D")]
			Original,
			// Token: 0x0400BAAB RID: 47787
			[Token(Token = "0x401BB5E")]
			Custom
		}

		// Token: 0x02000DBB RID: 3515
		[Token(Token = "0x2001433")]
		public enum CubemapDepth
		{
			// Token: 0x0400BAAD RID: 47789
			[Token(Token = "0x401BB60")]
			Depth_24 = 24,
			// Token: 0x0400BAAE RID: 47790
			[Token(Token = "0x401BB61")]
			Depth_16 = 16,
			// Token: 0x0400BAAF RID: 47791
			[Token(Token = "0x401BB62")]
			Depth_Zero = 0
		}

		// Token: 0x02000DBC RID: 3516
		[Token(Token = "0x2001434")]
		public enum CubemapResolution
		{
			// Token: 0x0400BAB1 RID: 47793
			[Token(Token = "0x401BB64")]
			POW2_4096 = 4096,
			// Token: 0x0400BAB2 RID: 47794
			[Token(Token = "0x401BB65")]
			POW2_2048 = 2048,
			// Token: 0x0400BAB3 RID: 47795
			[Token(Token = "0x401BB66")]
			POW2_1024 = 1024,
			// Token: 0x0400BAB4 RID: 47796
			[Token(Token = "0x401BB67")]
			POW2_512 = 512,
			// Token: 0x0400BAB5 RID: 47797
			[Token(Token = "0x401BB68")]
			POW2_256 = 256
		}

		// Token: 0x02000DBD RID: 3517
		[Token(Token = "0x2001435")]
		public enum AntiAliasingLevel
		{
			// Token: 0x0400BAB7 RID: 47799
			[Token(Token = "0x401BB6A")]
			UseCurrent,
			// Token: 0x0400BAB8 RID: 47800
			[Token(Token = "0x401BB6B")]
			ForceNone,
			// Token: 0x0400BAB9 RID: 47801
			[Token(Token = "0x401BB6C")]
			ForceSample2,
			// Token: 0x0400BABA RID: 47802
			[Token(Token = "0x401BB6D")]
			ForceSample4,
			// Token: 0x0400BABB RID: 47803
			[Token(Token = "0x401BB6E")]
			ForceSample8
		}

		// Token: 0x02000DBE RID: 3518
		[Token(Token = "0x2001436")]
		public enum DownScale
		{
			// Token: 0x0400BABD RID: 47805
			[Token(Token = "0x401BB70")]
			Original = 1,
			// Token: 0x0400BABE RID: 47806
			[Token(Token = "0x401BB71")]
			Half,
			// Token: 0x0400BABF RID: 47807
			[Token(Token = "0x401BB72")]
			Quarter = 4,
			// Token: 0x0400BAC0 RID: 47808
			[Token(Token = "0x401BB73")]
			Eighth = 8,
			// Token: 0x0400BAC1 RID: 47809
			[Token(Token = "0x401BB74")]
			Sixteenth = 16,
			// Token: 0x0400BAC2 RID: 47810
			[Token(Token = "0x401BB75")]
			Custom = 100
		}

		// Token: 0x02000DBF RID: 3519
		[Token(Token = "0x2001437")]
		public enum OutputPath
		{
			// Token: 0x0400BAC4 RID: 47812
			[Token(Token = "0x401BB77")]
			RelativeToProject,
			// Token: 0x0400BAC5 RID: 47813
			[Token(Token = "0x401BB78")]
			RelativeToPeristentData,
			// Token: 0x0400BAC6 RID: 47814
			[Token(Token = "0x401BB79")]
			Absolute
		}

		// Token: 0x02000DC0 RID: 3520
		[Token(Token = "0x2001438")]
		public enum OutputExtension
		{
			// Token: 0x0400BAC8 RID: 47816
			[Token(Token = "0x401BB7B")]
			AVI,
			// Token: 0x0400BAC9 RID: 47817
			[Token(Token = "0x401BB7C")]
			MP4,
			// Token: 0x0400BACA RID: 47818
			[Token(Token = "0x401BB7D")]
			PNG,
			// Token: 0x0400BACB RID: 47819
			[Token(Token = "0x401BB7E")]
			Custom = 100
		}

		// Token: 0x02000DC1 RID: 3521
		[Token(Token = "0x2001439")]
		public enum OutputType
		{
			// Token: 0x0400BACD RID: 47821
			[Token(Token = "0x401BB80")]
			VideoFile,
			// Token: 0x0400BACE RID: 47822
			[Token(Token = "0x401BB81")]
			ImageSequence,
			// Token: 0x0400BACF RID: 47823
			[Token(Token = "0x401BB82")]
			NamedPipe
		}

		// Token: 0x02000DC2 RID: 3522
		[Token(Token = "0x200143A")]
		[Serializable]
		public class PostCaptureSettings
		{
			// Token: 0x06005B32 RID: 23346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A91")]
			[Address(RVA = "0x2478670", Offset = "0x2478771", VA = "0x2478670")]
			public PostCaptureSettings()
			{
			}

			// Token: 0x0400BAD0 RID: 47824
			[Token(Token = "0x401BB83")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Attribute(Name = "TooltipAttribute", RVA = "0x199280", Offset = "0x199381")]
			public bool writeFastStartStreamingForMp4;
		}
	}
}
