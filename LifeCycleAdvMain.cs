using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020007E5 RID: 2021
[Token(Token = "0x200053D")]
public class LifeCycleAdvMain : MonoBehaviour
{
	// Token: 0x17000746 RID: 1862
	// (get) Token: 0x060034DC RID: 13532 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060034DD RID: 13533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005AF")]
	public AdvDialogControl advDialogControl
	{
		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x230BDA0", Offset = "0x230BEA1", VA = "0x230BDA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A53B0", Offset = "0x1A54B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x230BDB0", Offset = "0x230BEB1", VA = "0x230BDB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A53C0", Offset = "0x1A54C1")]
		private set
		{
		}
	}

	// Token: 0x060034DE RID: 13534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C00")]
	[Address(RVA = "0x230BDC0", Offset = "0x230BEC1", VA = "0x230BDC0")]
	private void Awake()
	{
	}

	// Token: 0x060034DF RID: 13535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C01")]
	[Address(RVA = "0x230BE90", Offset = "0x230BF91", VA = "0x230BE90")]
	public void ForceEnd()
	{
	}

	// Token: 0x060034E0 RID: 13536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C02")]
	[Address(RVA = "0x230BEB0", Offset = "0x230BFB1", VA = "0x230BEB0")]
	public void AdvStart(string filePath, NpcController npc)
	{
	}

	// Token: 0x060034E1 RID: 13537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C03")]
	[Address(RVA = "0x230C470", Offset = "0x230C571", VA = "0x230C470")]
	private void InitAdvStart(int npcId)
	{
	}

