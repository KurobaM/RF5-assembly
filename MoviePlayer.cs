using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Switch;
using UnityEngine.UI;

// Token: 0x020002EB RID: 747
[Token(Token = "0x2000249")]
public class MoviePlayer : SingletonMonoBehaviour<MoviePlayer>
{
	// Token: 0x17000384 RID: 900
	// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00008F88 File Offset: 0x00007188
	// (set) Token: 0x060013C7 RID: 5063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034C")]
	public bool IsDisplaySubtitle
	{
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x1E12110", Offset = "0x1E12211", VA = "0x1E12110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CB00", Offset = "0x19CC01")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x1E12120", Offset = "0x1E12221", VA = "0x1E12120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CB10", Offset = "0x19CC11")]
		set
		{
		}
	}

	// Token: 0x17000385 RID: 901
	// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00008FA0 File Offset: 0x000071A0
	// (set) Token: 0x060013C9 RID: 5065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034D")]
	public bool Visible
	{
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x1E12130", Offset = "0x1E12231", VA = "0x1E12130")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x1E12150", Offset = "0x1E12251", VA = "0x1E12150")]
		set
		{
		}
	}

	// Token: 0x17000386 RID: 902
	// (get) Token: 0x060013CA RID: 5066 RVA: 0x00008FB8 File Offset: 0x000071B8
	// (set) Token: 0x060013CB RID: 5067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034E")]
	public bool EnableListener
	{
		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x1E121C0", Offset = "0x1E122C1", VA = "0x1E121C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x1E121E0", Offset = "0x1E122E1", VA = "0x1E121E0")]
		set
		{
		}
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x00008FD0 File Offset: 0x000071D0
	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x1E12200", Offset = "0x1E12301", VA = "0x1E12200")]
	public bool Initialize(int screenWidth = 1920, int screenHeight = 1080)
	{
		return default(bool);
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x00008FE8 File Offset: 0x000071E8
	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x1E12520", Offset = "0x1E12621", VA = "0x1E12520")]
	public bool SetUp(string filepath, [Optional] List<MoviePlayer.SUBTITLEDATA> subtitledatas, bool isLoop = false)
	{
		return default(bool);
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001200")]
	[Address(RVA = "0x1E127E0", Offset = "0x1E128E1", VA = "0x1E127E0")]
	public void Play(float jumptosecond = 0f)
	{
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001201")]
	[Address(RVA = "0x1E12900", Offset = "0x1E12A01", VA = "0x1E12900")]
	public void Pause(bool value)
	{
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001202")]
	[Address(RVA = "0x1E12920", Offset = "0x1E12A21", VA = "0x1E12920")]
	public void Stop()
	{
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00009000 File Offset: 0x00007200
	[Token(Token = "0x6001203")]
	[Address(RVA = "0x1E129C0", Offset = "0x1E12AC1", VA = "0x1E129C0")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x00009018 File Offset: 0x00007218
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x1E12A40", Offset = "0x1E12B41", VA = "0x1E12A40")]
	public float GetTime()
	{
		return 0f;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x00009030 File Offset: 0x00007230
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x1E12A60", Offset = "0x1E12B61", VA = "0x1E12A60")]
	public float GetMovieTimeLength()
	{
		return 0f;
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001206")]
	[Address(RVA = "0x1E12A80", Offset = "0x1E12B81", VA = "0x1E12A80")]
	public void Terminate()
	{
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x00009048 File Offset: 0x00007248
	[Token(Token = "0x6001207")]
	[Address(RVA = "0x1E12420", Offset = "0x1E12521", VA = "0x1E12420")]
	private static int Gcd(int a, int b)
	{
		return 0;
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001208")]
	[Address(RVA = "0x1E12B30", Offset = "0x1E12C31", VA = "0x1E12B30")]
	private void loopPointMovieEvent()
	{
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001209")]
	[Address(RVA = "0x1E12B40", Offset = "0x1E12C41", VA = "0x1E12B40")]
	private void OnMovieEvent(SwitchVideoPlayer.Event FMVevent)
	{
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120A")]
	[Address(RVA = "0x1E12C80", Offset = "0x1E12D81", VA = "0x1E12C80")]
	public void PlaySubtitle(int MovieId)
	{
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120B")]
	[Address(RVA = "0x1E12CF0", Offset = "0x1E12DF1", VA = "0x1E12CF0")]
	private void Start()
	{
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x1E12D60", Offset = "0x1E12E61", VA = "0x1E12D60")]
	private void Update()
	{
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x1E12E90", Offset = "0x1E12F91", VA = "0x1E12E90")]
	private void OnPreRender()
	{
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x1E12EB0", Offset = "0x1E12FB1", VA = "0x1E12EB0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x1E12EC0", Offset = "0x1E12FC1", VA = "0x1E12EC0")]
	public MoviePlayer()
	{
	}

	// Token: 0x04000B15 RID: 2837
	[Token(Token = "0x40008AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string MoviePath;

	// Token: 0x04000B16 RID: 2838
	[Token(Token = "0x40008AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Camera MovieCamera;

	// Token: 0x04000B17 RID: 2839
	[Token(Token = "0x40008AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioListener MovieListener;

	// Token: 0x04000B18 RID: 2840
	[Token(Token = "0x40008B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Renderer MovieRenderer;

	// Token: 0x04000B19 RID: 2841
	[Token(Token = "0x40008B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text Subtitle;

	// Token: 0x04000B1A RID: 2842
	[Token(Token = "0x40008B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject ScreenObj;

	// Token: 0x04000B1B RID: 2843
	[Token(Token = "0x40008B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject SubtitlesObj;

	// Token: 0x04000B1C RID: 2844
	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SwitchVideoPlayer video;

	// Token: 0x04000B1D RID: 2845
	[Token(Token = "0x40008B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private SwitchFMVTexture lumaTex;

	// Token: 0x04000B1E RID: 2846
	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private SwitchFMVTexture chromaTex;

	// Token: 0x04000B1F RID: 2847
	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly float movieScreenAspectWidth;

	// Token: 0x04000B20 RID: 2848
	[Token(Token = "0x40008B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private readonly float movieScreenAspectHeight;

	// Token: 0x04000B21 RID: 2849
	[Token(Token = "0x40008B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isInitialized;

	// Token: 0x04000B22 RID: 2850
	[Token(Token = "0x40008BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<MoviePlayer.SUBTITLEDATA> subTitleDatas;

	// Token: 0x04000B23 RID: 2851
	[Token(Token = "0x40008BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int displaySubtitleCount;

	// Token: 0x04000B24 RID: 2852
	[Token(Token = "0x40008BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F5F0", Offset = "0x15F6F1")]
	private bool <IsDisplaySubtitle>k__BackingField;

	// Token: 0x04000B25 RID: 2853
	[Token(Token = "0x40008BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UnityAction CreatedCallBack;

	// Token: 0x04000B26 RID: 2854
	[Token(Token = "0x40008BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public UnityAction FirstFrameReadyCallBack;

	// Token: 0x04000B27 RID: 2855
	[Token(Token = "0x40008BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public UnityAction LoopPointCallBack;

	// Token: 0x04000B28 RID: 2856
	[Token(Token = "0x40008C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public UnityAction EndOfStreamCallBack;

	// Token: 0x020002EC RID: 748
	[Token(Token = "0x200102B")]
	public enum MovieEvent
	{
		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4018EDC")]
		None,
		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4018EDD")]
		Created,
		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4018EDE")]
		FirstFrameReady = 4,
		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4018EDF")]
		LoopPointReached = 3,
		// Token: 0x04000B2E RID: 2862
		[Token(Token = "0x4018EE0")]
		EndOfStream = 2
	}

	// Token: 0x020002ED RID: 749
	[Token(Token = "0x200102C")]
	public struct SUBTITLEDATA
	{
		// Token: 0x060013DE RID: 5086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB9")]
		[Address(RVA = "0x2DE0E0", Offset = "0x2DE1E1", VA = "0x2DE0E0")]
		public SUBTITLEDATA(int startTime, int displayTime, string subtitle)
		{
		}

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4018EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int StartTime;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4018EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int DisplayTime;

		// Token: 0x04000B31 RID: 2865
		[Token(Token = "0x4018EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Subtitle;
	}

	// Token: 0x020002EE RID: 750
	[Token(Token = "0x200102D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1573A0", Offset = "0x1574A1")]
	private sealed class <>c__DisplayClass40_0
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBA")]
		[Address(RVA = "0x1E12B20", Offset = "0x1E12C21", VA = "0x1E12B20")]
		public <>c__DisplayClass40_0()
		{
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x6006CBB")]
		[Address(RVA = "0x1E12F20", Offset = "0x1E13021", VA = "0x1E12F20")]
		internal int <Gcd>b__0(int x, int y)
		{
			return 0;
		}

		// Token: 0x04000B32 RID: 2866
		[Token(Token = "0x4018EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Func<int, int, int> gcd;
	}
}
