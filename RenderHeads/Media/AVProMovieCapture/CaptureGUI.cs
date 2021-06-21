using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DB4 RID: 3508
	[Token(Token = "0x20008F0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148A60", Offset = "0x148B61")]
	public class CaptureGUI : MonoBehaviour
	{
		// Token: 0x06005ABA RID: 23226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x247FC20", Offset = "0x247FD21", VA = "0x247FC20")]
		private void Start()
		{
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x247FCB0", Offset = "0x247FDB1", VA = "0x247FCB0")]
		private void CreateGUI()
		{
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x2481180", Offset = "0x2481281", VA = "0x2481180")]
		private void OnGUI()
		{
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0x24814A0", Offset = "0x24815A1", VA = "0x24814A0")]
		private void MyWindow(int id)
		{
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0x2483D80", Offset = "0x2483E81", VA = "0x2483D80")]
		private void GUI_RecordingStatus()
		{
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE5")]
		[Address(RVA = "0x2485750", Offset = "0x2485851", VA = "0x2485750")]
		private void DrawGuiField(string a, string b)
		{
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE6")]
		[Address(RVA = "0x24854E0", Offset = "0x24855E1", VA = "0x24854E0")]
		private void StartCapture()
		{
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE7")]
		[Address(RVA = "0x2485B80", Offset = "0x2485C81", VA = "0x2485B80")]
		private void StopCapture()
		{
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE8")]
		[Address(RVA = "0x2485AE0", Offset = "0x2485BE1", VA = "0x2485AE0")]
		private void CancelCapture()
		{
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE9")]
		[Address(RVA = "0x2485A40", Offset = "0x2485B41", VA = "0x2485A40")]
		private void ResumeCapture()
		{
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x24859A0", Offset = "0x2485AA1", VA = "0x24859A0")]
		private void PauseCapture()
		{
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x2485C20", Offset = "0x2485D21", VA = "0x2485C20")]
		private void Update()
		{
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x2485DE0", Offset = "0x2485EE1", VA = "0x2485DE0")]
		public CaptureGUI()
		{
		}

		// Token: 0x0400BA01 RID: 47617
		[Token(Token = "0x4008ADA")]
		[FieldOffset(Offset = "0x18")]
		public CaptureBase _movieCapture;

		// Token: 0x0400BA02 RID: 47618
		[Token(Token = "0x4008ADB")]
		[FieldOffset(Offset = "0x20")]
		public bool _showUI;

		// Token: 0x0400BA03 RID: 47619
		[Token(Token = "0x4008ADC")]
		[FieldOffset(Offset = "0x21")]
		public bool _whenRecordingAutoHideUI;

		// Token: 0x0400BA04 RID: 47620
		[Token(Token = "0x4008ADD")]
		[FieldOffset(Offset = "0x28")]
		public GUISkin _guiSkin;

		// Token: 0x0400BA05 RID: 47621
		[Token(Token = "0x4008ADE")]
		[FieldOffset(Offset = "0x30")]
		private int _shownSection;

		// Token: 0x0400BA06 RID: 47622
		[Token(Token = "0x4008ADF")]
		[FieldOffset(Offset = "0x38")]
		private string[] _videoCodecNames;

		// Token: 0x0400BA07 RID: 47623
		[Token(Token = "0x4008AE0")]
		[FieldOffset(Offset = "0x40")]
		private string[] _audioCodecNames;

		// Token: 0x0400BA08 RID: 47624
		[Token(Token = "0x4008AE1")]
		[FieldOffset(Offset = "0x48")]
		private bool[] _videoCodecConfigurable;

		// Token: 0x0400BA09 RID: 47625
		[Token(Token = "0x4008AE2")]
		[FieldOffset(Offset = "0x50")]
		private bool[] _audioCodecConfigurable;

		// Token: 0x0400BA0A RID: 47626
		[Token(Token = "0x4008AE3")]
		[FieldOffset(Offset = "0x58")]
		private string[] _audioDeviceNames;

		// Token: 0x0400BA0B RID: 47627
		[Token(Token = "0x4008AE4")]
		[FieldOffset(Offset = "0x60")]
		private string[] _downScales;

		// Token: 0x0400BA0C RID: 47628
		[Token(Token = "0x4008AE5")]
		[FieldOffset(Offset = "0x68")]
		private string[] _frameRates;

		// Token: 0x0400BA0D RID: 47629
		[Token(Token = "0x4008AE6")]
		[FieldOffset(Offset = "0x70")]
		private string[] _outputType;

		// Token: 0x0400BA0E RID: 47630
		[Token(Token = "0x4008AE7")]
		[FieldOffset(Offset = "0x78")]
		private int _downScaleIndex;

		// Token: 0x0400BA0F RID: 47631
		[Token(Token = "0x4008AE8")]
		[FieldOffset(Offset = "0x7C")]
		private int _frameRateIndex;

		// Token: 0x0400BA10 RID: 47632
		[Token(Token = "0x4008AE9")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 _videoPos;

		// Token: 0x0400BA11 RID: 47633
		[Token(Token = "0x4008AEA")]
		[FieldOffset(Offset = "0x88")]
		private Vector2 _audioPos;

		// Token: 0x0400BA12 RID: 47634
		[Token(Token = "0x4008AEB")]
		[FieldOffset(Offset = "0x90")]
		private Vector2 _audioCodecPos;

		// Token: 0x0400BA13 RID: 47635
		[Token(Token = "0x4008AEC")]
		[FieldOffset(Offset = "0x98")]
		private long _lastFileSize;

		// Token: 0x0400BA14 RID: 47636
		[Token(Token = "0x4008AED")]
		[FieldOffset(Offset = "0xA0")]
		private uint _lastEncodedMinutes;

		// Token: 0x0400BA15 RID: 47637
		[Token(Token = "0x4008AEE")]
		[FieldOffset(Offset = "0xA4")]
		private uint _lastEncodedSeconds;

		// Token: 0x0400BA16 RID: 47638
		[Token(Token = "0x4008AEF")]
		[FieldOffset(Offset = "0xA8")]
		private uint _lastEncodedFrame;
	}
}