	// Token: 0x060034E2 RID: 13538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002C04")]
	[Address(RVA = "0x230C650", Offset = "0x230C751", VA = "0x230C650")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A53D0", Offset = "0x1A54D1")]
	private IEnumerator AdvStartWaitResult(string filePath, NpcController npc)
	{
		return null;
	}

	// Token: 0x060034E3 RID: 13539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C05")]
	[Address(RVA = "0x230C4F0", Offset = "0x230C5F1", VA = "0x230C4F0")]
	public void AdvStart2(TextAsset textobj, string filePath)
	{
	}

	// Token: 0x060034E4 RID: 13540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C06")]
	[Address(RVA = "0x230C940", Offset = "0x230CA41", VA = "0x230C940")]
	public void AdvEnd(NpcController npc)
	{
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002C07")]
	[Address(RVA = "0x230CA60", Offset = "0x230CB61", VA = "0x230CA60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5440", Offset = "0x1A5541")]
	public IEnumerator NpcMotion(NpcController npc, int motionId, float wait)
	{
		return null;
	}

	// Token: 0x060034E6 RID: 13542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C08")]
	[Address(RVA = "0x230CB30", Offset = "0x230CC31", VA = "0x230CB30")]
	public void AdvUpdate(NpcController npc)
	{
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x00012060 File Offset: 0x00010260
	[Token(Token = "0x6002C09")]
	[Address(RVA = "0x230CCD0", Offset = "0x230CDD1", VA = "0x230CCD0")]
	private LifeCycleAdvMain.WorkList ReadCommand(NpcController npc)
	{
		return LifeCycleAdvMain.WorkList.WORK_NONE;
	}

	// Token: 0x060034E8 RID: 13544 RVA: 0x00012078 File Offset: 0x00010278
	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x230CCE0", Offset = "0x230CDE1", VA = "0x230CCE0")]
	private LifeCycleAdvMain.WorkList ReadCommandCore(NpcController npc)
	{
		return LifeCycleAdvMain.WorkList.WORK_NONE;
	}

	// Token: 0x060034E9 RID: 13545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x230F330", Offset = "0x230F431", VA = "0x230F330")]
	public void onPauseEnd()
	{
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C0C")]
	[Address(RVA = "0x230F340", Offset = "0x230F441", VA = "0x230F340")]
	public void onTextWindowClick(int n)
	{
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x00012090 File Offset: 0x00010290
	[Token(Token = "0x6002C0D")]
	[Address(RVA = "0x230F360", Offset = "0x230F461", VA = "0x230F360")]
	public int OnSkip([Optional] bool? flag)
	{
		return 0;
	}

	// Token: 0x060034EC RID: 13548 RVA: 0x000120A8 File Offset: 0x000102A8
	[Token(Token = "0x6002C0E")]
	[Address(RVA = "0x230F430", Offset = "0x230F531", VA = "0x230F430")]
	public int GetSkipState()
	{
		return 0;
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002C0F")]
	[Address(RVA = "0x230F250", Offset = "0x230F351", VA = "0x230F250")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A54B0", Offset = "0x1A55B1")]
	public IEnumerator SetNpcPositionIdCoroutine(int npcId, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, bool relative = false)
	{
		return null;
	}

	// Token: 0x060034EE RID: 13550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C10")]
	[Address(RVA = "0x230F470", Offset = "0x230F571", VA = "0x230F470")]
	public LifeCycleAdvMain()
	{
	}

	// Token: 0x060034EF RID: 13551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C11")]
	[Address(RVA = "0x230F4F0", Offset = "0x230F5F1", VA = "0x230F4F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5520", Offset = "0x1A5621")]
	private void <ReadCommandCore>b__35_0()
	{
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C12")]
	[Address(RVA = "0x230F500", Offset = "0x230F601", VA = "0x230F500")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5530", Offset = "0x1A5631")]
	private void <ReadCommandCore>b__35_1()
	{
	}

	// Token: 0x04007876 RID: 30838
	[Token(Token = "0x4006D5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<LifeCycleAdvData> EventStartDataQueue;

	// Token: 0x04007877 RID: 30839
	[Token(Token = "0x4006D5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<LifeCycleAdvData> TmpList;

	// Token: 0x04007878 RID: 30840
	[Token(Token = "0x4006D5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16A040", Offset = "0x16A141")]
	private AdvDialogControl <advDialogControl>k__BackingField;

	// Token: 0x04007879 RID: 30841
	[Token(Token = "0x4006D5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ScriptWork scriptwork;

	// Token: 0x0400787A RID: 30842
	[Token(Token = "0x4006D60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ItemData BeforeEquipedTool;

	// Token: 0x0400787B RID: 30843
	[Token(Token = "0x4006D61")]
	private const int ScriptParamMax = 9;

	// Token: 0x0400787C RID: 30844
	[Token(Token = "0x4006D62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool IsForceText;

	// Token: 0x0400787D RID: 30845
	[Token(Token = "0x4006D63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private LifeCycleAdvMain.WorkList work;

	// Token: 0x0400787E RID: 30846
	[Token(Token = "0x4006D64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private stCommand_t cmd;

	// Token: 0x0400787F RID: 30847
	[Token(Token = "0x4006D65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private stCommand_t rndcmd;

	// Token: 0x04007880 RID: 30848
	[Token(Token = "0x4006D66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<stCommand_t> cmdList;

	// Token: 0x04007881 RID: 30849
	[Token(Token = "0x4006D67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isWait;

	// Token: 0x04007882 RID: 30850
	[Token(Token = "0x4006D68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float waitSec;

	// Token: 0x04007883 RID: 30851
	[Token(Token = "0x4006D69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float waitStartTime;

	// Token: 0x04007884 RID: 30852
	[Token(Token = "0x4006D6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int isSkip;

	// Token: 0x04007885 RID: 30853
	[Token(Token = "0x4006D6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool IsCmdWait;

	// Token: 0x04007886 RID: 30854
	[Token(Token = "0x4006D6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string seName;

	// Token: 0x04007887 RID: 30855
	[Token(Token = "0x4006D6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string voiceName;

	// Token: 0x04007888 RID: 30856
	[Token(Token = "0x4006D6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private NpcData npcData;

	// Token: 0x04007889 RID: 30857
	[Token(Token = "0x4006D6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int loaderId;

	// Token: 0x0400788A RID: 30858
	[Token(Token = "0x4006D70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool IsAdvStarted;

	// Token: 0x020007E6 RID: 2022
	[Token(Token = "0x200122D")]
	private enum WorkList
	{
		// Token: 0x0400788C RID: 30860
		[Token(Token = "0x4019780")]
		WORK_NONE,
		// Token: 0x0400788D RID: 30861
		[Token(Token = "0x4019781")]
		WORK_READ_TEXT,
		// Token: 0x0400788E RID: 30862
		[Token(Token = "0x4019782")]
		WORK_MESSAGE_WAIT,
		// Token: 0x0400788F RID: 30863
		[Token(Token = "0x4019783")]
		WORK_BU_WAIT,
		// Token: 0x04007890 RID: 30864
		[Token(Token = "0x4019784")]
		WORK_BG_WAIT,
		// Token: 0x04007891 RID: 30865
		[Token(Token = "0x4019785")]
		WORK_BGM_WAIT,
		// Token: 0x04007892 RID: 30866
		[Token(Token = "0x4019786")]
		WORK_BGM_STOP_WAIT,
		// Token: 0x04007893 RID: 30867
		[Token(Token = "0x4019787")]
		WORK_FADE_WAIT,
		// Token: 0x04007894 RID: 30868
		[Token(Token = "0x4019788")]
		WORK_WAIT,
		// Token: 0x04007895 RID: 30869
		[Token(Token = "0x4019789")]
		WORK_SELECT_WAIT,
		// Token: 0x04007896 RID: 30870
		[Token(Token = "0x401978A")]
		WORK_TIMELINE_WAIT,
		// Token: 0x04007897 RID: 30871
		[Token(Token = "0x401978B")]
		WORK_TIMELINE_END_WAIT,
		// Token: 0x04007898 RID: 30872
		[Token(Token = "0x401978C")]
		WORK_MOVIE_WAIT,
		// Token: 0x04007899 RID: 30873
		[Token(Token = "0x401978D")]
		WORK_PAUSE
	}

	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x200122E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158AE0", Offset = "0x158BE1")]
	private sealed class <>c__DisplayClass27_0
	{
		// Token: 0x060034F1 RID: 13553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C7")]
		[Address(RVA = "0x230C460", Offset = "0x230C561", VA = "0x230C460")]
		public <>c__DisplayClass27_0()
		{
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C8")]
		[Address(RVA = "0x230F510", Offset = "0x230F611", VA = "0x230F510")]
		internal void <AdvStart>b__0(AssetHandle<TextAsset> handle)
		{
		}

		// Token: 0x0400789A RID: 30874
		[Token(Token = "0x401978E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LifeCycleAdvMain <>4__this;

		// Token: 0x0400789B RID: 30875
		[Token(Token = "0x401978F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string filePath;
	}

	// Token: 0x020007E8 RID: 2024
	[Token(Token = "0x200122F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158AF0", Offset = "0x158BF1")]
	private sealed class <AdvStartWaitResult>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060034F3 RID: 13555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C9")]
		[Address(RVA = "0x230C910", Offset = "0x230CA11", VA = "0x230C910")]
		[DebuggerHidden]
		public <AdvStartWaitResult>d__29(int <>1__state)
		{
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CA")]
		[Address(RVA = "0x230F590", Offset = "0x230F691", VA = "0x230F590", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000120C0 File Offset: 0x000102C0
		[Token(Token = "0x60073CB")]
		[Address(RVA = "0x230F5A0", Offset = "0x230F6A1", VA = "0x230F5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D54")]
		private object Current
		{
			[Token(Token = "0x60073CC")]
			[Address(RVA = "0x230F760", Offset = "0x230F861", VA = "0x230F760", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CD")]
		[Address(RVA = "0x230F770", Offset = "0x230F871", VA = "0x230F770", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D55")]
		private object Current
		{
			[Token(Token = "0x60073CE")]
			[Address(RVA = "0x230F7D0", Offset = "0x230F8D1", VA = "0x230F7D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400789C RID: 30876
		[Token(Token = "0x4019790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400789D RID: 30877
		[Token(Token = "0x4019791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400789E RID: 30878
		[Token(Token = "0x4019792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LifeCycleAdvMain <>4__this;

		// Token: 0x0400789F RID: 30879
		[Token(Token = "0x4019793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filePath;

		// Token: 0x040078A0 RID: 30880
		[Token(Token = "0x4019794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextAsset <result>5__2;
	}

	// Token: 0x020007E9 RID: 2025
	[Token(Token = "0x2001230")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B00", Offset = "0x158C01")]
	private sealed class <NpcMotion>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060034F9 RID: 13561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CF")]
		[Address(RVA = "0x230CB00", Offset = "0x230CC01", VA = "0x230CB00")]
		[DebuggerHidden]
		public <NpcMotion>d__32(int <>1__state)
		{
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D0")]
		[Address(RVA = "0x230F7E0", Offset = "0x230F8E1", VA = "0x230F7E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x000120D8 File Offset: 0x000102D8
		[Token(Token = "0x60073D1")]
		[Address(RVA = "0x230F7F0", Offset = "0x230F8F1", VA = "0x230F7F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D56")]
		private object Current
		{
			[Token(Token = "0x60073D2")]
			[Address(RVA = "0x230F920", Offset = "0x230FA21", VA = "0x230F920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D3")]
		[Address(RVA = "0x230F930", Offset = "0x230FA31", VA = "0x230F930", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D57")]
		private object Current
		{
			[Token(Token = "0x60073D4")]
			[Address(RVA = "0x230F990", Offset = "0x230FA91", VA = "0x230F990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040078A1 RID: 30881
		[Token(Token = "0x4019795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040078A2 RID: 30882
		[Token(Token = "0x4019796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040078A3 RID: 30883
		[Token(Token = "0x4019797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcController npc;

		// Token: 0x040078A4 RID: 30884
		[Token(Token = "0x4019798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float wait;

		// Token: 0x040078A5 RID: 30885
		[Token(Token = "0x4019799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int motionId;
	}

	// Token: 0x020007EA RID: 2026
	[Token(Token = "0x2001231")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B10", Offset = "0x158C11")]
	private sealed class <SetNpcPositionIdCoroutine>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060034FF RID: 13567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D5")]
		[Address(RVA = "0x230F440", Offset = "0x230F541", VA = "0x230F440")]
		[DebuggerHidden]
		public <SetNpcPositionIdCoroutine>d__40(int <>1__state)
		{
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D6")]
		[Address(RVA = "0x230F9A0", Offset = "0x230FAA1", VA = "0x230F9A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000120F0 File Offset: 0x000102F0
		[Token(Token = "0x60073D7")]
		[Address(RVA = "0x230F9B0", Offset = "0x230FAB1", VA = "0x230F9B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D58")]
		private object Current
		{
			[Token(Token = "0x60073D8")]
			[Address(RVA = "0x230FDA0", Offset = "0x230FEA1", VA = "0x230FDA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D9")]
		[Address(RVA = "0x230FDB0", Offset = "0x230FEB1", VA = "0x230FDB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D59")]
		private object Current
		{
			[Token(Token = "0x60073DA")]
			[Address(RVA = "0x230FE10", Offset = "0x230FF11", VA = "0x230FE10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040078A6 RID: 30886
		[Token(Token = "0x401979A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040078A7 RID: 30887
		[Token(Token = "0x401979B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040078A8 RID: 30888
		[Token(Token = "0x401979C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wait;

		// Token: 0x040078A9 RID: 30889
		[Token(Token = "0x401979D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int npcId;

		// Token: 0x040078AA RID: 30890
		[Token(Token = "0x401979E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float posX;

		// Token: 0x040078AB RID: 30891
		[Token(Token = "0x401979F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float posY;

		// Token: 0x040078AC RID: 30892
		[Token(Token = "0x40197A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float posZ;

		// Token: 0x040078AD RID: 30893
		[Token(Token = "0x40197A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool relative;

		// Token: 0x040078AE RID: 30894
		[Token(Token = "0x40197A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rotX;

		// Token: 0x040078AF RID: 30895
		[Token(Token = "0x40197A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float rotY;

		// Token: 0x040078B0 RID: 30896
		[Token(Token = "0x40197A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotZ;
	}
}
