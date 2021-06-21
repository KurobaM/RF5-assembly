using System;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020002EF RID: 751
[Token(Token = "0x200024A")]
public class RF5MoviePlayer : SingletonMonoBehaviour<RF5MoviePlayer>
{
	// Token: 0x17000387 RID: 903
	// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00009078 File Offset: 0x00007278
	// (set) Token: 0x060013E2 RID: 5090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034F")]
	private MovieID CurrentMovie
	{
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x2174D70", Offset = "0x2174E71", VA = "0x2174D70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CB20", Offset = "0x19CC21")]
		get
		{
			return MovieID.Opening;
		}
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x2174D80", Offset = "0x2174E81", VA = "0x2174D80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CB30", Offset = "0x19CC31")]
		set
		{
		}
	}

	// Token: 0x17000388 RID: 904
	// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060013E4 RID: 5092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000350")]
	private UnityAction CallBack
	{
		[Token(Token = "0x6001212")]
		[Address(RVA = "0x2174D90", Offset = "0x2174E91", VA = "0x2174D90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CB40", Offset = "0x19CC41")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x2174DA0", Offset = "0x2174EA1", VA = "0x2174DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CB50", Offset = "0x19CC51")]
		set
		{
		}
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001214")]
	[Address(RVA = "0x2174DB0", Offset = "0x2174EB1", VA = "0x2174DB0")]
	public static void Play(MovieID id, [Optional] UnityAction callback)
	{
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001215")]
	[Address(RVA = "0x21751F0", Offset = "0x21752F1", VA = "0x21751F0")]
	public static void Pause()
	{
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001216")]
	[Address(RVA = "0x2175280", Offset = "0x2175381", VA = "0x2175280")]
	public static void Resume()
	{
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x21752F0", Offset = "0x21753F1", VA = "0x21752F0")]
	public static void Stop()
	{
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x2175370", Offset = "0x2175471", VA = "0x2175370")]
	private void None_Enter()
	{
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001219")]
	[Address(RVA = "0x2175380", Offset = "0x2175481", VA = "0x2175380")]
	private void None_Update()
	{
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x2175390", Offset = "0x2175491", VA = "0x2175390")]
	private void Load_Enter()
	{
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121B")]
	[Address(RVA = "0x21754C0", Offset = "0x21755C1", VA = "0x21754C0")]
	private void Load_Update()
	{
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121C")]
	[Address(RVA = "0x21755B0", Offset = "0x21756B1", VA = "0x21755B0")]
	private void WaitPlay_Enter()
	{
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x21756F0", Offset = "0x21757F1", VA = "0x21756F0")]
	private void WaitPlay_Update()
	{
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x2175720", Offset = "0x2175821", VA = "0x2175720")]
	private void Play_Enter()
	{
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121F")]
	[Address(RVA = "0x2175B50", Offset = "0x2175C51", VA = "0x2175B50")]
	private void Play_Update()
	{
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001220")]
	[Address(RVA = "0x2175BD0", Offset = "0x2175CD1", VA = "0x2175BD0")]
	private void Pause_Enter()
	{
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001221")]
	[Address(RVA = "0x2175BF0", Offset = "0x2175CF1", VA = "0x2175BF0")]
	private void Pause_Update()
	{
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001222")]
	[Address(RVA = "0x2175C50", Offset = "0x2175D51", VA = "0x2175C50")]
	private void Done_Enter()
	{
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001223")]
	[Address(RVA = "0x2175EC0", Offset = "0x2175FC1", VA = "0x2175EC0")]
	private void Done_Update()
	{
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001224")]
	[Address(RVA = "0x2175180", Offset = "0x2175281", VA = "0x2175180")]
	private void ChangeState(RF5MoviePlayer.State state)
	{
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001225")]
	[Address(RVA = "0x2175ED0", Offset = "0x2175FD1", VA = "0x2175ED0")]
	private void Update()
	{
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001226")]
	[Address(RVA = "0x2176000", Offset = "0x2176101", VA = "0x2176000", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001227")]
	[Address(RVA = "0x2176150", Offset = "0x2176251", VA = "0x2176150")]
	private void Start()
	{
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001228")]
	[Address(RVA = "0x2176170", Offset = "0x2176271", VA = "0x2176170")]
	public RF5MoviePlayer()
	{
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122A")]
	[Address(RVA = "0x2176200", Offset = "0x2176301", VA = "0x2176200")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CB60", Offset = "0x19CC61")]
	private void <WaitPlay_Enter>b__25_0()
	{
	}

	// Token: 0x04000B33 RID: 2867
	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RF5MoviePlayer.State m_State;

	// Token: 0x04000B34 RID: 2868
	[Token(Token = "0x40008C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private RF5MoviePlayer.State m_PrevState;

	// Token: 0x04000B35 RID: 2869
	[Token(Token = "0x40008C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_Elapsed;

	// Token: 0x04000B36 RID: 2870
	[Token(Token = "0x40008C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F600", Offset = "0x15F701")]
	private MovieID <CurrentMovie>k__BackingField;

	// Token: 0x04000B37 RID: 2871
	[Token(Token = "0x40008C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SEController[] SEControllers;

	// Token: 0x04000B38 RID: 2872
	[Token(Token = "0x40008C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private MoviePlayer MoviePlayer;

	// Token: 0x04000B39 RID: 2873
	[Token(Token = "0x40008C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F620", Offset = "0x15F721")]
	private UnityAction <CallBack>k__BackingField;

	// Token: 0x04000B3A RID: 2874
	[Token(Token = "0x40008C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MovieRoomDataTable MovieRoomDataTable;

	// Token: 0x04000B3B RID: 2875
	[Token(Token = "0x40008C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool HasSystemPause;

	// Token: 0x04000B3C RID: 2876
	[Token(Token = "0x40008CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool FirstFrameReady;

	// Token: 0x04000B3D RID: 2877
	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int wait_frame;

	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x200102E")]
	private enum State
	{
		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x4018EE6")]
		None,
		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4018EE7")]
		Load,
		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4018EE8")]
		WaitPlay,
		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4018EE9")]
		Play,
		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4018EEA")]
		Pause,
		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4018EEB")]
		Done
	}
}
